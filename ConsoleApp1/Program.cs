using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class SeleniumDemo {
    static void Main()
    {
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("--headless");
        var driver = new ChromeDriver(chromeOptions);
        
        Console.WriteLine("start");
        driver.Navigate().GoToUrl("http://www.baidu.com");
        driver.Manage().Cookies.AddCookie(new Cookie("xxxtoken","xxxcokenValue",".baidu.com","/", new DateTime(2023,5,5)));

        PrintOptions printOptions = new PrintOptions();
        PrintDocument doc = driver.Print(printOptions);
        try
        {
            doc.SaveAsFile("./csharp-selenium-out.pdf");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        Console.WriteLine("end");
        driver.Quit();
    }
}