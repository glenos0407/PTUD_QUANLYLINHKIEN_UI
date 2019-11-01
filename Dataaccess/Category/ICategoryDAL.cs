﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public interface ICategoryDAL
    {
        Category GetCategoryByName(string name);
        List<Category> GetAllCategory();
    }
}
