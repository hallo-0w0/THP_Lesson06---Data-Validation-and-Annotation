using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thp.Lab05.Models; 

namespace Thp.Lab05.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member/CreateOne
        public ActionResult CreateOne()
        {
            return View();
        }

        // POST: /Member/CreateOne
        [HttpPost]
        public ActionResult CreateOne(Member m)
        {
            // Chuyển dữ liệu nhận được tới View Details
            return View("Details", m);
        }

        // GET: /Member/CreateTwo
        public ActionResult CreateTwo()
        {
            return View();
        }

        // POST: /Member/CreateTwo
        [HttpPost]
        public ActionResult CreateTwo(Member m)
        {
            // Kiểm tra trống các trường và thông báo lỗi tới VIEW
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if (string.IsNullOrEmpty(m.Username))
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (string.IsNullOrEmpty(m.FullName))
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (string.IsNullOrEmpty(m.Email))
            {
                ViewBag.error = "Hãy nhập Email";
                return View();
            }

            // Mẫu kiểm tra Email
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (!System.Text.RegularExpressions.Regex.IsMatch(m.Email, regexPattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng email";
                return View();
            }

            // Nếu không xảy ra lỗi thì chuyển dữ liệu tới View Details
            return View("Details", m);
        }

        // GET: /Member/CreateThree
        public ActionResult CreateThree()
        {
            return View();
        }

        // POST: /Member/CreateThree
        [HttpPost]
        public ActionResult CreateThree(Member m)
        {
            // Nếu dữ liệu của Model hợp lệ thì chuyển dữ liệu tới View Details
            if (ModelState.IsValid)
            {
                return View("Details", m);
            }
            else
            {
                // Quay lại view CreateThree để báo lỗi
                return View();
            }
        }

        // GET: /Member/Details
        public ActionResult Details(Member m)
        {
            return View(m);
        }
    }
}
