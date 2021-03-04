﻿using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        

        IDataResult<List<Brand>> GetByColorId(int ıd);
        IDataResult<List<Brand>> GetByBrandId(int ıd);
        IDataResult<List<Brand>> GetByCategoryId(int ıd);

        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
    }
}
