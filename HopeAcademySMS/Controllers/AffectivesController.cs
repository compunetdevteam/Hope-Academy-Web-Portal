using HopeAcademySMS.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HopeAcademySMS.Controllers
{
    public class AffectivesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Affectives
        public async Task<ActionResult> Index()
        {
            return View(await db.Affectives.ToListAsync());
        }

        // GET: Affectives/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affective affective = await db.Affectives.FindAsync(id);
            if (affective == null)
            {
                return HttpNotFound();
            }
            return View(affective);
        }

        // GET: Affectives/Create
        public ActionResult Create()
        {

            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View();
        }

        // POST: Affectives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Affective model)
        {
            if (ModelState.IsValid)
            {
                var affective = new Affective()
                {
                    StudentId = model.StudentId,
                    TermName = model.TermName.ToString(),
                    SessionName = model.SessionName,
                    ClassName = model.ClassName,
                    Punctuality = model.Punctuality,
                    BehaviourInClass = model.BehaviourInClass,
                    AttentivenessInClass = model.AttentivenessInClass,
                    ClassAssignmentsProjects = model.ClassAssignmentsProjects,
                    Neatness = model.Neatness,
                    SelfControl = model.SelfControl,
                    RelationshipWithOthers = model.RelationshipWithOthers,
                    RelationshipWithTeachersAndStaff = model.RelationshipWithTeachersAndStaff,
                    SenseOfResponsibility = model.SenseOfResponsibility,
                    AttendanceInClass = model.AttendanceInClass,
                    Politeness = model.Politeness,
                    HonestyAndReliability = model.HonestyAndReliability
                };
                db.Affectives.Add(affective);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View(model);
        }

        // GET: Affectives/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affective affective = await db.Affectives.FindAsync(id);
            if (affective == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View(affective);
        }

        // POST: Affectives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,StudentId,TermName,SessionName,ClassName,Punctuality,BehaviourInClass,AttentivenessInClass,ClassAssignmentsProjects,Neatness,SelfControl,RelationshipWithOthers,RelationshipWithTeachersAndStaff,SenseOfResponsibility,AttendanceInClass,Politeness,HonestyAndReliability")] Affective affective)
        {
            if (ModelState.IsValid)
            {
                db.Entry(affective).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(affective);
        }

        // GET: Affectives/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affective affective = await db.Affectives.FindAsync(id);
            if (affective == null)
            {
                return HttpNotFound();
            }
            return View(affective);
        }

        // POST: Affectives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Affective affective = await db.Affectives.FindAsync(id);
            db.Affectives.Remove(affective);
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
