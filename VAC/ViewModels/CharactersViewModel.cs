using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;
using VAC.Models;

namespace VAC.ViewModels
{
    partial class CharactersViewModel : ObservableObject
    {
        private Random random => new Random();
        public List<ICharacter> catalog => GetImplementations<ICharacter>();

        public List<ICharacter> GetImplementations<TInterface>()
        {
            List<ICharacter> characters = new List<ICharacter>();
            IEnumerable<Type> instances = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(TInterface).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (Type instance in instances)
            {
                characters.Add((ICharacter)Activator.CreateInstance(instance));
            }

            return characters;
        }

        [ObservableProperty]
        private List<ICharacter>? _characters;

        [ObservableProperty]
        private int _players;

        [ObservableProperty]
        private List<CharacterTypeFilter>? _filters;

        [RelayCommand]
        private void Generate()
        {
            List<ICharacter> filteredCharacters = new List<ICharacter>();

            foreach (var filter in Filters)
            {
                if (filter.Selected == true)
                {
                    filteredCharacters.AddRange(
                        catalog.Where(c => c.Type == filter.Type).ToList()
                    );
                }
            }

            if (filteredCharacters.Count == 0)
            {
                return;
            }

            Characters = filteredCharacters
                .OrderBy(x => random.Next())
                .Take(Players)
                .ToList();
        }

        public CharactersViewModel()
        {
            Players = 5;
            Filters = new List<CharacterTypeFilter>()
            {
                new CharacterTypeFilter(ICharacter.Types.Sentinel, true),
                new CharacterTypeFilter(ICharacter.Types.Duelist, true),
                new CharacterTypeFilter(ICharacter.Types.Controller, true),
                new CharacterTypeFilter(ICharacter.Types.Initiator, true)
            };

            Generate();
        }
    }
}
