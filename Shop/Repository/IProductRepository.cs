using System.Collections.Generic;
using Shop.Models.Northwind;

public interface IProductRepository : IRepository<Product>
{
    //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
}
