using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Mecanillama.ITests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public async Task Customers_Get()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("/api/v1/Customers");
            var stringResult = await response.Content.ReadAsStringAsync();
            var search = stringResult.Contains("customer");
            Assert.IsTrue(search);
        }
        [TestMethod]
        public async Task Appointments_Get()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("/api/v1/Appointments");
            var stringResult = await response.Content.ReadAsStringAsync();
            var search = stringResult.Contains("10:00");
            Assert.IsTrue(search);
        }
        
        [TestMethod]
        public async Task Mechanics_Get()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("/api/v1/Mechanics");
            var stringResult = await response.Content.ReadAsStringAsync();
            var search = stringResult.Contains("mechanic");
            Assert.IsTrue(search);
        }
        
        [TestMethod]
        public async Task Reviews_Get()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("/api/v1/Reviews");
            var stringResult = await response.Content.ReadAsStringAsync();
            Assert.IsNotNull(stringResult);
        }
    }
}