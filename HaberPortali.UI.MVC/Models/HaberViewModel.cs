using System.Collections.Generic;
using HaberPortali.Entity.Model;

namespace HaberPortali.UI.MVC.Models
{
    public class HaberViewModel
    {
        public List<Haber> haber { get; set; }
        public List<Fotograf> fotograf { get; set; }
        public List<Kategori> kategori { get; set; }
        public List<Yazar> yazar { get; set; }
        public List<Yorum> yorum { get; set; }
    }
}