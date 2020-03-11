using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using banger.Models;
using System.Threading.Tasks;

namespace banger.Services
{

    public class InsuranceService : IInsuranceService
    {

        public bool checkNIC(string nic)
        {

            bool flag = false;
            try {
                using (SqlConnection connection = new SqlConnection(
                   "Server=.;Database=insurance;user id=izzath;password=izzath;Trusted_Connection=True;MultipleActiveResultSets=True;"))
                {

                    SqlCommand command = new SqlCommand("select * from [insurance].[dbo].[users]", connection);

                    command.Connection.Open();

                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            if (nic == rdr.GetString(2)) {
                                flag = true;
                            }


                        }
                    }

                }


              
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection Error");

            }
            return flag;
        }


    }
    }

