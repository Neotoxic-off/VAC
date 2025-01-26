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
        private Random random => new Random();
        public List<IChallenge> catalog => GetImplementations<IChallenge>();

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

        [ObservableProperty]
        private List<IChallenge>? _challenges;

        [ObservableProperty]
        private int _challengesCount;

        [RelayCommand]
        private void Generate()
        {
            List<int> indexes = Enumerable.Range(0, catalog.Count)
                .OrderBy(x => random.Next())
                .Take(ChallengesCount)
                .ToList();
            Challenges = new List<IChallenge>();

            foreach (int index in indexes)
            {
                Challenges.Add(catalog[index]);
            }
        }

        public ChallengesViewModel()
        {
            ChallengesCount = 3;

            Generate();
        }
    }
}