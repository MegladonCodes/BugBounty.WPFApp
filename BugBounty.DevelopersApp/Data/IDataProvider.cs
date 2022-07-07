using BugBounty.DevelopersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBounty.DevelopersApp.Data
{
    public interface IDataProvider
    {
        //Specify methods to use with data
        public Task<IEnumerable<BugModel>?> GetAll();
    }
}
