using Lab5_RubikStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_RubikStore.Controllers
{
    public class KhachHangController : Controller
    {
        RubikStoreDataContext data = new RubikStoreDataContext();
        // GET: KhachHang
        public ActionResult Index()
        {
            var all_sach = from s in data.KhachHangs select s;
            return View(all_sach);


        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, KhachHang s)
        {
            //var E_makh = collection["makh"];
            var E_hoten = collection["hoten"];
            var E_tendangnhap = collection["tendangnhap"];
            var E_matkhau = collection["matkhau"];
            var E_email = collection["email"];
            var E_diachi = collection["diachi"];
            var E_dienthoai = collection["dienthoai"];

            var E_ngaysinh = Convert.ToDateTime(collection["ngaysinh"]);

            if (string.IsNullOrEmpty(E_hoten)) 
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                //s.makh = int.Parse(E_makh.ToString());
                s.hoten = E_hoten.ToString();
                s.tendangnhap = E_tendangnhap.ToString();
                s.matkhau = E_matkhau.ToString();
                s.email = E_email.ToString();
                s.diachi = E_diachi.ToString();
                s.dienthoai = E_dienthoai.ToString();
                s.ngaysinh = E_ngaysinh;
    
                data.KhachHangs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index","RubikStore");
            }
            return this.Create();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var Masv = collection["tendangnhap"];
            var mk = collection["matkhau"];
            KhachHang sv = data.KhachHangs.SingleOrDefault(n => n.tendangnhap == Masv  && n.matkhau == mk );
            if (sv == null)
            {
                ViewBag.ThongBao = "that bai";


            }
            else
            {
                ViewBag.ThongBao = "Dang nhap thanh cong";
                Session["Index"] = sv;
                return RedirectToAction("Index", "RubikStore");

            }
            return View();


        }
    }
}