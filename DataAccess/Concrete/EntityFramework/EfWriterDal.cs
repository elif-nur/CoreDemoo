﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class EfWriterDal:GenericRepository<Writer>,IWriterDal
    {
    }
}
