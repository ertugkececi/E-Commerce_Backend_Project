// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();
CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
    }
    Console.WriteLine("---------------------------\n");
}

static void CategoryTest()
{
    CategoryManager CategoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in CategoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
    Console.WriteLine("---------------------------\n");
}