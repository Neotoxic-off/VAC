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
    partial class MapsViewModel : ObservableObject
    {
        public List<IMap> catalog => GetImplementations<IMap>();

        public List<IMap> GetImplementations<TInterface>()
        {
            List<IMap> maps = new List<IMap>();
            IEnumerable<Type> instances = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(TInterface).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (Type instance in instances)
            {
                maps.Add((IMap)Activator.CreateInstance(instance));
            }

            return maps;
        }

        private Random random => new Random();

        [ObservableProperty]
        private List<IMap>? _map;

        [ObservableProperty]
        private List<MapFilter>? _filters;

        [RelayCommand]
        private void Generate()
        {
            Map = new List<IMap>()
            {
                Filters.Where(map => map.Selected == true)
                .OrderBy(x => random.Next())
                .Take(1)
                .First().Map
            };
        }

        private List<MapFilter> GetFilters()
        {
            List<MapFilter> filters = new List<MapFilter>();

            foreach (IMap map in catalog)
            {
                filters.Add(new MapFilter(map, true));
            }

            return filters;
        }

        public MapsViewModel()
        {
            Filters = GetFilters();
            Generate();
        }
    }
}
