using System;
using System.Collections.Generic;
//#Additional Namespaces
using System.Data.Entity;
using NorthwindSystem.Entities;
//#end
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSystem.DAL
{
    // restrct axccess to this class ONLY other classes
    //      within this library has access priviledge security measures
    // connect this class to EntityFramework by inheriting DbConttext
    // security measure
    internal class NorthwindSystemContext:DbContext
    {
        // you will need a constructor that passes the conncection
        //      string name to Entity Framework via inherited class DbContext
        /// base refers to the:DbCOntext

        public NorthwindSystemContext() : base("NWDB")
        {
            
        }
        // properties to interact with EntityFramework
        // these properties represent the whole and all data
        // of the sql database
        public DbSet<Product> Products{ get; set; }

        public DbSet<Region> Region { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
