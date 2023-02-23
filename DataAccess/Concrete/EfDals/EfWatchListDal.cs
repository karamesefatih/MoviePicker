﻿using Core.Concrete;
using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfDals
{
    public class EfWatchListDal:GenericRepository<WatchList,MoviePickerContext>,IWatchListDal
    {
    }
}
