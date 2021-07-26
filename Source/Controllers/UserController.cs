using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalManagement.Controllers
{
    public class UserController : Controller
    {
        private HospitalContext hospitalContext;
        public UserController(HospitalContext sc)
        {
            hospitalContext = sc;
        }

        public IActionResult Index()
        {
            return View(hospitalContext.User);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create_Post(User user)
        {
            if (ModelState.IsValid)
            {
                User obj = new User();
                obj.UserName = user.UserName;
                obj.UserRole = user.UserRole;
                obj.Emailid = user.Emailid;
                obj.PhoneNo = user.PhoneNo;
                obj.AddedOn = DateTime.UtcNow;
                hospitalContext.User.Add(obj);
                hospitalContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public IActionResult Update(Guid id)
        {
            return View(hospitalContext.User.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update_Post(User user)
        {
            hospitalContext.User.Update(user);
            hospitalContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var user = hospitalContext.User.Where(a => a.Id == id).FirstOrDefault();
            hospitalContext.User.Remove(user);
            hospitalContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
