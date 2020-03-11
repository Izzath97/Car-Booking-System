using banger.Models;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Mappers
{
    public sealed class LicenseMap :ClassMap<LicenseModel>
    {
        public LicenseMap() {
            Map(m => m.Name).Name(Constants.CsvHeaders.Name);
            Map(m => m.LicenseNo).Name(Constants.CsvHeaders.LicenseNo);

        }
  
    }
}
