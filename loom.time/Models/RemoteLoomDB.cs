using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace loom.time.Models
{
    public class RemoteLoomDB
    {
        static HttpClient client = new HttpClient();
        /*
        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/products", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        
        static async Task<Staff> GetStaffAsync(long staffid)
        {
            Staff staff = null;
        //    HttpResponseMessage response = await client.GetAsync(new Uri($"api/staff/{staff.StaffID}", staff));
        //HttpResponseMessage response = await client.GetAsync(string.Format("/Layouts/{0}", machineInformation.LocalMachineName()));
            if (response.IsSuccessStatusCode)
            {
                staff = await response.Content.ReadAsAsync<Staff>();
            }
            return staff;
        }
        
        
        
         * // No final slash
var baseUri = new Uri("https://localhost:44302/AndonService.svc");
var uri = new Uri(baseUri, "Layouts/1100-00277");
Console.WriteLine(uri);
// Prints "https://localhost:44302/Layouts/1100-00277"


// With final slash
var baseUri = new Uri("https://localhost:44302/AndonService.svc/");
var uri = new Uri(baseUri, "Layouts/1100-00277");
Console.WriteLine(uri);
// Prints "https://localhost:44302/AndonService.svc/Layouts/1100-00277"
         */
        
        
        /*
        static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }
*/
        RemoteLoomDB()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:64195/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
  /*              // Create a new product
                Product product = new Product
                {
                    Name = "Gizmo",
                    Price = 100,
                    Category = "Widgets"
                };

                var url = await CreateProductAsync(product);
                Console.WriteLine($"Created at {url}");

                // Get the product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Update the product
                Console.WriteLine("Updating price...");
                product.Price = 80;
                await UpdateProductAsync(product);

                // Get the updated product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Delete the product
                var statusCode = await DeleteProductAsync(product.Id);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");
*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

    }
}