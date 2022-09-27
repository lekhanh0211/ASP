using EProject_Sem3.BLL.Repositories;
using EProject_Sem3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject_Sem3.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        private IRepository<AdminLogin> lg;
        private Eproject_DbContext db;
        public LoginController()
        {
            lg = new Repository<AdminLogin>();
            db = new Eproject_DbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if(string.IsNullOrEmpty(username)==true | string.IsNullOrEmpty(password) == true)
            {
                ViewBag.Message = "Bạn cần nhập đầy đủ các thông tin!!!";
            return View();
            }
            var data = db.AdminLogins.Where(x => x.username.Equals(username) && x.password.Equals(password)).SingleOrDefault();
            if (data == null)
            {
                ViewBag.Message = "Tai khoan or Mat khau khong dung!";
                ViewBag.username = username;
                return View();
            }
            if(data.password != password)
            {
                ViewBag.Message = "Tai khoan mat khau khong dung!";
                ViewBag.username = username;
                return View();
            }
            // Kiem tra active 
            /* if(data.Status != true)
             {
                 ViewBag.Message = "Tai khoan đang bị khoa!";
                 ViewBag.username = username;
                 return View();
             }*/
            //Lưu Session
            Session["Admin"] = data;
            return RedirectToAction("Index","HomeAdmin");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login","Login");
        }
    }
}