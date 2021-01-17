using System;
using System.Collections.Generic;
using System.Text;
using Market.Entity.Concrete;

namespace Market.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
