using HopeAcademySMS.Models;
using HopeAcademySMS.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HopeAcademySMS.Controllers
{
    public class GradesController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Grades
        public async Task<ActionResult> Index()
        {
            return View(await db.Grades.ToListAsync());
        }

        // GET: Grades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            return View();
        }

        // POST: Grades/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(GradeViewModel model)
        {
            if (ModelState.IsValid)
            {

                var myGrade = db.Grades.Where(x => x.GradeName.Equals(model.GradeName.ToString()));
                var countFromDb = myGrade.Count();
                if (countFromDb >= 1)
                {
                    return View("Error2");
                }
                else
                {
                    var grade = new Grade
                    {
                        GradeName = model.GradeName.ToString(),
                        MinimumValue = model.MinimumValue,
                        MaximumValue = model.MaximumValue,
                        Remark = model.Remark
                    };
                    db.Grades.Add(grade);
                }
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }



        // GET: Grades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grades/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Grades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grades/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
