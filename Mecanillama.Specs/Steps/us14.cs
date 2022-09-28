using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mecanillama.Specs.Steps;

[Binding]
public class us14 : driver
{
    private ChromeDriver driver;
    public us14() => driver = new ChromeDriver();

    [Given(@"the customer is at the homepage")]
    public void GivenTheCustomerIsAtTheHomepage()
    {
        Driver.Navigate().GoToUrl("https://mecanillama-frontend.web.app/sign-in");
        Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).SendKeys("customer@customer.com");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).SendKeys("customer123");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[4]/button/span[1]")).Click();
    }

    [When(@"the customer visits a mechanic profile")]
    public void WhenTheCustomerVisitsAMechanicProfile()
    {
        Thread.Sleep(5000);
        Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/div/div/div/div/div[2]/div/a/button")).Click();
    }

    [When(@"clicks the make an appointment button")]
    public void WhenClicksTheMakeAnAppointmentButton()
    {
        Thread.Sleep(5000);
        Driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div[2]/button")).Click();
            
    }

    [Then(@"the customer can select the required data")]
    public void ThenTheCustomerCanSelectTheRequiredData()
    {
        Thread.Sleep(5000);
        Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div/span/input")).Click();
        Thread.Sleep(1000);
        Driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/button[2]/span[1]")).Click();
        Thread.Sleep(1000);
        Driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[2]/table/tbody/tr[2]/td[4]/span")).Click();
        Thread.Sleep(1000);
        Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div/span")).Click();
        Driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[3]")).Click();
        Driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]/span[2]")).Click();
    }

    [Then(@"the appointment should be at the Appointments tab")]
    public void ThenTheAppointmentShouldBeAtTheAppointmentsTab()
    {
        
        Thread.Sleep(5000);
        Driver.FindElement(By.XPath("/html/body/div/div[1]/div/ul/li[2]/a/span[2]")).Click();
    }
}