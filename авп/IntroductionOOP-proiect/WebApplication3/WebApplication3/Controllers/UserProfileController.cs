using CodeFirst;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using PagedList;
namespace WebApplication3.Controllers
{
    public class UserProfileController : Controller
    {


        public ApplicationDbContext dbContext = new ApplicationDbContext();



        // GET: UserProfile
        public ActionResult Index(string searchString, string sortOption, int page = 1)
        {
              int pageSize = 10;

            ApplicationDbContext dbContext = new ApplicationDbContext();

            var users = dbContext.Users.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                users = dbContext.Users.Where(u => u.UserName.ToLower().Contains(searchString));
            }
            switch (sortOption)
            {
                case "name_acs":
                    users = users.OrderBy(p => p.UserName);
                    break;
                case "name_desc":
                    users = users.OrderByDescending(p => p.Email);
                    break;
                default:
                    users = users.OrderBy(p => p.Id);
                    break;

            }
            return Request.IsAjaxRequest()
                ? (ActionResult)PartialView("View", users.ToPagedList(page, pageSize))
                : View(users.ToPagedList(page, pageSize));
        }


        [HttpPost]
        public ActionResult Details()
        {
            return PartialView();
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
       

    
    }
}