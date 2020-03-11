using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using banger.Models;
using banger.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace banger.Controllers
{
    [Route("User")]

    public class UserController : Controller
    {
       
        private readonly dbContext _context;
        private readonly IWebService _webService ;
        public UserController(dbContext context,IWebService webService)
        {
            _context = context;
            _webService = webService;
           
        }
        [Route("")]
        [Route("Home")]
        [Route("~/")]
        //public IActionResult Home() {

        //    var json = JsonConvert.SerializeObject(_context.Users);
        //    var vehicles = _context.Users.ToList();
        //    ViewBag.User = _context.Users.ToListAsync();
        //    var value = _context.Users.ToListAsync();
        //    return View(_context.Users.ToListAsync());
        //}
        public async Task<IActionResult> Home()
        {
   
            ViewBag.data = await _context.Vehicle.ToListAsync(); 
            ViewBag.addOn= await _context.AddOns.ToListAsync();
            ViewBag.email = HttpContext.Session.GetString("email");
            return View();
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            string aa = "";
    
          
            string bb = aa;
            string vv;

            byte[] data1 = Convert.FromBase64String(bb);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("hash"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data1, 0, data1.Length);
                    vv = UTF8Encoding.UTF8.GetString(results);
                }
            }
            string cc = vv;

            //string aa = Encrypt("aaa","Insaf");
            //string bbb = Decrypt("aaa",aa);
            // ViewBag.email = HttpContext.Session.GetString("email");
            return View("Register", new Users());
        }

        //get login
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
           
            return View("Login");
            TempData.Clear();
        }
        [HttpGet]
        [Route("Admin")]
        public async Task<IActionResult> Admin()
        {
            ViewBag.email = HttpContext.Session.GetString("email");
            ViewBag.vehicle = await _context.Vehicle.ToListAsync();
            ViewBag.customers = _context.Users.ToList().Count();
            ViewBag.AddOns = _context.AddOns.ToList().Count();
            ViewBag.vehicles = _context.Vehicle.ToList().Count();
            ViewBag.bookings = _context.Bookings.Where(b => b.BookingStatus == "Booked").ToList().Count();
            var aa= await _webService.WebScraping();
            return View(aa);
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(Users user, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                user.Pic = "No Image";
            }
            else {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "", photo.FileName);
                var stream = new FileStream(path, FileMode.Create);
                user.Pic = photo.FileName;
            }
            byte[] data = UTF8Encoding.UTF8.GetBytes(user.Password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("hash"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    user.Password = Convert.ToBase64String(results, 0, results.Length);
                }
            }

            user.Type = "user";
            user.Status = "Enable";
            _context.Users.Add(user);
            _context.SaveChanges();
            ViewBag.email = HttpContext.Session.GetString("email");
            return RedirectToAction("Home");
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Users user)
        {
            Users usertemp=null;
            bool flag = false;
            var users = _context.Users.ToList();
            foreach (Users u in users)
            {
                string password = "";
                byte[] data1 = Convert.FromBase64String(u.Password);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("hash"));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data1, 0, data1.Length);
                        password = UTF8Encoding.UTF8.GetString(results);
                    }
                }
                if (user.Email.Equals(u.Email) && password.Equals(user.Password))
                {
                    usertemp = u;                
                    flag = true;
                }
            }

            if (flag == true)
            {
                if (usertemp.Status == "Blocked")
                {
                    TempData["message"] = "User Has Been Blocked Please Contact The Administration";
                return    RedirectToAction("Login");
                }
                else
                {
                    HttpContext.Session.SetString("email", usertemp.Email);
                    ViewBag.email = HttpContext.Session.GetString("email");
                    if (usertemp.Type == "admin")
                    {

                        ViewBag.image = usertemp.Pic;
                        return RedirectToAction("Admin");
                    }
                    else
                    {
                       
                        return RedirectToAction("Home");
                    }
                }
            }
            else
            {
                Console.WriteLine("Fail");
                TempData["message"] = "Try Again with Valid Email and Password";
                return RedirectToAction("login");
            }
        }


      

        //Get
        public async Task<IActionResult> Index()
        {

            return View(await _context.Users.ToListAsync());
        }

        [Route("ViewBookings")]
        [HttpGet]
        public async Task<IActionResult> ViewBookings()
        {
            var bookings = _context.Bookings.Where(b=>b.Email== HttpContext.Session.GetString("email")&&b.BookingStatus!="Returned");
            List<Bookings> booking =await _context.Bookings.Where(b => b.Email == HttpContext.Session.GetString("email") && b.BookingStatus == "Returned").ToListAsync();
            ViewBag.booking = booking;
            return View( bookings);

        }

        [HttpGet]
        [Route("ViewUser")]
        public IActionResult ViewUser()
        {
            ViewBag.email = HttpContext.Session.GetString("email");
            var aa=_context.Users.ToList().Where(u=>u.Type=="user");
            return View(aa);
        }


        [HttpGet]
        [Route("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            TempData.Clear();
            return RedirectToAction("Home");
        }


        [HttpGet]
        [Route("Profile")]
        public IActionResult Profile()
        {
            var user = _context.Users.Find(HttpContext.Session.GetString("email"));
            byte[] data1 = Convert.FromBase64String(user.Password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("hash"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data1, 0, data1.Length);
                    user.Password = UTF8Encoding.UTF8.GetString(results);
                }
            }
            ViewBag.user = user;
            return View();
        }

        [Route("UpdateProfile")]
        [HttpPost]
        public async Task<IActionResult> UpdateProfile(Users user)
        {
           

            var users = _context.Users.Find(user.Email);

            byte[] data = UTF8Encoding.UTF8.GetBytes(user.Password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("hash"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    users.Password = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            users.Age = user.Age;
            users.ContactNumber = user.ContactNumber;
            users.Gender = user.Gender;
         
            users.Name = user.Name;
            if (user.Pic != null)
            {
                users.Pic = user.Pic;
            }
            // ViewBag.image = "uploadimage";
            _context.Users.Update(users);
            _context.SaveChanges();
            return RedirectToAction("Profile");

        }

        [HttpGet]
        [Route("About")]
        public IActionResult About()
        {

            return View();
        }

        [HttpGet]
        [Route("Service")]
        public IActionResult Service()
        {

            return View();
        }


        [Route("DeleteBooking")]
        public IActionResult DeleteBooking(int id=0)
        {
            var booking = _context.Bookings.Where(b => b.BookingID == id);


            _context.Bookings.Remove(_context.Bookings.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ViewBookings");
        }
        [Route("DisableUser")]
        public IActionResult DisableUser(String id = "",string status="")
        {
            Users user = _context.Users.Find(id);
            user.Status = status;
            _context.Users.Update(user);
            _context.SaveChanges();
            return RedirectToAction("ViewUser");
        }



    }
}