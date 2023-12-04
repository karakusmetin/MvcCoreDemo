using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Responsitories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
		public List<int> GetListCommentId()
		{
			using (var cm = new Context()) 
			{ 
				return cm.Comment.Select(x=>x.BlogID).ToList();	
			}
			

		}
	}
}
