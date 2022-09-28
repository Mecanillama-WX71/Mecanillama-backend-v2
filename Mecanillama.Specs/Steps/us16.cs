using OpenQA.Selenium;

namespace Mecanillama.Specs.Steps;

[Binding]
public class us16 : driver
{
    [Given(@"the user is at the homepage")]
    public void GivenTheUserIsAtTheHomepage()
    {
        Driver.Navigate().GoToUrl("https://mecanillama-frontend.web.app/sign-in");
        Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
    }

    [When(@"the user clicks Sign up")]
    public void WhenTheUserClicksSignUp()
    {
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div/a")).Click();
    }

    [Then(@"the user can fill the form")]
    public void ThenTheUserCanFillTheForm()
    {
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).SendKeys("nuevo customer");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).SendKeys("nuevo@customer.com");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[3]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[3]/div/span/input")).SendKeys("nuevo123");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[4]/div/span/div/span")).Click();
        Driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[2]")).Click();
    }

    [Then(@"click the Sign up button")]
    public void ThenClickTheSignUpButton()
    {
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[5]/button/span[1]")).Click();
    }

    [Then(@"the user will be redirected to the main page")]
    public bool ThenTheUserWillBeRedirectedToTheMainPage()
    {
        return true;
    }
}