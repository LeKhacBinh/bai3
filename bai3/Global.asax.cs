using bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace bai3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            List<Book> listBook = new List<Book>()
            {
                new Book { Id = 1, TacGia = "Tac Gia A", Gia = 100, TenSach = "Lam Vuon", SoTrang = 100, Hinh = "\\Content\\Theme\\images\\templatemo_image_01.jpg", MoTa = "aaaaaaaaaaaaaaaa" },
                new Book { Id = 2, TacGia = "Tac Gia V", Gia = 200, TenSach = "Nau AN", SoTrang = 100, Hinh = "\\Content\\Theme\\images\\templatemo_image_02.jpg", MoTa = "aaaaaaaaaaaaaaaa" },
                new Book { Id = 3, TacGia = "Tac Gia C", Gia = 300, TenSach = "Doi Song", SoTrang = 100, Hinh = "\\Content\\Theme\\imagestemplatemo_image_03.jpg", MoTa = "aaaaaaaaaaaaaaaa" },
                new Book { Id = 4, TacGia = "Tac Gia D", Gia = 400, TenSach = "Kinh Doanh", SoTrang = 100, Hinh = "\\Content\\Theme\\imagestemplatemo_image_04.jpg", MoTa = "aaaaaaaaaaaaaaaa" }
            };
            Application["listBook"] = listBook;
        }
    }
}
