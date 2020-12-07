using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace caner.Controllers
{
    public class ogrenciController : Controller
    {
        // GET: ogrenci
        public ActionResult Liste()
        {
            return View(Models.ogrenci.ogrencis);
        }
        
        public ActionResult Edit(int Id)
        {
            var ogrenci = Models.ogrenci.ogrencis.Where(g=> g.id == Id).FirstOrDefault();
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult Edit(Models.ogrenci ogrenciV )
        {
            var ogrenci = Models.ogrenci.ogrencis.FirstOrDefault(g => g.id == ogrenciV.id);
            ogrenci.isim = ogrenciV.isim;
            ogrenci.soyisim = ogrenciV.soyisim;
            ogrenci.adres = ogrenciV.adres;
            ogrenci.OgrenciNo = ogrenciV.OgrenciNo;
            return RedirectToAction("Liste");
        }
        public ActionResult Delete(int Id)
        {
            var ogrenci = Models.ogrenci.ogrencis.Where(g => g.id == Id).FirstOrDefault();
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult Delete(Models.ogrenci ogrenciV)
        {
            var ogrenci = Models.ogrenci.ogrencis.FirstOrDefault(g => g.id == ogrenciV.id);
            Models.ogrenci.ogrencis.Remove(ogrenci);
            return View(ogrenci);
            return RedirectToAction("Liste");
        }
        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.ogrenci ogrenciV)
        {

            Models.ogrenci.ogrencis.Add(ogrenciV);
            return RedirectToAction("Liste");

        }
    }
}