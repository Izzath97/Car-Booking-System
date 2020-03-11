using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Services
{
    public class DatabaseConfiguration : IDatabaseConfiguration
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string userid { get; set; }

        public string password { get; set; }

        public string Trusted_Connection { get; set; }
        public string MultipleActiveResultSets { get; set; }
    }
}
