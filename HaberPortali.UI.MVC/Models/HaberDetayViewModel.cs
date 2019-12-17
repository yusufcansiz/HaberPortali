using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberPortali.UI.MVC.Models
{
    public class HaberDetayViewModel
    {
        public Haber haber { get; set; }
        public List<Fotograf> fotograf { get; set; }
        public Kategori kategori { get; set; }
        public List<Yazar> yazar { get; set; }
        public List<Yorum> yorum { get; set; }
    }
}