using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VAC.Interfaces;

namespace VAC.ViewModels
{
    partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _welcomeMessage;

        public HomeViewModel()
        {
            WelcomeMessage = $"Welcome {Environment.UserName}";
        }
    }
}
