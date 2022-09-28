using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Mecanillama.Specs.Steps;

public class driver
{
    public IWebDriver Driver;
    public StringBuilder verificationErrors;

    public driver()
    {
        Driver = new ChromeDriver(); //replace with required driver
        verificationErrors = new StringBuilder();
    }
}