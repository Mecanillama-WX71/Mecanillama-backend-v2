using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;

namespace Mecanillama.Specs;

[Binding]
public class LosPasos : IDisposable
{
    private ChromeDriver driver;
    public LosPasos() => driver = new ChromeDriver();
    
    [Given(@"que quiero un test")]
    public void GivenQueQuieroUnTest()
    {
        driver.Navigate().GoToUrl("http://localhost:3000/home");
        driver.Manage().Window.Size = new System.Drawing.Size(1443, 768);
    }

    [Given(@"abri el programa")]
    public void GivenAbriElPrograma()
    {
        driver.FindElement(By.CssSelector(".button:nth-child(1) .p-button-label")).Click();
    }

    [When(@"digo hola")]
    public void WhenDigoHola()
    {
        driver.FindElement(By.XPath("//div[@id=\'app\']/div/div[2]/div/form/div[1]/div/span/input")).Click();
        driver.FindElement(By.XPath("//div[@id=\'app\']/div/div[2]/div/form/div/div/span/input")).SendKeys("Carlos");
        driver.FindElement(By.CssSelector(".m-3:nth-child(2) .p-inputtext")).SendKeys("carlos@gmail.com");
        driver.FindElement(By.CssSelector(".m-3:nth-child(3) .p-inputtext")).SendKeys("carlos123");
        driver.FindElement(By.CssSelector(".p-dropdown-label")).Click();
    }
    
    [Then(@"dice hola")]
    public void ThenDiceHola()
    {
        driver.FindElement(By.CssSelector(".p-dropdown-item:nth-child(2)")).Click();
        driver.FindElement(By.CssSelector(".p-button")).Click();
    }

    public void Dispose()
    {
        driver.Dispose();
    }
}