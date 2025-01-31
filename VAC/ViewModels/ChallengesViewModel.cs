using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VAC.Interfaces;

namespace VAC.ViewModels
{
    partial class ChallengesViewModel : ObservableObject
    {
        private readonly Random _random = new Random();
        public List<IChallenge> Catalog => GetImplementations<IChallenge>();

        [ObservableProperty]
        private List<IChallenge>? _challenges;

        [ObservableProperty]
        private int _challengesCount;

        [ObservableProperty]
        private uint _challengesScore;

        public List<IChallenge> GetImplementations<TInterface>()
        {
            List<IChallenge> challenges = new List<IChallenge>();
            IEnumerable<Type> instances = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(TInterface).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (Type instance in instances)
            {
                challenges.Add((IChallenge)Activator.CreateInstance(instance));
            }

            return challenges;
        }

        [RelayCommand]
        private void Generate()
        {
            List<int> indexes = Enumerable.Range(0, Catalog.Count)
                .OrderBy(_ => _random.Next())
                .Take(ChallengesCount)
                .ToList();

            Challenges = indexes.Select(index => Catalog[index]).ToList();
        }

        public ChallengesViewModel()
        {
            ChallengesCount = 3;

            Generate();
        }
    }
}
