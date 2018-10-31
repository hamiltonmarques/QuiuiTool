using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using Xceed.Words.NET;

namespace TestProject
{
    [TestClass]
    public class TestClassB
    {
        [TestMethod]
        public void FrenchFriesTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("French Fries");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[FrenchFriesTest]");
            logs.Add("Open google page.");
            logs.Add("Fill field search.");
            logs.Add("Enter pressed.");
            logs.Add("Validating links.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.IsTrue(true, "Some message.");

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void FruitSaladTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Fruit Salad");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.IsTrue(true, "Some message.");
        }

        [TestMethod]
        public void MashedPotatoesTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Mashed Potatoes");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[MashedPotatoesTest]");
            logs.Add("Finding web element.");
            logs.Add("Element found.");
            logs.Add("Scroll up page.");
            logs.Add("Taking print.");
            logs.Add("Validating data base select.");
            logs.Add("Updating field search.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Assert.AreEqual("Potato", "Carrot", "Incorrect main ingredient name.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void PuddingTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Pudding");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[PuddingTest]");
            logs.Add("Loading service requests.");
            logs.Add("Fill field search with invalid characters.");
            logs.Add("Click on search button.");
            logs.Add("Select value 30 on Size select field.");
            logs.Add("Click on Send button.");
            logs.Add("Validating successfull addition message.");
            logs.Add("It is a very long log. I am writing something only to look scrolls on text field and to validate how is displayed. Let me see if it works with a very long log. Everything that has a beginning has an end.");
            logs.Add("Copy value from comments field.");
            logs.Add("Checking backwards compatibility.");
            logs.Add("Select only Pudding.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Docx.AddText("Pudding is a type of food that can be either a dessert or a savory dish.", Alignment.right, docxName);

            Assert.IsTrue(false, "Container did not load recipes menu.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void WatermelonTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Watermelon");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[WatermelonTest]");
            logs.Add("Initializing inconclusive test.");
            logs.Add("Field Recipes filled successfully.");
            logs.Add("Searching by partial name.");
            logs.Add("Validating select items.");
            logs.Add("Loading page results.");
            logs.Add("Select menu fruits.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Assert.Inconclusive("Watermelon dessert not found. It must be avaiable.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void ApplePieTest(string docxName, List<string> logs)
        {
            IWebDriver driver = Quiui.GetDriver(docxName);

            IWebElement TxtSearch = driver.FindElement(By.Name("q"));
            TxtSearch.SendKeys("Apple Pie");
            TxtSearch.Submit();

            Quiui.Token.ThrowIfCancellationRequested();

            logs.Add("[ApplePieTest]");
            logs.Add("Waiting page loading.");
            logs.Add("Settings are ready. Allow share pie.");

            Thread.Sleep(3000);

            Quiui.Token.ThrowIfCancellationRequested();

            Quiui.TakeScreenshot(driver, docxName);

            Docx.AddText("An apple pie is a pie or a tart, in which the principal filling ingredient is apple.", Alignment.right, docxName);

            Assert.Inconclusive("Account without access privilege.");

            logs.Add("Test finished.");
        }

        [TestMethod]
        public void SpaghettiTest()
        {
            // Test unknown.
        }
    }
}