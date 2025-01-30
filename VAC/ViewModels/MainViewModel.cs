using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace VAC.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private Version? version;
        private Random _random => new Random();

        [ObservableProperty]
        private string? _Title;

        private void SoundPlayer()
        {
            int luck = 2;

            if (_random.Next(0, 101) <= luck)
            {
                using (UnmanagedMemoryStream stream = Properties.Resources.Kayo)
                {
                    SoundPlayer player = new SoundPlayer(stream);
                    player.Play();
                }
            }
        }

        private void LoadVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version = assembly.GetName().Version;
        }

        public MainViewModel()
        {
            LoadVersion();

            Title = $"Valorant Assistant Companion {version}";

            SoundPlayer();
        }
    }
}
