using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /*
         * Any Changes inflicted will reflec in the UI
         */

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void RaisePropertyChanged([CallerMemberName] string? property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public virtual Task LoadAsync()
        {
            return Task.CompletedTask;
        }
    }
}
