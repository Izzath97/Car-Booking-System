using banger.Mappers;
using banger.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banger.Services
{
    public class CvsParserService
    {

        public List<string> ReadCvsFileToLicenseModel(string path)
        {
            try
            {
                List<string> names = new List<string>();
                List<string> licenseNo = new List<string>();
                using (var reader = new StreamReader(path, Encoding.Default))
                    while (!reader.EndOfStream)
                    {   
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        names.Add(values[0]);
                        licenseNo.Add(values[1]);
                    }
                    return licenseNo;               
            }

           

            catch (UnauthorizedAccessException e) {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e) {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
