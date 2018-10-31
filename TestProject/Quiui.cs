using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace TestProject
{
    /// <summary>
    /// Provides methods to:
    /// create the directories used by QuiuiTool application;
    /// create the ChromeDriver instances used in the tests;
    /// take a screenshot of a web page;
    /// quit the ChromeDriver instances.
    /// </summary>
    /// <remarks>
    /// The MIT License (MIT) Copyright (c) 2018 Hamilton Marques.
    /// Meet Hamilton Marques at http://bit.do/HamiltonLinkedIn
    /// Videos about QuiuiTool at http://bit.do/QuiuiTool
    /// </remarks>
    public class Quiui
    {
        #region Fields
        /// <summary>
        /// Used to throw a System.OperationCanceledException when the cancellation of the run of the tests is requested.
        /// </summary>
        public static CancellationToken Token;

        /// <summary>
        /// Exposes instance methods for creating, moving, and enumerating through directories and subdirectories.
        /// </summary>
        private static DirectoryInfo dInfo;

        /// <summary>
        /// Represents the access control and audit security for a directory.
        /// </summary>
        private static DirectorySecurity dSecurity;

        /// <summary>
        /// Represents an abstraction of an access control entry (ACE) that defines an access rule for a file or directory.
        /// </summary>
        private static FileSystemAccessRule fRule;

        /// <summary>
        /// Used to add arguments in the list of arguments to be appended to the Chrome.exe command line.
        /// </summary>
        private static ChromeOptions options = new ChromeOptions();

        /// <summary>
        /// Used to keep the ChromeDriver instances while the run of the tests.
        /// </summary>
        private static Dictionary<string, IWebDriver> drivers = new Dictionary<string, IWebDriver>();

        /// <summary>
        /// URL of the website to be loaded.
        /// Change the URL value (essential step).
        /// </summary>
        private const string URL = "https://google.com/ncr";

        /// <summary>
        /// Root directory of the QuiuiTool application data.
        /// </summary>
        public static string rootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\SystemData";

        /// <summary>
        /// Directory of the evidence files.
        /// </summary>
        public static string docxFolder = rootFolder + @"\Docx";

        /// <summary>
        /// Directory of the screenshot images.
        /// </summary>
        public static string pngFolder = rootFolder + @"\Png";

        /// <summary>
        /// Used to make the name of the evidences file single.
        /// </summary>
        public const string format = "MMddyyyyHHmmss_";
        #endregion

        #region Quiui
        /// <summary>
        /// Adds the arguments in the list of arguments to be appended to the Chrome.exe command line.
        /// </summary>
        static Quiui()
        {
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-infobars");
        }
        #endregion

        #region CreateDirectories
        /// <summary>
        /// Creates the root directory of the QuiuiTool application data and sets the access control.
        /// </summary>
        private static void CreateRootFolder()
        {
            Directory.CreateDirectory(rootFolder);
            dInfo = new DirectoryInfo(rootFolder);
            dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(fRule);
            dInfo.SetAccessControl(dSecurity);
        }

        /// <summary>
        /// Creates the directory of the evidence files and sets the access control.
        /// </summary>
        public static void CreateDocxFolder()
        {
            if (!Directory.Exists(rootFolder))
            {
                CreateRootFolder();
            }

            Directory.CreateDirectory(docxFolder);
            dInfo = new DirectoryInfo(docxFolder);
            dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(fRule);
            dInfo.SetAccessControl(dSecurity);
        }

        /// <summary>
        /// Creates the directory of the screenshot images and sets the access control.
        /// </summary>
        private static void CreatePngFolder()
        {
            if (!Directory.Exists(rootFolder))
            {
                CreateRootFolder();
            }

            Directory.CreateDirectory(pngFolder);
            dInfo = new DirectoryInfo(pngFolder);
            dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(fRule);
            dInfo.SetAccessControl(dSecurity);
        }

        /// <summary>
        /// Create the directories used by QuiuiTool application.
        /// </summary>
        public static void CreateFolders()
        {
            fRule = new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);

            CreateDocxFolder();
            CreatePngFolder();
        }
        #endregion

        #region GetDriver
        /// <summary>
        /// Creates a ChromeDriver instance and loads the website of the URL string.
        /// </summary>
        /// <param name="driverKey">Key of the ChromeDriver instance.</param>
        /// <returns>A ChromeDriver instance.</returns>
        public static IWebDriver GetDriver(string driverKey)
        {
            Token.ThrowIfCancellationRequested();

            ChromeDriverService ChromeService = ChromeDriverService.CreateDefaultService();
            ChromeService.HideCommandPromptWindow = true;

            Token.ThrowIfCancellationRequested();

            IWebDriver driver = new ChromeDriver(ChromeService, options);

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(25000);
            driver.Navigate().GoToUrl(URL);

            drivers.Add(driverKey, driver);

            Token.ThrowIfCancellationRequested();

            return driver;
        }
        #endregion

        #region QuitDriver
        /// <summary>
        /// Quits a ChromeDriver instance contained in the drivers dictionary, closing every associated window.
        /// </summary>
        /// <param name="driverKey">Key of the ChromeDriver instance.</param>
        public static void QuitDriver(string driverKey)
        {
            if (drivers.ContainsKey(driverKey))
            {
                drivers[driverKey].Quit();
                drivers.Remove(driverKey);
            }
        }
        #endregion

        #region TakeScreenshot
        /// <summary>
        /// Takes a screenshot of a web page and adds the image in a Microsoft Word file.
        /// </summary>
        /// <param name="driver">ChromeDriver intance.</param>
        /// <param name="docxName">Name of the Microsoft Word file.</param>
        public static void TakeScreenshot(IWebDriver driver, string docxName)
        {
            if (!Directory.Exists(pngFolder))
            {
                CreatePngFolder();
            }

            string pngPath = pngFolder + @"\" + docxName + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(pngPath, ScreenshotImageFormat.Png);

            Docx.AddImage(pngPath, docxName);
        }
        #endregion

        #region DebugEx
        /// <summary>
        /// Writes informations about an exception to the trace listeners in the Debug.Listeners collection.
        /// </summary>
        /// <param name="ex">Exception thrown.</param>
        public static void DebugEx(Exception ex)
        {
            Debug.WriteLine(Environment.NewLine + "Message: " + ex.Message +
                            Environment.NewLine + "Type: " + ex.GetType().Name +
                            Environment.NewLine + ex.StackTrace +
                            Environment.NewLine);
        }
        #endregion
    }
}