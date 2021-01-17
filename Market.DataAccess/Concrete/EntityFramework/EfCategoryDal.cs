using Core.DataAccess.Concrete.EntityFramework;
using Market.DataAccess.Abstract;
using Market.DataAccess.Concrete.EntityFramework.Contexts;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
