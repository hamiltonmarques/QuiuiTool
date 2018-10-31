using QuiuiApp.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace QuiuiApp
{
    /// <summary>
    /// Represents the QuiuiTool application.
    /// Use QuiuiTool to manage the run of the web testing automated.
    /// </summary>
    /// <remarks>
    /// The MIT License (MIT) Copyright (c) 2018 Hamilton Marques.
    /// Meet Hamilton Marques at http://bit.do/HamiltonLinkedIn
    /// Videos about QuiuiTool at http://bit.do/QuiuiTool
    /// </remarks>
    public partial class FormQuiui : Form
    {
        #region Fields
        /// <summary>
        /// Used to split data.
        /// </summary>
        private const char cplit = '⁝';

        /// <summary>
        /// Used to split data.
        /// </summary>
        private const string split = "3cyQ8pow";

        /// <summary>
        /// Used to replace an empty string.
        /// </summary>
        private const string empty = "0tGYd4js";

        /// <summary>
        /// References the string[] that contains the texts of the interface.
        /// </summary>
        public static string[] text;

        /// <summary>
        /// Contains the texts of the interface in american English.
        /// </summary>
        private string[] usText = new string[55];

        /// <summary>
        /// Contains the texts of the interface in brazilian Portuguese.
        /// </summary>
        private string[] brText = new string[55];

        /// <summary>
        /// Contains the columns default width of the lvwResults control.
        /// </summary>
        private readonly int[] widthColumn = new int[] { 60, 100, 120, 130, 180 };

        /// <summary>
        /// Index of the sub-item that contains the name of the evidences file.
        /// </summary>
        private const int evidenceIndex = 5;

        /// <summary>
        /// Index of the sub-item that contains the key of the logs.
        /// </summary>
        private const int logIndex = 6;

        /// <summary>
        /// Total of new results.
        /// </summary>
        private int newResult = 0;

        /// <summary>
        /// Total of tests to be run.
        /// </summary>
        private int remain;

        /// <summary>
        /// Index of the first item of the lvwResults control to be saved.
        /// </summary>
        private int saveItemIndex;

        /// <summary>
        /// Index of the last item of the lvwResults control.
        /// </summary>
        private int lastItemIndex;

        /// <summary>
        /// Number of the result in the lvwResults control.
        /// </summary>
        private int number;

        /// <summary>
        /// Total of passed results.
        /// </summary>
        public static decimal passed;

        /// <summary>
        /// Total of failed results.
        /// </summary>
        public static decimal failed;

        /// <summary>
        /// Total of inconclusive results.
        /// </summary>
        public static decimal inconclusive;

        /// <summary>
        /// Total of results.
        /// </summary>
        private decimal results;

        /// <summary>
        /// Directory of the evidences files.
        /// </summary>
        private string docxFolder = Quiui.docxFolder;

        /// <summary>
        /// Name of the test.
        /// </summary>
        private string testName1;

        /// <summary>
        /// Result of the test.
        /// </summary>
        private string result1;

        /// <summary>
        /// Message of the test.
        /// </summary>
        private string message1;

        /// <summary>
        /// Name of the evidences file.
        /// </summary>
        private string docxName1;

        /// <summary>
        /// Name of the test.
        /// </summary>
        private string testName2;

        /// <summary>
        /// Result of the test.
        /// </summary>
        private string result2;

        /// <summary>
        /// Message of the test.
        /// </summary>
        private string message2;

        /// <summary>
        /// Name of the evidences file.
        /// </summary>
        private string docxName2;

        /// <summary>
        /// Name of the test.
        /// </summary>
        private string testName3;

        /// <summary>
        /// Result of the test.
        /// </summary>
        private string result3;

        /// <summary>
        /// Message of the test.
        /// </summary>
        private string message3;

        /// <summary>
        /// Name of the evidences file.
        /// </summary>
        private string docxName3;

        /// <summary>
        /// Name of the results file.
        /// </summary>
        private string txtName = string.Empty;

        /// <summary>
        /// Path of the results file.
        /// </summary>
        private string resultsPath;

        /// <summary>
        /// Identifies if the test passed.
        /// </summary>
        private bool passed1;

        /// <summary>
        /// Identifies if the test passed.
        /// </summary>
        private bool passed2;

        /// <summary>
        /// Identifies if the test passed.
        /// </summary>
        private bool passed3;

        /// <summary>
        /// Identifies if the test failed.
        /// </summary>
        private bool failed1;

        /// <summary>
        /// Identifies if the test failed.
        /// </summary>
        private bool failed2;

        /// <summary>
        /// Identifies if the test failed.
        /// </summary>
        private bool failed3;

        /// <summary>
        /// Identifies if the test is inconclusive.
        /// </summary>
        private bool inconclusive1;

        /// <summary>
        /// Identifies if the test is inconclusive.
        /// </summary>
        private bool inconclusive2;

        /// <summary>
        /// Identifies if the test is inconclusive.
        /// </summary>
        private bool inconclusive3;

        /// <summary>
        /// Identifies if the test exists.
        /// </summary>
        private bool unknown1;

        /// <summary>
        /// Identifies if the test exists.
        /// </summary>
        private bool unknown2;

        /// <summary>
        /// Identifies if the test exists.
        /// </summary>
        private bool unknown3;

        /// <summary>
        /// Identifies if the method this.Robot1 finished the run of its test.
        /// </summary>
        private bool finish1 = true;

        /// <summary>
        /// Identifies if the method this.Robot2 finished the run of its test.
        /// </summary>
        private bool finish2 = true;

        /// <summary>
        /// Identifies if the method this.Robot3 finished the run of its test.
        /// </summary>
        private bool finish3 = true;

        /// <summary>
        /// Identifies the property Enabled of the btnOpenEvidence control.
        /// </summary>
        private bool btnOpenEvidenceEnabled;

        /// <summary>
        /// Identifies if should call the method this.Activate.
        /// </summary>
        private bool activate = true;

        /// <summary>
        /// Identifies if there are new results.
        /// </summary>
        private bool newResultAdded;

        /// <summary>
        /// Identifies if the internet connection is available.
        /// </summary>
        private bool hasInternet;

        /// <summary>
        /// Identifies if should update the lblStats control.
        /// </summary>
        private bool updateLblStats;

        /// <summary>
        /// Identifies if some test was ordered.
        /// </summary>
        private bool lvwOrdered;

        /// <summary>
        /// Used to cancel the run of the tests.
        /// </summary>
        private CancellationTokenSource tokenSource;

        /// <summary>
        /// Total time of the run of all tests.
        /// </summary>
        private TimeSpan totalTime;

        /// <summary>
        /// Total time of the run of the last tests started.
        /// </summary>
        private TimeSpan elapsedTime;

        /// <summary>
        /// Total time of the run of the last tests started (for settings).
        /// </summary>
        private TimeSpan elapsedTime1;

        /// <summary>
        /// Total time of the run of the last tests started (for settings).
        /// </summary>
        private TimeSpan elapsedTime2;

        /// <summary>
        /// Total time of the run of the last tests started (for settings).
        /// </summary>
        private TimeSpan elapsedTime3;

        /// <summary>
        /// Used to update the total time of the run of the tests.
        /// </summary>
        private Stopwatch runTime = new Stopwatch();

        /// <summary>
        /// Used to order the results statistics.
        /// </summary>
        private Dictionary<string, decimal> stats = new Dictionary<string, decimal>();

        /// <summary>
        /// Used to keep the logs of the tests.
        /// </summary>
        private Dictionary<string, List<string>> tLogs = new Dictionary<string, List<string>>();

        /// <summary>
        /// Used to keep the names of the evidences files to be deleted.
        /// </summary>
        private List<string> docxDelete = new List<string>();

        /// <summary>
        /// Contains some websites address.
        /// </summary>
        private List<string> sites = new List<string>();

        /// <summary>
        /// Contains the logs of the test.
        /// </summary>
        private List<string> logs1;

        /// <summary>
        /// Contains the logs of the test.
        /// </summary>
        private List<string> logs2;

        /// <summary>
        /// Contains the logs of the test.
        /// </summary>
        private List<string> logs3;

        /// <summary>
        /// References the CultureInfo of the language of the interface.
        /// </summary>
        private CultureInfo culture;

        /// <summary>
        /// en-US CultureInfo.
        /// </summary>
        private CultureInfo usCulture = new CultureInfo("en-US");

        /// <summary>
        /// pt-BR CultureInfo.
        /// </summary>
        private CultureInfo brCulture = new CultureInfo("pt-BR");

        /// <summary>
        /// Contains the tests to be run.
        /// </summary>
        private Stack<string> tests = new Stack<string>();

        /// <summary>
        /// Used to generate a pseudo-random number.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Used to keep the results arranged in rows of a html table.
        /// </summary>
        private StringBuilder buffer = new StringBuilder();

        /// <summary>
        /// Used to keep the ListView controls that contains the name of the tests.
        /// </summary>
        private List<ListView> lvwTests = new List<ListView>();
        #endregion

        #region FormQuiui
        /// <summary>
        /// Initializes a new instance of the FormQuiui class.
        /// </summary>
        public FormQuiui()
        {
            InitializeComponent();

            DoubleBuffer(lvwResults);
            lblStats.Text = string.Empty;

            Quiui.CreateFolders();

            InterfaceText();
            text = usText;

            SitesAddress();

            culture = usCulture;
        }
        #endregion

        #region FormQuiui_Load
        /// <summary>
        /// Loads the initial state of the QuiuiTool application.
        /// If the QuiuiTool application was not closed properly, a MessageBox is displayed.
        /// Occurs before the FormQuiui is displayed for the first time.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void FormQuiui_Load(object sender, EventArgs e)
        {
            LoadSettings();
            TabPageAdd();
            SecuritySetResults();
        }
        #endregion

        #region FormQuiui_FormClosing
        /// <summary>
        /// Displays a MessageBox when the user tries to close the QuiuiTool application while the run of the tests.
        /// If the new results have not yet been saved, displays a MessageBox to choose to save or not the new results, or to cancel the closing.
        /// Occurs when the FormQuiui is closing.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void FormQuiui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnStart.Enabled)
            {
                MessageBox.Show(text[45], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else if (newResult > 0)
            {
                string saveText;

                if (string.IsNullOrEmpty(txtName))
                {
                    saveText = text[46] + "\"" + text[29] + "\"?";
                }
                else
                {
                    saveText = text[46] + "\"" + txtName + "\"?";
                }

                DialogResult dr = MessageBox.Show(saveText, text[7], MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) // Save
                {
                    mnuSave.PerformClick();

                    this.Cursor = Cursors.AppStarting;

                    ClearSettings();

                    SaveSettings();
                }
                else if (dr == DialogResult.No) // Do not save
                {
                    this.Cursor = Cursors.AppStarting;

                    DeleteFiles(docxDelete);

                    ClearSettings();

                    SaveSettings();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.Cursor = Cursors.AppStarting;

                SaveSettings();
            }
        }
        #endregion

        #region FormQuiui_Activated
        /// <summary>
        /// Hides the focus cue if the ListView control that contains the tests has the input focus.
        /// Occurs when the FormQuiui is activated in code or by the user.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void FormQuiui_Activated(object sender, EventArgs e)
        {
            FocusCueFocus();
        }
        #endregion

        #region FormQuiui_Deactivate
        /// <summary>
        /// Activates the FormQuiui and gives it focus if the activate bool is true.
        /// Occurs when the FormQuiui loses focus and is no longer the active Form.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void FormQuiui_Deactivate(object sender, EventArgs e)
        {
            if (activate)
            {
                this.Activate();
            }

            activate = true;
        }
        #endregion

        #region LoadSettings
        /// <summary>
        /// Loads the interface settings of the user.
        /// All interface settings will be set to the default value if any interface setting of the user is corrupted.
        /// </summary>
        private void LoadSettings()
        {
            try
            {
                if (Settings.Default.mnuPortuguese)
                {
                    mnuPortuguese.PerformClick();
                }

                if (Settings.Default.mnuHide)
                {
                    mnuHide.PerformClick();
                }

                switch (Settings.Default.mnuNumber)
                {
                    case 1:
                        mnu1Test.PerformClick();
                        break;
                    case 2:
                        mnu2Tests.PerformClick();
                        break;
                }

                if (!Settings.Default.mnuCancel)
                {
                    mnuCancel.PerformClick();
                }

                if (!Settings.Default.mnuWatch)
                {
                    mnuWatch.PerformClick();
                }

                this.Width = Settings.Default.width;
                this.Height = Settings.Default.height;
                this.CenterToScreen();

                TestSettings();
            }
            catch (Exception ex)
            {
                mnuEnglish.PerformClick();
                mnuShow.PerformClick();
                mnu3Tests.PerformClick();

                if (!mnuCancel.Checked)
                {
                    mnuCancel.PerformClick();
                }

                if (!mnuWatch.Checked)
                {
                    mnuWatch.PerformClick();
                }

                this.Width = 1260;
                this.Height = 660;
                this.CenterToScreen();

                TestSettings();

                Quiui.DebugEx(ex);
            }
        }
        #endregion

        #region SaveSettings
        /// <summary>
        /// Saves the lvwTests, width and height settings.
        /// </summary>
        private void SaveSettings()
        {
            if (lvwOrdered)
            {
                Settings.Default.lvwTests.Clear();

                foreach (var item in lvwTests)
                {
                    foreach (ListViewItem lvi in item.Items)
                    {
                        Settings.Default.lvwTests.Add(Encrypt1(lvi.Text));
                    }

                    Settings.Default.lvwTests.Add(Encrypt1(cplit.ToString()));
                }
            }

            Settings.Default.width = this.Width;
            Settings.Default.height = this.Height;
            Settings.Default.Save();
        }
        #endregion

        #region NoOneTestChecked
        /// <summary>
        /// Verifies if no one test is checked.
        /// </summary>
        /// <returns>true if no one test is checked.</returns>
        private bool NoOneTestChecked()
        {
            foreach (var item in lvwTests)
            {
                if (item.CheckedItems.Count > 0) return false;
            }

            return true;
        }
        #endregion

        #region TestChecked
        /// <summary>
        /// Calculates the total of tests checked.
        /// </summary>
        /// <returns>The total of tests checked.</returns>
        private int TestChecked()
        {
            int total = 0;

            foreach (var item in lvwTests)
            {
                total += item.CheckedItems.Count;
            }

            return total;
        }
        #endregion

        #region PushTestStack
        /// <summary>
        /// Inserts the name of the tests checked in the tests Stack, from last to first.
        /// </summary>
        private void PushTestStack()
        {
            tests.Clear();

            for (int i = lvwTests.Count - 1; i >= 0; i--)
            {
                for (int j = lvwTests[i].CheckedItems.Count - 1; j >= 0; j--)
                {
                    tests.Push(lvwTests[i].CheckedItems[j].Text);
                }
            }
        }
        #endregion

        #region ItemCheck
        /// <summary>
        /// Keeps the check state of the items while the run of the tests.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!btnStart.Enabled)
            {
                if (e.CurrentValue == CheckState.Checked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    e.NewValue = CheckState.Unchecked;
                }
            }

            FocusCueFocus();
        }
        #endregion

        #region DoubleBuffer
        /// <summary>
        /// Prevents the flickering of a ListView control.
        /// </summary>
        /// <param name="lvw">ListView to be set.</param>
        private void DoubleBuffer(ListView lvw)
        {
            PropertyInfo prop;
            string name = "DoubleBuffered";
            BindingFlags bind = BindingFlags.Instance | BindingFlags.NonPublic;

            prop = lvw.GetType().GetProperty(name, bind);
            prop.SetValue(lvw, true);
        }
        #endregion

        #region OrderTest
        /// <summary>
        /// Orders a test.
        /// A MessageBox is displayed if no one test is selected.
        /// </summary>
        /// <param name="up">true moves to up; false moves to down.</param>
        private void OrderTest(bool up)
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            if (lvw.SelectedItems.Count > 0)
            {
                bool check = lvw.SelectedItems[0].Checked;

                bool position = up ? (lvw.SelectedItems[0].Index != 0) : (lvw.SelectedItems[0].Index != lvw.Items.Count - 1);

                if (position)
                {
                    string text = lvw.SelectedItems[0].Text;

                    int i = lvw.SelectedItems[0].Index;

                    int j = up ? (i - 1) : (i + 1);

                    lvw.BeginUpdate();

                    lvw.Items.RemoveAt(i);

                    lvw.Items.Insert(j, text);

                    lvw.Items[j].Selected = true;

                    lvw.FocusedItem = lvw.Items[j];

                    if (check)
                    {
                        lvw.Items[j].Checked = true;
                    }

                    lvw.EndUpdate();

                    lvwOrdered = true;
                }

                lvw.Select();
            }
            else
            {
                MessageBox.Show(text[33], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FocusCueSelect();
            }
        }
        #endregion

        #region ClearResults
        /// <summary>
        /// Clean up the controls and settings related to the results.
        /// </summary>
        private void ClearResults()
        {
            this.Cursor = Cursors.AppStarting;

            lvwResults.Items.Clear();

            for (int i = 0; i < lvwResults.Columns.Count; i++)
            {
                lvwResults.Columns[i].Width = widthColumn[i];
            }

            lblStats.Text = string.Empty;
            btnOpenEvidence.Enabled = false;
            txtLogs.Clear();
            lblResults.Text = text[6];

            mnuOpenResults.Enabled = true;
            mnuSave.Enabled = false;
            mnuSaveAs.Enabled = false;
            mnuChart.Enabled = false;
            mnuCopyResults.Enabled = false;
            mnuClear.Enabled = false;

            tLogs.Clear();
            buffer.Clear();

            passed = 0;
            failed = 0;
            inconclusive = 0;
            results = 0;
            newResult = 0;
            saveItemIndex = 0;
            lastItemIndex = 0;
            number = 0;

            txtName = string.Empty;
            resultsPath = null;

            totalTime = new TimeSpan();

            DeleteFiles(docxDelete);
            docxDelete.Clear();

            ClearSettings();

            this.Cursor = Cursors.Default;
        }
        #endregion

        #region EnabledFalse
        /// <summary>
        /// Changes the property Enabled of the controls to false.
        /// Exception cases:
        /// The property Enabled of the btnCancel control is changed to true.
        /// </summary>
        public void EnabledFalse()
        {
            this.Cursor = Cursors.AppStarting;

            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            btnCancel.Select();
            btnCheck.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnOpenEvidenceEnabled = btnOpenEvidence.Enabled;
            btnOpenEvidence.Enabled = false;

            mnuEnglish.Enabled = false;
            mnuPortuguese.Enabled = false;
            mnuOpenEvidencesFolder.Enabled = false;
            mnuNumber.Enabled = false;
            mnuOpenResults.Enabled = false;
            mnuSave.Enabled = false;
            mnuSaveAs.Enabled = false;
            mnuChart.Enabled = false;
            mnuCopyResults.Enabled = false;
            mnuClear.Enabled = false;
        }
        #endregion

        #region EnabledTrue
        /// <summary>
        /// Changes the property Enabled of the controls to true.
        /// Exception cases:
        /// The property Enabled of the btnCancel control is changed to false.
        /// The property Enabled of some controls is changed to true only if a condition is true.
        /// </summary>
        public void EnabledTrue()
        {
            btnStart.Enabled = true;
            btnStart.Select();
            btnCancel.Enabled = false;
            btnCheck.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnOpenEvidence.Enabled = btnOpenEvidenceEnabled;

            mnuEnglish.Enabled = true;
            mnuPortuguese.Enabled = true;
            mnuOpenEvidencesFolder.Enabled = true;
            mnuNumber.Enabled = true;

            if (newResult > 0)
            {
                mnuSave.Enabled = true;
            }

            if (results > 0)
            {
                mnuSaveAs.Enabled = true;
                mnuChart.Enabled = true;
                mnuCopyResults.Enabled = true;
                mnuClear.Enabled = true;
            }
            else
            {
                mnuOpenResults.Enabled = true;
            }

            this.Cursor = Cursors.Default;
        }
        #endregion

        #region ShowLogs
        /// <summary>
        /// Displays the logs of the test in the txtLogs control.
        /// </summary>
        private void ShowLogs()
        {
            if (lvwResults.SelectedItems.Count > 0)
            {
                if (lvwResults.SelectedItems[0].ImageIndex < 3 && mnuShow.Checked)
                {
                    string docxName = lvwResults.SelectedItems[0].SubItems[logIndex].Text;

                    if (!docxName.Equals(empty))
                    {
                        List<string> logs = tLogs[docxName];

                        StringBuilder sb = new StringBuilder();

                        sb.Append(logs[0]);

                        foreach (var log in logs.Skip(1))
                        {
                            sb.Append(Environment.NewLine + log);
                        }

                        txtLogs.Text = sb.ToString();
                    }
                }

                btnOpenEvidence.Enabled = (lvwResults.SelectedItems[0].ImageIndex < 3) && btnStart.Enabled ? true : false;
            }
            else
            {
                txtLogs.Clear();
            }
        }
        #endregion

        #region OpenShowDialog
        /// <summary>
        /// Displays the ofdResults control to open a txt file.
        /// Opening is canceled and a MessageBox is displayed if to occur an error.
        /// </summary>
        private void OpenShowDialog()
        {
            if (ofdResults.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OpenResults(ofdResults.FileName);
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;

                    Quiui.DebugEx(ex);

                    MessageBox.Show(text[40], text[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FocusCueFocus();
        }
        #endregion

        #region OpenResults
        /// <summary>
        /// Reads and validates the content of a txt file to load the results.
        /// After the finish of the reading and validations, adds the results in the lvwResults control.
        /// </summary>
        /// <param name="filePath">Path of the txt file.</param>
        /// <exception cref="System.Exception">Throws if the content of the txt file is not about results or if any data is corrupted.</exception>
        private void OpenResults(string filePath)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();

            this.Cursor = Cursors.AppStarting;

            StreamReader sr = new StreamReader(filePath);

            string header = Decrypt(sr.ReadLine());

            sr.Close();

            string[] _split = header.Split(cplit);

            int failedA = int.Parse(_split[0]);

            int inconclusiveA = int.Parse(_split[1]);

            int passedA = int.Parse(_split[2]);

            totalTime = TimeSpan.Parse(_split[3]);

            int passedB = 0;
            int failedB = 0;
            int inconclusiveB = 0;
            int _number = 0;

            ListView _lvwResults = new ListView();

            ListViewItem lvi = new ListViewItem();

            Dictionary<string, List<string>> _tLogs = new Dictionary<string, List<string>>();

            List<string> logs = new List<string>();

            StringBuilder _buffer = new StringBuilder();

            int imgIndex;

            bool result = true;

            string logIndexText;
            string _line = string.Empty;

            foreach (var line in File.ReadLines(filePath).Skip(1))
            {
                _line = Decrypt(line);

                if (_line.Equals(string.Empty))
                {
                    throw new Exception("_line.Equals(string.Empty)");
                }

                if (_line.Equals(split))
                {
                    logIndexText = lvi.SubItems[logIndex].Text;

                    if (logIndexText.Equals(empty) && logs.Count > 0)
                    {
                        throw new Exception("logIndexText.Equals(empty) && logs.Count > 0");
                    }

                    if (!logIndexText.Equals(empty) && logs.Count == 0)
                    {
                        throw new Exception("!logIndexText.Equals(empty) && logs.Count == 0");
                    }

                    if (logs.Count > 0)
                    {
                        if (logs.Count != int.Parse(logIndexText.Split('x').Last()))
                        {
                            throw new Exception("logs.Count != int.Parse(logIndexText.Split('x').Last()); logs.Count == " + logs.Count + "; logIndexText == " + logIndexText);
                        }

                        _tLogs.Add(logIndexText, logs);
                        logs = new List<string>();
                    }

                    lvi.Text = (++_number).ToString();

                    _lvwResults.Items.Add(lvi);

                    BufferAdd(lvi, _buffer);

                    lvi = new ListViewItem();

                    result = true;
                }
                else if (result)
                {
                    _split = _line.Split(cplit);

                    imgIndex = int.Parse(_split[0]);

                    lvi.SubItems.Add(_split[1]);

                    switch (imgIndex)
                    {
                        case 0:
                            passedB++;
                            lvi.SubItems.Add(text[0]);
                            break;
                        case 1:
                            failedB++;
                            lvi.SubItems.Add(text[1]);
                            break;
                        case 2:
                            inconclusiveB++;
                            lvi.SubItems.Add(text[2]);
                            break;
                        default:
                            throw new Exception("lvi.ImageIndex == " + imgIndex);
                    }

                    lvi.ImageIndex = imgIndex;
                    ForeColorLvi(lvi);

                    if (_split[2].Equals(empty))
                    {
                        lvi.SubItems.Add(string.Empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(_split[2]);
                    }

                    TimeSpan.Parse(_split[3]);

                    lvi.SubItems.Add(_split[3]);

                    lvi.SubItems.Add(_split[4]);

                    lvi.SubItems.Add(_split[5]);

                    result = false;
                }
                else
                {
                    if (_line.Equals(empty))
                    {
                        logs.Add(string.Empty);
                    }
                    else
                    {
                        logs.Add(_line);
                    }
                }
            } // End foreach

            if (!_line.Equals(split) || !result)
            {
                throw new Exception("!_line.Equals(split) || !result; _line == " + _line + "; result == " + result);
            }

            if (_lvwResults.Items.Count == 0)
            {
                throw new Exception("_lvwResults.Items.Count == 0");
            }

            if (passedA != passedB)
            {
                throw new Exception("passedA != passedB; passedA == " + passedA + "; passedB == " + passedB);
            }

            if (failedA != failedB)
            {
                throw new Exception("failedA != failedB; failedA == " + failedA + "; failedB == " + failedB);
            }

            if (inconclusiveA != inconclusiveB)
            {
                throw new Exception("inconclusiveA != inconclusiveB; inconclusiveA == " + inconclusiveA + "; inconclusiveB == " + inconclusiveB);
            }

            passed = 0;
            failed = 0;
            inconclusive = 0;
            results = 0;

            updateLblStats = false;

            lvwResults.Items.Clear();

            lvwResults.BeginUpdate();

            foreach (ListViewItem item in _lvwResults.Items)
            {
                _lvwResults.Items.Remove(item);
                lvwResults.Items.Add(item).Checked = true;
            }

            lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvwResults.EndUpdate();

            UpdateLblStats();

            updateLblStats = true;

            tLogs = _tLogs;
            buffer = _buffer;
            number = _number;

            txtName = Path.GetFileNameWithoutExtension(filePath);
            resultsPath = filePath;

            newResult = 0;
            saveItemIndex = lvwResults.Items.Count;
            lastItemIndex = lvwResults.Items.Count;

            UpdateLblResults();

            DeleteFiles(docxDelete);

            docxDelete.Clear();

            mnuOpenResults.Enabled = false;
            mnuSaveAs.Enabled = true;
            mnuChart.Enabled = true;
            mnuCopyResults.Enabled = true;
            mnuClear.Enabled = true;

            this.Cursor = Cursors.Default;

            Debug.WriteLine("Open " + stop.Elapsed);
        }
        #endregion

        #region SaveResults
        /// <summary>
        /// Saves the results and the logs in a txt file.
        /// Saving is canceled and a MessageBox is displayed if to occur an error.
        /// </summary>
        /// <param name="saveAs">true saves in a new txt file; false saves in the txt file already saved.</param>
        private void SaveResults(bool saveAs)
        {
            int _saveItemIndex = saveItemIndex;

            try
            {
                Stopwatch stop = new Stopwatch();
                stop.Start();

                this.Cursor = Cursors.AppStarting;

                FileStream fs;
                StreamWriter sw;

                string header = Encrypt1(failed + cplit.ToString() + inconclusive + cplit.ToString() + passed + cplit.ToString() + totalTime.ToString());

                if (saveAs)
                {
                    saveItemIndex = 0;

                    fs = new FileStream(sfdResults.FileName, FileMode.Create, FileAccess.Write);

                    sw = new StreamWriter(fs);
                    sw.Write(header);
                }
                else
                {
                    fs = new FileStream(resultsPath, FileMode.Open, FileAccess.ReadWrite);
                    fs.Seek(0, SeekOrigin.Begin);

                    sw = new StreamWriter(fs);
                    sw.Write(header);

                    sw.Close();
                    fs.Close();

                    fs = new FileStream(resultsPath, FileMode.Append);

                    sw = new StreamWriter(fs);
                }

                ListViewItem lvi;

                StringBuilder item = new StringBuilder();

                for (int i = saveItemIndex; i < lvwResults.Items.Count; i++)
                {
                    lvi = lvwResults.Items[i];

                    if (lvi.ImageIndex < 3)
                    {
                        item.Clear();

                        item.Append(lvi.ImageIndex.ToString() + cplit + lvi.SubItems[1].Text);

                        if (lvi.SubItems[3].Text.Equals(string.Empty))
                        {
                            item.Append(cplit + empty);
                        }
                        else
                        {
                            item.Append(cplit + lvi.SubItems[3].Text);
                        }

                        item.Append(cplit + lvi.SubItems[4].Text);
                        item.Append(cplit + lvi.SubItems[5].Text);
                        item.Append(cplit + lvi.SubItems[6].Text);

                        sw.Write(Environment.NewLine + Encrypt1(item.ToString()));

                        if (!lvi.SubItems[logIndex].Text.Equals(empty))
                        {
                            foreach (var log in tLogs[lvi.SubItems[logIndex].Text])
                            {
                                if (log.Equals(string.Empty))
                                {
                                    sw.Write(Environment.NewLine + Encrypt1(empty));
                                }
                                else
                                {
                                    sw.Write(Environment.NewLine + Encrypt1(log));
                                }
                            }
                        }

                        sw.Write(Environment.NewLine + Encrypt1(split));
                    }
                }

                sw.Close();
                fs.Close();

                if (saveAs)
                {
                    txtName = Path.GetFileNameWithoutExtension(sfdResults.FileName);
                    resultsPath = sfdResults.FileName;
                }
                else
                {
                    txtName = Path.GetFileNameWithoutExtension(resultsPath);
                }

                saveItemIndex = lvwResults.Items.Count;
                newResult = 0;
                mnuSave.Enabled = false;

                UpdateLblResults();

                ClearSettings();

                this.Cursor = Cursors.Default;

                Debug.WriteLine("Save " + stop.Elapsed);

                docxDelete.Clear();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;

                saveItemIndex = _saveItemIndex;

                Quiui.DebugEx(ex);

                MessageBox.Show(text[54], text[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SaveAsResults
        /// <summary>
        /// Displays the sfdResults control to save the results and logs in a new txt file.
        /// </summary>
        private void SaveAsResults()
        {
            if (sfdResults.ShowDialog() == DialogResult.OK)
            {
                SaveResults(true);
            }

            FocusCueFocus();
        }
        #endregion

        #region ForeColorLvi
        /// <summary>
        /// Changes the property ForeColor of a ListViewItem according to the property ImageIndex.
        /// </summary>
        /// <param name="lvi">ListViewItem to be changed.</param>
        public void ForeColorLvi(ListViewItem lvi)
        {
            switch (lvi.ImageIndex)
            {
                case 0:
                    lvi.ForeColor = Color.FromArgb(0, 145, 0);
                    break;
                case 1:
                    lvi.ForeColor = Color.FromArgb(255, 0, 0);
                    break;
                case 2:
                    lvi.ForeColor = Color.FromArgb(0, 120, 180);
                    break;
                default:
                    lvi.ForeColor = Color.FromArgb(235, 100, 0);
                    break;
            }
        }
        #endregion

        #region ForeColorLblRemain
        /// <summary>
        /// Changes the property ForeColor of the lblRemain control to red or purple.
        /// </summary>
        /// <param name="red">true changes to red.</param>
        private void ForeColorLblRemain(bool red = false)
        {
            if (red)
            {
                lblRemain.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                lblRemain.ForeColor = Color.FromArgb(139, 0, 139);
            }
        }
        #endregion

        #region UpdateLblStats
        /// <summary>
        /// Changes the property Text of the lblStats control.
        /// After the change, it will contain the percentage of the tests passed, failed and inconclusive (if greater than zero) and the total time of the run of the tests in the language of the interface.
        /// </summary>
        public void UpdateLblStats()
        {
            if (results > 0)
            {
                stats.Clear();

                stats.Add(text[0], (100 * passed / results));
                stats.Add(text[1], (100 * failed / results));
                stats.Add(text[2], (100 * inconclusive / results));

                var orderBy = stats.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key);

                string lblText = string.Empty;
                string value;

                bool bar = false;

                foreach (var item in orderBy)
                {
                    if (item.Value > 0)
                    {
                        value = string.Format(culture, "{0:0.##}", item.Value);

                        if (bar)
                        {
                            lblText += " | " + value + "% " + item.Key;
                        }
                        else
                        {
                            lblText = value + "% " + item.Key;
                            bar = true;
                        }
                    }
                }

                if (finish1 && finish2 && finish3)
                {
                    lblText += " | " + text[9] + totalTime.ToString();
                }

                lblStats.Text = lblText;
            }
            else
            {
                if (totalTime.TotalMilliseconds > 0)
                {
                    lblStats.Text = text[9] + totalTime.ToString();
                }
                else
                {
                    lblStats.Text = string.Empty;
                }
            }
        }
        #endregion

        #region UpdateLblRemain
        /// <summary>
        /// Changes the property Text of the lblRemain control.
        /// After the change, it will contain the total of tests to be run or a message requesting to wait (when the tests are canceled) in the language of the interface.
        /// </summary>
        /// <param name="remain">Total of tests to be run.</param>
        public void UpdateLblRemain(int remain)
        {
            switch (remain)
            {
                case 0:
                    // Wait message
                    lblRemain.Text = text[37];
                    break;
                case 1:
                    // 1 test left
                    lblRemain.Text = text[35].Replace(cplit.ToString(), remain.ToString());
                    break;
                default:
                    // (n > 1) tests left
                    lblRemain.Text = text[36].Replace(cplit.ToString(), remain.ToString());
                    break;
            }
        }
        #endregion

        #region UpdateLblResults
        /// <summary>
        /// Changes the property Text of the lblResults control.
        /// After the change, it will contain the name of the results file, or the total of new results, or both data together in the language of the interface.
        /// </summary>
        private void UpdateLblResults()
        {
            string lblText = text[6];

            if (!string.IsNullOrEmpty(txtName))
            {
                if (txtName.Length > 75)
                {
                    lblText += " | " + txtName.Substring(0, 75) + "...";
                }
                else
                {
                    lblText += " | " + txtName;
                }
            }

            if (newResult > 0)
            {
                lblText += " {+" + newResult + "}";
            }

            lblResults.Text = lblText;
        }
        #endregion

        #region Encrypt
        /// <summary>
        /// Converts a string into another that can not be intelligible.
        /// </summary>
        /// <param name="decrypted">String to be encrypted.</param>
        /// <returns>An encrypted string.</returns>
        public string Encrypt1(string decrypted)
        {
            byte[] data = Encoding.UTF8.GetBytes(decrypted);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        /// <summary>
        /// Converts a string into another that can not be intelligible.
        /// </summary>
        /// <param name="decrypted">String to be encrypted.</param>
        /// <returns>An encrypted string.</returns>
        public string Encrypt2(string decrypted)
        {
            byte[] data = Encoding.UTF8.GetBytes(decrypted);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        /// <summary>
        /// Converts a string into another that can not be intelligible.
        /// </summary>
        /// <param name="decrypted">String to be encrypted.</param>
        /// <returns>An encrypted string.</returns>
        public string Encrypt3(string decrypted)
        {
            byte[] data = Encoding.UTF8.GetBytes(decrypted);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        #endregion

        #region Decrypt
        /// <summary>
        /// Makes a string intelligible.
        /// Only works if the string was encrypted by the methods this.Encrypt1, this.Encrypt2 or this.Encrypt3 and if the string is not corrupted.
        /// </summary>
        /// <param name="encrypted">String to be decrypted.</param>
        /// <returns>A decrypted string.</returns>
        public string Decrypt(string encrypted)
        {
            byte[] data = Convert.FromBase64String(encrypted);

            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));

                using (var tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                    return Encoding.UTF8.GetString(results);
                }
            }
        }
        #endregion

        #region InterfaceText
        /// <summary>
        /// Adds the interface texts in the usText[] and brText[].
        /// </summary>
        private void InterfaceText()
        {
            usText[0] = "Passed";
            brText[0] = "Passou";

            usText[1] = "Failed";
            brText[1] = "Falhou";

            usText[2] = "Inconclusive";
            brText[2] = "Inconclusivo";

            usText[3] = "Test";
            brText[3] = "Teste";

            usText[4] = "Tests";
            brText[4] = "Testes";

            usText[5] = "Result";
            brText[5] = "Resultado";

            usText[6] = "Results";
            brText[6] = "Resultados";

            usText[7] = "Message";
            brText[7] = "Mensagem";

            usText[8] = "Elapsed Time";
            brText[8] = "Tempo Consumido";

            usText[9] = "Total Time ";
            brText[9] = "Tempo Total ";

            usText[10] = "Cancel";
            brText[10] = "Cancelar";

            usText[11] = "Start";
            brText[11] = "Iniciar";

            usText[12] = "Evidence";
            brText[12] = "Evidência";

            usText[13] = "Options";
            brText[13] = "Opções";

            usText[14] = "Show";
            brText[14] = "Mostrar";

            usText[15] = "Hide";
            brText[15] = "Esconder";

            usText[16] = "Open evidences folder";
            brText[16] = "Abrir pasta de evidências";

            usText[17] = "Number of tests run in parallel";
            brText[17] = "Quantidade de testes executados em paralelo";

            usText[18] = "Do not run in parallel";
            brText[18] = "Não executar em paralelo";

            usText[19] = "2 tests";
            brText[19] = "2 testes";

            usText[20] = "3 tests";
            brText[20] = "3 testes";

            usText[21] = "Cancel the run of the tests when the internet connection is not available";
            brText[21] = "Cancelar a execução dos testes quando a conexão com a internet não estiver disponível";

            usText[22] = "Watch QuiuiTool while the run of the tests";
            brText[22] = "Assistir QuiuiTool durante a execução dos testes";

            usText[23] = "Open";
            brText[23] = "Abrir";

            usText[24] = "Save";
            brText[24] = "Salvar";

            usText[25] = "Save as";
            brText[25] = "Salvar como";

            usText[26] = "Chart";
            brText[26] = "Gráfico";

            usText[27] = "Clear all";
            brText[27] = "Limpar tudo";

            usText[28] = "Copy all";
            brText[28] = "Copiar tudo";

            usText[29] = "New file";
            brText[29] = "Novo arquivo";

            usText[30] = "Open results";
            brText[30] = "Abrir resultados";

            usText[31] = "Save results";
            brText[31] = "Salvar resultados";

            usText[32] = "Check one or more tests.";
            brText[32] = "Marque um ou mais testes.";

            usText[33] = "Select one test.";
            brText[33] = "Selecione um teste.";

            usText[34] = "Select one result.";
            brText[34] = "Selecione um resultado.";

            usText[35] = cplit.ToString() + " test left";
            brText[35] = "Resta " + cplit.ToString() + " teste";

            usText[36] = cplit.ToString() + " tests left";
            brText[36] = "Restam " + cplit.ToString() + " testes";

            usText[37] = "Wait";
            brText[37] = "Aguarde";

            usText[38] = "This result does not have the evidences file.";
            brText[38] = "Este resultado não possui o arquivo de evidências.";

            usText[39] = "The evidences file was not found. The file was deleted or is in another folder.";
            brText[39] = "O arquivo de evidências não foi encontrado. O arquivo foi excluído ou está em outra pasta.";

            usText[40] = "This file is not about results or is corrupted.";
            brText[40] = "Este arquivo não é sobre resultados ou está corrompido.";

            usText[41] = "Do you want to restore the last results?";
            brText[41] = "Deseja restaurar os últimos resultados?";

            usText[42] = "Was not possible to restore the last results.";
            brText[42] = "Não foi possível restaurar os últimos resultados.";

            usText[43] = "The run of the tests was canceled successfully.";
            brText[43] = "A execução dos testes foi cancelada com sucesso.";

            usText[44] = "WARNING: the run of the tests was canceled. REASON: the internet connection is not available.";
            brText[44] = "ATENÇÃO: a execução dos testes foi cancelada. MOTIVO: a conexão com a internet não está disponível.";

            usText[45] = "Cancel the run of the tests or wait to finish.";
            brText[45] = "Cancele a execução dos testes ou aguarde finalizar.";

            usText[46] = "Save the new results in ";
            brText[46] = "Salvar os novos resultados em ";

            usText[47] = "Test unknown." + cplit.ToString() + split;
            brText[47] = "Teste desconhecido." + cplit.ToString() + split;

            usText[48] = "Copy/paste format not supported.";
            brText[48] = "Formato copiar/colar não suportado.";

            usText[49] = "Logs is empty.";
            brText[49] = "Logs está vazio.";

            usText[50] = "{Type: ";
            brText[50] = "{Tipo: ";

            usText[51] = "; Method: ";
            brText[51] = "; Método: ";

            usText[52] = "; File: ";
            brText[52] = "; Arquivo: ";

            usText[53] = "; Line: ";
            brText[53] = "; Linha: ";

            usText[54] = "An error has occurred. Please, try again.";
            brText[54] = "Ocorreu um erro. Por favor, tente novamente.";
        }
        #endregion

        #region SitesAddress
        /// <summary>
        /// Adds some websites address in the sites List.
        /// </summary>
        private void SitesAddress()
        {
            sites.Add("Facebook.com");
            sites.Add("Twitter.com");
            sites.Add("Google.com");
            sites.Add("Instagram.com");
            sites.Add("Linkedin.com");
            sites.Add("Wordpress.org");
            sites.Add("Pinterest.com");
            sites.Add("Wikipedia.org");
            sites.Add("Blogspot.com");
            sites.Add("Amazon.com");
            sites.Add("Vimeo.com");
            sites.Add("Flickr.com");
            sites.Add("Yahoo.com");
            sites.Add("Bit.ly");
            sites.Add("Vk.com");
            sites.Add("Qq.com");
            sites.Add("Godaddy.com");
            sites.Add("Reddit.com");
            sites.Add("Buydomains.com");
            sites.Add("W3.org");
            sites.Add("Nytimes.com");
            sites.Add("T.co");
            sites.Add("Statcounter.com");
            sites.Add("Blogger.com");
            sites.Add("Wp.com");
            sites.Add("Jimdo.com");
            sites.Add("Bbc.co.uk");
            sites.Add("Github.com");
            sites.Add("Soundcloud.com");
            sites.Add("Yandex.ru");
            sites.Add("Baidu.com");
            sites.Add("Mozilla.org");
            sites.Add("Gravatar.com");
            sites.Add("Theguardian.com");
            sites.Add("Nih.gov");
            sites.Add("Cnn.com");
            sites.Add("Wix.com");
            sites.Add("Huffingtonpost.com");
            sites.Add("Creativecommons.org");
            sites.Add("Imdb.com");
            sites.Add("Yelp.com");
            sites.Add("Feedburner.com");
            sites.Add("Bluehost.com");
            sites.Add("Addtoany.com");
            sites.Add("Dropbox.com");
            sites.Add("Forbes.com");
            sites.Add("Tinyurl.com");
            sites.Add("Washingtonpost.com");
            sites.Add("Slideshare.net");
            sites.Add("Archive.org");
        }
        #endregion

        #region InternetAvailable
        /// <summary>
        /// Verifies if the internet connection is available (only if the mnuCancel control is checked).
        /// </summary>
        /// <returns>true if the internet connection is available or if the mnuCancel control is not checked; false if the internet connection is not available.</returns>
        private async Task<bool> InternetAvailable()
        {
            if (mnuCancel.Checked)
            {
                PingReply reply;
                Ping ping = new Ping();

                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        reply = await ping.SendPingAsync(sites[random.Next(50)], 3000);

                        if (reply.Status == IPStatus.Success)
                        {
                            return true;
                        }
                        else
                        {
                            if (i == 2)
                            {
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Quiui.DebugEx(ex);

                        return false;
                    }
                }
            }

            return true;
        }
        #endregion

        #region UpdateFinish
        /// <summary>
        /// Updates the controls after the finish of the run of all tests.
        /// </summary>
        private void UpdateFinish()
        {
            if (finish1 && finish2 && finish3)
            {
                runTime.Stop();

                totalTime = totalTime.Add(elapsedTime);

                picLoadPurple.Visible = false;

                lblRemain.Visible = false;

                UpdateLblStats();

                EnabledTrue();

                SystemSounds.Exclamation.Play();

                this.TopMost = false;
            }
        }
        #endregion

        #region UpdateCancel
        /// <summary>
        /// Updates the controls after the run of the tests has been canceled.
        /// If the run was canceled by the user, a MessageBox is displayed with a default message.
        /// If the run was canceled because the internet connection was not available, another MessageBox is displayed.
        /// </summary>
        private void UpdateCancel()
        {
            if (finish1 && finish2 && finish3)
            {
                runTime.Stop();

                if (newResultAdded)
                {
                    totalTime = totalTime.Add(elapsedTime);
                }

                picLoadPurple.Visible = false;
                picLoadRed.Visible = false;
                lblRemain.Visible = false;

                passed1 = false;
                failed1 = false;
                inconclusive1 = false;
                unknown1 = false;

                passed2 = false;
                failed2 = false;
                inconclusive2 = false;
                unknown2 = false;

                passed3 = false;
                failed3 = false;
                inconclusive3 = false;
                unknown3 = false;

                this.Cursor = Cursors.Default;

                if (!btnCancel.Enabled)
                {
                    MessageBox.Show(text[43], text[7], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(text[44], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                UpdateLblStats();

                EnabledTrue();

                ForeColorLblRemain();

                this.TopMost = false;
            }
        }
        #endregion

        #region Robot1
        /// <summary>
        /// While the tests Stack contains elements, calls the method tests.Pop and then calls the method this.Test1 which will run the test.
        /// </summary>
        /// <remarks>
        /// After the run of the method this.Test1:
        /// adds the result in the lvwResults control;
        /// adds the logs in the tLogs dictionary;
        /// adds the name of the evidences file in the docxDelete List;
        /// saves the result in the lvwResults setting;
        /// saves the logs in the logs1 setting;
        /// saves the name of the evidences file in the docxDelete setting.
        /// When the run of the tests is canceled:
        /// closes the test which is being run;
        /// calls the methods related to the cancellation;
        /// exits at return statement.
        /// </remarks>
        private async void Robot1()
        {
            bool updateLblResults;
            bool hasInternet1;
            TimeSpan runTime1 = new TimeSpan();
            Stopwatch testTime = new Stopwatch();

            while (tests.Count > 0)
            {
                try
                {
                    testName1 = tests.Pop();
                }
                catch (InvalidOperationException)
                {
                    finish1 = true;
                    UpdateFinish();

                    return;
                }

                this.TopMost = mnuWatch.Checked ? true : false;
                updateLblResults = false;

                try
                {
                    this.Activate();
                    testTime.Restart();
                    await System.Threading.Tasks.Task.Factory.StartNew(Test1);
                    testTime.Stop();
                    this.Activate();

                    if (btnCancel.Enabled)
                    {
                        if (hasInternet)
                        {
                            hasInternet1 = await InternetAvailable();

                            if (!hasInternet1)
                            {
                                tokenSource.Cancel();
                                hasInternet = false;
                            }
                        }
                    }

                    Quiui.Token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    DeleteFile(docxName1);
                    finish1 = true;
                    UpdateCancel();

                    return;
                }

                runTime1 = runTime.Elapsed;
                elapsedTime = runTime1;
                elapsedTime1 = runTime1;

                ListViewItem lvi = new ListViewItem();

                lvi.SubItems.Add(testName1);
                lvi.SubItems.Add(result1);
                lvi.SubItems.Add(message1.Trim());

                if (passed1 || failed1)
                {
                    lvi.Text = (++number).ToString();
                    lvi.SubItems.Add(testTime.Elapsed.ToString());

                    if (passed1)
                    {
                        lvi.ImageIndex = 0;
                        passed1 = false;
                    }
                    else
                    {
                        if (inconclusive1)
                        {
                            lvi.ImageIndex = 2;
                            inconclusive1 = false;
                        }
                        else
                        {
                            lvi.ImageIndex = 1;
                        }

                        failed1 = false;
                    }

                    if (!File.Exists(docxFolder + @"\" + docxName1))
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName1); // Evidence
                        docxDelete.Add(docxName1);

                        Settings.Default.docxDelete.Add(Encrypt1(docxName1));
                    }

                    if (logs1.Count == 0)
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName1 + logs1.Count); // Log
                        tLogs.Add(docxName1 + logs1.Count, logs1);

                        SecurityCopyLog1(docxName1 + logs1.Count, logs1);
                    }

                    updateLblResults = true;
                }
                else
                {
                    lvi.ImageIndex = 3;
                    unknown1 = false;
                }

                ForeColorLvi(lvi);

                lvwResults.BeginUpdate();

                lvwResults.Items.Add(lvi).Checked = true;

                lvwResults.EndUpdate();

                SecurityCopyResult1(lvi);

                newResultAdded = true;

                lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                lvwResults.EnsureVisible(lastItemIndex++);

                if (remain > 1)
                {
                    UpdateLblRemain(--remain);
                }

                if (updateLblResults)
                {
                    newResult++;
                    UpdateLblResults();
                }

                BufferAdd(lvi, buffer);
            } // End while

            finish1 = true;
            UpdateFinish();
        }
        #endregion

        #region Robot2
        /// <summary>
        /// While the tests Stack contains elements, calls the method tests.Pop and then calls the method this.Test2 which will run the test.
        /// </summary>
        /// <remarks>
        /// After the run of the method this.Test2:
        /// adds the result in the lvwResults control;
        /// adds the logs in the tLogs dictionary;
        /// adds the name of the evidences file in the docxDelete List;
        /// saves the result in the lvwResults setting;
        /// saves the logs in the logs2 setting;
        /// saves the name of the evidences file in the docxDelete setting.
        /// When the run of the tests is canceled:
        /// closes the test which is being run;
        /// calls the methods related to the cancellation;
        /// exits at return statement.
        /// </remarks>
        private async void Robot2()
        {
            bool updateLblResults;
            bool hasInternet2;
            TimeSpan runTime2 = new TimeSpan();
            Stopwatch testTime = new Stopwatch();

            while (tests.Count > 0)
            {
                try
                {
                    testName2 = tests.Pop();
                }
                catch (InvalidOperationException)
                {
                    finish2 = true;
                    UpdateFinish();

                    return;
                }

                this.TopMost = mnuWatch.Checked ? true : false;
                updateLblResults = false;

                try
                {
                    this.Activate();
                    testTime.Restart();
                    await System.Threading.Tasks.Task.Factory.StartNew(Test2);
                    testTime.Stop();
                    this.Activate();

                    if (btnCancel.Enabled)
                    {
                        if (hasInternet)
                        {
                            hasInternet2 = await InternetAvailable();

                            if (!hasInternet2)
                            {
                                tokenSource.Cancel();
                                hasInternet = false;
                            }
                        }
                    }

                    Quiui.Token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    DeleteFile(docxName2);
                    finish2 = true;
                    UpdateCancel();

                    return;
                }

                runTime2 = runTime.Elapsed;
                elapsedTime = runTime2;
                elapsedTime2 = runTime2;

                ListViewItem lvi = new ListViewItem();

                lvi.SubItems.Add(testName2);
                lvi.SubItems.Add(result2);
                lvi.SubItems.Add(message2.Trim());

                if (passed2 || failed2)
                {
                    lvi.Text = (++number).ToString();
                    lvi.SubItems.Add(testTime.Elapsed.ToString());

                    if (passed2)
                    {
                        lvi.ImageIndex = 0;
                        passed2 = false;
                    }
                    else
                    {
                        if (inconclusive2)
                        {
                            lvi.ImageIndex = 2;
                            inconclusive2 = false;
                        }
                        else
                        {
                            lvi.ImageIndex = 1;
                        }

                        failed2 = false;
                    }

                    if (!File.Exists(docxFolder + @"\" + docxName2))
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName2); // Evidence
                        docxDelete.Add(docxName2);

                        Settings.Default.docxDelete.Add(Encrypt2(docxName2));
                    }

                    if (logs2.Count == 0)
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName2 + logs2.Count); // Log
                        tLogs.Add(docxName2 + logs2.Count, logs2);

                        SecurityCopyLog2(docxName2 + logs2.Count, logs2);
                    }

                    updateLblResults = true;
                }
                else
                {
                    lvi.ImageIndex = 3;
                    unknown2 = false;
                }

                ForeColorLvi(lvi);

                lvwResults.BeginUpdate();

                lvwResults.Items.Add(lvi).Checked = true;

                lvwResults.EndUpdate();

                SecurityCopyResult2(lvi);

                newResultAdded = true;

                lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                lvwResults.EnsureVisible(lastItemIndex++);

                if (remain > 1)
                {
                    UpdateLblRemain(--remain);
                }

                if (updateLblResults)
                {
                    newResult++;
                    UpdateLblResults();
                }

                BufferAdd(lvi, buffer);
            } // End while

            finish2 = true;
            UpdateFinish();
        }
        #endregion

        #region Robot3
        /// <summary>
        /// While the tests Stack contains elements, calls the method tests.Pop and then calls the method this.Test3 which will run the test.
        /// </summary>
        /// <remarks>
        /// After the run of the method this.Test3:
        /// adds the result in the lvwResults control;
        /// adds the logs in the tLogs dictionary;
        /// adds the name of the evidences file in the docxDelete List;
        /// saves the result in the lvwResults setting;
        /// saves the logs in the logs3 setting;
        /// saves the name of the evidences file in the docxDelete setting.
        /// When the run of the tests is canceled:
        /// closes the test which is being run;
        /// calls the methods related to the cancellation;
        /// exits at return statement.
        /// </remarks>
        private async void Robot3()
        {
            bool updateLblResults;
            bool hasInternet3;
            TimeSpan runTime3 = new TimeSpan();
            Stopwatch testTime = new Stopwatch();

            while (tests.Count > 0)
            {
                try
                {
                    testName3 = tests.Pop();
                }
                catch (InvalidOperationException)
                {
                    finish3 = true;
                    UpdateFinish();

                    return;
                }

                this.TopMost = mnuWatch.Checked ? true : false;
                updateLblResults = false;

                try
                {
                    this.Activate();
                    testTime.Restart();
                    await System.Threading.Tasks.Task.Factory.StartNew(Test3);
                    testTime.Stop();
                    this.Activate();

                    if (btnCancel.Enabled)
                    {
                        if (hasInternet)
                        {
                            hasInternet3 = await InternetAvailable();

                            if (!hasInternet3)
                            {
                                tokenSource.Cancel();
                                hasInternet = false;
                            }
                        }
                    }

                    Quiui.Token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    DeleteFile(docxName3);
                    finish3 = true;
                    UpdateCancel();

                    return;
                }

                runTime3 = runTime.Elapsed;
                elapsedTime = runTime3;
                elapsedTime3 = runTime3;

                ListViewItem lvi = new ListViewItem();

                lvi.SubItems.Add(testName3);
                lvi.SubItems.Add(result3);
                lvi.SubItems.Add(message3.Trim());

                if (passed3 || failed3)
                {
                    lvi.Text = (++number).ToString();
                    lvi.SubItems.Add(testTime.Elapsed.ToString());

                    if (passed3)
                    {
                        lvi.ImageIndex = 0;
                        passed3 = false;
                    }
                    else
                    {
                        if (inconclusive3)
                        {
                            lvi.ImageIndex = 2;
                            inconclusive3 = false;
                        }
                        else
                        {
                            lvi.ImageIndex = 1;
                        }

                        failed3 = false;
                    }

                    if (!File.Exists(docxFolder + @"\" + docxName3))
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName3); // Evidence
                        docxDelete.Add(docxName3);

                        Settings.Default.docxDelete.Add(Encrypt3(docxName3));
                    }

                    if (logs3.Count == 0)
                    {
                        lvi.SubItems.Add(empty);
                    }
                    else
                    {
                        lvi.SubItems.Add(docxName3 + logs3.Count); // Log
                        tLogs.Add(docxName3 + logs3.Count, logs3);

                        SecurityCopyLog3(docxName3 + logs3.Count, logs3);
                    }

                    updateLblResults = true;
                }
                else
                {
                    lvi.ImageIndex = 3;
                    unknown3 = false;
                }

                ForeColorLvi(lvi);

                lvwResults.BeginUpdate();

                lvwResults.Items.Add(lvi).Checked = true;

                lvwResults.EndUpdate();

                SecurityCopyResult3(lvi);

                newResultAdded = true;

                lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                lvwResults.EnsureVisible(lastItemIndex++);

                if (remain > 1)
                {
                    UpdateLblRemain(--remain);
                }

                if (updateLblResults)
                {
                    newResult++;
                    UpdateLblResults();
                }

                BufferAdd(lvi, buffer);
            } // End while

            finish3 = true;
            UpdateFinish();
        }
        #endregion

        #region Test1
        /// <summary>
        /// Runs a test.
        /// After the finish of the run, sets the variables according to the result and quits the ChromeDriver instance.
        /// </summary>
        private void Test1()
        {
            try
            {
                docxName1 = DateTime.Now.ToString(Quiui.format, culture) + testName1 + ".docx";
                logs1 = new List<string>();

                CallTestMethod(testName1, docxName1, logs1);

                result1 = text[0];
                message1 = string.Empty;
                passed1 = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Split('.').First().Equals("Assert"))
                {
                    message1 = string.Join(" ", ex.Message.Split(' ').Skip(2));
                }
                else if (ex.Message.Contains(cplit.ToString() + split))
                {
                    message1 = ex.Message.Split(cplit).First();
                    unknown1 = true;
                }
                else
                {
                    message1 = ex.Message;
                }

                if (unknown1)
                {
                    result1 = string.Empty;
                }
                else
                {
                    if (ex.Message.Split(' ').First().Equals("Assert.Inconclusive"))
                    {
                        inconclusive1 = true;
                        result1 = text[2];
                    }
                    else
                    {
                        result1 = text[1];
                    }

                    StackTraceAdd(ex, logs1);

                    failed1 = true;
                }
            }

            Quiui.QuitDriver(docxName1);
        }
        #endregion

        #region Test2
        /// <summary>
        /// Runs a test.
        /// After the finish of the run, sets the variables according to the result and quits the ChromeDriver instance.
        /// </summary>
        private void Test2()
        {
            try
            {
                docxName2 = DateTime.Now.ToString(Quiui.format, culture) + testName2 + ".docx";
                logs2 = new List<string>();

                CallTestMethod(testName2, docxName2, logs2);

                result2 = text[0];
                message2 = string.Empty;
                passed2 = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Split('.').First().Equals("Assert"))
                {
                    message2 = string.Join(" ", ex.Message.Split(' ').Skip(2));
                }
                else if (ex.Message.Contains(cplit.ToString() + split))
                {
                    message2 = ex.Message.Split(cplit).First();
                    unknown2 = true;
                }
                else
                {
                    message2 = ex.Message;
                }

                if (unknown2)
                {
                    result2 = string.Empty;
                }
                else
                {
                    if (ex.Message.Split(' ').First().Equals("Assert.Inconclusive"))
                    {
                        inconclusive2 = true;
                        result2 = text[2];
                    }
                    else
                    {
                        result2 = text[1];
                    }

                    StackTraceAdd(ex, logs2);

                    failed2 = true;
                }
            }

            Quiui.QuitDriver(docxName2);
        }
        #endregion

        #region Test3
        /// <summary>
        /// Runs a test.
        /// After the finish of the run, sets the variables according to the result and quits the ChromeDriver instance.
        /// </summary>
        private void Test3()
        {
            try
            {
                docxName3 = DateTime.Now.ToString(Quiui.format, culture) + testName3 + ".docx";
                logs3 = new List<string>();

                CallTestMethod(testName3, docxName3, logs3);

                result3 = text[0];
                message3 = string.Empty;
                passed3 = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Split('.').First().Equals("Assert"))
                {
                    message3 = string.Join(" ", ex.Message.Split(' ').Skip(2));
                }
                else if (ex.Message.Contains(cplit.ToString() + split))
                {
                    message3 = ex.Message.Split(cplit).First();
                    unknown3 = true;
                }
                else
                {
                    message3 = ex.Message;
                }

                if (unknown3)
                {
                    result3 = string.Empty;
                }
                else
                {
                    if (ex.Message.Split(' ').First().Equals("Assert.Inconclusive"))
                    {
                        inconclusive3 = true;
                        result3 = text[2];
                    }
                    else
                    {
                        result3 = text[1];
                    }

                    StackTraceAdd(ex, logs3);

                    failed3 = true;
                }
            }

            Quiui.QuitDriver(docxName3);
        }
        #endregion

        #region BufferAdd
        /// <summary>
        /// Arranges a result in a row of a html table and appends in a StringBuilder.
        /// </summary>
        /// <param name="lvi">ListViewItem that contains a result.</param>
        /// <param name="buff">StringBuilder to be appended.</param>
        private void BufferAdd(ListViewItem lvi, StringBuilder buff)
        {
            if (lvi.ImageIndex < 3)
            {
                switch (lvi.ImageIndex)
                {
                    case 0:
                        buff.Append("<tr style=\"color: #009100;\">");
                        break;
                    case 1:
                        buff.Append("<tr style=\"color: #FF0000;\">");
                        break;
                    case 2:
                        buff.Append("<tr style=\"color: #0078B4;\">");
                        break;
                }

                buff.Append("<td>" + WebUtility.HtmlEncode(lvi.SubItems[0].Text) + "</td>");
                buff.Append("<td>" + WebUtility.HtmlEncode(lvi.SubItems[1].Text) + "</td>");
                buff.Append("<td>" + WebUtility.HtmlEncode(lvi.SubItems[2].Text) + "</td>");
                buff.Append("<td>" + WebUtility.HtmlEncode(lvi.SubItems[3].Text) + "</td>");
                buff.Append("<td>" + WebUtility.HtmlEncode(lvi.SubItems[4].Text) + "&#8203;</td></tr>");
            }
        }
        #endregion

        #region StackTraceAdd
        /// <summary>
        /// Gets details of an exception and adds in a List in the language of the interface.
        /// </summary>
        /// <remarks>
        /// Details where the exception was thrown:
        /// the type of the exception;
        /// the name of the method;
        /// the name of the file;
        /// the number of the line.
        /// </remarks>
        /// <param name="ex">Exception thrown.</param>
        /// <param name="logs">List that contains the logs of the test.</param>
        private void StackTraceAdd(Exception ex, List<string> logs)
        {
            StackTrace st = new StackTrace(ex, true);

            string[] frames = Regex.Split(ex.StackTrace, "\r\n");

            for (int i = 0; i < frames.Length; i++)
            {
                if (frames[i].Contains(solutionFolder))
                {
                    StackFrame sf = st.GetFrame(i);

                    logs.Add(text[50] + ex.GetType().Name +
                             text[51] + sf.GetMethod().ToString().Split('(').First() +
                             text[52] + Path.GetFileName(sf.GetFileName()) +
                             text[53] + sf.GetFileLineNumber() + "}");
                    break;
                }
            }
        }
        #endregion

        #region SecurityCopyResult
        /// <summary>
        /// Saves a result, the total time of the run of the tests and the path of the results file in the settings.
        /// </summary>
        /// <param name="lvi">ListViewItem that contains a result.</param>
        private void SecurityCopyResult1(ListViewItem lvi)
        {
            if (lvi.ImageIndex < 3)
            {
                string result = lvi.ImageIndex.ToString();

                result += cplit.ToString() + lvi.SubItems[1].Text;
                result += cplit.ToString() + lvi.SubItems[3].Text;
                result += cplit.ToString() + lvi.SubItems[4].Text;
                result += cplit.ToString() + lvi.SubItems[5].Text;
                result += cplit.ToString() + lvi.SubItems[6].Text;

                Settings.Default.lvwResults.Add(Encrypt1(result));

                Settings.Default.totalTime = Encrypt1(totalTime.Add(elapsedTime1).ToString());

                if (resultsPath != null && string.IsNullOrEmpty(Settings.Default.resultPath))
                {
                    Settings.Default.resultPath = Encrypt1(resultsPath);
                }

                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Saves a result, the total time of the run of the tests and the path of the results file in the settings.
        /// </summary>
        /// <param name="lvi">ListViewItem that contains a result.</param>
        private void SecurityCopyResult2(ListViewItem lvi)
        {
            if (lvi.ImageIndex < 3)
            {
                string result = lvi.ImageIndex.ToString();

                result += cplit.ToString() + lvi.SubItems[1].Text;
                result += cplit.ToString() + lvi.SubItems[3].Text;
                result += cplit.ToString() + lvi.SubItems[4].Text;
                result += cplit.ToString() + lvi.SubItems[5].Text;
                result += cplit.ToString() + lvi.SubItems[6].Text;

                Settings.Default.lvwResults.Add(Encrypt2(result));

                Settings.Default.totalTime = Encrypt2(totalTime.Add(elapsedTime2).ToString());

                if (resultsPath != null && string.IsNullOrEmpty(Settings.Default.resultPath))
                {
                    Settings.Default.resultPath = Encrypt2(resultsPath);
                }

                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Saves a result, the total time of the run of the tests and the path of the results file in the settings.
        /// </summary>
        /// <param name="lvi">ListViewItem that contains a result.</param>
        private void SecurityCopyResult3(ListViewItem lvi)
        {
            if (lvi.ImageIndex < 3)
            {
                string result = lvi.ImageIndex.ToString();

                result += cplit.ToString() + lvi.SubItems[1].Text;
                result += cplit.ToString() + lvi.SubItems[3].Text;
                result += cplit.ToString() + lvi.SubItems[4].Text;
                result += cplit.ToString() + lvi.SubItems[5].Text;
                result += cplit.ToString() + lvi.SubItems[6].Text;

                Settings.Default.lvwResults.Add(Encrypt3(result));

                Settings.Default.totalTime = Encrypt3(totalTime.Add(elapsedTime3).ToString());

                if (resultsPath != null && string.IsNullOrEmpty(Settings.Default.resultPath))
                {
                    Settings.Default.resultPath = Encrypt3(resultsPath);
                }

                Settings.Default.Save();
            }
        }
        #endregion

        #region SecurityCopyLog
        /// <summary>
        /// Saves the logs of the test in the logs1 setting.
        /// </summary>
        /// <param name="logsKey">Key of the logs.</param>
        /// <param name="logs">List that contains the logs of the test.</param>
        private void SecurityCopyLog1(string logsKey, List<string> logs)
        {
            Settings.Default.logs1.Add(Encrypt1(logsKey));

            foreach (var item in logs)
            {
                if (item.Equals(string.Empty))
                {
                    Settings.Default.logs1.Add(Encrypt1(empty));
                }
                else
                {
                    Settings.Default.logs1.Add(Encrypt1(item));
                }
            }

            Settings.Default.logs1.Add(Encrypt1(cplit.ToString()));
        }

        /// <summary>
        /// Saves the logs of the test in the logs2 setting.
        /// </summary>
        /// <param name="logsKey">Key of the logs.</param>
        /// <param name="logs">List that contains the logs of the test.</param>
        private void SecurityCopyLog2(string logsKey, List<string> logs)
        {
            Settings.Default.logs2.Add(Encrypt2(logsKey));

            foreach (var item in logs)
            {
                if (item.Equals(string.Empty))
                {
                    Settings.Default.logs2.Add(Encrypt2(empty));
                }
                else
                {
                    Settings.Default.logs2.Add(Encrypt2(item));
                }
            }

            Settings.Default.logs2.Add(Encrypt2(cplit.ToString()));
        }

        /// <summary>
        /// Saves the logs of the test in the logs3 setting.
        /// </summary>
        /// <param name="logsKey">Key of the logs.</param>
        /// <param name="logs">List that contains the logs of the test.</param>
        private void SecurityCopyLog3(string logsKey, List<string> logs)
        {
            Settings.Default.logs3.Add(Encrypt3(logsKey));

            foreach (var item in logs)
            {
                if (item.Equals(string.Empty))
                {
                    Settings.Default.logs3.Add(Encrypt3(empty));
                }
                else
                {
                    Settings.Default.logs3.Add(Encrypt3(item));
                }
            }

            Settings.Default.logs3.Add(Encrypt3(cplit.ToString()));
        }
        #endregion

        #region SecuritySetResults
        /// <summary>
        /// Adds the results stored at lvwResults setting in the lvwResults control.
        /// Displays a MessageBox to choose between to restore or not the results.
        /// If the user does not want to restore, deletes the evidences files of this results and clean up the settings related to the results.
        /// If any result is corrupted, deletes the evidences files of this results, clean up the controls and settings related to the results and displays a MessageBox.
        /// </summary>
        private void SecuritySetResults()
        {
            if (Settings.Default.lvwResults.Count > 0)
            {
                if (MessageBox.Show(text[41], text[7], MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.AppStarting;

                        if (!string.IsNullOrEmpty(Settings.Default.resultPath))
                        {
                            OpenResults(Decrypt(Settings.Default.resultPath));
                            updateLblStats = false;
                            newResult = 0;
                        }

                        totalTime = TimeSpan.Parse(Decrypt(Settings.Default.totalTime));

                        SecuritySetLogs();
                        SecuritySetDocxDelete();

                        ListViewItem lvi;
                        string[] split;

                        foreach (var item in Settings.Default.lvwResults)
                        {
                            split = Decrypt(item).Split(cplit);

                            lvi = new ListViewItem();
                            lvi.ImageIndex = int.Parse(split[0]);
                            lvi.Text = (++number).ToString();

                            lvi.SubItems.Add(split[1]);

                            switch (lvi.ImageIndex)
                            {
                                case 0:
                                    lvi.SubItems.Add(text[0]);
                                    break;
                                case 1:
                                    lvi.SubItems.Add(text[1]);
                                    break;
                                case 2:
                                    lvi.SubItems.Add(text[2]);
                                    break;
                                default:
                                    throw new Exception("lvi.ImageIndex == " + lvi.ImageIndex);
                            }

                            lvi.SubItems.Add(split[2]);

                            TimeSpan.Parse(split[3]);
                            lvi.SubItems.Add(split[3]);

                            lvi.SubItems.Add(split[4]);

                            if (!split[5].Equals(empty) && !tLogs.ContainsKey(split[5]))
                            {
                                throw new Exception("!split[5].Equals(empty) && !tLogs.ContainsKey(split[5]); split[5] == " + split[5]);
                            }

                            lvi.SubItems.Add(split[5]);

                            ForeColorLvi(lvi);

                            lvwResults.Items.Add(lvi).Checked = true;
                            newResult++;

                            BufferAdd(lvi, buffer);
                        }

                        lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                        UpdateLblStats();
                        UpdateLblResults();

                        mnuOpenResults.Enabled = false;
                        mnuSave.Enabled = true;
                        mnuSaveAs.Enabled = true;
                        mnuChart.Enabled = true;
                        mnuCopyResults.Enabled = true;
                        mnuClear.Enabled = true;

                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        docxDelete.Clear();
                        SecuritySetDocxDelete(true);

                        ClearResults();

                        Quiui.DebugEx(ex);

                        this.Cursor = Cursors.Default;

                        MessageBox.Show(text[42], text[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Cursor = Cursors.AppStarting;

                    SecuritySetDocxDelete(true);
                    DeleteFiles(docxDelete);
                    docxDelete.Clear();

                    ClearSettings();

                    this.Cursor = Cursors.Default;
                }
            }

            updateLblStats = true;
        }
        #endregion

        #region SecuritySetLogs
        /// <summary>
        /// Adds the logs of the tests stored at logs settings in the tLogs dictionary.
        /// </summary>
        /// <exception cref="System.Exception">Throws if the validation catches an inconsistency or if any log is corrupted.</exception>
        private void SecuritySetLogs()
        {
            string log;
            string docxName;

            List<string> logs = new List<string>();

            StringCollection[] arrLogs = new StringCollection[]
            {
                Settings.Default.logs1,
                Settings.Default.logs2,
                Settings.Default.logs3
            };

            foreach (var setting in arrLogs)
            {
                foreach (var item in setting)
                {
                    log = Decrypt(item);

                    if (log.Equals(cplit.ToString()))
                    {
                        docxName = logs[0];

                        logs.RemoveAt(0);

                        if (logs.Count != int.Parse(docxName.Split('x').Last()))
                        {
                            throw new Exception("logs.Count != int.Parse(docxName.Split('x').Last()); logs.Count == " + logs.Count + "; docxName == " + docxName);
                        }

                        tLogs.Add(docxName, logs);

                        logs = new List<string>();
                    }
                    else
                    {
                        if (log.Equals(empty))
                        {
                            logs.Add(string.Empty);
                        }
                        else
                        {
                            logs.Add(log);
                        }
                    }
                }
            }
        }
        #endregion

        #region SecuritySetDocxDelete
        /// <summary>
        /// Adds the names of the evidences files stored at docxDelete setting in the docxDelete List.
        /// </summary>
        /// <param name="tryCatch">true to catch the exceptions inside of the method.</param>
        private void SecuritySetDocxDelete(bool tryCatch = false)
        {
            if (tryCatch)
            {
                foreach (var docxName in Settings.Default.docxDelete)
                {
                    try
                    {
                        docxDelete.Add(Decrypt(docxName));
                    }
                    catch (Exception ex)
                    {
                        Quiui.DebugEx(ex);
                    }
                }
            }
            else
            {
                foreach (var docxName in Settings.Default.docxDelete)
                {
                    docxDelete.Add(Decrypt(docxName));
                }
            }
        }
        #endregion

        #region ClearSettings
        /// <summary>
        /// Clean up the settings related to the results.
        /// </summary>
        private void ClearSettings()
        {
            Settings.Default.lvwResults.Clear();
            Settings.Default.logs1.Clear();
            Settings.Default.logs2.Clear();
            Settings.Default.logs3.Clear();
            Settings.Default.docxDelete.Clear();
            Settings.Default.resultPath = string.Empty;
            Settings.Default.totalTime = string.Empty;

            Settings.Default.Save();
        }
        #endregion

        #region TestSettings
        /// <summary>
        /// Adds the names of the test methods stored at lvwTests setting in ListView controls.
        /// Adds the names of the test methods found at test classes if the lvwTests setting is empty or when an exception is thrown.
        /// </summary>
        private void TestSettings()
        {
            if (Settings.Default.lvwTests.Count > 0)
            {
                try
                {
                    List<ListView> lvwList = new List<ListView>();
                    ListView lvw = NewListView();
                    ListViewItem lvi;

                    string testName;

                    foreach (var item in Settings.Default.lvwTests)
                    {
                        testName = Decrypt(item);

                        if (testName.Equals(cplit.ToString()))
                        {
                            lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                            lvw.ItemCheck += new ItemCheckEventHandler(ItemCheck);
                            lvw.SelectedIndexChanged += (s, e) => FocusCueItem();
                            DoubleBuffer(lvw);

                            lvwList.Add(lvw);
                            lvw = NewListView();
                        }
                        else
                        {
                            lvi = new ListViewItem();
                            lvi.Text = testName;
                            lvw.Items.Add(lvi);
                        }
                    }

                    lvwTests = lvwList;
                }
                catch (Exception ex)
                {
                    TestDefault();

                    Settings.Default.lvwTests.Clear();

                    Quiui.DebugEx(ex);
                }
            }
            else
            {
                TestDefault();
            }
        }
        #endregion

        #region TestDefault
        /// <summary>
        /// Adds the names of the test methods found at test classes in ListView controls.
        /// </summary>
        private void TestDefault()
        {
            ListView lvw;
            ListViewItem lvi;

            foreach (var tests in TestFromClass())
            {
                lvw = NewListView();

                foreach (var item in tests)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item;
                    lvw.Items.Add(lvi);
                }

                lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvw.ItemCheck += new ItemCheckEventHandler(ItemCheck);
                lvw.SelectedIndexChanged += (s, e) => FocusCueItem();
                DoubleBuffer(lvw);

                lvwTests.Add(lvw);
            }
        }
        #endregion

        #region TestFromClass
        /// <summary>
        /// Searches by test methods at test classes and adds the names in string[]'s.
        /// Each string[] represents a test class.
        /// </summary>
        /// <returns>A List containing string[]'s.</returns>
        private List<string[]> TestFromClass()
        {
            List<string[]> tests = new List<string[]>();

            string[] names;

            IEnumerable<MethodInfo> methods;

            foreach (var type in TestClasses())
            {
                methods = type.GetMethods().Where(methodInfo => methodInfo.GetCustomAttributes(typeof(TestMethodAttribute), true).Length > 0);

                if (methods.Count() > 0)
                {
                    names = new string[methods.Count()];

                    for (int i = 0; i < names.Length; i++)
                    {
                        names[i] = methods.ElementAt(i).Name;
                    }

                    tests.Add(names);
                }
            }

            return tests;
        }
        #endregion

        #region NewListView
        /// <summary>
        /// Creates a ListView control.
        /// </summary>
        /// <returns>A ListView control customized.</returns>
        private ListView NewListView()
        {
            var lvw = new ListView
            {
                BorderStyle = BorderStyle.None,
                CheckBoxes = true,
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Segoe UI", 10.2f, FontStyle.Regular),
                HeaderStyle = ColumnHeaderStyle.None,
                MultiSelect = false,
                TabStop = false,
                View = System.Windows.Forms.View.Details
            };

            lvw.Columns.Add("clmTest");

            return lvw;
        }
        #endregion

        #region TabPageAdd
        /// <summary>
        /// Creates the tab pages of the tbcTests control.
        /// </summary>
        private void TabPageAdd()
        {
            Type[] tclass = TestClasses();
            TabPage tabPage;

            for (int i = 0; i < lvwTests.Count; i++)
            {
                try
                {
                    tabPage = new TabPage(tclass[i].Name);
                }
                catch (IndexOutOfRangeException)
                {
                    tabPage = new TabPage();
                }

                tabPage.BackColor = Color.White;
                tabPage.Padding = new Padding(3, 3, 3, 3);
                tabPage.Controls.Add(lvwTests[i]);

                tbcTests.TabPages.Add(tabPage);
            }
        }
        #endregion

        #region DeleteFile
        /// <summary>
        /// Deletes permanently a evidences file.
        /// </summary>
        /// <param name="docxName">Name of the evidences file.</param>
        private void DeleteFile(string docxName)
        {
            string docxPath = docxFolder + @"\" + docxName;

            try
            {
                if (File.Exists(docxPath))
                {
                    File.Delete(docxPath);
                }
            }
            catch (Exception ex)
            {
                Quiui.DebugEx(ex);
            }
        }
        #endregion

        #region DeleteFiles
        /// <summary>
        /// Deletes permanently the evidences files contained in a List.
        /// Before to delete, closes without saving the files contained at List.
        /// </summary>
        /// <param name="docxList">List that contains the names of the evidences files to be deleted.</param>
        private void DeleteFiles(List<string> docxList)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("WINWORD");

                if (proc.Length > 0)
                {
                    Microsoft.Office.Interop.Word.Application wordApp = Marshal.GetActiveObject("Word.Application") as Microsoft.Office.Interop.Word.Application;

                    bool exit = (wordApp.Documents.Count == 0);

                    foreach (var docxName in docxList)
                    {
                        if (exit) break;

                        foreach (Document word in wordApp.Documents)
                        {
                            if (word.Name.Equals(docxName))
                            {
                                word.Close(SaveChanges: false);

                                if (wordApp.Documents.Count == 0)
                                {
                                    wordApp.Quit();
                                    exit = true;
                                }

                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Quiui.DebugEx(ex);
            }

            string docxPath;

            foreach (var docxName in docxList)
            {
                try
                {
                    docxPath = docxFolder + @"\" + docxName;

                    if (File.Exists(docxPath))
                    {
                        File.Delete(docxPath);
                    }
                }
                catch (Exception ex)
                {
                    Quiui.DebugEx(ex);
                }
            }
        }
        #endregion

        #region FocusCue
        /// <summary>
        /// Clean up the items selected in the ListView control that contains the tests if it does not have the input focus.
        /// </summary>
        private void FocusCueButton()
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            if (!lvw.ContainsFocus && lvw.SelectedItems.Count > 0)
            {
                lvw.SelectedItems.Clear();
            }
        }

        /// <summary>
        /// Selects the ListView control that contains the tests and hides the focus cue.
        /// </summary>
        private void FocusCueSelect()
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            lvw.Select();

            if (lvw.FocusedItem != null && lvw.SelectedItems.Count == 0)
            {
                lvw.FocusedItem.Focused = false;
            }
        }

        /// <summary>
        /// Hides the focus cue if the ListView control that contains the tests does not have items selected.
        /// </summary>
        private void FocusCueItem()
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            if (lvw.FocusedItem != null && lvw.SelectedItems.Count == 0)
            {
                lvw.FocusedItem.Focused = false;
            }
        }

        /// <summary>
        /// Hides the focus cue if the ListView control that contains the tests has the input focus.
        /// </summary>
        private void FocusCueFocus()
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            if (lvw.ContainsFocus)
            {
                if (lvw.FocusedItem != null && lvw.SelectedItems.Count == 0)
                {
                    lvw.FocusedItem.Focused = false;
                }
            }
        }
        #endregion

        #region LvwResults_ItemCheck
        /// <summary>
        /// Updates the total of passed, failed and inconclusive results.
        /// Occurs when the check state of an item changes.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void LvwResults_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                switch (lvwResults.Items[e.Index].ImageIndex)
                {
                    case 0:
                        passed++;
                        break;
                    case 1:
                        failed++;
                        break;
                    case 2:
                        inconclusive++;
                        break;
                    default:
                        e.NewValue = CheckState.Unchecked;
                        return;
                }
                results++;
            }
            else
            {
                switch (lvwResults.Items[e.Index].ImageIndex)
                {
                    case 0:
                        passed--;
                        break;
                    case 1:
                        failed--;
                        break;
                    case 2:
                        inconclusive--;
                        break;
                }
                results--;
            }

            if (updateLblStats)
            {
                UpdateLblStats();
                mnuChart.Enabled = (results > 0) && btnStart.Enabled ? true : false;
            }
        }
        #endregion

        #region LvwResults_SelectedIndexChanged
        /// <summary>
        /// Displays the logs of the test in the txtLogs control.
        /// Occurs when the SelectedIndices collection changes.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void LvwResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowLogs();
        }
        #endregion

        #region TbcTests_SelectedIndexChanged
        /// <summary>
        /// Selects the ListView control that contains the tests and hides the focus cue.
        /// Occurs when the SelectedIndex property has changed.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void TbcTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            FocusCueSelect();
        }
        #endregion

        #region Mnu_MouseEnter
        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuInterface control to false.
        /// Occurs when the mouse pointer enters the mnuEnglish control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuEnglish_MouseEnter(object sender, EventArgs e)
        {
            mnuInterface.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuInterface control to false.
        /// Occurs when the mouse pointer enters the mnuPortuguese control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuPortuguese_MouseEnter(object sender, EventArgs e)
        {
            mnuInterface.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuLogs to control false.
        /// Occurs when the mouse pointer enters the mnuShow control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuShow_MouseEnter(object sender, EventArgs e)
        {
            mnuLogs.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuLogs control to false.
        /// Occurs when the mouse pointer enters the mnuHide control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuHide_MouseEnter(object sender, EventArgs e)
        {
            mnuLogs.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to false.
        /// Occurs when the mouse pointer enters the mnu1Test control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu1Test_MouseEnter(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to false.
        /// Occurs when the mouse pointer enters the mnu2Tests control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu2Tests_MouseEnter(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to false.
        /// Occurs when the mouse pointer enters the mnu3Tests control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu3Tests_MouseEnter(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuOptions control to false.
        /// Occurs when the mouse pointer enters the mnuCancel control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuCancel_MouseEnter(object sender, EventArgs e)
        {
            mnuOptions.DropDown.AutoClose = false;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuOptions control to false.
        /// Occurs when the mouse pointer enters the mnuWatch control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuWatch_MouseEnter(object sender, EventArgs e)
        {
            mnuOptions.DropDown.AutoClose = false;
        }
        #endregion

        #region Mnu_MouseLeave
        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuInterface control to true.
        /// Occurs when the mouse pointer leaves the mnuEnglish control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuEnglish_MouseLeave(object sender, EventArgs e)
        {
            mnuInterface.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuInterface control to true.
        /// Occurs when the mouse pointer leaves the mnuPortuguese control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuPortuguese_MouseLeave(object sender, EventArgs e)
        {
            mnuInterface.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuLogs control to true.
        /// Occurs when the mouse pointer leaves the mnuShow control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuShow_MouseLeave(object sender, EventArgs e)
        {
            mnuLogs.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuLogs control to true.
        /// Occurs when the mouse pointer leaves the mnuHide control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuHide_MouseLeave(object sender, EventArgs e)
        {
            mnuLogs.DropDown.AutoClose = true;

        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to true.
        /// Occurs when the mouse pointer leaves the mnu1Test control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu1Test_MouseLeave(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to true.
        /// Occurs when the mouse pointer leaves the mnu2Tests control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu2Tests_MouseLeave(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuNumber control to true.
        /// Occurs when the mouse pointer leaves the mnu3Tests control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu3Tests_MouseLeave(object sender, EventArgs e)
        {
            mnuNumber.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuOptions control to true.
        /// Occurs when the mouse pointer leaves the mnuCancel control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuCancel_MouseLeave(object sender, EventArgs e)
        {
            mnuOptions.DropDown.AutoClose = true;
        }

        /// <summary>
        /// Changes the property DropDown.AutoClose of the mnuOptions control to true.
        /// Occurs when the mouse pointer leaves the mnuWatch control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuWatch_MouseLeave(object sender, EventArgs e)
        {
            mnuOptions.DropDown.AutoClose = true;
        }
        #endregion

        #region Btn_MouseEnter
        /// <summary>
        /// Clean up the items selected in the ListView control that contains the tests if it does not have the input focus.
        /// Occurs when the mouse pointer enters the btnUp control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnUp_MouseEnter(object sender, EventArgs e)
        {
            FocusCueButton();
        }

        /// <summary>
        /// Clean up the items selected in the ListView control that contains the tests if it does not have the input focus.
        /// Occurs when the mouse pointer enters the btnDown control.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnDown_MouseEnter(object sender, EventArgs e)
        {
            FocusCueButton();
        }
        #endregion

        #region Mnu_Click
        /// <summary>
        /// Changes the language of the interface to american English and saves the mnuPortuguese setting.
        /// Occurs when the mnuEnglish is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuEnglish_Click(object sender, EventArgs e)
        {
            if (!mnuEnglish.Checked)
            {
                mnuEnglish.Checked = true;
            }
            else
            {
                mnuEnglish.Checked = true;
                mnuPortuguese.Checked = false;

                text = usText;
                culture = usCulture;

                btnCancel.Text = text[10];
                btnStart.Text = text[11];
                btnOpenEvidence.Text = text[12];
                mnuOptions.Text = text[13];
                mnuResults.Text = text[6];

                mnuShow.Text = text[14];
                mnuHide.Text = text[15];
                mnuCopyLogs.Text = text[28];
                mnuOpenEvidencesFolder.Text = text[16];
                mnuNumber.Text = text[17];
                mnu1Test.Text = text[18];
                mnu2Tests.Text = text[19];
                mnu3Tests.Text = text[20];
                mnuCancel.Text = text[21];
                mnuWatch.Text = text[22];
                mnuOpenResults.Text = text[23];
                mnuSave.Text = text[24];
                mnuSaveAs.Text = text[25];
                mnuChart.Text = text[26];
                mnuCopyResults.Text = text[28];
                mnuClear.Text = text[27];

                lblTests.Text = text[4];

                UpdateLblResults();
                UpdateLblStats();

                lvwResults.BeginUpdate();

                lvwResults.Columns[1].Text = text[3];
                lvwResults.Columns[2].Text = text[5];
                lvwResults.Columns[3].Text = text[7];
                lvwResults.Columns[4].Text = text[8];

                lvwResults.EndUpdate();

                if (lvwResults.Items.Count > 0)
                {
                    lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

                ofdResults.Title = text[30];
                sfdResults.Title = text[31];

                Settings.Default.mnuPortuguese = false;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Changes the language of the interface to brazilian Portuguese and saves the mnuPortuguese setting.
        /// Occurs when the mnuPortuguese is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuPortuguese_Click(object sender, EventArgs e)
        {
            if (!mnuPortuguese.Checked)
            {
                mnuPortuguese.Checked = true;
            }
            else
            {
                mnuPortuguese.Checked = true;
                mnuEnglish.Checked = false;

                text = brText;
                culture = brCulture;

                btnCancel.Text = text[10];
                btnStart.Text = text[11];
                btnOpenEvidence.Text = text[12];
                mnuOptions.Text = text[13];
                mnuResults.Text = text[6];

                mnuShow.Text = text[14];
                mnuHide.Text = text[15];
                mnuCopyLogs.Text = text[28];
                mnuOpenEvidencesFolder.Text = text[16];
                mnuNumber.Text = text[17];
                mnu1Test.Text = text[18];
                mnu2Tests.Text = text[19];
                mnu3Tests.Text = text[20];
                mnuCancel.Text = text[21];
                mnuWatch.Text = text[22];
                mnuOpenResults.Text = text[23];
                mnuSave.Text = text[24];
                mnuSaveAs.Text = text[25];
                mnuChart.Text = text[26];
                mnuCopyResults.Text = text[28];
                mnuClear.Text = text[27];

                lblTests.Text = text[4];

                UpdateLblResults();
                UpdateLblStats();

                lvwResults.BeginUpdate();

                lvwResults.Columns[1].Text = text[3];
                lvwResults.Columns[2].Text = text[5];
                lvwResults.Columns[3].Text = text[7];
                lvwResults.Columns[4].Text = text[8];

                lvwResults.EndUpdate();

                if (lvwResults.Items.Count > 0)
                {
                    lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }

                ofdResults.Title = text[30];
                sfdResults.Title = text[31];

                Settings.Default.mnuPortuguese = true;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Makes visible the lblLogs and txtLogs controls and saves the mnuHide setting.
        /// Occurs when the mnuShow is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuShow_Click(object sender, EventArgs e)
        {
            if (!mnuShow.Checked)
            {
                mnuShow.Checked = true;
            }
            else
            {
                mnuHide.Checked = false;
                mnuCopyLogs.Enabled = true;

                tlpApp.SetRowSpan(lvwResults, 1);
                ShowLogs();

                tlpApp.SetRow(lblStats, 3);

                tlpApp.SetRow(btnOpenEvidence, 3);

                lblLogs.Visible = true;
                txtLogs.Visible = true;

                Settings.Default.mnuHide = false;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Hides the lblLogs and txtLogs controls and saves the mnuHide setting.
        /// Occurs when the mnuHide is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuHide_Click(object sender, EventArgs e)
        {
            if (!mnuHide.Checked)
            {
                mnuHide.Checked = true;
            }
            else
            {
                mnuShow.Checked = false;
                mnuCopyLogs.Enabled = false;

                lblLogs.Visible = false;
                txtLogs.Visible = false;

                tlpApp.SetRow(lblStats, 6);

                tlpApp.SetRow(btnOpenEvidence, 6);

                tlpApp.SetRowSpan(lvwResults, 4);
                lvwResults.Refresh();

                Settings.Default.mnuHide = true;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Copies the text of the txtLogs control to the clipboard.
        /// If the txtLogs control is empty, a MessageBox is displayed.
        /// Occurs when the mnuCopyLogs is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuCopyLogs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogs.Text))
            {
                MessageBox.Show(text[49], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FocusCueFocus();
            }
            else
            {
                Clipboard.SetText(txtLogs.Text);
            }
        }

        /// <summary>
        /// Opens the evidences folder.
        /// A MessageBox is displayed if to occur an error.
        /// Occurs when the mnuOpenEvidencesFolder is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuOpenEvidencesFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(docxFolder))
                {
                    Quiui.CreateDocxFolder();
                }

                this.TopMost = false;

                Process.Start(docxFolder);
            }
            catch (Exception ex)
            {
                Quiui.DebugEx(ex);

                MessageBox.Show(text[54], text[7], MessageBoxButtons.OK, MessageBoxIcon.Error);

                FocusCueFocus();
            }
        }

        /// <summary>
        /// Disables the run of the tests in parallel and saves the mnuNumber setting.
        /// Occurs when the mnu1Test is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu1Test_Click(object sender, EventArgs e)
        {
            if (!mnu1Test.Checked)
            {
                mnu1Test.Checked = true;
            }
            else
            {
                mnu1Test.Checked = true;
                mnu2Tests.Checked = false;
                mnu3Tests.Checked = false;

                mnu2Tests.Image = null;
                mnu3Tests.Image = null;

                mnu1Test.Image = ilsMenu.Images[2];

                Settings.Default.mnuNumber = 1;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Changes the number of tests run in parallel to 2 and saves the mnuNumber setting.
        /// Occurs when the mnu2Tests is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu2Tests_Click(object sender, EventArgs e)
        {
            if (!mnu2Tests.Checked)
            {
                mnu2Tests.Checked = true;
            }
            else
            {
                mnu2Tests.Checked = true;
                mnu1Test.Checked = false;
                mnu3Tests.Checked = false;

                mnu1Test.Image = null;
                mnu3Tests.Image = null;

                mnu2Tests.Image = ilsMenu.Images[2];

                Settings.Default.mnuNumber = 2;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Changes the number of tests run in parallel to 3 and saves the mnuNumber setting.
        /// Occurs when the mnu3Tests is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void Mnu3Tests_Click(object sender, EventArgs e)
        {
            if (!mnu3Tests.Checked)
            {
                mnu3Tests.Checked = true;
            }
            else
            {
                mnu3Tests.Checked = true;
                mnu1Test.Checked = false;
                mnu2Tests.Checked = false;

                mnu1Test.Image = null;
                mnu2Tests.Image = null;

                mnu3Tests.Image = ilsMenu.Images[2];

                Settings.Default.mnuNumber = 3;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Enables or disables the option of to cancel automatically the run of the tests when the internet connection is not available and saves the mnuCancel setting.
        /// Occurs when the mnuCancel is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuCancel_Click(object sender, EventArgs e)
        {
            if (mnuCancel.Checked)
            {
                mnuCancel.Image = ilsMenu.Images[0];

                Settings.Default.mnuCancel = true;
            }
            else
            {
                mnuCancel.Image = null;

                Settings.Default.mnuCancel = false;
            }

            Settings.Default.Save();
        }

        /// <summary>
        /// Enables or disables the option of to watch QuiuiTool application while the run of the tests and saves the mnuWatch setting.
        /// Occurs when the mnuWatch is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuWatch_Click(object sender, EventArgs e)
        {
            if (mnuWatch.Checked)
            {
                mnuWatch.Image = ilsMenu.Images[1];

                Settings.Default.mnuWatch = true;
            }
            else
            {
                mnuWatch.Image = null;

                Settings.Default.mnuWatch = false;
            }

            Settings.Default.Save();
        }

        /// <summary>
        /// Displays the ofdResults control to open a txt file.
        /// Occurs when the mnuOpenResults is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuOpenResults_Click(object sender, EventArgs e)
        {
            OpenShowDialog();
        }

        /// <summary>
        /// Saves the results and the logs in a txt file.
        /// Occurs when the mnuSave is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuSave_Click(object sender, EventArgs e)
        {
            if (resultsPath != null)
            {
                SaveResults(false);
            }
            else
            {
                SaveAsResults();
            }
        }

        /// <summary>
        /// Displays the sfdResults control to save the results and logs in a new txt file.
        /// Occurs when the mnuSaveAs is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsResults();
        }

        /// <summary>
        /// Makes a FormChart instance and then calls the method FormChart.ShowDialog.
        /// See <see cref="FormChart.FormChart_Load(object, EventArgs)"/>.
        /// Occurs when the mnuChart is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuChart_Click(object sender, EventArgs e)
        {
            FormChart chart = new FormChart();
            chart.ShowDialog();
            chart.Dispose();
        }

        /// <summary>
        /// Arranges the results in a html table and copies to the clipboard.
        /// Occurs when the mnuCopyResults is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuCopyResults_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            string header = "<table><tbody><tr>";

            for (int i = 0; i < lvwResults.Columns.Count; i++)
            {
                header += "<td>" + lvwResults.Columns[i].Text + "</td>";
            }

            header += "</tr>";

            string footer = "<tr style=\"color: #800000;\"><td colspan=\"5\">" + WebUtility.HtmlEncode(lblStats.Text) + "</td></tr></tbody></table>";

            ClipboardHtml.CopyToClipboard(header + buffer + footer, text[48]);

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Clean up the lvwResults control.
        /// If the new results have not yet been saved, displays a MessageBox to choose to save or not the new results, or to cancel the cleanup.
        /// Occurs when the mnuClear is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void MnuClear_Click(object sender, EventArgs e)
        {
            if (newResult > 0)
            {
                string saveText;

                if (string.IsNullOrEmpty(txtName))
                {
                    saveText = text[46] + "\"" + text[29] + "\"?";
                }
                else
                {
                    saveText = text[46] + "\"" + txtName + "\"?";
                }

                DialogResult dr = MessageBox.Show(saveText, text[7], MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) // Save
                {
                    mnuSave.PerformClick();

                    ClearResults();
                }
                else if (dr == DialogResult.No) // Do not save
                {
                    ClearResults();
                }
            }
            else
            {
                ClearResults();
            }
        }
        #endregion

        #region BtnCheck_Click
        /// <summary>
        /// Checks or unchecks all tests.
        /// Occurs when the btnCheck is clicked.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ListView lvw = lvwTests[tbcTests.SelectedIndex];

            lvw.SelectedItems.Clear();

            bool check = (lvw.CheckedItems.Count == lvw.Items.Count) ? false : true;

            foreach (ListViewItem lvi in lvw.Items)
            {
                lvi.Checked = check;
            }

            FocusCueSelect();
        }
        #endregion

        #region BtnUp_Click
        /// <summary>
        /// Moves a test selected one position above.
        /// Occurs when the btnUp is clicked.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnUp_Click(object sender, EventArgs e)
        {
            OrderTest(true);
        }
        #endregion

        #region BtnDown_Click
        /// <summary>
        /// Moves a test selected one position below.
        /// Occurs when the btnDown is clicked.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnDown_Click(object sender, EventArgs e)
        {
            OrderTest(false);
        }
        #endregion

        #region BtnOpenEvidence_Click
        /// <summary>
        /// Opens the evidences file of a result.
        /// Occurs when the btnOpenEvidence is clicked.
        /// </summary>
        /// <remarks>
        /// A MessageBox is displayed:
        /// if no one result is selected in the lvwResults control;
        /// if the result does not have the evidences file;
        /// if the evidences file does not exist;
        /// if to occurs an error.
        /// </remarks>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnOpenEvidence_Click(object sender, EventArgs e)
        {
            if (lvwResults.SelectedItems.Count > 0)
            {
                string docxName = lvwResults.SelectedItems[0].SubItems[evidenceIndex].Text;
                string docxPath = docxFolder + @"\" + docxName;

                try
                {
                    if (docxName.Equals(empty))
                    {
                        MessageBox.Show(text[38], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        lvwResults.Select();

                        return;
                    }

                    if (!File.Exists(docxPath))
                    {
                        MessageBox.Show(text[39], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        lvwResults.Select();

                        return;
                    }

                    btnOpenEvidence.Enabled = false;

                    lvwResults.Select();

                    this.TopMost = false;

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = Path.GetFileName(docxPath),
                        WorkingDirectory = Path.GetDirectoryName(docxPath)
                    };

                    activate = false;

                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    Quiui.DebugEx(ex);

                    MessageBox.Show(text[54], text[7], MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lvwResults.Select();
                }
            }
            else
            {
                MessageBox.Show(text[34], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region BtnCancel_Click
        /// <summary>
        /// Cancels the run of the tests.
        /// Occurs when the btnCancel is clicked.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();

            btnCancel.Enabled = false;

            remain = 0;
            UpdateLblRemain(remain);
            ForeColorLblRemain(true);

            picLoadPurple.Visible = false;
            picLoadRed.Visible = true;

            FocusCueSelect();
        }
        #endregion

        #region BtnStart_Click
        /// <summary>
        /// Starts the run of the tests.
        /// Occurs when the btnStart is clicked.
        /// </summary>
        /// <remarks>
        /// A MessageBox is displayed:
        /// if no one test is checked;
        /// when the btnCancel control is clicked before the start of the run.
        /// </remarks>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (NoOneTestChecked())
            {
                MessageBox.Show(text[32], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FocusCueSelect();
            }
            else
            {
                tokenSource = new CancellationTokenSource();
                Quiui.Token = tokenSource.Token;

                EnabledFalse();
                PushTestStack();

                remain = tests.Count;
                UpdateLblRemain(remain);

                picLoadPurple.Visible = true;
                lblRemain.Visible = true;

                hasInternet = await InternetAvailable();

                if (!hasInternet || Quiui.Token.IsCancellationRequested)
                {
                    picLoadPurple.Visible = false;
                    picLoadRed.Visible = false;
                    lblRemain.Visible = false;
                    ForeColorLblRemain();

                    this.Cursor = Cursors.Default;

                    if (Quiui.Token.IsCancellationRequested)
                    {
                        MessageBox.Show(text[43], text[7], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(text[44], text[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    EnabledTrue();

                    return;
                }

                finish1 = false;
                newResultAdded = false;

                int count = TestChecked();

                runTime.Restart();

                if (mnu1Test.Checked)
                {
                    Robot1();
                }
                else if (mnu2Tests.Checked)
                {
                    Robot1();

                    if (count > 1)
                    {
                        finish2 = false;
                        await System.Threading.Tasks.Task.Delay(700);
                        Robot2();
                    }
                }
                else
                {
                    Robot1();

                    if (count > 1)
                    {
                        finish2 = false;
                        await System.Threading.Tasks.Task.Delay(700);
                        Robot2();

                        if (count > 2)
                        {
                            finish3 = false;
                            await System.Threading.Tasks.Task.Delay(700);
                            Robot3();
                        }
                    }
                }
            }
        }
        #endregion

        #region *** CODE ***
        /// <summary>
        /// Directory of the QuiuiApp solution in your pc or in a team repository, etc.
        /// Change the solutionFolder value and rebuild solution (essential step).
        /// </summary>
        private const string solutionFolder = @"D:\Projects\Dragonair\QuiuiApp";

        /// <summary>
        /// Used by the methods this.Encrypt1, this.Encrypt2, this.Encrypt3 and this.Decrypt.
        /// Change the hash value (essential step).
        /// </summary>
        private const string hash = "Al*$pio&7";

        /// <summary>
        /// Adds the test classes in a Type[].
        /// </summary>
        /// <returns>A Type[] containing the test classes.</returns>
        private Type[] TestClasses()
        {
            // Open the Test Explorer (Ctrl+E, T), group by class and then add the test classes (essential step).
            return new Type[]
            {
                typeof(TestClassA),
                typeof(TestClassB)
            };
        }

        // Create one object of each test class (essential step).

        /// <summary>
        /// Contains its test methods.
        /// </summary>
        private TestClassA testClassA = new TestClassA();

        /// <summary>
        /// Contains its test methods.
        /// </summary>
        private TestClassB testClassB = new TestClassB();

        /// <summary>
        /// Calls a test method.
        /// </summary>
        /// <param name="testName">Name of the test method.</param>
        /// <param name="docxName">Name of the evidences file.</param>
        /// <param name="logs">List to add the logs of the test.</param>
        /// <exception cref="System.Exception">Throws if the test does not exist or if the call of the method has not yet been added.</exception>
        private void CallTestMethod(string testName, string docxName, List<string> logs)
        {
            switch (testName)
            {
                // Call the test methods of the test classes (essential step).
                case "FranceTest":
                    testClassA.FranceTest(docxName, logs);
                    break;
                case "PanamaTest":
                    testClassA.PanamaTest(docxName, logs);
                    break;
                case "PortugalTest":
                    testClassA.PortugalTest(docxName, logs);
                    break;
                case "SpainTest":
                    testClassA.SpainTest(docxName, logs);
                    break;
                case "SingaporeTest":
                    testClassA.SingaporeTest(docxName, logs);
                    break;
                case "SenegalTest":
                    testClassA.SenegalTest(docxName, logs);
                    break;
                case "Japan5minTest":
                    testClassA.Japan5minTest(docxName, logs);
                    break;
                case "FrenchFriesTest":
                    testClassB.FrenchFriesTest(docxName, logs);
                    break;
                case "FruitSaladTest":
                    testClassB.FruitSaladTest(docxName, logs);
                    break;
                case "MashedPotatoesTest":
                    testClassB.MashedPotatoesTest(docxName, logs);
                    break;
                case "PuddingTest":
                    testClassB.PuddingTest(docxName, logs);
                    break;
                case "WatermelonTest":
                    testClassB.WatermelonTest(docxName, logs);
                    break;
                case "ApplePieTest":
                    testClassB.ApplePieTest(docxName, logs);
                    break;
                default:
                    throw new Exception(text[47]);
            }
        }
        #endregion
    }
}