﻿using DataAccess.Abstract;
using DataAccess.Repository;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>,IAboutDal
    {

    }
}
