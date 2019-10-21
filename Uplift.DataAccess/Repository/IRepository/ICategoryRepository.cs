﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.Models;

namespace Uplift.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();
        void Update(Category category);

    }
}