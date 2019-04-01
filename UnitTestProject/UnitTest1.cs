using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod() //CHROME AYAĞA KALDIRMA TESTCASE'i
        {
            var uri = "http://localhost:4444/wd/hub";  // Ayağa kalkan HUB adresimiz
            var capabilities = new ChromeOptions().ToCapabilities();  // Node da çalışacak Browser (Chrome-Option / Firefox-Profile)
            var commandTimeout = TimeSpan.FromMinutes(5); // Boş yapmasın diye :))
            var driver = new RemoteWebDriver(new Uri(uri), capabilities, commandTimeout);

            /* Normalde IWebDriver üzerinden klasik _driver instance oluştururduk ...
            *  ama Gridlerdeki Nodelarımızın farklı
            *  platform(os:linux_sürümleri/win10/win7/mac..cs.) 
            *  ve
            *  browser(chrome/firefox/edge...vs.) 
            *  seçenekleriyle test senaryoları koştuğumuz için burda RemoteWebDriver üzerinden driver tanımlıyoruz.*/
            
            driver.Navigate().GoToUrl("https://www.amazon.com/"); 
            // örnek olarak Node içerisinden Chrome ile Amozon.com'u ziyarete geldik  
            // anlamadığınız yer olursa ->> oguzhanvarol@outlook.com.tr 
        }
    }
}
