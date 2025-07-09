using ProductClient.Models; 
namespace ProductClient.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;

        public ProductService(IHttpClientFactory factory)
        {
            _http = factory.CreateClient("ProductApi");
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _http.GetFromJsonAsync<List<Product>>("products");
        }

        public async Task AddProductAsync(Product product)
        {
            await _http.PostAsJsonAsync("products", product);
        }
    }
}