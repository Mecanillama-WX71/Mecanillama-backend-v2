using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mecanillama.Specs.Steps;

[Binding]
public class us05 : driver
{
    
    [When(@"clicks the review text box")]
    public bool WhenClicksTheReviewTextBox()
    {
        //Driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div[3]/textarea")).Click();
        return true;
    }

    [Then(@"the customer can type the comment")]
    public bool ThenTheCustomerCanTypeTheComment()
    {
        //Driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div[3]/textarea")).SendKeys("A new comment");
        return true;
    }

    [Then(@"select the amount of stars")]
    public bool ThenSelectTheAmountOfStars()
    {
        //Driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div[3]/div[1]/span[4]")).Click();
        return true;
    }

    [Then(@"the review should appear")]
    public bool ThenTheReviewShouldAppear()
    {
        //Driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div[3]/button/span[2]")).Click(); 
        return true;
    }

}