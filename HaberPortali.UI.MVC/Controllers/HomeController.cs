using HaberPortali.BLL.Controller;
using HaberPortali.Entity.Model;
using HaberPortali.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortali.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        HaberController haberController = new HaberController();
        FotografController fotografController = new FotografController();
        KategoriController kategoriController = new KategoriController();
        YazarController yazarController = new YazarController();
        YorumController yorumController = new YorumController();

        List<Haber> Haberler;
        List<Fotograf> Fotograflar;
        List<Kategori> Kategoriler;
        List<Yazar> Yazarlar;
        List<Yorum> Yorumlar;

        HaberViewModel habermodel;

        public ViewResult Index()
        {
            Haberler = haberController.Getir();
            //Haber id = haberController.Getir(x => x.HaberId == 3).FirstOrDefault();
            Fotograflar = fotografController.Getir();
            Kategoriler = kategoriController.Getir();
            Yazarlar = yazarController.Getir();
            Yorumlar = yorumController.Getir();

            habermodel = new HaberViewModel
            {
                haber = Haberler,
                fotograf = Fotograflar,
                kategori = Kategoriler,
                yazar = Yazarlar,
                yorum = Yorumlar
            };

            return View(habermodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HaberDetay(int id)
        {
            Haber haber = haberController.Getir(id);

            return View(haber);
        }

        public ActionResult AdminPanel()
        {
            HaberViewModel model = IndexMethod();
            return View(model);
        }

        public ActionResult Delete(Haber haber)
        {
           // Haber silinecekHaber = haberController.Getir(x => x.HaberId == haber.HaberId).FirstOrDefault();
            haberController.Sil(haberController.Getir(x => x.HaberId == haber.HaberId).FirstOrDefault());
            return RedirectToAction("AdminPanel");
        }

        private HaberViewModel IndexMethod()
        {
            Haberler = haberController.Getir();
            //Haber id = haberController.Getir(x => x.HaberId == 3).FirstOrDefault();
            Fotograflar = fotografController.Getir();
            Kategoriler = kategoriController.Getir();
            Yazarlar = yazarController.Getir();
            Yorumlar = yorumController.Getir();

            HaberViewModel habermodel = new HaberViewModel
            {
                haber = Haberler,
                fotograf = Fotograflar,
                kategori = Kategoriler,
                yazar = Yazarlar,
                yorum = Yorumlar
            };

            return habermodel;
        }
    }
}