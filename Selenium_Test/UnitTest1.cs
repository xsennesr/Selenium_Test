using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using Xunit;

public class SeleniumTest
{
    IWebDriver driver = new EdgeDriver();

    [Fact]
    public void ElementExist()
    {
        try
        {
            driver.Navigate().GoToUrl("https://is.stuba.sk/auth/?lang=sk");
            var element = driver.FindElement(By.Id("login-btn"));
            Assert.NotNull(element);
        }
        finally
        {
            driver.Quit();
        }
    }

    [Fact]
    public void ElementDoesntExist()
    {
        try
        {
            driver.Navigate().GoToUrl("https://is.stuba.sk/auth/?lang=sk");
            var element = driver.FindElement(By.Id("login-btn2"));
            Assert.NotNull(element);
        }
        finally
        {
            driver.Quit();
        }
    }
}