using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager :IWriterService
	{
		IWriterDal _writeldal;

		public WriterManager(IWriterDal writeldal)
		{
			_writeldal = writeldal;
		}

		public void WriteAdd(Writer writer)
		{
			_writeldal.Insert(writer);
		}


	
	}
}
