using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using Xceed.Words.NET;

namespace TestProject
{
    [TestClass]
    public class TestClassA
    {
        [TestMethod]
        public void FranceTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("France");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[FranceTest]");
            logs.Add("Open google page.");
            logs.Add("Fill field search.");
            logs.Add("Enter pressed.");
            logs.Add("Validating links.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.IsTrue(true, "Some message.");

            Quiui.Token.ThrowIfCancellationRequested();

            Docx.AddText("France, in Western Europe, encompasses medieval cities, alpine villages and Mediterranean beaches.", Alignment.left, docxName);

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void PanamaTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Panama");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.IsTrue(true, "Some message.");
        }

        [TestMethod]
        public void PortugalTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Portugal");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[PortugalTest]");
            logs.Add("Finding web element.");
            logs.Add("Element found.");
            logs.Add("Scroll up page.");
            logs.Add("Taking print.");
            logs.Add("Validating data base select.");
            logs.Add("Updating field search.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.AreEqual("Lisbon", "Porto", "Incorrect largest city name.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void SpainTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Spain");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[SpainTest]");
            logs.Add("Loading service requests.");
            logs.Add("Fill field search with invalid characters.");
            logs.Add("Click on search button.");
            logs.Add("Select value 30 on Size select field.");
            logs.Add("Click on Send button.");
            logs.Add("Validating successfull addition message.");
            logs.Add("It is a very long log. I am writing something only to look scrolls on text field and to validate how is displayed. Let me see if it works with a very long log.");
            logs.Add("Copy value from comments field.");
            logs.Add("Checking backwards compatibility.");
            logs.Add("Select only Spain facts.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Assert.IsTrue(false, "Page did not load castles architecture.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void SingaporeTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Singapore");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[SingaporeTest]");
            logs.Add("Initializing inconclusive test.");
            logs.Add("Field Adress filled successfully.");
            logs.Add("Searching by partial name.");
            logs.Add("Validating select items.");
            logs.Add("Loading page results.");
            logs.Add("Select menu Orders.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Docx.AddText("Singapore, an island city-state off southern Malaysia, is a global financial center with a tropical climate and multicultural population.", Alignment.center, docxName);

            Assert.Inconclusive("Singapore flag not found. It must be displayed.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void SenegalTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Senegal");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[SenegalTest]");
            logs.Add("Waiting page loading.");
            logs.Add("Settings are ready. Allow export file.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.Inconclusive("Account without access authorization.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void Japan5minTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Japan");
            TxtSearch.Submit();

            Quiui.TakeScreenshot(driver, docxName);

            for (int i = 0; i < 60; i++)
            {
                Quiui.Token.ThrowIfCancellationRequested();
                Thread.Sleep(5000);
            }
        }
    }
}