using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YourLifeSaver.Models;

namespace YourLifeSaver.Controllers
{
    public class quizsController : Controller
    {
        private webQuizModel db = new webQuizModel();

        // GET: quizs
        public ActionResult Index()
        {
            return View(db.quizs.ToList());
        }

        public ActionResult Quiz(int id)
        {
            Update(id);
            return View(db.quizs.ToList());
        }


        //Update quiz database
        public void Update(int id)
        {
            quiz quiz = db.quizs.Find(id);
            quiz.Count += 1;
            if (ModelState.IsValid)
            {
                db.Entry(quiz).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        // GET: quizs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quiz quiz = db.quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }


        // GET: quizs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: quizs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Result,Count")] quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.quizs.Add(quiz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quiz);
        }

        // GET: quizs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quiz quiz = db.quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // POST: quizs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Result,Count")] quiz quiz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quiz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quiz);
        }

        // GET: quizs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            quiz quiz = db.quizs.Find(id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // POST: quizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            quiz quiz = db.quizs.Find(id);
            db.quizs.Remove(quiz);
            db.SaveChanges();
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

        public ActionResult HelpSuggestion()
        {
            return View();
        }

        public ActionResult CheckList()
        {
            return View();
        }

        public ActionResult ViolenceSign()
        {
            return View();
        }

        public ActionResult SupportGroup()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }
    }
}
