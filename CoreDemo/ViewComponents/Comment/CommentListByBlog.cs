﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{ 
		CommentManeger cm = new CommentManeger(new EfCommentRepository());

		public IViewComponentResult Invoke(int id)
		{
			var values = cm.GetList(id);
			return View(values);
		}
	}

}
