using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Mecanillama.ITests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public async Task DefaultRoute_Login()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();

            var response = await httpClient.GetAsync("/api/v1/Customers");
            var stringResult = await response.Content.ReadAsStringAsync();
            var search = stringResult.Contains("customer");
            Assert.IsTrue(search);
        }
    }
}