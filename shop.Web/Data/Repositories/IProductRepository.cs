﻿
namespace shop.Web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IProductRepository : IGenericRepository<Product>
    {
       
            IQueryable GetAllWithUsers();

          IEnumerable<SelectListItem> GetComboProducts();

    }

}
