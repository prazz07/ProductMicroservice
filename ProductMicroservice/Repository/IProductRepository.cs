using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(int ProductId);
        void Save();

    }
}
