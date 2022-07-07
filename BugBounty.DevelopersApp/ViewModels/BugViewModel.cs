using BugBounty.DevelopersApp.Data;
using BugBounty.DevelopersApp.Delegates;
using BugBounty.DevelopersApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.ViewModels
{
    public class BugViewModel : ViewModelBase
    {
        private readonly IDataProvider bugDataProvider;

        /*
        * -> View model interacts with our UI
        * -> Implement our methods, fields and properties here
        */

        public BugViewModel(IDataProvider BugDataProvider)
        {
            bugDataProvider = BugDataProvider;
        }

        public ObservableCollection<BugModel> BugList { get; } = new();

        public override async Task LoadAsync()
        {
            if (BugList.Any()) { return; }

            var bugs = await bugDataProvider.GetAll();

            if (bugs is not null)
            {
                foreach (var bug in bugs)
                {
                    BugList.Add(bug);
                }
            }
        }

    }
}
