
namespace shop.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {
       
            IQueryable GetAllWithUsers();
        

    }

}
