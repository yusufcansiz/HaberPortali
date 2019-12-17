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
    public class HaberDetayController : Controller
    {
        HaberController haberController = new HaberController();
        FotografController fotografController = new FotografController();
        KategoriController kategoriController = new KategoriController();
        YazarController yazarController = new YazarController();
        YorumController yorumController = new YorumController();

        Haber Haberler;
        List<Fotograf> Fotograflar;
        Kategori Kategoriler;
        List<Yazar> Yazarlar;
        List<Yorum> Yorumlar;

        HaberDetayViewModel haberDetayViewModel;

        // GET: HaberDetay
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HaberDetay(int id)
        {
            Haberler = haberController.Getir(x => x.HaberId == id).FirstOrDefault();
            Fotograflar = fotografController.Getir(x => x.HaberId == id);
            Kategoriler = kategoriController.Getir(x => x.HaberId == id).FirstOrDefault();
            Yazarlar = yazarController.Getir(x => x.HaberId == id);
            Yorumlar = yorumController.Getir(x => x.HaberId == id);

            haberDetayViewModel = new HaberDetayViewModel 
            {
                haber = Haberler,
                fotograf = Fotograflar,
                kategori = Kategoriler,
                yazar = Yazarlar,
                yorum = Yorumlar
            };

            
            return View(haberDetayViewModel);
        }


    }
}