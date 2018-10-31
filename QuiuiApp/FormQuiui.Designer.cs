namespace QuiuiApp
{
    partial class FormQuiui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiui));
            this.mnuApp = new System.Windows.Forms.MenuStrip();
            this.mnuInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPortuguese = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenEvidencesFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu3Tests = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2Tests = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1Test = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResultsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdResults = new System.Windows.Forms.SaveFileDialog();
            this.ofdResults = new System.Windows.Forms.OpenFileDialog();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblRemain = new System.Windows.Forms.Label();
            this.tbcTests = new System.Windows.Forms.TabControl();
            this.lvwResults = new System.Windows.Forms.ListView();
            this.clmIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmElapsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilsResults = new System.Windows.Forms.ImageList(this.components);
            this.lblResults = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTests = new System.Windows.Forms.Label();
            this.btnOpenEvidence = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lblLogs = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.ilsMenu = new System.Windows.Forms.ImageList(this.components);
            this.tlpApp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.picLoadPurple = new System.Windows.Forms.PictureBox();
            this.picLoadRed = new System.Windows.Forms.PictureBox();
            this.pnlTests = new System.Windows.Forms.Panel();
            this.lblLeft = new System.Windows.Forms.Label();
            this.tlpApp.SuspendLayout();
            this.pnlLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadRed)).BeginInit();
            this.pnlTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuApp
            // 
            this.mnuApp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuApp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuApp.Location = new System.Drawing.Point(0, 0);
            this.mnuApp.Name = "mnuApp";
            this.mnuApp.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuApp.Size = new System.Drawing.Size(1242, 24);
            this.mnuApp.TabIndex = 0;
            this.mnuApp.Text = "menuStrip1";
            this.mnuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuInterface,
                this.mnuLogs,
                this.mnuOptions,
                this.mnuResults
            });
            // 
            // mnuInterface
            // 
            this.mnuInterface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuPortuguese});
            this.mnuInterface.Name = "mnuInterface";
            this.mnuInterface.Size = new System.Drawing.Size(89, 27);
            this.mnuInterface.Text = "Interface";
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Checked = true;
            this.mnuEnglish.CheckOnClick = true;
            this.mnuEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuEnglish.Image = ((System.Drawing.Image)(resources.GetObject("mnuEnglish.Image")));
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEnglish.Size = new System.Drawing.Size(199, 26);
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.MnuEnglish_Click);
            this.mnuEnglish.MouseEnter += new System.EventHandler(this.MnuEnglish_MouseEnter);
            this.mnuEnglish.MouseLeave += new System.EventHandler(this.MnuEnglish_MouseLeave);
            // 
            // mnuPortuguese
            // 
            this.mnuPortuguese.CheckOnClick = true;
            this.mnuPortuguese.Image = ((System.Drawing.Image)(resources.GetObject("mnuPortuguese.Image")));
            this.mnuPortuguese.Name = "mnuPortuguese";
            this.mnuPortuguese.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPortuguese.Size = new System.Drawing.Size(199, 26);
            this.mnuPortuguese.Text = "Português";
            this.mnuPortuguese.Click += new System.EventHandler(this.MnuPortuguese_Click);
            this.mnuPortuguese.MouseEnter += new System.EventHandler(this.MnuPortuguese_MouseEnter);
            this.mnuPortuguese.MouseLeave += new System.EventHandler(this.MnuPortuguese_MouseLeave);
            // 
            // mnuLogs
            // 
            this.mnuLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.mnuHide,
            this.mnuLogsSeparator,
            this.mnuCopyLogs});
            this.mnuLogs.Name = "mnuLogs";
            this.mnuLogs.Size = new System.Drawing.Size(57, 27);
            this.mnuLogs.Text = "Logs";
            // 
            // mnuShow
            // 
            this.mnuShow.Checked = true;
            this.mnuShow.CheckOnClick = true;
            this.mnuShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShow.Image = ((System.Drawing.Image)(resources.GetObject("mnuShow.Image")));
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuShow.Size = new System.Drawing.Size(190, 26);
            this.mnuShow.Text = "Show";
            this.mnuShow.Click += new System.EventHandler(this.MnuShow_Click);
            this.mnuShow.MouseEnter += new System.EventHandler(this.MnuShow_MouseEnter);
            this.mnuShow.MouseLeave += new System.EventHandler(this.MnuShow_MouseLeave);
            // 
            // mnuHide
            // 
            this.mnuHide.CheckOnClick = true;
            this.mnuHide.Image = ((System.Drawing.Image)(resources.GetObject("mnuHide.Image")));
            this.mnuHide.Name = "mnuHide";
            this.mnuHide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuHide.Size = new System.Drawing.Size(190, 26);
            this.mnuHide.Text = "Hide";
            this.mnuHide.Click += new System.EventHandler(this.MnuHide_Click);
            this.mnuHide.MouseEnter += new System.EventHandler(this.MnuHide_MouseEnter);
            this.mnuHide.MouseLeave += new System.EventHandler(this.MnuHide_MouseLeave);
            // 
            // mnuLogsSeparator
            // 
            this.mnuLogsSeparator.Name = "mnuLogsSeparator";
            this.mnuLogsSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // mnuCopyLogs
            // 
            this.mnuCopyLogs.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopyLogs.Image")));
            this.mnuCopyLogs.Name = "mnuCopyLogs";
            this.mnuCopyLogs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuCopyLogs.Size = new System.Drawing.Size(190, 26);
            this.mnuCopyLogs.Text = "Copy all";
            this.mnuCopyLogs.Click += new System.EventHandler(this.MnuCopyLogs_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenEvidencesFolder,
            this.mnuNumber,
            this.mnuCancel,
            this.mnuWatch});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(82, 27);
            this.mnuOptions.Text = "Options";
            // 
            // mnuOpenEvidencesFolder
            // 
            this.mnuOpenEvidencesFolder.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpenEvidencesFolder.Image")));
            this.mnuOpenEvidencesFolder.Name = "mnuOpenEvidencesFolder";
            this.mnuOpenEvidencesFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuOpenEvidencesFolder.Size = new System.Drawing.Size(555, 26);
            this.mnuOpenEvidencesFolder.Text = "Open evidences folder";
            this.mnuOpenEvidencesFolder.Click += new System.EventHandler(this.MnuOpenEvidencesFolder_Click);
            // 
            // mnuNumber
            // 
            this.mnuNumber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu3Tests,
            this.mnu2Tests,
            this.mnu1Test});
            this.mnuNumber.Name = "mnuNumber";
            this.mnuNumber.Size = new System.Drawing.Size(555, 26);
            this.mnuNumber.Text = "Number of tests run in parallel";
            // 
            // mnu3Tests
            // 
            this.mnu3Tests.Checked = true;
            this.mnu3Tests.CheckOnClick = true;
            this.mnu3Tests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu3Tests.Image = ((System.Drawing.Image)(resources.GetObject("mnu3Tests.Image")));
            this.mnu3Tests.Name = "mnu3Tests";
            this.mnu3Tests.Size = new System.Drawing.Size(225, 26);
            this.mnu3Tests.Text = "3 tests";
            this.mnu3Tests.Click += new System.EventHandler(this.Mnu3Tests_Click);
            this.mnu3Tests.MouseEnter += new System.EventHandler(this.Mnu3Tests_MouseEnter);
            this.mnu3Tests.MouseLeave += new System.EventHandler(this.Mnu3Tests_MouseLeave);
            // 
            // mnu2Tests
            // 
            this.mnu2Tests.CheckOnClick = true;
            this.mnu2Tests.Name = "mnu2Tests";
            this.mnu2Tests.Size = new System.Drawing.Size(225, 26);
            this.mnu2Tests.Text = "2 tests";
            this.mnu2Tests.Click += new System.EventHandler(this.Mnu2Tests_Click);
            this.mnu2Tests.MouseEnter += new System.EventHandler(this.Mnu2Tests_MouseEnter);
            this.mnu2Tests.MouseLeave += new System.EventHandler(this.Mnu2Tests_MouseLeave);
            // 
            // mnu1Test
            // 
            this.mnu1Test.CheckOnClick = true;
            this.mnu1Test.Name = "mnu1Test";
            this.mnu1Test.Size = new System.Drawing.Size(225, 26);
            this.mnu1Test.Text = "Do not run in parallel";
            this.mnu1Test.Click += new System.EventHandler(this.Mnu1Test_Click);
            this.mnu1Test.MouseEnter += new System.EventHandler(this.Mnu1Test_MouseEnter);
            this.mnu1Test.MouseLeave += new System.EventHandler(this.Mnu1Test_MouseLeave);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Checked = true;
            this.mnuCancel.CheckOnClick = true;
            this.mnuCancel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuCancel.Image = ((System.Drawing.Image)(resources.GetObject("mnuCancel.Image")));
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(555, 26);
            this.mnuCancel.Text = "Cancel the run of the tests when the internet connection is not available";
            this.mnuCancel.Click += new System.EventHandler(this.MnuCancel_Click);
            this.mnuCancel.MouseEnter += new System.EventHandler(this.MnuCancel_MouseEnter);
            this.mnuCancel.MouseLeave += new System.EventHandler(this.MnuCancel_MouseLeave);
            // 
            // mnuWatch
            // 
            this.mnuWatch.Checked = true;
            this.mnuWatch.CheckOnClick = true;
            this.mnuWatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuWatch.Image = ((System.Drawing.Image)(resources.GetObject("mnuWatch.Image")));
            this.mnuWatch.Name = "mnuWatch";
            this.mnuWatch.Size = new System.Drawing.Size(555, 26);
            this.mnuWatch.Text = "Watch QuiuiTool while the run of the tests";
            this.mnuWatch.Click += new System.EventHandler(this.MnuWatch_Click);
            this.mnuWatch.MouseEnter += new System.EventHandler(this.MnuWatch_MouseEnter);
            this.mnuWatch.MouseLeave += new System.EventHandler(this.MnuWatch_MouseLeave);
            // 
            // mnuResults
            // 
            this.mnuResults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenResults,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuChart,
            this.mnuResultsSeparator,
            this.mnuCopyResults,
            this.mnuClear});
            this.mnuResults.Name = "mnuResults";
            this.mnuResults.Size = new System.Drawing.Size(75, 27);
            this.mnuResults.Text = "Results";
            // 
            // mnuOpenResults
            // 
            this.mnuOpenResults.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpenResults.Image")));
            this.mnuOpenResults.Name = "mnuOpenResults";
            this.mnuOpenResults.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenResults.Size = new System.Drawing.Size(190, 26);
            this.mnuOpenResults.Text = "Open";
            this.mnuOpenResults.Click += new System.EventHandler(this.MnuOpenResults_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Enabled = false;
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(190, 26);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.MnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Enabled = false;
            this.mnuSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveAs.Image")));
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSaveAs.Size = new System.Drawing.Size(190, 26);
            this.mnuSaveAs.Text = "Save as";
            this.mnuSaveAs.Click += new System.EventHandler(this.MnuSaveAs_Click);
            // 
            // mnuChart
            // 
            this.mnuChart.Enabled = false;
            this.mnuChart.Image = ((System.Drawing.Image)(resources.GetObject("mnuChart.Image")));
            this.mnuChart.Name = "mnuChart";
            this.mnuChart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuChart.Size = new System.Drawing.Size(190, 26);
            this.mnuChart.Text = "Chart";
            this.mnuChart.Click += new System.EventHandler(this.MnuChart_Click);
            // 
            // mnuResultsSeparator
            // 
            this.mnuResultsSeparator.Name = "mnuResultsSeparator";
            this.mnuResultsSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // mnuCopyResults
            // 
            this.mnuCopyResults.Enabled = false;
            this.mnuCopyResults.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopyResults.Image")));
            this.mnuCopyResults.Name = "mnuCopyResults";
            this.mnuCopyResults.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuCopyResults.Size = new System.Drawing.Size(190, 26);
            this.mnuCopyResults.Text = "Copy all";
            this.mnuCopyResults.Click += new System.EventHandler(this.MnuCopyResults_Click);
            // 
            // mnuClear
            // 
            this.mnuClear.Enabled = false;
            this.mnuClear.Image = ((System.Drawing.Image)(resources.GetObject("mnuClear.Image")));
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuClear.Size = new System.Drawing.Size(190, 26);
            this.mnuClear.Text = "Clear all";
            this.mnuClear.Click += new System.EventHandler(this.MnuClear_Click);
            // 
            // sfdResults
            // 
            this.sfdResults.DefaultExt = "txt";
            this.sfdResults.Filter = "txt files|*.txt";
            this.sfdResults.Title = "Save results";
            // 
            // ofdResults
            // 
            this.ofdResults.DefaultExt = "txt";
            this.ofdResults.Filter = "txt files|*.txt";
            this.ofdResults.Title = "Open results";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.Location = new System.Drawing.Point(21, 6);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(36, 32);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(104, 6);
            this.btnDown.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 32);
            this.btnDown.TabIndex = 0;
            this.btnDown.TabStop = false;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            this.btnDown.MouseEnter += new System.EventHandler(this.BtnDown_MouseEnter);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(63, 6);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 32);
            this.btnUp.TabIndex = 0;
            this.btnUp.TabStop = false;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            this.btnUp.MouseEnter += new System.EventHandler(this.BtnUp_MouseEnter);
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.ForeColor = System.Drawing.Color.Purple;
            this.lblRemain.Location = new System.Drawing.Point(725, 0);
            this.lblRemain.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(189, 29);
            this.lblRemain.TabIndex = 0;
            this.lblRemain.Text = "Restam 000 testes";
            this.lblRemain.Visible = false;
            // 
            // tbcTests
            // 
            this.tbcTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpApp.SetColumnSpan(this.tbcTests, 2);
            this.tbcTests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcTests.Location = new System.Drawing.Point(20, 81);
            this.tbcTests.Margin = new System.Windows.Forms.Padding(0, 4, 20, 4);
            this.tbcTests.Name = "tbcTests";
            this.tlpApp.SetRowSpan(this.tbcTests, 4);
            this.tbcTests.SelectedIndex = 0;
            this.tbcTests.Size = new System.Drawing.Size(308, 443);
            this.tbcTests.TabIndex = 1;
            this.tbcTests.SelectedIndexChanged += new System.EventHandler(this.TbcTests_SelectedIndexChanged);
            // 
            // lvwResults
            // 
            this.lvwResults.AllowColumnReorder = true;
            this.lvwResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwResults.CheckBoxes = true;
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIcon,
            this.clmTest,
            this.clmResult,
            this.clmMessage,
            this.clmElapsed});
            this.tlpApp.SetColumnSpan(this.lvwResults, 3);
            this.lvwResults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwResults.FullRowSelect = true;
            this.lvwResults.GridLines = true;
            this.lvwResults.HideSelection = false;
            this.lvwResults.Location = new System.Drawing.Point(348, 81);
            this.lvwResults.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lvwResults.MultiSelect = false;
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(874, 256);
            this.lvwResults.SmallImageList = this.ilsResults;
            this.lvwResults.TabIndex = 3;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.Details;
            this.lvwResults.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LvwResults_ItemCheck);
            this.lvwResults.SelectedIndexChanged += new System.EventHandler(this.LvwResults_SelectedIndexChanged);
            // 
            // clmIcon
            // 
            this.clmIcon.Text = "";
            // 
            // clmTest
            // 
            this.clmTest.Text = "Test";
            this.clmTest.Width = 100;
            // 
            // clmResult
            // 
            this.clmResult.Text = "Result";
            this.clmResult.Width = 120;
            // 
            // clmMessage
            // 
            this.clmMessage.Text = "Message";
            this.clmMessage.Width = 130;
            // 
            // clmElapsed
            // 
            this.clmElapsed.Text = "Elapsed Time";
            this.clmElapsed.Width = 180;
            // 
            // ilsResults
            // 
            this.ilsResults.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsResults.ImageStream")));
            this.ilsResults.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsResults.Images.SetKeyName(0, "passed.jpg");
            this.ilsResults.Images.SetKeyName(1, "failed.jpg");
            this.ilsResults.Images.SetKeyName(2, "inconc.jpg");
            this.ilsResults.Images.SetKeyName(3, "unknown.jpg");
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.tlpApp.SetColumnSpan(this.lblResults, 3);
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(348, 54);
            this.lblResults.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(63, 23);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(20, 532);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(178, 532);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 20, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTests.Location = new System.Drawing.Point(20, 54);
            this.lblTests.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(46, 23);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Tests";
            // 
            // btnOpenEvidence
            // 
            this.btnOpenEvidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEvidence.Enabled = false;
            this.btnOpenEvidence.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEvidence.Location = new System.Drawing.Point(1072, 345);
            this.btnOpenEvidence.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.btnOpenEvidence.Name = "btnOpenEvidence";
            this.btnOpenEvidence.Size = new System.Drawing.Size(150, 36);
            this.btnOpenEvidence.TabIndex = 4;
            this.btnOpenEvidence.Text = "Evidence";
            this.btnOpenEvidence.UseVisualStyleBackColor = true;
            this.btnOpenEvidence.Click += new System.EventHandler(this.BtnOpenEvidence_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogs.BackColor = System.Drawing.SystemColors.Window;
            this.tlpApp.SetColumnSpan(this.txtLogs, 3);
            this.txtLogs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(348, 408);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.tlpApp.SetRowSpan(this.txtLogs, 2);
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(874, 161);
            this.txtLogs.TabIndex = 5;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.tlpApp.SetColumnSpan(this.lblLogs, 3);
            this.lblLogs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogs.Location = new System.Drawing.Point(348, 381);
            this.lblLogs.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(45, 23);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "Logs";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.tlpApp.SetColumnSpan(this.lblStats, 2);
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.Maroon;
            this.lblStats.Location = new System.Drawing.Point(348, 341);
            this.lblStats.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(46, 23);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Stats";
            // 
            // ilsMenu
            // 
            this.ilsMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsMenu.ImageStream")));
            this.ilsMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsMenu.Images.SetKeyName(0, "shield.png");
            this.ilsMenu.Images.SetKeyName(1, "gear.png");
            this.ilsMenu.Images.SetKeyName(2, "arrow.png");
            // 
            // tlpApp
            // 
            this.tlpApp.ColumnCount = 5;
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33291F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66709F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpApp.Controls.Add(this.lblTests, 0, 1);
            this.tlpApp.Controls.Add(this.lvwResults, 2, 2);
            this.tlpApp.Controls.Add(this.lblResults, 2, 1);
            this.tlpApp.Controls.Add(this.lblStats, 2, 3);
            this.tlpApp.Controls.Add(this.lblLogs, 2, 4);
            this.tlpApp.Controls.Add(this.txtLogs, 2, 5);
            this.tlpApp.Controls.Add(this.btnCancel, 0, 6);
            this.tlpApp.Controls.Add(this.btnStart, 1, 6);
            this.tlpApp.Controls.Add(this.tbcTests, 0, 2);
            this.tlpApp.Controls.Add(this.pnlLoad, 2, 0);
            this.tlpApp.Controls.Add(this.lblRemain, 3, 0);
            this.tlpApp.Controls.Add(this.btnOpenEvidence, 4, 3);
            this.tlpApp.Controls.Add(this.pnlTests, 1, 0);
            this.tlpApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApp.Location = new System.Drawing.Point(0, 24);
            this.tlpApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpApp.Name = "tlpApp";
            this.tlpApp.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tlpApp.RowCount = 7;
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.95181F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.04819F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpApp.Size = new System.Drawing.Size(1242, 589);
            this.tlpApp.TabIndex = 0;
            // 
            // pnlLoad
            // 
            this.pnlLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoad.Controls.Add(this.picLoadPurple);
            this.pnlLoad.Controls.Add(this.picLoadRed);
            this.pnlLoad.Location = new System.Drawing.Point(617, 0);
            this.pnlLoad.Margin = new System.Windows.Forms.Padding(3, 0, 0, 11);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(100, 43);
            this.pnlLoad.TabIndex = 72;
            // 
            // picLoadPurple
            // 
            this.picLoadPurple.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picLoadPurple.Image = ((System.Drawing.Image)(resources.GetObject("picLoadPurple.Image")));
            this.picLoadPurple.Location = new System.Drawing.Point(69, 0);
            this.picLoadPurple.Margin = new System.Windows.Forms.Padding(0);
            this.picLoadPurple.Name = "picLoadPurple";
            this.picLoadPurple.Size = new System.Drawing.Size(31, 31);
            this.picLoadPurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLoadPurple.TabIndex = 68;
            this.picLoadPurple.TabStop = false;
            this.picLoadPurple.Visible = false;
            // 
            // picLoadRed
            // 
            this.picLoadRed.Image = ((System.Drawing.Image)(resources.GetObject("picLoadRed.Image")));
            this.picLoadRed.Location = new System.Drawing.Point(69, 0);
            this.picLoadRed.Margin = new System.Windows.Forms.Padding(0);
            this.picLoadRed.Name = "picLoadRed";
            this.picLoadRed.Size = new System.Drawing.Size(31, 31);
            this.picLoadRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLoadRed.TabIndex = 70;
            this.picLoadRed.TabStop = false;
            this.picLoadRed.Visible = false;
            // 
            // pnlTests
            // 
            this.pnlTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTests.Controls.Add(this.btnCheck);
            this.pnlTests.Controls.Add(this.btnUp);
            this.pnlTests.Controls.Add(this.btnDown);
            this.pnlTests.Location = new System.Drawing.Point(188, 16);
            this.pnlTests.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pnlTests.Name = "pnlTests";
            this.pnlTests.Size = new System.Drawing.Size(140, 38);
            this.pnlTests.TabIndex = 2;
            this.pnlTests.TabStop = true;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Purple;
            this.lblLeft.Location = new System.Drawing.Point(725, 0);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(189, 29);
            this.lblLeft.TabIndex = 69;
            this.lblLeft.Text = "Restam 000 testes";
            this.lblLeft.Visible = false;
            // 
            // FormQuiui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 613);
            this.Controls.Add(this.tlpApp);
            this.Controls.Add(this.mnuApp);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuApp;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1260, 660);
            this.Name = "FormQuiui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiuiTool";
            this.Activated += new System.EventHandler(this.FormQuiui_Activated);
            this.Deactivate += new System.EventHandler(this.FormQuiui_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuiui_FormClosing);
            this.Load += new System.EventHandler(this.FormQuiui_Load);
            this.tlpApp.ResumeLayout(false);
            this.tlpApp.PerformLayout();
            this.pnlLoad.ResumeLayout(false);
            this.pnlLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadRed)).EndInit();
            this.pnlTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuApp;
        private System.Windows.Forms.SaveFileDialog sfdResults;
        private System.Windows.Forms.OpenFileDialog ofdResults;
        private System.Windows.Forms.ToolStripMenuItem mnuInterface;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuPortuguese;
        private System.Windows.Forms.ToolStripMenuItem mnuLogs;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuHide;
        private System.Windows.Forms.ToolStripSeparator mnuLogsSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyLogs;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenEvidencesFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuNumber;
        private System.Windows.Forms.ToolStripMenuItem mnu1Test;
        private System.Windows.Forms.ToolStripMenuItem mnu2Tests;
        private System.Windows.Forms.ToolStripMenuItem mnu3Tests;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuWatch;
        private System.Windows.Forms.ToolStripMenuItem mnuResults;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenResults;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuChart;
        private System.Windows.Forms.ToolStripSeparator mnuResultsSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyResults;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TabControl tbcTests;
        private System.Windows.Forms.ListView lvwResults;
        private System.Windows.Forms.ColumnHeader clmIcon;
        private System.Windows.Forms.ColumnHeader clmTest;
        private System.Windows.Forms.ColumnHeader clmResult;
        private System.Windows.Forms.ColumnHeader clmMessage;
        private System.Windows.Forms.ColumnHeader clmElapsed;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Button btnOpenEvidence;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.ImageList ilsResults;
        private System.Windows.Forms.ImageList ilsMenu;
        private System.Windows.Forms.TableLayoutPanel tlpApp;
        private System.Windows.Forms.PictureBox picLoadPurple;
        private System.Windows.Forms.PictureBox picLoadRed;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Panel pnlTests;
        private System.Windows.Forms.Label lblLeft;
    }
}