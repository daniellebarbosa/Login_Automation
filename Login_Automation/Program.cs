using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login_Automation
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://www.americanas.com.br/");

			driver.FindElement(By.Id("h_usr-link")).Click();
			driver.FindElement(By.Id("h_usr-signin")).Click();

			driver.FindElement(By.Id("email-input")).SendKeys("exemploteste1401@gmail.com");
			driver.FindElement(By.Id("password-input")).SendKeys("teste9876");

			driver.FindElement(By.Id("login-button")).Click();

			if (driver.Url == "https://www.americanas.com.br/")
			{
				driver.Quit();
			}
			else
			{
				Console.WriteLine("Erro no login");
			}
		}
	}
}
