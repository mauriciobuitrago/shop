
namespace Shop.UIForms.ViewModels
{
    using shop.Common.Models;
    using shop.Common.Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Products> products;
        public ObservableCollection<Products> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }


        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.loadProducts();

        }

        private async void loadProducts()
        {
            var response = await this.apiService.GetListAsync<Products>(
                "https://shopmaufenix.azurewebsites.net",
                "/api",
                "/Products"
                );
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "ERROR",
                    response.Message,
                    "Accept");
                return;

            }
            var myProducts = (List<Products>)response.Result;
            //products is the variable  that it in product page
            this.Products = new ObservableCollection<Products>(myProducts);
        }
    }

}
