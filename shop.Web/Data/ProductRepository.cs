
namespace shop.Web.Data
{
    using System.Threading.Tasks;
    using Entities;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

      
    }

}
