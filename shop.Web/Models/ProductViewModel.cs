
namespace shop.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using shop.Web.Data.Entities;
   

    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]

        // iFormFile capture the file in memory.(images)
        public IFormFile ImageFile { get; set; }
    }

}
