using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManeger cm = new CommentManeger(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment() 
		{ 
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
