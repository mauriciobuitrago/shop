

namespace shop.Web.Data
{
    using Entities;

    public class CountrytRepository : GenericRepository<Country>, ICountrytRepository
    {
        public CountrytRepository(DataContext context) : base(context)
        {
        }
    }
}
