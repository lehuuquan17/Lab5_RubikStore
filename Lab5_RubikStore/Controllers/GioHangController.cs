using Lab5_RubikStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_RubikStore.Controllers
{
    public class GioHangController : Controller
    {
        RubikStoreDataContext data = new RubikStoreDataContext();
        public List<GioHang> Laygiohang()
        {
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<GioHang>();
                Session["Giohang"] = lstGiohang;
            }
            return lstGiohang;
        }
        public ActionResult ThemGioHang(int id, string strURL)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.Find(n => n.id == id);
            if (sanpham == null)
            {
                sanpham = new GioHang(id);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.soluong++;
                return Redirect(strURL);
            }
        }
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Sum(n => n.soluong);
            }
            return tsl;
        }
        private int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Count;
            }
            return tsl;
        }
        private double TongTien()
        {
            double tt = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tt = lstGiohang.Sum(n => n.dthanhtien);
            }
            return tt;
        }
        public ActionResult GioHang()
        {
            List<GioHang> lstGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }
        public ActionResult XoaGiohang(int id)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.id == id);
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.id == id);
                return RedirectToAction("GioHang");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult CapnhatGiohang(int id, FormCollection collection)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.id == id);
            if (sanpham != null)
            {
                sanpham.soluong = int.Parse(collection["txtSoLg"].ToString());
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaTatCaGioHang()
        {
            List<GioHang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("GioHang");
        }
        public ActionResult Dathang()
        {
            try
            {
                DonHang donhang = new DonHang();
                List<GioHang> lstGiohang = Laygiohang();
                donhang.madon = TongSoLuong();
                donhang.makh = TongSoLuongSanPham();
               
                data.DonHangs.InsertOnSubmit(donhang);
                data.SubmitChanges();
                for (int i = 0; i < lstGiohang.Count; i++)
                {
                    ChiTietDonHang ctdh = new ChiTietDonHang();
                    ctdh.madon = donhang.madon;
                    ctdh.id = lstGiohang[i].id;
                    ctdh.soluong = lstGiohang[i].soluong;
                    ctdh.gia = (decimal?)lstGiohang[i].gia;
                    data.ChiTietDonHangs.InsertOnSubmit(ctdh);
                }
                data.SubmitChanges();
                XoaTatCaGioHang();

                //Response.Write("<script>alert('Đặt hàng thành công! Đơn hàng có mã là: " + donhang.MaDon.ToString() + " Tổng tiền:  " + donhang.TongTien.ToString() + "');</script>");
                TempData["msg"] = "<script>alert('Đặt hàng thành công! Đơn hàng có mã là: " + donhang.madon.ToString() + " Tổng tiền:  " + donhang.thanhtoan.ToString() + "');</script>";
                return RedirectToAction("Index", "Home");

            }
            catch
            {
                return RedirectToAction("Index", "RubikStore");
            }

        }
        // GET: GioHang

    }
}