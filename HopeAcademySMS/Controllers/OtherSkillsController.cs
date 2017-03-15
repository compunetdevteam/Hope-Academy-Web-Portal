using HopeAcademySMS.Models;
using HopeAcademySMS.ViewModel;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HopeAcademySMS.Controllers
{
    public class OtherSkillsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OtherSkills
        public async Task<ActionResult> Index()
        {
            return View(await db.OtherSkills.ToListAsync());
        }

        // GET: OtherSkills/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OtherSkills otherSkills = await db.OtherSkills.FindAsync(id);
            if (otherSkills == null)
            {
                return HttpNotFound();
            }
            return View(otherSkills);
        }

        // GET: OtherSkills/Create
        public ActionResult Create()
        {
            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View();
        }

        // POST: OtherSkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(OtherSkillsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var otherSkills = new OtherSkills()
                {
                    StudentId = model.StudentId,
                    TermName = model.TermName.ToString(),
                    SessionName = model.SessionName,
                    ClassName = model.ClassName,
                    TeamWorkTeamLeading = model.TeamWorkTeamLeading,
                    PhysicalDexterity = model.PhysicalDexterity,
                    ClubAndSocieties = model.ClubAndSocieties,
                    ArtisticOrMusicalSkills = model.ArtisticOrMusicalSkills,
                    LabAndWorkshopSkills = model.LabAndWorkshopSkills,
                    Sports = model.Sports
                };
                db.OtherSkills.Add(otherSkills);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View(model);
        }

        // GET: OtherSkills/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OtherSkills otherSkills = await db.OtherSkills.FindAsync(id);
            if (otherSkills == null)
            {
                return HttpNotFound();
            }
            return View(otherSkills);
        }

        // POST: OtherSkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,StudentId,TermName,SessionName,ClassName,TeamWorkTeamLeading,PhysicalDexterity,ClubAndSocieties,ArtisticOrMusicalSkills,LabAndWorkshopSkills,Sports")] OtherSkills otherSkills)
        {
            if (ModelState.IsValid)
            {
                db.Entry(otherSkills).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(otherSkills);
        }

        // GET: OtherSkills/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OtherSkills otherSkills = await db.OtherSkills.FindAsync(id);
            if (otherSkills == null)
            {
                return HttpNotFound();
            }
            return View(otherSkills);
        }

        // POST: OtherSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OtherSkills otherSkills = await db.OtherSkills.FindAsync(id);
            db.OtherSkills.Remove(otherSkills);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
