using MirokuExample.CodeFirstDB;
using Sap.Data.SQLAnywhere;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirokuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.DefaultConnectionFactory = new SAConnectionFactory();
            Database.SetInitializer<CodingFirstContext>(
                new DropCreateDatabaseAlways<CodingFirstContext>());

            using (var db = new CodingFirstContext(
                "DSN=Miroku"))
            {
                var query = db.Products.ToList();
            }
        }
    }
}
