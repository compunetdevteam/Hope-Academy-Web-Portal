using HopeAcademySMS.Models;
using HopeAcademySMS.ViewModel;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HopeAcademySMS.Controllers
{
    public class ExpressionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Expressions
        public async Task<ActionResult> Index()
        {
            return View(await db.Expressions.ToListAsync());
        }

        // GET: Expressions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expression expression = await db.Expressions.FindAsync(id);
            if (expression == null)
            {
                return HttpNotFound();
            }
            return View(expression);
        }

        // GET: Expressions/Create
        public ActionResult Create()
        {
            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View();
        }

        // POST: Expressions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ExpressionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var expression = new Expression()
                {
                    StudentId = model.StudentId,
                    TermName = model.TermName.ToString(),
                    SessionName = model.SessionName,
                    ClassName = model.ClassName,
                    QualityofHandwriting = model.QualityofHandwriting,
                    GrammaticalSkills = model.GrammaticalSkills,
                    OralExpression = model.OralExpression,
                    ImaginationCreativity = model.ImaginationCreativity,
                    VocabularyLexicalSkills = model.VocabularyLexicalSkills,
                    OrganizationOfIdeas = model.OrganizationOfIdeas
                };


                db.Expressions.Add(expression);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View(model);
        }

        // GET: Expressions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expression expression = await db.Expressions.FindAsync(id);
            if (expression == null)
            {
                return HttpNotFound();
            }
            ViewBag.SessionName = new SelectList(db.Sessions, "SessionName", "SessionName");
            ViewBag.ClassName = new SelectList(db.Classes, "FullClassName", "FullClassName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View(expression);
        }

        // POST: Expressions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,StudentId,TermName,SessionName,ClassName,QualityofHandwriting,GrammaticalSkills,OralExpression,ImaginationCreativity,VocabularyLexicalSkills,OrganizationOfIdeas")] Expression expression)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expression).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(expression);
        }

        // GET: Expressions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expression expression = await db.Expressions.FindAsync(id);
            if (expression == null)
            {
                return HttpNotFound();
            }
            return View(expression);
        }

        // POST: Expressions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Expression expression = await db.Expressions.FindAsync(id);
            db.Expressions.Remove(expression);
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
