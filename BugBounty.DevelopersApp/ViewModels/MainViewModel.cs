using BugBounty.DevelopersApp.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _selectedViewModel;
        public bool IsFormViewSelected => SelectedViewModel == FormViewModel;

        public MainViewModel(BugViewModel bugViewModel, FormViewModel formViewModel)
        {
            BugViewModel = bugViewModel;
            FormViewModel = formViewModel;
            SelectedViewModel = BugViewModel;
            AddNewBugCommand = new DelegateCommand(AddNewBug, canAddNewBug);
            CloseFormViewCommand = new DelegateCommand(CloseFormView);
        }

        private async void CloseFormView(object? parameter)
        {
            if (SelectedViewModel != BugViewModel)
            {
                SelectedViewModel = parameter as ViewModelBase;
                await LoadAsync();
                /*
                 * Raise AddNewBugCommand to notify UI
                 * that SelectedViewModel has changed
                 */
                AddNewBugCommand.RaisedCanExecuteChanged();
            }
        }

        private bool canAddNewBug(object? parameter) => SelectedViewModel != FormViewModel;

        private async void AddNewBug(object? parameter)
        {
            if (SelectedViewModel != FormViewModel)
            {
                SelectedViewModel = parameter as ViewModelBase;
                await LoadAsync();
                AddNewBugCommand.RaisedCanExecuteChanged();
            }
        }

        public ViewModelBase? SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(IsFormViewSelected));
            }
        }

        public DelegateCommand AddNewBugCommand { get; }
        public DelegateCommand CloseFormViewCommand { get; }
        public BugViewModel BugViewModel { get; }
        public FormViewModel FormViewModel { get; }

        public override async Task LoadAsync()
        {
            if(SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }
    }
}
