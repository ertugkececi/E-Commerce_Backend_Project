// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var productResult = productManager.GetProductDetails();
    if (productResult.Success == true)
    {
        foreach (var product in productResult.Data)
        {
            Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
        }
    }
    else Console.WriteLine(productResult.Message);
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