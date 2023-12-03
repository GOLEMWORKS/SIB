namespace SIB.MainApp.Data
{
	public class ProductService
	{
		List<Product> products = new List<Product>() {
			/* Здесь создаются объекты */
			new Product(){ProductID = 1, ProductName="Computer1",Price=50000, PurchaseDate=Convert.ToDateTime("03-Dec-2023")},
			new Product(){ProductID = 2, ProductName="Computer2",Price=40000, PurchaseDate=Convert.ToDateTime("02-Dec-2023")},
			new Product(){ProductID = 3, ProductName="Computer3",Price=25000, PurchaseDate=Convert.ToDateTime("01-Dec-2023")},
			new Product(){ProductID = 4, ProductName="Computer4",Price=35000, PurchaseDate=Convert.ToDateTime("02-Dec-2023")},
			new Product(){ProductID = 5, ProductName="Computer5",Price=60000, PurchaseDate=Convert.ToDateTime("03-Dec-2023")}
		};

		public async Task<List<Product>> ProductList()
		{
			return await Task.FromResult(products);
		}
	}
}
