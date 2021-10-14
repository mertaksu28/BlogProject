using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PartialAddComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment comment)
        {
            comment.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            comment.BlogId = 2;
            commentManager.Add(comment);
            return RedirectToAction("Index", "Blog");
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAll(id);
            return PartialView(values);
        }

    }
}
