namespace SIB.MainApp.Data
{
	public class ProductService
	{
		List<Product> products = new List<Product>() {
			/* Здесь создаются объекты */
			new Product(){ProductID = 1, ProductName="Computer",Price=50000, PurchaseDate=Convert.ToDateTime("03-Dec-2023")}
		};

		public async Task<List<Product>> ProductList()
		{
			return await Task.FromResult(products);
		}
	}
}
