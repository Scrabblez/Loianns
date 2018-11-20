using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism;
using Prism.Commands;

namespace SoulSong_Analysis.ViewModels
{
    class InstallScreenVM : BaseViewModel
    {
        public InstallScreenVM()
        {
            InstallButtonCommand = new DelegateCommand(Install);
            CancelButtonCommand = new DelegateCommand(Cancel);
        }
        public DelegateCommand InstallButtonCommand { get; private set; }
        public DelegateCommand CancelButtonCommand { get; private set; }

        public void Install()
        {
            MessageBox.Show("I did a thing.");
        }

        public void Cancel()
        {
            App.Current.Shutdown();
        }
    }
}
