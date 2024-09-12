using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SpineLabeler
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ManualPrint = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ReviewBox = new System.Windows.Forms.RadioButton();
            this.AutoPrintBox = new System.Windows.Forms.RadioButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.zebraSettingsPanel = new System.Windows.Forms.Panel();
            this.zplBatchPreview = new System.Windows.Forms.TextBox();
            this.btnTestPrint = new System.Windows.Forms.Button();
            this.numupTopOffset = new System.Windows.Forms.NumericUpDown();
            this.labelTopOffset = new System.Windows.Forms.Label();
            this.numudSplitOffset = new System.Windows.Forms.NumericUpDown();
            this.labelSplitOffset = new System.Windows.Forms.Label();
            this.labelZebraPrinter = new System.Windows.Forms.Label();
            this.zebraPrinterBox = new System.Windows.Forms.ComboBox();
            this.panelMax = new System.Windows.Forms.Panel();
            this.inMaxLines = new System.Windows.Forms.TextBox();
            this.inMaxChars = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.UseZPL = new System.Windows.Forms.RadioButton();
            this.viaDOSPanel = new System.Windows.Forms.Panel();
            this.viadosCaution = new System.Windows.Forms.Label();
            this.Panel17 = new System.Windows.Forms.Panel();
            this.appendAscii = new System.Windows.Forms.TextBox();
            this.dosUseFF = new System.Windows.Forms.RadioButton();
            this.dosAddLines = new System.Windows.Forms.RadioButton();
            this.dosBlankLines = new System.Windows.Forms.TextBox();
            this.Label115 = new System.Windows.Forms.Label();
            this.Label120 = new System.Windows.Forms.Label();
            this.Label122 = new System.Windows.Forms.Label();
            this.dosParam2 = new System.Windows.Forms.TextBox();
            this.dosParam1 = new System.Windows.Forms.TextBox();
            this.batsignal = new System.Windows.Forms.Label();
            this.loadViados = new System.Windows.Forms.Button();
            this.hideDosWindow = new System.Windows.Forms.CheckBox();
            this.Label119 = new System.Windows.Forms.Label();
            this.Label118 = new System.Windows.Forms.Label();
            this.dosPlTabNum = new System.Windows.Forms.TextBox();
            this.dosPlColNum = new System.Windows.Forms.TextBox();
            this.dosPlUseTab = new System.Windows.Forms.RadioButton();
            this.dosPlUseCol = new System.Windows.Forms.RadioButton();
            this.Label117 = new System.Windows.Forms.Label();
            this.Label114 = new System.Windows.Forms.Label();
            this.batchDisplay = new System.Windows.Forms.TextBox();
            this.viadosSave = new System.Windows.Forms.Button();
            this.useDOSBatch = new System.Windows.Forms.CheckBox();
            this.FTPwarning = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.showLabelType = new System.Windows.Forms.Label();
            this.orientationPanel = new System.Windows.Forms.Panel();
            this.usePortrait = new System.Windows.Forms.RadioButton();
            this.useLandscape = new System.Windows.Forms.RadioButton();
            this.marginPanel = new System.Windows.Forms.Panel();
            this.inUnits1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.inTopMargin = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.inLeftMargin = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.inLineSpacing = new System.Windows.Forms.TextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.UseLaser = new System.Windows.Forms.RadioButton();
            this.UseFTP = new System.Windows.Forms.RadioButton();
            this.UseDesktop = new System.Windows.Forms.RadioButton();
            this.FTPGroup = new System.Windows.Forms.GroupBox();
            this.ftpRegisterMsg = new System.Windows.Forms.Label();
            this.btn_ftpRegister = new System.Windows.Forms.Button();
            this.ftpArrow = new System.Windows.Forms.Label();
            this.FTPInfo = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.FTPHelp = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.FTPPassword = new System.Windows.Forms.TextBox();
            this.Label48 = new System.Windows.Forms.Label();
            this.FTPLogin = new System.Windows.Forms.TextBox();
            this.Label46 = new System.Windows.Forms.Label();
            this.FTPip = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.TextBox23 = new System.Windows.Forms.TextBox();
            this.TextBox22 = new System.Windows.Forms.TextBox();
            this.TextBox21 = new System.Windows.Forms.TextBox();
            this.TextBox20 = new System.Windows.Forms.TextBox();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.DesktopGroup = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnBCFontDialog = new System.Windows.Forms.Button();
            this.inBCFontWeight = new System.Windows.Forms.CheckBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.inBCFontSize = new System.Windows.Forms.TextBox();
            this.inBCFontName = new System.Windows.Forms.TextBox();
            this.SheetSettings = new System.Windows.Forms.Panel();
            this.Label121 = new System.Windows.Forms.Label();
            this.inUnits2 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.inStartCol = new System.Windows.Forms.TextBox();
            this.inStartRow = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.batchEntries = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.batchNumber = new System.Windows.Forms.NumericUpDown();
            this.batchPreview = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnPrintBatch = new System.Windows.Forms.Button();
            this.Label42 = new System.Windows.Forms.Label();
            this.inGapHeight = new System.Windows.Forms.TextBox();
            this.inGapWidth = new System.Windows.Forms.TextBox();
            this.inLabelHeight = new System.Windows.Forms.TextBox();
            this.inLabelWidth = new System.Windows.Forms.TextBox();
            this.inLabelCols = new System.Windows.Forms.TextBox();
            this.inLabelRows = new System.Windows.Forms.TextBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.inFontWeight = new System.Windows.Forms.CheckBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.inFontSize = new System.Windows.Forms.TextBox();
            this.FontDialogButn = new System.Windows.Forms.Button();
            this.inFontName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PrinterDialogButn = new System.Windows.Forms.Button();
            this.inPrinterName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.PocketLabelPanel = new System.Windows.Forms.Panel();
            this.plUnits2 = new System.Windows.Forms.Label();
            this.plUnits1 = new System.Windows.Forms.Label();
            this.userDefinedPanel = new System.Windows.Forms.Panel();
            this.Label96 = new System.Windows.Forms.Label();
            this.plMax4 = new System.Windows.Forms.TextBox();
            this.plMax3 = new System.Windows.Forms.TextBox();
            this.plMax2 = new System.Windows.Forms.TextBox();
            this.plMax1 = new System.Windows.Forms.TextBox();
            this.Label95 = new System.Windows.Forms.Label();
            this.plMin4 = new System.Windows.Forms.TextBox();
            this.plMin3 = new System.Windows.Forms.TextBox();
            this.plMin2 = new System.Windows.Forms.TextBox();
            this.plMin1 = new System.Windows.Forms.TextBox();
            this.Label93 = new System.Windows.Forms.Label();
            this.Label92 = new System.Windows.Forms.Label();
            this.plSrc4 = new System.Windows.Forms.TextBox();
            this.plSrc3 = new System.Windows.Forms.TextBox();
            this.plSrc2 = new System.Windows.Forms.TextBox();
            this.plSrc1 = new System.Windows.Forms.TextBox();
            this.spineType = new System.Windows.Forms.Label();
            this.Label106 = new System.Windows.Forms.Label();
            this.Label105 = new System.Windows.Forms.Label();
            this.Label104 = new System.Windows.Forms.Label();
            this.Label101 = new System.Windows.Forms.Label();
            this.Label100 = new System.Windows.Forms.Label();
            this.Label94 = new System.Windows.Forms.Label();
            this.btnSL6 = new System.Windows.Forms.RadioButton();
            this.btnSL4 = new System.Windows.Forms.RadioButton();
            this.btnSLB = new System.Windows.Forms.RadioButton();
            this.Label103 = new System.Windows.Forms.Label();
            this.Label102 = new System.Windows.Forms.Label();
            this.plLeftMargin = new System.Windows.Forms.TextBox();
            this.PLcount = new System.Windows.Forms.NumericUpDown();
            this.plDistance = new System.Windows.Forms.TextBox();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label98 = new System.Windows.Forms.Label();
            this.plWork = new System.Windows.Forms.TextBox();
            this.Label97 = new System.Windows.Forms.Label();
            this.btnPlCustom = new System.Windows.Forms.RadioButton();
            this.plOutput = new System.Windows.Forms.TextBox();
            this.Label88 = new System.Windows.Forms.Label();
            this.tweakParsingPanel = new System.Windows.Forms.Panel();
            this.convertBlankTo = new System.Windows.Forms.TextBox();
            this.Label65 = new System.Windows.Forms.Label();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.hideCutterDecimal = new System.Windows.Forms.CheckBox();
            this.lcType = new System.Windows.Forms.TextBox();
            this.Label107 = new System.Windows.Forms.Label();
            this.lcRemoveAfter = new System.Windows.Forms.CheckBox();
            this.lcBreak = new System.Windows.Forms.TextBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.lcOtherBreakAft = new System.Windows.Forms.RadioButton();
            this.Label78 = new System.Windows.Forms.Label();
            this.lcOtherBreakB4 = new System.Windows.Forms.RadioButton();
            this.lcOtherNoBreak = new System.Windows.Forms.RadioButton();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Label76 = new System.Windows.Forms.Label();
            this.lcInCutterBreak = new System.Windows.Forms.RadioButton();
            this.lcIncutternobreak = new System.Windows.Forms.RadioButton();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.Label75 = new System.Windows.Forms.Label();
            this.lcCutterBreak = new System.Windows.Forms.RadioButton();
            this.lcCutterNoBreak = new System.Windows.Forms.RadioButton();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.lcDecimalBreakAfter = new System.Windows.Forms.RadioButton();
            this.Label74 = new System.Windows.Forms.Label();
            this.lcDecimalBreakB4 = new System.Windows.Forms.RadioButton();
            this.lcNoDecimalBreak = new System.Windows.Forms.RadioButton();
            this.lcNumericBreak = new System.Windows.Forms.RadioButton();
            this.lcNoNumericBreak = new System.Windows.Forms.RadioButton();
            this.Label66 = new System.Windows.Forms.Label();
            this.TabPage8 = new System.Windows.Forms.TabPage();
            this.deweyDecBreak = new System.Windows.Forms.CheckBox();
            this.deweyDigitsToBreak = new System.Windows.Forms.TextBox();
            this.Label128 = new System.Windows.Forms.Label();
            this.Label127 = new System.Windows.Forms.Label();
            this.Label126 = new System.Windows.Forms.Label();
            this.Label125 = new System.Windows.Forms.Label();
            this.deweydigitsperline = new System.Windows.Forms.TextBox();
            this.deweyGroup3 = new System.Windows.Forms.CheckBox();
            this.DeweyType = new System.Windows.Forms.TextBox();
            this.Label108 = new System.Windows.Forms.Label();
            this.deweyRemoveAfter = new System.Windows.Forms.CheckBox();
            this.deweyCharBreak = new System.Windows.Forms.TextBox();
            this.Panel15 = new System.Windows.Forms.Panel();
            this.deweyCharBreakAft = new System.Windows.Forms.RadioButton();
            this.Label84 = new System.Windows.Forms.Label();
            this.deweyCharBreakb4 = new System.Windows.Forms.RadioButton();
            this.deweyOtherNoBreak = new System.Windows.Forms.RadioButton();
            this.Panel14 = new System.Windows.Forms.Panel();
            this.Label82 = new System.Windows.Forms.Label();
            this.deweyPrefixBreak = new System.Windows.Forms.RadioButton();
            this.deweyPrefixNoBreak = new System.Windows.Forms.RadioButton();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Label77 = new System.Windows.Forms.Label();
            this.deweyCutterBreak = new System.Windows.Forms.RadioButton();
            this.deweyCutterNoBreak = new System.Windows.Forms.RadioButton();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.deweyDecimalBreakAft = new System.Windows.Forms.RadioButton();
            this.Label79 = new System.Windows.Forms.Label();
            this.deweyDecimalBreakb4 = new System.Windows.Forms.RadioButton();
            this.deweyDecimalNoBreak = new System.Windows.Forms.RadioButton();
            this.TabPage10 = new System.Windows.Forms.TabPage();
            this.sudocRemoveAfter = new System.Windows.Forms.CheckBox();
            this.sudocCharBreak = new System.Windows.Forms.TextBox();
            this.Panel16 = new System.Windows.Forms.Panel();
            this.sudocCharBreakAft = new System.Windows.Forms.RadioButton();
            this.Label113 = new System.Windows.Forms.Label();
            this.sudocCharBreakB4 = new System.Windows.Forms.RadioButton();
            this.sudocOtherNoBreak = new System.Windows.Forms.RadioButton();
            this.sudocType = new System.Windows.Forms.TextBox();
            this.Label109 = new System.Windows.Forms.Label();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.sudocNoBreakB4Numerics = new System.Windows.Forms.RadioButton();
            this.sudocBreakB4Numerics = new System.Windows.Forms.RadioButton();
            this.Label85 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.sudocNoDecimalBreak = new System.Windows.Forms.RadioButton();
            this.sudocBreakDecimal = new System.Windows.Forms.RadioButton();
            this.Label69 = new System.Windows.Forms.Label();
            this.sudocBreakBeforeColon = new System.Windows.Forms.RadioButton();
            this.sudocBreakAfterColon = new System.Windows.Forms.RadioButton();
            this.sudocNoColonBreak = new System.Windows.Forms.RadioButton();
            this.Label67 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.sudocDashNoBreak = new System.Windows.Forms.RadioButton();
            this.sudocDashBreak = new System.Windows.Forms.RadioButton();
            this.Label70 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.sudocSlashNobreak = new System.Windows.Forms.RadioButton();
            this.sudocSlashBreak = new System.Windows.Forms.RadioButton();
            this.Label68 = new System.Windows.Forms.Label();
            this.TabPage11 = new System.Windows.Forms.TabPage();
            this.otherType = new System.Windows.Forms.TextBox();
            this.Label110 = new System.Windows.Forms.Label();
            this.otherRemoveAfter = new System.Windows.Forms.CheckBox();
            this.otherFirstSpaceBreak = new System.Windows.Forms.RadioButton();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.otherNumBreakAfter = new System.Windows.Forms.RadioButton();
            this.otherNumBreakb4 = new System.Windows.Forms.RadioButton();
            this.othernumnobreak = new System.Windows.Forms.RadioButton();
            this.Label83 = new System.Windows.Forms.Label();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.otherListBreakAfter = new System.Windows.Forms.RadioButton();
            this.otherListBreakb4 = new System.Windows.Forms.RadioButton();
            this.otherListNoBreak = new System.Windows.Forms.RadioButton();
            this.Label81 = new System.Windows.Forms.Label();
            this.otherBreak = new System.Windows.Forms.TextBox();
            this.otherAllSpaceBreak = new System.Windows.Forms.RadioButton();
            this.otherSpaceNoBreak = new System.Windows.Forms.RadioButton();
            this.Label80 = new System.Windows.Forms.Label();
            this.TabPage9 = new System.Windows.Forms.TabPage();
            this.Label111 = new System.Windows.Forms.Label();
            this.Label62 = new System.Windows.Forms.Label();
            this.spaceBreak = new System.Windows.Forms.CheckBox();
            this.issueListBreakAfter = new System.Windows.Forms.RadioButton();
            this.issueListBreakB4 = new System.Windows.Forms.RadioButton();
            this.issueListNoBreak = new System.Windows.Forms.RadioButton();
            this.issueRemoveAfter = new System.Windows.Forms.CheckBox();
            this.issueBreak = new System.Windows.Forms.TextBox();
            this.BreakParen = new System.Windows.Forms.CheckBox();
            this.ProtectColon = new System.Windows.Forms.CheckBox();
            this.ColonBreak = new System.Windows.Forms.CheckBox();
            this.Label73 = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.Label59 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.testCallNumType = new System.Windows.Forms.TextBox();
            this.btnTestParser = new System.Windows.Forms.Button();
            this.showFormatInfo = new System.Windows.Forms.TextBox();
            this.FTPwarning2 = new System.Windows.Forms.Label();
            this.Label91 = new System.Windows.Forms.Label();
            this.chkUsePocketLabels = new System.Windows.Forms.CheckBox();
            this.nonFlagWrapWidth = new System.Windows.Forms.TextBox();
            this.flagWrapWidth = new System.Windows.Forms.TextBox();
            this.nonFlagDefaults = new System.Windows.Forms.TextBox();
            this.flagDefaults = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tweakTest = new System.Windows.Forms.Label();
            this.inOtherSource = new System.Windows.Forms.TextBox();
            this.chkIncludeOther = new System.Windows.Forms.CheckBox();
            this.chkIncludeHoldings = new System.Windows.Forms.CheckBox();
            this.radio_useSOMparsing = new System.Windows.Forms.RadioButton();
            this.parsingSource = new System.Windows.Forms.TextBox();
            this.useExlibrisParsing = new System.Windows.Forms.RadioButton();
            this.inCallNumSource = new System.Windows.Forms.TextBox();
            this.inIssueLevelSource = new System.Windows.Forms.TextBox();
            this.Label87 = new System.Windows.Forms.Label();
            this.FlagSlips = new System.Windows.Forms.CheckBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Spine = new System.Windows.Forms.RadioButton();
            this.CustomLabel = new System.Windows.Forms.RadioButton();
            this.CustomText = new System.Windows.Forms.TextBox();
            this.formatInfoPanel = new System.Windows.Forms.Panel();
            this.suppress3 = new System.Windows.Forms.TextBox();
            this.suppress2 = new System.Windows.Forms.TextBox();
            this.suppress1 = new System.Windows.Forms.TextBox();
            this.wrapWidth = new System.Windows.Forms.TextBox();
            this.closeFormatInfo = new System.Windows.Forms.TextBox();
            this.Label45 = new System.Windows.Forms.Label();
            this.spineDefaults = new System.Windows.Forms.TextBox();
            this.pocketDefaults = new System.Windows.Forms.TextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Label57 = new System.Windows.Forms.Label();
            this.radio_useSystem = new System.Windows.Forms.RadioButton();
            this.radio_useLocal = new System.Windows.Forms.RadioButton();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.btn_saveALT = new System.Windows.Forms.Button();
            this.btn_cancelALT = new System.Windows.Forms.Button();
            this.btn_deleteALT = new System.Windows.Forms.Button();
            this.btn_changeALT = new System.Windows.Forms.Button();
            this.btn_addALT = new System.Windows.Forms.Button();
            this.altText = new System.Windows.Forms.TextBox();
            this.altURL = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.SaveAboveLC = new System.Windows.Forms.Button();
            this.altList = new System.Windows.Forms.ListBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.btnDocDownload = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkXMLWarning = new System.Windows.Forms.CheckBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_copyXMLtext = new System.Windows.Forms.Label();
            this.includeSettings = new System.Windows.Forms.CheckBox();
            this.xmlCopyDone = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.dontConvert = new System.Windows.Forms.CheckBox();
            this.xmlShell = new System.Windows.Forms.TextBox();
            this.Label134 = new System.Windows.Forms.Label();
            this.Label131 = new System.Windows.Forms.Label();
            this.apiMethod = new System.Windows.Forms.TextBox();
            this.Label130 = new System.Windows.Forms.Label();
            this.Label129 = new System.Windows.Forms.Label();
            this.apiKey = new System.Windows.Forms.TextBox();
            this.apiURL = new System.Windows.Forms.TextBox();
            this.UseRestfulApi = new System.Windows.Forms.RadioButton();
            this.ispList = new System.Windows.Forms.ListBox();
            this.updatePath = new System.Windows.Forms.TextBox();
            this.configText = new System.Windows.Forms.TextBox();
            this.logEdits = new System.Windows.Forms.CheckBox();
            this.XMLPath = new System.Windows.Forms.TextBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.showIsp = new System.Windows.Forms.CheckBox();
            this.chkAddHostname = new System.Windows.Forms.CheckBox();
            this.copyDone = new System.Windows.Forms.Label();
            this.lbl_setclipboard = new System.Windows.Forms.Label();
            this.chkGeoList = new System.Windows.Forms.CheckBox();
            this.inclScanned = new System.Windows.Forms.CheckBox();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.GroupBox();
            this.byAlpha = new System.Windows.Forms.RadioButton();
            this.byCount = new System.Windows.Forms.RadioButton();
            this.sortSTL = new System.Windows.Forms.ListBox();
            this.radioByLocation = new System.Windows.Forms.RadioButton();
            this.Label56 = new System.Windows.Forms.Label();
            this.searchArg = new System.Windows.Forms.TextBox();
            this.radioSearch = new System.Windows.Forms.RadioButton();
            this.statsOut = new System.Windows.Forms.TextBox();
            this.radioByLibrary = new System.Windows.Forms.RadioButton();
            this.radioByUser = new System.Windows.Forms.RadioButton();
            this.btnScan = new System.Windows.Forms.Button();
            this.STL = new System.Windows.Forms.ListBox();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.toScan = new System.Windows.Forms.DateTimePicker();
            this.fromScan = new System.Windows.Forms.DateTimePicker();
            this.createTemp = new System.Windows.Forms.CheckBox();
            this.chkRequireUser = new System.Windows.Forms.CheckBox();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.FileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.FileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.SaveSettingsButn = new System.Windows.Forms.Button();
            this.LoadSettingsButn = new System.Windows.Forms.Button();
            this.Label27 = new System.Windows.Forms.Label();
            this.HistoryList = new System.Windows.Forms.ListBox();
            this.ArrowLabel = new System.Windows.Forms.Label();
            this.TempLabelBox = new System.Windows.Forms.TextBox();
            this.CreateTempLbl = new System.Windows.Forms.Label();
            this.CheckForUpdates = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label47 = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.station = new System.Windows.Forms.TextBox();
            this.LabelRepeat = new System.Windows.Forms.NumericUpDown();
            this.lblXMLWarn = new System.Windows.Forms.Label();
            this.lblToggleAdmin = new System.Windows.Forms.Label();
            this.unitCM = new System.Windows.Forms.RadioButton();
            this.unitINCH = new System.Windows.Forms.RadioButton();
            this.decimalCOMMA = new System.Windows.Forms.RadioButton();
            this.decimalDOT = new System.Windows.Forms.RadioButton();
            this.zplAddBtn = new System.Windows.Forms.Button();
            this.zplPrintBtn = new System.Windows.Forms.Button();
            this.Label34 = new System.Windows.Forms.Label();
            this.PrintDocument2 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.parsedBy = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.CheckBox();
            this.Label86 = new System.Windows.Forms.Label();
            this.TextBox24 = new System.Windows.Forms.TextBox();
            this.printProgress = new System.Windows.Forms.Label();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Label112 = new System.Windows.Forms.Label();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.Panel18 = new System.Windows.Forms.Panel();
            this.Label116 = new System.Windows.Forms.Label();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.Label124 = new System.Windows.Forms.Label();
            this.Label123 = new System.Windows.Forms.Label();
            this.xboxPanel = new System.Windows.Forms.Panel();
            this.Label90 = new System.Windows.Forms.Label();
            this.Label89 = new System.Windows.Forms.Label();
            this.closeXbox = new System.Windows.Forms.Label();
            this.XBOX = new System.Windows.Forms.ListBox();
            this.holdingsBy = new System.Windows.Forms.Label();
            this.accessType = new System.Windows.Forms.Label();
            this.printPanel = new System.Windows.Forms.Panel();
            this.zplPrintPanel = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.zebraSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupTopOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSplitOffset)).BeginInit();
            this.panelMax.SuspendLayout();
            this.viaDOSPanel.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.orientationPanel.SuspendLayout();
            this.marginPanel.SuspendLayout();
            this.FTPGroup.SuspendLayout();
            this.DesktopGroup.SuspendLayout();
            this.SheetSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumber)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.PocketLabelPanel.SuspendLayout();
            this.userDefinedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLcount)).BeginInit();
            this.tweakParsingPanel.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.Panel14.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.TabPage10.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabPage11.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.formatInfoPanel.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.sortBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRepeat)).BeginInit();
            this.Panel18.SuspendLayout();
            this.Panel19.SuspendLayout();
            this.xboxPanel.SuspendLayout();
            this.printPanel.SuspendLayout();
            this.zplPrintPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(0, 188);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputBox.Size = new System.Drawing.Size(216, 192);
            this.OutputBox.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.OutputBox, "Output Box where the spine label can be displayed or edited.");
            // 
            // ManualPrint
            // 
            this.ManualPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualPrint.Location = new System.Drawing.Point(2, 3);
            this.ManualPrint.Margin = new System.Windows.Forms.Padding(0);
            this.ManualPrint.Name = "ManualPrint";
            this.ManualPrint.Size = new System.Drawing.Size(152, 24);
            this.ManualPrint.TabIndex = 1;
            this.ManualPrint.Text = "Send to Desktop printer";
            this.ToolTip1.SetToolTip(this.ManualPrint, "Print label on selected printer");
            this.ManualPrint.UseVisualStyleBackColor = true;
            this.ManualPrint.Click += new System.EventHandler(this.ManualPrint_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ReviewBox);
            this.Panel1.Controls.Add(this.AutoPrintBox);
            this.Panel1.Location = new System.Drawing.Point(16, 20);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(176, 24);
            this.Panel1.TabIndex = 2;
            // 
            // ReviewBox
            // 
            this.ReviewBox.AutoSize = true;
            this.ReviewBox.Checked = true;
            this.ReviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewBox.Location = new System.Drawing.Point(96, 4);
            this.ReviewBox.Name = "ReviewBox";
            this.ReviewBox.Size = new System.Drawing.Size(71, 19);
            this.ReviewBox.TabIndex = 1;
            this.ReviewBox.TabStop = true;
            this.ReviewBox.Tag = "radio_review";
            this.ReviewBox.Text = "Review";
            this.ToolTip1.SetToolTip(this.ReviewBox, "Review label, and print when you click the Send to printer button.");
            this.ReviewBox.UseVisualStyleBackColor = true;
            this.ReviewBox.CheckedChanged += new System.EventHandler(this.ReviewBox_CheckedChanged);
            // 
            // AutoPrintBox
            // 
            this.AutoPrintBox.AutoSize = true;
            this.AutoPrintBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoPrintBox.Location = new System.Drawing.Point(4, 4);
            this.AutoPrintBox.Name = "AutoPrintBox";
            this.AutoPrintBox.Size = new System.Drawing.Size(77, 19);
            this.AutoPrintBox.TabIndex = 0;
            this.AutoPrintBox.Tag = "radio_autoprint";
            this.AutoPrintBox.Text = "Auto Print";
            this.ToolTip1.SetToolTip(this.AutoPrintBox, "Send label label to selected printer without review.");
            this.AutoPrintBox.UseVisualStyleBackColor = true;
            this.AutoPrintBox.CheckedChanged += new System.EventHandler(this.AutoPrintBox_CheckedChanged);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Location = new System.Drawing.Point(220, 28);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(536, 356);
            this.TabControl1.TabIndex = 3;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPage1.Controls.Add(this.panelMax);
            this.TabPage1.Controls.Add(this.UseZPL);
            this.TabPage1.Controls.Add(this.viaDOSPanel);
            this.TabPage1.Controls.Add(this.useDOSBatch);
            this.TabPage1.Controls.Add(this.FTPwarning);
            this.TabPage1.Controls.Add(this.Label72);
            this.TabPage1.Controls.Add(this.showLabelType);
            this.TabPage1.Controls.Add(this.orientationPanel);
            this.TabPage1.Controls.Add(this.marginPanel);
            this.TabPage1.Controls.Add(this.Label35);
            this.TabPage1.Controls.Add(this.UseLaser);
            this.TabPage1.Controls.Add(this.UseFTP);
            this.TabPage1.Controls.Add(this.UseDesktop);
            this.TabPage1.Controls.Add(this.FTPGroup);
            this.TabPage1.Controls.Add(this.DesktopGroup);
            this.TabPage1.Controls.Add(this.zebraSettingsPanel);
            this.TabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(528, 330);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Print Setup";
            // 
            // zebraSettingsPanel
            // 
            this.zebraSettingsPanel.Controls.Add(this.zplBatchPreview);
            this.zebraSettingsPanel.Controls.Add(this.btnTestPrint);
            this.zebraSettingsPanel.Controls.Add(this.numupTopOffset);
            this.zebraSettingsPanel.Controls.Add(this.labelTopOffset);
            this.zebraSettingsPanel.Controls.Add(this.numudSplitOffset);
            this.zebraSettingsPanel.Controls.Add(this.labelSplitOffset);
            this.zebraSettingsPanel.Controls.Add(this.labelZebraPrinter);
            this.zebraSettingsPanel.Controls.Add(this.zebraPrinterBox);
            this.zebraSettingsPanel.Location = new System.Drawing.Point(-1, 48);
            this.zebraSettingsPanel.Name = "zebraSettingsPanel";
            this.zebraSettingsPanel.Size = new System.Drawing.Size(525, 278);
            this.zebraSettingsPanel.TabIndex = 61;
            // 
            // zplBatchPreview
            // 
            this.zplBatchPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.zplBatchPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zplBatchPreview.Location = new System.Drawing.Point(11, 13);
            this.zplBatchPreview.Multiline = true;
            this.zplBatchPreview.Name = "zplBatchPreview";
            this.zplBatchPreview.ReadOnly = true;
            this.zplBatchPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zplBatchPreview.Size = new System.Drawing.Size(164, 255);
            this.zplBatchPreview.TabIndex = 37;
            this.ToolTip1.SetToolTip(this.zplBatchPreview, "A list of all labels currently in the selected batch");
            this.zplBatchPreview.WordWrap = false;
            // 
            // btnTestPrint
            // 
            this.btnTestPrint.Location = new System.Drawing.Point(264, 143);
            this.btnTestPrint.Name = "btnTestPrint";
            this.btnTestPrint.Size = new System.Drawing.Size(75, 23);
            this.btnTestPrint.TabIndex = 6;
            this.btnTestPrint.Text = "Print Test";
            this.btnTestPrint.UseVisualStyleBackColor = true;
            this.btnTestPrint.Click += new System.EventHandler(this.TestPrintBtnClick);
            // 
            // numupTopOffset
            // 
            this.numupTopOffset.Location = new System.Drawing.Point(392, 78);
            this.numupTopOffset.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numupTopOffset.Name = "numupTopOffset";
            this.numupTopOffset.Size = new System.Drawing.Size(120, 20);
            this.numupTopOffset.TabIndex = 5;
            this.numupTopOffset.Tag = "numud_topoffset";
            // 
            // labelTopOffset
            // 
            this.labelTopOffset.AutoSize = true;
            this.labelTopOffset.Location = new System.Drawing.Point(391, 61);
            this.labelTopOffset.Name = "labelTopOffset";
            this.labelTopOffset.Size = new System.Drawing.Size(57, 13);
            this.labelTopOffset.TabIndex = 4;
            this.labelTopOffset.Text = "Top Offset";
            // 
            // numudSplitOffset
            // 
            this.numudSplitOffset.Location = new System.Drawing.Point(259, 77);
            this.numudSplitOffset.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numudSplitOffset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numudSplitOffset.Name = "numudSplitOffset";
            this.numudSplitOffset.Size = new System.Drawing.Size(120, 20);
            this.numudSplitOffset.TabIndex = 3;
            this.numudSplitOffset.Tag = "numud_splitoffset";
            this.numudSplitOffset.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSplitOffset
            // 
            this.labelSplitOffset.AutoSize = true;
            this.labelSplitOffset.Location = new System.Drawing.Point(255, 60);
            this.labelSplitOffset.Name = "labelSplitOffset";
            this.labelSplitOffset.Size = new System.Drawing.Size(58, 13);
            this.labelSplitOffset.TabIndex = 2;
            this.labelSplitOffset.Text = "Split Offset";
            // 
            // labelZebraPrinter
            // 
            this.labelZebraPrinter.AutoSize = true;
            this.labelZebraPrinter.Location = new System.Drawing.Point(260, 13);
            this.labelZebraPrinter.Name = "labelZebraPrinter";
            this.labelZebraPrinter.Size = new System.Drawing.Size(68, 13);
            this.labelZebraPrinter.TabIndex = 1;
            this.labelZebraPrinter.Text = "Zebra Printer";
            // 
            // zebraPrinterBox
            // 
            this.zebraPrinterBox.FormattingEnabled = true;
            this.zebraPrinterBox.Location = new System.Drawing.Point(260, 30);
            this.zebraPrinterBox.Name = "zebraPrinterBox";
            this.zebraPrinterBox.Size = new System.Drawing.Size(253, 21);
            this.zebraPrinterBox.TabIndex = 0;
            this.zebraPrinterBox.Tag = "cbox_zebraprinter";
            this.zebraPrinterBox.Text = "Please select printer";
            this.zebraPrinterBox.SelectedIndexChanged += new System.EventHandler(this.zebraPrinterBox_SelectedIndexChanged);
            // 
            // panelMax
            // 
            this.panelMax.Controls.Add(this.inMaxLines);
            this.panelMax.Controls.Add(this.inMaxChars);
            this.panelMax.Controls.Add(this.Label24);
            this.panelMax.Controls.Add(this.Label25);
            this.panelMax.Controls.Add(this.Label15);
            this.panelMax.Location = new System.Drawing.Point(410, 186);
            this.panelMax.Name = "panelMax";
            this.panelMax.Size = new System.Drawing.Size(103, 83);
            this.panelMax.TabIndex = 60;
            // 
            // inMaxLines
            // 
            this.inMaxLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inMaxLines.Location = new System.Drawing.Point(77, 35);
            this.inMaxLines.Name = "inMaxLines";
            this.inMaxLines.Size = new System.Drawing.Size(24, 13);
            this.inMaxLines.TabIndex = 33;
            this.inMaxLines.Tag = "text_ftpmaxlines";
            this.inMaxLines.Text = "7";
            this.inMaxLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inMaxLines, "Set max. number of vertical lines to print");
            // 
            // inMaxChars
            // 
            this.inMaxChars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inMaxChars.Location = new System.Drawing.Point(77, 55);
            this.inMaxChars.Name = "inMaxChars";
            this.inMaxChars.Size = new System.Drawing.Size(24, 13);
            this.inMaxChars.TabIndex = 31;
            this.inMaxChars.Tag = "text_ftpmaxcharsperline";
            this.inMaxChars.Text = "9";
            this.inMaxChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inMaxChars, "Set max. number of characters per line");
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(1, 15);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(59, 13);
            this.Label24.TabIndex = 32;
            this.Label24.Text = "Maximums:";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(1, 55);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(58, 13);
            this.Label25.TabIndex = 30;
            this.Label25.Text = "Chars/line:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(1, 35);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(62, 13);
            this.Label15.TabIndex = 29;
            this.Label15.Text = "Lines/label:";
            // 
            // UseZPL
            // 
            this.UseZPL.AutoSize = true;
            this.UseZPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseZPL.Location = new System.Drawing.Point(316, 18);
            this.UseZPL.Name = "UseZPL";
            this.UseZPL.Size = new System.Drawing.Size(82, 17);
            this.UseZPL.TabIndex = 59;
            this.UseZPL.Tag = "radio_useZPL";
            this.UseZPL.Text = "Zebra (ZPL)";
            this.ToolTip1.SetToolTip(this.UseZPL, "Print call numbers to Zebra printer using RAW printing ZPL.");
            this.UseZPL.UseVisualStyleBackColor = true;
            this.UseZPL.CheckedChanged += new System.EventHandler(this.UseZPL_CheckedChanged);
            // 
            // viaDOSPanel
            // 
            this.viaDOSPanel.Controls.Add(this.viadosCaution);
            this.viaDOSPanel.Controls.Add(this.Panel17);
            this.viaDOSPanel.Controls.Add(this.Label120);
            this.viaDOSPanel.Controls.Add(this.Label122);
            this.viaDOSPanel.Controls.Add(this.dosParam2);
            this.viaDOSPanel.Controls.Add(this.dosParam1);
            this.viaDOSPanel.Controls.Add(this.batsignal);
            this.viaDOSPanel.Controls.Add(this.loadViados);
            this.viaDOSPanel.Controls.Add(this.hideDosWindow);
            this.viaDOSPanel.Controls.Add(this.Label119);
            this.viaDOSPanel.Controls.Add(this.Label118);
            this.viaDOSPanel.Controls.Add(this.dosPlTabNum);
            this.viaDOSPanel.Controls.Add(this.dosPlColNum);
            this.viaDOSPanel.Controls.Add(this.dosPlUseTab);
            this.viaDOSPanel.Controls.Add(this.dosPlUseCol);
            this.viaDOSPanel.Controls.Add(this.Label117);
            this.viaDOSPanel.Controls.Add(this.Label114);
            this.viaDOSPanel.Controls.Add(this.batchDisplay);
            this.viaDOSPanel.Controls.Add(this.viadosSave);
            this.viaDOSPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viaDOSPanel.Location = new System.Drawing.Point(436, 264);
            this.viaDOSPanel.Name = "viaDOSPanel";
            this.viaDOSPanel.Size = new System.Drawing.Size(80, 44);
            this.viaDOSPanel.TabIndex = 58;
            this.viaDOSPanel.Visible = false;
            // 
            // viadosCaution
            // 
            this.viadosCaution.AutoSize = true;
            this.viadosCaution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viadosCaution.ForeColor = System.Drawing.Color.Red;
            this.viadosCaution.Location = new System.Drawing.Point(96, 292);
            this.viadosCaution.Name = "viadosCaution";
            this.viadosCaution.Size = new System.Drawing.Size(42, 13);
            this.viadosCaution.TabIndex = 64;
            this.viadosCaution.Text = "caution";
            this.viadosCaution.Visible = false;
            this.viadosCaution.Click += new System.EventHandler(this.Label126_Click);
            // 
            // Panel17
            // 
            this.Panel17.Controls.Add(this.appendAscii);
            this.Panel17.Controls.Add(this.dosUseFF);
            this.Panel17.Controls.Add(this.dosAddLines);
            this.Panel17.Controls.Add(this.dosBlankLines);
            this.Panel17.Controls.Add(this.Label115);
            this.Panel17.Location = new System.Drawing.Point(36, 28);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(316, 20);
            this.Panel17.TabIndex = 63;
            // 
            // appendAscii
            // 
            this.appendAscii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appendAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appendAscii.Location = new System.Drawing.Point(272, 2);
            this.appendAscii.Name = "appendAscii";
            this.appendAscii.Size = new System.Drawing.Size(16, 13);
            this.appendAscii.TabIndex = 8;
            this.appendAscii.Tag = "text_viadosAscii";
            this.appendAscii.Text = "12";
            this.appendAscii.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.appendAscii, "Append an ASCII code to the label text (12 = formfeed, etc.)");
            this.appendAscii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.appendAscii.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // dosUseFF
            // 
            this.dosUseFF.AutoSize = true;
            this.dosUseFF.Location = new System.Drawing.Point(180, 0);
            this.dosUseFF.Name = "dosUseFF";
            this.dosUseFF.Size = new System.Drawing.Size(91, 17);
            this.dosUseFF.TabIndex = 7;
            this.dosUseFF.Tag = "radio_useformfeed";
            this.dosUseFF.Text = "append ASCII";
            this.ToolTip1.SetToolTip(this.dosUseFF, "Append an ASCII value to the label text.");
            this.dosUseFF.UseVisualStyleBackColor = true;
            // 
            // dosAddLines
            // 
            this.dosAddLines.AutoSize = true;
            this.dosAddLines.Checked = true;
            this.dosAddLines.Location = new System.Drawing.Point(4, 0);
            this.dosAddLines.Name = "dosAddLines";
            this.dosAddLines.Size = new System.Drawing.Size(82, 17);
            this.dosAddLines.TabIndex = 6;
            this.dosAddLines.TabStop = true;
            this.dosAddLines.Tag = "radio_labellength";
            this.dosAddLines.Text = "Make labels";
            this.ToolTip1.SetToolTip(this.dosAddLines, "Add blank lines to make all labels the same length.");
            this.dosAddLines.UseVisualStyleBackColor = true;
            // 
            // dosBlankLines
            // 
            this.dosBlankLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosBlankLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosBlankLines.Location = new System.Drawing.Point(88, 2);
            this.dosBlankLines.Name = "dosBlankLines";
            this.dosBlankLines.Size = new System.Drawing.Size(16, 13);
            this.dosBlankLines.TabIndex = 5;
            this.dosBlankLines.Tag = "text_viadosnumlines";
            this.dosBlankLines.Text = "12";
            this.dosBlankLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.dosBlankLines, "Appends blank lines to make each label this length; Enter 0 for no blanks lines.");
            this.dosBlankLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.dosBlankLines.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label115
            // 
            this.Label115.AutoSize = true;
            this.Label115.Location = new System.Drawing.Point(108, 2);
            this.Label115.Name = "Label115";
            this.Label115.Size = new System.Drawing.Size(66, 13);
            this.Label115.TabIndex = 3;
            this.Label115.Text = "lines long, or";
            // 
            // Label120
            // 
            this.Label120.AutoSize = true;
            this.Label120.Location = new System.Drawing.Point(4, 80);
            this.Label120.Name = "Label120";
            this.Label120.Size = new System.Drawing.Size(134, 13);
            this.Label120.TabIndex = 62;
            this.Label120.Text = "Optional parameters:  %~1:";
            // 
            // Label122
            // 
            this.Label122.AutoSize = true;
            this.Label122.Location = new System.Drawing.Point(260, 80);
            this.Label122.Name = "Label122";
            this.Label122.Size = new System.Drawing.Size(31, 13);
            this.Label122.TabIndex = 61;
            this.Label122.Text = "%~2:";
            // 
            // dosParam2
            // 
            this.dosParam2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosParam2.Location = new System.Drawing.Point(292, 80);
            this.dosParam2.Name = "dosParam2";
            this.dosParam2.Size = new System.Drawing.Size(112, 13);
            this.dosParam2.TabIndex = 59;
            this.dosParam2.Tag = "text_dosparam2";
            this.ToolTip1.SetToolTip(this.dosParam2, "Send optional text string or <XML Field> value to the batch file.");
            this.dosParam2.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // dosParam1
            // 
            this.dosParam1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosParam1.Location = new System.Drawing.Point(140, 80);
            this.dosParam1.Name = "dosParam1";
            this.dosParam1.Size = new System.Drawing.Size(112, 13);
            this.dosParam1.TabIndex = 58;
            this.dosParam1.Tag = "text_dosparam1";
            this.ToolTip1.SetToolTip(this.dosParam1, "Send optional text string or <XLM field> value to the batch file.");
            this.dosParam1.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // batsignal
            // 
            this.batsignal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.batsignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.batsignal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.batsignal.Location = new System.Drawing.Point(308, 288);
            this.batsignal.Name = "batsignal";
            this.batsignal.Size = new System.Drawing.Size(20, 20);
            this.batsignal.TabIndex = 55;
            this.batsignal.Text = "u";
            // 
            // loadViados
            // 
            this.loadViados.Location = new System.Drawing.Point(220, 288);
            this.loadViados.Name = "loadViados";
            this.loadViados.Size = new System.Drawing.Size(68, 20);
            this.loadViados.TabIndex = 57;
            this.loadViados.Text = "Load file";
            this.ToolTip1.SetToolTip(this.loadViados, "Load the current \"viados.bat\" file from disk.");
            this.loadViados.UseVisualStyleBackColor = true;
            this.loadViados.Click += new System.EventHandler(this.loadViados_Click);
            // 
            // hideDosWindow
            // 
            this.hideDosWindow.AutoSize = true;
            this.hideDosWindow.Location = new System.Drawing.Point(8, 292);
            this.hideDosWindow.Name = "hideDosWindow";
            this.hideDosWindow.Size = new System.Drawing.Size(81, 17);
            this.hideDosWindow.TabIndex = 56;
            this.hideDosWindow.Tag = "check_runhidden";
            this.hideDosWindow.Text = "Run hidden";
            this.ToolTip1.SetToolTip(this.hideDosWindow, "Don\'t show command window when batch file executes.");
            this.hideDosWindow.UseVisualStyleBackColor = true;
            this.hideDosWindow.CheckedChanged += new System.EventHandler(this.hideDosWindow_CheckedChanged);
            // 
            // Label119
            // 
            this.Label119.AutoSize = true;
            this.Label119.Location = new System.Drawing.Point(220, 50);
            this.Label119.Name = "Label119";
            this.Label119.Size = new System.Drawing.Size(19, 13);
            this.Label119.TabIndex = 14;
            this.Label119.Text = "or ";
            // 
            // Label118
            // 
            this.Label118.AutoSize = true;
            this.Label118.Location = new System.Drawing.Point(308, 50);
            this.Label118.Name = "Label118";
            this.Label118.Size = new System.Drawing.Size(36, 13);
            this.Label118.TabIndex = 13;
            this.Label118.Text = "tab(s).";
            // 
            // dosPlTabNum
            // 
            this.dosPlTabNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosPlTabNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosPlTabNum.Location = new System.Drawing.Point(288, 50);
            this.dosPlTabNum.Name = "dosPlTabNum";
            this.dosPlTabNum.Size = new System.Drawing.Size(16, 13);
            this.dosPlTabNum.TabIndex = 12;
            this.dosPlTabNum.Tag = "text_plnumtabs";
            this.dosPlTabNum.Text = "1";
            this.dosPlTabNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.dosPlTabNum, "Separate spine from pocket label by this number of tabs.");
            this.dosPlTabNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.dosPlTabNum.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // dosPlColNum
            // 
            this.dosPlColNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dosPlColNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosPlColNum.Location = new System.Drawing.Point(200, 50);
            this.dosPlColNum.Name = "dosPlColNum";
            this.dosPlColNum.Size = new System.Drawing.Size(16, 13);
            this.dosPlColNum.TabIndex = 11;
            this.dosPlColNum.Tag = "text_plnumcols";
            this.dosPlColNum.Text = "10";
            this.dosPlColNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.dosPlColNum, "Separate spine from pocket label by this number of spaces.");
            this.dosPlColNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.dosPlColNum.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // dosPlUseTab
            // 
            this.dosPlUseTab.AutoSize = true;
            this.dosPlUseTab.Location = new System.Drawing.Point(240, 48);
            this.dosPlUseTab.Name = "dosPlUseTab";
            this.dosPlUseTab.Size = new System.Drawing.Size(46, 17);
            this.dosPlUseTab.TabIndex = 10;
            this.dosPlUseTab.Tag = "radio_dosplusetab";
            this.dosPlUseTab.Text = "after";
            this.ToolTip1.SetToolTip(this.dosPlUseTab, "For proportional fonts, use tab(s) between spine & pocket label.");
            this.dosPlUseTab.UseVisualStyleBackColor = true;
            // 
            // dosPlUseCol
            // 
            this.dosPlUseCol.AutoSize = true;
            this.dosPlUseCol.Checked = true;
            this.dosPlUseCol.Location = new System.Drawing.Point(128, 48);
            this.dosPlUseCol.Name = "dosPlUseCol";
            this.dosPlUseCol.Size = new System.Drawing.Size(73, 17);
            this.dosPlUseCol.TabIndex = 9;
            this.dosPlUseCol.TabStop = true;
            this.dosPlUseCol.Tag = "radio_useplcolspacing";
            this.dosPlUseCol.Text = " in column";
            this.ToolTip1.SetToolTip(this.dosPlUseCol, "For fixed pitch fonts, add spaces between spine & pocket label for proper alignme" +
        "nt.");
            this.dosPlUseCol.UseVisualStyleBackColor = true;
            // 
            // Label117
            // 
            this.Label117.AutoSize = true;
            this.Label117.Location = new System.Drawing.Point(36, 50);
            this.Label117.Name = "Label117";
            this.Label117.Size = new System.Drawing.Size(90, 13);
            this.Label117.TabIndex = 7;
            this.Label117.Text = "Start pocket label";
            // 
            // Label114
            // 
            this.Label114.AutoSize = true;
            this.Label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label114.Location = new System.Drawing.Point(64, 4);
            this.Label114.Name = "Label114";
            this.Label114.Size = new System.Drawing.Size(261, 15);
            this.Label114.TabIndex = 1;
            this.Label114.Text = "Send label text to batch file \"viados.bat\"";
            // 
            // batchDisplay
            // 
            this.batchDisplay.BackColor = System.Drawing.Color.Black;
            this.batchDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchDisplay.ForeColor = System.Drawing.Color.White;
            this.batchDisplay.Location = new System.Drawing.Point(8, 100);
            this.batchDisplay.Multiline = true;
            this.batchDisplay.Name = "batchDisplay";
            this.batchDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.batchDisplay.Size = new System.Drawing.Size(396, 184);
            this.batchDisplay.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.batchDisplay, "Create your own DOS Batch file to handle the \"label.txt\" file.");
            this.batchDisplay.TextChanged += new System.EventHandler(this.batchDisplay_TextChanged);
            // 
            // viadosSave
            // 
            this.viadosSave.Location = new System.Drawing.Point(328, 288);
            this.viadosSave.Name = "viadosSave";
            this.viadosSave.Size = new System.Drawing.Size(60, 20);
            this.viadosSave.TabIndex = 2;
            this.viadosSave.Text = "Save file";
            this.ToolTip1.SetToolTip(this.viadosSave, "Save text above to batch file to \"viados.bat\".");
            this.viadosSave.UseVisualStyleBackColor = true;
            this.viadosSave.Click += new System.EventHandler(this.viadosSave_Click);
            // 
            // useDOSBatch
            // 
            this.useDOSBatch.AutoSize = true;
            this.useDOSBatch.ForeColor = System.Drawing.Color.Gray;
            this.useDOSBatch.Location = new System.Drawing.Point(420, 304);
            this.useDOSBatch.Name = "useDOSBatch";
            this.useDOSBatch.Size = new System.Drawing.Size(95, 17);
            this.useDOSBatch.TabIndex = 57;
            this.useDOSBatch.Tag = "check_useviados";
            this.useDOSBatch.Text = "use viados.bat";
            this.ToolTip1.SetToolTip(this.useDOSBatch, "Use your own DOS batch file to print to a legacy printer.");
            this.useDOSBatch.UseVisualStyleBackColor = true;
            this.useDOSBatch.CheckStateChanged += new System.EventHandler(this.useDOSBatch_CheckStateChanged);
            // 
            // FTPwarning
            // 
            this.FTPwarning.AutoSize = true;
            this.FTPwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPwarning.ForeColor = System.Drawing.Color.Red;
            this.FTPwarning.Location = new System.Drawing.Point(200, 0);
            this.FTPwarning.Name = "FTPwarning";
            this.FTPwarning.Size = new System.Drawing.Size(266, 15);
            this.FTPwarning.TabIndex = 56;
            this.FTPwarning.Text = "==>FTP printing does not support pocket labels.";
            this.FTPwarning.Visible = false;
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label72.ForeColor = System.Drawing.Color.Red;
            this.Label72.Location = new System.Drawing.Point(64, 0);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(22, 15);
            this.Label72.TabIndex = 55;
            this.Label72.Tag = "";
            this.Label72.Text = "9";
            this.Label72.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ToolTip1.SetToolTip(this.Label72, "Click to open or close the setup panels");
            // 
            // showLabelType
            // 
            this.showLabelType.ForeColor = System.Drawing.Color.Blue;
            this.showLabelType.Location = new System.Drawing.Point(84, 0);
            this.showLabelType.Name = "showLabelType";
            this.showLabelType.Size = new System.Drawing.Size(116, 16);
            this.showLabelType.TabIndex = 34;
            this.showLabelType.Tag = "";
            this.ToolTip1.SetToolTip(this.showLabelType, "Shows the label format that will be used to print labels.");
            // 
            // orientationPanel
            // 
            this.orientationPanel.Controls.Add(this.usePortrait);
            this.orientationPanel.Controls.Add(this.useLandscape);
            this.orientationPanel.Location = new System.Drawing.Point(412, 136);
            this.orientationPanel.Name = "orientationPanel";
            this.orientationPanel.Size = new System.Drawing.Size(112, 44);
            this.orientationPanel.TabIndex = 33;
            // 
            // usePortrait
            // 
            this.usePortrait.AutoSize = true;
            this.usePortrait.Checked = true;
            this.usePortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePortrait.Location = new System.Drawing.Point(0, 4);
            this.usePortrait.Name = "usePortrait";
            this.usePortrait.Size = new System.Drawing.Size(58, 17);
            this.usePortrait.TabIndex = 6;
            this.usePortrait.TabStop = true;
            this.usePortrait.Tag = "radio_portrait";
            this.usePortrait.Text = "Portrait";
            this.ToolTip1.SetToolTip(this.usePortrait, "Print vertically on label");
            this.usePortrait.UseVisualStyleBackColor = true;
            // 
            // useLandscape
            // 
            this.useLandscape.AutoSize = true;
            this.useLandscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useLandscape.Location = new System.Drawing.Point(0, 24);
            this.useLandscape.Name = "useLandscape";
            this.useLandscape.Size = new System.Drawing.Size(78, 17);
            this.useLandscape.TabIndex = 7;
            this.useLandscape.Tag = "radio_landscape";
            this.useLandscape.Text = "Landscape";
            this.ToolTip1.SetToolTip(this.useLandscape, "Print horizontally on label");
            this.useLandscape.UseVisualStyleBackColor = true;
            // 
            // marginPanel
            // 
            this.marginPanel.Controls.Add(this.inUnits1);
            this.marginPanel.Controls.Add(this.Label4);
            this.marginPanel.Controls.Add(this.inTopMargin);
            this.marginPanel.Controls.Add(this.Label5);
            this.marginPanel.Controls.Add(this.inLeftMargin);
            this.marginPanel.Controls.Add(this.Label26);
            this.marginPanel.Controls.Add(this.inLineSpacing);
            this.marginPanel.Location = new System.Drawing.Point(412, 48);
            this.marginPanel.Name = "marginPanel";
            this.marginPanel.Size = new System.Drawing.Size(112, 84);
            this.marginPanel.TabIndex = 32;
            // 
            // inUnits1
            // 
            this.inUnits1.AutoSize = true;
            this.inUnits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inUnits1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inUnits1.Location = new System.Drawing.Point(92, 68);
            this.inUnits1.Name = "inUnits1";
            this.inUnits1.Size = new System.Drawing.Size(18, 13);
            this.inUnits1.TabIndex = 31;
            this.inUnits1.Text = "in.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(0, 4);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Top margin:";
            // 
            // inTopMargin
            // 
            this.inTopMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inTopMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTopMargin.Location = new System.Drawing.Point(72, 4);
            this.inTopMargin.Name = "inTopMargin";
            this.inTopMargin.Size = new System.Drawing.Size(36, 13);
            this.inTopMargin.TabIndex = 7;
            this.inTopMargin.Tag = "text_topmargin";
            this.inTopMargin.Text = "0.1";
            this.ToolTip1.SetToolTip(this.inTopMargin, "Set top margin");
            this.inTopMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NegativeKeyPress);
            this.inTopMargin.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(0, 28);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Left margin:";
            // 
            // inLeftMargin
            // 
            this.inLeftMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLeftMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLeftMargin.Location = new System.Drawing.Point(72, 28);
            this.inLeftMargin.Name = "inLeftMargin";
            this.inLeftMargin.Size = new System.Drawing.Size(36, 13);
            this.inLeftMargin.TabIndex = 9;
            this.inLeftMargin.Tag = "text_leftmargin";
            this.inLeftMargin.Text = "0.1";
            this.ToolTip1.SetToolTip(this.inLeftMargin, "Set left margin");
            this.inLeftMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NegativeKeyPress);
            this.inLeftMargin.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(0, 52);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(70, 13);
            this.Label26.TabIndex = 13;
            this.Label26.Text = "Line spacing:";
            // 
            // inLineSpacing
            // 
            this.inLineSpacing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLineSpacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLineSpacing.Location = new System.Drawing.Point(72, 52);
            this.inLineSpacing.Name = "inLineSpacing";
            this.inLineSpacing.Size = new System.Drawing.Size(36, 13);
            this.inLineSpacing.TabIndex = 14;
            this.inLineSpacing.Tag = "text_linespacing";
            this.inLineSpacing.Text = "0.2";
            this.ToolTip1.SetToolTip(this.inLineSpacing, "Set line spacing");
            this.inLineSpacing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inLineSpacing.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.Location = new System.Drawing.Point(4, 20);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(76, 13);
            this.Label35.TabIndex = 31;
            this.Label35.Text = "Printer type:";
            // 
            // UseLaser
            // 
            this.UseLaser.AutoSize = true;
            this.UseLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseLaser.Location = new System.Drawing.Point(232, 18);
            this.UseLaser.Name = "UseLaser";
            this.UseLaser.Size = new System.Drawing.Size(76, 17);
            this.UseLaser.TabIndex = 30;
            this.UseLaser.Tag = "radio_uselaser";
            this.UseLaser.Text = "Batch print";
            this.ToolTip1.SetToolTip(this.UseLaser, "Print batches of call numbers on multi-label laser print sheets");
            this.UseLaser.UseVisualStyleBackColor = true;
            this.UseLaser.CheckedChanged += new System.EventHandler(this.UseLaser_CheckedChanged);
            // 
            // UseFTP
            // 
            this.UseFTP.AutoSize = true;
            this.UseFTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseFTP.Location = new System.Drawing.Point(413, 18);
            this.UseFTP.Name = "UseFTP";
            this.UseFTP.Size = new System.Drawing.Size(107, 17);
            this.UseFTP.TabIndex = 14;
            this.UseFTP.Tag = "radio_useftp";
            this.UseFTP.Text = "FTP Label Printer";
            this.ToolTip1.SetToolTip(this.UseFTP, "Print to CAB or other printers via FTP");
            this.UseFTP.UseVisualStyleBackColor = true;
            this.UseFTP.CheckedChanged += new System.EventHandler(this.UseFTP_CheckedChanged);
            // 
            // UseDesktop
            // 
            this.UseDesktop.AutoSize = true;
            this.UseDesktop.Checked = true;
            this.UseDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDesktop.Location = new System.Drawing.Point(86, 18);
            this.UseDesktop.Name = "UseDesktop";
            this.UseDesktop.Size = new System.Drawing.Size(140, 17);
            this.UseDesktop.TabIndex = 13;
            this.UseDesktop.TabStop = true;
            this.UseDesktop.Tag = "radio_usedesktop";
            this.UseDesktop.Text = "Single label desktop";
            this.ToolTip1.SetToolTip(this.UseDesktop, "Print to dedicated desktop label printer (Zebra, Dymo, etc.)");
            this.UseDesktop.UseVisualStyleBackColor = true;
            this.UseDesktop.CheckedChanged += new System.EventHandler(this.UseDesktop_CheckedChanged);
            // 
            // FTPGroup
            // 
            this.FTPGroup.Controls.Add(this.ftpRegisterMsg);
            this.FTPGroup.Controls.Add(this.btn_ftpRegister);
            this.FTPGroup.Controls.Add(this.ftpArrow);
            this.FTPGroup.Controls.Add(this.FTPInfo);
            this.FTPGroup.Controls.Add(this.Label50);
            this.FTPGroup.Controls.Add(this.FTPHelp);
            this.FTPGroup.Controls.Add(this.Label49);
            this.FTPGroup.Controls.Add(this.FTPPassword);
            this.FTPGroup.Controls.Add(this.Label48);
            this.FTPGroup.Controls.Add(this.FTPLogin);
            this.FTPGroup.Controls.Add(this.Label46);
            this.FTPGroup.Controls.Add(this.FTPip);
            this.FTPGroup.Controls.Add(this.Label30);
            this.FTPGroup.Controls.Add(this.Label16);
            this.FTPGroup.Controls.Add(this.TextBox23);
            this.FTPGroup.Controls.Add(this.TextBox22);
            this.FTPGroup.Controls.Add(this.TextBox21);
            this.FTPGroup.Controls.Add(this.TextBox20);
            this.FTPGroup.Controls.Add(this.TextBox19);
            this.FTPGroup.Controls.Add(this.Label22);
            this.FTPGroup.Controls.Add(this.Label21);
            this.FTPGroup.Controls.Add(this.Label20);
            this.FTPGroup.Controls.Add(this.Label19);
            this.FTPGroup.Controls.Add(this.Label18);
            this.FTPGroup.Controls.Add(this.Label17);
            this.FTPGroup.Controls.Add(this.TextBox17);
            this.FTPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPGroup.Location = new System.Drawing.Point(4, 260);
            this.FTPGroup.Name = "FTPGroup";
            this.FTPGroup.Size = new System.Drawing.Size(24, 52);
            this.FTPGroup.TabIndex = 12;
            this.FTPGroup.TabStop = false;
            // 
            // ftpRegisterMsg
            // 
            this.ftpRegisterMsg.ForeColor = System.Drawing.Color.Red;
            this.ftpRegisterMsg.Location = new System.Drawing.Point(108, 280);
            this.ftpRegisterMsg.Name = "ftpRegisterMsg";
            this.ftpRegisterMsg.Size = new System.Drawing.Size(172, 16);
            this.ftpRegisterMsg.TabIndex = 41;
            this.ftpRegisterMsg.Text = "changes to Logon ID or Password.";
            this.ToolTip1.SetToolTip(this.ftpRegisterMsg, "Clicking \'Register\' rewrites the sendlabel.txt file with the new Login ID and/or " +
        "Password.");
            this.ftpRegisterMsg.Visible = false;
            // 
            // btn_ftpRegister
            // 
            this.btn_ftpRegister.Location = new System.Drawing.Point(52, 272);
            this.btn_ftpRegister.Name = "btn_ftpRegister";
            this.btn_ftpRegister.Size = new System.Drawing.Size(56, 24);
            this.btn_ftpRegister.TabIndex = 40;
            this.btn_ftpRegister.Text = "Register";
            this.ToolTip1.SetToolTip(this.btn_ftpRegister, "Clicking \'Register\' rewrites the sendlabel.txt file with the new Login ID and/or " +
        "Password.");
            this.btn_ftpRegister.UseVisualStyleBackColor = true;
            this.btn_ftpRegister.Visible = false;
            this.btn_ftpRegister.Click += new System.EventHandler(this.btn_ftpRegister_Click);
            // 
            // ftpArrow
            // 
            this.ftpArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ftpArrow.ForeColor = System.Drawing.Color.Red;
            this.ftpArrow.Location = new System.Drawing.Point(12, 268);
            this.ftpArrow.Name = "ftpArrow";
            this.ftpArrow.Size = new System.Drawing.Size(40, 28);
            this.ftpArrow.TabIndex = 39;
            this.ftpArrow.Text = "9";
            this.ftpArrow.Visible = false;
            // 
            // FTPInfo
            // 
            this.FTPInfo.AutoSize = true;
            this.FTPInfo.ForeColor = System.Drawing.Color.Blue;
            this.FTPInfo.Location = new System.Drawing.Point(368, 16);
            this.FTPInfo.Name = "FTPInfo";
            this.FTPInfo.Size = new System.Drawing.Size(25, 13);
            this.FTPInfo.TabIndex = 38;
            this.FTPInfo.Text = "Info";
            this.FTPInfo.Click += new System.EventHandler(this.FTPInfo_Click);
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Location = new System.Drawing.Point(12, 16);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(220, 13);
            this.Label50.TabIndex = 37;
            this.Label50.Text = "For FTP-attached CAB industrial label printers";
            // 
            // FTPHelp
            // 
            this.FTPHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPHelp.Location = new System.Drawing.Point(16, 36);
            this.FTPHelp.Name = "FTPHelp";
            this.FTPHelp.Size = new System.Drawing.Size(380, 88);
            this.FTPHelp.TabIndex = 35;
            this.FTPHelp.Text = resources.GetString("FTPHelp.Text");
            this.FTPHelp.Visible = false;
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.Location = new System.Drawing.Point(28, 128);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(56, 13);
            this.Label49.TabIndex = 34;
            this.Label49.Text = "FTP Login";
            // 
            // FTPPassword
            // 
            this.FTPPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FTPPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPPassword.Location = new System.Drawing.Point(20, 248);
            this.FTPPassword.Name = "FTPPassword";
            this.FTPPassword.PasswordChar = '*';
            this.FTPPassword.Size = new System.Drawing.Size(88, 20);
            this.FTPPassword.TabIndex = 33;
            this.FTPPassword.Tag = "texo_ftppassword";
            this.FTPPassword.TextChanged += new System.EventHandler(this.FTPPassword_TextChanged);
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.Location = new System.Drawing.Point(8, 232);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(56, 13);
            this.Label48.TabIndex = 32;
            this.Label48.Text = "Password:";
            // 
            // FTPLogin
            // 
            this.FTPLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FTPLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPLogin.Location = new System.Drawing.Point(20, 208);
            this.FTPLogin.Name = "FTPLogin";
            this.FTPLogin.Size = new System.Drawing.Size(88, 20);
            this.FTPLogin.TabIndex = 31;
            this.FTPLogin.Tag = "text_ftplogin";
            this.FTPLogin.TextChanged += new System.EventHandler(this.FTPLogin_TextChanged);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(8, 192);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(50, 13);
            this.Label46.TabIndex = 30;
            this.Label46.Text = "Login ID:";
            // 
            // FTPip
            // 
            this.FTPip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPip.Location = new System.Drawing.Point(20, 168);
            this.FTPip.Name = "FTPip";
            this.FTPip.Size = new System.Drawing.Size(88, 20);
            this.FTPip.TabIndex = 29;
            this.FTPip.Tag = "text_ftpipaddress";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.Location = new System.Drawing.Point(8, 148);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(61, 13);
            this.Label30.TabIndex = 28;
            this.Label30.Text = "IP Address:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(256, 128);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(123, 13);
            this.Label16.TabIndex = 16;
            this.Label16.Text = "Label Format Commands";
            // 
            // TextBox23
            // 
            this.TextBox23.Location = new System.Drawing.Point(196, 252);
            this.TextBox23.Name = "TextBox23";
            this.TextBox23.Size = new System.Drawing.Size(32, 20);
            this.TextBox23.TabIndex = 15;
            this.TextBox23.Tag = "text_ftpfontsize";
            this.TextBox23.Text = "12";
            this.TextBox23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.TextBox23.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // TextBox22
            // 
            this.TextBox22.Location = new System.Drawing.Point(196, 228);
            this.TextBox22.Name = "TextBox22";
            this.TextBox22.Size = new System.Drawing.Size(32, 20);
            this.TextBox22.TabIndex = 14;
            this.TextBox22.Tag = "text_ftpfontnum";
            this.TextBox22.Text = "8";
            this.TextBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.TextBox22.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // TextBox21
            // 
            this.TextBox21.Location = new System.Drawing.Point(196, 204);
            this.TextBox21.Name = "TextBox21";
            this.TextBox21.Size = new System.Drawing.Size(32, 20);
            this.TextBox21.TabIndex = 13;
            this.TextBox21.Tag = "text_ftplinespacing";
            this.TextBox21.Text = "5";
            this.TextBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.TextBox21.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // TextBox20
            // 
            this.TextBox20.Location = new System.Drawing.Point(196, 180);
            this.TextBox20.Name = "TextBox20";
            this.TextBox20.Size = new System.Drawing.Size(32, 20);
            this.TextBox20.TabIndex = 12;
            this.TextBox20.Tag = "text_ftptop";
            this.TextBox20.Text = "4";
            this.TextBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.TextBox20.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // TextBox19
            // 
            this.TextBox19.Location = new System.Drawing.Point(196, 156);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.Size = new System.Drawing.Size(32, 20);
            this.TextBox19.TabIndex = 11;
            this.TextBox19.Tag = "text_ftplmargin";
            this.TextBox19.Text = "2";
            this.TextBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.TextBox19.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(140, 256);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(54, 13);
            this.Label22.TabIndex = 9;
            this.Label22.Text = "Font Size:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(152, 232);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(38, 13);
            this.Label21.TabIndex = 8;
            this.Label21.Text = "Font#:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(124, 208);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(70, 13);
            this.Label20.TabIndex = 7;
            this.Label20.Text = "Line spacing:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(164, 184);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(26, 13);
            this.Label19.TabIndex = 6;
            this.Label19.Text = "Top";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(144, 160);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(48, 13);
            this.Label18.TabIndex = 5;
            this.Label18.Text = "L Margin";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(148, 128);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(82, 13);
            this.Label17.TabIndex = 3;
            this.Label17.Text = "#LABELTEXT#";
            // 
            // TextBox17
            // 
            this.TextBox17.BackColor = System.Drawing.Color.White;
            this.TextBox17.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox17.Location = new System.Drawing.Point(240, 140);
            this.TextBox17.Multiline = true;
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.Size = new System.Drawing.Size(152, 132);
            this.TextBox17.TabIndex = 0;
            this.TextBox17.Tag = "text_ftpcommands";
            this.TextBox17.Text = "M l fnt;gothic.ttf\r\nm m\r\nJ\r\nH 100\r\nS l1;12,0,37,41,25\r\nO R\r\nF 8;gothic\r\n#LABELTEX" +
    "T#\r\nA #COUNT#";
            // 
            // DesktopGroup
            // 
            this.DesktopGroup.Controls.Add(this.Label12);
            this.DesktopGroup.Controls.Add(this.btnBCFontDialog);
            this.DesktopGroup.Controls.Add(this.inBCFontWeight);
            this.DesktopGroup.Controls.Add(this.Label29);
            this.DesktopGroup.Controls.Add(this.inBCFontSize);
            this.DesktopGroup.Controls.Add(this.inBCFontName);
            this.DesktopGroup.Controls.Add(this.SheetSettings);
            this.DesktopGroup.Controls.Add(this.inFontWeight);
            this.DesktopGroup.Controls.Add(this.Label23);
            this.DesktopGroup.Controls.Add(this.inFontSize);
            this.DesktopGroup.Controls.Add(this.FontDialogButn);
            this.DesktopGroup.Controls.Add(this.inFontName);
            this.DesktopGroup.Controls.Add(this.Label3);
            this.DesktopGroup.Controls.Add(this.PrinterDialogButn);
            this.DesktopGroup.Controls.Add(this.inPrinterName);
            this.DesktopGroup.Controls.Add(this.Label2);
            this.DesktopGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopGroup.Location = new System.Drawing.Point(32, 40);
            this.DesktopGroup.Name = "DesktopGroup";
            this.DesktopGroup.Size = new System.Drawing.Size(376, 284);
            this.DesktopGroup.TabIndex = 11;
            this.DesktopGroup.TabStop = false;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(4, 60);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(71, 13);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "Barcode font:";
            // 
            // btnBCFontDialog
            // 
            this.btnBCFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBCFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCFontDialog.Location = new System.Drawing.Point(344, 56);
            this.btnBCFontDialog.Name = "btnBCFontDialog";
            this.btnBCFontDialog.Size = new System.Drawing.Size(28, 20);
            this.btnBCFontDialog.TabIndex = 46;
            this.btnBCFontDialog.Text = "...";
            this.ToolTip1.SetToolTip(this.btnBCFontDialog, "Select a barcode font from a list of your installed fonts");
            this.btnBCFontDialog.UseVisualStyleBackColor = false;
            this.btnBCFontDialog.Click += new System.EventHandler(this.btnBCFontDialog_Click);
            // 
            // inBCFontWeight
            // 
            this.inBCFontWeight.AutoSize = true;
            this.inBCFontWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBCFontWeight.Location = new System.Drawing.Point(292, 60);
            this.inBCFontWeight.Name = "inBCFontWeight";
            this.inBCFontWeight.Size = new System.Drawing.Size(46, 17);
            this.inBCFontWeight.TabIndex = 45;
            this.inBCFontWeight.Tag = "check_BCfontweight";
            this.inBCFontWeight.Text = "bold";
            this.inBCFontWeight.UseVisualStyleBackColor = true;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(220, 60);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 13);
            this.Label29.TabIndex = 44;
            this.Label29.Text = "Size:";
            // 
            // inBCFontSize
            // 
            this.inBCFontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inBCFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBCFontSize.Location = new System.Drawing.Point(256, 60);
            this.inBCFontSize.Name = "inBCFontSize";
            this.inBCFontSize.Size = new System.Drawing.Size(32, 13);
            this.inBCFontSize.TabIndex = 43;
            this.inBCFontSize.Tag = "text_BCfontsize";
            this.inBCFontSize.Text = "13";
            this.inBCFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inBCFontSize.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inBCFontName
            // 
            this.inBCFontName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inBCFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBCFontName.Location = new System.Drawing.Point(76, 60);
            this.inBCFontName.Name = "inBCFontName";
            this.inBCFontName.Size = new System.Drawing.Size(140, 13);
            this.inBCFontName.TabIndex = 42;
            this.inBCFontName.Tag = "text_BCfontname";
            this.inBCFontName.Text = "Please select barcode font";
            // 
            // SheetSettings
            // 
            this.SheetSettings.Controls.Add(this.Label121);
            this.SheetSettings.Controls.Add(this.inUnits2);
            this.SheetSettings.Controls.Add(this.Label11);
            this.SheetSettings.Controls.Add(this.inStartCol);
            this.SheetSettings.Controls.Add(this.inStartRow);
            this.SheetSettings.Controls.Add(this.Label31);
            this.SheetSettings.Controls.Add(this.Label32);
            this.SheetSettings.Controls.Add(this.batchEntries);
            this.SheetSettings.Controls.Add(this.Label43);
            this.SheetSettings.Controls.Add(this.batchNumber);
            this.SheetSettings.Controls.Add(this.batchPreview);
            this.SheetSettings.Controls.Add(this.Button2);
            this.SheetSettings.Controls.Add(this.btnPrintBatch);
            this.SheetSettings.Controls.Add(this.Label42);
            this.SheetSettings.Controls.Add(this.inGapHeight);
            this.SheetSettings.Controls.Add(this.inGapWidth);
            this.SheetSettings.Controls.Add(this.inLabelHeight);
            this.SheetSettings.Controls.Add(this.inLabelWidth);
            this.SheetSettings.Controls.Add(this.inLabelCols);
            this.SheetSettings.Controls.Add(this.inLabelRows);
            this.SheetSettings.Controls.Add(this.Label41);
            this.SheetSettings.Controls.Add(this.Label40);
            this.SheetSettings.Controls.Add(this.Label39);
            this.SheetSettings.Controls.Add(this.Label38);
            this.SheetSettings.Controls.Add(this.Label37);
            this.SheetSettings.Controls.Add(this.Label36);
            this.SheetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetSettings.Location = new System.Drawing.Point(4, 88);
            this.SheetSettings.Name = "SheetSettings";
            this.SheetSettings.Size = new System.Drawing.Size(368, 192);
            this.SheetSettings.TabIndex = 15;
            this.SheetSettings.Visible = false;
            // 
            // Label121
            // 
            this.Label121.AutoSize = true;
            this.Label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label121.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label121.Location = new System.Drawing.Point(212, 12);
            this.Label121.Name = "Label121";
            this.Label121.Size = new System.Drawing.Size(18, 13);
            this.Label121.TabIndex = 36;
            this.Label121.Text = "in.";
            // 
            // inUnits2
            // 
            this.inUnits2.AutoSize = true;
            this.inUnits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inUnits2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inUnits2.Location = new System.Drawing.Point(344, 12);
            this.inUnits2.Name = "inUnits2";
            this.inUnits2.Size = new System.Drawing.Size(18, 13);
            this.inUnits2.TabIndex = 35;
            this.inUnits2.Text = "in.";
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(4, 60);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(100, 16);
            this.Label11.TabIndex = 34;
            this.Label11.Text = "First label prints at:";
            this.ToolTip1.SetToolTip(this.Label11, "For partially used label sheets, specify the first unused label.");
            // 
            // inStartCol
            // 
            this.inStartCol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inStartCol.Location = new System.Drawing.Point(176, 60);
            this.inStartCol.Name = "inStartCol";
            this.inStartCol.Size = new System.Drawing.Size(20, 13);
            this.inStartCol.TabIndex = 33;
            this.inStartCol.Tag = "";
            this.inStartCol.Text = "1";
            this.inStartCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inStartCol, "Column containing first unused label.");
            this.inStartCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inStartCol.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inStartRow
            // 
            this.inStartRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inStartRow.Location = new System.Drawing.Point(128, 60);
            this.inStartRow.Name = "inStartRow";
            this.inStartRow.Size = new System.Drawing.Size(20, 13);
            this.inStartRow.TabIndex = 32;
            this.inStartRow.Tag = "";
            this.inStartRow.Text = "1";
            this.inStartRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inStartRow, "Row containing first unused label.");
            this.inStartRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inStartRow.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.Location = new System.Drawing.Point(100, 60);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(29, 13);
            this.Label31.TabIndex = 30;
            this.Label31.Text = "Row";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.Location = new System.Drawing.Point(148, 60);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(28, 13);
            this.Label32.TabIndex = 31;
            this.Label32.Text = ", Col";
            // 
            // batchEntries
            // 
            this.batchEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchEntries.Location = new System.Drawing.Point(160, 128);
            this.batchEntries.Name = "batchEntries";
            this.batchEntries.Size = new System.Drawing.Size(42, 12);
            this.batchEntries.TabIndex = 28;
            this.batchEntries.Text = "0";
            this.batchEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip1.SetToolTip(this.batchEntries, "The number of entries in the displayed batch");
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location = new System.Drawing.Point(108, 128);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(50, 13);
            this.Label43.TabIndex = 27;
            this.Label43.Text = "Entries:";
            // 
            // batchNumber
            // 
            this.batchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchNumber.Location = new System.Drawing.Point(168, 100);
            this.batchNumber.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.batchNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchNumber.Name = "batchNumber";
            this.batchNumber.ReadOnly = true;
            this.batchNumber.Size = new System.Drawing.Size(32, 22);
            this.batchNumber.TabIndex = 26;
            this.batchNumber.Tag = "numud_batchnum";
            this.ToolTip1.SetToolTip(this.batchNumber, "The batch number (from 1 to 3) that will be stored or printed");
            this.batchNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchNumber.ValueChanged += new System.EventHandler(this.batchNumber_ValueChanged);
            // 
            // batchPreview
            // 
            this.batchPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.batchPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchPreview.Location = new System.Drawing.Point(204, 60);
            this.batchPreview.Multiline = true;
            this.batchPreview.Name = "batchPreview";
            this.batchPreview.ReadOnly = true;
            this.batchPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.batchPreview.Size = new System.Drawing.Size(164, 132);
            this.batchPreview.TabIndex = 25;
            this.ToolTip1.SetToolTip(this.batchPreview, "A list of all labels currently in the selected batch");
            this.batchPreview.WordWrap = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.LightPink;
            this.Button2.Location = new System.Drawing.Point(156, 168);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(44, 20);
            this.Button2.TabIndex = 23;
            this.Button2.Text = " erase";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip1.SetToolTip(this.Button2, "Delete all labels from the selected batch");
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnPrintBatch
            // 
            this.btnPrintBatch.Location = new System.Drawing.Point(4, 108);
            this.btnPrintBatch.Name = "btnPrintBatch";
            this.btnPrintBatch.Size = new System.Drawing.Size(92, 24);
            this.btnPrintBatch.TabIndex = 21;
            this.btnPrintBatch.Text = "Preview/print";
            this.ToolTip1.SetToolTip(this.btnPrintBatch, "Preview the selected batch and optionally print to the selected printer");
            this.btnPrintBatch.UseVisualStyleBackColor = true;
            this.btnPrintBatch.Click += new System.EventHandler(this.btnPrintBatch_Click);
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.Location = new System.Drawing.Point(108, 105);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(60, 13);
            this.Label42.TabIndex = 19;
            this.Label42.Text = "Batch #: ";
            // 
            // inGapHeight
            // 
            this.inGapHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inGapHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGapHeight.Location = new System.Drawing.Point(304, 4);
            this.inGapHeight.Name = "inGapHeight";
            this.inGapHeight.Size = new System.Drawing.Size(40, 13);
            this.inGapHeight.TabIndex = 18;
            this.inGapHeight.Tag = "text_lblgapheight";
            this.inGapHeight.Text = "0.0";
            this.ToolTip1.SetToolTip(this.inGapHeight, "The height of the vertical gap (if any) between labels");
            this.inGapHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inGapHeight.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inGapWidth
            // 
            this.inGapWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inGapWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGapWidth.Location = new System.Drawing.Point(304, 24);
            this.inGapWidth.Name = "inGapWidth";
            this.inGapWidth.Size = new System.Drawing.Size(40, 13);
            this.inGapWidth.TabIndex = 17;
            this.inGapWidth.Tag = "text_lblgapwidth";
            this.inGapWidth.Text = "0.0";
            this.ToolTip1.SetToolTip(this.inGapWidth, "The width of the horizontal gap (if any) between labels");
            this.inGapWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inGapWidth.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inLabelHeight
            // 
            this.inLabelHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLabelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabelHeight.Location = new System.Drawing.Point(172, 4);
            this.inLabelHeight.Name = "inLabelHeight";
            this.inLabelHeight.Size = new System.Drawing.Size(40, 13);
            this.inLabelHeight.TabIndex = 16;
            this.inLabelHeight.Tag = "text_lblheight";
            this.inLabelHeight.Text = "1.5";
            this.ToolTip1.SetToolTip(this.inLabelHeight, "The height of each label on the sheet");
            this.inLabelHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inLabelHeight.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inLabelWidth
            // 
            this.inLabelWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLabelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabelWidth.Location = new System.Drawing.Point(172, 24);
            this.inLabelWidth.Name = "inLabelWidth";
            this.inLabelWidth.Size = new System.Drawing.Size(40, 13);
            this.inLabelWidth.TabIndex = 15;
            this.inLabelWidth.Tag = "text_lblwidth";
            this.inLabelWidth.Text = "1.0";
            this.ToolTip1.SetToolTip(this.inLabelWidth, "The width of each label on the sheet");
            this.inLabelWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inLabelWidth.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inLabelCols
            // 
            this.inLabelCols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLabelCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabelCols.Location = new System.Drawing.Point(72, 24);
            this.inLabelCols.Name = "inLabelCols";
            this.inLabelCols.Size = new System.Drawing.Size(28, 13);
            this.inLabelCols.TabIndex = 14;
            this.inLabelCols.Tag = "text_lblcols";
            this.inLabelCols.Text = "8";
            this.inLabelCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inLabelCols, "Number of vertical columns of labels");
            this.inLabelCols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inLabelCols.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // inLabelRows
            // 
            this.inLabelRows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inLabelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLabelRows.Location = new System.Drawing.Point(72, 4);
            this.inLabelRows.Name = "inLabelRows";
            this.inLabelRows.Size = new System.Drawing.Size(28, 13);
            this.inLabelRows.TabIndex = 13;
            this.inLabelRows.Tag = "text_lblrows";
            this.inLabelRows.Text = "5";
            this.inLabelRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.inLabelRows, "Number of horizontal rows of labels");
            this.inLabelRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inLabelRows.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(236, 4);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(62, 13);
            this.Label41.TabIndex = 12;
            this.Label41.Text = "Gap height:";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.Location = new System.Drawing.Point(104, 4);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(68, 13);
            this.Label40.TabIndex = 11;
            this.Label40.Text = "Label height:";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.Location = new System.Drawing.Point(32, 4);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(37, 13);
            this.Label39.TabIndex = 10;
            this.Label39.Text = "Rows:";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.Location = new System.Drawing.Point(240, 24);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(58, 13);
            this.Label38.TabIndex = 9;
            this.Label38.Text = "Gap width:";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.Location = new System.Drawing.Point(108, 24);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(64, 13);
            this.Label37.TabIndex = 8;
            this.Label37.Text = "Label width:";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.Location = new System.Drawing.Point(20, 24);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(50, 13);
            this.Label36.TabIndex = 7;
            this.Label36.Text = "Columns:";
            // 
            // inFontWeight
            // 
            this.inFontWeight.AutoSize = true;
            this.inFontWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFontWeight.Location = new System.Drawing.Point(292, 40);
            this.inFontWeight.Name = "inFontWeight";
            this.inFontWeight.Size = new System.Drawing.Size(46, 17);
            this.inFontWeight.TabIndex = 12;
            this.inFontWeight.Tag = "check_fontweight";
            this.inFontWeight.Text = "bold";
            this.inFontWeight.UseVisualStyleBackColor = true;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(220, 40);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(30, 13);
            this.Label23.TabIndex = 11;
            this.Label23.Text = "Size:";
            // 
            // inFontSize
            // 
            this.inFontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFontSize.Location = new System.Drawing.Point(256, 40);
            this.inFontSize.Name = "inFontSize";
            this.inFontSize.Size = new System.Drawing.Size(32, 13);
            this.inFontSize.TabIndex = 10;
            this.inFontSize.Tag = "text_fontsize";
            this.inFontSize.Text = "10";
            this.inFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.inFontSize.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // FontDialogButn
            // 
            this.FontDialogButn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FontDialogButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontDialogButn.Location = new System.Drawing.Point(344, 36);
            this.FontDialogButn.Name = "FontDialogButn";
            this.FontDialogButn.Size = new System.Drawing.Size(28, 20);
            this.FontDialogButn.TabIndex = 5;
            this.FontDialogButn.Text = "...";
            this.FontDialogButn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip1.SetToolTip(this.FontDialogButn, "Select a text font from a list of your installed fonts");
            this.FontDialogButn.UseVisualStyleBackColor = false;
            this.FontDialogButn.Click += new System.EventHandler(this.FontDialogButn_Click);
            // 
            // inFontName
            // 
            this.inFontName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFontName.Location = new System.Drawing.Point(76, 40);
            this.inFontName.Name = "inFontName";
            this.inFontName.Size = new System.Drawing.Size(140, 13);
            this.inFontName.TabIndex = 4;
            this.inFontName.Tag = "text_fontname";
            this.inFontName.Text = "Microsoft Sans Serif";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(24, 40);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Text font:";
            // 
            // PrinterDialogButn
            // 
            this.PrinterDialogButn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrinterDialogButn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterDialogButn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrinterDialogButn.Location = new System.Drawing.Point(344, 16);
            this.PrinterDialogButn.Margin = new System.Windows.Forms.Padding(0);
            this.PrinterDialogButn.Name = "PrinterDialogButn";
            this.PrinterDialogButn.Size = new System.Drawing.Size(28, 20);
            this.PrinterDialogButn.TabIndex = 2;
            this.PrinterDialogButn.Text = "...";
            this.PrinterDialogButn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrinterDialogButn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ToolTip1.SetToolTip(this.PrinterDialogButn, "Select a printer from a list of your available printers");
            this.PrinterDialogButn.UseVisualStyleBackColor = false;
            this.PrinterDialogButn.Click += new System.EventHandler(this.PrinterDialogButn_Click);
            // 
            // inPrinterName
            // 
            this.inPrinterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inPrinterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPrinterName.Location = new System.Drawing.Point(76, 20);
            this.inPrinterName.Name = "inPrinterName";
            this.inPrinterName.Size = new System.Drawing.Size(260, 13);
            this.inPrinterName.TabIndex = 1;
            this.inPrinterName.Tag = "text_printername";
            this.inPrinterName.Text = "Please select printer";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(36, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Printer:";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage2.Controls.Add(this.PocketLabelPanel);
            this.TabPage2.Controls.Add(this.tweakParsingPanel);
            this.TabPage2.Controls.Add(this.showFormatInfo);
            this.TabPage2.Controls.Add(this.FTPwarning2);
            this.TabPage2.Controls.Add(this.Label91);
            this.TabPage2.Controls.Add(this.chkUsePocketLabels);
            this.TabPage2.Controls.Add(this.nonFlagWrapWidth);
            this.TabPage2.Controls.Add(this.flagWrapWidth);
            this.TabPage2.Controls.Add(this.nonFlagDefaults);
            this.TabPage2.Controls.Add(this.flagDefaults);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this.FlagSlips);
            this.TabPage2.Controls.Add(this.Label33);
            this.TabPage2.Controls.Add(this.Label28);
            this.TabPage2.Controls.Add(this.Spine);
            this.TabPage2.Controls.Add(this.CustomLabel);
            this.TabPage2.Controls.Add(this.CustomText);
            this.TabPage2.Controls.Add(this.formatInfoPanel);
            this.TabPage2.Controls.Add(this.spineDefaults);
            this.TabPage2.Controls.Add(this.pocketDefaults);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(528, 330);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Tag = "";
            this.TabPage2.Text = "Call Number Format";
            // 
            // PocketLabelPanel
            // 
            this.PocketLabelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.PocketLabelPanel.Controls.Add(this.plUnits2);
            this.PocketLabelPanel.Controls.Add(this.plUnits1);
            this.PocketLabelPanel.Controls.Add(this.userDefinedPanel);
            this.PocketLabelPanel.Controls.Add(this.spineType);
            this.PocketLabelPanel.Controls.Add(this.Label106);
            this.PocketLabelPanel.Controls.Add(this.Label105);
            this.PocketLabelPanel.Controls.Add(this.Label104);
            this.PocketLabelPanel.Controls.Add(this.Label101);
            this.PocketLabelPanel.Controls.Add(this.Label100);
            this.PocketLabelPanel.Controls.Add(this.Label94);
            this.PocketLabelPanel.Controls.Add(this.btnSL6);
            this.PocketLabelPanel.Controls.Add(this.btnSL4);
            this.PocketLabelPanel.Controls.Add(this.btnSLB);
            this.PocketLabelPanel.Controls.Add(this.Label103);
            this.PocketLabelPanel.Controls.Add(this.Label102);
            this.PocketLabelPanel.Controls.Add(this.plLeftMargin);
            this.PocketLabelPanel.Controls.Add(this.PLcount);
            this.PocketLabelPanel.Controls.Add(this.plDistance);
            this.PocketLabelPanel.Controls.Add(this.Label99);
            this.PocketLabelPanel.Controls.Add(this.Label98);
            this.PocketLabelPanel.Controls.Add(this.plWork);
            this.PocketLabelPanel.Controls.Add(this.Label97);
            this.PocketLabelPanel.Controls.Add(this.btnPlCustom);
            this.PocketLabelPanel.Controls.Add(this.plOutput);
            this.PocketLabelPanel.Controls.Add(this.Label88);
            this.PocketLabelPanel.Location = new System.Drawing.Point(4, -8);
            this.PocketLabelPanel.Name = "PocketLabelPanel";
            this.PocketLabelPanel.Size = new System.Drawing.Size(512, 316);
            this.PocketLabelPanel.TabIndex = 60;
            this.PocketLabelPanel.Visible = false;
            // 
            // plUnits2
            // 
            this.plUnits2.AutoSize = true;
            this.plUnits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plUnits2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plUnits2.Location = new System.Drawing.Point(240, 84);
            this.plUnits2.Name = "plUnits2";
            this.plUnits2.Size = new System.Drawing.Size(18, 13);
            this.plUnits2.TabIndex = 80;
            this.plUnits2.Text = "in.";
            // 
            // plUnits1
            // 
            this.plUnits1.AutoSize = true;
            this.plUnits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plUnits1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.plUnits1.Location = new System.Drawing.Point(240, 48);
            this.plUnits1.Name = "plUnits1";
            this.plUnits1.Size = new System.Drawing.Size(18, 13);
            this.plUnits1.TabIndex = 79;
            this.plUnits1.Text = "in.";
            // 
            // userDefinedPanel
            // 
            this.userDefinedPanel.Controls.Add(this.Label96);
            this.userDefinedPanel.Controls.Add(this.plMax4);
            this.userDefinedPanel.Controls.Add(this.plMax3);
            this.userDefinedPanel.Controls.Add(this.plMax2);
            this.userDefinedPanel.Controls.Add(this.plMax1);
            this.userDefinedPanel.Controls.Add(this.Label95);
            this.userDefinedPanel.Controls.Add(this.plMin4);
            this.userDefinedPanel.Controls.Add(this.plMin3);
            this.userDefinedPanel.Controls.Add(this.plMin2);
            this.userDefinedPanel.Controls.Add(this.plMin1);
            this.userDefinedPanel.Controls.Add(this.Label93);
            this.userDefinedPanel.Controls.Add(this.Label92);
            this.userDefinedPanel.Controls.Add(this.plSrc4);
            this.userDefinedPanel.Controls.Add(this.plSrc3);
            this.userDefinedPanel.Controls.Add(this.plSrc2);
            this.userDefinedPanel.Controls.Add(this.plSrc1);
            this.userDefinedPanel.Location = new System.Drawing.Point(264, 184);
            this.userDefinedPanel.Name = "userDefinedPanel";
            this.userDefinedPanel.Size = new System.Drawing.Size(244, 112);
            this.userDefinedPanel.TabIndex = 78;
            // 
            // Label96
            // 
            this.Label96.AutoSize = true;
            this.Label96.Location = new System.Drawing.Point(100, 2);
            this.Label96.Name = "Label96";
            this.Label96.Size = new System.Drawing.Size(83, 13);
            this.Label96.TabIndex = 53;
            this.Label96.Text = "Number of lines:";
            // 
            // plMax4
            // 
            this.plMax4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMax4.Location = new System.Drawing.Point(216, 90);
            this.plMax4.Name = "plMax4";
            this.plMax4.Size = new System.Drawing.Size(20, 20);
            this.plMax4.TabIndex = 51;
            this.plMax4.Tag = "text_plmax4";
            this.plMax4.Text = "0";
            this.ToolTip1.SetToolTip(this.plMax4, "Enter the maximum number of lines that should print for this XML field.");
            this.plMax4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMax4.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMax3
            // 
            this.plMax3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMax3.Location = new System.Drawing.Point(216, 66);
            this.plMax3.Name = "plMax3";
            this.plMax3.Size = new System.Drawing.Size(20, 20);
            this.plMax3.TabIndex = 44;
            this.plMax3.Tag = "text_plmax3";
            this.plMax3.Text = "0";
            this.ToolTip1.SetToolTip(this.plMax3, "Enter the maximum number of lines that should print for this XML field.");
            this.plMax3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMax3.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMax2
            // 
            this.plMax2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMax2.Location = new System.Drawing.Point(216, 42);
            this.plMax2.Name = "plMax2";
            this.plMax2.Size = new System.Drawing.Size(20, 20);
            this.plMax2.TabIndex = 41;
            this.plMax2.Tag = "text_plmax2";
            this.plMax2.Text = "0";
            this.ToolTip1.SetToolTip(this.plMax2, "Enter the maximum number of lines that should print for this XML field.");
            this.plMax2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMax2.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMax1
            // 
            this.plMax1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMax1.Location = new System.Drawing.Point(216, 18);
            this.plMax1.Name = "plMax1";
            this.plMax1.Size = new System.Drawing.Size(20, 20);
            this.plMax1.TabIndex = 38;
            this.plMax1.Tag = "text_plmax1";
            this.plMax1.Text = "0";
            this.ToolTip1.SetToolTip(this.plMax1, "Enter the maximum number of lines that should print for this XML field.");
            this.plMax1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMax1.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label95
            // 
            this.Label95.AutoSize = true;
            this.Label95.Location = new System.Drawing.Point(212, 2);
            this.Label95.Name = "Label95";
            this.Label95.Size = new System.Drawing.Size(29, 13);
            this.Label95.TabIndex = 48;
            this.Label95.Text = "max.";
            // 
            // plMin4
            // 
            this.plMin4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMin4.Location = new System.Drawing.Point(188, 90);
            this.plMin4.Name = "plMin4";
            this.plMin4.Size = new System.Drawing.Size(20, 20);
            this.plMin4.TabIndex = 50;
            this.plMin4.Tag = "text_plmin4";
            this.plMin4.Text = "0";
            this.ToolTip1.SetToolTip(this.plMin4, "Enter a number of 0 or more lines to print for the XML field.");
            this.plMin4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMin4.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMin3
            // 
            this.plMin3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMin3.Location = new System.Drawing.Point(188, 66);
            this.plMin3.Name = "plMin3";
            this.plMin3.Size = new System.Drawing.Size(20, 20);
            this.plMin3.TabIndex = 43;
            this.plMin3.Tag = "text_plmin3";
            this.plMin3.Text = "0";
            this.ToolTip1.SetToolTip(this.plMin3, "Enter a number of 0 or more lines to print for the XML field.");
            this.plMin3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMin3.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMin2
            // 
            this.plMin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMin2.Location = new System.Drawing.Point(188, 42);
            this.plMin2.Name = "plMin2";
            this.plMin2.Size = new System.Drawing.Size(20, 20);
            this.plMin2.TabIndex = 40;
            this.plMin2.Tag = "text_plmin2";
            this.plMin2.Text = "0";
            this.ToolTip1.SetToolTip(this.plMin2, "Enter a number of 0 or more lines to print for the XML field.");
            this.plMin2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMin2.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // plMin1
            // 
            this.plMin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMin1.Location = new System.Drawing.Point(188, 18);
            this.plMin1.Name = "plMin1";
            this.plMin1.Size = new System.Drawing.Size(20, 20);
            this.plMin1.TabIndex = 37;
            this.plMin1.Tag = "text_plmin1";
            this.plMin1.Text = "0";
            this.ToolTip1.SetToolTip(this.plMin1, "Enter a number of 0 or more lines to print for the XML field.");
            this.plMin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plMin1.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label93
            // 
            this.Label93.AutoSize = true;
            this.Label93.Location = new System.Drawing.Point(8, 2);
            this.Label93.Name = "Label93";
            this.Label93.Size = new System.Drawing.Size(71, 13);
            this.Label93.TabIndex = 41;
            this.Label93.Text = "XML Sources";
            // 
            // Label92
            // 
            this.Label92.AutoSize = true;
            this.Label92.Location = new System.Drawing.Point(185, 2);
            this.Label92.Name = "Label92";
            this.Label92.Size = new System.Drawing.Size(26, 13);
            this.Label92.TabIndex = 40;
            this.Label92.Text = "min.";
            // 
            // plSrc4
            // 
            this.plSrc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSrc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plSrc4.Location = new System.Drawing.Point(8, 90);
            this.plSrc4.Name = "plSrc4";
            this.plSrc4.Size = new System.Drawing.Size(172, 20);
            this.plSrc4.TabIndex = 45;
            this.plSrc4.Tag = "text_plsource4";
            this.ToolTip1.SetToolTip(this.plSrc4, "Enter an XML field to include on the pocket label, or doubleclick to select an XM" +
        "L field.");
            this.plSrc4.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // plSrc3
            // 
            this.plSrc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSrc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plSrc3.Location = new System.Drawing.Point(8, 66);
            this.plSrc3.Name = "plSrc3";
            this.plSrc3.Size = new System.Drawing.Size(172, 20);
            this.plSrc3.TabIndex = 42;
            this.plSrc3.Tag = "text_plsource3";
            this.ToolTip1.SetToolTip(this.plSrc3, "Enter an XML field to include on the pocket label, or doubleclick to select an XM" +
        "L field.");
            this.plSrc3.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // plSrc2
            // 
            this.plSrc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSrc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plSrc2.Location = new System.Drawing.Point(8, 42);
            this.plSrc2.Name = "plSrc2";
            this.plSrc2.Size = new System.Drawing.Size(172, 20);
            this.plSrc2.TabIndex = 39;
            this.plSrc2.Tag = "text_plsource2";
            this.ToolTip1.SetToolTip(this.plSrc2, "Enter an XML field to include on the pocket label, or doubleclick to select an XM" +
        "L field.");
            this.plSrc2.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // plSrc1
            // 
            this.plSrc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSrc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plSrc1.Location = new System.Drawing.Point(8, 18);
            this.plSrc1.Name = "plSrc1";
            this.plSrc1.Size = new System.Drawing.Size(172, 20);
            this.plSrc1.TabIndex = 36;
            this.plSrc1.Tag = "text_plsource1";
            this.ToolTip1.SetToolTip(this.plSrc1, "Enter an XML field to include on the pocket label, or doubleclick to select an XM" +
        "L field.");
            this.plSrc1.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // spineType
            // 
            this.spineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spineType.ForeColor = System.Drawing.Color.Blue;
            this.spineType.Location = new System.Drawing.Point(332, 21);
            this.spineType.Name = "spineType";
            this.spineType.Size = new System.Drawing.Size(188, 15);
            this.spineType.TabIndex = 77;
            this.ToolTip1.SetToolTip(this.spineType, "The spine label portion of the pocket label set will depend on the Label Type sel" +
        "ected in the Call Number Format panel.");
            // 
            // Label106
            // 
            this.Label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label106.Location = new System.Drawing.Point(264, 144);
            this.Label106.Name = "Label106";
            this.Label106.Size = new System.Drawing.Size(140, 16);
            this.Label106.TabIndex = 76;
            this.Label106.Text = "User-defined format";
            // 
            // Label105
            // 
            this.Label105.AutoSize = true;
            this.Label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label105.Location = new System.Drawing.Point(384, 56);
            this.Label105.Name = "Label105";
            this.Label105.Size = new System.Drawing.Size(131, 13);
            this.Label105.TabIndex = 75;
            this.Label105.Text = "(Call number, Author, Title)";
            // 
            // Label104
            // 
            this.Label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label104.Location = new System.Drawing.Point(264, 56);
            this.Label104.Name = "Label104";
            this.Label104.Size = new System.Drawing.Size(120, 16);
            this.Label104.TabIndex = 74;
            this.Label104.Text = "Standard Formats";
            this.ToolTip1.SetToolTip(this.Label104, "Create OCLC standard labels with Call Number, Author and Title.");
            // 
            // Label101
            // 
            this.Label101.AutoSize = true;
            this.Label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label101.Location = new System.Drawing.Point(420, 118);
            this.Label101.Name = "Label101";
            this.Label101.Size = new System.Drawing.Size(85, 13);
            this.Label101.TabIndex = 73;
            this.Label101.Text = "(Double spaced)";
            // 
            // Label100
            // 
            this.Label100.AutoSize = true;
            this.Label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label100.Location = new System.Drawing.Point(420, 98);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(80, 13);
            this.Label100.TabIndex = 72;
            this.Label100.Text = "(Single spaced)";
            // 
            // Label94
            // 
            this.Label94.AutoSize = true;
            this.Label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label94.Location = new System.Drawing.Point(420, 78);
            this.Label94.Name = "Label94";
            this.Label94.Size = new System.Drawing.Size(80, 13);
            this.Label94.TabIndex = 71;
            this.Label94.Text = "(Single spaced)";
            // 
            // btnSL6
            // 
            this.btnSL6.AutoSize = true;
            this.btnSL6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSL6.Location = new System.Drawing.Point(272, 116);
            this.btnSL6.Name = "btnSL6";
            this.btnSL6.Size = new System.Drawing.Size(146, 17);
            this.btnSL6.TabIndex = 70;
            this.btnSL6.Tag = "radio_SL6";
            this.btnSL6.Text = "SL6 - 2 pocket labels";
            this.ToolTip1.SetToolTip(this.btnSL6, "Print spine label and two pocket labels, with double spacing.");
            this.btnSL6.UseVisualStyleBackColor = true;
            // 
            // btnSL4
            // 
            this.btnSL4.AutoSize = true;
            this.btnSL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSL4.Location = new System.Drawing.Point(272, 96);
            this.btnSL4.Name = "btnSL4";
            this.btnSL4.Size = new System.Drawing.Size(146, 17);
            this.btnSL4.TabIndex = 69;
            this.btnSL4.Tag = "radio_SL4";
            this.btnSL4.Text = "SL4 - 2 pocket labels";
            this.ToolTip1.SetToolTip(this.btnSL4, "Prints spine label and two pocket labels, with minimum line spacing.");
            this.btnSL4.UseVisualStyleBackColor = true;
            // 
            // btnSLB
            // 
            this.btnSLB.AutoSize = true;
            this.btnSLB.Checked = true;
            this.btnSLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLB.Location = new System.Drawing.Point(272, 76);
            this.btnSLB.Name = "btnSLB";
            this.btnSLB.Size = new System.Drawing.Size(141, 17);
            this.btnSLB.TabIndex = 68;
            this.btnSLB.TabStop = true;
            this.btnSLB.Tag = "radio_plSLB";
            this.btnSLB.Text = "SLB - 1 pocket label";
            this.ToolTip1.SetToolTip(this.btnSLB, "Prints spine label and one pocket label, minimum line spacing.");
            this.btnSLB.UseVisualStyleBackColor = true;
            // 
            // Label103
            // 
            this.Label103.Location = new System.Drawing.Point(60, 84);
            this.Label103.Name = "Label103";
            this.Label103.Size = new System.Drawing.Size(140, 20);
            this.Label103.TabIndex = 67;
            this.Label103.Text = "Distance between top lines:";
            // 
            // Label102
            // 
            this.Label102.AutoSize = true;
            this.Label102.Location = new System.Drawing.Point(16, 48);
            this.Label102.Name = "Label102";
            this.Label102.Size = new System.Drawing.Size(186, 13);
            this.Label102.TabIndex = 66;
            this.Label102.Text = "Pocket label distance from left margin:";
            // 
            // plLeftMargin
            // 
            this.plLeftMargin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plLeftMargin.Location = new System.Drawing.Point(204, 48);
            this.plLeftMargin.Name = "plLeftMargin";
            this.plLeftMargin.Size = new System.Drawing.Size(36, 13);
            this.plLeftMargin.TabIndex = 65;
            this.plLeftMargin.Tag = "text_plLeftmargin";
            this.plLeftMargin.Text = "1.2";
            this.ToolTip1.SetToolTip(this.plLeftMargin, "Horizontal distance from the left print margin to the pocket label.");
            this.plLeftMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plLeftMargin.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // PLcount
            // 
            this.PLcount.BackColor = System.Drawing.Color.White;
            this.PLcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLcount.ForeColor = System.Drawing.Color.Black;
            this.PLcount.Location = new System.Drawing.Point(352, 160);
            this.PLcount.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PLcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PLcount.Name = "PLcount";
            this.PLcount.ReadOnly = true;
            this.PLcount.Size = new System.Drawing.Size(36, 22);
            this.PLcount.TabIndex = 55;
            this.PLcount.TabStop = false;
            this.PLcount.Tag = "numud_pocketlabelcount";
            this.PLcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.PLcount, "Select 1 or 2 pocket labels");
            this.PLcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // plDistance
            // 
            this.plDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plDistance.Location = new System.Drawing.Point(204, 84);
            this.plDistance.Name = "plDistance";
            this.plDistance.Size = new System.Drawing.Size(36, 13);
            this.plDistance.TabIndex = 61;
            this.plDistance.Tag = "text_pldistance";
            this.plDistance.Text = "0.0";
            this.ToolTip1.SetToolTip(this.plDistance, "Vertical distance from top line of 1st pocket label to top line of the 2nd.");
            this.plDistance.TextChanged += new System.EventHandler(this.plDistance_TextChanged);
            this.plDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.plDistance.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label99
            // 
            this.Label99.Location = new System.Drawing.Point(16, 68);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(116, 20);
            this.Label99.TabIndex = 60;
            this.Label99.Text = "For two pocket labels:";
            // 
            // Label98
            // 
            this.Label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label98.Location = new System.Drawing.Point(16, 21);
            this.Label98.Name = "Label98";
            this.Label98.Size = new System.Drawing.Size(320, 15);
            this.Label98.TabIndex = 59;
            this.Label98.Text = "One spine label will be created using call number format :";
            // 
            // plWork
            // 
            this.plWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.plWork.Location = new System.Drawing.Point(8, 96);
            this.plWork.Multiline = true;
            this.plWork.Name = "plWork";
            this.plWork.Size = new System.Drawing.Size(20, 12);
            this.plWork.TabIndex = 58;
            this.plWork.Visible = false;
            this.plWork.WordWrap = false;
            // 
            // Label97
            // 
            this.Label97.AutoSize = true;
            this.Label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label97.Location = new System.Drawing.Point(392, 164);
            this.Label97.Name = "Label97";
            this.Label97.Size = new System.Drawing.Size(91, 13);
            this.Label97.TabIndex = 57;
            this.Label97.Text = "pocket label(s)";
            // 
            // btnPlCustom
            // 
            this.btnPlCustom.AutoSize = true;
            this.btnPlCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlCustom.Location = new System.Drawing.Point(272, 162);
            this.btnPlCustom.Name = "btnPlCustom";
            this.btnPlCustom.Size = new System.Drawing.Size(74, 17);
            this.btnPlCustom.TabIndex = 35;
            this.btnPlCustom.Tag = "radio_SLCUSTOM";
            this.btnPlCustom.Text = "Custom -";
            this.ToolTip1.SetToolTip(this.btnPlCustom, "Specify fields and line spacing to create a custom pocket label.");
            this.btnPlCustom.UseVisualStyleBackColor = true;
            this.btnPlCustom.CheckedChanged += new System.EventHandler(this.btnPlCustom_CheckedChanged);
            // 
            // plOutput
            // 
            this.plOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plOutput.Location = new System.Drawing.Point(0, 108);
            this.plOutput.Multiline = true;
            this.plOutput.Name = "plOutput";
            this.plOutput.Size = new System.Drawing.Size(256, 188);
            this.plOutput.TabIndex = 31;
            this.plOutput.TabStop = false;
            this.ToolTip1.SetToolTip(this.plOutput, "Output box where the pocket label can be displayed or edited.");
            this.plOutput.WordWrap = false;
            // 
            // Label88
            // 
            this.Label88.AutoSize = true;
            this.Label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label88.Location = new System.Drawing.Point(4, 4);
            this.Label88.Name = "Label88";
            this.Label88.Size = new System.Drawing.Size(133, 16);
            this.Label88.TabIndex = 30;
            this.Label88.Text = "Pocket Label Sets";
            // 
            // tweakParsingPanel
            // 
            this.tweakParsingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tweakParsingPanel.Controls.Add(this.convertBlankTo);
            this.tweakParsingPanel.Controls.Add(this.Label65);
            this.tweakParsingPanel.Controls.Add(this.TabControl2);
            this.tweakParsingPanel.Controls.Add(this.Label73);
            this.tweakParsingPanel.Controls.Add(this.Label71);
            this.tweakParsingPanel.Controls.Add(this.GroupBox2);
            this.tweakParsingPanel.Location = new System.Drawing.Point(4, 124);
            this.tweakParsingPanel.Name = "tweakParsingPanel";
            this.tweakParsingPanel.Size = new System.Drawing.Size(28, 180);
            this.tweakParsingPanel.TabIndex = 50;
            this.tweakParsingPanel.Visible = false;
            // 
            // convertBlankTo
            // 
            this.convertBlankTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.convertBlankTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBlankTo.Location = new System.Drawing.Point(320, 228);
            this.convertBlankTo.Name = "convertBlankTo";
            this.convertBlankTo.Size = new System.Drawing.Size(20, 13);
            this.convertBlankTo.TabIndex = 43;
            this.convertBlankTo.Tag = "text_convertblankcntype";
            this.convertBlankTo.Text = "0";
            this.convertBlankTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.convertBlankTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.convertBlankTo.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label65
            // 
            this.Label65.AutoSize = true;
            this.Label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label65.Location = new System.Drawing.Point(16, 228);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(304, 13);
            this.Label65.TabIndex = 42;
            this.Label65.Text = "If the incoming <call_number_type> is blank, convert it to type: ";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Controls.Add(this.TabPage8);
            this.TabControl2.Controls.Add(this.TabPage10);
            this.TabControl2.Controls.Add(this.TabPage11);
            this.TabControl2.Controls.Add(this.TabPage9);
            this.TabControl2.Location = new System.Drawing.Point(8, 20);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(504, 204);
            this.TabControl2.TabIndex = 40;
            this.TabControl2.SelectedIndexChanged += new System.EventHandler(this.TabControl2_SelectedIndexChanged);
            // 
            // TabPage7
            // 
            this.TabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage7.Controls.Add(this.hideCutterDecimal);
            this.TabPage7.Controls.Add(this.lcType);
            this.TabPage7.Controls.Add(this.Label107);
            this.TabPage7.Controls.Add(this.lcRemoveAfter);
            this.TabPage7.Controls.Add(this.lcBreak);
            this.TabPage7.Controls.Add(this.Panel6);
            this.TabPage7.Controls.Add(this.Panel8);
            this.TabPage7.Controls.Add(this.Panel7);
            this.TabPage7.Controls.Add(this.Panel5);
            this.TabPage7.Controls.Add(this.lcNumericBreak);
            this.TabPage7.Controls.Add(this.lcNoNumericBreak);
            this.TabPage7.Controls.Add(this.Label66);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(496, 178);
            this.TabPage7.TabIndex = 0;
            this.TabPage7.Text = "LC/Child.Lit/NLM";
            // 
            // hideCutterDecimal
            // 
            this.hideCutterDecimal.AutoSize = true;
            this.hideCutterDecimal.Location = new System.Drawing.Point(324, 72);
            this.hideCutterDecimal.Name = "hideCutterDecimal";
            this.hideCutterDecimal.Size = new System.Drawing.Size(117, 17);
            this.hideCutterDecimal.TabIndex = 26;
            this.hideCutterDecimal.Tag = "check_hidecutterdecimal";
            this.hideCutterDecimal.Text = "Hide cutter decimal";
            this.ToolTip1.SetToolTip(this.hideCutterDecimal, "Hides the decimal that precedes the cutter.");
            this.hideCutterDecimal.UseVisualStyleBackColor = true;
            this.hideCutterDecimal.CheckedChanged += new System.EventHandler(this.hideCutterDecimal_CheckedChanged);
            // 
            // lcType
            // 
            this.lcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lcType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcType.Location = new System.Drawing.Point(176, 4);
            this.lcType.Name = "lcType";
            this.lcType.Size = new System.Drawing.Size(48, 13);
            this.lcType.TabIndex = 25;
            this.lcType.Tag = "text_lctype";
            this.lcType.Text = "0,2";
            this.ToolTip1.SetToolTip(this.lcType, "One or more call number types (separated by commas) that will be handled by this " +
        "parsing routine.");
            // 
            // Label107
            // 
            this.Label107.AutoSize = true;
            this.Label107.ForeColor = System.Drawing.Color.Blue;
            this.Label107.Location = new System.Drawing.Point(20, 4);
            this.Label107.Name = "Label107";
            this.Label107.Size = new System.Drawing.Size(150, 13);
            this.Label107.TabIndex = 24;
            this.Label107.Text = "Handles Call Number Type(s): ";
            // 
            // lcRemoveAfter
            // 
            this.lcRemoveAfter.AutoSize = true;
            this.lcRemoveAfter.Location = new System.Drawing.Point(200, 140);
            this.lcRemoveAfter.Name = "lcRemoveAfter";
            this.lcRemoveAfter.Size = new System.Drawing.Size(205, 17);
            this.lcRemoveAfter.TabIndex = 23;
            this.lcRemoveAfter.Tag = "check_lcremoveafter";
            this.lcRemoveAfter.Text = "Remove character(s) from call number";
            this.lcRemoveAfter.UseVisualStyleBackColor = true;
            this.lcRemoveAfter.CheckedChanged += new System.EventHandler(this.lcRemoveAfter_CheckedChanged);
            // 
            // lcBreak
            // 
            this.lcBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.lcBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcBreak.Location = new System.Drawing.Point(408, 108);
            this.lcBreak.Multiline = true;
            this.lcBreak.Name = "lcBreak";
            this.lcBreak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lcBreak.Size = new System.Drawing.Size(84, 68);
            this.lcBreak.TabIndex = 22;
            this.lcBreak.Tag = "text_lcbreak";
            this.ToolTip1.SetToolTip(this.lcBreak, "One or more characters or phrases that will cause a line break.");
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.lcOtherBreakAft);
            this.Panel6.Controls.Add(this.Label78);
            this.Panel6.Controls.Add(this.lcOtherBreakB4);
            this.Panel6.Controls.Add(this.lcOtherNoBreak);
            this.Panel6.Location = new System.Drawing.Point(36, 116);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(372, 24);
            this.Panel6.TabIndex = 17;
            // 
            // lcOtherBreakAft
            // 
            this.lcOtherBreakAft.AutoSize = true;
            this.lcOtherBreakAft.Location = new System.Drawing.Point(260, 4);
            this.lcOtherBreakAft.Name = "lcOtherBreakAft";
            this.lcOtherBreakAft.Size = new System.Drawing.Size(108, 17);
            this.lcOtherBreakAft.TabIndex = 14;
            this.lcOtherBreakAft.Tag = "radio_lcotherbreakaft";
            this.lcOtherBreakAft.Text = "after character(s):";
            this.lcOtherBreakAft.UseVisualStyleBackColor = true;
            // 
            // Label78
            // 
            this.Label78.AutoSize = true;
            this.Label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label78.Location = new System.Drawing.Point(40, 8);
            this.Label78.Name = "Label78";
            this.Label78.Size = new System.Drawing.Size(42, 13);
            this.Label78.TabIndex = 9;
            this.Label78.Text = "Other:";
            // 
            // lcOtherBreakB4
            // 
            this.lcOtherBreakB4.AutoSize = true;
            this.lcOtherBreakB4.Location = new System.Drawing.Point(164, 4);
            this.lcOtherBreakB4.Name = "lcOtherBreakB4";
            this.lcOtherBreakB4.Size = new System.Drawing.Size(98, 17);
            this.lcOtherBreakB4.TabIndex = 13;
            this.lcOtherBreakB4.Tag = "radio_lcotherbreakb4";
            this.lcOtherBreakB4.Text = "Break before or";
            this.lcOtherBreakB4.UseVisualStyleBackColor = true;
            this.lcOtherBreakB4.CheckedChanged += new System.EventHandler(this.lcOtherBreakB4_CheckedChanged);
            // 
            // lcOtherNoBreak
            // 
            this.lcOtherNoBreak.AutoSize = true;
            this.lcOtherNoBreak.Checked = true;
            this.lcOtherNoBreak.Location = new System.Drawing.Point(88, 4);
            this.lcOtherNoBreak.Name = "lcOtherNoBreak";
            this.lcOtherNoBreak.Size = new System.Drawing.Size(69, 17);
            this.lcOtherNoBreak.TabIndex = 12;
            this.lcOtherNoBreak.TabStop = true;
            this.lcOtherNoBreak.Tag = "radio_lcothernobreak";
            this.lcOtherNoBreak.Text = "No break";
            this.lcOtherNoBreak.UseVisualStyleBackColor = true;
            this.lcOtherNoBreak.CheckedChanged += new System.EventHandler(this.lcOtherNoBreak_CheckedChanged);
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.Label76);
            this.Panel8.Controls.Add(this.lcInCutterBreak);
            this.Panel8.Controls.Add(this.lcIncutternobreak);
            this.Panel8.Location = new System.Drawing.Point(36, 92);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(312, 24);
            this.Panel8.TabIndex = 16;
            // 
            // Label76
            // 
            this.Label76.AutoSize = true;
            this.Label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label76.Location = new System.Drawing.Point(21, 8);
            this.Label76.Name = "Label76";
            this.Label76.Size = new System.Drawing.Size(60, 13);
            this.Label76.TabIndex = 9;
            this.Label76.Text = "In Cutter:";
            // 
            // lcInCutterBreak
            // 
            this.lcInCutterBreak.AutoSize = true;
            this.lcInCutterBreak.Checked = true;
            this.lcInCutterBreak.Location = new System.Drawing.Point(164, 4);
            this.lcInCutterBreak.Name = "lcInCutterBreak";
            this.lcInCutterBreak.Size = new System.Drawing.Size(135, 17);
            this.lcInCutterBreak.TabIndex = 13;
            this.lcInCutterBreak.TabStop = true;
            this.lcInCutterBreak.Tag = "radio_lccutterspacebreak";
            this.lcInCutterBreak.Text = "Break on cutter spaces";
            this.lcInCutterBreak.UseVisualStyleBackColor = true;
            this.lcInCutterBreak.CheckedChanged += new System.EventHandler(this.lcInCutterBreak_CheckedChanged);
            // 
            // lcIncutternobreak
            // 
            this.lcIncutternobreak.AutoSize = true;
            this.lcIncutternobreak.Location = new System.Drawing.Point(88, 4);
            this.lcIncutternobreak.Name = "lcIncutternobreak";
            this.lcIncutternobreak.Size = new System.Drawing.Size(69, 17);
            this.lcIncutternobreak.TabIndex = 12;
            this.lcIncutternobreak.Tag = "radio_lccutterspacenobreak";
            this.lcIncutternobreak.Text = "No break";
            this.lcIncutternobreak.UseVisualStyleBackColor = true;
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.Label75);
            this.Panel7.Controls.Add(this.lcCutterBreak);
            this.Panel7.Controls.Add(this.lcCutterNoBreak);
            this.Panel7.Location = new System.Drawing.Point(8, 68);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(308, 24);
            this.Panel7.TabIndex = 15;
            // 
            // Label75
            // 
            this.Label75.AutoSize = true;
            this.Label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label75.Location = new System.Drawing.Point(24, 8);
            this.Label75.Name = "Label75";
            this.Label75.Size = new System.Drawing.Size(86, 13);
            this.Label75.TabIndex = 9;
            this.Label75.Text = "Before Cutter:";
            // 
            // lcCutterBreak
            // 
            this.lcCutterBreak.AutoSize = true;
            this.lcCutterBreak.Checked = true;
            this.lcCutterBreak.Location = new System.Drawing.Point(192, 4);
            this.lcCutterBreak.Name = "lcCutterBreak";
            this.lcCutterBreak.Size = new System.Drawing.Size(116, 17);
            this.lcCutterBreak.TabIndex = 13;
            this.lcCutterBreak.TabStop = true;
            this.lcCutterBreak.Tag = "radio_lccutterbreak";
            this.lcCutterBreak.Text = "Break before cutter";
            this.lcCutterBreak.UseVisualStyleBackColor = true;
            this.lcCutterBreak.CheckedChanged += new System.EventHandler(this.lcCutterBreak_CheckedChanged);
            // 
            // lcCutterNoBreak
            // 
            this.lcCutterNoBreak.AutoSize = true;
            this.lcCutterNoBreak.Location = new System.Drawing.Point(116, 4);
            this.lcCutterNoBreak.Name = "lcCutterNoBreak";
            this.lcCutterNoBreak.Size = new System.Drawing.Size(69, 17);
            this.lcCutterNoBreak.TabIndex = 12;
            this.lcCutterNoBreak.Tag = "radio_lccutternobreak";
            this.lcCutterNoBreak.Text = "No break";
            this.lcCutterNoBreak.UseVisualStyleBackColor = true;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.lcDecimalBreakAfter);
            this.Panel5.Controls.Add(this.Label74);
            this.Panel5.Controls.Add(this.lcDecimalBreakB4);
            this.Panel5.Controls.Add(this.lcNoDecimalBreak);
            this.Panel5.Location = new System.Drawing.Point(8, 44);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(436, 24);
            this.Panel5.TabIndex = 14;
            // 
            // lcDecimalBreakAfter
            // 
            this.lcDecimalBreakAfter.AutoSize = true;
            this.lcDecimalBreakAfter.Location = new System.Drawing.Point(292, 4);
            this.lcDecimalBreakAfter.Name = "lcDecimalBreakAfter";
            this.lcDecimalBreakAfter.Size = new System.Drawing.Size(85, 17);
            this.lcDecimalBreakAfter.TabIndex = 14;
            this.lcDecimalBreakAfter.Tag = "radio_lcdecbreak";
            this.lcDecimalBreakAfter.Text = "after decimal";
            this.lcDecimalBreakAfter.UseVisualStyleBackColor = true;
            // 
            // Label74
            // 
            this.Label74.AutoSize = true;
            this.Label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label74.Location = new System.Drawing.Point(20, 8);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(90, 13);
            this.Label74.TabIndex = 9;
            this.Label74.Text = "Class Decimal:";
            // 
            // lcDecimalBreakB4
            // 
            this.lcDecimalBreakB4.AutoSize = true;
            this.lcDecimalBreakB4.Location = new System.Drawing.Point(192, 4);
            this.lcDecimalBreakB4.Name = "lcDecimalBreakB4";
            this.lcDecimalBreakB4.Size = new System.Drawing.Size(98, 17);
            this.lcDecimalBreakB4.TabIndex = 13;
            this.lcDecimalBreakB4.Tag = "radio_lcdecbreakbefore";
            this.lcDecimalBreakB4.Text = "Break before or";
            this.lcDecimalBreakB4.UseVisualStyleBackColor = true;
            this.lcDecimalBreakB4.CheckedChanged += new System.EventHandler(this.lcDecimalBreakB4_CheckedChanged);
            // 
            // lcNoDecimalBreak
            // 
            this.lcNoDecimalBreak.AutoSize = true;
            this.lcNoDecimalBreak.Checked = true;
            this.lcNoDecimalBreak.Location = new System.Drawing.Point(116, 4);
            this.lcNoDecimalBreak.Name = "lcNoDecimalBreak";
            this.lcNoDecimalBreak.Size = new System.Drawing.Size(69, 17);
            this.lcNoDecimalBreak.TabIndex = 12;
            this.lcNoDecimalBreak.TabStop = true;
            this.lcNoDecimalBreak.Tag = "radio_lcdecnobreak";
            this.lcNoDecimalBreak.Text = "No break";
            this.lcNoDecimalBreak.UseVisualStyleBackColor = true;
            this.lcNoDecimalBreak.CheckedChanged += new System.EventHandler(this.lcNoDecimalBreak_CheckedChanged);
            // 
            // lcNumericBreak
            // 
            this.lcNumericBreak.AutoSize = true;
            this.lcNumericBreak.Checked = true;
            this.lcNumericBreak.Location = new System.Drawing.Point(200, 28);
            this.lcNumericBreak.Name = "lcNumericBreak";
            this.lcNumericBreak.Size = new System.Drawing.Size(131, 17);
            this.lcNumericBreak.TabIndex = 11;
            this.lcNumericBreak.TabStop = true;
            this.lcNumericBreak.Tag = "radio_lcnumbreak";
            this.lcNumericBreak.Text = "Break before numerics";
            this.lcNumericBreak.UseVisualStyleBackColor = true;
            this.lcNumericBreak.CheckedChanged += new System.EventHandler(this.lcNumericBreak_CheckedChanged);
            // 
            // lcNoNumericBreak
            // 
            this.lcNoNumericBreak.AutoSize = true;
            this.lcNoNumericBreak.Location = new System.Drawing.Point(124, 28);
            this.lcNoNumericBreak.Name = "lcNoNumericBreak";
            this.lcNoNumericBreak.Size = new System.Drawing.Size(69, 17);
            this.lcNoNumericBreak.TabIndex = 10;
            this.lcNoNumericBreak.Tag = "radio_lcnumnobreak";
            this.lcNoNumericBreak.Text = "No break";
            this.lcNoNumericBreak.UseVisualStyleBackColor = true;
            // 
            // Label66
            // 
            this.Label66.AutoSize = true;
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label66.Location = new System.Drawing.Point(20, 28);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(97, 13);
            this.Label66.TabIndex = 8;
            this.Label66.Text = "Class Numerics:";
            // 
            // TabPage8
            // 
            this.TabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage8.Controls.Add(this.deweyDecBreak);
            this.TabPage8.Controls.Add(this.deweyDigitsToBreak);
            this.TabPage8.Controls.Add(this.Label128);
            this.TabPage8.Controls.Add(this.Label127);
            this.TabPage8.Controls.Add(this.Label126);
            this.TabPage8.Controls.Add(this.Label125);
            this.TabPage8.Controls.Add(this.deweydigitsperline);
            this.TabPage8.Controls.Add(this.deweyGroup3);
            this.TabPage8.Controls.Add(this.DeweyType);
            this.TabPage8.Controls.Add(this.Label108);
            this.TabPage8.Controls.Add(this.deweyRemoveAfter);
            this.TabPage8.Controls.Add(this.deweyCharBreak);
            this.TabPage8.Controls.Add(this.Panel15);
            this.TabPage8.Controls.Add(this.Panel14);
            this.TabPage8.Controls.Add(this.Panel9);
            this.TabPage8.Controls.Add(this.Panel11);
            this.TabPage8.Location = new System.Drawing.Point(4, 22);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage8.Size = new System.Drawing.Size(496, 178);
            this.TabPage8.TabIndex = 1;
            this.TabPage8.Text = "Dewey";
            // 
            // deweyDecBreak
            // 
            this.deweyDecBreak.AutoSize = true;
            this.deweyDecBreak.Enabled = false;
            this.deweyDecBreak.Location = new System.Drawing.Point(140, 68);
            this.deweyDecBreak.Name = "deweyDecBreak";
            this.deweyDecBreak.Size = new System.Drawing.Size(15, 14);
            this.deweyDecBreak.TabIndex = 60;
            this.deweyDecBreak.Tag = "check_deweydecimalbreak";
            this.ToolTip1.SetToolTip(this.deweyDecBreak, "Check to break the class number after the specified number of decimal digits.");
            this.deweyDecBreak.UseVisualStyleBackColor = true;
            this.deweyDecBreak.CheckedChanged += new System.EventHandler(this.deweyDecBreak_CheckedChanged);
            // 
            // deweyDigitsToBreak
            // 
            this.deweyDigitsToBreak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deweyDigitsToBreak.Enabled = false;
            this.deweyDigitsToBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deweyDigitsToBreak.Location = new System.Drawing.Point(260, 68);
            this.deweyDigitsToBreak.Name = "deweyDigitsToBreak";
            this.deweyDigitsToBreak.Size = new System.Drawing.Size(16, 13);
            this.deweyDigitsToBreak.TabIndex = 59;
            this.deweyDigitsToBreak.Tag = "text_deweydigitstobreak";
            this.deweyDigitsToBreak.Text = "4";
            this.deweyDigitsToBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.deweyDigitsToBreak, "The class number will not break unless the number of digits after the decimal poi" +
        "nt exceeds this value (from 2 through 7).");
            this.deweyDigitsToBreak.TextChanged += new System.EventHandler(this.deweyDigitsToBreak_TextChanged);
            this.deweyDigitsToBreak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitValues);
            this.deweyDigitsToBreak.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // Label128
            // 
            this.Label128.AutoSize = true;
            this.Label128.Enabled = false;
            this.Label128.Location = new System.Drawing.Point(156, 68);
            this.Label128.Name = "Label128";
            this.Label128.Size = new System.Drawing.Size(106, 13);
            this.Label128.TabIndex = 58;
            this.Label128.Text = "until after dec. digit #";
            // 
            // Label127
            // 
            this.Label127.AutoSize = true;
            this.Label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label127.ForeColor = System.Drawing.Color.Red;
            this.Label127.Location = new System.Drawing.Point(120, 68);
            this.Label127.Name = "Label127";
            this.Label127.Size = new System.Drawing.Size(22, 15);
            this.Label127.TabIndex = 57;
            this.Label127.Tag = "";
            this.Label127.Text = "9";
            this.Label127.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label126
            // 
            this.Label126.AutoSize = true;
            this.Label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label126.ForeColor = System.Drawing.Color.Red;
            this.Label126.Location = new System.Drawing.Point(296, 68);
            this.Label126.Name = "Label126";
            this.Label126.Size = new System.Drawing.Size(22, 15);
            this.Label126.TabIndex = 56;
            this.Label126.Tag = "";
            this.Label126.Text = "9";
            this.Label126.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label125
            // 
            this.Label125.AutoSize = true;
            this.Label125.Enabled = false;
            this.Label125.Location = new System.Drawing.Point(352, 68);
            this.Label125.Name = "Label125";
            this.Label125.Size = new System.Drawing.Size(112, 13);
            this.Label125.TabIndex = 45;
            this.Label125.Text = "digits per line grouping";
            // 
            // deweydigitsperline
            // 
            this.deweydigitsperline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deweydigitsperline.Enabled = false;
            this.deweydigitsperline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deweydigitsperline.Location = new System.Drawing.Point(332, 68);
            this.deweydigitsperline.Name = "deweydigitsperline";
            this.deweydigitsperline.Size = new System.Drawing.Size(16, 13);
            this.deweydigitsperline.TabIndex = 44;
            this.deweydigitsperline.Tag = "text_deweydigitsperline";
            this.deweydigitsperline.Text = "3";
            this.deweydigitsperline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deweydigitsperline.TextChanged += new System.EventHandler(this.deweydigitsperline_TextChanged);
            this.deweydigitsperline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitValues);
            this.deweydigitsperline.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // deweyGroup3
            // 
            this.deweyGroup3.AutoSize = true;
            this.deweyGroup3.Enabled = false;
            this.deweyGroup3.Location = new System.Drawing.Point(316, 68);
            this.deweyGroup3.Name = "deweyGroup3";
            this.deweyGroup3.Size = new System.Drawing.Size(15, 14);
            this.deweyGroup3.TabIndex = 28;
            this.deweyGroup3.Tag = "check_deweydigitsperline";
            this.ToolTip1.SetToolTip(this.deweyGroup3, "After breaking on the decimal point, display the remaining digits in groups 2 thr" +
        "ough 7 digits.");
            this.deweyGroup3.UseVisualStyleBackColor = true;
            this.deweyGroup3.CheckedChanged += new System.EventHandler(this.deweyGroup3_CheckedChanged);
            // 
            // DeweyType
            // 
            this.DeweyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.DeweyType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeweyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeweyType.Location = new System.Drawing.Point(176, 4);
            this.DeweyType.Name = "DeweyType";
            this.DeweyType.Size = new System.Drawing.Size(48, 13);
            this.DeweyType.TabIndex = 27;
            this.DeweyType.Tag = "text_deweytype";
            this.DeweyType.Text = "1";
            this.ToolTip1.SetToolTip(this.DeweyType, "One or more call number types (separated by commas) that will be handled by this " +
        "parsing routine.");
            // 
            // Label108
            // 
            this.Label108.AutoSize = true;
            this.Label108.ForeColor = System.Drawing.Color.Blue;
            this.Label108.Location = new System.Drawing.Point(20, 4);
            this.Label108.Name = "Label108";
            this.Label108.Size = new System.Drawing.Size(150, 13);
            this.Label108.TabIndex = 26;
            this.Label108.Text = "Handles Call Number Type(s): ";
            // 
            // deweyRemoveAfter
            // 
            this.deweyRemoveAfter.AutoSize = true;
            this.deweyRemoveAfter.Location = new System.Drawing.Point(196, 136);
            this.deweyRemoveAfter.Name = "deweyRemoveAfter";
            this.deweyRemoveAfter.Size = new System.Drawing.Size(205, 17);
            this.deweyRemoveAfter.TabIndex = 24;
            this.deweyRemoveAfter.Tag = "check_deweyremoveafter";
            this.deweyRemoveAfter.Text = "Remove character(s) from call number";
            this.ToolTip1.SetToolTip(this.deweyRemoveAfter, "Don\'t display the special characters that caused the break.");
            this.deweyRemoveAfter.UseVisualStyleBackColor = true;
            this.deweyRemoveAfter.CheckedChanged += new System.EventHandler(this.deweyRemoveAfter_CheckedChanged);
            // 
            // deweyCharBreak
            // 
            this.deweyCharBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.deweyCharBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deweyCharBreak.Location = new System.Drawing.Point(404, 104);
            this.deweyCharBreak.Multiline = true;
            this.deweyCharBreak.Name = "deweyCharBreak";
            this.deweyCharBreak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deweyCharBreak.Size = new System.Drawing.Size(88, 72);
            this.deweyCharBreak.TabIndex = 21;
            this.deweyCharBreak.Tag = "text_deweybreak";
            this.ToolTip1.SetToolTip(this.deweyCharBreak, "One or more characters or phrases that will cause a line break.");
            // 
            // Panel15
            // 
            this.Panel15.Controls.Add(this.deweyCharBreakAft);
            this.Panel15.Controls.Add(this.Label84);
            this.Panel15.Controls.Add(this.deweyCharBreakb4);
            this.Panel15.Controls.Add(this.deweyOtherNoBreak);
            this.Panel15.Location = new System.Drawing.Point(32, 112);
            this.Panel15.Name = "Panel15";
            this.Panel15.Size = new System.Drawing.Size(372, 24);
            this.Panel15.TabIndex = 20;
            this.Panel15.Tag = "";
            // 
            // deweyCharBreakAft
            // 
            this.deweyCharBreakAft.AutoSize = true;
            this.deweyCharBreakAft.Location = new System.Drawing.Point(260, 4);
            this.deweyCharBreakAft.Name = "deweyCharBreakAft";
            this.deweyCharBreakAft.Size = new System.Drawing.Size(108, 17);
            this.deweyCharBreakAft.TabIndex = 14;
            this.deweyCharBreakAft.Tag = "radio_deweycharbreakaft";
            this.deweyCharBreakAft.Text = "after character(s):";
            this.ToolTip1.SetToolTip(this.deweyCharBreakAft, "Break after any value specified in the text box.");
            this.deweyCharBreakAft.UseVisualStyleBackColor = true;
            // 
            // Label84
            // 
            this.Label84.AutoSize = true;
            this.Label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label84.Location = new System.Drawing.Point(40, 8);
            this.Label84.Name = "Label84";
            this.Label84.Size = new System.Drawing.Size(42, 13);
            this.Label84.TabIndex = 9;
            this.Label84.Text = "Other:";
            // 
            // deweyCharBreakb4
            // 
            this.deweyCharBreakb4.AutoSize = true;
            this.deweyCharBreakb4.Location = new System.Drawing.Point(164, 4);
            this.deweyCharBreakb4.Name = "deweyCharBreakb4";
            this.deweyCharBreakb4.Size = new System.Drawing.Size(98, 17);
            this.deweyCharBreakb4.TabIndex = 13;
            this.deweyCharBreakb4.Tag = "radio_deweycharbreakb4";
            this.deweyCharBreakb4.Text = "Break before or";
            this.ToolTip1.SetToolTip(this.deweyCharBreakb4, "Break before any value specified in the text box.");
            this.deweyCharBreakb4.UseVisualStyleBackColor = true;
            this.deweyCharBreakb4.CheckedChanged += new System.EventHandler(this.deweyCharBreakb4_CheckedChanged);
            // 
            // deweyOtherNoBreak
            // 
            this.deweyOtherNoBreak.AutoSize = true;
            this.deweyOtherNoBreak.Checked = true;
            this.deweyOtherNoBreak.Location = new System.Drawing.Point(88, 4);
            this.deweyOtherNoBreak.Name = "deweyOtherNoBreak";
            this.deweyOtherNoBreak.Size = new System.Drawing.Size(69, 17);
            this.deweyOtherNoBreak.TabIndex = 12;
            this.deweyOtherNoBreak.TabStop = true;
            this.deweyOtherNoBreak.Tag = "radio_deweycharnobreak";
            this.deweyOtherNoBreak.Text = "No break";
            this.ToolTip1.SetToolTip(this.deweyOtherNoBreak, "No other breaks.");
            this.deweyOtherNoBreak.UseVisualStyleBackColor = true;
            this.deweyOtherNoBreak.CheckedChanged += new System.EventHandler(this.deweyOtherNoBreak_CheckedChanged);
            // 
            // Panel14
            // 
            this.Panel14.Controls.Add(this.Label82);
            this.Panel14.Controls.Add(this.deweyPrefixBreak);
            this.Panel14.Controls.Add(this.deweyPrefixNoBreak);
            this.Panel14.Location = new System.Drawing.Point(32, 24);
            this.Panel14.Name = "Panel14";
            this.Panel14.Size = new System.Drawing.Size(356, 24);
            this.Panel14.TabIndex = 18;
            // 
            // Label82
            // 
            this.Label82.AutoSize = true;
            this.Label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label82.Location = new System.Drawing.Point(4, 8);
            this.Label82.Name = "Label82";
            this.Label82.Size = new System.Drawing.Size(79, 13);
            this.Label82.TabIndex = 9;
            this.Label82.Text = "Alpha Prefix:";
            // 
            // deweyPrefixBreak
            // 
            this.deweyPrefixBreak.AutoSize = true;
            this.deweyPrefixBreak.Checked = true;
            this.deweyPrefixBreak.Location = new System.Drawing.Point(164, 4);
            this.deweyPrefixBreak.Name = "deweyPrefixBreak";
            this.deweyPrefixBreak.Size = new System.Drawing.Size(105, 17);
            this.deweyPrefixBreak.TabIndex = 13;
            this.deweyPrefixBreak.TabStop = true;
            this.deweyPrefixBreak.Tag = "radio_deweyprefixbreakaft";
            this.deweyPrefixBreak.Text = "Break after prefix";
            this.ToolTip1.SetToolTip(this.deweyPrefixBreak, "Break after any alpha prefix.");
            this.deweyPrefixBreak.UseVisualStyleBackColor = true;
            this.deweyPrefixBreak.CheckedChanged += new System.EventHandler(this.deweyPrefixBreak_CheckedChanged);
            // 
            // deweyPrefixNoBreak
            // 
            this.deweyPrefixNoBreak.AutoSize = true;
            this.deweyPrefixNoBreak.Location = new System.Drawing.Point(88, 4);
            this.deweyPrefixNoBreak.Name = "deweyPrefixNoBreak";
            this.deweyPrefixNoBreak.Size = new System.Drawing.Size(69, 17);
            this.deweyPrefixNoBreak.TabIndex = 12;
            this.deweyPrefixNoBreak.Tag = "radio_deweyprefixnobreak";
            this.deweyPrefixNoBreak.Text = "No break";
            this.ToolTip1.SetToolTip(this.deweyPrefixNoBreak, "Don\'t break between any alpha prefix and the class number.");
            this.deweyPrefixNoBreak.UseVisualStyleBackColor = true;
            // 
            // Panel9
            // 
            this.Panel9.Controls.Add(this.Label77);
            this.Panel9.Controls.Add(this.deweyCutterBreak);
            this.Panel9.Controls.Add(this.deweyCutterNoBreak);
            this.Panel9.Location = new System.Drawing.Point(32, 88);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(280, 24);
            this.Panel9.TabIndex = 19;
            // 
            // Label77
            // 
            this.Label77.AutoSize = true;
            this.Label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label77.Location = new System.Drawing.Point(36, 8);
            this.Label77.Name = "Label77";
            this.Label77.Size = new System.Drawing.Size(45, 13);
            this.Label77.TabIndex = 9;
            this.Label77.Text = "Cutter:";
            // 
            // deweyCutterBreak
            // 
            this.deweyCutterBreak.AutoSize = true;
            this.deweyCutterBreak.Checked = true;
            this.deweyCutterBreak.Location = new System.Drawing.Point(164, 4);
            this.deweyCutterBreak.Name = "deweyCutterBreak";
            this.deweyCutterBreak.Size = new System.Drawing.Size(105, 17);
            this.deweyCutterBreak.TabIndex = 13;
            this.deweyCutterBreak.TabStop = true;
            this.deweyCutterBreak.Tag = "radio_deweycutterspacebreak";
            this.deweyCutterBreak.Text = "Break on spaces";
            this.ToolTip1.SetToolTip(this.deweyCutterBreak, "Break the cutter after each space.");
            this.deweyCutterBreak.UseVisualStyleBackColor = true;
            this.deweyCutterBreak.CheckedChanged += new System.EventHandler(this.deweyInCutterBreak_CheckedChanged);
            // 
            // deweyCutterNoBreak
            // 
            this.deweyCutterNoBreak.AutoSize = true;
            this.deweyCutterNoBreak.Location = new System.Drawing.Point(88, 4);
            this.deweyCutterNoBreak.Name = "deweyCutterNoBreak";
            this.deweyCutterNoBreak.Size = new System.Drawing.Size(69, 17);
            this.deweyCutterNoBreak.TabIndex = 12;
            this.deweyCutterNoBreak.Tag = "radio_deweycutterspacenobreak";
            this.deweyCutterNoBreak.Text = "No break";
            this.ToolTip1.SetToolTip(this.deweyCutterNoBreak, "Don\'t break before the Dewey cutter.");
            this.deweyCutterNoBreak.UseVisualStyleBackColor = true;
            // 
            // Panel11
            // 
            this.Panel11.Controls.Add(this.deweyDecimalBreakAft);
            this.Panel11.Controls.Add(this.Label79);
            this.Panel11.Controls.Add(this.deweyDecimalBreakb4);
            this.Panel11.Controls.Add(this.deweyDecimalNoBreak);
            this.Panel11.Location = new System.Drawing.Point(32, 44);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(356, 24);
            this.Panel11.TabIndex = 17;
            // 
            // deweyDecimalBreakAft
            // 
            this.deweyDecimalBreakAft.AutoSize = true;
            this.deweyDecimalBreakAft.Location = new System.Drawing.Point(260, 4);
            this.deweyDecimalBreakAft.Name = "deweyDecimalBreakAft";
            this.deweyDecimalBreakAft.Size = new System.Drawing.Size(85, 17);
            this.deweyDecimalBreakAft.TabIndex = 14;
            this.deweyDecimalBreakAft.Tag = "radio_deweydecbreakaft";
            this.deweyDecimalBreakAft.Text = "after decimal";
            this.ToolTip1.SetToolTip(this.deweyDecimalBreakAft, "Break the class number after the decimal point.");
            this.deweyDecimalBreakAft.UseVisualStyleBackColor = true;
            this.deweyDecimalBreakAft.CheckedChanged += new System.EventHandler(this.deweyDecimalBreakAft_CheckedChanged);
            // 
            // Label79
            // 
            this.Label79.AutoSize = true;
            this.Label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label79.Location = new System.Drawing.Point(40, 8);
            this.Label79.Name = "Label79";
            this.Label79.Size = new System.Drawing.Size(41, 13);
            this.Label79.TabIndex = 9;
            this.Label79.Text = "Class:";
            // 
            // deweyDecimalBreakb4
            // 
            this.deweyDecimalBreakb4.AutoSize = true;
            this.deweyDecimalBreakb4.Location = new System.Drawing.Point(164, 4);
            this.deweyDecimalBreakb4.Name = "deweyDecimalBreakb4";
            this.deweyDecimalBreakb4.Size = new System.Drawing.Size(98, 17);
            this.deweyDecimalBreakb4.TabIndex = 13;
            this.deweyDecimalBreakb4.Tag = "radio_deweydecbreakb4";
            this.deweyDecimalBreakb4.Text = "Break before or";
            this.ToolTip1.SetToolTip(this.deweyDecimalBreakb4, "Break the class number before the decimal point.");
            this.deweyDecimalBreakb4.UseVisualStyleBackColor = true;
            this.deweyDecimalBreakb4.CheckedChanged += new System.EventHandler(this.deweyDecimalBreak_CheckedChanged);
            // 
            // deweyDecimalNoBreak
            // 
            this.deweyDecimalNoBreak.AutoSize = true;
            this.deweyDecimalNoBreak.Checked = true;
            this.deweyDecimalNoBreak.Location = new System.Drawing.Point(88, 4);
            this.deweyDecimalNoBreak.Name = "deweyDecimalNoBreak";
            this.deweyDecimalNoBreak.Size = new System.Drawing.Size(69, 17);
            this.deweyDecimalNoBreak.TabIndex = 12;
            this.deweyDecimalNoBreak.TabStop = true;
            this.deweyDecimalNoBreak.Tag = "radio_deweydecnobreak";
            this.deweyDecimalNoBreak.Text = "No break";
            this.ToolTip1.SetToolTip(this.deweyDecimalNoBreak, "Don\'t break the class number (unless after a specific number of digits past the d" +
        "ecimal point)");
            this.deweyDecimalNoBreak.UseVisualStyleBackColor = true;
            this.deweyDecimalNoBreak.CheckedChanged += new System.EventHandler(this.deweyDecimalNoBreak_CheckedChanged);
            // 
            // TabPage10
            // 
            this.TabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage10.Controls.Add(this.sudocRemoveAfter);
            this.TabPage10.Controls.Add(this.sudocCharBreak);
            this.TabPage10.Controls.Add(this.Panel16);
            this.TabPage10.Controls.Add(this.sudocType);
            this.TabPage10.Controls.Add(this.Label109);
            this.TabPage10.Controls.Add(this.Panel10);
            this.TabPage10.Controls.Add(this.Panel3);
            this.TabPage10.Controls.Add(this.sudocBreakBeforeColon);
            this.TabPage10.Controls.Add(this.sudocBreakAfterColon);
            this.TabPage10.Controls.Add(this.sudocNoColonBreak);
            this.TabPage10.Controls.Add(this.Label67);
            this.TabPage10.Controls.Add(this.Panel4);
            this.TabPage10.Controls.Add(this.Panel2);
            this.TabPage10.Location = new System.Drawing.Point(4, 22);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Size = new System.Drawing.Size(496, 178);
            this.TabPage10.TabIndex = 3;
            this.TabPage10.Text = "SuDoc";
            // 
            // sudocRemoveAfter
            // 
            this.sudocRemoveAfter.AutoSize = true;
            this.sudocRemoveAfter.Location = new System.Drawing.Point(200, 156);
            this.sudocRemoveAfter.Name = "sudocRemoveAfter";
            this.sudocRemoveAfter.Size = new System.Drawing.Size(205, 17);
            this.sudocRemoveAfter.TabIndex = 56;
            this.sudocRemoveAfter.Tag = "check_sudocremoveafter";
            this.sudocRemoveAfter.Text = "Remove character(s) from call number";
            this.sudocRemoveAfter.UseVisualStyleBackColor = true;
            this.sudocRemoveAfter.CheckedChanged += new System.EventHandler(this.sudocRemoveAfter_CheckedChanged);
            // 
            // sudocCharBreak
            // 
            this.sudocCharBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.sudocCharBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudocCharBreak.Location = new System.Drawing.Point(412, 104);
            this.sudocCharBreak.Multiline = true;
            this.sudocCharBreak.Name = "sudocCharBreak";
            this.sudocCharBreak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sudocCharBreak.Size = new System.Drawing.Size(76, 72);
            this.sudocCharBreak.TabIndex = 55;
            this.sudocCharBreak.Tag = "text_sudocbreak";
            this.ToolTip1.SetToolTip(this.sudocCharBreak, "One or more characters or phrases that will cause a line break.");
            // 
            // Panel16
            // 
            this.Panel16.Controls.Add(this.sudocCharBreakAft);
            this.Panel16.Controls.Add(this.Label113);
            this.Panel16.Controls.Add(this.sudocCharBreakB4);
            this.Panel16.Controls.Add(this.sudocOtherNoBreak);
            this.Panel16.Location = new System.Drawing.Point(36, 132);
            this.Panel16.Name = "Panel16";
            this.Panel16.Size = new System.Drawing.Size(372, 24);
            this.Panel16.TabIndex = 54;
            this.Panel16.Tag = "";
            // 
            // sudocCharBreakAft
            // 
            this.sudocCharBreakAft.AutoSize = true;
            this.sudocCharBreakAft.Location = new System.Drawing.Point(260, 4);
            this.sudocCharBreakAft.Name = "sudocCharBreakAft";
            this.sudocCharBreakAft.Size = new System.Drawing.Size(108, 17);
            this.sudocCharBreakAft.TabIndex = 14;
            this.sudocCharBreakAft.Tag = "radio_sudoccharbreakaft";
            this.sudocCharBreakAft.Text = "after character(s):";
            this.sudocCharBreakAft.UseVisualStyleBackColor = true;
            // 
            // Label113
            // 
            this.Label113.AutoSize = true;
            this.Label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label113.Location = new System.Drawing.Point(44, 6);
            this.Label113.Name = "Label113";
            this.Label113.Size = new System.Drawing.Size(42, 13);
            this.Label113.TabIndex = 9;
            this.Label113.Text = "Other:";
            // 
            // sudocCharBreakB4
            // 
            this.sudocCharBreakB4.AutoSize = true;
            this.sudocCharBreakB4.Location = new System.Drawing.Point(164, 4);
            this.sudocCharBreakB4.Name = "sudocCharBreakB4";
            this.sudocCharBreakB4.Size = new System.Drawing.Size(98, 17);
            this.sudocCharBreakB4.TabIndex = 13;
            this.sudocCharBreakB4.Tag = "radio_sudoccharbreakb4";
            this.sudocCharBreakB4.Text = "Break before or";
            this.sudocCharBreakB4.UseVisualStyleBackColor = true;
            this.sudocCharBreakB4.CheckedChanged += new System.EventHandler(this.sudocCharBreakB4_CheckedChanged);
            // 
            // sudocOtherNoBreak
            // 
            this.sudocOtherNoBreak.AutoSize = true;
            this.sudocOtherNoBreak.Checked = true;
            this.sudocOtherNoBreak.Location = new System.Drawing.Point(88, 4);
            this.sudocOtherNoBreak.Name = "sudocOtherNoBreak";
            this.sudocOtherNoBreak.Size = new System.Drawing.Size(69, 17);
            this.sudocOtherNoBreak.TabIndex = 12;
            this.sudocOtherNoBreak.TabStop = true;
            this.sudocOtherNoBreak.Tag = "radio_sudoccharnobreak";
            this.sudocOtherNoBreak.Text = "No break";
            this.sudocOtherNoBreak.UseVisualStyleBackColor = true;
            this.sudocOtherNoBreak.CheckedChanged += new System.EventHandler(this.sudocOtherNoBreak_CheckedChanged);
            // 
            // sudocType
            // 
            this.sudocType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.sudocType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sudocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudocType.Location = new System.Drawing.Point(176, 4);
            this.sudocType.Name = "sudocType";
            this.sudocType.Size = new System.Drawing.Size(48, 13);
            this.sudocType.TabIndex = 53;
            this.sudocType.Tag = "text_sudoctype";
            this.sudocType.Text = "3";
            this.ToolTip1.SetToolTip(this.sudocType, "One or more call number types (separated by commas) that will be handled by this " +
        "parsing routine.");
            // 
            // Label109
            // 
            this.Label109.AutoSize = true;
            this.Label109.ForeColor = System.Drawing.Color.Blue;
            this.Label109.Location = new System.Drawing.Point(20, 4);
            this.Label109.Name = "Label109";
            this.Label109.Size = new System.Drawing.Size(150, 13);
            this.Label109.TabIndex = 52;
            this.Label109.Text = "Handles Call Number Type(s): ";
            // 
            // Panel10
            // 
            this.Panel10.Controls.Add(this.sudocNoBreakB4Numerics);
            this.Panel10.Controls.Add(this.sudocBreakB4Numerics);
            this.Panel10.Controls.Add(this.Label85);
            this.Panel10.Location = new System.Drawing.Point(20, 20);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(332, 24);
            this.Panel10.TabIndex = 51;
            // 
            // sudocNoBreakB4Numerics
            // 
            this.sudocNoBreakB4Numerics.AutoSize = true;
            this.sudocNoBreakB4Numerics.Checked = true;
            this.sudocNoBreakB4Numerics.Location = new System.Drawing.Point(104, 4);
            this.sudocNoBreakB4Numerics.Name = "sudocNoBreakB4Numerics";
            this.sudocNoBreakB4Numerics.Size = new System.Drawing.Size(69, 17);
            this.sudocNoBreakB4Numerics.TabIndex = 9;
            this.sudocNoBreakB4Numerics.TabStop = true;
            this.sudocNoBreakB4Numerics.Tag = "radio_sudocnobreakb4numerics";
            this.sudocNoBreakB4Numerics.Text = "No break";
            this.sudocNoBreakB4Numerics.UseVisualStyleBackColor = true;
            // 
            // sudocBreakB4Numerics
            // 
            this.sudocBreakB4Numerics.AutoSize = true;
            this.sudocBreakB4Numerics.Location = new System.Drawing.Point(180, 4);
            this.sudocBreakB4Numerics.Name = "sudocBreakB4Numerics";
            this.sudocBreakB4Numerics.Size = new System.Drawing.Size(131, 17);
            this.sudocBreakB4Numerics.TabIndex = 8;
            this.sudocBreakB4Numerics.Tag = "radio_sudocbreakb4numerics";
            this.sudocBreakB4Numerics.Text = "Break before numerics";
            this.sudocBreakB4Numerics.UseVisualStyleBackColor = true;
            this.sudocBreakB4Numerics.CheckedChanged += new System.EventHandler(this.sudocBreakB4Numerics_CheckedChanged);
            // 
            // Label85
            // 
            this.Label85.AutoSize = true;
            this.Label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label85.Location = new System.Drawing.Point(36, 8);
            this.Label85.Name = "Label85";
            this.Label85.Size = new System.Drawing.Size(63, 13);
            this.Label85.TabIndex = 7;
            this.Label85.Text = "Numerics:";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.sudocNoDecimalBreak);
            this.Panel3.Controls.Add(this.sudocBreakDecimal);
            this.Panel3.Controls.Add(this.Label69);
            this.Panel3.Location = new System.Drawing.Point(20, 44);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(332, 24);
            this.Panel3.TabIndex = 50;
            // 
            // sudocNoDecimalBreak
            // 
            this.sudocNoDecimalBreak.AutoSize = true;
            this.sudocNoDecimalBreak.Checked = true;
            this.sudocNoDecimalBreak.Location = new System.Drawing.Point(104, 4);
            this.sudocNoDecimalBreak.Name = "sudocNoDecimalBreak";
            this.sudocNoDecimalBreak.Size = new System.Drawing.Size(69, 17);
            this.sudocNoDecimalBreak.TabIndex = 9;
            this.sudocNoDecimalBreak.TabStop = true;
            this.sudocNoDecimalBreak.Tag = "radio_sudocnobrkdecimal";
            this.sudocNoDecimalBreak.Text = "No break";
            this.sudocNoDecimalBreak.UseVisualStyleBackColor = true;
            this.sudocNoDecimalBreak.CheckedChanged += new System.EventHandler(this.sudocNoDecimalBreak_CheckedChanged);
            // 
            // sudocBreakDecimal
            // 
            this.sudocBreakDecimal.AutoSize = true;
            this.sudocBreakDecimal.Location = new System.Drawing.Point(180, 4);
            this.sudocBreakDecimal.Name = "sudocBreakDecimal";
            this.sudocBreakDecimal.Size = new System.Drawing.Size(125, 17);
            this.sudocBreakDecimal.TabIndex = 8;
            this.sudocBreakDecimal.Tag = "radio_sudocbrkdecimal";
            this.sudocBreakDecimal.Text = "Break before decimal";
            this.sudocBreakDecimal.UseVisualStyleBackColor = true;
            // 
            // Label69
            // 
            this.Label69.AutoSize = true;
            this.Label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label69.Location = new System.Drawing.Point(44, 8);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(56, 13);
            this.Label69.TabIndex = 7;
            this.Label69.Text = "Decimal:";
            // 
            // sudocBreakBeforeColon
            // 
            this.sudocBreakBeforeColon.AutoSize = true;
            this.sudocBreakBeforeColon.Checked = true;
            this.sudocBreakBeforeColon.Location = new System.Drawing.Point(200, 68);
            this.sudocBreakBeforeColon.Name = "sudocBreakBeforeColon";
            this.sudocBreakBeforeColon.Size = new System.Drawing.Size(98, 17);
            this.sudocBreakBeforeColon.TabIndex = 45;
            this.sudocBreakBeforeColon.TabStop = true;
            this.sudocBreakBeforeColon.Tag = "radio_sudocbrkb4colon";
            this.sudocBreakBeforeColon.Text = "Break before or";
            this.sudocBreakBeforeColon.UseVisualStyleBackColor = true;
            this.sudocBreakBeforeColon.CheckedChanged += new System.EventHandler(this.sudocBreakBeforeColon_CheckedChanged_1);
            // 
            // sudocBreakAfterColon
            // 
            this.sudocBreakAfterColon.AutoSize = true;
            this.sudocBreakAfterColon.Location = new System.Drawing.Point(300, 68);
            this.sudocBreakAfterColon.Name = "sudocBreakAfterColon";
            this.sudocBreakAfterColon.Size = new System.Drawing.Size(75, 17);
            this.sudocBreakAfterColon.TabIndex = 46;
            this.sudocBreakAfterColon.Tag = "radio_sudocbrkaftercolon";
            this.sudocBreakAfterColon.Text = "after colon";
            this.sudocBreakAfterColon.UseVisualStyleBackColor = true;
            // 
            // sudocNoColonBreak
            // 
            this.sudocNoColonBreak.AutoSize = true;
            this.sudocNoColonBreak.Location = new System.Drawing.Point(124, 68);
            this.sudocNoColonBreak.Name = "sudocNoColonBreak";
            this.sudocNoColonBreak.Size = new System.Drawing.Size(69, 17);
            this.sudocNoColonBreak.TabIndex = 47;
            this.sudocNoColonBreak.Tag = "radio_sudoccolonnobrk";
            this.sudocNoColonBreak.Text = "No break";
            this.sudocNoColonBreak.UseVisualStyleBackColor = true;
            this.sudocNoColonBreak.CheckedChanged += new System.EventHandler(this.sudocNoColonBreak_CheckedChanged);
            // 
            // Label67
            // 
            this.Label67.AutoSize = true;
            this.Label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label67.Location = new System.Drawing.Point(76, 72);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(43, 13);
            this.Label67.TabIndex = 48;
            this.Label67.Text = "Colon:";
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.sudocDashNoBreak);
            this.Panel4.Controls.Add(this.sudocDashBreak);
            this.Panel4.Controls.Add(this.Label70);
            this.Panel4.Location = new System.Drawing.Point(8, 112);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(356, 24);
            this.Panel4.TabIndex = 51;
            // 
            // sudocDashNoBreak
            // 
            this.sudocDashNoBreak.AutoSize = true;
            this.sudocDashNoBreak.Location = new System.Drawing.Point(116, 4);
            this.sudocDashNoBreak.Name = "sudocDashNoBreak";
            this.sudocDashNoBreak.Size = new System.Drawing.Size(69, 17);
            this.sudocDashNoBreak.TabIndex = 7;
            this.sudocDashNoBreak.Tag = "radio_sudocdashnobrk";
            this.sudocDashNoBreak.Text = "No break";
            this.sudocDashNoBreak.UseVisualStyleBackColor = true;
            this.sudocDashNoBreak.CheckedChanged += new System.EventHandler(this.sudocDashNoBreak_CheckedChanged);
            // 
            // sudocDashBreak
            // 
            this.sudocDashBreak.AutoSize = true;
            this.sudocDashBreak.Checked = true;
            this.sudocDashBreak.Location = new System.Drawing.Point(192, 4);
            this.sudocDashBreak.Name = "sudocDashBreak";
            this.sudocDashBreak.Size = new System.Drawing.Size(137, 17);
            this.sudocDashBreak.TabIndex = 6;
            this.sudocDashBreak.TabStop = true;
            this.sudocDashBreak.Tag = "radio_sudocdashbrk";
            this.sudocDashBreak.Text = "Replace dash w/ break";
            this.sudocDashBreak.UseVisualStyleBackColor = true;
            // 
            // Label70
            // 
            this.Label70.AutoSize = true;
            this.Label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label70.Location = new System.Drawing.Point(0, 4);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(113, 13);
            this.Label70.TabIndex = 5;
            this.Label70.Text = "Dash (after colon):";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.sudocSlashNobreak);
            this.Panel2.Controls.Add(this.sudocSlashBreak);
            this.Panel2.Controls.Add(this.Label68);
            this.Panel2.Location = new System.Drawing.Point(0, 88);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(364, 24);
            this.Panel2.TabIndex = 49;
            // 
            // sudocSlashNobreak
            // 
            this.sudocSlashNobreak.AutoSize = true;
            this.sudocSlashNobreak.Location = new System.Drawing.Point(124, 4);
            this.sudocSlashNobreak.Name = "sudocSlashNobreak";
            this.sudocSlashNobreak.Size = new System.Drawing.Size(69, 17);
            this.sudocSlashNobreak.TabIndex = 8;
            this.sudocSlashNobreak.Tag = "radio_sudocslashnobrk";
            this.sudocSlashNobreak.Text = "No break";
            this.sudocSlashNobreak.UseVisualStyleBackColor = true;
            this.sudocSlashNobreak.CheckedChanged += new System.EventHandler(this.sudocSlashNobreak_CheckedChanged);
            // 
            // sudocSlashBreak
            // 
            this.sudocSlashBreak.AutoSize = true;
            this.sudocSlashBreak.Checked = true;
            this.sudocSlashBreak.Location = new System.Drawing.Point(200, 4);
            this.sudocSlashBreak.Name = "sudocSlashBreak";
            this.sudocSlashBreak.Size = new System.Drawing.Size(138, 17);
            this.sudocSlashBreak.TabIndex = 7;
            this.sudocSlashBreak.TabStop = true;
            this.sudocSlashBreak.Tag = "radio_sudocslashbrk";
            this.sudocSlashBreak.Text = "Replace slash w/ break";
            this.sudocSlashBreak.UseVisualStyleBackColor = true;
            // 
            // Label68
            // 
            this.Label68.AutoSize = true;
            this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label68.Location = new System.Drawing.Point(4, 8);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(115, 13);
            this.Label68.TabIndex = 6;
            this.Label68.Text = "Slash (after colon):";
            // 
            // TabPage11
            // 
            this.TabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage11.Controls.Add(this.otherType);
            this.TabPage11.Controls.Add(this.Label110);
            this.TabPage11.Controls.Add(this.otherRemoveAfter);
            this.TabPage11.Controls.Add(this.otherFirstSpaceBreak);
            this.TabPage11.Controls.Add(this.Panel13);
            this.TabPage11.Controls.Add(this.Panel12);
            this.TabPage11.Controls.Add(this.otherBreak);
            this.TabPage11.Controls.Add(this.otherAllSpaceBreak);
            this.TabPage11.Controls.Add(this.otherSpaceNoBreak);
            this.TabPage11.Controls.Add(this.Label80);
            this.TabPage11.Location = new System.Drawing.Point(4, 22);
            this.TabPage11.Name = "TabPage11";
            this.TabPage11.Size = new System.Drawing.Size(496, 178);
            this.TabPage11.TabIndex = 4;
            this.TabPage11.Text = "Other";
            // 
            // otherType
            // 
            this.otherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.otherType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherType.Location = new System.Drawing.Point(176, 4);
            this.otherType.Name = "otherType";
            this.otherType.Size = new System.Drawing.Size(52, 13);
            this.otherType.TabIndex = 27;
            this.otherType.Tag = "text_othertype";
            this.otherType.Text = "4,7,8";
            this.ToolTip1.SetToolTip(this.otherType, "One or more call number types (separated by commas) that will be handled by this " +
        "parsing routine.");
            // 
            // Label110
            // 
            this.Label110.AutoSize = true;
            this.Label110.ForeColor = System.Drawing.Color.Blue;
            this.Label110.Location = new System.Drawing.Point(20, 4);
            this.Label110.Name = "Label110";
            this.Label110.Size = new System.Drawing.Size(150, 13);
            this.Label110.TabIndex = 26;
            this.Label110.Text = "Handles Call Number Type(s): ";
            // 
            // otherRemoveAfter
            // 
            this.otherRemoveAfter.AutoSize = true;
            this.otherRemoveAfter.Location = new System.Drawing.Point(184, 104);
            this.otherRemoveAfter.Name = "otherRemoveAfter";
            this.otherRemoveAfter.Size = new System.Drawing.Size(205, 17);
            this.otherRemoveAfter.TabIndex = 24;
            this.otherRemoveAfter.Tag = "check_otherremoveafter";
            this.otherRemoveAfter.Text = "Remove character(s) from call number";
            this.otherRemoveAfter.UseVisualStyleBackColor = true;
            this.otherRemoveAfter.CheckedChanged += new System.EventHandler(this.otherRemoveAfter_CheckedChanged);
            // 
            // otherFirstSpaceBreak
            // 
            this.otherFirstSpaceBreak.AutoSize = true;
            this.otherFirstSpaceBreak.Location = new System.Drawing.Point(280, 40);
            this.otherFirstSpaceBreak.Name = "otherFirstSpaceBreak";
            this.otherFirstSpaceBreak.Size = new System.Drawing.Size(87, 17);
            this.otherFirstSpaceBreak.TabIndex = 16;
            this.otherFirstSpaceBreak.Tag = "radio_otherfirstspacebrk";
            this.otherFirstSpaceBreak.Text = "Break on first";
            this.otherFirstSpaceBreak.UseVisualStyleBackColor = true;
            // 
            // Panel13
            // 
            this.Panel13.Controls.Add(this.otherNumBreakAfter);
            this.Panel13.Controls.Add(this.otherNumBreakb4);
            this.Panel13.Controls.Add(this.othernumnobreak);
            this.Panel13.Controls.Add(this.Label83);
            this.Panel13.Location = new System.Drawing.Point(0, 56);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(376, 24);
            this.Panel13.TabIndex = 15;
            // 
            // otherNumBreakAfter
            // 
            this.otherNumBreakAfter.AutoSize = true;
            this.otherNumBreakAfter.Location = new System.Drawing.Point(280, 4);
            this.otherNumBreakAfter.Name = "otherNumBreakAfter";
            this.otherNumBreakAfter.Size = new System.Drawing.Size(77, 17);
            this.otherNumBreakAfter.TabIndex = 19;
            this.otherNumBreakAfter.Tag = "radio_othernumbrkafter";
            this.otherNumBreakAfter.Text = "Break after";
            this.otherNumBreakAfter.UseVisualStyleBackColor = true;
            // 
            // otherNumBreakb4
            // 
            this.otherNumBreakb4.AutoSize = true;
            this.otherNumBreakb4.Location = new System.Drawing.Point(184, 4);
            this.otherNumBreakb4.Name = "otherNumBreakb4";
            this.otherNumBreakb4.Size = new System.Drawing.Size(98, 17);
            this.otherNumBreakb4.TabIndex = 16;
            this.otherNumBreakb4.Tag = "radio_othernumbrkb4";
            this.otherNumBreakb4.Text = "Break before or";
            this.otherNumBreakb4.UseVisualStyleBackColor = true;
            this.otherNumBreakb4.CheckedChanged += new System.EventHandler(this.othernumbreakb4_CheckedChanged);
            // 
            // othernumnobreak
            // 
            this.othernumnobreak.AutoSize = true;
            this.othernumnobreak.Checked = true;
            this.othernumnobreak.Location = new System.Drawing.Point(108, 4);
            this.othernumnobreak.Name = "othernumnobreak";
            this.othernumnobreak.Size = new System.Drawing.Size(69, 17);
            this.othernumnobreak.TabIndex = 17;
            this.othernumnobreak.TabStop = true;
            this.othernumnobreak.Tag = "radio_othernumnobrk";
            this.othernumnobreak.Text = "No break";
            this.othernumnobreak.UseVisualStyleBackColor = true;
            this.othernumnobreak.CheckedChanged += new System.EventHandler(this.othernumnobreak_CheckedChanged);
            // 
            // Label83
            // 
            this.Label83.AutoSize = true;
            this.Label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label83.Location = new System.Drawing.Point(4, 8);
            this.Label83.Name = "Label83";
            this.Label83.Size = new System.Drawing.Size(98, 13);
            this.Label83.TabIndex = 18;
            this.Label83.Text = "Initial Numerics:";
            // 
            // Panel12
            // 
            this.Panel12.Controls.Add(this.otherListBreakAfter);
            this.Panel12.Controls.Add(this.otherListBreakb4);
            this.Panel12.Controls.Add(this.otherListNoBreak);
            this.Panel12.Controls.Add(this.Label81);
            this.Panel12.Location = new System.Drawing.Point(24, 80);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(368, 24);
            this.Panel12.TabIndex = 14;
            // 
            // otherListBreakAfter
            // 
            this.otherListBreakAfter.AutoSize = true;
            this.otherListBreakAfter.Location = new System.Drawing.Point(256, 4);
            this.otherListBreakAfter.Name = "otherListBreakAfter";
            this.otherListBreakAfter.Size = new System.Drawing.Size(108, 17);
            this.otherListBreakAfter.TabIndex = 12;
            this.otherListBreakAfter.Tag = "radio_otherbrkafter";
            this.otherListBreakAfter.Text = "after character(s):";
            this.otherListBreakAfter.UseVisualStyleBackColor = true;
            // 
            // otherListBreakb4
            // 
            this.otherListBreakb4.AutoSize = true;
            this.otherListBreakb4.Location = new System.Drawing.Point(160, 4);
            this.otherListBreakb4.Name = "otherListBreakb4";
            this.otherListBreakb4.Size = new System.Drawing.Size(98, 17);
            this.otherListBreakb4.TabIndex = 10;
            this.otherListBreakb4.Tag = "radio_otherbrkb4";
            this.otherListBreakb4.Text = "Break before or";
            this.otherListBreakb4.UseVisualStyleBackColor = true;
            this.otherListBreakb4.CheckedChanged += new System.EventHandler(this.otherListBreakb4_CheckedChanged);
            // 
            // otherListNoBreak
            // 
            this.otherListNoBreak.AutoSize = true;
            this.otherListNoBreak.Checked = true;
            this.otherListNoBreak.Location = new System.Drawing.Point(84, 4);
            this.otherListNoBreak.Name = "otherListNoBreak";
            this.otherListNoBreak.Size = new System.Drawing.Size(69, 17);
            this.otherListNoBreak.TabIndex = 11;
            this.otherListNoBreak.TabStop = true;
            this.otherListNoBreak.Tag = "radio_othernolistbrk";
            this.otherListNoBreak.Text = "No break";
            this.otherListNoBreak.UseVisualStyleBackColor = true;
            this.otherListNoBreak.CheckedChanged += new System.EventHandler(this.otherListNoBreak_CheckedChanged);
            // 
            // Label81
            // 
            this.Label81.AutoSize = true;
            this.Label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label81.Location = new System.Drawing.Point(36, 8);
            this.Label81.Name = "Label81";
            this.Label81.Size = new System.Drawing.Size(42, 13);
            this.Label81.TabIndex = 8;
            this.Label81.Text = "Other:";
            // 
            // otherBreak
            // 
            this.otherBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.otherBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBreak.Location = new System.Drawing.Point(396, 72);
            this.otherBreak.Multiline = true;
            this.otherBreak.Name = "otherBreak";
            this.otherBreak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otherBreak.Size = new System.Drawing.Size(88, 92);
            this.otherBreak.TabIndex = 9;
            this.otherBreak.Tag = "text_otherlist";
            this.ToolTip1.SetToolTip(this.otherBreak, "One or more characters or phrases that will cause a line break.");
            // 
            // otherAllSpaceBreak
            // 
            this.otherAllSpaceBreak.AutoSize = true;
            this.otherAllSpaceBreak.Checked = true;
            this.otherAllSpaceBreak.Location = new System.Drawing.Point(184, 40);
            this.otherAllSpaceBreak.Name = "otherAllSpaceBreak";
            this.otherAllSpaceBreak.Size = new System.Drawing.Size(81, 17);
            this.otherAllSpaceBreak.TabIndex = 5;
            this.otherAllSpaceBreak.TabStop = true;
            this.otherAllSpaceBreak.Tag = "radio_otherallspacebrk";
            this.otherAllSpaceBreak.Text = "Break on all";
            this.otherAllSpaceBreak.UseVisualStyleBackColor = true;
            this.otherAllSpaceBreak.CheckedChanged += new System.EventHandler(this.otherAllSpaceBreak_CheckedChanged);
            // 
            // otherSpaceNoBreak
            // 
            this.otherSpaceNoBreak.AutoSize = true;
            this.otherSpaceNoBreak.Location = new System.Drawing.Point(108, 40);
            this.otherSpaceNoBreak.Name = "otherSpaceNoBreak";
            this.otherSpaceNoBreak.Size = new System.Drawing.Size(69, 17);
            this.otherSpaceNoBreak.TabIndex = 6;
            this.otherSpaceNoBreak.Tag = "radio_othernospacebrk";
            this.otherSpaceNoBreak.Text = "No break";
            this.otherSpaceNoBreak.UseVisualStyleBackColor = true;
            this.otherSpaceNoBreak.CheckedChanged += new System.EventHandler(this.otherSpaceNoBreak_CheckedChanged);
            // 
            // Label80
            // 
            this.Label80.AutoSize = true;
            this.Label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label80.Location = new System.Drawing.Point(48, 44);
            this.Label80.Name = "Label80";
            this.Label80.Size = new System.Drawing.Size(53, 13);
            this.Label80.TabIndex = 7;
            this.Label80.Text = "Spaces:";
            // 
            // TabPage9
            // 
            this.TabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage9.Controls.Add(this.Label111);
            this.TabPage9.Controls.Add(this.Label62);
            this.TabPage9.Controls.Add(this.spaceBreak);
            this.TabPage9.Controls.Add(this.issueListBreakAfter);
            this.TabPage9.Controls.Add(this.issueListBreakB4);
            this.TabPage9.Controls.Add(this.issueListNoBreak);
            this.TabPage9.Controls.Add(this.issueRemoveAfter);
            this.TabPage9.Controls.Add(this.issueBreak);
            this.TabPage9.Controls.Add(this.BreakParen);
            this.TabPage9.Controls.Add(this.ProtectColon);
            this.TabPage9.Controls.Add(this.ColonBreak);
            this.TabPage9.ForeColor = System.Drawing.Color.Black;
            this.TabPage9.Location = new System.Drawing.Point(4, 22);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage9.Size = new System.Drawing.Size(496, 178);
            this.TabPage9.TabIndex = 5;
            this.TabPage9.Text = "Holdings";
            // 
            // Label111
            // 
            this.Label111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label111.Location = new System.Drawing.Point(96, 144);
            this.Label111.Name = "Label111";
            this.Label111.Size = new System.Drawing.Size(248, 20);
            this.Label111.TabIndex = 53;
            this.Label111.Text = "*Use tildes (~) to include leading or trailing spaces.";
            // 
            // Label62
            // 
            this.Label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label62.ForeColor = System.Drawing.Color.Blue;
            this.Label62.Location = new System.Drawing.Point(436, 80);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(16, 16);
            this.Label62.TabIndex = 52;
            this.Label62.Text = "*";
            // 
            // spaceBreak
            // 
            this.spaceBreak.AutoSize = true;
            this.spaceBreak.Location = new System.Drawing.Point(40, 60);
            this.spaceBreak.Name = "spaceBreak";
            this.spaceBreak.Size = new System.Drawing.Size(195, 17);
            this.spaceBreak.TabIndex = 51;
            this.spaceBreak.Tag = "check_holdingsspacebreak";
            this.spaceBreak.Text = "Break on spaces between elements";
            this.ToolTip1.SetToolTip(this.spaceBreak, "Break on spaces between holdings elements.");
            this.spaceBreak.UseVisualStyleBackColor = true;
            // 
            // issueListBreakAfter
            // 
            this.issueListBreakAfter.AutoSize = true;
            this.issueListBreakAfter.Location = new System.Drawing.Point(240, 84);
            this.issueListBreakAfter.Name = "issueListBreakAfter";
            this.issueListBreakAfter.Size = new System.Drawing.Size(108, 17);
            this.issueListBreakAfter.TabIndex = 50;
            this.issueListBreakAfter.Tag = "radio_issuebrkafter";
            this.issueListBreakAfter.Text = "after character(s):";
            this.issueListBreakAfter.UseVisualStyleBackColor = true;
            // 
            // issueListBreakB4
            // 
            this.issueListBreakB4.AutoSize = true;
            this.issueListBreakB4.Location = new System.Drawing.Point(144, 84);
            this.issueListBreakB4.Name = "issueListBreakB4";
            this.issueListBreakB4.Size = new System.Drawing.Size(98, 17);
            this.issueListBreakB4.TabIndex = 48;
            this.issueListBreakB4.Tag = "radio_issuebrkb4";
            this.issueListBreakB4.Text = "Break before or";
            this.issueListBreakB4.UseVisualStyleBackColor = true;
            // 
            // issueListNoBreak
            // 
            this.issueListNoBreak.AutoSize = true;
            this.issueListNoBreak.Checked = true;
            this.issueListNoBreak.Location = new System.Drawing.Point(40, 84);
            this.issueListNoBreak.Name = "issueListNoBreak";
            this.issueListNoBreak.Size = new System.Drawing.Size(101, 17);
            this.issueListNoBreak.TabIndex = 49;
            this.issueListNoBreak.TabStop = true;
            this.issueListNoBreak.Tag = "radio_issuenolistbrk";
            this.issueListNoBreak.Text = "No other breaks";
            this.issueListNoBreak.UseVisualStyleBackColor = true;
            // 
            // issueRemoveAfter
            // 
            this.issueRemoveAfter.AutoSize = true;
            this.issueRemoveAfter.Location = new System.Drawing.Point(144, 108);
            this.issueRemoveAfter.Name = "issueRemoveAfter";
            this.issueRemoveAfter.Size = new System.Drawing.Size(190, 17);
            this.issueRemoveAfter.TabIndex = 47;
            this.issueRemoveAfter.Tag = "check_issueremoveother";
            this.issueRemoveAfter.Text = "Remove character(s) from holdings";
            this.issueRemoveAfter.UseVisualStyleBackColor = true;
            // 
            // issueBreak
            // 
            this.issueBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.issueBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBreak.Location = new System.Drawing.Point(348, 80);
            this.issueBreak.Multiline = true;
            this.issueBreak.Name = "issueBreak";
            this.issueBreak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issueBreak.Size = new System.Drawing.Size(88, 84);
            this.issueBreak.TabIndex = 46;
            this.issueBreak.Tag = "text_issuelist";
            this.ToolTip1.SetToolTip(this.issueBreak, "One or more characters or phrases that will cause a line break.");
            // 
            // BreakParen
            // 
            this.BreakParen.AutoSize = true;
            this.BreakParen.Checked = true;
            this.BreakParen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BreakParen.Location = new System.Drawing.Point(40, 12);
            this.BreakParen.Name = "BreakParen";
            this.BreakParen.Size = new System.Drawing.Size(143, 17);
            this.BreakParen.TabIndex = 44;
            this.BreakParen.Tag = "check_issuebreakparen";
            this.BreakParen.Text = "Break on \"(\" in long lines";
            this.ToolTip1.SetToolTip(this.BreakParen, "Break on open parenthesis if line excedes max. characters");
            this.BreakParen.UseVisualStyleBackColor = true;
            // 
            // ProtectColon
            // 
            this.ProtectColon.AutoSize = true;
            this.ProtectColon.Checked = true;
            this.ProtectColon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProtectColon.Enabled = false;
            this.ProtectColon.Location = new System.Drawing.Point(144, 36);
            this.ProtectColon.Name = "ProtectColon";
            this.ProtectColon.Size = new System.Drawing.Size(210, 17);
            this.ProtectColon.TabIndex = 43;
            this.ProtectColon.Tag = "check_protectcolon";
            this.ProtectColon.Text = "...but leave it visible inside parentheses";
            this.ToolTip1.SetToolTip(this.ProtectColon, "Leave colon visible when inside parentheses");
            this.ProtectColon.UseVisualStyleBackColor = true;
            // 
            // ColonBreak
            // 
            this.ColonBreak.AutoSize = true;
            this.ColonBreak.Checked = true;
            this.ColonBreak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColonBreak.Location = new System.Drawing.Point(40, 36);
            this.ColonBreak.Name = "ColonBreak";
            this.ColonBreak.Size = new System.Drawing.Size(107, 17);
            this.ColonBreak.TabIndex = 42;
            this.ColonBreak.Tag = "check_issuebreakcolon";
            this.ColonBreak.Text = "Break on colon...";
            this.ToolTip1.SetToolTip(this.ColonBreak, "Break on colon");
            this.ColonBreak.UseVisualStyleBackColor = true;
            this.ColonBreak.CheckedChanged += new System.EventHandler(this.ColonBreak_CheckedChanged);
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label73.Location = new System.Drawing.Point(4, 4);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(448, 16);
            this.Label73.TabIndex = 37;
            this.Label73.Text = "Tweak and Test SpineOMatic\'s Call Number && Holdings Parsing";
            // 
            // Label71
            // 
            this.Label71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label71.ForeColor = System.Drawing.Color.White;
            this.Label71.Location = new System.Drawing.Point(504, 0);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(20, 20);
            this.Label71.TabIndex = 36;
            this.Label71.Text = "X";
            this.Label71.Click += new System.EventHandler(this.Label71_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.GroupBox2.Controls.Add(this.testComboBox);
            this.GroupBox2.Controls.Add(this.Label59);
            this.GroupBox2.Controls.Add(this.Label58);
            this.GroupBox2.Controls.Add(this.testCallNumType);
            this.GroupBox2.Controls.Add(this.btnTestParser);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(12, 244);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(508, 80);
            this.GroupBox2.TabIndex = 35;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Test parsing";
            // 
            // testComboBox
            // 
            this.testComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Items.AddRange(new object[] {
            "SD373 .M28 1950 [LC]",
            "QA 76.6 .J38 H674 2006 [LC]",
            "PZ7.M516353 Wi 2011 [LC child. lit]",
            "PZ7.R79835 Ham 1999b [LC child. lit]",
            "WL 108 H684d 1988 [NLM]",
            "WL 300 R797c 1973 [NLM]",
            "006.78 DREAM C552 [Dewey]",
            "658.9945 C245 2010/2 [Dewey]",
            "388.1446392 BAR [Dewey]",
            "HE 20.4002:AD 9/2 [SuDoc]",
            "D 101.11:11-5835-241-13 & P [SuDoc]",
            "Y 3.N 88:10/0868 [SuDoc]",
            "I 19.81:31099-H 6-TF-024/991 [SuDoc]",
            "PREX 3.10/4:SO 8/990/SH.2 [SuDoc]",
            "DVD 15035 MEDIA [Other]"});
            this.testComboBox.Location = new System.Drawing.Point(16, 20);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(252, 23);
            this.testComboBox.TabIndex = 37;
            this.testComboBox.SelectedIndexChanged += new System.EventHandler(this.testComboBox_SelectedIndexChanged);
            // 
            // Label59
            // 
            this.Label59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.Location = new System.Drawing.Point(320, 20);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(180, 52);
            this.Label59.TabIndex = 35;
            this.Label59.Text = "Enter a call number and a \'type,\' or select one of the samples provided. Click \'t" +
    "est\' to see how SpineOMatic will parse it. ";
            // 
            // Label58
            // 
            this.Label58.AutoSize = true;
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.Location = new System.Drawing.Point(12, 52);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(88, 13);
            this.Label58.TabIndex = 3;
            this.Label58.Text = "Call number type:";
            // 
            // testCallNumType
            // 
            this.testCallNumType.Location = new System.Drawing.Point(100, 48);
            this.testCallNumType.Name = "testCallNumType";
            this.testCallNumType.Size = new System.Drawing.Size(20, 20);
            this.testCallNumType.TabIndex = 2;
            this.testCallNumType.Text = "0";
            this.ToolTip1.SetToolTip(this.testCallNumType, "Optional call number type.");
            this.testCallNumType.TextChanged += new System.EventHandler(this.testCallNumType_TextChanged);
            // 
            // btnTestParser
            // 
            this.btnTestParser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestParser.Location = new System.Drawing.Point(276, 20);
            this.btnTestParser.Name = "btnTestParser";
            this.btnTestParser.Size = new System.Drawing.Size(40, 20);
            this.btnTestParser.TabIndex = 1;
            this.btnTestParser.Text = "test";
            this.ToolTip1.SetToolTip(this.btnTestParser, "Click to view how the call number will be parsed by SpineOMatic.");
            this.btnTestParser.UseVisualStyleBackColor = true;
            this.btnTestParser.Click += new System.EventHandler(this.btnTestParser_Click);
            // 
            // showFormatInfo
            // 
            this.showFormatInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showFormatInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showFormatInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.showFormatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFormatInfo.ForeColor = System.Drawing.Color.Blue;
            this.showFormatInfo.Location = new System.Drawing.Point(304, 172);
            this.showFormatInfo.Name = "showFormatInfo";
            this.showFormatInfo.Size = new System.Drawing.Size(64, 13);
            this.showFormatInfo.TabIndex = 61;
            this.showFormatInfo.Text = " these codes";
            this.showFormatInfo.Click += new System.EventHandler(this.showFormatInfo_Click);
            // 
            // FTPwarning2
            // 
            this.FTPwarning2.AutoSize = true;
            this.FTPwarning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTPwarning2.ForeColor = System.Drawing.Color.Red;
            this.FTPwarning2.Location = new System.Drawing.Point(156, 4);
            this.FTPwarning2.Name = "FTPwarning2";
            this.FTPwarning2.Size = new System.Drawing.Size(266, 15);
            this.FTPwarning2.TabIndex = 64;
            this.FTPwarning2.Text = "==>FTP printing does not support pocket labels.";
            this.FTPwarning2.Visible = false;
            // 
            // Label91
            // 
            this.Label91.Location = new System.Drawing.Point(180, 172);
            this.Label91.Name = "Label91";
            this.Label91.Size = new System.Drawing.Size(124, 16);
            this.Label91.TabIndex = 58;
            this.Label91.Text = "* Format by prefixing with";
            this.ToolTip1.SetToolTip(this.Label91, "Asterisked fields can be prefixed with formatting characters.");
            // 
            // chkUsePocketLabels
            // 
            this.chkUsePocketLabels.AutoSize = true;
            this.chkUsePocketLabels.Location = new System.Drawing.Point(432, 8);
            this.chkUsePocketLabels.Name = "chkUsePocketLabels";
            this.chkUsePocketLabels.Size = new System.Drawing.Size(94, 17);
            this.chkUsePocketLabels.TabIndex = 59;
            this.chkUsePocketLabels.Tag = "check_pocketLabels";
            this.chkUsePocketLabels.Text = "Pocket Labels";
            this.ToolTip1.SetToolTip(this.chkUsePocketLabels, "Create spine & pocket label sets.");
            this.chkUsePocketLabels.UseVisualStyleBackColor = true;
            this.chkUsePocketLabels.CheckedChanged += new System.EventHandler(this.chkUsePocketLabels_CheckedChanged);
            // 
            // nonFlagWrapWidth
            // 
            this.nonFlagWrapWidth.Location = new System.Drawing.Point(64, 228);
            this.nonFlagWrapWidth.Name = "nonFlagWrapWidth";
            this.nonFlagWrapWidth.Size = new System.Drawing.Size(24, 20);
            this.nonFlagWrapWidth.TabIndex = 53;
            this.nonFlagWrapWidth.Tag = "text_nonflagwrapwidth";
            this.nonFlagWrapWidth.Text = "1.0";
            this.nonFlagWrapWidth.Visible = false;
            // 
            // flagWrapWidth
            // 
            this.flagWrapWidth.Location = new System.Drawing.Point(36, 228);
            this.flagWrapWidth.Name = "flagWrapWidth";
            this.flagWrapWidth.Size = new System.Drawing.Size(24, 20);
            this.flagWrapWidth.TabIndex = 52;
            this.flagWrapWidth.Tag = "text_flagwrapwidth";
            this.flagWrapWidth.Text = "2.4";
            this.flagWrapWidth.Visible = false;
            // 
            // nonFlagDefaults
            // 
            this.nonFlagDefaults.Location = new System.Drawing.Point(28, 248);
            this.nonFlagDefaults.Name = "nonFlagDefaults";
            this.nonFlagDefaults.Size = new System.Drawing.Size(56, 20);
            this.nonFlagDefaults.TabIndex = 48;
            this.nonFlagDefaults.Tag = "text_nonflagdefaults";
            this.nonFlagDefaults.Text = "0.1|0.1|0.2|1.0|0.0|2.0|0.0|5|8|7|9|true|<call_number>\r\n<issue_level_description>" +
    "\r\n<current_date>\r\n<library_name>\r\n<location_name>";
            this.nonFlagDefaults.Visible = false;
            // 
            // flagDefaults
            // 
            this.flagDefaults.Location = new System.Drawing.Point(28, 268);
            this.flagDefaults.Name = "flagDefaults";
            this.flagDefaults.Size = new System.Drawing.Size(56, 20);
            this.flagDefaults.TabIndex = 47;
            this.flagDefaults.Tag = "text_flagdefaults";
            this.flagDefaults.Text = "0.5|0.1|0.2|2.7|0.0|7.0|0.0|1|4|30|50|false|!<barcode>\r\n~<location_name>\r\n%<call_" +
    "number>\r\n#<issue_level_description>\r\n~=<title>";
            this.flagDefaults.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.tweakTest);
            this.GroupBox1.Controls.Add(this.inOtherSource);
            this.GroupBox1.Controls.Add(this.chkIncludeOther);
            this.GroupBox1.Controls.Add(this.chkIncludeHoldings);
            this.GroupBox1.Controls.Add(this.radio_useSOMparsing);
            this.GroupBox1.Controls.Add(this.parsingSource);
            this.GroupBox1.Controls.Add(this.useExlibrisParsing);
            this.GroupBox1.Controls.Add(this.inCallNumSource);
            this.GroupBox1.Controls.Add(this.inIssueLevelSource);
            this.GroupBox1.Controls.Add(this.Label87);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(36, 52);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(460, 116);
            this.GroupBox1.TabIndex = 45;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Call Number Parsing Options";
            // 
            // tweakTest
            // 
            this.tweakTest.AutoSize = true;
            this.tweakTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweakTest.ForeColor = System.Drawing.Color.Blue;
            this.tweakTest.Location = new System.Drawing.Point(380, 64);
            this.tweakTest.Name = "tweakTest";
            this.tweakTest.Size = new System.Drawing.Size(73, 13);
            this.tweakTest.TabIndex = 50;
            this.tweakTest.Text = "Tweak && Test";
            this.ToolTip1.SetToolTip(this.tweakTest, "Lets you test SpineOMatic\'s parsing routines, and change parsing behavior.");
            this.tweakTest.Click += new System.EventHandler(this.tweakTest_Click);
            // 
            // inOtherSource
            // 
            this.inOtherSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inOtherSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOtherSource.Location = new System.Drawing.Point(132, 94);
            this.inOtherSource.Name = "inOtherSource";
            this.inOtherSource.Size = new System.Drawing.Size(228, 20);
            this.inOtherSource.TabIndex = 48;
            this.inOtherSource.Tag = "text_inothersource";
            this.ToolTip1.SetToolTip(this.inOtherSource, "Doubleclick to select an XML field.");
            this.inOtherSource.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // chkIncludeOther
            // 
            this.chkIncludeOther.AutoSize = true;
            this.chkIncludeOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeOther.Location = new System.Drawing.Point(8, 96);
            this.chkIncludeOther.Name = "chkIncludeOther";
            this.chkIncludeOther.Size = new System.Drawing.Size(124, 17);
            this.chkIncludeOther.TabIndex = 47;
            this.chkIncludeOther.Tag = "check_includeother";
            this.chkIncludeOther.Text = "Include other value *";
            this.ToolTip1.SetToolTip(this.chkIncludeOther, "Include any other XML element at the end of the spine label.");
            this.chkIncludeOther.UseVisualStyleBackColor = true;
            this.chkIncludeOther.CheckedChanged += new System.EventHandler(this.chkIncludeOther_CheckedChanged);
            // 
            // chkIncludeHoldings
            // 
            this.chkIncludeHoldings.AutoSize = true;
            this.chkIncludeHoldings.Checked = true;
            this.chkIncludeHoldings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeHoldings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeHoldings.Location = new System.Drawing.Point(8, 74);
            this.chkIncludeHoldings.Name = "chkIncludeHoldings";
            this.chkIncludeHoldings.Size = new System.Drawing.Size(103, 17);
            this.chkIncludeHoldings.TabIndex = 46;
            this.chkIncludeHoldings.Tag = "check_includeholdings";
            this.chkIncludeHoldings.Text = "Include holdings";
            this.ToolTip1.SetToolTip(this.chkIncludeHoldings, "Parse and include the holdings info on the spine label.");
            this.chkIncludeHoldings.UseVisualStyleBackColor = true;
            this.chkIncludeHoldings.CheckedChanged += new System.EventHandler(this.chkIncludeHoldings_CheckedChanged);
            // 
            // radio_useSOMparsing
            // 
            this.radio_useSOMparsing.AutoSize = true;
            this.radio_useSOMparsing.Checked = true;
            this.radio_useSOMparsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_useSOMparsing.Location = new System.Drawing.Point(8, 50);
            this.radio_useSOMparsing.Name = "radio_useSOMparsing";
            this.radio_useSOMparsing.Size = new System.Drawing.Size(123, 17);
            this.radio_useSOMparsing.TabIndex = 1;
            this.radio_useSOMparsing.TabStop = true;
            this.radio_useSOMparsing.Text = "SpineOMatic parsing";
            this.ToolTip1.SetToolTip(this.radio_useSOMparsing, "Let SpineOMatic parse the call number.");
            this.radio_useSOMparsing.UseVisualStyleBackColor = true;
            // 
            // parsingSource
            // 
            this.parsingSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parsingSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parsingSource.Location = new System.Drawing.Point(132, 24);
            this.parsingSource.Name = "parsingSource";
            this.parsingSource.Size = new System.Drawing.Size(228, 20);
            this.parsingSource.TabIndex = 44;
            this.parsingSource.Tag = "text_parsingsource";
            this.parsingSource.Text = "<parsed_call_number>";
            this.ToolTip1.SetToolTip(this.parsingSource, "Doubleclick to select an XML field.");
            this.parsingSource.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // useExlibrisParsing
            // 
            this.useExlibrisParsing.AutoSize = true;
            this.useExlibrisParsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useExlibrisParsing.Location = new System.Drawing.Point(8, 26);
            this.useExlibrisParsing.Name = "useExlibrisParsing";
            this.useExlibrisParsing.Size = new System.Drawing.Size(101, 17);
            this.useExlibrisParsing.TabIndex = 0;
            this.useExlibrisParsing.Tag = "radio_useexlibrisparsing";
            this.useExlibrisParsing.Text = "Ex Libris parsing";
            this.ToolTip1.SetToolTip(this.useExlibrisParsing, "Use the parsed call number provided by Ex Libris in the Alma XML record.");
            this.useExlibrisParsing.UseVisualStyleBackColor = true;
            this.useExlibrisParsing.CheckedChanged += new System.EventHandler(this.useExlibrisParsing_CheckedChanged);
            // 
            // inCallNumSource
            // 
            this.inCallNumSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inCallNumSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCallNumSource.Location = new System.Drawing.Point(132, 48);
            this.inCallNumSource.Name = "inCallNumSource";
            this.inCallNumSource.Size = new System.Drawing.Size(228, 20);
            this.inCallNumSource.TabIndex = 1;
            this.inCallNumSource.Tag = "text_callnumsource";
            this.inCallNumSource.Text = "<call_number>";
            this.ToolTip1.SetToolTip(this.inCallNumSource, "Doubleclick to select an XML field.");
            this.inCallNumSource.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // inIssueLevelSource
            // 
            this.inIssueLevelSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inIssueLevelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inIssueLevelSource.Location = new System.Drawing.Point(132, 71);
            this.inIssueLevelSource.Name = "inIssueLevelSource";
            this.inIssueLevelSource.Size = new System.Drawing.Size(228, 20);
            this.inIssueLevelSource.TabIndex = 3;
            this.inIssueLevelSource.Tag = "text_lcissuedescsource";
            this.inIssueLevelSource.Text = "<issue_level_description>";
            this.ToolTip1.SetToolTip(this.inIssueLevelSource, "Doubleclick to select an XML field.");
            this.inIssueLevelSource.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // Label87
            // 
            this.Label87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label87.Location = new System.Drawing.Point(356, 60);
            this.Label87.Name = "Label87";
            this.Label87.Size = new System.Drawing.Size(24, 24);
            this.Label87.TabIndex = 54;
            this.Label87.Text = "u";
            // 
            // FlagSlips
            // 
            this.FlagSlips.AutoSize = true;
            this.FlagSlips.Location = new System.Drawing.Point(84, 188);
            this.FlagSlips.Name = "FlagSlips";
            this.FlagSlips.Size = new System.Drawing.Size(90, 17);
            this.FlagSlips.TabIndex = 36;
            this.FlagSlips.Tag = "check_flagslips";
            this.FlagSlips.Text = "Print flag slips";
            this.ToolTip1.SetToolTip(this.FlagSlips, "Create flag slips for items that cannot have adhesive labels attached.");
            this.FlagSlips.UseVisualStyleBackColor = true;
            this.FlagSlips.CheckedChanged += new System.EventHandler(this.FlagSlips_CheckedChanged);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.Location = new System.Drawing.Point(4, 212);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(93, 13);
            this.Label33.TabIndex = 33;
            this.Label33.Text = "XML sources: *";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location = new System.Drawing.Point(4, 8);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(84, 16);
            this.Label28.TabIndex = 29;
            this.Label28.Text = "Label type:";
            // 
            // Spine
            // 
            this.Spine.AutoSize = true;
            this.Spine.Checked = true;
            this.Spine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spine.Location = new System.Drawing.Point(4, 30);
            this.Spine.Name = "Spine";
            this.Spine.Size = new System.Drawing.Size(65, 20);
            this.Spine.TabIndex = 27;
            this.Spine.TabStop = true;
            this.Spine.Tag = "radio_spine";
            this.Spine.Text = "Spine";
            this.ToolTip1.SetToolTip(this.Spine, "Create standard spine label");
            this.Spine.UseVisualStyleBackColor = true;
            this.Spine.CheckedChanged += new System.EventHandler(this.Spine_CheckedChanged);
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomLabel.Location = new System.Drawing.Point(4, 184);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(76, 20);
            this.CustomLabel.TabIndex = 28;
            this.CustomLabel.Tag = "radio_currper";
            this.CustomLabel.Text = "Custom";
            this.ToolTip1.SetToolTip(this.CustomLabel, "Create custom label using XML source names and/or free text.");
            this.CustomLabel.UseVisualStyleBackColor = true;
            this.CustomLabel.CheckedChanged += new System.EventHandler(this.CustomLabel_CheckedChanged);
            // 
            // CustomText
            // 
            this.CustomText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomText.Location = new System.Drawing.Point(100, 212);
            this.CustomText.Multiline = true;
            this.CustomText.Name = "CustomText";
            this.CustomText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomText.Size = new System.Drawing.Size(272, 112);
            this.CustomText.TabIndex = 32;
            this.CustomText.Tag = "text_custom";
            this.ToolTip1.SetToolTip(this.CustomText, "Enter XML source names, one per line, or doubleclick to select  XML fields.");
            this.CustomText.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // formatInfoPanel
            // 
            this.formatInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formatInfoPanel.Controls.Add(this.suppress3);
            this.formatInfoPanel.Controls.Add(this.suppress2);
            this.formatInfoPanel.Controls.Add(this.suppress1);
            this.formatInfoPanel.Controls.Add(this.wrapWidth);
            this.formatInfoPanel.Controls.Add(this.closeFormatInfo);
            this.formatInfoPanel.Controls.Add(this.Label45);
            this.formatInfoPanel.Location = new System.Drawing.Point(376, 131);
            this.formatInfoPanel.Name = "formatInfoPanel";
            this.formatInfoPanel.Size = new System.Drawing.Size(148, 197);
            this.formatInfoPanel.TabIndex = 63;
            this.formatInfoPanel.Visible = false;
            // 
            // suppress3
            // 
            this.suppress3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suppress3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppress3.Location = new System.Drawing.Point(108, 170);
            this.suppress3.Margin = new System.Windows.Forms.Padding(0);
            this.suppress3.Name = "suppress3";
            this.suppress3.Size = new System.Drawing.Size(32, 13);
            this.suppress3.TabIndex = 69;
            this.suppress3.Tag = "text_suppress3";
            this.suppress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.suppress3, "Suppress display if XML field has this value");
            // 
            // suppress2
            // 
            this.suppress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suppress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppress2.Location = new System.Drawing.Point(68, 170);
            this.suppress2.Margin = new System.Windows.Forms.Padding(0);
            this.suppress2.Name = "suppress2";
            this.suppress2.Size = new System.Drawing.Size(32, 13);
            this.suppress2.TabIndex = 68;
            this.suppress2.Tag = "text_suppress2";
            this.suppress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.suppress2, "Suppress display if XML field has this value");
            // 
            // suppress1
            // 
            this.suppress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suppress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppress1.Location = new System.Drawing.Point(28, 170);
            this.suppress1.Margin = new System.Windows.Forms.Padding(0);
            this.suppress1.Name = "suppress1";
            this.suppress1.Size = new System.Drawing.Size(32, 13);
            this.suppress1.TabIndex = 67;
            this.suppress1.Tag = "text_suppress1";
            this.suppress1.Text = "0";
            this.suppress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip1.SetToolTip(this.suppress1, "Suppress display if XML field has this value");
            // 
            // wrapWidth
            // 
            this.wrapWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wrapWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrapWidth.Location = new System.Drawing.Point(116, 45);
            this.wrapWidth.Name = "wrapWidth";
            this.wrapWidth.Size = new System.Drawing.Size(32, 13);
            this.wrapWidth.TabIndex = 51;
            this.wrapWidth.Tag = "";
            this.wrapWidth.Text = "1.0";
            this.ToolTip1.SetToolTip(this.wrapWidth, "The width used when wrapping with the \'=\' format code.");
            this.wrapWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericKeyPress);
            this.wrapWidth.Leave += new System.EventHandler(this.NumericLeave);
            // 
            // closeFormatInfo
            // 
            this.closeFormatInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeFormatInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.closeFormatInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeFormatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormatInfo.ForeColor = System.Drawing.Color.White;
            this.closeFormatInfo.Location = new System.Drawing.Point(131, 0);
            this.closeFormatInfo.Name = "closeFormatInfo";
            this.closeFormatInfo.Size = new System.Drawing.Size(16, 15);
            this.closeFormatInfo.TabIndex = 62;
            this.closeFormatInfo.Text = " X";
            this.closeFormatInfo.Click += new System.EventHandler(this.closeFormatInfo_Click);
            // 
            // Label45
            // 
            this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.Location = new System.Drawing.Point(6, 6);
            this.Label45.Margin = new System.Windows.Forms.Padding(3);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(140, 159);
            this.Label45.TabIndex = 43;
            this.Label45.Text = resources.GetString("Label45.Text");
            // 
            // spineDefaults
            // 
            this.spineDefaults.Location = new System.Drawing.Point(28, 288);
            this.spineDefaults.Name = "spineDefaults";
            this.spineDefaults.Size = new System.Drawing.Size(56, 20);
            this.spineDefaults.TabIndex = 65;
            this.spineDefaults.Tag = "text_spinedefaults";
            this.spineDefaults.Text = "0.1|0.1|0.2|1.0|0.0|2.0|0.0|5|8|7|9|true|";
            this.spineDefaults.Visible = false;
            // 
            // pocketDefaults
            // 
            this.pocketDefaults.Location = new System.Drawing.Point(28, 308);
            this.pocketDefaults.Name = "pocketDefaults";
            this.pocketDefaults.Size = new System.Drawing.Size(56, 20);
            this.pocketDefaults.TabIndex = 66;
            this.pocketDefaults.Tag = "text_pocketdefaults";
            this.pocketDefaults.Text = "0.1|0.1|0.2|1.0|0.0|2.0|0.0|5|8|7|9|true|";
            this.pocketDefaults.Visible = false;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage3.Controls.Add(this.Label57);
            this.TabPage3.Controls.Add(this.radio_useSystem);
            this.TabPage3.Controls.Add(this.radio_useLocal);
            this.TabPage3.Controls.Add(this.Label54);
            this.TabPage3.Controls.Add(this.Label44);
            this.TabPage3.Controls.Add(this.btn_saveALT);
            this.TabPage3.Controls.Add(this.btn_cancelALT);
            this.TabPage3.Controls.Add(this.btn_deleteALT);
            this.TabPage3.Controls.Add(this.btn_changeALT);
            this.TabPage3.Controls.Add(this.btn_addALT);
            this.TabPage3.Controls.Add(this.altText);
            this.TabPage3.Controls.Add(this.altURL);
            this.TabPage3.Controls.Add(this.Label8);
            this.TabPage3.Controls.Add(this.TextBox14);
            this.TabPage3.Controls.Add(this.TextBox13);
            this.TabPage3.Controls.Add(this.Label14);
            this.TabPage3.Controls.Add(this.Label13);
            this.TabPage3.Controls.Add(this.SaveAboveLC);
            this.TabPage3.Controls.Add(this.altList);
            this.TabPage3.Controls.Add(this.ComboBox1);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(528, 330);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Label Prefixes";
            // 
            // Label57
            // 
            this.Label57.AutoSize = true;
            this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label57.Location = new System.Drawing.Point(4, 8);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(106, 16);
            this.Label57.TabIndex = 31;
            this.Label57.Text = "Label Prefixes";
            // 
            // radio_useSystem
            // 
            this.radio_useSystem.AutoSize = true;
            this.radio_useSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_useSystem.Location = new System.Drawing.Point(120, 48);
            this.radio_useSystem.Name = "radio_useSystem";
            this.radio_useSystem.Size = new System.Drawing.Size(147, 17);
            this.radio_useSystem.TabIndex = 30;
            this.radio_useSystem.Tag = "radio_usesystem";
            this.radio_useSystem.Text = "Use system file, URL:";
            this.ToolTip1.SetToolTip(this.radio_useSystem, "Use the server\'s \"aboveLabel.txt\" file as the source of the Label Prefix text.");
            this.radio_useSystem.UseVisualStyleBackColor = true;
            this.radio_useSystem.CheckedChanged += new System.EventHandler(this.radio_useSystem_CheckedChanged);
            // 
            // radio_useLocal
            // 
            this.radio_useLocal.AutoSize = true;
            this.radio_useLocal.Checked = true;
            this.radio_useLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_useLocal.Location = new System.Drawing.Point(120, 28);
            this.radio_useLocal.Name = "radio_useLocal";
            this.radio_useLocal.Size = new System.Drawing.Size(99, 17);
            this.radio_useLocal.TabIndex = 29;
            this.radio_useLocal.TabStop = true;
            this.radio_useLocal.Tag = "radio_useLocal";
            this.radio_useLocal.Text = "Use local file";
            this.ToolTip1.SetToolTip(this.radio_useLocal, "Use the local \"myLabelText.txt\" file as the source of the Label Prefix text.");
            this.radio_useLocal.UseVisualStyleBackColor = true;
            this.radio_useLocal.CheckedChanged += new System.EventHandler(this.radio_useLocal_CheckedChanged);
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.ForeColor = System.Drawing.Color.Gray;
            this.Label54.Location = new System.Drawing.Point(12, 256);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(202, 13);
            this.Label54.TabIndex = 28;
            this.Label54.Text = "Double click an entry to change or delete";
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location = new System.Drawing.Point(12, 76);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(296, 16);
            this.Label44.TabIndex = 27;
            this.Label44.Text = "Enter:  Library Name+Location Name=Label Text";
            // 
            // btn_saveALT
            // 
            this.btn_saveALT.ForeColor = System.Drawing.Color.Black;
            this.btn_saveALT.Location = new System.Drawing.Point(452, 212);
            this.btn_saveALT.Name = "btn_saveALT";
            this.btn_saveALT.Size = new System.Drawing.Size(64, 40);
            this.btn_saveALT.TabIndex = 26;
            this.btn_saveALT.Text = "Save Changes";
            this.ToolTip1.SetToolTip(this.btn_saveALT, "Write the table to local PC file \"myLabelText.txt\"");
            this.btn_saveALT.UseVisualStyleBackColor = true;
            this.btn_saveALT.Click += new System.EventHandler(this.btn_saveALT_Click);
            // 
            // btn_cancelALT
            // 
            this.btn_cancelALT.Location = new System.Drawing.Point(456, 164);
            this.btn_cancelALT.Name = "btn_cancelALT";
            this.btn_cancelALT.Size = new System.Drawing.Size(52, 20);
            this.btn_cancelALT.TabIndex = 25;
            this.btn_cancelALT.Text = "Cancel";
            this.ToolTip1.SetToolTip(this.btn_cancelALT, "Cancel a double click and empy the yellow input box");
            this.btn_cancelALT.UseVisualStyleBackColor = true;
            this.btn_cancelALT.Click += new System.EventHandler(this.btn_cancelALT_Click);
            // 
            // btn_deleteALT
            // 
            this.btn_deleteALT.Enabled = false;
            this.btn_deleteALT.Location = new System.Drawing.Point(456, 140);
            this.btn_deleteALT.Name = "btn_deleteALT";
            this.btn_deleteALT.Size = new System.Drawing.Size(52, 20);
            this.btn_deleteALT.TabIndex = 24;
            this.btn_deleteALT.Text = "Delete";
            this.ToolTip1.SetToolTip(this.btn_deleteALT, "Delete an entry from the table that was double clicked into the yellow input box");
            this.btn_deleteALT.UseVisualStyleBackColor = true;
            this.btn_deleteALT.Click += new System.EventHandler(this.btn_deleteALT_Click);
            // 
            // btn_changeALT
            // 
            this.btn_changeALT.Enabled = false;
            this.btn_changeALT.Location = new System.Drawing.Point(456, 116);
            this.btn_changeALT.Name = "btn_changeALT";
            this.btn_changeALT.Size = new System.Drawing.Size(52, 20);
            this.btn_changeALT.TabIndex = 23;
            this.btn_changeALT.Text = "Change";
            this.ToolTip1.SetToolTip(this.btn_changeALT, "Change the table entry that was double clicked and modified in the yellow input b" +
        "ox");
            this.btn_changeALT.UseVisualStyleBackColor = true;
            this.btn_changeALT.Click += new System.EventHandler(this.btn_changeALT_Click);
            // 
            // btn_addALT
            // 
            this.btn_addALT.Location = new System.Drawing.Point(456, 92);
            this.btn_addALT.Name = "btn_addALT";
            this.btn_addALT.Size = new System.Drawing.Size(52, 20);
            this.btn_addALT.TabIndex = 22;
            this.btn_addALT.Text = "Add";
            this.ToolTip1.SetToolTip(this.btn_addALT, "Add the entry in the yellow input box to the table");
            this.btn_addALT.UseVisualStyleBackColor = true;
            this.btn_addALT.Click += new System.EventHandler(this.btn_addALT_Click);
            // 
            // altText
            // 
            this.altText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.altText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altText.Location = new System.Drawing.Point(12, 92);
            this.altText.Name = "altText";
            this.altText.Size = new System.Drawing.Size(436, 21);
            this.altText.TabIndex = 21;
            this.ToolTip1.SetToolTip(this.altText, "Enter library+location=label text");
            // 
            // altURL
            // 
            this.altURL.BackColor = System.Drawing.Color.White;
            this.altURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.altURL.Location = new System.Drawing.Point(272, 48);
            this.altURL.Name = "altURL";
            this.altURL.Size = new System.Drawing.Size(168, 13);
            this.altURL.TabIndex = 20;
            this.altURL.Tag = "text_abovelabeltexturl";
            this.ToolTip1.SetToolTip(this.altURL, "URL to the web directory containing the \"aboveLabelText.txt\" file");
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(244, 260);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(37, 13);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Show:";
            // 
            // TextBox14
            // 
            this.TextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox14.Location = new System.Drawing.Point(336, 292);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.Size = new System.Drawing.Size(112, 20);
            this.TextBox14.TabIndex = 15;
            this.TextBox14.Tag = "text_locsource";
            this.TextBox14.Text = "<location_name>";
            this.ToolTip1.SetToolTip(this.TextBox14, "XML Source field containing the location name");
            this.TextBox14.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // TextBox13
            // 
            this.TextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox13.Location = new System.Drawing.Point(96, 292);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.Size = new System.Drawing.Size(120, 20);
            this.TextBox13.TabIndex = 14;
            this.TextBox13.Tag = "text_libsource";
            this.TextBox13.Text = "<library_name>";
            this.ToolTip1.SetToolTip(this.TextBox13, "XML Source field containing the library name");
            this.TextBox13.DoubleClick += new System.EventHandler(this.xmlLoad);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(244, 296);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(86, 13);
            this.Label14.TabIndex = 13;
            this.Label14.Text = "Location source:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(16, 296);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(76, 13);
            this.Label13.TabIndex = 12;
            this.Label13.Text = "Library source:";
            // 
            // SaveAboveLC
            // 
            this.SaveAboveLC.Location = new System.Drawing.Point(450, 44);
            this.SaveAboveLC.Name = "SaveAboveLC";
            this.SaveAboveLC.Size = new System.Drawing.Size(64, 20);
            this.SaveAboveLC.TabIndex = 10;
            this.SaveAboveLC.Text = "Download";
            this.ToolTip1.SetToolTip(this.SaveAboveLC, "Download the latest \"aboveLabel.txt\" file from the specified URL");
            this.SaveAboveLC.UseVisualStyleBackColor = true;
            this.SaveAboveLC.Click += new System.EventHandler(this.SaveAboveLC_Click);
            // 
            // altList
            // 
            this.altList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altList.FormattingEnabled = true;
            this.altList.ItemHeight = 15;
            this.altList.Location = new System.Drawing.Point(12, 116);
            this.altList.Name = "altList";
            this.altList.Size = new System.Drawing.Size(436, 139);
            this.altList.Sorted = true;
            this.altList.TabIndex = 5;
            this.ToolTip1.SetToolTip(this.altList, "Displays list of libraries, locations, and optional Above LC Label Text");
            this.altList.DoubleClick += new System.EventHandler(this.altList_DoubleClick);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "All Libraries",
            "Bapst",
            "Burns",
            "Burns - Archives",
            "Educational Resource Center",
            "Law",
            "O\'Neill",
            "Social Work Library",
            "Theology and Ministry Library"});
            this.ComboBox1.Location = new System.Drawing.Point(288, 256);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(160, 21);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.Text = "All Libraries";
            this.ToolTip1.SetToolTip(this.ComboBox1, "Filter the table by library name");
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage4.Controls.Add(this.btnDocDownload);
            this.TabPage4.Controls.Add(this.PictureBox1);
            this.TabPage4.Controls.Add(this.chkXMLWarning);
            this.TabPage4.Controls.Add(this.RichTextBox1);
            this.TabPage4.Controls.Add(this.lbl_copyXMLtext);
            this.TabPage4.Controls.Add(this.includeSettings);
            this.TabPage4.Controls.Add(this.xmlCopyDone);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(528, 330);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Current XML";
            // 
            // btnDocDownload
            // 
            this.btnDocDownload.Location = new System.Drawing.Point(296, 86);
            this.btnDocDownload.Name = "btnDocDownload";
            this.btnDocDownload.Size = new System.Drawing.Size(176, 40);
            this.btnDocDownload.TabIndex = 37;
            this.btnDocDownload.Text = "View the SpineOMatic Wiki";
            this.ToolTip1.SetToolTip(this.btnDocDownload, "Downloads documentation and displays it in MS Word");
            this.btnDocDownload.UseVisualStyleBackColor = true;
            this.btnDocDownload.Visible = false;
            this.btnDocDownload.Click += new System.EventHandler(this.btnDocDownload_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImage = global::SpineLabeler.My.Resources.Resources.somBkgrnd;
            this.PictureBox1.Location = new System.Drawing.Point(4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(520, 320);
            this.PictureBox1.TabIndex = 36;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // chkXMLWarning
            // 
            this.chkXMLWarning.AutoSize = true;
            this.chkXMLWarning.Location = new System.Drawing.Point(4, 4);
            this.chkXMLWarning.Name = "chkXMLWarning";
            this.chkXMLWarning.Size = new System.Drawing.Size(133, 17);
            this.chkXMLWarning.TabIndex = 38;
            this.chkXMLWarning.Tag = "check_xmlwarning";
            this.chkXMLWarning.Text = "Stop on XML warnings";
            this.ToolTip1.SetToolTip(this.chkXMLWarning, "When checked, displays which XML field caused an error.");
            this.chkXMLWarning.UseVisualStyleBackColor = true;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox1.ForeColor = System.Drawing.Color.Red;
            this.RichTextBox1.Location = new System.Drawing.Point(4, 24);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(520, 288);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // lbl_copyXMLtext
            // 
            this.lbl_copyXMLtext.AutoSize = true;
            this.lbl_copyXMLtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyXMLtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_copyXMLtext.Location = new System.Drawing.Point(244, 4);
            this.lbl_copyXMLtext.Name = "lbl_copyXMLtext";
            this.lbl_copyXMLtext.Size = new System.Drawing.Size(114, 13);
            this.lbl_copyXMLtext.TabIndex = 40;
            this.lbl_copyXMLtext.Text = "Copy XML to clipboard";
            this.ToolTip1.SetToolTip(this.lbl_copyXMLtext, "Click to copy the Current XML text to the Windows clipboard.");
            this.lbl_copyXMLtext.Click += new System.EventHandler(this.lbl_copyXMLtext_Click);
            // 
            // includeSettings
            // 
            this.includeSettings.AutoSize = true;
            this.includeSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.includeSettings.Location = new System.Drawing.Point(360, 4);
            this.includeSettings.Name = "includeSettings";
            this.includeSettings.Size = new System.Drawing.Size(100, 17);
            this.includeSettings.TabIndex = 41;
            this.includeSettings.Tag = "chk_includesettings";
            this.includeSettings.Text = "Include settings";
            this.ToolTip1.SetToolTip(this.includeSettings, "Check to add the text of the \'settings.som\' file to the Current XML text when cop" +
        "ying to the clipboard.");
            this.includeSettings.UseVisualStyleBackColor = true;
            this.includeSettings.CheckedChanged += new System.EventHandler(this.includeSettings_CheckedChanged);
            // 
            // xmlCopyDone
            // 
            this.xmlCopyDone.Location = new System.Drawing.Point(464, 8);
            this.xmlCopyDone.Name = "xmlCopyDone";
            this.xmlCopyDone.Size = new System.Drawing.Size(60, 12);
            this.xmlCopyDone.TabIndex = 42;
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage5.Controls.Add(this.dontConvert);
            this.TabPage5.Controls.Add(this.xmlShell);
            this.TabPage5.Controls.Add(this.Label134);
            this.TabPage5.Controls.Add(this.Label131);
            this.TabPage5.Controls.Add(this.apiMethod);
            this.TabPage5.Controls.Add(this.Label130);
            this.TabPage5.Controls.Add(this.Label129);
            this.TabPage5.Controls.Add(this.apiKey);
            this.TabPage5.Controls.Add(this.apiURL);
            this.TabPage5.Controls.Add(this.UseRestfulApi);
            this.TabPage5.Controls.Add(this.ispList);
            this.TabPage5.Controls.Add(this.updatePath);
            this.TabPage5.Controls.Add(this.configText);
            this.TabPage5.Controls.Add(this.logEdits);
            this.TabPage5.Controls.Add(this.XMLPath);
            this.TabPage5.Controls.Add(this.btnMonitor);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(528, 330);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Alma Access";
            // 
            // dontConvert
            // 
            this.dontConvert.AutoSize = true;
            this.dontConvert.Location = new System.Drawing.Point(324, 67);
            this.dontConvert.Name = "dontConvert";
            this.dontConvert.Size = new System.Drawing.Size(115, 17);
            this.dontConvert.TabIndex = 72;
            this.dontConvert.Tag = "";
            this.dontConvert.Text = "Don\'t convert XML";
            this.ToolTip1.SetToolTip(this.dontConvert, "Check this box only to view the RESTful XML in the \'Current XML\' tab.");
            this.dontConvert.UseVisualStyleBackColor = true;
            this.dontConvert.CheckedChanged += new System.EventHandler(this.dontConvert_CheckedChanged);
            // 
            // xmlShell
            // 
            this.xmlShell.Location = new System.Drawing.Point(448, 63);
            this.xmlShell.Multiline = true;
            this.xmlShell.Name = "xmlShell";
            this.xmlShell.Size = new System.Drawing.Size(72, 60);
            this.xmlShell.TabIndex = 70;
            this.xmlShell.Text = resources.GetString("xmlShell.Text");
            this.xmlShell.Visible = false;
            // 
            // Label134
            // 
            this.Label134.AutoSize = true;
            this.Label134.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label134.Location = new System.Drawing.Point(140, 67);
            this.Label134.Name = "Label134";
            this.Label134.Size = new System.Drawing.Size(95, 13);
            this.Label134.TabIndex = 69;
            this.Label134.Text = "(Java not required)";
            // 
            // Label131
            // 
            this.Label131.AutoSize = true;
            this.Label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label131.Location = new System.Drawing.Point(88, 111);
            this.Label131.Name = "Label131";
            this.Label131.Size = new System.Drawing.Size(52, 15);
            this.Label131.TabIndex = 66;
            this.Label131.Text = "Method:";
            // 
            // apiMethod
            // 
            this.apiMethod.Location = new System.Drawing.Point(144, 111);
            this.apiMethod.Name = "apiMethod";
            this.apiMethod.Size = new System.Drawing.Size(296, 20);
            this.apiMethod.TabIndex = 65;
            this.apiMethod.Tag = "text_restfulmethod";
            this.apiMethod.Text = "/almaws/v1/items?view=label&item_barcode={item_barcode}";
            this.ToolTip1.SetToolTip(this.apiMethod, "Method to obtain item info using RESTful API");
            // 
            // Label130
            // 
            this.Label130.AutoSize = true;
            this.Label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label130.Location = new System.Drawing.Point(68, 87);
            this.Label130.Name = "Label130";
            this.Label130.Size = new System.Drawing.Size(70, 15);
            this.Label130.TabIndex = 64;
            this.Label130.Text = "ALMA URL:";
            // 
            // Label129
            // 
            this.Label129.AutoSize = true;
            this.Label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label129.Location = new System.Drawing.Point(88, 135);
            this.Label129.Name = "Label129";
            this.Label129.Size = new System.Drawing.Size(51, 15);
            this.Label129.TabIndex = 63;
            this.Label129.Text = "API Key:";
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(144, 135);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(296, 20);
            this.apiKey.TabIndex = 62;
            this.apiKey.Tag = "texo_restfulapikey";
            this.apiKey.Text = "--Your Ex Libris API Key goes here --";
            this.ToolTip1.SetToolTip(this.apiKey, "Your API key (from Developer\'s Network)");
            // 
            // apiURL
            // 
            this.apiURL.Location = new System.Drawing.Point(144, 87);
            this.apiURL.Name = "apiURL";
            this.apiURL.Size = new System.Drawing.Size(296, 20);
            this.apiURL.TabIndex = 61;
            this.apiURL.Tag = "text_restfulalmaurl";
            this.apiURL.Text = "https://--your Alma server address goes here--";
            this.ToolTip1.SetToolTip(this.apiURL, "https:// your alma server .com");
            // 
            // UseRestfulApi
            // 
            this.UseRestfulApi.AutoSize = true;
            this.UseRestfulApi.Checked = true;
            this.UseRestfulApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseRestfulApi.Location = new System.Drawing.Point(4, 63);
            this.UseRestfulApi.Name = "UseRestfulApi";
            this.UseRestfulApi.Size = new System.Drawing.Size(131, 19);
            this.UseRestfulApi.TabIndex = 60;
            this.UseRestfulApi.TabStop = true;
            this.UseRestfulApi.Tag = "radio_useRESTful";
            this.UseRestfulApi.Text = "Use RESTful API";
            this.UseRestfulApi.UseVisualStyleBackColor = true;
            this.UseRestfulApi.CheckedChanged += new System.EventHandler(this.UseRestfulApi_CheckedChanged);
            // 
            // ispList
            // 
            this.ispList.FormattingEnabled = true;
            this.ispList.Location = new System.Drawing.Point(448, 123);
            this.ispList.Name = "ispList";
            this.ispList.Size = new System.Drawing.Size(72, 17);
            this.ispList.Sorted = true;
            this.ispList.TabIndex = 59;
            this.ispList.Visible = false;
            // 
            // updatePath
            // 
            this.updatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePath.Location = new System.Drawing.Point(284, 164);
            this.updatePath.Name = "updatePath";
            this.updatePath.Size = new System.Drawing.Size(236, 20);
            this.updatePath.TabIndex = 58;
            this.updatePath.Tag = "texo_updatepath";
            this.updatePath.Text = "http://arc.bc.edu:8080/Getfile/get?file=";
            this.updatePath.Visible = false;
            this.updatePath.TextChanged += new System.EventHandler(this.UpdatePath_TextChanged);
            // 
            // configText
            // 
            this.configText.Location = new System.Drawing.Point(4, 140);
            this.configText.Multiline = true;
            this.configText.Name = "configText";
            this.configText.Size = new System.Drawing.Size(32, 32);
            this.configText.TabIndex = 39;
            this.configText.Visible = false;
            // 
            // logEdits
            // 
            this.logEdits.Location = new System.Drawing.Point(448, 147);
            this.logEdits.Name = "logEdits";
            this.logEdits.Size = new System.Drawing.Size(68, 17);
            this.logEdits.TabIndex = 38;
            this.logEdits.Tag = "check_logedits";
            this.logEdits.Text = "Log manual call number edits";
            this.ToolTip1.SetToolTip(this.logEdits, "Check to log manual changes to spine labels");
            this.logEdits.UseVisualStyleBackColor = true;
            this.logEdits.Visible = false;
            // 
            // XMLPath
            // 
            this.XMLPath.Location = new System.Drawing.Point(480, 39);
            this.XMLPath.Name = "XMLPath";
            this.XMLPath.Size = new System.Drawing.Size(40, 20);
            this.XMLPath.TabIndex = 0;
            this.XMLPath.TabStop = false;
            this.XMLPath.Tag = "text_monitorfolder";
            this.ToolTip1.SetToolTip(this.XMLPath, "Folder on local PC to receive Alma XML (C:/spine or similar)");
            this.XMLPath.Visible = false;
            this.XMLPath.TextChanged += new System.EventHandler(this.XMLPath_TextChanged);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(4, 115);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(39, 20);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.TabStop = false;
            this.btnMonitor.Text = "Use";
            this.ToolTip1.SetToolTip(this.btnMonitor, "Tell the java app and the local PC to communicate via this folder");
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Visible = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TabPage6.Controls.Add(this.showIsp);
            this.TabPage6.Controls.Add(this.chkAddHostname);
            this.TabPage6.Controls.Add(this.copyDone);
            this.TabPage6.Controls.Add(this.lbl_setclipboard);
            this.TabPage6.Controls.Add(this.chkGeoList);
            this.TabPage6.Controls.Add(this.inclScanned);
            this.TabPage6.Controls.Add(this.Label61);
            this.TabPage6.Controls.Add(this.Label60);
            this.TabPage6.Controls.Add(this.sortBox);
            this.TabPage6.Controls.Add(this.sortSTL);
            this.TabPage6.Controls.Add(this.radioByLocation);
            this.TabPage6.Controls.Add(this.Label56);
            this.TabPage6.Controls.Add(this.searchArg);
            this.TabPage6.Controls.Add(this.radioSearch);
            this.TabPage6.Controls.Add(this.statsOut);
            this.TabPage6.Controls.Add(this.radioByLibrary);
            this.TabPage6.Controls.Add(this.radioByUser);
            this.TabPage6.Controls.Add(this.btnScan);
            this.TabPage6.Controls.Add(this.STL);
            this.TabPage6.Controls.Add(this.Label55);
            this.TabPage6.Controls.Add(this.Label9);
            this.TabPage6.Controls.Add(this.toScan);
            this.TabPage6.Controls.Add(this.fromScan);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(528, 330);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Reports";
            // 
            // showIsp
            // 
            this.showIsp.AutoSize = true;
            this.showIsp.Location = new System.Drawing.Point(428, 80);
            this.showIsp.Name = "showIsp";
            this.showIsp.Size = new System.Drawing.Size(40, 17);
            this.showIsp.TabIndex = 25;
            this.showIsp.Text = "Isp";
            this.showIsp.UseVisualStyleBackColor = true;
            // 
            // chkAddHostname
            // 
            this.chkAddHostname.AutoSize = true;
            this.chkAddHostname.Location = new System.Drawing.Point(300, 80);
            this.chkAddHostname.Name = "chkAddHostname";
            this.chkAddHostname.Size = new System.Drawing.Size(74, 17);
            this.chkAddHostname.TabIndex = 24;
            this.chkAddHostname.Text = "Hostname";
            this.chkAddHostname.UseVisualStyleBackColor = true;
            this.chkAddHostname.Visible = false;
            this.chkAddHostname.CheckedChanged += new System.EventHandler(this.chkAddHostname_CheckedChanged);
            // 
            // copyDone
            // 
            this.copyDone.Location = new System.Drawing.Point(304, 316);
            this.copyDone.Name = "copyDone";
            this.copyDone.Size = new System.Drawing.Size(72, 12);
            this.copyDone.TabIndex = 23;
            // 
            // lbl_setclipboard
            // 
            this.lbl_setclipboard.AutoSize = true;
            this.lbl_setclipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setclipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_setclipboard.Location = new System.Drawing.Point(212, 316);
            this.lbl_setclipboard.Name = "lbl_setclipboard";
            this.lbl_setclipboard.Size = new System.Drawing.Size(89, 13);
            this.lbl_setclipboard.TabIndex = 22;
            this.lbl_setclipboard.Text = "Copy to clipboard";
            this.ToolTip1.SetToolTip(this.lbl_setclipboard, "Click to copy the text of the report to the Windows clipboard.");
            this.lbl_setclipboard.Click += new System.EventHandler(this.Label62_Click);
            // 
            // chkGeoList
            // 
            this.chkGeoList.AutoSize = true;
            this.chkGeoList.Enabled = false;
            this.chkGeoList.Location = new System.Drawing.Point(376, 80);
            this.chkGeoList.Name = "chkGeoList";
            this.chkGeoList.Size = new System.Drawing.Size(47, 17);
            this.chkGeoList.TabIndex = 21;
            this.chkGeoList.Text = "Map";
            this.chkGeoList.UseVisualStyleBackColor = true;
            this.chkGeoList.Visible = false;
            // 
            // inclScanned
            // 
            this.inclScanned.AutoSize = true;
            this.inclScanned.Location = new System.Drawing.Point(300, 60);
            this.inclScanned.Name = "inclScanned";
            this.inclScanned.Size = new System.Drawing.Size(161, 17);
            this.inclScanned.TabIndex = 19;
            this.inclScanned.Text = "Include scanned and printed";
            this.ToolTip1.SetToolTip(this.inclScanned, "Check to include lables that were scanned, but not printed.");
            this.inclScanned.UseVisualStyleBackColor = true;
            // 
            // Label61
            // 
            this.Label61.AutoSize = true;
            this.Label61.ForeColor = System.Drawing.Color.Red;
            this.Label61.Location = new System.Drawing.Point(104, 16);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(29, 13);
            this.Label61.TabIndex = 18;
            this.Label61.Text = "Beta";
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.Location = new System.Drawing.Point(300, 8);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(124, 13);
            this.Label60.TabIndex = 17;
            this.Label60.Text = "--- Sorted by date/time ---";
            // 
            // sortBox
            // 
            this.sortBox.Controls.Add(this.byAlpha);
            this.sortBox.Controls.Add(this.byCount);
            this.sortBox.Location = new System.Drawing.Point(224, 8);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(72, 80);
            this.sortBox.TabIndex = 16;
            this.sortBox.TabStop = false;
            this.sortBox.Text = "Sort by";
            // 
            // byAlpha
            // 
            this.byAlpha.AutoSize = true;
            this.byAlpha.Location = new System.Drawing.Point(8, 52);
            this.byAlpha.Name = "byAlpha";
            this.byAlpha.Size = new System.Drawing.Size(52, 17);
            this.byAlpha.TabIndex = 17;
            this.byAlpha.Text = "Alpha";
            this.ToolTip1.SetToolTip(this.byAlpha, "Sort report alphabetically");
            this.byAlpha.UseVisualStyleBackColor = true;
            // 
            // byCount
            // 
            this.byCount.AutoSize = true;
            this.byCount.Checked = true;
            this.byCount.Location = new System.Drawing.Point(8, 28);
            this.byCount.Name = "byCount";
            this.byCount.Size = new System.Drawing.Size(53, 17);
            this.byCount.TabIndex = 17;
            this.byCount.TabStop = true;
            this.byCount.Text = "Count";
            this.ToolTip1.SetToolTip(this.byCount, "Sort report by count, highest to lowest");
            this.byCount.UseVisualStyleBackColor = true;
            // 
            // sortSTL
            // 
            this.sortSTL.FormattingEnabled = true;
            this.sortSTL.Location = new System.Drawing.Point(448, 0);
            this.sortSTL.Name = "sortSTL";
            this.sortSTL.Size = new System.Drawing.Size(40, 17);
            this.sortSTL.TabIndex = 15;
            this.sortSTL.Visible = false;
            // 
            // radioByLocation
            // 
            this.radioByLocation.AutoSize = true;
            this.radioByLocation.Location = new System.Drawing.Point(140, 60);
            this.radioByLocation.Name = "radioByLocation";
            this.radioByLocation.Size = new System.Drawing.Size(81, 17);
            this.radioByLocation.TabIndex = 14;
            this.radioByLocation.Text = "By Location";
            this.ToolTip1.SetToolTip(this.radioByLocation, "Count labels printed for each shelving location in specified date range.");
            this.radioByLocation.UseVisualStyleBackColor = true;
            // 
            // Label56
            // 
            this.Label56.AutoSize = true;
            this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.Location = new System.Drawing.Point(4, 4);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(104, 15);
            this.Label56.TabIndex = 13;
            this.Label56.Text = "Activity Reports";
            // 
            // searchArg
            // 
            this.searchArg.Location = new System.Drawing.Point(412, 36);
            this.searchArg.Name = "searchArg";
            this.searchArg.Size = new System.Drawing.Size(104, 20);
            this.searchArg.TabIndex = 12;
            this.ToolTip1.SetToolTip(this.searchArg, "Show detail record only if it includes this exact text string.");
            // 
            // radioSearch
            // 
            this.radioSearch.AutoSize = true;
            this.radioSearch.Location = new System.Drawing.Point(300, 36);
            this.radioSearch.Name = "radioSearch";
            this.radioSearch.Size = new System.Drawing.Size(114, 17);
            this.radioSearch.TabIndex = 11;
            this.radioSearch.Text = "Details (filtered by:)";
            this.ToolTip1.SetToolTip(this.radioSearch, "Show details for all labels printed in specified date range.");
            this.radioSearch.UseVisualStyleBackColor = true;
            // 
            // statsOut
            // 
            this.statsOut.BackColor = System.Drawing.Color.AntiqueWhite;
            this.statsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsOut.Location = new System.Drawing.Point(4, 100);
            this.statsOut.Multiline = true;
            this.statsOut.Name = "statsOut";
            this.statsOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statsOut.Size = new System.Drawing.Size(520, 216);
            this.statsOut.TabIndex = 10;
            this.ToolTip1.SetToolTip(this.statsOut, "Report appears here.");
            this.statsOut.WordWrap = false;
            this.statsOut.TextChanged += new System.EventHandler(this.statsOut_TextChanged);
            // 
            // radioByLibrary
            // 
            this.radioByLibrary.AutoSize = true;
            this.radioByLibrary.Location = new System.Drawing.Point(140, 36);
            this.radioByLibrary.Name = "radioByLibrary";
            this.radioByLibrary.Size = new System.Drawing.Size(71, 17);
            this.radioByLibrary.TabIndex = 7;
            this.radioByLibrary.Text = "By Library";
            this.ToolTip1.SetToolTip(this.radioByLibrary, "Count labels printed for each library in specified date range.");
            this.radioByLibrary.UseVisualStyleBackColor = true;
            // 
            // radioByUser
            // 
            this.radioByUser.AutoSize = true;
            this.radioByUser.Checked = true;
            this.radioByUser.Location = new System.Drawing.Point(140, 12);
            this.radioByUser.Name = "radioByUser";
            this.radioByUser.Size = new System.Drawing.Size(62, 17);
            this.radioByUser.TabIndex = 6;
            this.radioByUser.TabStop = true;
            this.radioByUser.Text = "By User";
            this.ToolTip1.SetToolTip(this.radioByUser, "Count labels printed by user in specified date range.");
            this.radioByUser.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(476, 76);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(48, 20);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Run";
            this.ToolTip1.SetToolTip(this.btnScan, "Run report based on dates and other selections.");
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // STL
            // 
            this.STL.FormattingEnabled = true;
            this.STL.Location = new System.Drawing.Point(488, 0);
            this.STL.Name = "STL";
            this.STL.Size = new System.Drawing.Size(36, 17);
            this.STL.TabIndex = 4;
            this.STL.Visible = false;
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.Location = new System.Drawing.Point(20, 60);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(16, 13);
            this.Label55.TabIndex = 3;
            this.Label55.Text = "to";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(4, 36);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(30, 13);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "From";
            // 
            // toScan
            // 
            this.toScan.CustomFormat = "";
            this.toScan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toScan.Location = new System.Drawing.Point(36, 56);
            this.toScan.Name = "toScan";
            this.toScan.Size = new System.Drawing.Size(92, 20);
            this.toScan.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.toScan, "Select highest date for report.");
            this.toScan.Value = new System.DateTime(2013, 8, 28, 0, 0, 0, 0);
            // 
            // fromScan
            // 
            this.fromScan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromScan.Location = new System.Drawing.Point(36, 32);
            this.fromScan.Name = "fromScan";
            this.fromScan.Size = new System.Drawing.Size(92, 20);
            this.fromScan.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.fromScan, "Select earliest date for report.");
            this.fromScan.Value = new System.DateTime(2013, 6, 12, 0, 0, 0, 0);
            // 
            // createTemp
            // 
            this.createTemp.AutoSize = true;
            this.createTemp.Location = new System.Drawing.Point(484, 8);
            this.createTemp.Name = "createTemp";
            this.createTemp.Size = new System.Drawing.Size(132, 17);
            this.createTemp.TabIndex = 31;
            this.createTemp.Tag = "check_createtemp";
            this.createTemp.Text = "Enable temp barcodes";
            this.ToolTip1.SetToolTip(this.createTemp, "Turn on the temp label option");
            this.createTemp.UseVisualStyleBackColor = true;
            this.createTemp.CheckedChanged += new System.EventHandler(this.createTemp_CheckedChanged);
            // 
            // chkRequireUser
            // 
            this.chkRequireUser.AutoSize = true;
            this.chkRequireUser.Location = new System.Drawing.Point(364, 8);
            this.chkRequireUser.Name = "chkRequireUser";
            this.chkRequireUser.Size = new System.Drawing.Size(114, 17);
            this.chkRequireUser.TabIndex = 46;
            this.chkRequireUser.Tag = "check_requireuser";
            this.chkRequireUser.Text = "Require Username";
            this.ToolTip1.SetToolTip(this.chkRequireUser, "Check to require the user to enter their ID before continuing.");
            this.chkRequireUser.UseVisualStyleBackColor = true;
            this.chkRequireUser.CheckedChanged += new System.EventHandler(this.chkRequireUser_CheckedChanged);
            // 
            // FileSystemWatcher1
            // 
            this.FileSystemWatcher1.EnableRaisingEvents = true;
            this.FileSystemWatcher1.Filter = "*.xml";
            this.FileSystemWatcher1.SynchronizingObject = this;
            this.FileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Created);
            // 
            // FileSystemWatcher2
            // 
            this.FileSystemWatcher2.EnableRaisingEvents = true;
            this.FileSystemWatcher2.Filter = "labelout.txt";
            this.FileSystemWatcher2.SynchronizingObject = this;
            this.FileSystemWatcher2.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher2_Changed);
            // 
            // InputBox
            // 
            this.InputBox.AllowDrop = true;
            this.InputBox.CausesValidation = false;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(44, 136);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(148, 22);
            this.InputBox.TabIndex = 11;
            this.ToolTip1.SetToolTip(this.InputBox, "Input Box - Scan, type or drop barcode number");
            this.InputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputBox_DragDrop);
            this.InputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputBox_DragEnter);
            this.InputBox.GotFocus += new System.EventHandler(this.InputBox_GotFocus);
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            this.InputBox.LostFocus += new System.EventHandler(this.InputBox_LostFocus);
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(0, 136);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(40, 24);
            this.ScanButton.TabIndex = 13;
            this.ScanButton.Text = "scan";
            this.ToolTip1.SetToolTip(this.ScanButton, "Clears the input box and waits for you to scan or type a barcode number.");
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // SaveSettingsButn
            // 
            this.SaveSettingsButn.Location = new System.Drawing.Point(700, 388);
            this.SaveSettingsButn.Name = "SaveSettingsButn";
            this.SaveSettingsButn.Size = new System.Drawing.Size(52, 20);
            this.SaveSettingsButn.TabIndex = 15;
            this.SaveSettingsButn.Text = "Save";
            this.ToolTip1.SetToolTip(this.SaveSettingsButn, "Save all settings to be recalled on startup");
            this.SaveSettingsButn.UseVisualStyleBackColor = true;
            this.SaveSettingsButn.Click += new System.EventHandler(this.SaveSettingsButn_Click);
            // 
            // LoadSettingsButn
            // 
            this.LoadSettingsButn.Location = new System.Drawing.Point(644, 388);
            this.LoadSettingsButn.Name = "LoadSettingsButn";
            this.LoadSettingsButn.Size = new System.Drawing.Size(52, 20);
            this.LoadSettingsButn.TabIndex = 16;
            this.LoadSettingsButn.Text = "Load";
            this.ToolTip1.SetToolTip(this.LoadSettingsButn, "Load the most recently saved settings");
            this.LoadSettingsButn.UseVisualStyleBackColor = true;
            this.LoadSettingsButn.Click += new System.EventHandler(this.LoadSettingsButn_Click);
            // 
            // Label27
            // 
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.Location = new System.Drawing.Point(4, 52);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(200, 16);
            this.Label27.TabIndex = 17;
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryList
            // 
            this.HistoryList.FormattingEnabled = true;
            this.HistoryList.Location = new System.Drawing.Point(44, 156);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(148, 69);
            this.HistoryList.TabIndex = 18;
            this.ToolTip1.SetToolTip(this.HistoryList, "Doubleclick to recall a recently scanned barcode number");
            this.HistoryList.Visible = false;
            this.HistoryList.DoubleClick += new System.EventHandler(this.HistoryList_DoubleClick);
            // 
            // ArrowLabel
            // 
            this.ArrowLabel.AutoSize = true;
            this.ArrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ArrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ArrowLabel.Location = new System.Drawing.Point(192, 140);
            this.ArrowLabel.Name = "ArrowLabel";
            this.ArrowLabel.Size = new System.Drawing.Size(20, 15);
            this.ArrowLabel.TabIndex = 19;
            this.ArrowLabel.Text = "q";
            this.ToolTip1.SetToolTip(this.ArrowLabel, "Show/hide last 5 barcode numbers");
            this.ArrowLabel.Click += new System.EventHandler(this.ArrowLabel_Click);
            // 
            // TempLabelBox
            // 
            this.TempLabelBox.BackColor = System.Drawing.Color.White;
            this.TempLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TempLabelBox.Location = new System.Drawing.Point(44, 116);
            this.TempLabelBox.Name = "TempLabelBox";
            this.TempLabelBox.Size = new System.Drawing.Size(148, 20);
            this.TempLabelBox.TabIndex = 21;
            this.ToolTip1.SetToolTip(this.TempLabelBox, "Drag this barcode number to the input box or to Alma.");
            this.TempLabelBox.Visible = false;
            this.TempLabelBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TempLabelBox_MouseDown);
            // 
            // CreateTempLbl
            // 
            this.CreateTempLbl.AutoSize = true;
            this.CreateTempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTempLbl.Location = new System.Drawing.Point(0, 116);
            this.CreateTempLbl.Name = "CreateTempLbl";
            this.CreateTempLbl.Size = new System.Drawing.Size(36, 13);
            this.CreateTempLbl.TabIndex = 22;
            this.CreateTempLbl.Text = "temp>";
            this.ToolTip1.SetToolTip(this.CreateTempLbl, "Click to create a temporary barcode number.");
            this.CreateTempLbl.Visible = false;
            this.CreateTempLbl.Click += new System.EventHandler(this.CreateTempLbl_Click);
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.Location = new System.Drawing.Point(220, 384);
            this.CheckForUpdates.Name = "CheckForUpdates";
            this.CheckForUpdates.Size = new System.Drawing.Size(108, 24);
            this.CheckForUpdates.TabIndex = 23;
            this.CheckForUpdates.Text = "Check for updates";
            this.ToolTip1.SetToolTip(this.CheckForUpdates, "Check web for newer software release");
            this.CheckForUpdates.UseVisualStyleBackColor = true;
            this.CheckForUpdates.Click += new System.EventHandler(this.CheckForUpdates_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Active = false;
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.Location = new System.Drawing.Point(708, 8);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(40, 13);
            this.Label47.TabIndex = 35;
            this.Label47.Text = "About";
            this.ToolTip1.SetToolTip(this.Label47, "Statement of Copyright and authorship, and link to product manual");
            this.Label47.Click += new System.EventHandler(this.Label47_Click);
            // 
            // usrname
            // 
            this.usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrname.ForeColor = System.Drawing.Color.Blue;
            this.usrname.Location = new System.Drawing.Point(120, 6);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(88, 13);
            this.usrname.TabIndex = 38;
            this.ToolTip1.SetToolTip(this.usrname, "Optional user ID to use in Activity Reports.");
            this.usrname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usrname_KeyPress);
            // 
            // lblStation
            // 
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStation.Location = new System.Drawing.Point(0, 4);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(84, 16);
            this.lblStation.TabIndex = 39;
            this.ToolTip1.SetToolTip(this.lblStation, "Station name that identifies this workstation.");
            // 
            // station
            // 
            this.station.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.station.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.station.ForeColor = System.Drawing.Color.Green;
            this.station.Location = new System.Drawing.Point(268, 8);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(92, 14);
            this.station.TabIndex = 49;
            this.station.Tag = "text_stationname";
            this.station.Text = "Station?";
            this.ToolTip1.SetToolTip(this.station, "Enter a brief name to identify this workstation for Activity Reports.");
            this.station.TextChanged += new System.EventHandler(this.station_TextChanged);
            // 
            // LabelRepeat
            // 
            this.LabelRepeat.BackColor = System.Drawing.Color.White;
            this.LabelRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRepeat.ForeColor = System.Drawing.Color.Black;
            this.LabelRepeat.Location = new System.Drawing.Point(173, 4);
            this.LabelRepeat.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.LabelRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LabelRepeat.Name = "LabelRepeat";
            this.LabelRepeat.ReadOnly = true;
            this.LabelRepeat.Size = new System.Drawing.Size(36, 22);
            this.LabelRepeat.TabIndex = 35;
            this.LabelRepeat.Tag = "numud_repeatnum";
            this.LabelRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.LabelRepeat, "Print the label up to 99 times.");
            this.LabelRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LabelRepeat.ValueChanged += new System.EventHandler(this.LabelRepeat_ValueChanged);
            // 
            // lblXMLWarn
            // 
            this.lblXMLWarn.AutoSize = true;
            this.lblXMLWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblXMLWarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXMLWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLWarn.ForeColor = System.Drawing.Color.Red;
            this.lblXMLWarn.Location = new System.Drawing.Point(1, 169);
            this.lblXMLWarn.Name = "lblXMLWarn";
            this.lblXMLWarn.Size = new System.Drawing.Size(38, 15);
            this.lblXMLWarn.TabIndex = 53;
            this.lblXMLWarn.Text = "XML!";
            this.ToolTip1.SetToolTip(this.lblXMLWarn, "Warns if an XML field is invalid.  Click the \'XML!\' symbol to see which field(s) " +
        "caused the error.");
            this.lblXMLWarn.Visible = false;
            this.lblXMLWarn.Click += new System.EventHandler(this.lblXMLWarn_Click);
            // 
            // lblToggleAdmin
            // 
            this.lblToggleAdmin.AutoSize = true;
            this.lblToggleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblToggleAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblToggleAdmin.Location = new System.Drawing.Point(196, 20);
            this.lblToggleAdmin.Name = "lblToggleAdmin";
            this.lblToggleAdmin.Size = new System.Drawing.Size(21, 15);
            this.lblToggleAdmin.TabIndex = 54;
            this.lblToggleAdmin.Tag = "";
            this.lblToggleAdmin.Text = "u";
            this.ToolTip1.SetToolTip(this.lblToggleAdmin, "Click to open or close the setup panels");
            this.lblToggleAdmin.Click += new System.EventHandler(this.lblToggleAdmin_Click);
            // 
            // unitCM
            // 
            this.unitCM.AutoSize = true;
            this.unitCM.Location = new System.Drawing.Point(76, 6);
            this.unitCM.Name = "unitCM";
            this.unitCM.Size = new System.Drawing.Size(42, 17);
            this.unitCM.TabIndex = 1;
            this.unitCM.Tag = "radio_unitcm";
            this.unitCM.Text = "cm.";
            this.ToolTip1.SetToolTip(this.unitCM, "Margins and linespacing measurements are in centimeters.");
            this.unitCM.UseVisualStyleBackColor = true;
            // 
            // unitINCH
            // 
            this.unitINCH.AutoSize = true;
            this.unitINCH.Checked = true;
            this.unitINCH.Location = new System.Drawing.Point(40, 6);
            this.unitINCH.Name = "unitINCH";
            this.unitINCH.Size = new System.Drawing.Size(36, 17);
            this.unitINCH.TabIndex = 0;
            this.unitINCH.TabStop = true;
            this.unitINCH.Tag = "radio_unitinch";
            this.unitINCH.Text = "in.";
            this.ToolTip1.SetToolTip(this.unitINCH, "Margins and line spacing measurements are in inches.");
            this.unitINCH.UseVisualStyleBackColor = true;
            this.unitINCH.CheckedChanged += new System.EventHandler(this.unitINCH_CheckedChanged);
            // 
            // decimalCOMMA
            // 
            this.decimalCOMMA.AutoSize = true;
            this.decimalCOMMA.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalCOMMA.Location = new System.Drawing.Point(100, 4);
            this.decimalCOMMA.Name = "decimalCOMMA";
            this.decimalCOMMA.Size = new System.Drawing.Size(33, 20);
            this.decimalCOMMA.TabIndex = 1;
            this.decimalCOMMA.Tag = "radio_comma";
            this.decimalCOMMA.Text = ",";
            this.decimalCOMMA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolTip1.SetToolTip(this.decimalCOMMA, "Use a comma to represent fractions.");
            this.decimalCOMMA.UseVisualStyleBackColor = true;
            // 
            // decimalDOT
            // 
            this.decimalDOT.AutoSize = true;
            this.decimalDOT.Checked = true;
            this.decimalDOT.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalDOT.Location = new System.Drawing.Point(60, 4);
            this.decimalDOT.Name = "decimalDOT";
            this.decimalDOT.Size = new System.Drawing.Size(33, 20);
            this.decimalDOT.TabIndex = 0;
            this.decimalDOT.TabStop = true;
            this.decimalDOT.Tag = "radio_decimalpoint";
            this.decimalDOT.Text = ".";
            this.decimalDOT.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ToolTip1.SetToolTip(this.decimalDOT, "Use a decimal point to represent fractions.");
            this.decimalDOT.UseVisualStyleBackColor = true;
            this.decimalDOT.CheckedChanged += new System.EventHandler(this.decimalDOT_CheckedChanged);
            // 
            // zplAddBtn
            // 
            this.zplAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zplAddBtn.Location = new System.Drawing.Point(1, 3);
            this.zplAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.zplAddBtn.Name = "zplAddBtn";
            this.zplAddBtn.Size = new System.Drawing.Size(104, 24);
            this.zplAddBtn.TabIndex = 1;
            this.zplAddBtn.Text = "Add";
            this.ToolTip1.SetToolTip(this.zplAddBtn, "Print label on selected printer");
            this.zplAddBtn.UseVisualStyleBackColor = true;
            this.zplAddBtn.Click += new System.EventHandler(this.zplAddBtn_Click);
            // 
            // zplPrintBtn
            // 
            this.zplPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zplPrintBtn.Location = new System.Drawing.Point(108, 3);
            this.zplPrintBtn.Margin = new System.Windows.Forms.Padding(0);
            this.zplPrintBtn.Name = "zplPrintBtn";
            this.zplPrintBtn.Size = new System.Drawing.Size(107, 24);
            this.zplPrintBtn.TabIndex = 2;
            this.zplPrintBtn.Text = "Print";
            this.ToolTip1.SetToolTip(this.zplPrintBtn, "Print label on selected printer");
            this.zplPrintBtn.UseVisualStyleBackColor = true;
            this.zplPrintBtn.Click += new System.EventHandler(this.zplPrintBtn_Click);
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location = new System.Drawing.Point(588, 392);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(57, 13);
            this.Label34.TabIndex = 27;
            this.Label34.Text = "Settings:";
            // 
            // PrintDocument2
            // 
            this.PrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument2_PrintPage);
            this.PrintDocument2.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.PrintDocument2_QueryPageSettings);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Document = this.PrintDocument2;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // parsedBy
            // 
            this.parsedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parsedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.parsedBy.Location = new System.Drawing.Point(40, 160);
            this.parsedBy.Name = "parsedBy";
            this.parsedBy.Size = new System.Drawing.Size(176, 16);
            this.parsedBy.TabIndex = 36;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(84, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 13);
            this.lblUser.TabIndex = 37;
            this.lblUser.Text = "User:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(216, 9);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(51, 13);
            this.Label10.TabIndex = 50;
            this.Label10.Text = "Station:";
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Location = new System.Drawing.Point(620, 8);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(76, 17);
            this.tips.TabIndex = 51;
            this.tips.Tag = "check_showtips";
            this.tips.Text = "Show Tips";
            this.tips.UseVisualStyleBackColor = true;
            this.tips.CheckedChanged += new System.EventHandler(this.tips_CheckedChanged);
            // 
            // Label86
            // 
            this.Label86.AutoSize = true;
            this.Label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label86.Location = new System.Drawing.Point(157, 8);
            this.Label86.Name = "Label86";
            this.Label86.Size = new System.Drawing.Size(14, 13);
            this.Label86.TabIndex = 52;
            this.Label86.Text = "X";
            // 
            // TextBox24
            // 
            this.TextBox24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox24.ForeColor = System.Drawing.Color.Blue;
            this.TextBox24.Location = new System.Drawing.Point(4, 72);
            this.TextBox24.Multiline = true;
            this.TextBox24.Name = "TextBox24";
            this.TextBox24.Size = new System.Drawing.Size(208, 44);
            this.TextBox24.TabIndex = 12;
            // 
            // printProgress
            // 
            this.printProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.printProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printProgress.ForeColor = System.Drawing.Color.Fuchsia;
            this.printProgress.Location = new System.Drawing.Point(16, 364);
            this.printProgress.Name = "printProgress";
            this.printProgress.Size = new System.Drawing.Size(132, 17);
            this.printProgress.TabIndex = 35;
            this.printProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printProgress.Visible = false;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(260, 4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(108, 17);
            this.RadioButton1.TabIndex = 14;
            this.RadioButton1.Tag = "radio_deweycharbreakaft";
            this.RadioButton1.Text = "after character(s):";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Label112
            // 
            this.Label112.AutoSize = true;
            this.Label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label112.Location = new System.Drawing.Point(40, 8);
            this.Label112.Name = "Label112";
            this.Label112.Size = new System.Drawing.Size(42, 13);
            this.Label112.TabIndex = 9;
            this.Label112.Text = "Other:";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(164, 4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(98, 17);
            this.RadioButton2.TabIndex = 13;
            this.RadioButton2.Tag = "radio_deweycharbreakb4";
            this.RadioButton2.Text = "Break before or";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Checked = true;
            this.RadioButton3.Location = new System.Drawing.Point(88, 4);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(69, 17);
            this.RadioButton3.TabIndex = 12;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Tag = "radio_deweycharnobreak";
            this.RadioButton3.Text = "No break";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // Panel18
            // 
            this.Panel18.BackColor = System.Drawing.Color.White;
            this.Panel18.Controls.Add(this.unitCM);
            this.Panel18.Controls.Add(this.unitINCH);
            this.Panel18.Controls.Add(this.Label116);
            this.Panel18.Location = new System.Drawing.Point(328, 384);
            this.Panel18.Name = "Panel18";
            this.Panel18.Size = new System.Drawing.Size(124, 28);
            this.Panel18.TabIndex = 60;
            // 
            // Label116
            // 
            this.Label116.AutoSize = true;
            this.Label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label116.Location = new System.Drawing.Point(4, 8);
            this.Label116.Name = "Label116";
            this.Label116.Size = new System.Drawing.Size(38, 13);
            this.Label116.TabIndex = 28;
            this.Label116.Text = "units:";
            // 
            // Panel19
            // 
            this.Panel19.Controls.Add(this.Label124);
            this.Panel19.Controls.Add(this.decimalCOMMA);
            this.Panel19.Controls.Add(this.decimalDOT);
            this.Panel19.Controls.Add(this.Label123);
            this.Panel19.Location = new System.Drawing.Point(452, 384);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(136, 28);
            this.Panel19.TabIndex = 61;
            // 
            // Label124
            // 
            this.Label124.AutoSize = true;
            this.Label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label124.Location = new System.Drawing.Point(4, 8);
            this.Label124.Name = "Label124";
            this.Label124.Size = new System.Drawing.Size(54, 13);
            this.Label124.TabIndex = 29;
            this.Label124.Text = "decimal:";
            // 
            // Label123
            // 
            this.Label123.AutoSize = true;
            this.Label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label123.Location = new System.Drawing.Point(4, 6);
            this.Label123.Name = "Label123";
            this.Label123.Size = new System.Drawing.Size(0, 13);
            this.Label123.TabIndex = 28;
            // 
            // xboxPanel
            // 
            this.xboxPanel.BackColor = System.Drawing.Color.Lavender;
            this.xboxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xboxPanel.Controls.Add(this.Label90);
            this.xboxPanel.Controls.Add(this.Label89);
            this.xboxPanel.Controls.Add(this.closeXbox);
            this.xboxPanel.Controls.Add(this.XBOX);
            this.xboxPanel.Location = new System.Drawing.Point(0, 52);
            this.xboxPanel.Name = "xboxPanel";
            this.xboxPanel.Size = new System.Drawing.Size(44, 44);
            this.xboxPanel.TabIndex = 59;
            this.xboxPanel.Visible = false;
            // 
            // Label90
            // 
            this.Label90.AutoSize = true;
            this.Label90.Location = new System.Drawing.Point(48, 336);
            this.Label90.Name = "Label90";
            this.Label90.Size = new System.Drawing.Size(106, 13);
            this.Label90.TabIndex = 3;
            this.Label90.Text = "Doubleclick to select";
            // 
            // Label89
            // 
            this.Label89.AutoSize = true;
            this.Label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label89.ForeColor = System.Drawing.Color.Blue;
            this.Label89.Location = new System.Drawing.Point(12, 4);
            this.Label89.Name = "Label89";
            this.Label89.Size = new System.Drawing.Size(183, 15);
            this.Label89.TabIndex = 2;
            this.Label89.Text = "Available XML fields for this item";
            // 
            // closeXbox
            // 
            this.closeXbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeXbox.ForeColor = System.Drawing.Color.White;
            this.closeXbox.Location = new System.Drawing.Point(196, 0);
            this.closeXbox.Name = "closeXbox";
            this.closeXbox.Size = new System.Drawing.Size(16, 16);
            this.closeXbox.TabIndex = 1;
            this.closeXbox.Text = "X";
            this.closeXbox.Click += new System.EventHandler(this.closeXbox_Click);
            // 
            // XBOX
            // 
            this.XBOX.BackColor = System.Drawing.Color.AntiqueWhite;
            this.XBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBOX.FormattingEnabled = true;
            this.XBOX.IntegralHeight = false;
            this.XBOX.Location = new System.Drawing.Point(4, 20);
            this.XBOX.Name = "XBOX";
            this.XBOX.Size = new System.Drawing.Size(204, 312);
            this.XBOX.TabIndex = 0;
            this.XBOX.DoubleClick += new System.EventHandler(this.XBOX_DoubleClick);
            // 
            // holdingsBy
            // 
            this.holdingsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdingsBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.holdingsBy.Location = new System.Drawing.Point(40, 174);
            this.holdingsBy.Name = "holdingsBy";
            this.holdingsBy.Size = new System.Drawing.Size(176, 14);
            this.holdingsBy.TabIndex = 62;
            // 
            // accessType
            // 
            this.accessType.AutoSize = true;
            this.accessType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accessType.Location = new System.Drawing.Point(200, 120);
            this.accessType.Name = "accessType";
            this.accessType.Size = new System.Drawing.Size(10, 13);
            this.accessType.TabIndex = 63;
            this.accessType.Text = "-";
            // 
            // printPanel
            // 
            this.printPanel.Controls.Add(this.ManualPrint);
            this.printPanel.Controls.Add(this.Label86);
            this.printPanel.Controls.Add(this.LabelRepeat);
            this.printPanel.Location = new System.Drawing.Point(1, 384);
            this.printPanel.Name = "printPanel";
            this.printPanel.Size = new System.Drawing.Size(216, 29);
            this.printPanel.TabIndex = 64;
            // 
            // zplPrintPanel
            // 
            this.zplPrintPanel.Controls.Add(this.zplPrintBtn);
            this.zplPrintPanel.Controls.Add(this.zplAddBtn);
            this.zplPrintPanel.Location = new System.Drawing.Point(1, 383);
            this.zplPrintPanel.Name = "zplPrintPanel";
            this.zplPrintPanel.Size = new System.Drawing.Size(216, 29);
            this.zplPrintPanel.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 414);
            this.Controls.Add(this.xboxPanel);
            this.Controls.Add(this.Panel19);
            this.Controls.Add(this.Panel18);
            this.Controls.Add(this.printProgress);
            this.Controls.Add(this.lblToggleAdmin);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.station);
            this.Controls.Add(this.chkRequireUser);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.Label47);
            this.Controls.Add(this.createTemp);
            this.Controls.Add(this.Label34);
            this.Controls.Add(this.CheckForUpdates);
            this.Controls.Add(this.CreateTempLbl);
            this.Controls.Add(this.TempLabelBox);
            this.Controls.Add(this.ArrowLabel);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.LoadSettingsButn);
            this.Controls.Add(this.SaveSettingsButn);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.TextBox24);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.lblXMLWarn);
            this.Controls.Add(this.parsedBy);
            this.Controls.Add(this.holdingsBy);
            this.Controls.Add(this.accessType);
            this.Controls.Add(this.zplPrintPanel);
            this.Controls.Add(this.printPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SpineOMatic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.zebraSettingsPanel.ResumeLayout(false);
            this.zebraSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupTopOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSplitOffset)).EndInit();
            this.panelMax.ResumeLayout(false);
            this.panelMax.PerformLayout();
            this.viaDOSPanel.ResumeLayout(false);
            this.viaDOSPanel.PerformLayout();
            this.Panel17.ResumeLayout(false);
            this.Panel17.PerformLayout();
            this.orientationPanel.ResumeLayout(false);
            this.orientationPanel.PerformLayout();
            this.marginPanel.ResumeLayout(false);
            this.marginPanel.PerformLayout();
            this.FTPGroup.ResumeLayout(false);
            this.FTPGroup.PerformLayout();
            this.DesktopGroup.ResumeLayout(false);
            this.DesktopGroup.PerformLayout();
            this.SheetSettings.ResumeLayout(false);
            this.SheetSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchNumber)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.PocketLabelPanel.ResumeLayout(false);
            this.PocketLabelPanel.PerformLayout();
            this.userDefinedPanel.ResumeLayout(false);
            this.userDefinedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLcount)).EndInit();
            this.tweakParsingPanel.ResumeLayout(false);
            this.tweakParsingPanel.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.TabPage8.ResumeLayout(false);
            this.TabPage8.PerformLayout();
            this.Panel15.ResumeLayout(false);
            this.Panel15.PerformLayout();
            this.Panel14.ResumeLayout(false);
            this.Panel14.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.TabPage10.ResumeLayout(false);
            this.TabPage10.PerformLayout();
            this.Panel16.ResumeLayout(false);
            this.Panel16.PerformLayout();
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TabPage11.ResumeLayout(false);
            this.TabPage11.PerformLayout();
            this.Panel13.ResumeLayout(false);
            this.Panel13.PerformLayout();
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.TabPage9.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.formatInfoPanel.ResumeLayout(false);
            this.formatInfoPanel.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.sortBox.ResumeLayout(false);
            this.sortBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelRepeat)).EndInit();
            this.Panel18.ResumeLayout(false);
            this.Panel18.PerformLayout();
            this.Panel19.ResumeLayout(false);
            this.Panel19.PerformLayout();
            this.xboxPanel.ResumeLayout(false);
            this.xboxPanel.PerformLayout();
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            this.zplPrintPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal TextBox OutputBox;
        internal Button ManualPrint;
        internal Panel Panel1;
        internal RadioButton ReviewBox;
        internal RadioButton AutoPrintBox;
        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal RichTextBox RichTextBox1;
        internal TextBox inCallNumSource;
        internal TextBox inIssueLevelSource;
        internal TextBox TextBox14;
        internal TextBox TextBox13;
        internal Label Label14;
        internal Label Label13;
        internal Button SaveAboveLC;
        internal ListBox altList;
        internal ComboBox ComboBox1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.IO.FileSystemWatcher FileSystemWatcher1;
        internal FontDialog FontDialog1;
        internal System.IO.FileSystemWatcher FileSystemWatcher2;
        internal TextBox InputBox;
        internal Button ScanButton;
        internal Button SaveSettingsButn;
        internal Button LoadSettingsButn;
        internal Label Label27;
        internal RadioButton Spine;
        internal RadioButton CustomLabel;
        internal Label Label28;
        internal ListBox HistoryList;
        internal Label ArrowLabel;
        internal TextBox TempLabelBox;
        internal Label CreateTempLbl;
        internal CheckBox createTemp;
        internal Button CheckForUpdates;
        internal Label Label33;
        internal TextBox CustomText;
        internal ToolTip ToolTip1;
        internal Label Label34;
        internal System.Drawing.Printing.PrintDocument PrintDocument2;
        internal PrintPreviewDialog PrintPreviewDialog1;
        internal CheckBox FlagSlips;
        internal Label Label8;
        internal Label Label47;
        internal PictureBox PictureBox1;
        internal Button btnDocDownload;
        internal Label parsedBy;
        internal TextBox parsingSource;
        internal GroupBox GroupBox1;
        internal RadioButton radio_useSOMparsing;
        internal RadioButton useExlibrisParsing;
        internal CheckBox chkIncludeHoldings;
        internal TabPage TabPage5;
        internal TextBox XMLPath;
        internal Button btnMonitor;
        internal TextBox altURL;
        internal TextBox altText;
        internal Button btn_saveALT;
        internal Button btn_cancelALT;
        internal Button btn_deleteALT;
        internal Button btn_changeALT;
        internal Button btn_addALT;
        internal Label Label44;
        internal Label Label54;
        internal RadioButton radio_useLocal;
        internal RadioButton radio_useSystem;
        internal TextBox usrname;
        internal Label lblUser;
        internal CheckBox chkRequireUser;
        internal Label Label10;
        internal TextBox station;
        internal Label lblStation;
        internal TabPage TabPage6;
        internal Label Label55;
        internal Label Label9;
        internal DateTimePicker toScan;
        internal DateTimePicker fromScan;
        internal ListBox STL;
        internal Button btnScan;
        internal RadioButton radioByLibrary;
        internal RadioButton radioByUser;
        internal TextBox statsOut;
        internal TextBox searchArg;
        internal RadioButton radioSearch;
        internal Label Label56;
        internal Label Label57;
        internal RadioButton radioByLocation;
        internal ListBox sortSTL;
        internal RadioButton byCount;
        internal GroupBox sortBox;
        internal RadioButton byAlpha;
        internal Label Label60;
        internal Label Label61;
        internal CheckBox inclScanned;
        internal CheckBox chkIncludeOther;
        internal TextBox inOtherSource;
        internal TextBox nonFlagDefaults;
        internal TextBox flagDefaults;
        internal CheckBox tips;
        internal CheckBox chkGeoList;
        internal Panel tweakParsingPanel;
        internal Label Label71;
        internal GroupBox GroupBox2;
        internal Label Label59;
        internal Label Label58;
        internal TextBox testCallNumType;
        internal Button btnTestParser;
        internal Label tweakTest;
        internal Label Label73;
        internal ComboBox testComboBox;
        internal TabControl TabControl2;
        internal TabPage TabPage7;
        internal TabPage TabPage8;
        internal RadioButton lcNumericBreak;
        internal RadioButton lcNoNumericBreak;
        internal Label Label74;
        internal Label Label66;
        internal Panel Panel5;
        internal RadioButton lcDecimalBreakB4;
        internal RadioButton lcNoDecimalBreak;
        internal Panel Panel7;
        internal Label Label75;
        internal RadioButton lcCutterBreak;
        internal RadioButton lcCutterNoBreak;
        internal Panel Panel8;
        internal Label Label76;
        internal RadioButton lcInCutterBreak;
        internal RadioButton lcIncutternobreak;
        internal TabPage TabPage10;
        internal TabPage TabPage11;
        internal Panel Panel9;
        internal Label Label77;
        internal RadioButton deweyCutterBreak;
        internal RadioButton deweyCutterNoBreak;
        internal Panel Panel11;
        internal Label Label79;
        internal RadioButton deweyDecimalBreakb4;
        internal RadioButton deweyDecimalNoBreak;
        internal RadioButton otherAllSpaceBreak;
        internal RadioButton otherSpaceNoBreak;
        internal Label Label80;
        internal RadioButton otherListBreakb4;
        internal RadioButton otherListNoBreak;
        internal TextBox otherBreak;
        internal Label Label81;
        internal RadioButton otherListBreakAfter;
        internal Panel Panel12;
        internal Panel Panel13;
        internal RadioButton otherNumBreakb4;
        internal RadioButton othernumnobreak;
        internal Label Label83;
        internal RadioButton otherFirstSpaceBreak;
        internal RadioButton otherNumBreakAfter;
        internal RadioButton deweyDecimalBreakAft;
        internal Panel Panel14;
        internal Label Label82;
        internal RadioButton deweyPrefixBreak;
        internal RadioButton deweyPrefixNoBreak;
        internal TextBox deweyCharBreak;
        internal Panel Panel15;
        internal RadioButton deweyCharBreakAft;
        internal Label Label84;
        internal RadioButton deweyCharBreakb4;
        internal RadioButton deweyOtherNoBreak;
        internal Panel Panel3;
        internal RadioButton sudocNoDecimalBreak;
        internal RadioButton sudocBreakDecimal;
        internal Label Label69;
        internal RadioButton sudocBreakBeforeColon;
        internal RadioButton sudocBreakAfterColon;
        internal RadioButton sudocNoColonBreak;
        internal Label Label67;
        internal Panel Panel4;
        internal RadioButton sudocDashNoBreak;
        internal RadioButton sudocDashBreak;
        internal Label Label70;
        internal Panel Panel2;
        internal RadioButton sudocSlashNobreak;
        internal RadioButton sudocSlashBreak;
        internal Label Label68;
        internal Panel Panel6;
        internal Label Label78;
        internal RadioButton lcOtherBreakB4;
        internal RadioButton lcOtherNoBreak;
        internal TextBox lcBreak;
        internal RadioButton lcOtherBreakAft;
        internal CheckBox lcRemoveAfter;
        internal CheckBox deweyRemoveAfter;
        internal CheckBox otherRemoveAfter;
        internal Panel Panel10;
        internal RadioButton sudocNoBreakB4Numerics;
        internal RadioButton sudocBreakB4Numerics;
        internal Label Label85;
        internal NumericUpDown LabelRepeat;
        internal Label Label86;
        internal Label Label87;
        internal CheckBox chkXMLWarning;
        internal Label lblXMLWarn;
        internal Label lblToggleAdmin;
        internal TextBox wrapWidth;
        internal TextBox flagWrapWidth;
        internal TextBox nonFlagWrapWidth;
        internal Label Label91;
        internal CheckBox chkUsePocketLabels;
        internal Panel PocketLabelPanel;
        internal TextBox plOutput;
        internal Label Label88;
        internal RadioButton btnPlCustom;
        internal TextBox plSrc1;
        internal TextBox plSrc3;
        internal TextBox plSrc2;
        internal TextBox plSrc4;
        internal TextBox plMin3;
        internal TextBox plMin2;
        internal TextBox plMin1;
        internal Label Label93;
        internal Label Label92;
        internal TextBox plMin4;
        internal Label Label96;
        internal TextBox plMax4;
        internal TextBox plMax3;
        internal TextBox plMax2;
        internal TextBox plMax1;
        internal Label Label95;
        internal Label Label97;
        internal TextBox plWork;
        internal Label Label99;
        internal Label Label98;
        internal TextBox plDistance;
        internal NumericUpDown PLcount;
        internal Label Label102;
        internal TextBox plLeftMargin;
        internal Label Label103;
        internal Label Label101;
        internal Label Label100;
        internal Label Label94;
        internal RadioButton btnSL6;
        internal RadioButton btnSL4;
        internal RadioButton btnSLB;
        internal Label Label105;
        internal Label Label104;
        internal Label Label106;
        internal TextBox showFormatInfo;
        internal TextBox closeFormatInfo;
        internal Panel formatInfoPanel;
        internal Label Label45;
        internal Label FTPwarning2;
        internal Label spineType;
        internal Panel userDefinedPanel;
        internal TextBox spineDefaults;
        internal TextBox lcType;
        internal Label Label107;
        internal TextBox DeweyType;
        internal Label Label108;
        internal TextBox sudocType;
        internal Label Label109;
        internal TextBox otherType;
        internal Label Label110;
        internal TextBox convertBlankTo;
        internal Label Label65;
        internal CheckBox logEdits;
        internal TabPage TabPage9;
        internal CheckBox BreakParen;
        internal CheckBox ProtectColon;
        internal CheckBox ColonBreak;
        internal TextBox issueBreak;
        internal CheckBox issueRemoveAfter;
        internal RadioButton issueListBreakAfter;
        internal RadioButton issueListBreakB4;
        internal RadioButton issueListNoBreak;
        internal CheckBox hideCutterDecimal;
        internal TextBox TextBox24;
        internal TextBox pocketDefaults;
        internal Label printProgress;
        internal TextBox configText;
        internal CheckBox spaceBreak;
        internal Label lbl_setclipboard;
        internal Label copyDone;
        internal Label lbl_copyXMLtext;
        internal CheckBox includeSettings;
        internal Label xmlCopyDone;
        internal CheckBox chkAddHostname;
        internal Label Label111;
        internal Label Label62;
        internal TextBox suppress3;
        internal TextBox suppress2;
        internal TextBox suppress1;
        internal CheckBox sudocRemoveAfter;
        internal TextBox sudocCharBreak;
        internal Panel Panel16;
        internal RadioButton sudocCharBreakAft;
        internal Label Label113;
        internal RadioButton sudocCharBreakB4;
        internal RadioButton sudocOtherNoBreak;
        internal RadioButton RadioButton1;
        internal Label Label112;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton3;
        internal TextBox updatePath;
        internal Panel Panel18;
        internal Label Label116;
        internal RadioButton unitCM;
        internal RadioButton unitINCH;
        internal Label plUnits2;
        internal Label plUnits1;
        internal Panel Panel19;
        internal RadioButton decimalCOMMA;
        internal RadioButton decimalDOT;
        internal Label Label123;
        internal Label Label124;
        internal CheckBox deweyGroup3;
        internal TextBox deweydigitsperline;
        internal Label Label125;
        internal Panel xboxPanel;
        internal Label closeXbox;
        internal ListBox XBOX;
        internal Label Label89;
        internal Label Label90;
        internal Label holdingsBy;
        internal RadioButton lcDecimalBreakAfter;
        internal Label Label127;
        internal Label Label126;
        internal TextBox deweyDigitsToBreak;
        internal Label Label128;
        internal CheckBox deweyDecBreak;
        internal ListBox ispList;
        internal CheckBox showIsp;
        internal RadioButton UseRestfulApi;
        internal Label Label129;
        internal TextBox apiKey;
        internal TextBox apiURL;
        internal Label Label130;
        internal Label Label131;
        internal TextBox apiMethod;
        internal Label Label134;
        internal TextBox xmlShell;
        internal Label accessType;
        internal CheckBox dontConvert;
        internal TabPage TabPage1;
        private Panel panelMax;
        internal RadioButton UseZPL;
        internal Panel viaDOSPanel;
        internal Label viadosCaution;
        internal Panel Panel17;
        internal TextBox appendAscii;
        internal RadioButton dosUseFF;
        internal RadioButton dosAddLines;
        internal TextBox dosBlankLines;
        internal Label Label115;
        internal Label Label120;
        internal Label Label122;
        internal TextBox dosParam2;
        internal TextBox dosParam1;
        internal Label batsignal;
        internal Button loadViados;
        internal CheckBox hideDosWindow;
        internal Label Label119;
        internal Label Label118;
        internal TextBox dosPlTabNum;
        internal TextBox dosPlColNum;
        internal RadioButton dosPlUseTab;
        internal RadioButton dosPlUseCol;
        internal Label Label117;
        internal Label Label114;
        internal TextBox batchDisplay;
        internal Button viadosSave;
        internal CheckBox useDOSBatch;
        internal Label FTPwarning;
        internal Label Label72;
        internal Label showLabelType;
        internal Panel orientationPanel;
        internal RadioButton usePortrait;
        internal RadioButton useLandscape;
        internal Panel marginPanel;
        internal Label inUnits1;
        internal Label Label4;
        internal TextBox inTopMargin;
        internal Label Label5;
        internal TextBox inLeftMargin;
        internal Label Label26;
        internal TextBox inLineSpacing;
        internal Label Label35;
        internal RadioButton UseLaser;
        internal RadioButton UseFTP;
        internal RadioButton UseDesktop;
        internal GroupBox FTPGroup;
        internal Label ftpRegisterMsg;
        internal Button btn_ftpRegister;
        internal Label ftpArrow;
        internal Label FTPInfo;
        internal Label Label50;
        internal Label FTPHelp;
        internal Label Label49;
        internal TextBox FTPPassword;
        internal Label Label48;
        internal TextBox FTPLogin;
        internal Label Label46;
        internal TextBox FTPip;
        internal Label Label30;
        internal Label Label16;
        internal TextBox TextBox23;
        internal TextBox TextBox22;
        internal TextBox TextBox21;
        internal TextBox TextBox20;
        internal TextBox TextBox19;
        internal Label Label22;
        internal Label Label21;
        internal Label Label20;
        internal Label Label19;
        internal Label Label18;
        internal Label Label17;
        internal TextBox TextBox17;
        internal GroupBox DesktopGroup;
        internal Label Label12;
        internal Button btnBCFontDialog;
        internal CheckBox inBCFontWeight;
        internal Label Label29;
        internal TextBox inBCFontSize;
        internal TextBox inBCFontName;
        internal Panel SheetSettings;
        internal Label Label121;
        internal Label inUnits2;
        internal Label Label11;
        internal TextBox inStartCol;
        internal TextBox inStartRow;
        internal Label Label31;
        internal Label Label32;
        internal Label batchEntries;
        internal Label Label43;
        internal NumericUpDown batchNumber;
        internal TextBox batchPreview;
        internal Button Button2;
        internal Button btnPrintBatch;
        internal Label Label42;
        internal TextBox inGapHeight;
        internal TextBox inGapWidth;
        internal TextBox inLabelHeight;
        internal TextBox inLabelWidth;
        internal TextBox inLabelCols;
        internal TextBox inLabelRows;
        internal Label Label41;
        internal Label Label40;
        internal Label Label39;
        internal Label Label38;
        internal Label Label37;
        internal Label Label36;
        internal CheckBox inFontWeight;
        internal Label Label23;
        internal TextBox inFontSize;
        internal Button FontDialogButn;
        internal TextBox inFontName;
        internal Label Label3;
        internal Button PrinterDialogButn;
        internal TextBox inPrinterName;
        internal Label Label2;
        internal TextBox inMaxLines;
        internal TextBox inMaxChars;
        internal Label Label24;
        internal Label Label25;
        internal Label Label15;
        private Panel zebraSettingsPanel;
        private ComboBox zebraPrinterBox;
        private NumericUpDown numudSplitOffset;
        private Label labelSplitOffset;
        private Label labelZebraPrinter;
        private NumericUpDown numupTopOffset;
        private Label labelTopOffset;
        private Button btnTestPrint;
        internal TextBox zplBatchPreview;
        private Panel printPanel;
        private Panel zplPrintPanel;
        internal Button zplAddBtn;
        internal Button zplPrintBtn;
    }
}