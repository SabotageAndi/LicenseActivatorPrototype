using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LicenseActivatorPrototype.Helper;

namespace LicenseActivatorPrototype.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            RegisterLicenseCommand = new DelegateCommand(() => RegisterLicense());
            UnRegisterLicenseCommand = new DelegateCommand(() => UnregisterLicense());
        }

        public ICommand RegisterLicenseCommand { get; }
        public DelegateCommand UnRegisterLicenseCommand { get; }

        public void RegisterLicense()
        { }

        private void UnregisterLicense()
        {
        }

    }
}