using StoreData.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreServices.Interface
{
    public interface IProductRepository
    {
        public Task<List<Product>> ReceiveAllProductReposutoryAsync();
        public Task<string> AddProductAsync(Product productPresenter);
        public Task<string> ChangeProductAsync(Product productPresenter);
        public Task<string> DeleteProductAsync(int id);
    }
}
