using OpenQA.Selenium;

namespace Mecanillama.Specs.Steps;

[Binding]
public class us15 : driver
{
    [Given(@"the mechanic logs in")]
    public void GivenTheMechanicLogsIn()
    {
        Driver.Navigate().GoToUrl("https://mecanillama-frontend.web.app/sign-in");
        Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[1]/div/span/input")).SendKeys("mechanic1@mechanic.com");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).Click();
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/div/span/input")).SendKeys("mechanic123");
        Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[4]/button/span[1]")).Click();
    }

    [When(@"the mechanic sees his profile")]
    public bool WhenTheMechanicSeesHisProfile()
    {
        return true;
    }

    [Then(@"the mechanic can see all their appointments")]
    public bool ThenTheMechanicCanSeeAllTheirAppointments()
    {
        return true;
    }
}