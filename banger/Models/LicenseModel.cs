
using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class LicenseModel
    {
       
        public string Name { get; set; }

        public string LicenseNo { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
