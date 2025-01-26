using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private Version? version;

        [ObservableProperty]
        private string? _Title;

        public MainViewModel()
        {
            version = new Version(0, 1, 0, 0);
            Title = $"Valorant Assistant Companion {version}";
        }
    }
}
