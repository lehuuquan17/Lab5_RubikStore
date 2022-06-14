using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab5_RubikStore.Models
{
    public class GioHang
    {
        RubikStoreDataContext data = new RubikStoreDataContext();
        public int id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string tensp { get; set; }
        [Display(Name = "Hình ảnh")]
        public string hinhsp { get; set; }
        [Display(Name = "Giá")]
        public double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int soluong { get; set; }
        [Display(Name = "Thành tiền")]
        public double dthanhtien
        {
            get
            {
                return soluong * gia;
            }
        }
        public GioHang(int id)
        {
            this.id = id;
            var sp = data.Rubiks.Single(n => n.id == id);
            tensp = sp.ten;
            gia = double.Parse(sp.gia.ToString());
            soluong = 1;

        }
    }
}
