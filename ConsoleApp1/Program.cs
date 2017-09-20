using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PruebaE2E
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Driver");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:56625");

            IWebElement linkMedicos = driver.FindElement(By.LinkText("Medicos"));
            linkMedicos.Click();
            IWebElement linkCreate = driver.FindElement(By.LinkText("Create New"));
            linkCreate.Click();

            IWebElement id = driver.FindElement(By.Id("idmedico"));
            IWebElement nombre = driver.FindElement(By.Id("nombre"));
            IWebElement apellido = driver.FindElement(By.Id("apellido"));
            IWebElement ident = driver.FindElement(By.Id("identificacion"));
            IWebElement boton = driver.FindElement(By.Id("boton"));

            id.SendKeys("10");
            nombre.SendKeys("Luis Felipe");
            apellido.SendKeys("Sosa Alvarez");
            ident.SendKeys("1234567");
            boton.Click();      
        }
    }
}
