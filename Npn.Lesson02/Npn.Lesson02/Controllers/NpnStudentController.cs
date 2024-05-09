using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Npn.Lesson02.Controllers
{
    /// <summary>
    /// Author: Nguyễn Phú Nam
    /// Class: K22CNT3
    /// </summary>
    public class NpnStudentController : Controller
    {
        // GET: NpnStudent
        public ActionResult Index()
        {
            //Truyền dữ liệu từ Controller -> View
            ViewBag.fullname = "Nguyễn Phú Nam";
            ViewData["Birthday"] = "26/07/2004";
            TempData["Phone"] = "0902069171";

            return View();
        }

        public ActionResult Details(){
            string npnStr = "";
            npnStr += "<h3> Họ và tên: Nguyễn Phú Nam</h3>";
            npnStr += "<p> Mã số: 2210900047";
            npnStr += "<p> Địa chỉ mail: nambkvn2004@gmail.com";
            
            ViewBag.Details = npnStr;

            return View("chiTiet");
        }

        public ActionResult NgonNguRazor(){
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: NpnStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string npnStr = "<h3>" + fullname + "</h3>";
            npnStr += "<p>" + masv;
            npnStr += "<p>" + TaiKhoan;
            npnStr += "<p>" + MatKhau;

            ViewBag.info = npnStr;

            return View("Ketqua");
        }
    }
}