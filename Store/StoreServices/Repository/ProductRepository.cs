using Microsoft.EntityFrameworkCore;
using StoreData.ConnectDB;
using StoreData.Entyties;
using StoreServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreServices.Repository
{
    public class ProductRepository : IProductRepository
    {
        DataContext _context;

        public ProductRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<string> AddProductAsync(Product productPresenter)
        {
            await _context.Products.AddAsync(productPresenter);
            await _context.SaveChangesAsync();

            return "Продукт успешно добавлен";
        }

        public async Task<string> ChangeProductAsync(Product productPresenter)
        {
            Product findProduct = await _context.Products.FirstOrDefaultAsync(x=>x.Id == productPresenter.Id);

            if (findProduct is null)
                return "Данный продукт не был найден в базе данных";

            findProduct.NameProduct = productPresenter.NameProduct;
            findProduct.Price = productPresenter.Price;

            await _context.SaveChangesAsync();

            return "Продукт успешно изменен";
        }

        public async Task<string> DeleteProductAsync(int id)
        {
            Product findProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (findProduct is null)
                return "Данный продукт не был найден в базе данных";

            _context.Products.Remove(findProduct);

            await _context.SaveChangesAsync();

            return "Продукт успешно удален";
        }

        public async Task<List<Product>> ReceiveAllProductReposutoryAsync()
        {
            return await _context.Products.ToListAsync();
        }

    }
}
