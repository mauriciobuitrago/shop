using Microsoft.EntityFrameworkCore;
using shop.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Web.Data
{
    public class DataContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

        // conexion for  de data base 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
