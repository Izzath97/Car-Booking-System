using banger.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Services
{
   public  interface IWebService
    {
        Task<List<WebModel>>  WebScraping();


    }
}
