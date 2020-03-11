using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using banger.Models;
using banger.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace banger.Controllers
{
    [Route("Vehicle")]
    public class VehicleController : Controller
    {
      
        private readonly dbContext _context;
  
        private readonly IMessageService _messageService;

      
        private readonly IInsuranceService _insuranceService;
        public VehicleController(dbContext context,IMessageService messageService,IInsuranceService insuranceService)

        {
            _messageService = messageService;
            _context = context;
            _insuranceService = insuranceService;
        }

     
        [Route("AddVehicle")]
        public async Task<IActionResult> AddVehicle(string num="")
        {

            if (num == "")
            {
                return View(new Vehicle());
            }
            else
            {
                ViewBag.type = "Update";
                return View(await _context.Vehicle.FindAsync(num));

            }
        }
        [Route("UpdateVehicles")]
        public IActionResult UpdateVehicles(Vehicle vehicle, IFormFile photo)
        {
            Vehicle vehicles = _context.Vehicle.Find(vehicle.VehicleNo);
            if (photo == null || photo.Length == 0)
            {
                vehicle.Pic = vehicles.Pic;
            }
            else
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "", photo.FileName);
                var stream = new FileStream(path, FileMode.Create);
                vehicle.Pic = photo.FileName;
            }
            vehicle.VehicleAvailability = true;
           
            _context.Vehicle.Attach(vehicles);
            vehicles.VehicleType = vehicle.VehicleType;
            vehicles.Amount = vehicle.Amount;
            vehicles.VehicleAvailability = vehicle.VehicleAvailability;
            vehicles.Class = vehicle.Class;

            _context.SaveChanges();

            return RedirectToAction("ViewVehicle");


        }


        [Route("CarDetails")]
        public async Task<IActionResult> CarDetails(string num = "")
        {
            var email = HttpContext.Session.GetString("email");
            if (email != null)
            {
                ViewBag.addOn = await _context.AddOns.ToListAsync();
                return View(await _context.Vehicle.FindAsync(num));
            }
            else {
                return RedirectToAction("Login","User");
            }
        }



        public IActionResult UpdateAddOns(AddOns addOns)
        {

            AddOns a = _context.AddOns.Find(addOns.AddOnsID);
            _context.AddOns.Attach(a);
            a.Equipment = addOns.Equipment;
            a.Amount = addOns.Amount;
            a.Quantity = addOns.Quantity;
        //    _context.Entry(addOns).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

          //  _context.AddOns.Update(addOns);
            _context.SaveChanges();

            return RedirectToAction("ViewAddOns");


        }
        [Route("AddAddOns")]
        public IActionResult AddAddOns(int num=0)
        {
            if (num == 0)
            {
                return View(new AddOns());
            }
            else
            {
                ViewBag.type = "Update";
                return View(_context.AddOns.Find(num));

            }
        }

        [HttpPost]
        [Route("AddVehicles")]
        public async Task<IActionResult> AddVehicles( Vehicle vehicle, IFormFile photo)
        {
            if (await _context.Vehicle.FindAsync(vehicle.VehicleNo)!=null) {
                ViewBag.message = "Vehicle Already Exist";
                return View("AddVehicle");
            }
                if (photo == null || photo.Length == 0)
                {
                    vehicle.Pic = "No Image";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    vehicle.Pic = photo.FileName;
                }  
           
            _context.Vehicle.Add(vehicle);
            _context.SaveChanges();

                return RedirectToAction("ViewVehicle");
            
           
        }


      

        [HttpPost]
        [Route("AddAddOns")]
        public IActionResult AddAddOns(AddOns addOns)
        {
           
           
            addOns.Availability = true;
            _context.AddOns.Add(addOns);
            _context.SaveChanges();

            return RedirectToAction("ViewAddOns");
        }


        [Route("ViewVehicle")]
        [HttpGet]
        public async Task<IActionResult> ViewVehicle()
        {
            var validation = TempData["message"];
            return View(await _context.Vehicle.ToListAsync());
           
        }

        [Route("ReturnVehicle")]
        [HttpGet]
        public async Task<IActionResult> ReturnVehicle(int id)
        {
            Bookings bookings = await _context.Bookings.FindAsync(id);
            return View(bookings);

        }

        [Route("CollectPayment")]
   
        public async Task<IActionResult> CollectPayment(Bookings bookings,int id,DateTime value)
        {
            if (bookings.Amount != 0.0) {
                bookings.BookingStatus = "Returned";
                _context.Bookings.Update(bookings);
                _context.SaveChanges();
                return RedirectToAction("ViewBookingsHistory");

            }
            float additional=0;
            int dates = (value - bookings.ReturnDate).Days;
            if (dates > 0) {
                additional = 200 * dates;
            }
            //  Bookings booking = await _context.Bookings.FindAsync(id);
            float num = 0;
            Vehicle vehicle = await _context.Vehicle.FindAsync(bookings.VehicleNo);
            int date = (bookings.ReturnDate - bookings.PickUpDate).Days;
            if (bookings.Equipment != null) {
                AddOns addOns =  _context.AddOns.Where(a => a.Equipment == bookings.Equipment).FirstOrDefault();
                num = addOns.Amount * date;
            }
            float amount = vehicle.Amount * id;
            TempData["Amount"] = amount+ num+additional;
            bookings.Amount = amount+num;
            return View("ReturnVehicle",bookings);

        }



        [Route("ViewAddOns")]
        [HttpGet]
        public async Task<IActionResult> ViewAddOns()
        {
            return View(await _context.AddOns.ToListAsync());

        }

        [Route("ViewBookings")]
        [HttpGet]
        public async Task<IActionResult> ViewBookings()
        {
            return View(await _context.Bookings.Where(b=>b.BookingStatus=="Pending").ToListAsync());

        }

        [Route("ViewBookingsHistory")]
        [HttpGet]
        public async Task<IActionResult> ViewBookingsHistory()
        {
            return View(await _context.Bookings.Where(b => b.BookingStatus == "Returned").ToListAsync());

        }


        [Route("ViewCollectedBookings")]
        [HttpGet]
        public async Task<IActionResult> ViewCollectedBookings()
        {
            return View(await _context.Bookings.Where(b => b.BookingStatus == "Collected").ToListAsync());

        }


        [Route("UpdateBookings")]
        [HttpGet]
        public async Task<IActionResult> UpdateBookings(int num)
        {
           // ViewBag.image = "uploadimage";
            Bookings booking = await _context.Bookings.FindAsync(num);
            return View(booking);

        }

        

        [Route("UpdateBooking")]
       
        public async Task<IActionResult> UpdateBooking(Bookings bookings, IFormFile photo)
        {
           
         bool flag=   _insuranceService.checkNIC(bookings.NICNo);
            
            if (flag) {
               
                if (photo == null || photo.Length == 0)
                {
                    TempData["messagebook"] = "Please Add An Additional File to Continue Booking";
                    //    TempData["message"] = "Please Add an Original Copy";
                    TempData["image"] = "image";
                    ViewBag.image = "uploadimage";
                    return View("UpdateBookings", bookings);
                 
                    
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    bookings.PicExtra = photo.FileName;
                    bookings.BookingStatus = "Collected";
                    _context.Bookings.Update(bookings);
                    _context.SaveChanges();
                    return RedirectToAction("ViewBookings");
                }
              
            }
             bookings.BookingStatus = "Collected";
             _context.Bookings.Update(bookings);
             _context.SaveChanges();
            return RedirectToAction("ViewBookings");

        }

        [Route("Contacts")]
        [HttpGet]
        public async Task<IActionResult> Contacts()
        {

           return View();

        }

   

        [Route("SendContacts")]
      
        public async Task<IActionResult> SendContacts(Contact contact)
        {

            await _messageService.SendEmailAsync(contact.Name+" "+contact.Email, "izzath0@gmail.com", "izzath", "izzath0@gmail.com", contact.Subject, contact.Message);

            return View();

        }




        


        [Route("ReturnCars")]
        [HttpPost]
        public async Task<IActionResult> ReturnCars(int id,int km,DateTime endDate)
        {
            AddOns addOns = null;
            Bookings booking = _context.Bookings.ToList().FirstOrDefault(v => v.BookingID == id);
            Vehicle vehicle = _context.Vehicle.ToList().FirstOrDefault(v => v.VehicleType == booking.VehicleNo);
            if (booking.Equipment != null)
            {

                addOns = _context.AddOns.ToList().FirstOrDefault(a => a.Equipment == booking.Equipment);


            }
            int date = (booking.PickUpDate - booking.ReturnDate).Days;
            booking.Amount = (vehicle.Amount*km )+ addOns.Amount;
            return View(await _context.Vehicle.ToListAsync());

        }

        [Route("Cars")]
        [HttpGet]
        public async Task<IActionResult> Cars()
        {

            ViewBag.cars = await _context.Vehicle.ToListAsync();
            return View(await _context.Vehicle.ToListAsync());

        }

        [Route("DeleteVehicle")]
        public IActionResult DeleteVehicle(string id = "")
        {
            Bookings booking = _context.Bookings.Where(b => b.VehicleNo == id).FirstOrDefault();
            if (booking == null)
            {
                _context.Vehicle.Remove(_context.Vehicle.Find(id));
                _context.SaveChanges();
            }
            else {
                TempData["message"] = "Vehicle is Already Booked By a User";
               
            }
           
            return RedirectToAction("ViewVehicle");
        }


        [Route("DeleteAddOns")]
        public IActionResult DeleteAddOns(int id = 0)
        {
            AddOns addOns = _context.AddOns.Find(id);
            if (_context.Bookings.Where(b => b.Equipment == addOns.Equipment).FirstOrDefault() == null)
            {
                _context.AddOns.Remove(_context.AddOns.Find(addOns.AddOnsID));
                _context.SaveChanges();
            }
            else
            {
                TempData["message"] = "AddOn is Already Booked By a User";

            }

            return RedirectToAction("ViewAddOns");
        }



        [HttpPost]
        [Route("Bookings")]
        public async Task<IActionResult> Bookings(Bookings bookings, IFormFile photo,string vehicleNo)
        {
            if (bookings.VehicleNo==null) {
                bookings.VehicleNo = vehicleNo;

            }
            Vehicle vehicle = await _context.Vehicle.FindAsync(bookings.VehicleNo);
            var email =  HttpContext.Session.GetString("email");
            if (email != null)
            {
                Users user =  await _context.Users.FindAsync(email);
                if (user.Status == "Blocked") {
                    TempData["message"] = "You Are Not Allowed to Book Any vehicles From Banger. Please Contact the Admin to Enable Bookings";
                    return RedirectToPage("Home");
                }
                if (photo == null || photo.Length == 0)
                {
                    bookings.Pic = "No Image";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    bookings.Pic = photo.FileName;
                }

                var csvParserService = new CvsParserService();
                var paths = @"C:\\Users\\Izzath\\Documents\\Visual Studio 2017\\Projects\\banger\\banger\\wwwroot\\dmvFile.csv";
                List<string> results = csvParserService.ReadCvsFileToLicenseModel(paths);
                bool flag = false;
                foreach (string licenseNo in results) {
                    if (bookings.LicenseNo.Equals(licenseNo)) {
                        flag = true;
                    }
                }
                if (flag) {


                    await _messageService.SendEmailAsync("Imth","izzath0@gmail.com","izzath", "izzath0@gmail.com"," Alert",bookings.LicenseNo+" Has Accessed Banger System "+System.DateTime.Now);
                    TempData["message"] = "Contact The Administration You are not allowed to Book a Vehicle";
                    return RedirectToAction("Home", "User");
                }
               
                bookings.Email = HttpContext.Session.GetString("email");
                bookings.BookingStatus = "Pending";
                
                var booking = _context.Bookings.ToList();
                var currentBooking = _context.Bookings
             .Where(b => b.VehicleNo == bookings.VehicleNo && b.BookingStatus!= "Returned")
             .Select(b => (bookings.ReturnDate > b.PickUpDate && bookings.PickUpDate < b.ReturnDate)
                       || (bookings.PickUpDate < b.PickUpDate && bookings.ReturnDate > b.PickUpDate))

             .FirstOrDefault();

                if (currentBooking)
                {
                    TempData["message"] =   "The Vehicle is already Booked on that date.";
                    return RedirectToAction("Home", "User");

                }
                int date = (bookings.ReturnDate - bookings.PickUpDate).Days;
                int time = (bookings.ReturnDate - bookings.PickUpDate).Hours;

                if (date > 14) {
                    TempData["message"] = "The Vehicle only can be booked for maximum of 14 days";
                    return RedirectToAction("Home", "User");
                }
                //else if (time<5) {
                //    TempData["message"] = "The Vehicle should be booked for minumum of 5 Hours";
                //    return RedirectToAction("Home", "User");

                //}
                if (user.Age < 25 && vehicle.VehicleAvailability)
                {
                    TempData["message"] = "You are not Allowed to Book This Vehicle Because of Your Age restriction";
                    return RedirectToAction("Home", "User");
                }
                _context.Bookings.Add(bookings);
                _context.SaveChanges();

                return RedirectToAction("ViewBookings","User");
            }
            else {
                ViewBag.message = "Please Login To Book a Vehicle";
                return RedirectToAction("Login", "User",new { area= ViewBag.message = "Please Login To Book a Vehicle" });
            }
        }
    }
}