            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class ProductRepository : Repository<Product>, IProductRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public ProductRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IProductRepository.cs file
}
