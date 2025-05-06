using DegisiklikBildirimFormu.Data;
using DegisiklikBildirimFormu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DegisiklikBildirimFormu.Controllers
{
    public class FormController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FormController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var formList= _db.Formlar.ToList();

          
            return View(formList);
        }
        public IActionResult Create()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult Create(Form obj)
        {
           if (obj == null)
            {
                return BadRequest();
            }

           if (string.IsNullOrEmpty(obj.Durum))
            {
                obj.Durum = "Bekliyor";
            }
                _db.Add(obj);
                _db.SaveChanges();
               return(RedirectToAction("Index")); 
           }

        public IActionResult FormDetail(int id)
        {
            var formDetail = _db.Formlar
                .Include(f => f.EskiYeniKodlar)
                .FirstOrDefault(f => f.FormID == id);

            return View(formDetail);
        }
        [HttpPost , ActionName("FormDetail")]
        public IActionResult FormDetailPOST(int? id)
        {
            Form deleteForm = _db.Formlar
                .FirstOrDefault(df => df.FormID == id);
            if (deleteForm == null)
            {
                return BadRequest();
            }
            _db.Formlar.Remove(deleteForm);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
