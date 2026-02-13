using Core.DAL.Repositories.Concrete.EntityFrameworkCore;
using DataAccessLayer.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Text;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories.Concrete
{
    public class BrandRepository:EFBaseRepository<Brand, NtierDbContext>, IBrandRepository
    {
        public BrandRepository(NtierDbContext context):base(context)
        {}
    }
}
