using BugBounty.DevelopersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.Data
{
    public class BugDataProvider : IDataProvider
    {
        /*
         * Temporary -> Load data from a set list
         */
        List<BugModel> BugData =  new List<BugModel>
            {
                new BugModel{ BugId=001, ShortDesc="User age is saved as double what is entered", Location="/UI/UserRegistration.cs"
                ,Assignee="Josh",IsResolved=true },
                new BugModel
                { BugId=002, ShortDesc="Form does not load", Location="/Forms/BrokerForms.cs"
                 ,Assignee="Mike",   IsResolved=false },
                new BugModel
                {
                    BugId = 003,
                    ShortDesc = "Back button greyed out",
                    Location = "/BI/BusinessAnalysis.cs",
                    Assignee = "Robert",
                    IsResolved = true
                },
            };
        public async Task<IEnumerable<BugModel>?> GetAll()
        {
            await Task.Delay(100);

            return BugData;
        }
    }
}
