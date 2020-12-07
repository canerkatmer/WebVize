using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace caner.Controllers
{
    public class ogretmenController : Controller
    {
        // GET: ogrenci
        public ActionResult Liste2()
        {
            return View(Models.ogretmen.ogretmenx);
        }
        public ActionResult Edit(int Id)
        {
            var ogretmen = Models.ogretmen.ogretmenx.Where(g => g.id == Id).FirstOrDefault();
            return View(ogretmen);
        }
        [HttpPost]
        public ActionResult Edit(Models.ogretmen ogretmenV)
        {
            var ogretmen = Models.ogretmen.ogretmenx.FirstOrDefault(g => g.id == ogretmenV.id);
            ogretmen.isim = ogretmenV.isim;
            ogretmen.soyisim = ogretmenV.soyisim;
            ogretmen.adres = ogretmenV.adres;
            ogretmen.Dersadi = ogretmenV.Dersadi;
            return RedirectToAction("Liste2");
        }
        public ActionResult Delete(int Id)
        {
            var ogretmen= Models.ogretmen.ogretmenx.Where(g => g.id == Id).FirstOrDefault();
            return View(ogretmen);
        }
        [HttpPost]
        public ActionResult Delete(Models.ogretmen ogretmenV)
        {
            var ogretmen = Models.ogretmen.ogretmenx.FirstOrDefault(g => g.id == ogretmenV.id);
            Models.ogretmen.ogretmenx.Remove(ogretmen);
            return View(ogretmen);
            return RedirectToAction("Liste2");
        }
        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.ogretmen ogretmenV)
        {

            Models.ogretmen.ogretmenx.Add(ogretmenV);
            return RedirectToAction("Liste2");

        }
    }
}