using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI_001_Repository.Models
{
    /// <summary>
    /// 1) Create Models
    /// 2) Install packages (3-4)
    /// 3) Create DatabaseContext class
    /// 4) Program.cs add our Database service and connection string
    /// 5) go to console => add-migration name
    /// 6) go to console => database-update
    /// 7) done
    /// </summary>
    public class Samurai
    {
        //Entity Framework works with PK... Id or ClassName+Id

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public int Age { get; set; }
    }
}