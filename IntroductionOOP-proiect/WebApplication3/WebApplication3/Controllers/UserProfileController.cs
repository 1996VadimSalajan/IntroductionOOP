using CodeFirst;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UserProfileController : Controller
    {


        public ApplicationDbContext dbContext = new ApplicationDbContext();



        // GET: UserProfile
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public new ActionResult AddPhoto()
        {
            return View();
        }

        [AllowAnonymous]
        public new ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public new ActionResult Profile([Bind(Exclude = "Photo")]Profile model)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase poImgFile = Request.Files["Photo"];
                    using (var binary = new BinaryReader(poImgFile.InputStream))
                    {
                        imageData = binary.ReadBytes(poImgFile.ContentLength);
                    }
                }
                var userid = User.Identity.GetUserId();
                var user = dbContext.Users.Where(u => u.Id == userid).FirstOrDefault();
                user.Photo = imageData;
                dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index", "Manage");
            }
            return View(model);
        }
        public void UserInformation()
        {
            var userid = User.Identity.GetUserId();
            var user = from u in dbContext.Users
                       where u.Id == userid
                       select new
                       {
                           u.UserName,
                           u.BirthDate,
                           u.Age
                       };
           user.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}