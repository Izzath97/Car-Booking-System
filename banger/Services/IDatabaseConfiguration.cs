using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Services
{
  public   interface IDatabaseConfiguration
    {
        string Server { get; }

        string Database { get; }

        string userid { get; }
        string password { get; }
        string Trusted_Connection { get; set; }
        string MultipleActiveResultSets { get; set; }
    }
}
