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
    partial class MapsViewModel : ObservableObject
    {
        private List<IMap> catalog => new List<IMap>()
        {
            new Models.Maps.Ascent(),
            new Models.Maps.Bind(),
            new Models.Maps.Breeze(),
            new Models.Maps.Haven(),
            new Models.Maps.Icebox(),
            new Models.Maps.Lotus(),
            new Models.Maps.Pearl(),
            new Models.Maps.Split(),
            new Models.Maps.Sunset()
        };

        private Random random => new Random();

        [ObservableProperty]
        private IMap? _map;

        [RelayCommand]
        private void Generate()
        {
            int index = random.Next(0, catalog.Count);

            Map = catalog[index];
        }
    }
}
