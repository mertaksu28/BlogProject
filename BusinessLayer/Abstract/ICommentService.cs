using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll(int id);
      //  Comment GetById(int id);
        void Add(Comment comment);
       // void Delete(Comment comment);
       // void Update(Comment comment);
    }
}
