﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> GetAll();
        Blog GetById(int id);
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
    }
}
