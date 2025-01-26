using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.ViewModels
{
    partial class CharactersViewModel : ObservableObject
    {
        private List<ICharacter> catalog => new List<ICharacter>()
        {
            new Models.Characters.Omen(),
            new Models.Characters.Jett(),
        };

        private Random random => new Random();

        [ObservableProperty]
        private ICharacter? _character;

        [RelayCommand]
        private void Generate()
        {
            int index = random.Next(0, catalog.Count);

            Character = catalog[index];
        }
    }
}
