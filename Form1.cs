using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SpineLabeler
{


    public partial class Form1
    {
        // v. 9.0: Major release
        // Change langage from VB.NET to C#.NET
        // v. 8.0: Major release
        // Includes checking GitHub for new version and linking to GitHub wiki for documentation. Removed references to BC license and server.
        // 
        // v. 7.0: Major release
        // Includes option to use Alma's RESTful API URL to retrieve an item's XML file, as
        // well as the deprecated Java SOAP APIs.  The RESTful XML file is converted into
        // the SOAP XML format so that SpineOMatic can process the file without major 
        // modification to the software.
        // 
        // v. 6.12: Minor trial release
        // Allows the ! (render as bar code) formatting code to be used in custom Pocket Labels.
        // Will be distributed to one user who wanted the feature, and included in subsequent
        // releases if it is acceptable.
        // 
        // v. 6.11: Minor release
        // Clarified and changed LC/LC child lit./NLM and Dewey parsing behavior:
        // Tweak and Test panel for the LC... parser: "Decimal" break description was changed to
        // "Class Decimal".  Fixed a bug in "Break before decimal" that was causing a break
        // after the decimal rather than before. An option was added to allow break both before
        // or after the decimal.
        // An option was added to the Dewey parser to allow breaking on the cutter decimal
        // string after a specific number of characters following the decimal.
        // 
        // v. 6.1: Minor release
        // Fixed bug in "*" format code ("Suppress field display");
        // Added check for unbalanced quotation marks in "Quoted text" format code.
        // 
        // v. 6.0: Major release features:
        // Holdings processor now lets user select no holdings, textual holdings parsed by SpineOMatic,
        // or Ex Libris' Parsed Holdings fields.  If Parsed Holdings are specified but do not exist,
        // SpineOMatic will parse the textual holdings.  The display will indicated which call number
        // parser was used, and also which holdings parser was used.
        // Asterisk (*) formatting code ("suppress" field display) suppresses display if the XML field
        // is blank, or if the field is equal to any of three user-defined values.
        // Tweak and Test SuDoc parser allows breaking on "Other" characters, with option
        // to remove characters. (Behavior is consistent with LC, Dewey and Other parsers.)
        // Dewey parser provides an option to print long numeric class numbers in groups of characters.
        // New print option to send label text to a custom DOS batch file ("viados.bat"), which can
        // print to legacy printers attached via LPT or COM ports, etc.
        // Margins and line spacing can be entered in inches or centimeters.
        // A decimal point or a comma can represent decimal fractions.
        // Allows negative top margin and left margin settings.
        // To insert XML field names into text boxes that allow it, items can be selected from
        // a list of all XML fields (rather than typing the names).
        // 
        // v. 5.21: Minor release to handle unencoded ampersands in the item's XML record.
        // Added the tilde (~) character to stand for space characters in the Tweak and Test 
        // Other Break text strings.
        // Changed the "Hide cutter decimal" routine from removing all decimals to removing only
        // the first character, if it is a decimal.
        // 
        // v. 5.2: Minor release to fix a bug in the multi-label print to Desktop routine, which failed to
        // change the print button from "Stop" to "Send to Desktop Printer".
        // 
        // v. 5.1: Minor release to fix the Holdings parser, which was causing spaces between elements
        // to be removed.
        // A "Break on spaces" checkbox was added to the Holdings parser's Tweak and Test panel;
        // Made improvements to the management of default settings for Spine, Custom, Custom/Flag slips 
        // and Pocket Labels
        // A "copy to clipboard" feature was added to send Report text and CurrentXML/settings.som
        // text to the Windows clipboard.
        // 
        // v. 5.0: Major release to add Pocket Label printing;
        // Repairs errors due to unencoded angle bracket characters appearing in the data of
        // returned XML files.
        // Does not check the arc.bc.edu:8080 server at startup, but only when Check for
        // Updates is clicked.  (Due to occasional arc crashes that prevent SpineOMatic from
        // starting.)
        // Allows any call_number_type to be handled by any of SpineOMatic's parsing routines. 
        // Blank <call_number_type> can be converted to any specified type (0 - 8).
        // Added option to the LC Tweak and Test panel to suppress the decimal that normally
        // precedes the cutter.
        // Added a Holdings parser to the Tweak and Test panels.
        // Call number formats (Spine, Custom & Custom w/Flag Slips and Pocket Labels) each 
        // have their own separate set of margin settings and other defaults.
        // Added formatting characters "^" to suppress newline after field, "*" to
        // suppresse display of a field if it is blank or zero, and "+" to look up <location_name>
        // in the Label Prefixes table and use the label text (that allows line breaks via semicolons).  
        // Increased maximum number of label copies from 5 to 99. 
        // Added a "cancel print" option for Desktop printing, and added a warning for Batch 
        // and FTP printing if more than 5 label copies are requested.
        // Added keyboard shortcut CTRL p to trigger a manual print without having to use 
        // the mouse.  
        // Added a License Agreement that requires the user to either accept terms or cancel 
        // installation on first use of software, change of version, or relocation to a different PC.
        // 
        // v. 4.32: Minor release to fix wrapping (if wrapping was turned on for one field, it
        // stayed on for other fields that did not specify wrapping).  Added a formatting
        // code to add a text prefix to custom label fields, as well as to Spine fields
        // "Include holdings" and "Include other value".  Double quotes around text cause
        // text to be prefixed to the printed value. Eg: "copy: "<copy_id>
        // Redid the fix (originally in v. 4.3) that was supposed to prevent loss of Custom
        // fields upon saving.  
        // 
        // v. 4.31: Minor release to fix a bug that prevented "Include holdings" from working.
        // This is the first release to use two digits after the decimal of the release number.
        // 
        // v. 4.3: Fixed a bug causing multi-cuttered LC call numbers to hide the decimal when
        // breaking on cutter.  Fixed bug that caused Custom fields to be lost when
        // user saved settings while Flag Slips checkbox was checked.
        // Replaced code written to parse the Ex Libris XML file with VB.NET's XML parser.
        // Also alerted user if errors were detected in
        // user-specified XML fields, i.e., not found, extraneous characters, etc.  
        // Checkbox added to either display error alert only, or to pop up a detailed message. 
        // Added ability for user to add formatting characters to Custom fields:
        // (%=parse call#, #=parse holdings, !=render as barcode, ~=add space) before entry. 
        // Also allowed space (~) to be added before "Other" field in Spine label section.
        // Added multi-label print capability, allowing label to be printed from 1 to 5 times.
        // 
        // v. 4.2: Fixed a bug to allow SpineOMatic to recognize international date settings. 
        // Added Tweak and Test panel to allow user to modify the behaviors of
        // SpineOMatic's parsing routines.
        // Added a Dewey Decimal and an "Other" parser.
        // Moved the Test Parsing section from Java Setup to
        // the Tweak and Test Parsing panel.  Removed the portrait/landscape distinction
        // when SpineOMatic parsed SuDoc numbers.  User can now set up parsing for one or
        // the other.
        // Added better checking for Java URL problems and credential issues.
        // If the customer's PC cannot connect to BC servers due to blocking by their 
        // proxy server, a message tells them to whitelist the BC servers.
        // 
        // v. 4.1: Changes to wording and layout of Print Flag Slips checkbox and Label Printing
        // Web Service Credentials. 
        // 
        // v. 4.0: Removed need to provide a folder to receive Alma XML file.  The installation
        // directory will be used by default;
        // Imported graphic background for the About box that contains the BC seal graphic; 
        // Java app class file and alma-sdk files are now automatically downloaded if needed, 
        // without manual intervention;
        // Added separate margin/orientation/maximum settings for Flag Slips.  Toggling the 
        // "print flag slips" checkbox calls up Flag Slip settings or returns to standard settings;
        // The Java application is now run as a process from within vb rather than as an
        // external .bat file. Java installation is verified, and problems locating or 
        // accessing java are reported to the user.
        // A list of servers can be specified from which to obtain updates (i.e., the updatePath.
        // If the default server fails, each server in the list is tried in turn to try to find
        // a working server.  If none can be found, a "fail" message is displayed.
        // =======================================================================================
        // v. 3.3: Added SuDoc parsing for portrait and landscape modes; Changes to error checking
        // and AboveCall#Text behavior; 
        // 
        // v. 3.2: Added ability to put an additional field (e.g., <copy_id>) at end of spine label;
        // Ensured label text in OutputBox does not end with unnecessary cr/lf;
        // Fixed bug in Above Call# Text that produced incorrect matching.
        // Limited User ID to 8 alpha characters.
        // 
        // v. 3.1: Added Station name and User ID; Reports; Test Parsing; better LC/LC Children's lit/NLM
        // call number parsing.
        // 
        // v. 3.0: Cosmetic changes to admin panels; added "About" box with download/view
        // of associated documentation. Added access to Alma Label Printing Web Service
        // via desktop java app; Added option to use Ex Libris parsed call numbers.
        // =======================================================================================
        // v. 2.6: for "Custom" labels, text not enclosed in angle brackets (<...>) will print as-is on the label
        // Bug fix: manual print button now checks line lengths against max. chars/line;
        // v. 2.5: adds textbox for url to Alma Label Printing Web Service
        // v. 2.4: adds barcode font dialog selection for use in flag slips;
        // v. 2.3: dlgSettings.UseEXDialog = True to enable print dialog selection in Windows 7
        // v. 2.2: corrects spacing & punctuation errors in incoming call numbers (for TML);
        // v. ...: 
        private string somVersion = "9.0.0";
        private string javaClassName = "almalabelu2"; // the java class name
        private string javaSDKName = "alma-sdk.1.0.jar"; // the Ex Libris SDK for web services
        private string javaTest = "javatest"; // java class that reports presence and version of java
        private string mypath = ""; // path of startup directory will be used as mypath
        private string servers = "arc.bc.edu:8080|libstaff.bc.edu:8080|mlib.bc.edu:8080";
        private string lcxml = "";
        private string issuexml = "";
        private string locxml = "";
        private string libxml = "";
        private string otherxml = "";
        private string titlexml = "";
        private string libraryxml = "";
        private int pixelsPerInchX = 0;
        private int pixelsPerInchY = 0;
        private int changeCount = 0;
        private string xmlReturned = "";
        private string settings = "";
        private int winFrom = 0;
        private int winTo = 0;
        private Array wline = null;
        private int wlinesToPrint = 0;
        private string origText = "";
        private string editText = "";
        private int maxLines = 0;
        private Array LABELS;
        private int nxt = 0;
        private int horizPos = 0;
        private string fontname = "";
        private float fontsize = 0.0f;
        private FontStyle fWeight;
        private FontStyle bcWeight;
        private float topMargin = 0.0f;
        private float leftMargin = 0.0f;
        private float lineSpacing = 0.0f;
        private int labelRows;
        private int labelCols;
        private float labelWidth;
        private float labelHeight;
        private float gapWidth;
        private float gapHeight;
        private string original_settings = "";
        private string closing_settings = "";
        private TabPage saveTab;
        private string lastxml = "";
        private bool ignoreChange = true;
        private string ALTfile = "";
        private bool madeALTchanges = false;
        private string statrec;
        private string lastbc = "";
        private string cntype;
        private string almaReturnCode = "";
        private string almaLibrary = "";
        private string almaLocation = "";
        private string usermessage = "";
        private bool settingsfound = true;
        private bool settingsLoaded = false;
        private bool settingsOpen = false;
        private bool logView = false;
        private string flagSlipDefaults = "";
        private bool firstPage = true;
        private string otherList = "";
        private string xmlerr = "";
        private bool indenting = false;
        private bool wrapping = false;
        private int totalLines = 0;
        private int labelCount = 0;
        private bool needTypeCheck = false; // alerts if call number parsers have been changed
        private XmlDocument xdoc = new XmlDocument();
        private bool warranty_accepted = true;
        private int spin = 1;
        private bool stopPrinting = false;
        private bool spineDefaultLoaded = false;
        private bool customNonFlagDefaultLoaded = false;
        private bool customFlagDefaultLoaded = false;
        private bool pocketDefaultLoaded = false;
        private WebClient client;
        private bool licenseDeclined = true;
        private string pcname = "";
        private bool spineVerticalLine;
        private bool nonFlagVerticalLine;
        private bool flagVerticalLine;
        private bool pocketVerticalLine;
        private bool usingDewey = false;
        private TextBox xtb;
        private Color xtbOrigColor;
        private const int LB_SETTABSTOPS = 0xCB;
        private ArrayList zplBatchAL = new ArrayList();

        public Form1()
        {
            client = new WebClient();
            InitializeComponent();

            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                zebraPrinterBox.Items.Add(pkInstalledPrinters);
            }
        }


        [DllImport("user32.dll")]
        // DLL import is used to set margins in the Reports ("StatsOut") textbox
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private void SetTabs()
        {
            // {0, 65, 110, 165, 240, 255} (original settings)
            int[] ListBoxTabs = new int[] { 0, 60, 110, 180, 240, 255 };
            int result;
            IntPtr ptr;
            GCHandle pinnedArray;

            pinnedArray = GCHandle.Alloc(ListBoxTabs, GCHandleType.Pinned);
            ptr = pinnedArray.AddrOfPinnedObject();
            // Send LB_SETTABSTOPS message to TextBox.
            result = SendMessage(statsOut.Handle, LB_SETTABSTOPS, new IntPtr(ListBoxTabs.Length), ptr);
            pinnedArray.Free();

            // Refresh the TextBox control.
            statsOut.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (licenseDeclined)
                return;
            string resp = "";
            writeStat("S"); // write "S" (scanned, not printed) to statrec, and write to stat file.
            if (madeALTchanges == true)
            {
                DialogResult box = MessageBox.Show("Changes to your local label text file have not been saved." + Constants.vbCrLf + "Do you want to save them now?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (box == DialogResult.Yes)
                {
                    btn_saveALT.PerformClick();
                    Interaction.MsgBox("Changes to your local label text file have been saved.", MsgBoxStyle.Information, "Settings Saved");
                    madeALTchanges = false;
                }
            }
            saveSettings("tostring"); // put current settings into the closing_settings string
            closing_settings = closing_settings.Replace(Constants.vbLf, "");
            original_settings = original_settings.Replace(Constants.vbLf, "");
            if ((original_settings ?? "") != (closing_settings ?? ""))
            {
                // Clipboard.SetText("orig:" & vbCrLf & original_settings & vbCrLf & "new:" & vbCrLf & closing_settings)
                DialogResult box = MessageBox.Show("Your settings have changed, but have not been saved." + Constants.vbCrLf + "Do you want to save them now?" + Constants.vbCrLf + Constants.vbCrLf + "(Click CANCEL to continue working.)", "Save Settings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (box == DialogResult.Yes)
                {
                    saveSettings("todisk");
                    Interaction.MsgBox("Your settings have been saved.", MsgBoxStyle.Information, "Settings Saved");
                }
                else if (box == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) == 1) // keychar 1 = "CTRL a"
            {
                e.Handled = true;
                if (settingsOpen == false)
                {
                    openSettings();
                }
                else
                {
                    // Me.CloseSettings_Click(Nothing, Nothing)
                    CloseSettings();
                }
            }
            if (Strings.Asc(e.KeyChar) == 16) // CTRL p
            {
                e.Handled = true;
                ManualPrint.PerformClick();
            }

        }
        private void NumericKeyPress(object sender, KeyPressEventArgs e)  // Handles TextBox.KeyPress
        {
            TextBox tb = (TextBox)sender;
            string dc = "";
            if (decimalDOT.Checked)
                dc = ".";
            else
                dc = ",";
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | Conversions.ToString(e.KeyChar) == dc & tb.Text.IndexOf(dc) < 0))
            {
                e.Handled = true;
                Interaction.Beep();
                return;
            }
        }
        private void NegativeKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string dc = "";
            if (decimalDOT.Checked)
                dc = ".";
            else
                dc = ",";
            if (!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | Conversions.ToString(e.KeyChar) == dc & tb.Text.IndexOf(dc) < 0 | Conversions.ToString(e.KeyChar) == "-"))
            {
                e.Handled = true;
                Interaction.Beep();
            }
        }

        private void NumericLeave(object sender, EventArgs e)  // Handles TextBox.KeyPress
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
            }
        }
        private void limitValues(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!"234567".Contains(Conversions.ToString(e.KeyChar)))
            {
                e.Handled = true;
                Interaction.Beep();
            }
            else
            {
                // deweydigitsperline.Text = e.KeyChar
                ((dynamic)sender).Text = e.KeyChar;
                e.Handled = true;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            settingsfound = true;
            string disclaimerInfo = "";
            string currentLicense = "";
            pcname = Dns.GetHostName();
            KeyPreview = true;
            Show();
            mypath = AppDomain.CurrentDomain.BaseDirectory;
            Text = "SpineOMatic " + somVersion;
            CloseSettings(); // close the settings panels
            Application.DoEvents();
            continueFormLoad();

        }

        private void continueFormLoad()
        {
            licenseDeclined = false;
            GetSettingsFile();
            // CloseSettings() Let the "GetSettingsFile" routine determine if settings exist or not.
            // If no settings file exists, panels should remain open
            Application.DoEvents();
            settingsLoaded = true;
            original_settings = RichTextBox1.Text;
            XMLPath.Text = mypath; // path is now always set to the installation directory, "mypath"
            try
            {
                FileSystemWatcher1.Path = XMLPath.Text;
                FileSystemWatcher2.Path = XMLPath.Text;
            }
            catch
            {
                Interaction.MsgBox("Directory to watch for incoming XML files is not valid." + Constants.vbCrLf + "Path = " + XMLPath.Text, MsgBoxStyle.Exclamation, "Invalid Path");
                FileSystemWatcher1.Path = "";
            }

            batchPreview.Text = GetBatch((int)Math.Round(batchNumber.Value));
            if (batchPreview.Lines.Length > 0)
            {
                // batchEntries.Text = batchPreview.Lines.Length - 1
                batchEntries.Text = countBatch();
            }
            else
            {
                batchEntries.Text = "0";
            }
            btnMonitor.Enabled = false;

            createBatFiles();

            downloadAboveLcFile();
            Application.DoEvents();
            loadLabelText();
            lblStation.Text = station.Text;
            usermessage = "Please enter your User ID in the 'User:' box above." + Constants.vbCrLf + Constants.vbCrLf + "The ID must be 8 characters or less." + Constants.vbCrLf + Constants.vbCrLf + "When done, press the ENTER key.";
            if (chkRequireUser.Checked)
            {
                usrname.Enabled = true;
                OutputBox.Text = usermessage;
                usrname.BackColor = Color.Yellow;
                usrname.Focus();
            }
            else
            {
                usrname.Text = "[none]";
                usrname.Enabled = false;
                InputBox.Select();
                InputBox.Focus();
            }

            var date1 = DateTime.Now;
            var dtNow = DateTime.Now;
            var dtFirstOfMonth = dtNow.AddDays(-dtNow.Day + 1);
            fromScan.Format = DateTimePickerFormat.Short;
            fromScan.CustomFormat = "MM/dd/yyyy";
            toScan.Format = DateTimePickerFormat.Short;
            toScan.CustomFormat = "MM/dd/yyyy";
            // toScan.Value = DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture)
            // toScan.Value = date1.Month & "/" & date1.Day & "/" & date1.Year
            fromScan.Value = dtFirstOfMonth;

            toScan.Value = Conversions.ToDate(date1.Date.ToString());
            SetTabs(); // change tab settings of the Reports textbox.

            TabControl1.SelectedIndex = 1;
            TabControl1.SelectedIndex = 0;
            lbl_setclipboard.ForeColor = Color.MediumBlue;
            InputBox.Focus();
        }



        private string countBatch()
        {
            int ln = -1;
            int pos = 1;
            do
            {
                pos = Strings.InStr(pos + 1, batchPreview.Text, "===============", CompareMethod.Text);
                ln = ln + 1;
            }
            while (pos != 0);
            return (ln + 1).ToString();
        }
        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            // Watches a selected directory for the arrival of an Ex Libris' Alma item XML file
            // and generates a spine label when one arrives.
            // 
            // If the file is being written into the directory by another application (i.e., a
            // Java program that retrieves the Alma file and writes in into the specified
            // directory), the FileSystemWatcher may fire before the file is completely written.
            // This routine waits until the file can be successfully read.  It tries up to 20
            // times, waiting 100ms between tries.
            bool fileFound = false;
            int loopcnt;
            loopcnt = 20;

            while (loopcnt > 0)
            {
                try
                {
                    TextReader tr = new StreamReader(e.FullPath);
                    xmlReturned = tr.ReadToEnd();
                    tr.Close();
                    fileFound = true;
                    break;
                }
                catch (Exception ex)
                {
                    loopcnt = loopcnt - 1;
                    Thread.Sleep(100);
                }
            }

            if (fileFound)
            {
                InputBox.Text = e.Name.Replace(".xml", "");
                lastxml = e.FullPath;

                // If xmlReturned.Contains("<bib_data link") Then
                // xmlReturned = convertRESTfulXML()
                // End If

                getBarcodeFile();
                if (AutoPrintBox.Checked)
                {
                    ManualPrint.PerformClick();
                }
            }
            else
            {
                Interaction.MsgBox("The complete Alma XML file did not arrive: " + e.FullPath, MsgBoxStyle.Exclamation, "File Incomplete");
            }
        }

        private string convertRESTfulXML()
        {
            // Converts RESTful XML files into depricated SOAP format so that existing SpineOMatic code can 
            // be used with the new XML format.
            var doc = new XmlDocument();
            string t = "";
            string cn = "";
            string ct = "";
            string n = "";
            string titl = "";
            string cntype = "";
            int e;
            XmlNode mynode;
            XmlNode anode;
            XmlNodeList nl;
            string pcn = ""; // parsed call number
            string pild = ""; // parsed issue level description
            int i = 0;

            // The RESTful XML text is loaded into an XML document
            doc.LoadXml(xmlReturned);
            var elemList = doc.GetElementsByTagName("item_data"); // most user fields are under
                                                                  // <item_data>...</item_data>

            // Put all RESTful <item_data> fields into string "t"
            var loopTo = elemList.Count - 1;
            for (e = 0; e <= loopTo; e++)
                t = elemList[e].InnerXml + Constants.vbCrLf;

            // RESTful parsed_call_number and parsed_issue_level_description fields need to be modified 
            // in the final text.  Here is where we remove these fields from the text string "t":
            if (t.Contains("<parsed_call_number"))
            {
                t = t.Substring(0, t.IndexOf("<parsed_call_number>")) + t.Substring(t.IndexOf("</parsed_call_number>") + 21);
            }
            if (t.Contains("<parsed_issue_level_description>"))
            {
                t = t.Substring(0, t.IndexOf("<parsed_issue_level_description>")) + t.Substring(t.IndexOf("</parsed_issue_level_description>") + 32);
            }

            // These routines step through each element of the <parsed_call_number> and <parsed_issue_level_desctiption>
            // fields in the XML document, and a sequence number is added to the XML field names.
            // Ex:  <call_no>BX</call_no>  is changed to <call_no_1>BX</call_no_1>, etc...
            i = 1;
            pcn = "";
            foreach (XmlNode currentMynode in doc.SelectNodes("/item/item_data/parsed_call_number/*"))
            {
                mynode = currentMynode;
                if (mynode == null)
                    break;
                pcn = pcn + "<call_no_" + i + ">" + mynode.InnerXml + "</call_no_" + i + ">" + Constants.vbCrLf;
                i = i + 1;
            }
            pcn = "<parsed_call_number>" + Constants.vbCrLf + pcn + Constants.vbCrLf + "</parsed_call_number>";

            i = 1;
            pild = "";
            foreach (XmlNode currentMynode1 in doc.SelectNodes("/item/item_data/parsed_issue_level_description/*"))
            {
                mynode = currentMynode1;
                if (mynode == null)
                    break;
                pild = pild + "<issue_level_description_" + i + ">" + mynode.InnerXml + "</issue_level_description_" + i + ">" + Constants.vbCrLf;
                i = i + 1;
            }
            pild = "<parsed_issue_level_description>" + Constants.vbCrLf + pild + Constants.vbCrLf + "</parsed_issue_level_description>";
            // the new fields are stored in variables 'pcn' (parsed call number) and 'pild' (parsed issue level description)
            // fields, and these modified fields are added back to string "t" later in the process.

            // <call_number> is not in the <item_data> section, so it's put in variable 'cn' and added to string 't' later
            nl = doc.GetElementsByTagName("call_number");
            cn = nl[0].OuterXml;

            // <call_number_type> is not in <item_data> either, so it is extracted in 'ct', and later added to string 't'
            nl = doc.GetElementsByTagName("call_number_type");
            ct = "<call_number_type>" + nl[0].InnerXml + "</call_number_type>";

            // <title> is not in <item_data>, so it is extracted to 'nl' and added back to string 't' later.
            nl = doc.GetElementsByTagName("title");
            titl = nl[0].OuterXml;

            // <library desc="O'Neill">ONL</library>' is changed into two fields:
            // 1) <library_code>ONL</library_code>
            // 2) <library_name>O'Neill</library_name>
            // liname and licode are added to string 't'
            var lid = doc.GetElementsByTagName("library");
            string licode = "<library_code>" + lid[0].InnerXml + "</library_code>";
            anode = doc.SelectSingleNode("//library");
            string liname = "<library_name>" + anode.Attributes[0].Value + "</library_name>";

            // <location desc="Offsite Collection (RM150 GOVD)">RM150_GOVD</location>  is changed into:
            // 1) <location_name>Offsite Collection (RM150 GOVD)</location_name>
            // 2) <location_code>RM150_GOVD</location_code>
            // lod and locode are added to string 't'
            var lod = doc.GetElementsByTagName("location");
            string locode = "<location_code>" + lod[0].InnerXml + "</location_code>";
            anode = doc.SelectSingleNode("//location");
            string loname = "<location_name>" + anode.Attributes[0].Value + "</location_name>";

            // all the new XML elements that were relocated or created are added back to string 't', and 
            // string 't' is inserted into an 'XmlShell' invisible text box, replacing the text "**XMLBODY**"
            // that identifies the spot where the new XML is to be interted.
            xmlReturned = xmlShell.Text.Replace("**XMLBODY**", cn + Constants.vbCrLf + ct + Constants.vbCrLf + titl + Constants.vbCrLf + licode + Constants.vbCrLf + liname + Constants.vbCrLf + loname + locode + Constants.vbCrLf + pcn + Constants.vbCrLf + pild + Constants.vbCrLf + t);

            // the new RESTful "<description>" field names are changed to <issue_level_description>, to
            // mimic the SOAP naming convention
            xmlReturned = xmlReturned.Replace("<description>", "<issue_level_description>");
            xmlReturned = xmlReturned.Replace("</description>", "</issue_level_description>");

            return xmlReturned;
        }

        private void ManualPrint_Click(object sender, EventArgs e)
        {
            // manual print
            if (ManualPrint.Text == "Stop Printing")
            {
                stopPrinting = true;
                SetPrintButtonText();
                return;
            }
            string dayTime = "";
            string logentry = "";
            string barcodenum = "";
            int lencheck = 0;
            Array chkline = null;
            int maxlines = Conversions.ToInteger(inMaxLines.Text);
            bool linesOK = true;
            int maxchars = Conversions.ToInteger(inMaxChars.Text);
            int repeat = 0;
            int i = 0;
            string batchText = "";
            string labelin;
            plDistance.BackColor = Color.White;
            if (chkUsePocketLabels.Checked)
            {
                if (btnSL4.Checked | btnSL6.Checked | btnPlCustom.Checked & PLcount.Value == 2m)
                {
                    if ((double)Conversions.ToSingle(plDistance.Text) == 0.0d)
                    {
                        plDistance.BackColor = Color.Pink;
                        Interaction.MsgBox("When printing two pocket labels, you must specify a vertical distance" + Constants.vbCrLf + "between the top lines of the two labels.", MsgBoxStyle.Exclamation, "No Distance Specified");
                        plDistance.Focus();
                        return;
                    }
                }
            }

            if (string.IsNullOrEmpty(Strings.Trim(OutputBox.Text)))
            {
                Interaction.Beep();
                InputBox.Focus();
                return;
            }
            editText = OutputBox.Text;
            barcodenum = InputBox.Text;
            if ((editText ?? "") != (origText ?? "") & !string.IsNullOrEmpty(barcodenum) & logEdits.Checked)
            {
                dayTime = DateTime.Now.ToString("ddd MMM d, yyyy HH:mm", CultureInfo.InvariantCulture);
                logentry = dayTime + Constants.vbTab + barcodenum + Constants.vbTab + origText.Replace(Constants.vbCrLf, "|") + Constants.vbTab + editText.Replace(Constants.vbCrLf, "|");
                writeFile(mypath + "changelog.txt", logentry, true);
                editText = "";
                origText = "";
            }

            if (OutputBox.Text.Contains("** ERROR **"))
            {
                Interaction.Beep();
                Interaction.MsgBox("Could not find this barcode number in Alma.", MsgBoxStyle.Exclamation, "Barcode Number Error");
                return;
            }
            if (OutputBox.Text.Contains("Java: **"))
            {
                Interaction.Beep();
                Interaction.MsgBox("Could not contact Alma.", MsgBoxStyle.Exclamation, "Connection Error");
            }
            lencheck = checkLineLength();
            chkline = Strings.Split(OutputBox.Text, Constants.vbCrLf);
            if (lencheck != 99)
            {
                // chkline = Split(OutputBox.Text, vbCrLf)
                Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Line #" + lencheck + ":" + Constants.vbCrLf, chkline.GetValue(lencheck - 1)), Constants.vbCrLf), " contains more than "), maxchars), " characters."));
                return;
            }
            if (chkline.Length > maxlines)
            {
                Interaction.Beep();
                Interaction.MsgBox("Lable contains more than " + maxlines + " lines.", MsgBoxStyle.Exclamation, "Too Many Lines");
                return;
            }
            if (lblXMLWarn.Visible == true)
            {
                Interaction.Beep();
                Interaction.MsgBox("An XML <field> used in your settings is incorrect.", MsgBoxStyle.Exclamation, "XML Reference Error");
                return;
            }

            // ********************
            // Use DOS Batch File
            // ********************
            if (useDOSBatch.Checked)
            {
                string txtout = "";
                int extraLines = Conversions.ToInteger(dosBlankLines.Text);
                string addcr = "";
                int tabpos = 0;
                int k = 0;
                int extraSpaces = Conversions.ToInteger(dosPlColNum.Text);
                int tabcount = Conversions.ToInteger(dosPlTabNum.Text);
                string addsp = "";
                Array taray;
                string mg = "";

                if (chkUsePocketLabels.Checked)
                {
                    taray = packagePocket().Split(Conversions.ToChar(Constants.vbCrLf));
                    txtout = "";
                    var loopTo = taray.Length - 1;
                    for (k = 0; k <= loopTo; k++)
                    {
                        tabpos = Conversions.ToInteger(taray.GetValue(k).ToString().Replace(Constants.vbLf, "").IndexOf(Constants.vbTab));
                        if (dosPlUseCol.Checked)
                        {
                            addsp = new string(' ', extraSpaces - tabpos);
                            txtout = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(txtout, taray.GetValue(k).ToString().Replace(Constants.vbTab, addsp)), Constants.vbCrLf));
                        }
                        else
                        {
                            if (tabcount > 1)
                            {
                                addsp = new string(Conversions.ToChar(Constants.vbTab), tabcount);
                            }
                            else
                            {
                                addsp = Constants.vbTab;
                            }
                            txtout = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(txtout, taray.GetValue(k).ToString().Replace(Constants.vbTab, addsp)), Constants.vbCrLf));
                        }
                    }
                    txtout = txtout + terminator(taray.Length);
                }
                else
                {
                    txtout = txtout + OutputBox.Text + terminator(OutputBox.Lines.Length);
                }

                viaDOS(txtout);
                return;
            }

            if (UseDesktop.Checked)
            {
                getPrintParams();
                PrintDocument2.PrinterSettings.PrinterName = inPrinterName.Text;
                PrintDocument2.PrintController = new StandardPrintController();

                if (chkUsePocketLabels.Checked)
                {
                    labelin = packagePocket();
                    labelin = labelin.Replace(Constants.vbCrLf, "|");
                }
                else
                {
                    labelin = OutputBox.Text.Replace(Constants.vbCrLf, "|");
                }

                // For desktop printing, only one label will be in the "LABELS" array,
                // but the print routine always uses the LABELS array to get its input,
                // for single label printing and for multi-label batch printing.
                LABELS = labelin.Split(Conversions.ToChar(Constants.vbCrLf));

                repeat = (int)Math.Round(LabelRepeat.Value);
                if (repeat > 1 & ManualPrint.Text != "Stop Printing")
                {
                    ManualPrint.Text = "Stop Printing";
                    printProgress.Visible = true;
                    Application.DoEvents();
                }
                var loopTo1 = repeat;
                for (i = 1; i <= loopTo1; i++)
                {
                    Application.DoEvents();
                    if (stopPrinting)
                    {
                        SetPrintButtonText();
                        stopPrinting = false;
                        printProgress.Visible = false;
                        break;
                    }
                    try
                    {
                        printProgress.Text = "Printing " + i + " of" + repeat;
                        Application.DoEvents();
                        PrintDocument2.Print();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Printer settings are not correct." + Constants.vbCrLf + "Make sure a valid printer has been selected, and try again." + Constants.vbCrLf + ex.ToString(), MsgBoxStyle.Exclamation, "Printer Selection Error");
                        break;
                    }
                }
                // ********************
                SetPrintButtonText();
                // ********************
                printProgress.Visible = false;
                nxt = 0;
                writeStat("P"); // add P to end of statrec and write to statfile.
                OutputBox.Text = "";
                plOutput.Text = "";
                TempLabelBox.Text = "";
                InputBox.Text = "";
                InputBox.Focus();
            }
            if (UseLaser.Checked) // SAVE TO BATCH
            {
                repeat = (int)Math.Round(LabelRepeat.Value);
                if (repeat > 5 && MessageBox.Show(repeat + " labels will be printed.", "Confirm Multipl Label Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    return;

                if (chkUsePocketLabels.Checked)
                {
                    batchText = packagePocket();
                }
                else
                {
                    batchText = OutputBox.Text;
                }
                repeat = (int)Math.Round(LabelRepeat.Value);
                var loopTo2 = repeat;
                for (i = 1; i <= loopTo2; i++)
                    sendToBatch2(batchText);
                writeStat("B"); // add B to end of statrec and write to statfile
                OutputBox.Text = "";
                plOutput.Text = "";
                TempLabelBox.Text = "";
                InputBox.Text = "";
                InputBox.Focus();
                
            }
            if (UseFTP.Checked)
            {
                repeat = (int)Math.Round(LabelRepeat.Value);
                if (repeat > 5 && MessageBox.Show(repeat + " labels will be printed.", "Confirm Multipl Label Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    return;
                ftpPrint();
            }

        }

        private void zplPrintBtn_Click(object sender, EventArgs e)
        {
            // TODO JF
            string barcode = getval("barcode");
            string title = getval("title");
            if (title.Length > 21)
            {
                title = title.Substring(0, 20);
            }
            if (OutputBox.Text.Length > 0)
            {
                string labelData = title + Constants.vbCrLf + barcode + Constants.vbCrLf + OutputBox.Text;
                // MessageBox.Show(labelData);
                string labelTxt = labelData.Replace(Constants.vbCrLf, "|");
                zplPrint(labelTxt);
            }
            if (zplBatchAL.Count > 0)
            {
                foreach (Object obj in zplBatchAL)
                {
                    string labelData = obj.ToString();
                    // MessageBox.Show(labelData);
                    string labelTxt = labelData.Replace(Constants.vbCrLf, "|");
                    zplPrint(labelTxt);
                }
            }
            OutputBox.Text = "";
            InputBox.Text = "";
            zplBatchPreview.Text = "";
            zplBatchAL.Clear();
        }

        private void zplPrint(string labelStr)
        {
            var lineAr = new List<string>(labelStr.Split('|'));
            string title = lineAr[0];
            string barcode = lineAr[1];
            lineAr.RemoveRange(0,2);

            // MessageBox.Show(lineAr.Count.ToString());
            int maxLineLn = 0;
            foreach (String line in lineAr)
            {
                if (line.Length > maxLineLn)
                {
                    maxLineLn = line.Length;
                }
            }
            // ZPL Command(s)
            int so = Convert.ToInt16(numudSplitOffset.Value);
            int to = Convert.ToInt16(numupTopOffset.Value);

            int xa = so;
            int ya = to;
            string ZPLString = "^XA^CI28";
            xa = so - 55;
            ya = to + 25;
            ZPLString += "^FO" + xa + "," + ya + "^A0R40,40^FD" + title + "^FS";
            xa = so - 125;
            ZPLString += "^FO" + xa + "," + ya + "^A0R50,50^FD" + barcode + "^FS";
            xa = so + 15;
            int xb = so + 16;
            int yb = to + 26;

            if (lineAr.Count <= 6 && maxLineLn <= 8)
            {
                if (lineAr.Count >= 1)
                {
                    ya = to + 30;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[0] + "^FS";
                }
                if (lineAr.Count >= 2)
                {
                    ya = to + 90;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[1] + "^FS";
                }
                if (lineAr.Count >= 3)
                {
                    ya = to + 150;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[2] + "^FS";
                }
                if (lineAr.Count >= 4)
                {
                    ya = to + 210;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[3] + "^FS";
                }
                if (lineAr.Count >= 5)
                {
                    ya = to + 270;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[4] + "^FS";
                }
                if (lineAr.Count >= 6)
                {
                    ya = to + 330;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FD" + lineAr[5] + "^FS";
                }
            }
            else if (lineAr.Count <= 7 && maxLineLn <= 10)
            {
                ya = to + 25;
                ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[0] + "^FS";
                ya = to + 75;
                ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[1] + "^FS";
                ya = to + 125;
                ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[2] + "^FS";
                if (lineAr.Count >= 4)
                {
                    ya = to + 175;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[3] + "^FS";
                }
                if (lineAr.Count >= 5)
                {
                    ya = to + 225;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[4] + "^FS";
                }
                if (lineAr.Count >= 6)
                {
                    ya = to + 275;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[5] + "^FS";
                }
                if (lineAr.Count >= 7)
                {
                    ya = to + 325;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FD" + lineAr[6] + "^FS";
                }
            }
            else if (lineAr.Count <= 8 && maxLineLn <= 12)
            {
                ya = to + 25;
                ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[0] + "^FS";
                yb = to + 26;
                ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[0] + "^FS";
                ya = to + 70;
                ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[1] + "^FS";
                yb = to + 71;
                ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[1] + "^FS";
                ya = to + 115;
                ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[2] + "^FS";
                yb = to + 116;
                ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[2] + "^FS";
                if (lineAr.Count >= 4)
                {
                    ya = to + 160;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[3] + "^FS";
                    yb = to + 161;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[3] + "^FS";
                }
                if (lineAr.Count >= 5)
                {
                    ya = to + 205;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[4] + "^FS";
                    yb = to + 206;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[4] + "^FS";
                }
                if (lineAr.Count >= 6)
                {
                    ya = to + 250;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[5] + "^FS";
                    yb = to + 251;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[5] + "^FS";
                }
                if (lineAr.Count >= 7)
                {
                    ya = to + 295;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[6] + "^FS";
                    yb = to + 296;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[6] + "^FS";
                }
                if (lineAr.Count >= 8)
                {
                    ya = to + 340;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FD" + lineAr[7] + "^FS";
                    yb = to + 341;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FD" + lineAr[7] + "^FS";
                }
            }
            else
            {
                ya = to + 25;
                ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[0] + "^FS";
                yb = to + 26;
                ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[0] + "^FS";
                ya = to + 65;
                ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[1] + "^FS";
                yb = to + 66;
                ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[1] + "^FS";
                ya = to + 105;
                ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[2] + "^FS";
                yb = to + 106;
                ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[2] + "^FS";
                if (lineAr.Count >= 4)
                {
                    ya = to + 145;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[3] + "^FS";
                    yb = to + 146;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[3] + "^FS";
                }
                if (lineAr.Count >= 5)
                {
                    ya = to + 185;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[4] + "^FS";
                    yb = to + 186;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[4] + "^FS";
                }
                if (lineAr.Count >= 6)
                {
                    ya = to + 225;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[5] + "^FS";
                    yb = to + 226;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[5] + "^FS";
                }
                if (lineAr.Count >= 7)
                {
                    ya = to + 265;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[6] + "^FS";
                    yb = to + 266;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[6] + "^FS";
                }
                if (lineAr.Count >= 8)
                {
                    ya = to + 305;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[7] + "^FS";
                    yb = to + 306;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[7] + "^FS";
                }
                if (lineAr.Count >= 9)
                {
                    ya = to + 345;
                    ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FD" + lineAr[8] + "^FS";
                    yb = to + 346;
                    ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FD" + lineAr[8] + "^FS";
                }
            }
            ZPLString += "^XZ";
            // MessageBox.Show(ZPLString);
            // Use http://labelary.com/viewer.html to view ZPL from MessageBox
            RawPrinterHelper.SendStringToPrinter(zebraPrinterBox.Text, ZPLString);
        }
        private void TestPrintBtnClick(object sender, EventArgs e)
        {
            int so = Convert.ToInt16(numudSplitOffset.Value);
            int to = Convert.ToInt16(numupTopOffset.Value);
            int xa = so;
            int ya = to;
            string ZPLString = "^XA^CI28";
            ZPLString += "^FO" + xa + "," + ya + "^GB0,50,2^FS";
            ZPLString += "^FO" + xa + "," + ya + "^GB50,0,2^FS";
            xa = so - 55;
            ya = to + 25;
            ZPLString += "^FO" + xa + "," + ya + "^A0R40,40^FDTitle of Resource^FS";
            xa = so - 125;
            ZPLString += "^FO" + xa + "," + ya + "^A0R50,50^FDBARCODE^FS";
            xa = so + 15;
            int xb = so + 16;
            ya = to + 30;
            ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FDLine1<7^FS";
            ya = to + 90;
            ZPLString += "^FO" + xa + "," + ya + "^A0N50,50^FDLine2<7^FS";
            ya = to + 150;
            ZPLString += "^FO" + xa + "," + ya + "^A0N45,45^FDLine 3 =7^FS";
            ya = to + 205;
            ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FDLine 4 = 8^FS";
            int yb = to + 206;
            ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FDLine 4 = 8^FS";
            ya = to + 255;
            ZPLString += "^FO" + xa + "," + ya + "^A0N40,40^FDLine 5 = 8^FS";
            yb = to + 256;
            ZPLString += "^FO" + xb + "," + yb + "^A0N40,40^FDLine 5 = 8^FS";
            ya = to + 305;
            ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FDLine 6 = 9Ln^FS";
            yb = to + 306;
            ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FDLine 6 = 9Ln^FS";
            ya = to + 345;
            ZPLString += "^FO" + xa + "," + ya + "^A0N35,35^FDLine 7 = 9Ln^FS";
            yb = to + 346;
            ZPLString += "^FO" + xb + "," + yb + "^A0N35,35^FDLine 7 = 9Ln^FS";
            ZPLString += "^XZ";
            // MessageBox.Show(ZPLString);
            // Use http://labelary.com/viewer.html to view ZPL from MessageBox
            RawPrinterHelper.SendStringToPrinter(zebraPrinterBox.Text, ZPLString);
        }
        private void zplAddBtn_Click(object sender, EventArgs e)
        {
            string barcode = getval("barcode");
            string title = getval("title");
            if (title.Length > 21)
            {
                title = title.Substring(0, 20);
            }
            string labelData = title + Constants.vbCrLf + barcode + Constants.vbCrLf + OutputBox.Text;

            // MessageBox.Show(labelData);
            zplBatchAL.Add(labelData);
            OutputBox.Text = "";
            InputBox.Text = "";
            string allLabels = "";
            foreach (Object obj in zplBatchAL)
            {
                allLabels += obj.ToString();
                allLabels += Constants.vbCrLf + "===============" + Constants.vbCrLf;
            }
            zplBatchPreview.Text = allLabels;
        }

        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "ZPL Spine Label Document";
                di.pDataType = "RAW";

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendFileToPrinter(string szPrinterName, string szFileName)
            {
                // Open the file.
                FileStream fs = new FileStream(szFileName, FileMode.Open);
                // Create a BinaryReader on the file.
                BinaryReader br = new BinaryReader(fs);
                // Dim an array of bytes big enough to hold the file's contents.
                Byte[] bytes = new Byte[fs.Length];
                bool bSuccess = false;
                // Your unmanaged pointer.
                IntPtr pUnmanagedBytes = new IntPtr(0);
                int nLength;

                nLength = Convert.ToInt32(fs.Length);
                // Read the contents of the file into the array.
                bytes = br.ReadBytes(nLength);
                // Allocate some unmanaged memory for those bytes.
                pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
                // Copy the managed byte array into the unmanaged array.
                Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
                // Send the unmanaged bytes to the printer.
                bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
                // Free the unmanaged memory that you allocated earlier.
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }

        private string terminator(int actualLen)
        {
            string trm = "";
            int desiredLen = Conversions.ToInteger(dosBlankLines.Text);
            if (desiredLen > actualLen)
            {
                if (dosAddLines.Checked)
                {
                    trm = new string('^', desiredLen - actualLen).Replace("^", Constants.vbCrLf);
                }
                else
                {
                    trm = Conversions.ToString(Strings.Chr(Conversions.ToInteger(appendAscii.Text)));
                }
            }
            else
            {
                trm = "";
            }
            return trm;
        }
        private void SetPrintButtonText()
        {
            ManualPrint.ForeColor = Color.Black;
            if (UseFTP.Checked)
                ManualPrint.Text = "Send to FTP Printer";
            if (UseLaser.Checked)
                ManualPrint.Text = "Add to batch #" + batchNumber.Value.ToString();
            if (UseDesktop.Checked)
                ManualPrint.Text = "Send to desktop printer";
            if (UseZPL.Checked) ManualPrint.Text = "Send to Zebra printer";
            // If useDOSBatch.Checked Then ManualPrint.Text = "Run viados.bat"
        }

        private string packagePocket()
        {
            // combines spine label in OutputBox with pocket label in plOutput.
            // A tab character separates lines of spine text from a line of pocket label text.
            int k = 0;
            string sp = "";
            int s = 0;
            int p = 0;
            string stext = "";
            string ptext = "";
            do
            {
                if (s <= OutputBox.Lines.Length - 1)
                {
                    stext = OutputBox.Lines[s];
                    s = s + 1;
                }
                else
                    stext = "";
                if (p <= plOutput.Lines.Length - 1)
                {
                    ptext = plOutput.Lines[p];
                    p = p + 1;
                }
                else
                    ptext = "";
                if (string.IsNullOrEmpty(stext) & string.IsNullOrEmpty(ptext))
                    break;
                sp = sp + stext + Constants.vbTab + ptext + Constants.vbCrLf;
                k = k + 1;
                if (k > 20)
                    return "*** Error preparing pocket labels for printing ***";
            }
            while (true);

            sp = sp.Substring(0, sp.Length - 2); // remove final crlf

            return sp;
        }

        private void btnPrintBatch_Click(object sender, EventArgs e)
        {
            string labelsIn;
            string wrk;
            labelsIn = GetBatch((int)Math.Round(batchNumber.Value));

            // modified------------------------------
            // LABELS = labelsIn.Split(vbCrLf)
            // --------------------------------------

            wrk = labelsIn.Replace(Constants.vbCrLf + "===============" + Constants.vbCrLf, "^");
            wrk = wrk.Replace(Constants.vbCrLf, "|");
            wrk = wrk.Replace("^", Constants.vbCrLf);
            // MsgBox("wrk:" & wrk)
            LABELS = wrk.Split(Conversions.ToChar(Constants.vbCrLf));

            if (LABELS.Length == 0)
            {
                Interaction.MsgBox("There are no labels in batch number " + batchNumber.Value);
                return;
            }

            nxt = 0;
            getPrintParams();
            firstPage = true;
            PrintDocument2.PrinterSettings.PrinterName = inPrinterName.Text;
            PrintPreviewDialog1.Document = PrintDocument2;
            try
            {
                PrintPreviewDialog1.ShowDialog();
            }
            catch
            {
                Interaction.MsgBox("The specified printer: " + Constants.vbCrLf + Constants.vbCrLf + inPrinterName.Text + Constants.vbCrLf + Constants.vbCrLf + "does not exist." + Constants.vbCrLf + "Please select a different printer.", MsgBoxStyle.Exclamation, "Printer not found");
            }

        }

        private void getPrintParams()
        {
            float cf = 0.0f;
            if (unitINCH.Checked)
            {
                cf = 100f;
            }
            else
            {
                cf = 39.3701f;
            }
            horizPos = 0;
            fontname = inFontName.Text;
            fontsize = Conversions.ToSingle(inFontSize.Text);
            fWeight = FontStyle.Regular;
            if (inFontWeight.Checked)
                fWeight = FontStyle.Bold;
            maxLines = Conversions.ToInteger(inMaxLines.Text);
            topMargin = Conversions.ToSingle(inTopMargin.Text) * cf; // 100
            leftMargin = Conversions.ToSingle(inLeftMargin.Text) * cf; // 100
            lineSpacing = Conversions.ToSingle(inLineSpacing.Text) * cf; // 100
            if (UseLaser.Checked) // for batch printing, set params for multi-row & multi-column sheets
            {
                labelRows = Conversions.ToInteger(inLabelRows.Text);
                labelCols = Conversions.ToInteger(inLabelCols.Text);
                labelWidth = Conversions.ToSingle(inLabelWidth.Text) * cf; // 100
                labelHeight = Conversions.ToSingle(inLabelHeight.Text) * cf; // 100
                gapWidth = Conversions.ToSingle(inGapWidth.Text) * cf; // 100
                gapHeight = Conversions.ToSingle(inGapHeight.Text) * cf; // 100
            }
            else // for single-label desktop printing, rows & columns are always "1", with no gaps.
            {
                labelRows = 1;
                labelCols = 1;
                labelWidth = 0f;
                labelHeight = 0f;
                gapWidth = 0f;
                gapHeight = 0f;
            }
        }
        private void sendToBatch(string labelout)
        {
            // add a spine label or book flag to the end of the selected label batch
            labelout = labelout.Replace(Constants.vbCrLf, "|");

            // labelout = vbCrLf + "----------" & vbCrLf & labelout
            labelout = Strings.Mid(labelout, 1, labelout.Length); // remove final "|"
            writeFile(mypath + "labelbatch" + batchNumber.Value + ".txt", labelout, true);
            batchPreview.Text = batchPreview.Text + labelout;
            batchEntries.Text = (Conversions.ToDouble(batchEntries.Text) + 1d).ToString();
        }

        private void sendToBatch2(string labelout)
        {
            // NEW METHOD
            // add a spine label or book flag to the end of the selected label batch
            if (Conversions.ToInteger(batchEntries.Text) > 0)
            {
                labelout = Constants.vbCrLf + "===============" + Constants.vbCrLf + labelout;
            }
            writeFile(mypath + "labelbatch" + batchNumber.Value + ".txt", labelout, true);
            batchPreview.Text = batchPreview.Text + labelout;
            batchEntries.Text = (Conversions.ToDouble(batchEntries.Text) + 1d).ToString();

        }

        private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = 0.0f;
            float y = 0.0f;
            float ypos = 0.0f;
            int z = 0;
            int t = 0;
            int down = 0;
            int across = 0;
            int i = 0;
            object pFont = new Font(fontname, fontsize, fWeight);
            if (inBCFontWeight.Checked)
            {
                bcWeight = FontStyle.Bold;
            }
            else
            {
                bcWeight = FontStyle.Regular;
            }
            object bFont = new Font(inBCFontName.Text, Conversions.ToSingle(inBCFontSize.Text), bcWeight);
            // Dim testlbl As String = "QA|76.73|.J38|H674|2006"
            Array line; // = testlbl.Split("|")
            string test = "";
            int extraSpace = 0;
            float bcwidth = 0.0f;
            int cntrOffset = 0;
            string nextLabel = "";
            int startRow = Conversions.ToInteger(inStartRow.Text);
            int startcol = Conversions.ToInteger(inStartCol.Text);

            int PlySave; // save starting point of call# label to use if a pocket label
            int PLx;
            int PLy; // will subsequently be printed.
            int leftPocket = 0; // left margin of pocket label
            int plk = 0;
            Array plparams;
            bool theseArePocketLabels = false;
            float cf = 0.0f;
            if (unitINCH.Checked)
            {
                cf = 100f;
            }
            else
            {
                cf = 39.3701f;
            }
            if (chkUsePocketLabels.Checked)
            {
                plparams = PocketParams(); // called to get the labelCount (1 or 2) currently in effect
            }
            if (startRow > labelRows)
            {
                Interaction.MsgBox("Starting row number is greater than the maximum rows.", MsgBoxStyle.Exclamation, "Starting Row Number Too Large");
                return;
            }
            if (startcol > labelCols)
            {
                Interaction.MsgBox("Starting column number is greater than the maximum columns.", MsgBoxStyle.Exclamation, "Starting Column Number Too Large");
                return;
            }
            // values preceded by ! will display a barcode first, followed by the actual value on the next line
            // values preceded by ~ will have extra vertical spacing
            if (!firstPage)
            {
                startRow = 1;
                startcol = 1;
            }
            do
            {
                bool exitDo1 = false;
                var loopTo = labelRows;
                for (down = startRow; down <= loopTo; down++)
                {
                    y = topMargin + (down - 1) * (labelHeight + gapHeight);

                    bool exitDo = false;
                    var loopTo1 = labelCols;
                    for (across = startcol; across <= loopTo1; across++)
                    {
                        nextLabel = getNextLabel(); // gets next label from the LABELS array
                        if (nextLabel == "done")
                        {
                            exitDo1 = exitDo = true;
                            break;
                        }
                        line = nextLabel.Split('|');

                        if (Conversions.ToBoolean(line.GetValue(0).ToString().Contains(Constants.vbTab))) // pocket labels will always have a tab in the 1st line
                        {
                            theseArePocketLabels = true;
                            plparams = PocketParams();
                            line = removePocket(line); // split off the pocket label from the spine label
                        }

                        x = leftMargin + (across - 1) * (labelWidth + gapWidth);
                        PLx = (int)Math.Round(x);
                        ypos = y;
                        PlySave = (int)Math.Round(y); // for pocket labels, save starting y position
                        var loopTo2 = line.Length - 1;
                        for (z = 0; z <= loopTo2; z++)
                        {
                            test = Conversions.ToString(line.GetValue(z));
                            // print barcode, if "!" precedes value
                            if (Strings.Mid(test, 1, 1) == "!") // if this value should be printed as a barcode
                            {
                                test = Strings.Mid(test, 2, test.Length - 1); // remove the !
                                e.Graphics.DrawString("*" + test + "*", (Font)bFont, Brushes.Black, x, ypos);
                                e.Graphics.DrawString("*" + test + "*", (Font)bFont, Brushes.Black, x, ypos + Conversions.ToSingle(inBCFontSize.Text));
                                ypos = ypos + lineSpacing + 20f; // allow for extra vertical spacing
                                cntrOffset = 25;
                            }

                            if (Strings.Mid(test, 1, 1) == "~") // if this value should be prededed by extra space
                            {
                                test = Strings.Mid(test, 2, test.Length - 1); // remove the ~
                                extraSpace = (int)Math.Round(Conversions.ToSingle(inLineSpacing.Text) * cf); // * 100
                            }

                            ypos = ypos + extraSpace;
                            e.Graphics.DrawString(test, (Font)pFont, Brushes.Black, x + cntrOffset, ypos);
                            ypos = ypos + lineSpacing;
                            extraSpace = 0;
                            cntrOffset = 0;
                        }

                        if (UseLaser.Checked & FlagSlips.Enabled & FlagSlips.Checked & inLabelHeight.Text == "7.0")
                        {
                            // If chk_VerticalLine.Checked Then
                            e.Graphics.DrawLine(Pens.Black, x + labelWidth - 10f, down * 20, x + labelWidth - 10f, down * labelHeight);
                        }

                        if (theseArePocketLabels)
                        {
                            string pltext = "";
                            bool printbarcode = false;
                            PLy = PlySave; // start 1st pocket label at same top margin as the spine label
                            leftPocket = (int)Math.Round(PLx + Conversions.ToSingle(plLeftMargin.Text) * cf); // * 100)
                            var loopTo3 = labelCount;
                            for (i = 1; i <= loopTo3; i++)
                            {
                                var loopTo4 = plOutput.Lines.Length - 1;
                                for (plk = 0; plk <= loopTo4; plk++)
                                {
                                    pltext = plOutput.Lines[plk];
                                    if (Strings.Mid(pltext, 1, 1) == "!")
                                    {
                                        pltext = Strings.Mid(pltext, 2, pltext.Length - 1); // remove the !
                                        printbarcode = true;
                                    }
                                    e.Graphics.DrawString(pltext, (Font)pFont, Brushes.Black, leftPocket, PLy);
                                    PLy = (int)Math.Round(PLy + lineSpacing);
                                    if (printbarcode)
                                    {
                                        e.Graphics.DrawString("*" + pltext + "*", (Font)bFont, Brushes.Black, leftPocket, PLy);
                                        e.Graphics.DrawString("*" + pltext + "*", (Font)bFont, Brushes.Black, leftPocket, PLy - 10 + Conversions.ToSingle(inBCFontSize.Text));
                                        PLy = PLy + 30;
                                        printbarcode = false;
                                    }
                                }
                                // if there is a 2nd pocket label, start it at the 1st top
                                // margin plus the offset specified by the user ("plDistance")
                                PLy = (int)Math.Round(PlySave + Conversions.ToSingle(plDistance.Text) * cf); // * 100)
                            }
                            plOutput.Text = "";
                        }

                        if (UseDesktop.Checked)
                        {
                            exitDo1 = exitDo = true;
                            break;
                        }
                    }

                    if (exitDo)
                    {
                        break;

                    }
                    startcol = 1;
                }

                if (exitDo1)
                {
                    break;
                }
                startRow = 1;
                if (nxt != LABELS.Length - 1)
                {
                    firstPage = false;
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    nxt = 0;
                }
                return;
            }

            while (false);
            nxt = 0;
            e.HasMorePages = false;
        }

        private void PrintDocument2_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            PrinterResolution pres;
            // Dim c As Integer = 0
            // Dim i As Integer = 0
            // Dim lst As String = ""
            // Dim ps As New PaperSize("Custom", 100, 300)
            // e.PageSettings.PaperSize = ps
            if (useLandscape.Checked)
            {
                e.PageSettings.Landscape = true;
            }
            else
            {
                e.PageSettings.Landscape = false;
            }
            pres = PrintDocument2.DefaultPageSettings.PrinterResolution;
            // c = e.PageSettings.PrinterSettings.PaperSizes.Count
            // For i = 0 To c - 1
            // lst = lst & e.PageSettings.PrinterSettings.PaperSizes(i).ToString() & vbCrLf
            // Next
            // MsgBox("Paper Sizes" & vbCrLf & lst)
        }

        private Array removePocket(Array line)
        {
            // gets pocket label from batch file and separates the spine label part from the pocket label part.
            int k = 0;
            string s = "";
            plOutput.Text = "";
            var loopTo = line.Length - 1;
            for (k = 0; k <= loopTo; k++)
            {
                if (Conversions.ToBoolean(line.GetValue(k).ToString().Contains(Constants.vbTab)))
                {
                    plOutput.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(plOutput.Text, line.GetValue(k).ToString().Substring((int)Operators.AddObject(line.GetValue(k).ToString().IndexOf(Constants.vbTab), 1))), Constants.vbCrLf));
                    line.SetValue(line.GetValue(k).ToString().Substring(0, line.GetValue(k).ToString().IndexOf(Constants.vbTab)), k);
                }
                else
                {
                    plOutput.Text = Conversions.ToString(Operators.ConcatenateObject(plOutput.Text, line.GetValue(k)));
                }
            }
            s = plOutput.Text;
            k = 0;
            try
            {
                while ((s.Substring(s.Length - 2, 2) ?? "") == Constants.vbCrLf) // trim all crlfs from end of pocket label
                    s = s.Substring(0, s.Length - 2);
            }
            catch (Exception ex)
            {
                // Return Split("NOTPOCKET", "|")
            }
            plOutput.Text = s;
            return line;
        }
        private string getNextLabel()
        {
            string labelWork;
            // nxt is defined globally
            if (nxt > LABELS.Length - 1)
            {
                nxt = 0;
                return "done";
            }

            labelWork = Conversions.ToString(this.LABELS.GetValue(nxt).ToString().Replace(Constants.vbLf, ""));

            if (string.IsNullOrEmpty(Strings.Trim(labelWork)))
            {
                nxt = 0;
                return "done";
            }

            nxt = nxt + 1;
            return labelWork;

        }

        private string GetBatch(int bnum)
        {
            StreamWriter sw;
            string labelText = "";
            string wrk;

            // If the labelBatch text file doesn't exist in executable's path, create it.
            if (!File.Exists(mypath + "labelbatch" + bnum + ".txt"))
            {
                sw = File.CreateText(mypath + "labelbatch" + bnum + ".txt");
                sw.Close();
            }

            var tr = new StreamReader(mypath + "labelbatch" + bnum + ".txt");
            int i;

            try
            {
                labelText = tr.ReadToEnd();
                tr.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Can't read Label batch #" + bnum + Constants.vbCrLf + "Reason: " + ex.Message, MsgBoxStyle.Exclamation, "Batch File Error");
                labelText = "*ERROR READING BATCH #" + bnum;
            }
            if (labelText.Length != 0)
            {
                i = 1;
                if (char.IsControl(labelText, 1))
                    i = 3;
                wrk = Strings.Mid(labelText, i, labelText.Length); // remove initial CR/LF and returned LF
                if (wrk.Length > 1)
                {
                    wrk = Strings.Mid(wrk, 1, wrk.Length - 1);
                }
                if (wrk.Contains("|"))
                {
                    wrk = wrk.Replace(Constants.vbCrLf, Constants.vbCrLf + "===============" + Constants.vbCrLf).Replace("|", Constants.vbCrLf);
                    writeFile(mypath + "labelbatch" + batchNumber.Value + ".txt", wrk, false);
                }
                else
                {
                    wrk = wrk.Replace(Constants.vbCrLf + Constants.vbCrLf + "=", Constants.vbCrLf + "=");
                }
                return wrk;
            }
            return "";
        }

        private void callAlma()
        {

            var webClient = new WebClient();
            bool almaOK = true;
            int i = 0;
            bool addToHistory;
            string svcRequest = "";
            string fixedBarcode = "";
            string quot = "\"";
            lblXMLWarn.Visible = false;
            xmlerr = "";
            if (string.IsNullOrEmpty(InputBox.Text))
            {
                Interaction.Beep();
                return;
            }

            fixedBarcode = Strings.Replace(InputBox.Text, "+", "%2B");
            fixedBarcode = Strings.Replace(fixedBarcode, " ", "%20");
            svcRequest = Strings.Trim(apiURL.Text) + Strings.Trim(apiMethod.Text.Replace("{item_barcode}", fixedBarcode)) + "&apikey=" + Strings.Trim(apiKey.Text);

            lastbc = InputBox.Text;
            addToHistory = true;

            if (string.IsNullOrEmpty(Strings.Trim(InputBox.Text)))
                addToHistory = false;
            if (HistoryList.Items.Contains(InputBox.Text))
                addToHistory = false;
            if (addToHistory)
            {
                if (HistoryList.Items.Count == 0)
                {
                    HistoryList.Items.Add(InputBox.Text);
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(HistoryList.Items[0], InputBox.Text, false)))
                {
                    HistoryList.Items.Insert(0, InputBox.Text);
                }

                if (HistoryList.Items.Count == 6)
                {
                    HistoryList.Items.RemoveAt(5);
                }
            }


            // if XML is coming from a web call (via java servlet or RESTful call:
            webClient.Encoding = System.Text.Encoding.UTF8;

            try
            {

                xmlReturned = webClient.DownloadString(svcRequest);

                if (UseRestfulApi.Checked & dontConvert.Checked == false)
                {

                    xmlReturned = xmlReturned.Replace("><", ">" + Constants.vbCrLf + "<");

                    string convertedXML, e;
                    convertedXML = Conversions.ToString(RESTfulToSOAP(xmlReturned));
                    int pos, opn, clos;

                    pos = Strings.InStr(1, convertedXML, " desc=", CompareMethod.Text);
                    while (pos > 0)
                    {
                        opn = Strings.InStrRev(convertedXML, "<", pos, CompareMethod.Text);
                        clos = Strings.InStr(opn, convertedXML, ">", CompareMethod.Text);
                        clos = Strings.InStr(clos + 1, convertedXML, ">", CompareMethod.Text);
                        e = Strings.Mid(convertedXML, opn, clos - opn + 1);
                        convertedXML = convertedXML.Replace(e, deAttrib(e));
                        pos = Strings.InStr(clos + 1, convertedXML, " desc=", CompareMethod.Text);
                    }

                    convertedXML = convertedXML.Replace("call_number_type_code", "call_number_type");
                    convertedXML = convertedXML.Replace("<description>", "<issue_level_description>");
                    convertedXML = convertedXML.Replace("</description>", "</issue_level_description>");
                    convertedXML = convertedXML.Replace("<enumeration_", "<enum_");
                    convertedXML = convertedXML.Replace("</enumeration_", "</enum_");
                    convertedXML = convertedXML.Replace("<chronology_", "<chron_");
                    convertedXML = convertedXML.Replace("</chronology_", "</chron_");


                    if (convertedXML.Contains("<parsed_call_number>"))
                    {
                        convertedXML = Conversions.ToString(enumerate(convertedXML, "<parsed_call_number>", "</parsed_call_number>", "<call_no>"));
                    }

                    if (convertedXML.Contains("<parsed_issue_level_description>"))
                    {
                        convertedXML = Conversions.ToString(enumerate(convertedXML, "<parsed_issue_level_description>", "</parsed_issue_level_description>", "<issue_level_description>"));
                    }

                    if (!convertedXML.Contains("<issue_level_description>"))
                    {
                        convertedXML = convertedXML.Replace("</barcode>", "</barcode>" + Constants.vbCrLf + "<issue_level_description> </issue_level_description>");
                    }

                    if (!convertedXML.Contains("<chron_"))
                    {
                        object dummyChron = "</barcode>" + Constants.vbCrLf + "<chron_i> </chron_i>" + Constants.vbCrLf + "<chron_j> </chron_j>" + Constants.vbCrLf + "<chron_k> </chron_k>" + Constants.vbCrLf + "<chron_l> </chron_l>" + Constants.vbCrLf + "<chron_m> </chron_m>" + Constants.vbCrLf;
                        convertedXML = convertedXML.Replace("</barcode>", Conversions.ToString(dummyChron));
                    }

                    xmlReturned = xmlShell.Text.Replace("**XMLBODY**", convertedXML);
                }
                else if (dontConvert.Checked == true)
                {
                    TabControl1.SelectedIndex = 3;
                }
            }
            catch (Exception ex)
            {
                almaOK = false;
                OutputBox.Text = "***** ERROR ***** " + Constants.vbCrLf + "Can't retrieve XML file." + Constants.vbCrLf + Constants.vbCrLf + "Error message: " + ex.Message;
                // MsgBox("error: " & ex.Message)
            }
            if (almaOK)
            {
                getBarcodeFile();
            }
        }
        private object enumerate(string xml, string xfrom, string xto, string breakon)
        {
            int k = 0;
            string parseString = "";
            Array cline;
            string enumerated = "";
            parseString = BTween(xml, xfrom, xto);
            cline = Strings.Split(parseString, breakon);
            var loopTo = cline.Length - 1;
            for (k = 1; k <= loopTo; k++)
                enumerated = enumerated + (breakon + cline.GetValue(k).ToString()).Replace(">", "_" + k + ">");
            xml = xml.Replace(parseString, enumerated);
            return xml;
        }
        private object RESTfulToSOAP(string restfulXml)
        {
            // convert RESTful xml file returned by Alma into SOAP format
            int e;
            int f;
            int i;
            string t = "";
            var rdoc = new XmlDocument();
            XmlNode nodes;
            XmlNode cnodes;
            string element = "";
            var parts = new string[3];
            parts[0] = "//bib_data";
            parts[1] = "//holding_data";
            parts[2] = "//item_data";

            rdoc.PreserveWhitespace = true;
            rdoc.LoadXml(restfulXml);

            var loopTo = parts.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {

                nodes = rdoc.SelectSingleNode(parts[i]);

                if (nodes.HasChildNodes)
                {

                    var loopTo1 = nodes.ChildNodes.Count - 1;
                    for (e = 0; e <= loopTo1; e++)
                    {

                        if (nodes.ChildNodes[e].HasChildNodes)
                        {
                            cnodes = nodes.ChildNodes[e];
                            if (cnodes.ChildNodes.Count > 1)
                            {
                                t = t + "<" + cnodes.Name + ">" + Constants.vbCrLf;
                                var loopTo2 = cnodes.ChildNodes.Count - 1;
                                for (f = 0; f <= loopTo2; f++)
                                    t = t + cnodes.ChildNodes[f].OuterXml + Constants.vbCrLf;
                                t = t + "</" + cnodes.Name + ">" + Constants.vbCrLf;
                            }
                            else
                            {
                                element = nodes.ChildNodes[e].OuterXml;
                                t = t + element + Constants.vbCrLf;
                                // If element.Contains(" desc=") Then t = t & deAttrib(element) & vbCrLf
                            }
                        }
                    }
                }
            }
            // writeFile(mypath & "converted.txt", t, False)
            return t;

        }

        private string deAttrib(string e)
        {
            string element;
            string attrVal;
            string codeval;
            string quot = "\"";
            string XML1;
            string XML2;

            element = BTween(e, "<", " ");
            attrVal = BTween(e, quot, quot);
            codeval = BTween(e, ">", "<");

            XML1 = "<" + element + "_name>" + attrVal + "</" + element + "_name>";
            XML2 = "<" + element + "_code>" + codeval + "</" + element + "_code>";


            return XML1 + Constants.vbCrLf + XML2;
        }
        private object donothing(string x)
        {
            // MsgBox(RESTfulToSOAP(xmlReturned))

            // Dim doc As New XmlDocument
            // Dim t As String = ""
            // Dim cn As String = "" 'call number
            // Dim cntp As String = "" 'call number type
            // Dim n As String = ""
            // Dim titl As String = ""
            // Dim e As Integer
            // Dim Lnode As XmlNodeList
            // Dim anode As XmlNode

            // doc.LoadXml(xmlReturned)
            // Dim elemList As XmlNodeList = doc.GetElementsByTagName("item_data")
            // Dim c As XmlNodeList = doc.GetElementsByTagName("call_number")
            // cn = c(0).OuterXml

            // Lnode = doc.GetElementsByTagName("call_number_type")
            // cntp = "<call_number_type>" & Lnode(0).InnerXml & "</call_number_type>"

            // Dim ti As XmlNodeList = doc.GetElementsByTagName("title")
            // titl = ti(0).OuterXml

            // Dim lid As XmlNodeList = doc.GetElementsByTagName("library")
            // Dim licode As String = "<library_code>" & lid(0).InnerXml & "</library_code>"
            // anode = doc.SelectSingleNode("//library")
            // Dim liname As String = "<library_name>" & anode.Attributes(0).Value & "</library_name>"

            // Dim lod As XmlNodeList = doc.GetElementsByTagName("location")
            // Dim locode As String = "<location_code>" & lod(0).InnerXml & "</location_code>"
            // anode = doc.SelectSingleNode("//location")
            // Dim loname As String = "<location_name>" & anode.Attributes(0).Value & "</location_name>"

            // For e = 0 To elemList.Count - 1
            // t = elemList(e).InnerXml & vbCrLf
            // Next e

            // xmlReturned = xmlShell.Text.Replace("**XMLBODY**", cn & vbCrLf & cntp & vbCrLf & titl & vbCrLf & licode & vbCrLf & liname & vbCrLf & loname & locode & vbCrLf & t)
            // xmlReturned = xmlReturned.Replace("<description>", "<issue_level_description>")
            // xmlReturned = xmlReturned.Replace("</description>", "</issue_level_description>")
            // xmlReturned = xmlReturned.Replace("enumeration_", "enum_")
            return x;
        }




        private void getBarcodeFile()
        {

            string xmltext;
            int bcstart = 0;
            int bcend = 0;
            string current_date = Conversions.ToString(DateTime.Now.Date);
            string xmlerror = "";
            string er = "";
            string cdxml = "<current_date>" + current_date + "</current_date>";
            string xmlend = "</physical_item_display_for_printing>";
            Array x;
            int linenum = 0;
            int charpos = 0;
            string coords;
            Array pos;
            string s = "";
            int i;
            int loopcount = 0;
            xmlReturned = xmlReturned.Replace(xmlend, cdxml + xmlend);

            loopcount = 0;
            do
            {
                try
                {
                    // ANGLE BRACKET ERROR OCCURS HERE

                    xdoc.LoadXml(xmlReturned.Replace("&", "|amp"));
                    break;
                }
                // *********************************
                catch (Exception ex) // if xdoc.LoadXml fails, it may be due to < character in the data.
                {
                    x = Strings.Split(xmlReturned, Constants.vbLf); // need an array of lines to find line# of bad "<" character.
                    s = ex.ToString();
                    if (s.Contains("Name cannot begin with")) // If error is due to extraneous < character 
                    {
                        coords = Strings.Mid(s, s.IndexOf("Line "), 24); // finds location (line#, char pos. w/in line)
                        coords = coords.Replace("Line", "").Replace("position", "").Replace(".", "").Replace(" ", "");
                        pos = Strings.Split(coords, ","); // comma separates line# from char position
                        linenum = Conversions.ToInteger(Operators.SubtractObject(pos.GetValue(0), 1));
                        charpos = Conversions.ToInteger(pos.GetValue(1));
                        string argsDest = Conversions.ToString(x.GetValue(linenum));
                        StringType.MidStmtStr(ref argsDest, charpos - 1, 1, "`"); // replace offending < with accent mark
                        x.SetValue(x.GetValue(linenum).ToString().Replace("`", "|lt;"), linenum); // change accent to code representing < char. Later,
                        xmlReturned = "";                             // during XML display, |lt; will be replaced with <
                        var loopTo = x.Length - 1;
                        for (i = 0; i <= loopTo; i++)
                            xmlReturned = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(xmlReturned, x.GetValue(i)), Constants.vbLf));

                        loopcount = loopcount + 1;
                        if (loopcount > 10)
                        {
                            Interaction.MsgBox("Too many tries to fix the XML record");
                            break;
                        }
                    }
                    else // if this is not a "<" error, then give up.
                    {
                        Interaction.MsgBox("SpineOMatic cannot process the XML due to invalid characters in the data." + Constants.vbCrLf + "The error returned is: " + Constants.vbCrLf + ex.ToString());
                        return;
                    }
                }
            }
            while (true);


            xmltext = StripControlChars(xmlReturned, false);
            xmltext = xmltext.Replace("></", "> </");
            xmltext = xmltext.Replace("><", ">" + Constants.vbCrLf + "<");
            RichTextBox1.Clear();
            RichTextBox1.ForeColor = Color.Red;
            RichTextBox1.Text = xmltext;
            writeStat("S");
            if (xmltext.IndexOf("</error>") - xmltext.IndexOf("<error>") > 8)
            {
                OutputBox.Text = "***** ERROR ******" + Constants.vbCrLf + "can't find this barcode number in Alma";
                almaReturnCode = "Bad barcode";
                InputBox.SelectionStart = 0;
                InputBox.SelectionLength = InputBox.Text.Length;
                if (File.Exists(lastxml) == true)
                    File.Delete(lastxml);
                cntype = "-";
                buildStatRec();
                return;
            }

            if (xmltext.IndexOf("</som_error>") - xmltext.IndexOf("<som_error>") > 8)
            {
                er = xmltext.ToLower();
                OutputBox.Text = "***** ERROR *****" + Constants.vbCrLf + "Can't connect to Alma";
                if (er.IndexOf("unauthorized") > 0)
                {
                    OutputBox.Text = OutputBox.Text + Constants.vbCrLf + "Java: credentials unauthorized.";
                    almaReturnCode = "Bad credentials";
                }
                else if (er.IndexOf("unknownhost") > 0)
                {
                    OutputBox.Text = OutputBox.Text + Constants.vbCrLf + "Java: **Check Alma URL.";
                    almaReturnCode = "Bad URL";
                }
                else if (Conversions.ToBoolean(er.IndexOf("unsupported endpoint") | Conversions.ToInteger(er.IndexOf("illegalargument") > 0)))
                {
                    OutputBox.Text = OutputBox.Text + Constants.vbCrLf + "Java: **Check Alma URL--It must start with http://";
                    almaReturnCode = "Bad URL";
                }
                cntype = "-";
                buildStatRec();
                InputBox.SelectionStart = 0;
                InputBox.SelectionLength = InputBox.Text.Length;
                if (File.Exists(lastxml) == true)
                    File.Delete(lastxml);
                return;
            }

            almaReturnCode = "OK";

            lcxml = xmlValue(inCallNumSource.Text).Replace(Constants.vbTab, "");

            if (!inIssueLevelSource.Text.Contains("parsed"))
            {
                issuexml = xmlValue(inIssueLevelSource.Text);
                if (!string.IsNullOrEmpty(Strings.Trim(issuexml)))
                {
                    issuexml = Custom2(inIssueLevelSource.Text);
                }
            }

            libxml = xmlValue(TextBox13.Text);
            locxml = xmlValue(TextBox14.Text);
            almaLibrary = libxml;
            almaLocation = locxml;
            cntype = xmlValue("<call_number_type>");
            if (string.IsNullOrEmpty(Strings.Trim(cntype)))
                cntype = convertBlankTo.Text;
            testComboBox.Text = lcxml;
            testCallNumType.Text = cntype;

            buildStatRec();
            RichTextBox1.Enabled = false;
            formatXML();
            RichTextBox1.Enabled = true;
            if (File.Exists(lastxml) == true)
                File.Delete(lastxml);
            printCallNum();
        }
        private void getNodeList()
        {
            batchPreview.Text = "";
            XmlNodeList nodelist;
            nodelist = xdoc.SelectNodes("//*");
            Interaction.MsgBox(nodelist.Count);
            foreach (XmlNode node in nodelist)
                batchPreview.Text = batchPreview.Text + node.Name + Constants.vbCrLf;

        }
        private void formatXML()
        {
            // Makes the Current XML display look more like XML in the RichTextBox window.
            int pos = 0;
            int tagstart = 0;
            int tagend = 0;
            string tagname = "";
            int nextclose = 0;
            int nextend = 0;
            string endname = "";
            int sp = 0;
            int ep = 0;
            Font currentSelectionFont;

            try
            {
                {
                    var withBlock = RichTextBox1;
                    while (true)
                    {
                        tagstart = withBlock.Find("<", tagstart, RichTextBoxFinds.MatchCase);
                        withBlock.SelectionStart = tagstart;
                        withBlock.SelectionLength = 1;
                        withBlock.SelectionColor = Color.Blue;
                        if (tagstart == -1)
                            break;
                        tagend = withBlock.Find(">", tagstart, RichTextBoxFinds.MatchCase);
                        withBlock.SelectionStart = tagend;
                        withBlock.SelectionLength = 1;
                        withBlock.SelectionColor = Color.Blue;
                        tagname = Strings.Mid(withBlock.Text, tagstart + 1, tagend - tagstart + 1);
                        nextclose = withBlock.Find("</", tagend, RichTextBoxFinds.MatchCase);
                        if (nextclose == -1)
                            break;
                        withBlock.SelectionStart = nextclose + 1; // make the "/" blue
                        withBlock.SelectionLength = 1;
                        withBlock.SelectionColor = Color.Blue;
                        nextend = withBlock.Find(">", nextclose, RichTextBoxFinds.MatchCase);
                        endname = Strings.Mid(withBlock.Text, nextclose + 1, nextend - nextclose + 1);
                        if ((tagname ?? "") == (endname.Replace("/", "") ?? ""))
                        {
                            // For RichTextBox.SelectionFont Property:
                            // If the current text selection has more than one font specified, the property SelectionFont is null,
                            // so we use a variable to hold the current one SelectionFont.
                            currentSelectionFont = RichTextBox1.SelectionFont;
                            sp = tagend + 1;
                            ep = nextclose - 1;
                            withBlock.SelectionStart = sp;
                            withBlock.SelectionLength = ep - sp + 1;
                            withBlock.SelectionColor = Color.Black;
                            withBlock.SelectionFont = new Font(currentSelectionFont, FontStyle.Bold);
                        }
                        tagstart = tagstart + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                if (!ex.ToString().Contains("Font prototype, FontStyle newStyle"))
                {
                    Interaction.MsgBox("error: " + ex.ToString());
                }
            }
        }
        private string StripControlChars(string source, bool KeepCRLF = true)
        {
            // we use this to build the result
            var sb = new System.Text.StringBuilder(source.Length);
            int index;
            var loopTo = source.Length - 1;
            for (index = 0; index <= loopTo; index++)
            {
                if (!char.IsControl(source, index))
                {
                    // not a control char, so we can add to result
                    sb.Append(source[index]);
                }
                else if (KeepCRLF && (source.Substring(index, 2) ?? "") == ControlChars.CrLf)
                {
                    // it is a CRLF, and the user asked to keep it
                    sb.Append(source[index]);
                }
            }
            return sb.ToString();
        }

        private void printCallNum()
        {
            string preLC = "";
            string mainLC = "";
            string issueLC = "";
            string otherLC = "";
            string taday = DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            Array checklines = null;
            int maxChars = Conversions.ToInteger(inMaxChars.Text);
            int maxlines = Conversions.ToInteger(inMaxLines.Text);
            bool charsOK = true;
            bool linesOK = true;
            int i = 0;
            string fontname = inFontName.Text;
            float fontsize = Conversions.ToSingle(inFontSize.Text);
            object quot = "\"";
            string checkcr = "";
            string cr = "";
            string ttl = "";
            // **********************************************
            preLC = aboveCall(libxml, locxml); // & vbCrLf
            if (!string.IsNullOrEmpty(preLC))
                preLC = preLC + Constants.vbCrLf;
            // **********************************************        
            preLC = preLC.Replace(";", Constants.vbCrLf);
            OutputBox.Font = new Font(fontname, fontsize);
            ttl = xmlValue("<title>");
            if (ttl.Length > 70)
            {
                ttl = ttl.Substring(0, 70) + "...";
            }
            TextBox24.Text = ttl; // xmlValue("<title>")

            Label27.Text = xmlValue("<library_name>");
            string custom_field = "";
            string otherval = "";
            string parserName = "";

            if (CustomLabel.Checked)
            {
                // create custom label
                parsedBy.BackColor = Color.White;
                if (FlagSlips.Checked)
                {
                    parsedBy.ForeColor = Color.Green;
                    parsedBy.Text = "Label type: Custom/Flag Slips";
                }
                else
                {
                    parsedBy.ForeColor = Color.Green;
                    parsedBy.Text = "Label type: Custom";
                }
                OutputBox.Text = "";
                OutputBox.Text = Custom2(CustomText.Text);
                if ((Strings.Mid(OutputBox.Text, 1, 2) ?? "") == Constants.vbCrLf)
                {
                    OutputBox.Text = OutputBox.Text.Substring(2);
                }
            }
            else
            {
                if (useExlibrisParsing.Checked == false)
                {
                    parsedBy.ForeColor = Color.Blue;
                    parsedBy.BackColor = Color.White;
                    parserName = TabControl2.SelectedTab.Text.Replace("/Child.Lit/NLM", "...");
                    parsedBy.Text = "Call# Parser: SpineOMatic " + parserName;
                    mainLC = parseLC(lcxml);
                }
                else
                {
                    parsedBy.ForeColor = Color.DarkRed;
                    parsedBy.BackColor = Color.White;
                    parsedBy.Text = "Call# Parser: Ex Libris";
                    mainLC = getParsing2(parsingSource.Text);
                }

                if (chkIncludeHoldings.Checked) // if holdings are requested...
                {
                    if (inIssueLevelSource.Text == "<parsed_issue_level_description>")
                    {
                        issueLC = Constants.vbCrLf + Strings.Trim(getParsing2("<parsed_issue_level_description>"));
                        holdingsBy.Text = "Holdings: Ex Libris parsed.";
                        holdingsBy.ForeColor = Color.DarkRed;
                        if ((issueLC ?? "") == Constants.vbCrLf) // if no parsed holdings were found...
                        {
                            issuexml = xmlValue("<issue_level_description>");
                            issueLC = Constants.vbCrLf + Strings.Trim(parseIssue(issuexml)); // use textual holdings
                            issueLC = issueLC.Replace("^", ":" + Constants.vbCrLf);
                            holdingsBy.Text = "Holdings: SpineOMatic, no Ex Libris";
                            holdingsBy.ForeColor = Color.DarkCyan;
                            if ((issueLC ?? "") == Constants.vbCrLf)
                            {
                                holdingsBy.Text = "Holdings: None found.";
                                holdingsBy.ForeColor = Color.Gray;
                                issueLC = "";
                            }
                        }
                    }
                    else // if requesting textual holdings
                    {
                        issueLC = Constants.vbCrLf + Strings.Trim(parseIssue(issuexml)); // get textual holdings
                        issueLC = issueLC.Replace("^", ":" + Constants.vbCrLf);
                        holdingsBy.Text = "Holdings: SpineOMatic";
                        holdingsBy.ForeColor = Color.Blue;
                        if ((issueLC ?? "") == Constants.vbCrLf)
                        {
                            holdingsBy.Text = "Holdings: none found.";
                            holdingsBy.ForeColor = Color.Gray;
                            issueLC = "";
                        }
                    }
                }
                else
                {
                    holdingsBy.Text = "Holdings: Not requested.";
                    holdingsBy.ForeColor = Color.Gray;
                    issueLC = "";
                }

                if (chkIncludeOther.Checked)
                {
                    otherLC = Custom2(inOtherSource.Text);
                }
                else
                {
                    otherLC = "";
                }

                checkcr = preLC + mainLC + issueLC;
                OutputBox.Text = checkcr.Replace(Constants.vbCrLf + Constants.vbCrLf, Constants.vbCrLf) + otherLC;
                origText = OutputBox.Text; // save text to later detect if it was manually changed
                if (dontConvert.Checked)
                    OutputBox.Text = "** VIEW RESTful XML ONLY **" + Constants.vbCrLf + Constants.vbCrLf + "Uncheck 'Don't Convert XML' in the Alma Access panel " + "to restore normal operation.";
            }

            charsOK = true;

            if (dontConvert.Checked == false)
            {
                checklines = Strings.Split(OutputBox.Text, Constants.vbCrLf);
                var siz = TextRenderer.MeasureText(OutputBox.Text, OutputBox.Font);
                if (siz.Height > OutputBox.Height)
                {
                    OutputBox.ScrollBars = ScrollBars.Vertical;
                }
                else
                {
                    OutputBox.ScrollBars = ScrollBars.None;
                }
                if (checklines.Length > maxlines)
                {
                    Interaction.Beep();
                    Interaction.MsgBox("Label contains more than " + maxlines + " lines.", MsgBoxStyle.Exclamation, "Too Many Lines");
                    linesOK = false;
                }
                var loopTo = checklines.Length - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(checklines.GetValue(i).ToString().Length, maxChars, false)))
                    {
                        Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Line #" + (i + 1) + ": ", checklines.GetValue(i)), Constants.vbCrLf), " contains more than "), maxChars), " characters."));
                        charsOK = false;
                    }
                }
            }
            plOutput.Text = "";
            plOutput.Font = new Font(inFontName.Text, Conversions.ToSingle(inFontSize.Text), FontStyle.Regular);

            if (chkUsePocketLabels.Checked)
            {
                try
                {
                    CreatePocketLabel();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("User-defined pocket label error." + Constants.vbCrLf + "The maximum number of lines for XML field ", quot), ex.Message), quot), " must not be less than the minimum, and/or must not be zero."), MsgBoxStyle.Exclamation, "Custom Label Line Space Error");
                    return;
                }
            }

            if (AutoPrintBox.Checked & charsOK & linesOK)
            {
                if (UseZPL.Checked)
                {
                    zplAddBtn.PerformClick();
                } else {
                    editText = "";
                    ManualPrint.PerformClick(); // send text to printer
                }
            }

        }

        private int checkLineLength()
        {
            Array checklines = null;
            int maxChars = Conversions.ToInteger(inMaxChars.Text);
            int i = 0;
            int r = 99;
            checklines = Strings.Split(OutputBox.Text, Constants.vbCrLf);
            var loopTo = checklines.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(checklines.GetValue(i).ToString().Length, maxChars, false)))
                {
                    r = i + 1; // if a line exceeds the specified line length, the 1-based line number is returned
                    break;
                }
            }
            return r; // if r returns with 99, all lines are OK.
        }
        private string Custom2(string fields)
        {

            if (string.IsNullOrEmpty(Strings.Trim(fields)))
            {
                return "";
                return default;
            }

            int i = 0;
            int j = 0;
            string cf = "";
            Array custom;
            string fmt = "";
            Array fmtreturn;
            string freetext = "";
            object val = "";
            object lbl = "";
            string quot = "\"";
            string txt = "";
            string fldval = "";
            string s = Constants.vbCrLf;
            int bg, nd;
            int qlen = 0;
            int charWrap = 0;
            string s1, s2, s3;
            int stringLength = 0;

            fields = fields.Replace("><", "/");

            custom = Strings.Split(fields, Constants.vbCrLf);
            // When Spine labels are selected, only the "Include other field" is sent through this routine.
            // If that field is wrapped, it must be wrapped to the Chars/Line value, not to a length.
            if (Spine.Checked)
            {
                charWrap = Conversions.ToInteger(inMaxChars.Text);
            }
            // getFmt returns an array in fmtreturn.  Fmtreturn(0) is the format string, Fmtreturn(1) is any quoted text

            try
            {
                var loopTo = custom.Length - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    cf = Conversions.ToString(custom.GetValue(i));
                    wrapping = false;
                    bg = cf.IndexOf("<");
                    nd = cf.IndexOf(">");
                    if (bg != -1 & nd != -1 & bg < nd) // if this is a <xml_value> in angle brackets,
                    {
                        fmtreturn = getFmt(Strings.Trim(cf.Substring(0, bg)));
                        fmt = Conversions.ToString(fmtreturn.GetValue(0));
                        cf = cf.Substring(bg, nd - bg + 1);
                        if (fmt.Contains("*"))
                        {
                            fldval = xmlValue(cf, true);
                        }
                        else
                        {
                            fldval = xmlValue(cf);
                        }
                        stringLength = 0;
                        string stringLengthString;
                        stringLengthString = Constants.vbNullString;
                        var loopTo1 = fmt.Length - 1;
                        for (j = 0; j <= loopTo1; j++)
                        {
                            if ("0123456789".Contains(Conversions.ToString(fmt[j])))
                            {
                                stringLengthString += fmt.Substring(j, 1);
                            }
                        }
                        if (!ReferenceEquals(stringLengthString, Constants.vbNullString))
                        {
                            stringLength = Convert.ToInt32(stringLengthString);
                        }
                        if (fldval.Length > 0 & fldval.Length > stringLength & stringLength > 0)
                        {
                            fldval = fldval.Substring(0, stringLength);
                        }
                        txt = Conversions.ToString(Operators.ConcatenateObject(fmtreturn.GetValue(1), fldval));
                    }
                    else // if this is a free-text string
                    {
                        fmtreturn = getFmt(cf);
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(fmtreturn.GetValue(1), "", false)))
                            qlen = 2; // if quoted text exists, account for quote marks
                        txt = Conversions.ToString(Operators.ConcatenateObject(fmtreturn.GetValue(1), cf.Substring(Conversions.ToInteger(Operators.AddObject(Operators.AddObject(fmtreturn.GetValue(0).ToString().Length, fmtreturn.GetValue(1).ToString().Length), qlen)))));
                        fmt = Conversions.ToString(fmtreturn.GetValue(0));
                    }

                    if (string.IsNullOrEmpty(Strings.Trim(txt)))
                        continue;
                    // 
                    // txt = Trim(getPrefix(fmt) & Trim(txt)) 'add any prefix to the value.
                    if (!string.IsNullOrEmpty(fmt))
                    {

                        if (fmt.Contains("*"))
                        {
                            s1 = "";
                            s2 = "";
                            s3 = "";
                            if (string.IsNullOrEmpty(suppress1.Text))
                                s1 = "@@";
                            else
                                s1 = suppress1.Text;
                            if (string.IsNullOrEmpty(suppress2.Text))
                                s2 = "@@";
                            else
                                s2 = suppress2.Text;
                            if (string.IsNullOrEmpty(suppress3.Text))
                                s3 = "@@";
                            else
                                s3 = suppress3.Text;
                            // If Trim(fldval.Replace("0", "")) = "" Then
                            if (string.IsNullOrEmpty(Strings.Trim(fldval.Replace(s1, "").Replace(s2, "").Replace(s3, ""))))
                            {
                                // Exit For
                                txt = "";
                            }
                        }

                        if (fmt.Contains("~"))
                            lbl = Operators.ConcatenateObject(lbl, Constants.vbCrLf);
                        if (fmt.Contains("!"))
                            lbl = Operators.ConcatenateObject(lbl, "!");
                        if (fmt.Contains("+"))
                        {
                            lbl = Operators.ConcatenateObject(lbl, aboveCall(libxml, locxml).Replace(";", Constants.vbCrLf));
                            txt = "";
                        }

                        if (fmt.Contains("="))
                            wrapping = true;

                        if (fmt.Contains("%")) // if call number parse prefix,
                        {
                            val = wrap(parseLC(txt), charWrap); // val is parsed call number.
                        }
                        else if (fmt.Contains("#")) // 0therwise, if holdings-parse prefix,
                        {
                            val = wrap(parseIssue(txt).Replace("^", ":" + Constants.vbCrLf), charWrap); // val is parsed holdings
                        }
                        else
                        {
                            val = wrap(txt, charWrap);
                        } // if neither, val is just the XML value

                        if (fmt.Contains("^"))
                        {
                            lbl = Operators.ConcatenateObject(Operators.ConcatenateObject(lbl, val), " "); // add the value to the outputbox, no line break.
                        }
                        // If lbl <> "" Then lbl = lbl & val & vbCrLf 'add the value to the outputbox w/ linebreak.
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(val, "", false)))
                            lbl = Operators.ConcatenateObject(Operators.ConcatenateObject(lbl, val), Constants.vbCrLf); // add the value to the outputbox w/ linebreak.
                    }

                    else // if no formatting...
                    {
                        lbl = Operators.ConcatenateObject(Operators.ConcatenateObject(lbl, wrap(txt, charWrap)), Constants.vbCrLf);
                    }
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Custom2(): " + ex.ToString());
            }
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(((dynamic)lbl).Length, 2, false)))
            {
                lbl = Operators.ConcatenateObject(Constants.vbCrLf, ((dynamic)lbl).Substring(0, Operators.SubtractObject(((dynamic)lbl).Length, 2))); // removes crlf from end of string
            }
            return Conversions.ToString(lbl);
        }
        private Array getFmt(string arg)
        {
            // loop thru free text arg, storing initial format chars (~ # % ! ^) in 'fmt'
            // Removes quoted "prefix" text that may contain these characters.
            string fmt = "";
            string quot = "\"";
            Array a;
            string argnoquot = "";
            string c = "";
            int i = 0;
            string qm = "";
            int qcount = 0;
            if (string.IsNullOrEmpty(Strings.Trim(arg))) // if arg is null,
            {
                return Strings.Split("" + "|" + "", "|"); // return two empty fields.
            }

            if (arg.Contains(quot))
            {
                a = arg.Split(Conversions.ToChar(quot));
                qcount = a.Length - 1;
                // Label27.Text = qcount
                if (qcount % 2 != 0)
                {
                    Interaction.MsgBox("Unbalanced quotation marks in format string: " + arg, MsgBoxStyle.Exclamation, "Unbalanced quotes in format string");
                    return Strings.Split("" + "|" + "", "|"); // return two empty fields.
                }
                argnoquot = Conversions.ToString(Operators.ConcatenateObject(a.GetValue(0), a.GetValue(2)));
                qm = Conversions.ToString(a.GetValue(1));
            }
            else
            {
                argnoquot = arg;
            }

            var loopTo = argnoquot.Length;
            for (i = 1; i <= loopTo; i++)
            {
                c = Strings.Mid(argnoquot, i, 1);
                if ("~=!#%^*+".Contains(c) | "0123456789".Contains(c))
                {
                    fmt = fmt + c;
                }
                else
                {
                    break;
                }
            }
            return Strings.Split(fmt + "|" + qm, "|");
        }
        private string getPrefix(string fmt)
        {
            string quot = "\"";
            Array a;
            if (!fmt.Contains(quot))
                return "";
            a = fmt.Split(Conversions.ToChar(quot)); // splitting on quots puts the contents in element #1 (0 and 2 have the quots)
            return Conversions.ToString(a.GetValue(1)); // return the text string between the quots.
        }
        private string CreateFlagSlip()
        {
            int i = 0;
            string custom_field = "";
            Array custom;
            string lname = "";
            string cn = "";
            string itm = "";
            string bc = "";
            string titl = "";
            float mywidth = 0.0f;
            var myfont = new Font(fontname, 10f);
            custom = Strings.Split(CustomText.Text, Constants.vbCrLf);

            OutputBox.Font = myfont;
            var loopTo = custom.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {
                custom_field = Conversions.ToString(custom.GetValue(i));

                if (custom_field == "<call_number>")
                {
                    cn = parseLC(xmlValue(custom_field));
                }
                if (custom_field == "<issue_level_description>")
                {
                    itm = parseIssue(xmlValue(custom_field));
                    itm = itm.Replace("^", ":"); // non-breaking colon returns as ^, and is replaced by :
                    itm = wrap(itm);
                }
                if (custom_field == "<barcode>")
                {
                    bc = "!" + xmlValue(custom_field);
                }
                if (custom_field.Contains("<title>"))
                {
                    titlexml = xmlValue(custom_field);
                    titl = "~" + wrap(titlexml);
                }
                if (custom_field == "<location_name>")
                {
                    lname = "~" + xmlValue(custom_field);
                    lname = wrap(lname);
                }
            }
            return bc + Constants.vbCrLf + lname + Constants.vbCrLf + cn + Constants.vbCrLf + itm + Constants.vbCrLf + titl;
        }
        private void CreatePocketLabel()
        {
            Array plValues;
            Array plParam;
            int plMin = 0;
            int plMax = 0;
            int i = 0;
            int k = 0;
            string temp = "";
            string formatChar = "";
            plParam = PocketParams();
            wrapping = true;
            indenting = true;


            var loopTo = plParam.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {
                plValues = Strings.Split(Conversions.ToString(plParam.GetValue(i)), ";");
                if (string.IsNullOrEmpty(Strings.Trim(Conversions.ToString(plValues.GetValue(0)))))
                {
                    continue;
                }
                plMin = Conversions.ToInteger(plValues.GetValue(1));
                plMax = Conversions.ToInteger(plValues.GetValue(2));
                if (plMin > plMax | plMax == 0)
                {
                    throw new Exception(Conversions.ToString(plValues.GetValue(0))); // send back the XML field name that has bad min/max lines.
                    return;
                }
                plWork.Text = "";

                if (Strings.Mid(Conversions.ToString(plValues.GetValue(0)), 1, 1) == "!")
                {
                    formatChar = "!";
                    plValues.SetValue(Strings.Mid(Conversions.ToString(plValues.GetValue(0)), 2, Conversions.ToInteger(Operators.SubtractObject(plValues.GetValue(0).ToString().Length, 1))), 0); // remove the !
                }
                else
                {
                    formatChar = "";
                }

                temp = formatChar + this.xmlValue(plValues.GetValue(0));
                if (Conversions.ToBoolean(plValues.GetValue(0).ToString().Contains("title>")))
                {
                    if (temp.Substring(temp.Length - 2) == " /")
                    {
                        temp = temp.Substring(0, temp.Length - 2);
                    }
                }
                // plWork.Text = plWork.Text & wrap(xmlValue(plValues(0)))
                plWork.Text = plWork.Text + wrap(temp, 28);
                plWork.Text = plWork.Text + Strings.StrDup(5, Constants.vbCrLf);
                if (string.IsNullOrEmpty(plWork.Text) & plMin == 0)
                    continue;
                k = 0;
                while (k < plMin) // print minimum number of lines
                {
                    plOutput.Text = plOutput.Text + plWork.Lines[k].ToString() + Constants.vbCrLf;
                    k = k + 1;
                }

                while (k < plMax & !string.IsNullOrEmpty(plWork.Lines[k])) // stop at maximum, or when no more lines.
                {
                    plOutput.Text = plOutput.Text + plWork.Lines[k].ToString() + Constants.vbCrLf;
                    k = k + 1;
                }

            }
            plOutput.Text = plOutput.Text.Substring(0, plOutput.Text.Length - 2); // remove final crlf
            wrapping = false;
            indenting = false;
        }
        private Array PocketParams()
        {
            Array plParam;
            if (btnSLB.Checked)
            {
                plParam = Strings.Split("<call_number>;1;1|<author>;1;2|<title>;1;2", "|");
                labelCount = 1;
            }
            else if (btnSL4.Checked)
            {
                plParam = Strings.Split("<call_number>;1;1|<author>;1;2|<title>;1;2", "|");
                labelCount = 2;
            }
            else if (btnSL6.Checked)
            {
                plParam = Strings.Split("<call_number>;2;2|<author>;2;3|<title>;1;3", "|");
                labelCount = 2;
            }
            else
            {
                plParam = Strings.Split(plSrc1.Text + ";" + plMin1.Text + ";" + plMax1.Text + "|" + plSrc2.Text + ";" + plMin2.Text + ";" + plMax2.Text + "|" + plSrc3.Text + ";" + plMin3.Text + ";" + plMax3.Text + "|" + plSrc4.Text + ";" + plMin4.Text + ";" + plMax4.Text, "|");
                labelCount = (int)Math.Round(PLcount.Value);
            }
            return plParam;
        }
        private string HexString(string EvalString)
        {
            string HexStringRet = default;
            int intStrLen;
            int intLoop;
            string strHex = "";

            EvalString = Strings.Trim(EvalString);
            intStrLen = Strings.Len(EvalString);
            var loopTo = intStrLen;
            for (intLoop = 1; intLoop <= loopTo; intLoop++)
                strHex = strHex + " " + Conversion.Hex(Strings.Asc(Strings.Mid(EvalString, intLoop, 1)));
            HexStringRet = strHex;
            return HexStringRet;
        }
        private string wrap(string textline, int useCharCount = 0)
        {
            // wrap a string to the label width [if no useCharCount is passed to this routine]
            // wrap a string to a specified number of characters if useCharCount is provided]
            // ***********
            if (!wrapping)
                return textline;
            // ***********
            if (string.IsNullOrEmpty(Strings.Trim(textline)))
                return "";
            if (textline.Length > 200)
            {
                textline = Strings.Mid(textline, 1, 200) + "...";
            }
            int maxCharsPerLine = 0;

            if (useCharCount == 0)
            {
                int chars = textline.Length;
                object textwidth = Measure(textline, "t");
                float fitToWidth = (float)((double)Conversions.ToSingle(wrapWidth.Text) * 0.9d); // use a 10% buffer
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLessEqual(textwidth, fitToWidth, false)))
                    return textline;
                float cpi = Conversions.ToSingle(Operators.DivideObject(chars, textwidth));
                maxCharsPerLine = (int)Math.Round(cpi * fitToWidth);
            }

            else
            {
                maxCharsPerLine = useCharCount;
                if (textline.Length <= useCharCount)
                    return textline;
            }

            string result = "";
            int @base = 1;
            int inc = 0;
            string s = "";
            int lastSpace = 0;
            int i = 0;
            string indentChar = "";
            if (indenting)
            {
                indentChar = " ";
            }
            else
            {
                indentChar = "";
            }

            try
            {
                do
                {
                    lastSpace = Strings.Mid(textline, @base, maxCharsPerLine).LastIndexOf(" ");
                    if (lastSpace == -1)
                    {
                        textline = textline.Insert(@base + maxCharsPerLine - 1, "-|");
                        @base = @base + maxCharsPerLine + 2;
                    }
                    else
                    {
                        StringType.MidStmtStr(ref textline, @base + lastSpace, 1, "|");
                        @base = @base + lastSpace;
                    }
                    if (textline.Length - @base <= maxCharsPerLine)
                        break;
                }
                while (true);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("The font size (" + inFontSize.Text + ") is too large to properly fit in the label width (" + inLabelWidth.Text + ")");
                return "[font too large]";
            }

            return textline.Replace("|", Constants.vbCrLf + indentChar);
        }

        private float Measure(string BannerText, string fontType)
        {
            // fontType is "t" for measuring a text font, or bc for measuring a barcode font.
            float mywidth;
            Bitmap b;
            Graphics g;
            SizeF stringSize;
            // Dim units As GraphicsUnit = GraphicsUnit.Inch
            var f = new Font(inFontName.Text, Conversions.ToSingle(inFontSize.Text));
            var bc = new Font(inBCFontName.Text, Conversions.ToSingle(inBCFontSize.Text));
            // Compute the string dimensions in the given font
            b = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            g = Graphics.FromImage(b);
            g.PageUnit = GraphicsUnit.Inch;

            if (fontType == "t")
            {
                stringSize = g.MeasureString(BannerText, f);
            }
            else
            {
                stringSize = g.MeasureString(BannerText, bc);
            }

            mywidth = stringSize.Width;
            // Height = stringSize.Height
            g.Dispose();
            b.Dispose();
            return mywidth;
        }
        public string cleanup(string callout)
        {
            callout = callout.Replace(Constants.vbCrLf + " ", Constants.vbCrLf);
            callout = callout.Replace(Constants.vbCrLf + Constants.vbCrLf, Constants.vbCrLf);
            if (callout.StartsWith(Constants.vbCrLf))
            {
                callout = callout.Substring(1);
            }
            // *** unfinished routine to limit labels to user-specified number of lines, and dump
            // *** remaining portion of call number on last line.
            // If usingDewey Then
            // If deweyGroup3.Enabled And deweyGroup3.Checked Then
            // Dim nlcount = Len(callout) - Len(callout.Replace("vbcrlf", ""))
            // Dim maxlines As Integer = CType(deweyMaxLines.Text, Integer)
            // If nlcount > maxlines Then
            // Do While nlcount - maxlines <> 0

            // Loop
            // End If
            // End If
            // End If
            return callout;
        }

        private string parseLC(string cn)
        {
            string callout = "";
            string cutter = "";
            string diagstring = "";
            string match = "";
            int pos = 1;
            int i = 0;
            if (cn == "*")
            {
                return "";
                return default;
            }

            if (!cn.Contains("*")) // TEST call nums will start with *
            {
                cntype = xmlValue("<call_number_type>"); // if not TEST, get call number type from XML
            }
            else
            {
                cn = cn.Replace("*", "");
                // The TEST process will have already set the cntype, so don't get it from the XML record.
            } // if TEST, remove *

            if (string.IsNullOrEmpty(Strings.Trim(cntype)))
                cntype = convertBlankTo.Text;
            // 
            if (DeweyType.Text.Contains(cntype))
            {
                callout = Conversions.ToString(parseDewey(cn));
                callout = cleanup(callout);
                return callout;
            }
            else if (sudocType.Text.Contains(cntype))
            {
                callout = parseSuDoc2(cn);
                callout = cleanup(callout);
                return callout;
            }
            else if (otherType.Text.Contains(cntype))
            {
                callout = Conversions.ToString(parseOther(cn));
                callout = cleanup(callout);
                return callout;
            }
            else if (!lcType.Text.Contains(cntype))
            {
                Interaction.MsgBox("Call number type " + cntype + " is not handeld by any parsing routine.");
                return "Unhandled Call Number Type";
            }


            // If we arrive here, process LC:

            while (char.IsLetter(Conversions.ToChar(Strings.Mid(cn, pos, 1)))) // loop through LC class letters
            {
                callout = callout + Strings.Mid(cn, pos, 1);
                pos = pos + 1;
            } // exit when we hit a non-letter

            if (lcNumericBreak.Checked)
            {
                callout = callout + Constants.vbCrLf; // add a cr/lf
            }
            // End If
            // loop through class numerics, including decimal if present.
            // loop while we see digits, or a decimal followed by a digit.
            if (Strings.Mid(cn, pos, 1) == " ")
            {
                pos = pos + 1;
            }

            while (char.IsDigit(Conversions.ToChar(Strings.Mid(cn, pos, 1))) | Strings.Mid(cn, pos, 1) == "." & char.IsDigit(Conversions.ToChar(Strings.Mid(cn, pos + 1, 1))))
            {
                callout = callout + Strings.Mid(cn, pos, 1);
                pos = pos + 1;
            }

            if (lcDecimalBreakAfter.Checked)
            {
                callout = callout.Replace(".", "." + Constants.vbCrLf);
            }

            if (lcDecimalBreakB4.Checked)
            {
                callout = callout.Replace(".", Constants.vbCrLf + ".");
            }

            if (lcCutterBreak.Checked)
            {
                callout = callout + Constants.vbCrLf; // add a cr/lf after the class numerics
            }
            else
            {
                callout = callout + " ";
            }

            cutter = cn.Substring(pos - 1); // trim off the rest of the cn and put it in the cutter var.
                                            // if cutter starts with a space or punctuation other than a decimal, remove it
            if (Strings.Mid(cutter, 1, 1) == " " | char.IsPunctuation(Conversions.ToChar(Strings.Mid(cutter, 1, 1))) & !(Strings.Mid(cutter, 1, 1) == "."))
            {
                cutter = cutter.Substring(1);
            }
            // *******
            if (lcCutterBreak.Checked)
            {
                cutter = cutter.Replace(" .", Constants.vbCrLf + ".");
            }
            else
            {
                cutter = cutter.Replace(" .", ".");
            }

            if (hideCutterDecimal.Checked)
            {
                // cutter = cutter.Replace(".", "")

                // If cutter begins with a decimal, remove it.
                // But make sure the cutter exists before referring to a substring...
                if (cutter.Length > 1 && cutter.Substring(0, 1) == ".")
                {
                    cutter = cutter.Substring(1);
                }

            }

            // *******
            // parseCaption2 determines which spaces in the cutter should cause a line break.
            // In ".H27 L43 2011", or ".H2345x 1997" or ".H143 1990", each space should cause a break.
            // In ".H27 v. 4", the space between "v." and "4" should not cause a break.

            cutter = parseCaption2(cutter); // initially, all spaces are turned into "?"

            // then, each is examined to see if should cause a break or not.
            if (lcInCutterBreak.Checked)
            {
                cutter = cutter.Replace(" ", Constants.vbCrLf); // those that should break are turned back into spaces
            }
            cutter = cutter.Replace("?", " "); // those that should not break are left as ?,
                                               // and this line turns those back into ordinary spaces before printing occurs.

            callout = callout + cutter;

            if (!lcOtherNoBreak.Checked)
            {
                lcBreak.Text = Strings.Trim(lcBreak.Text);
                var loopTo = lcBreak.Lines.Length - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    match = Strings.Trim(lcBreak.Lines[i]);
                    if (!string.IsNullOrEmpty(match) & callout.Contains(match))
                    {
                        if (lcOtherBreakB4.Checked)
                        {
                            callout = callout.Replace(match, Constants.vbCrLf + match);
                        }
                        else
                        {
                            callout = callout.Replace(match, match + Constants.vbCrLf);
                        }
                        if (lcRemoveAfter.Checked)
                            callout = callout.Replace(match, "");
                    }
                }
            }

            callout = cleanup(callout);

            return callout;
        }

        private object parseDewey(string cn)
        {
            string callout = "";
            string cutter = "";
            string afterdecimal = "";
            int pos = 0;
            int p = 0;
            int i = 0;
            int c = 0;
            string ch = "";
            int dcnt = 0;
            cn = Strings.Trim(cn);
            // find cutter:
            // look for 1st digit
            var loopTo = cn.Length - 1;
            for (i = 0; i <= loopTo; i++)
            {
                if (char.IsDigit(Conversions.ToChar(Strings.Mid(cn, i + 1, 1))))
                {
                    break;
                }
            }

            // loop until space (digits after decimal may contain alpha chars.
            var loopTo1 = cn.Length - 1;
            for (c = i; c <= loopTo1; c++)
            {
                if (Strings.Mid(cn, c + 1, 1) == " ")
                {
                    break;
                }
            }
            callout = cn.Substring(0, c);
            cutter = cn.Substring(c);

            if (deweyPrefixBreak.Checked)
            {
                if (char.IsLetter(Conversions.ToChar(Strings.Mid(callout, 1, 1))))
                {
                    var loopTo2 = callout.Length - 1;
                    for (i = 0; i <= loopTo2; i++)
                    {
                        if (char.IsDigit(Conversions.ToChar(Strings.Mid(callout, i + 1, 1))))
                        {
                            callout = callout.Substring(0, i).Replace(" ", Constants.vbCrLf) + Constants.vbCrLf + callout.Substring(i);
                            break;
                        }
                    }
                }
            }

            if (!deweyDecimalNoBreak.Checked)
            {
                // look for a decimal that has a digit on either side
                pos = callout.IndexOf(".");
                if (pos != -1)
                {
                    if (char.IsDigit(Conversions.ToChar(callout.Substring(pos - 1, 1))) & char.IsDigit(Conversions.ToChar(callout.Substring(pos + 1, 1))))
                    {
                        // replace this decimal (and not any others later in the call num) with a vertical bar
                        callout = callout.Substring(0, pos) + "|" + callout.Substring(pos + 1);
                        if (deweyDecimalBreakb4.Checked)
                        {
                            callout = callout.Replace("|", Constants.vbCrLf + "."); // break before: make it new line then dot
                        }
                        else
                        {
                            callout = callout.Replace("|", "." + Constants.vbCrLf); // break after: make it dot then new line
                            if (deweyGroup3.Checked)
                            {
                                callout = groupSplit(callout);
                            }
                        }
                    }
                }
            }
            else
            {
                // Break on a specified number of digits past the decimal point
                pos = callout.IndexOf("."); // find the class decimal

                if (pos != -1)
                {
                    if (deweyDecBreak.Checked)
                    {
                        // xxxxxxxxxxxxxxxxxxxx New Routine Goes Here xxxxxxxxxxxxxxxxxxxxxx
                        p = pos + 1;
                        // count the number of digits after the class decimal
                        var loopTo3 = callout.Length - 1;
                        for (i = p; i <= loopTo3; i++)
                        {
                            ch = callout.Substring(i, 1);
                            if (!char.IsDigit(Conversions.ToChar(ch)))
                                break;
                            dcnt = dcnt + 1;
                        }
                        if (dcnt > Conversions.ToInteger(deweyDigitsToBreak.Text))
                        {
                            callout = callout.Insert(pos + Conversions.ToInteger(deweyDigitsToBreak.Text) + 1, Constants.vbCrLf);
                        }
                    }
                }
            }

            if (deweyCutterBreak.Checked)
            {
                callout = callout + Constants.vbCrLf + cutter.Replace(". ", "|").Replace(" ", Constants.vbCrLf).Replace("|", ". ");
            }
            else
            {
                callout = callout + " " + cutter;
            }


            if (deweyOtherNoBreak.Checked)
                return callout;
            if (string.IsNullOrEmpty(Strings.Trim(deweyCharBreak.Text)))
                return callout;
            string match = "";
            var loopTo4 = deweyCharBreak.Lines.Length - 1;
            for (i = 0; i <= loopTo4; i++)
            {
                match = Strings.Trim(deweyCharBreak.Lines[i]);
                if (!string.IsNullOrEmpty(match) & callout.Contains(match))
                {
                    if (deweyCharBreakb4.Checked)
                    {
                        callout = callout.Replace(match, Constants.vbCrLf + match);
                    }
                    else
                    {
                        callout = callout.Replace(match, match + Constants.vbCrLf);
                    }
                    if (deweyRemoveAfter.Checked)
                        callout = callout.Replace(match, "");
                }
            }

            usingDewey = true;
            callout = cleanup(callout);
            return callout;
        }
        private string groupSplit(string cn)
        {
            int pos;
            string newcn = "";
            int j = 0;
            int k = 0;
            int brake = 0;
            int cpl;

            cpl = Conversions.ToInteger(deweydigitsperline.Text);
            pos = cn.IndexOf(".") + 2;
            if (pos == -1)
                return cn;
            pos = pos + 1;
            newcn = cn.Substring(0, pos) + Constants.vbCrLf;
            // pos points to first character after the decimal point
            j = pos;
            while (pos < cn.Length && char.IsDigit(Conversions.ToChar(cn.Substring(pos))))
            {
                brake = brake + 1;
                if (brake > 20)
                    return "whoa";
                newcn = newcn + cn.Substring(pos, 1);
                j = j + 1;
                k = k + 1;
                if (k % cpl == 0 & pos + 1 < cn.Length && char.IsDigit(Conversions.ToChar(cn.Substring(pos + 1))))
                {
                    newcn = newcn + Constants.vbCrLf;
                    j = j + 2;
                }
                pos = pos + 1;
            }
            newcn = newcn + cn.Substring(pos);

            return newcn;
        }
        private string parseSuDoc2(string cn)
        {
            Array cpart;
            string pre, post;
            object separator = "";
            int i = 0;
            string callout = "";

            if (sudocBreakB4Numerics.Checked)
            {
                var loopTo = cn.Length - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    if (char.IsDigit(Conversions.ToChar(Strings.Mid(cn, i + 1, 1))))
                    {
                        cn = cn.Substring(0, i) + Constants.vbCrLf + cn.Substring(i);
                        break;
                    }
                }
            }

            if (sudocBreakBeforeColon.Checked)
            {
                separator = Constants.vbCrLf + ":";
            }
            else if (sudocBreakAfterColon.Checked)
            {
                separator = ":" + Constants.vbCrLf;
            }
            else
            {
                separator = ":";
            }

            cpart = Strings.Split(cn, ":");
            pre = Conversions.ToString(cpart.GetValue(0));
            post = "";
            if (cpart.Length > 1) // If colon exists...
            {
                post = Conversions.ToString(cpart.GetValue(1));
                if (sudocSlashBreak.Checked)
                {
                    post = Conversions.ToString(cpart.GetValue(1).ToString().Replace("/", Constants.vbCrLf));
                }
                if (sudocBreakDecimal.Checked)
                {
                    pre = pre.Replace(".", Constants.vbCrLf + ".");
                }

                if (sudocDashBreak.Checked)
                {
                    post = breakSpace(post);
                    post = post.Replace("-", Constants.vbCrLf);
                }
                post = post.Replace("?", Constants.vbCrLf);
            }
            else
            {
                post = ""; // if no colon, "post" is null
                separator = "";
            }

            callout = cleanup(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(pre, separator), post)));

            if (sudocOtherNoBreak.Checked)
                return callout;
            if (string.IsNullOrEmpty(Strings.Trim(sudocCharBreak.Text)))
                return callout;
            string match = "";
            var loopTo1 = sudocCharBreak.Lines.Length - 1;
            for (i = 0; i <= loopTo1; i++)
            {
                match = Strings.Trim(sudocCharBreak.Lines[i]);
                if (!string.IsNullOrEmpty(match) & callout.Contains(match))
                {
                    if (sudocCharBreakB4.Checked)
                    {
                        callout = callout.Replace(match, Constants.vbCrLf + match);
                    }
                    else
                    {
                        callout = callout.Replace(match, match + Constants.vbCrLf);
                    }
                    if (sudocRemoveAfter.Checked)
                        callout = callout.Replace(match, "");
                }
            }

            return callout;
        }
        private object parseOther(string cn)
        {
            string callout = "";
            int i = 0;
            // Call number type 4 = "Shelving Control Number; 
            // type 8 is "Other".
            // type 7 is "source specified in subfield $2" - added by customer request
            // These simply break on spaces.
            // If cntype = "4" Or cntype = "8" Then
            callout = cn;
            if (otherAllSpaceBreak.Checked)
            {
                callout = cn.Replace(" ", Constants.vbCrLf);
            }
            else if (otherFirstSpaceBreak.Checked)
            {
                i = callout.IndexOf(" ");
                if (i != -1)
                {
                    StringType.MidStmtStr(ref callout, i + 1, 1, "|");
                    callout = callout.Replace("|", Constants.vbCrLf);
                }
            }


            if (otherNumBreakb4.Checked)
            {
                var loopTo = callout.Length - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    if (Information.IsNumeric(Strings.Mid(callout, i + 1, 1)))
                    {
                        callout = callout.Substring(0, i) + Constants.vbCrLf + callout.Substring(i);
                        break;
                    }
                }
            }
            else if (otherNumBreakAfter.Checked)
            {
                var loopTo1 = callout.Length - 1;
                for (i = 0; i <= loopTo1; i++)
                {
                    if (Information.IsNumeric(Strings.Mid(callout, i + 1, 1)) & Strings.Mid(callout, i + 2, 1) == " ")
                    {
                        StringType.MidStmtStr(ref callout, i + 2, 1, "|");
                        callout = callout.Replace("|", Constants.vbCrLf);
                    }
                }
            }
            callout = cleanup(callout);

            if (otherListNoBreak.Checked)
                return callout;
            if (string.IsNullOrEmpty(Strings.Trim(otherBreak.Text)))
                return callout;
            string match = "";
            var loopTo2 = otherBreak.Lines.Length - 1;
            for (i = 0; i <= loopTo2; i++)
            {
                match = Strings.Trim(otherBreak.Lines[i]);
                if (!string.IsNullOrEmpty(match) & callout.Contains(match))
                {
                    if (otherListBreakb4.Checked)
                    {
                        callout = callout.Replace(match, Constants.vbCrLf + match);
                    }
                    else
                    {
                        callout = callout.Replace(match, match + Constants.vbCrLf);
                    }
                    if (otherRemoveAfter.Checked)
                        callout = callout.Replace(match, "");
                }
            }
            callout = cleanup(callout);
            return callout;
            // End If
        }

        private string breakSpace(string cn)
        {
            // replace a breakable space with "?"
            int i = 1;
            int done = 0;
            cn = Strings.Trim(cn); // make sure no spaces at beginning or end of string
            done = cn.Length;
            do
            {
                if (char.IsDigit(Conversions.ToChar(Strings.Mid(cn, i, 1))) & Strings.Mid(cn, i + 1, 1) == " " & char.IsLetter(Conversions.ToChar(Strings.Mid(cn, i + 2, 1))))
                {
                    StringType.MidStmtStr(ref cn, i + 1, 1, "?");
                }
                i = i + 1;
            }
            while (i < done - 2);
            return cn;
        }
        private string getParsing2(string xmlsource)
        {
            string callout = "";
            string buildLC = "";
            string prefix = "";
            int i = 1;
            if (xmlsource == "<parsed_issue_level_description>")
            {
                prefix = "<issue_level_description_";
            }
            else
            {
                prefix = "<call_no_";
            }

            do
            {
                // buildLC = xmlValue(xmlsource & "<call_no_" & i & ">")
                buildLC = xmlValue(xmlsource + prefix + i + ">");
                if (string.IsNullOrEmpty(buildLC))
                    break;
                if (i != 1)
                    callout = callout + Constants.vbCrLf;
                callout = callout + buildLC;
                i = i + 1;
            }
            while (true);
            return callout.Replace(Constants.vbCrLf + Constants.vbCrLf, Constants.vbCrLf);
        }

        private string parseIssue(string issueText)
        {

            // only return holdings if <issue_level_description> is selected in the "Spine" label type.
            // I.e., ignore the "include holdings" checkbox if using "Custom" label format.

            if (!chkIncludeHoldings.Checked & Spine.Checked)
            {
                return "";
            }

            string issueWork = issueText;
            object maxchars = Conversions.ToInteger(inMaxChars.Text);
            int op = 0;
            int cp = 0;
            int i = 0;

            if (ProtectColon.Checked & ProtectColon.Enabled)
            {
                // if a colon is found inside of parentheses, protect it by replacing it with
                // a caret (^), and then later replacing the caret with a colon plus a cr/lf.
                // The colon remains visible on the final label, but it can still cause a line
                // break (if "break on colon" is checked).
                try
                {
                    op = Strings.InStr(cp + 1, issueWork, "(", CompareMethod.Text);
                    cp = Strings.InStr(op + 1, issueWork, ")", CompareMethod.Text);
                    var loopTo = cp;
                    for (i = op; i <= loopTo; i++)
                    {
                        if (Strings.Mid(issueWork, i, 1) == ":")
                            StringType.MidStmtStr(ref issueWork, i, 1, "^");
                    }
                }
                catch
                {
                    // The routine above will throw an exception if there are no parentheses in
                    // the string, so we are sent here, which does nothing. The error is simply
                    // ignored.
                }

            }

            // If the issue level description contains a colon, assume that no parsing is needed other than
            // replacing colons with cr/lf.
            // if no colons, assume older format material that needs to be parsed by the parseCaption
            // routine (i.e., break on space unless space immediately follows an alpha string.)

            if (ColonBreak.Checked & issueWork.IndexOf(":") != -1)
            {
                issueWork = issueWork.Replace(" :", ":").Replace(": ", ":").Replace(":", Constants.vbCrLf);
                if (ProtectColon.Checked)
                {
                    issueWork = issueWork.Replace("^", ":" + Constants.vbCrLf);
                }
            }
            else
            {
                issueWork = issueWork;
                issueWork = Strings.Trim(parseCaption2(issueWork));
                // breakable spaces are now " ", non-breakable spaces are "?"

                if (spaceBreak.Checked)
                {
                    issueWork = issueWork.Replace(" ", Constants.vbCrLf); // replace breakable spaces with crlf
                }

                issueWork = issueWork.Replace("?", " ");
            } // turn non-breakable spaces back into spaces

            if (Conversions.ToBoolean(Operators.AndObject(BreakParen.Checked, Operators.ConditionalCompareObjectGreater(issueWork.Replace(Constants.vbCrLf, "").Length, maxchars, false))))
            {
                issueWork = issueWork.Replace("(", Constants.vbCrLf + "(");
            }

            if (issueListNoBreak.Checked)
                return issueWork;
            if (string.IsNullOrEmpty(Strings.Trim(issueBreak.Text)))
                return issueWork;

            string match = "";

            var loopTo1 = issueBreak.Lines.Length - 1;
            for (i = 0; i <= loopTo1; i++)
            {
                match = Strings.Trim(issueBreak.Lines[i]);
                match = match.Replace("~", " ");
                if (!string.IsNullOrEmpty(match) & issueWork.Contains(match))
                {
                    if (issueListBreakB4.Checked)
                    {
                        issueWork = issueWork.Replace(match, Constants.vbCrLf + match);
                    }
                    else
                    {
                        issueWork = issueWork.Replace(match, match + Constants.vbCrLf);
                    }
                    if (issueRemoveAfter.Checked)
                        issueWork = issueWork.Replace(match, "");
                }

            }

            return issueWork;
        }

        public string parseCaption2(string cutter)
        {
            string c = cutter;
            int i = 0;
            int done = 0;
            int pos = 0;
            // replace every space in the cutter with a "?" (which ensures that all spaces will not
            // cause a break.)
            c = c.Replace(" ", "?");
            i = 1;
            done = c.Length;

            // Then examine the characters on both sides of each "?" to see if that space
            // should be breakable or not.
            do
            {

                if (char.IsDigit(Conversions.ToChar(Strings.Mid(c, i, 1))) & Strings.Mid(c, i + 1, 1) == "?" & char.IsLetter(Conversions.ToChar(Strings.Mid(c, i + 2, 1))))
                {
                    // if we find digit/?/letter, that ? should be replaced by a space, causing a break.
                    // so in "H237?J14", the ? will be replaced by a breakable space
                    StringType.MidStmtStr(ref c, i + 1, 1, " ");
                }
                // If Mid$(c, i, 1) = "x" And Mid$(c, i + 1, 1) = "?" And Char.IsDigit(Mid$(c, i + 2, 1)) Then
                if (char.IsLetter(Conversions.ToChar(Strings.Mid(c, i, 1))) & Strings.Mid(c, i + 1, 1) == "?" & IsYear(c, i + 2) == true)
                {
                    // if "x?digit", the space should be breakable as well.
                    // so in "H1234x?1927", the space will be breakable.
                    // MODIFIED: Any letter (not just 'x') followed by a 4-digit date will break.
                    StringType.MidStmtStr(ref c, i + 1, 1, " ");
                }

                if (char.IsDigit(Conversions.ToChar(Strings.Mid(c, i, 1))) & Strings.Mid(c, i + 1, 1) == "?" & char.IsDigit(Conversions.ToChar(Strings.Mid(c, i + 2, 1))))
                {
                    // if "digit?digit", the space should be breakable
                    // so in "H27?2011", the space will be breakable.
                    StringType.MidStmtStr(ref c, i + 1, 1, " ");
                }

                i = i + 1;
            }
            while (i < done - 2);

            return c;
        }
        private bool IsYear(string c, int i)
        {
            // c is the string containing the cutter
            // i is the position in c of the first character that might or might not be the first digit of a year.
            // If the four characters starting at position i are all numeric, IsYear returns True.
            if (char.IsDigit(Conversions.ToChar(Strings.Mid(c, i, 1))) & char.IsDigit(Conversions.ToChar(Strings.Mid(c, i + 1, 1))) & char.IsDigit(Conversions.ToChar(Strings.Mid(c, i + 2, 1))) & char.IsDigit(Conversions.ToChar(Strings.Mid(c, i + 3, 1))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string aboveCall(string libname, string liblocation)
        {
            string labeltext = "";
            string listentry = "";
            string lookfor = libname + "+" + liblocation;
            int len = lookfor.Length;
            string testentry = "";
            int i = 0;
            int itemindex = 0;
            var loopTo = altList.Items.Count - 1;
            for (i = 0; i <= loopTo; i++)
            {
                testentry = Conversions.ToString(altList.Items[i]);
                if ((Strings.Mid(testentry, 1, testentry.IndexOf("=")) ?? "") == (lookfor ?? ""))
                {
                    labeltext = testentry.Substring(testentry.IndexOf("=") + 1) + Constants.vbCrLf;
                    break;
                }
            }
            return labeltext;
        }

        private void loadLabelText()
        {
            ignoreChange = true;
            string inrec = "";
            string itm = "";
            int pos = 0;
            int tab1 = 0;
            int tab2 = 0;
            string library = "";
            string location = "";
            string labeltext = "";
            StreamWriter sw;
            string savecombotext = Conversions.ToString(ComboBox1.SelectedItem);

            StreamReader sr;
            FileStream fs;

            if (!File.Exists(mypath + ALTfile))
            {
                sw = File.CreateText(mypath + ALTfile);
                sw.Close();
            }
            fs = new FileStream(mypath + ALTfile, FileMode.Open);
            sr = new StreamReader(fs);
            itm = sr.ReadLine();
            altList.Items.Clear();
            ComboBox1.Items.Clear();
            ComboBox1.Items.Add("All Libraries");

            try
            {
                while (itm is not null)
                {
                    if (itm.Length > 5) // ignore blank/incomplete lines
                    {
                        if (itm.Contains(Constants.vbTab))
                        {
                            tab1 = Strings.InStr(itm, Constants.vbTab);
                            tab2 = Strings.InStr(tab1 + 1, itm, Constants.vbTab, CompareMethod.Text);
                            library = Strings.Mid(itm, 1, tab1 - 1);
                            location = Strings.Mid(itm, tab1 + 1, tab2 - tab1 - 1);
                            labeltext = Strings.Mid(itm, tab2 + 1, 99);
                            inrec = library + "+" + location + "=" + labeltext;
                            if (string.IsNullOrEmpty(Strings.Trim(labeltext)))
                            {
                                itm = sr.ReadLine();
                                continue;
                            }
                        }
                        else
                        {
                            inrec = Strings.Trim(itm);
                            pos = Strings.InStr(itm, "+", CompareMethod.Text);
                            library = Strings.Mid(itm, 1, pos - 1);
                            pos = Strings.InStr(itm, "=", CompareMethod.Text);
                            if (pos == inrec.Length)
                            {
                                labeltext = "";
                            }
                            else
                            {
                                labeltext = Strings.Mid(inrec, pos + 1, inrec.Length - pos);
                            }
                            if (string.IsNullOrEmpty(Strings.Trim(labeltext)))
                            {
                                itm = sr.ReadLine();
                                continue;
                            }
                        }
                        if (ComboBox1.Items.Contains(library) == false)
                        {
                            ComboBox1.Items.Add(library);
                        }

                        if (ComboBox1.Text == "All Libraries" | (ComboBox1.Text ?? "") == (library ?? ""))
                        {
                            altList.Items.Add(inrec);
                        }
                    }

                    itm = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("The file '" + ALTfile + "' could not be found." + Constants.vbCrLf + "Reason: " + ex.Message);
            }

            sr.Close();
            fs.Close();
            ComboBox1.Text = savecombotext;
            ignoreChange = false;
        }

        private void writeFile(string fpath, string fstring, bool append)
        {

            // writes the "labelout.txt" file to path: c:\a_spine, or any other file/path
            // passed to the subroutine. "append" is true to append, false to replace file data.
            StreamWriter sw;
            int i = 0;
            string listrec = "";
            try
            {
                if (!File.Exists(fpath))
                {
                    sw = File.CreateText(fpath);
                    sw.Close();
                }

                sw = new StreamWriter(fpath, append);
                sw.WriteLine(fstring);
                sw.Close();
            }

            catch (IOException ex)
            {
                Interaction.MsgBox("error writing to file: " + fpath + Constants.vbCrLf + ex.ToString());
            }
        }

        // Private Sub GetVideoInfo()
        // Dim query As New SelectQuery("Win32_DesktopMonitor")
        // Dim searcher As New ManagementObjectSearcher(query)''

        // For Each envVar As ManagementBaseObject In searcher.Get()
        // For Each obj As PropertyData In envVar.Properties
        // Console.WriteLine(obj.Name) 'get the name to pass in below
        // Next
        // pixelsPerInchX = envVar("PixelsPerXLogicalInch")
        // pixelsPerInchY = envVar("PixelsPerYLogicalInch")
        // Next
        // MsgBox("pixels/in X: " & pixelsPerInchX & " pixels/in Y: " & pixelsPerInchY)
        // End Sub

        private void PrinterDialogButn_Click(object sender, EventArgs e)
        {
            var dlgSettings = new PrintDialog();
            dlgSettings.UseEXDialog = true;
            dlgSettings.Document = PrintDocument1;
            // dlgSettings.ShowDialog()
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                inPrinterName.Text = dlgSettings.PrinterSettings.PrinterName;
            }
        }

        private void zebraPrinterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex != -1)
            { 
                zebraPrinterBox.Text = comboBox.Text;
            }
        }

        private void FontDialogButn_Click(object sender, EventArgs e)
        {
            var fntSettings = new FontDialog();
            // fntSettings.ShowDialog()
            if (fntSettings.ShowDialog() == DialogResult.OK)
            {
                inFontName.Text = fntSettings.Font.Name;
                inFontSize.Text = fntSettings.Font.Size.ToString();
                inFontWeight.Checked = fntSettings.Font.Bold;
            }

        }

        private void ftpPrint()
        {
            // Triggers print to FTP printer when labelout.txt is written to the installation
            // directory, alerting FileSystemWatcher2 to begin processing.
            Array tline = Strings.Split(OutputBox.Text, Constants.vbCrLf);
            int t = 0;
            string labelcmds = "";
            int LMar = Conversions.ToInteger(TextBox19.Text);
            int Top = Conversions.ToInteger(TextBox20.Text);
            int Inc = Conversions.ToInteger(TextBox21.Text);
            string Fontnum = TextBox22.Text;
            string Fontsize = TextBox23.Text;
            string textout = "";
            int maxLines = Conversions.ToInteger(inMaxLines.Text);
            int labelTop = 0;
            int lineCount = 0;
            int curline = 0;
            int lastLine = 0;
            if (string.IsNullOrEmpty(Strings.Trim(Conversions.ToString(tline.GetValue(tline.Length - 1)))))
            {
                lastLine = tline.Length - 2;
            }
            else
            {
                lastLine = tline.Length - 1;
            }
            do
            {
                labelTop = Top;
                var loopTo = lastLine;
                for (t = curline; t <= loopTo; t++)
                {
                    labelcmds = Conversions.ToString(Operators.ConcatenateObject(labelcmds + "T " + LMar.ToString() + "," + labelTop.ToString() + "," + "0," + Fontnum + "," + "pt" + Fontsize + ";", tline.GetValue(t)));
                    if (t < tline.Length - 1)
                        labelcmds = labelcmds + Constants.vbCrLf;
                    labelTop = labelTop + Inc;
                    lineCount = lineCount + 1;
                    if (lineCount == maxLines)
                    {
                        lineCount = 0;
                        break;
                    }
                }
                textout = textout + TextBox17.Text.Replace("#LABELTEXT#", labelcmds).Replace("#COUNT#", LabelRepeat.Value.ToString()) + Constants.vbCrLf;
                labelcmds = "";
                curline = t + 1;
            }
            while (curline <= lastLine);
            writeFile(mypath + "labelout.txt", textout, false);
            changeCount = 0;
            writeStat("F"); // Add "F" to statrec and write to statfile.
            OutputBox.Text = "";
            InputBox.Text = "";
            InputBox.Focus();
        }

        private void FileSystemWatcher2_Changed(object sender, FileSystemEventArgs e)
        {
            // 
            // Used with the FTP printer type only.  When the "labelout.txt" file is written
            // (this is the file that contains "JScript" label printing instructions for the industrial-style 
            // FTP-attached CAB printer), this filesystemwatcher's "changed" event is triggered.  This starts the 
            // ftpbat.bat batch file process which logs into the printer's FTP server and transfers
            // the contents of the labelout.txt file to the printer's "/execute" directory, causing the
            // printer to print the label.
            // 
            // The "changed" event fires multiple times for a single file change. To avoid
            // multiple executions of this code, a SyncLock ensures that only one event at a 
            // time can enter the "start" routine. The "changeCount" is set to zero in the 
            // calling routine, and incremented every time the SyncLock is entered. In SyncLock,
            // only if changeCount is zero will the batch process start.

            string ftpBatchFilePath = mypath + "ftpbat.bat";
            int maxLines = Conversions.ToInteger(inMaxLines.Text);
            var startInfo = new ProcessStartInfo(ftpBatchFilePath);
            Process p;
            // startInfo.WindowStyle = ProcessWindowStyle.Hidden 'makes sure entire process is invisible
            startInfo.Arguments = FTPip.Text; // the IP address is passed to ftpbat.bat as an argument
            var mlock = new object();
            lock (mlock)
            {
                if (changeCount == 0)
                {
                    changeCount = changeCount + 1;
                    p = Process.Start(startInfo); // tell Windows to start the batch file
                }
            }

        }
        private void viaDOS(string labeltext)
        {
            string dosPath = mypath + "viados.bat";
            var startInfo = new ProcessStartInfo(dosPath);
            Process p;
            string p1 = "";
            string p2 = "";
            string quot = "\"";

            if (hideDosWindow.Checked)
            {
                string batchtext = "";
                StreamReader sr;
                try
                {
                    sr = new StreamReader(mypath + "viados.bat");
                    batchtext = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("No viados.bat file was found.", MsgBoxStyle.Exclamation, "No viados.bat file");
                    return;
                }
                if (batchtext.ToUpper().Contains("PAUSE") | batchtext.ToUpper().Contains("PATHNAME"))
                {
                    Interaction.MsgBox("This batch file cannot in run in hidden mode because it contains 'pause' or 'PathName' commands " + "that will require a user response.", MsgBoxStyle.Exclamation, "Hidden Mode Error");
                    return;
                }
            }

            writeFile(mypath + "label.txt", labeltext, false);
            Thread.Sleep(300);
            if (Strings.Trim(dosParam1.Text).Contains("<"))
            {
                p1 = xmlValue(dosParam1.Text);
            }
            else
            {
                p1 = dosParam1.Text;
            }
            if (Strings.Trim(dosParam2.Text).Contains("<"))
            {
                p2 = xmlValue(dosParam2.Text);
            }
            else
            {
                p2 = dosParam2.Text;
            }
            startInfo.Arguments = quot + p1 + quot + " " + quot + p2 + quot;
            if (hideDosWindow.Checked)
            {
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            try
            {
                p = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("The DOS Batch File could not be started." + Constants.vbCrLf + "Error: " + ex.Message, MsgBoxStyle.Exclamation, "Batch File Error");
            }

        }
        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            string temptext = "";
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                temptext = e.Data.GetData(DataFormats.Text).ToString();
                if (temptext.Length > 20)
                {
                    InputBox.Text = "???";
                    Interaction.Beep();
                }
                else
                {
                    InputBox.Focus();
                    InputBox.Text = temptext;
                    Interaction.AppActivate("SpineOMatic " + somVersion.Replace("/", "."));
                    callAlma();
                }
            }
        }

        private void InputBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void InputBox_GotFocus(object sender, EventArgs e)
        {
            InputBox.BackColor = Color.FromArgb(220, 255, 220);
        }
        private void InputBox_LostFocus(object sender, EventArgs e)
        {
            InputBox.BackColor = Color.FromArgb(255, 220, 220);
        }
        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ControlChars.Cr)
            {
                e.Handled = true;
                if (InputBox.Text.ToLower() == "admin")
                {
                    InputBox.Text = "";
                    if (settingsOpen)
                        CloseSettings();
                    else
                        openSettings();
                    updatePath.Visible = false;
                    InputBox.Focus();
                }
                else if (InputBox.Text.ToLower() == "adminsecure")
                {
                    InputBox.Text = "";
                    openSettings();
                    InputBox.Focus();
                    updatePath.Visible = true;
                }
                else if (InputBox.Text.ToLower() == "adminl0gv1ew")
                {
                    InputBox.Text = "";
                    openSettings();
                    InputBox.Focus();
                    OutputBox.Text = "Log View Enabled";
                    getWebLog();
                    byAlpha.Checked = true;
                    chkGeoList.Visible = true;
                    chkAddHostname.Visible = true;
                }
                else if (InputBox.Text.ToLower() == "java")
                {

                    OutputBox.Text = GetJavaVersionInfo();
                }
                else if (string.IsNullOrEmpty(usrname.Text) & chkRequireUser.Checked)
                {
                    OutputBox.Font = new Font("MS Sans Serif", 9f, FontStyle.Regular);
                    OutputBox.Text = usermessage;
                    usrname.BackColor = Color.Yellow;
                    usrname.Focus();
                }
                else
                {
                    callAlma();
                }
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            OutputBox.Text = "";
            plOutput.Text = "";
            lblXMLWarn.Visible = false;
            HistoryList.Visible = false;
            ArrowLabel.Text = "q";
            parsedBy.Text = "";
            holdingsBy.Text = "";
            InputBox.Focus();
            InputBox.Text = "";
        }

        private void AutoPrintBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoPrintBox.Checked)
            {
                AutoPrintBox.Font = new Font(AutoPrintBox.Font, FontStyle.Bold);
                ReviewBox.Font = new Font(ReviewBox.Font, FontStyle.Regular);
            }
            InputBox.Focus();
        }

        private void ReviewBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReviewBox.Checked)
            {
                ReviewBox.Font = new Font(ReviewBox.Font, FontStyle.Bold);
                AutoPrintBox.Font = new Font(AutoPrintBox.Font, FontStyle.Regular);
            }
            else
            {
                ReviewBox.Font = new Font(ReviewBox.Font, FontStyle.Regular);
                AutoPrintBox.Font = new Font(AutoPrintBox.Font, FontStyle.Bold);
            }
            InputBox.Focus();

        }

        private void UseDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (UseDesktop.Checked)
            {
                refreshFTP();
                UseDesktop.Font = new Font(UseDesktop.Font, FontStyle.Bold);
                UseZPL.Font = new Font(UseZPL.Font, FontStyle.Regular);
                UseLaser.Font = new Font(UseLaser.Font, FontStyle.Regular);
                UseFTP.Font = new Font(UseFTP.Font, FontStyle.Regular);
                zebraSettingsPanel.Visible = false;
                zplPrintPanel.Visible = false;
                printPanel.Visible = true;
                SheetSettings.Visible = false;
                FTPGroup.Visible = false;
                orientationPanel.Visible = true;
                marginPanel.Visible = true;
                UseDesktop.Size = (Size)new Point(360, 168);
                DesktopGroup.Visible = true;
                useDOSBatch.Visible = true;
                panelMax.Visible = true;
                ManualPrint.Text = "Send to desktop printer";
                AutoPrintBox.Text = "Auto Print";
                ToolTip1.SetToolTip(AutoPrintBox, "Print label without reviewing it");
                InputBox.Focus();
            }
        }
        private void UseZPL_CheckedChanged(object sender, EventArgs e)
        {
            if (UseZPL.Checked)
            {
                refreshFTP();
                UseZPL.Font = new Font(UseZPL.Font, FontStyle.Bold);
                UseDesktop.Font = new Font(UseDesktop.Font, FontStyle.Regular);
                UseLaser.Font = new Font(UseLaser.Font, FontStyle.Regular);
                UseFTP.Font = new Font(UseFTP.Font, FontStyle.Regular);
                zebraSettingsPanel.Visible = true;
                zplPrintPanel.Visible = true;
                printPanel.Visible = false;
                SheetSettings.Visible = false;
                FTPGroup.Visible = false;
                orientationPanel.Visible = false;
                marginPanel.Visible = false;
                // UseDesktop.Size = (Size)new Point(360, 168);
                DesktopGroup.Visible = false;
                useDOSBatch.Visible = false;
                panelMax.Visible = true;
                ManualPrint.Text = "Send to Zebra printer";
                AutoPrintBox.Text = "Auto Add";
                ToolTip1.SetToolTip(AutoPrintBox, "Print label without reviewing it");
                InputBox.Focus();
            }
        }
        private void UseLaser_CheckedChanged(object sender, EventArgs e)
        {
            if (UseLaser.Checked)
            {
                refreshFTP();
                UseLaser.Font = new Font(UseLaser.Font, FontStyle.Bold);
                UseDesktop.Font = new Font(UseDesktop.Font, FontStyle.Regular);
                UseFTP.Font = new Font(UseFTP.Font, FontStyle.Regular);
                UseZPL.Font = new Font(UseZPL.Font, FontStyle.Regular);
                zebraSettingsPanel.Visible = false;
                zplPrintPanel.Visible = false;
                printPanel.Visible = true;
                FTPGroup.Visible = false;
                DesktopGroup.Visible = true;
                useDOSBatch.Visible = true;
                panelMax.Visible = true;
                SheetSettings.Visible = true;
                orientationPanel.Visible = true;
                marginPanel.Visible = true;
                AutoPrintBox.Text = "Auto Add";
                ToolTip1.SetToolTip(AutoPrintBox, "Add label to batch without reviewing it.");
                ManualPrint.Text = "Add to batch #" + batchNumber.Value.ToString();
                InputBox.Focus();
            }
        }
        private void UseFTP_CheckedChanged(object sender, EventArgs e)
        {
            if (UseFTP.Checked)
            {

                UseFTP.Font = new Font(UseFTP.Font, FontStyle.Bold);
                UseLaser.Font = new Font(UseLaser.Font, FontStyle.Regular);
                UseDesktop.Font = new Font(UseDesktop.Font, FontStyle.Regular);
                UseZPL.Font = new Font(UseZPL.Font, FontStyle.Regular);
                zebraSettingsPanel.Visible = false;
                zplPrintPanel.Visible = false;
                printPanel.Visible = true;
                DesktopGroup.Visible = false;
                useDOSBatch.Visible = true;
                panelMax.Visible = true;
                FTPGroup.Location = new Point(8, 28);
                FTPGroup.Size = (Size)new Point(400, 295); // 400 x 280
                FTPGroup.Visible = true;
                orientationPanel.Visible = false;
                marginPanel.Visible = false;
                AutoPrintBox.Text = "Auto Print";
                ToolTip1.SetToolTip(AutoPrintBox, "Print label without reviewing it.");
                refreshFTP();
                InputBox.Focus();
            }
        }
        private void refreshFTP()
        {
            if (chkUsePocketLabels.Checked & UseFTP.Checked)
            {
                FTPwarning.Visible = true;
                FTPwarning2.Visible = true;
                ManualPrint.Text = "--- Not Supported ---";
                ManualPrint.Enabled = false;
            }
            else
            {
                FTPwarning.Visible = false;
                FTPwarning2.Visible = false;
                ManualPrint.Enabled = true;
                ToolTip1.SetToolTip(ManualPrint, "Send label text to selected printer.");
                if (UseFTP.Checked)
                    ManualPrint.Text = "Send to FTP Printer";
                if (UseLaser.Checked)
                    ManualPrint.Text = "Add to batch #" + batchNumber.Value.ToString();
                if (UseDesktop.Checked)
                    ManualPrint.Text = "Send to desktop printer";
                if (useDOSBatch.Checked)
                {
                    ManualPrint.Text = "Run 'viados' batch file";
                    ToolTip1.SetToolTip(ManualPrint, "Writes label text to 'label.txt' file, then starts 'viados.bat' batch file.");
                }

            }
            if (Spine.Checked)
            {
                if (radio_useSOMparsing.Checked)
                {
                    spineType.Text = "Spine (SpineOMatic parsing)";
                }
                else
                {
                    spineType.Text = "Spine (Ex Libris parsing)";
                }
            }
            else if (CustomLabel.Checked)
            {
                spineType.Text = "Custom";
                if (FlagSlips.Checked)
                {
                    spineType.Text = "Custom/Flag Slips";
                }
            }
        }

        private void openSettings()
        {
            // expand user interface box to make administrative panels visible
            Size = new Size(770, 453);
            settingsOpen = true;
            lblToggleAdmin.Text = "t";
            InputBox.Focus();
        }

        private void saveSettings(string savetype)
        {
            TextBox24.ForeColor = Color.Red;
            TextBox24.Text = "SAVING SETTINGS...";
            Application.DoEvents();
            List<Control> conlist;
            string val = "";
            RadioButton r;
            CheckBox c;
            NumericUpDown n;
            ComboBox cb;
            string vline = "<spinelabel_settings>" + Constants.vbCrLf;

            if (pocketDefaultLoaded == true)
            {
                SaveDefaults(pocketDefaults);
            }
            else if (spineDefaultLoaded == true)
            {
                SaveDefaults(spineDefaults);
            }
            else if (customFlagDefaultLoaded == true)
            {
                SaveDefaults(flagDefaults);
                // wrapWidth.Text = flagWrapWidth.Text
                flagWrapWidth.Text = wrapWidth.Text;
            }
            else
            {
                SaveDefaults(nonFlagDefaults);
                // wrapWidth.Text = nonFlagWrapWidth.Text
                nonFlagWrapWidth.Text = wrapWidth.Text;
            }

            conlist = GetAllControls(this);    // function GetAllControls recursively loops through all 
                                               // controls on the form and returns a complete list.    

            foreach (var ctl in conlist)
            {

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ctl.Tag, null, false)))  // for all controls that have a "tag" entry...
                {
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "radio") // for radio button type controls
                    {
                        r = (RadioButton)ctl; // save the radio button as either selected or not
                        if (r.Checked)
                            val = "true";
                        else
                            val = "false";
                    }
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "check") // for checkbox type controls
                    {
                        c = (CheckBox)ctl; // save the checkbox as either checked or not
                        if (c.Checked)
                            val = "true";
                        else
                            val = "false";
                    }
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "text")  // for all text type controls
                    {
                        val = ctl.Text; // save the text of .text attribute
                        val = val.Replace(Constants.vbCrLf, "~cr~"); // but change cr/lf to a code that can be 
                    } // turned back into a cr/lf later

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "texo")  // for all obscured text type controls
                    {
                        val = ctl.Text; // save the text of .text attribute
                        val = obscure(val);
                        val = val.Replace(Constants.vbCrLf, "~cr~"); // but change cr/lf to a code that can be 
                    } // turned back into a cr/lf later

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "numud") // for the numeric up/down control
                    {
                        n = (NumericUpDown)ctl; // save the numeric value 
                        val = n.Value.ToString();
                    }

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "cbox")  // for all combo box type controls
                    {
                        val = ctl.Text; // save the text of .text attribute
                        val = val.Replace(Constants.vbCrLf, "~cr~"); // but change cr/lf to a code that can be 
                    } // turned back into a cr/lf later

                    // Then put the saved value between <controlname>...</controlname> elements
                    vline = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(vline + "<", ctl.Tag), ">"), val), "</"), ctl.Tag), ">"), Constants.vbCrLf));
                }
            }

            vline = vline + "</spinelabel_settings>";
            if (savetype == "todisk")
            {
                RichTextBox1.Clear();
                RichTextBox1.Text = vline;
                formatXML();
                writeFile(mypath + "settings.som", vline, false);
                original_settings = vline.Replace(Constants.vbCrLf, "");
            }
            else
            {
                closing_settings = vline.Replace(Constants.vbCrLf, "");
            }
            TextBox24.Text = "";
        }

        private void SaveSettingsButn_Click(object sender, EventArgs e)
        {
            saveSettings("todisk");
        }
        private void LoadSettingsButn_Click(object sender, EventArgs e)
        {
            GetSettingsFile();
        }
        private void GetSettingsFile()
        {
            TextBox24.ForeColor = Color.Red;
            TextBox24.Text = "LOADING SETTINGS...";
            Application.DoEvents();
            string settingsFile = mypath + "settings.som";
            settingsfound = true;
            try
            {
                TextReader tr = new StreamReader(settingsFile);
                RichTextBox1.Clear();
                RichTextBox1.ForeColor = Color.Red;
                RichTextBox1.Text = tr.ReadToEnd();
                tr.Close();
            }
            catch
            {
                openSettings();
                Interaction.MsgBox("Welcome to SpineOMatic.  To get started:" + Constants.vbCrLf + Constants.vbCrLf + "* In the Print Setup panel, select a printer, and a text font." + Constants.vbCrLf + "* In the Alma Access panel, enter your Ex Libris credentials." + Constants.vbCrLf + "* Obtain an API key from the Ex Libris Developer Network," + Constants.vbCrLf + "and fill out the 'RESTful API' section in the Alma Access panel." + Constants.vbCrLf + Constants.vbCrLf + "There are lots of other options and settings available--" + Constants.vbCrLf + "click the 'About' link to get the complete manual." + Constants.vbCrLf + "The Quick Start section will help get you up and running.", MsgBoxStyle.Exclamation, "Getting Started");

                settingsfound = false;
                if (UseDesktop.Checked)
                {
                    UseDesktop.Checked = false;
                    UseDesktop.Checked = true;
                }
                if (UseLaser.Checked)
                {
                    UseLaser.Checked = false;
                    UseLaser.Checked = true;
                }
                if (UseFTP.Checked)
                {
                    UseFTP.Checked = false;
                    UseFTP.Checked = true;
                }

                FlagSlips.Enabled = false;
                CustomLabel.Checked = true;
                LoadDefaults(nonFlagDefaults);
                Spine.Checked = true;

                CustomText.Enabled = false;


            }
            if (settingsfound)
            {
                InstallSettings();
                formatXML();
                // each time settings are read from disk, they are saved for later comparison to
                // the settings that are in the form when the program closes. This can alert the user
                // that the current settings have not been saved.
                original_settings = RichTextBox1.Text;
            }
            TextBox24.Text = "";
            TextBox24.ForeColor = Color.Blue;
        }

        private void InstallSettings()
        {
            List<Control> conlist;
            string val = "";
            TextBox t;
            RadioButton r;
            CheckBox c;
            NumericUpDown n;
            ComboBox cb;
            conlist = GetAllControls(this); // GetAllControls recursively steps through all controls on 
            foreach (var ctl in conlist) // the form, and returns a list.
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ctl.Tag, null, false))) // if the control has a .tag attribute
                {
                    val = getval(Conversions.ToString(ctl.Tag)); // get the .tag text
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "radio") // if the tag starts with "radio"
                    {
                        r = (RadioButton)ctl; // then this is a radio button
                        if (!string.IsNullOrEmpty(val)) // if a value is present, set the .checked attribute as true or false
                        {
                            if (val == "true")
                                r.Checked = true;
                            else
                                r.Checked = false;
                        }
                    }
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "check") // if this is a checkbox
                    {
                        c = (CheckBox)ctl;
                        if (!string.IsNullOrEmpty(val)) // and a value is present, set the checkbox to checked or unchecked
                        {
                            if (val == "true")
                                c.Checked = true;
                            else
                                c.Checked = false;
                        }
                    }
                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "text") // if this is a text value
                    {
                        t = (TextBox)ctl; // set the textbox.text to the saved text
                        if (!string.IsNullOrEmpty(val))
                        {
                            t.Text = val.Replace("~cr~", Constants.vbCrLf); // and turn codes back into real cr/lfs
                        }
                    }

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "texo") // if this is an obscured text value
                    {
                        t = (TextBox)ctl; // set the textbox.text to the saved text
                        if (!string.IsNullOrEmpty(val))
                        {
                            val = obscure(val);
                            t.Text = val.Replace("~cr~", Constants.vbCrLf); // and turn codes back into real cr/lfs
                        }
                    }

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 5) == "numud") // if this is a numeric up/down control
                    {
                        n = (NumericUpDown)ctl;
                        if (!string.IsNullOrEmpty(val)) // set the control's value to the number that was saved.
                        {
                            n.Value = Conversions.ToInteger(val);
                        }
                    }

                    if (Strings.Mid(Conversions.ToString(ctl.Tag), 1, 4) == "cbox") // if this is a text value for combo box
                    {
                        cb = (ComboBox)ctl; // set the ComboBox.text to the saved text
                        if (!string.IsNullOrEmpty(val))
                        {
                            cb.Text = val.Replace("~cr~", Constants.vbCrLf); // and turn codes back into real cr/lfs
                        }
                    }
                }
            }
            // ProgressBar1.Visible = False
            // the following toggles make sure that the text on the manual print button matches
            // the actual setting of the printer radio button, or the viados selection.
            if (UseDesktop.Checked)
            {
                UseDesktop.Checked = false;
                UseDesktop.Checked = true;
            }
            if (UseLaser.Checked)
            {
                UseLaser.Checked = false;
                UseLaser.Checked = true;
            }
            if (UseFTP.Checked)
            {
                UseFTP.Checked = false;
                UseFTP.Checked = true;
            }
            if (useDOSBatch.Checked)
            {
                useDOSBatch.Checked = false;
                useDOSBatch.Checked = true;
            }

            if (dosPlUseCol.Checked)
            {
                dosPlUseCol.Checked = false;
                dosPlUseCol.Checked = true;
            }
            else
            {
                dosPlUseTab.Checked = false;
                dosPlUseTab.Checked = true;
            }

            if (CustomLabel.Checked)
            {
                FlagSlips.Enabled = true;
            }
            else
            {
                FlagSlips.Enabled = false;
            }
            if (useExlibrisParsing.Checked)
            {
                parsingSource.Enabled = true;
                inCallNumSource.Enabled = false;
            }
            else
            {
                parsingSource.Enabled = false;
                inCallNumSource.Enabled = true;
            }
            if (chkIncludeOther.Checked)
            {
                inOtherSource.Enabled = true;
            }
            else
            {
                inOtherSource.Enabled = false;
            }
            if (radio_useLocal.Checked)
            {
                ALTfile = "myLabelText.txt";
            }
            else
            {
                ALTfile = "aboveLabel.txt";
            }

            if (UseRestfulApi.Checked)
            {
                accessType.Text = "R";
                accessType.ForeColor = Color.Green;
                ToolTip1.SetToolTip(accessType, "Using preferred RESTful API access to Alma.");
            }
            else
            {
                accessType.Text = "J";
                accessType.ForeColor = Color.Red;
                ToolTip1.SetToolTip(accessType, "Caution--Using deprecated Java access to Alma.");
            }

            if (chkUsePocketLabels.Checked) // pocket must be checked first, because spine or custom can also be checked,
            {
                // but pocked labels predominate.
                LoadDefaults(pocketDefaults);
                // chk_VerticalLine.Checked = pocketVerticalLine
                pocketDefaultLoaded = true;
                spineDefaultLoaded = false;
                customFlagDefaultLoaded = false;
                customNonFlagDefaultLoaded = false;
                PocketLabelPanel.Location = new Point(0, 30);
                PocketLabelPanel.Width = TabPage2.Size.Width;
                PocketLabelPanel.Height = TabPage2.Size.Height - 30;
                PocketLabelPanel.Visible = true;
            }
            else if (Spine.Checked)
            {
                LoadDefaults(spineDefaults);
                pocketDefaultLoaded = false;
                spineDefaultLoaded = true;
                customFlagDefaultLoaded = false;
                customNonFlagDefaultLoaded = false;
            }
            else if (CustomLabel.Checked)
            {
                if (FlagSlips.Checked)
                {
                    LoadDefaults(flagDefaults);
                    wrapWidth.Text = flagWrapWidth.Text;
                    pocketDefaultLoaded = false;
                    spineDefaultLoaded = false;
                    customFlagDefaultLoaded = true;
                    customNonFlagDefaultLoaded = false;
                }
                else
                {
                    LoadDefaults(nonFlagDefaults);
                    wrapWidth.Text = nonFlagWrapWidth.Text;
                    pocketDefaultLoaded = false;
                    spineDefaultLoaded = false;
                    customFlagDefaultLoaded = false;
                    customNonFlagDefaultLoaded = true;
                }
            }

            if (!btnPlCustom.Checked)
            {
                userDefinedPanel.Enabled = false;
            }
            if (deweyDecimalBreakAft.Checked)
            {
                deweyGroup3.Enabled = true;
                deweydigitsperline.Enabled = true;
                Label25.Enabled = true;
            }

            TabControl1.SelectedTab = TabPage2;
            TabControl1.SelectedTab = TabPage1;


        }

        public List<Control> GetAllControls(Control parent)
        {
            // recursive routine to step through all contols on the form.  Necessary because
            // controls can contain controls which can contain controls, etc.
            var list = new List<Control>();
            foreach (Control ctl in parent.Controls)
            {
                list.Add(ctl);
                if (ctl.Controls.Count > 0)
                {
                    list.AddRange(GetAllControls(ctl));
                }
            }
            return list; // returns a list of all controls on the form, no matter where they appear.
        }

        private string getval(string tagname)
        {
            // returns the value found between <tagname>...</tagname> in the Current XML richtextbox.
            string val = "";
            int tagstart = 0;
            string opentag = "";
            string closetag = "";
            int datastart = 0;
            int tagend = 0;
            opentag = "<" + tagname + ">";
            closetag = "</" + tagname + ">";

            {
                var withBlock = RichTextBox1;
                tagstart = withBlock.Find(opentag);
                if (tagstart == -1)
                {
                    val = "";
                    return val;
                }
                datastart = tagstart + opentag.Length;
                tagend = withBlock.Find(closetag, tagstart + 1, RichTextBoxFinds.MatchCase);
                if (datastart == tagend)
                {
                    val = "";
                }
                else
                {
                    val = Strings.Mid(withBlock.Text, datastart + 1, tagend - datastart);
                }

            }
            return val;
        }

        private void ArrowLabel_Click(object sender, EventArgs e)
        {
            if (HistoryList.Visible == false)
            {
                HistoryList.Visible = true;
                ArrowLabel.Text = "p";
            }
            else
            {
                HistoryList.Visible = false;
                ArrowLabel.Text = "q";
            }
        }

        private void HistoryList_DoubleClick(object sender, EventArgs e)
        {
            InputBox.Text = Conversions.ToString(HistoryList.Items[HistoryList.SelectedIndex]);
            HistoryList.Visible = false;
            ArrowLabel.Text = "q";
            OutputBox.Text = "";
            InputBox.Focus();
        }

        private void TempLabelBox_MouseDown(object sender, MouseEventArgs e)
        {
            TempLabelBox.DoDragDrop(TempLabelBox.Text, DragDropEffects.Copy);
        }

        private void CreateTempLbl_Click(object sender, EventArgs e)
        {
            string tempnum = "";
            tempnum = "TX" + DateTime.Now.ToString("yyMMddHHmmssfff", CultureInfo.InvariantCulture);
            TempLabelBox.Text = tempnum;
        }

        private void createTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (createTemp.Checked)
            {
                CreateTempLbl.Visible = true;
                TempLabelBox.Visible = true;
            }
            else
            {
                CreateTempLbl.Visible = false;
                TempLabelBox.Visible = false;
            }
        }

        private void CheckForUpdates_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();

            string result = "The new SpineOMatic file was downloaded successfully.";
            int msgStyle = (int)MsgBoxStyle.Information;
            bool getExe = false;
            bool OKtoRename = false;
            // Dim webRequest As String = ""
            // Dim versionList As String = ""
            // Dim verlist As Array
            // Dim vstart As Integer = 0, vlen As Integer = 0
            // Dim pv As String = "" 'preferred version
            // Dim exename As String = ""
            // Dim i As Integer = 0

            string sLatestVersion;
            string sDownloadURL;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;
            string json;
            var jss = new JavaScriptSerializer();

            try
            {
                request = (HttpWebRequest)WebRequest.Create("https://api.github.com/repos/ExLibrisGroup/SpineOMatic/releases/latest");
                request.UserAgent = "SpineOMatic";
                request.Method = "GET";
                response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
                json = reader.ReadToEnd();
                var dict = jss.Deserialize<Dictionary<string, object>>(json);
                sLatestVersion = Conversions.ToString(dict["tag_name"]);
                // TODO CheckForUpdates p1
                // Dictionary<string, object> dict2 = (Dictionary<string, object>) dict["assets"](0);  // First asset is the binary; Second asset is the documentation.
                // sDownloadURL = Conversions.ToString(dict2["browser_download_url"]);
            }
            catch (Exception ex)
            {
                msgStyle = (int)MsgBoxStyle.Exclamation;
                result = "ERROR--Unable to check for new version of SpineOMatic." + Constants.vbCrLf + Constants.vbCrLf + ex.ToString();
                Interaction.MsgBox(result, (MsgBoxStyle)msgStyle, "SpineOMatic Download");
                return;
            }

            if (!string.IsNullOrEmpty(sLatestVersion) & (sLatestVersion ?? "") != ("v" + somVersion ?? ""))   // if the latest version is not what is running
            {
                object box = MessageBox.Show("There is a newer version of SpineOMatic." + Constants.vbCrLf + "Do you want to download it now?", "Download Decision", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(box, ((dynamic)box).No, false)))
                {
                    result = "A new version of SpineOMatic will not be downloaded at this time.";
                    getExe = false;
                }
                else
                {
                    getExe = true;
                }
            }
            else
            {
                Interaction.MsgBox("Your version of SpineOMatic is current.");
                return;
            }

            if (getExe)
            {
                try
                {
                    // TODO CheckForUpdates p2
                    //webClient.DownloadFile(sDownloadURL, mypath + "somtemp.exe");
                    OKtoRename = true;
                }
                catch (Exception ex)
                {
                    msgStyle = (int)MsgBoxStyle.Exclamation;
                    result = "ERROR--Unable to download the new version of SpineOMatic." + Constants.vbCrLf + Constants.vbCrLf + ex.ToString();
                }
            }
            if (OKtoRename)
            {
                My.MyProject.Computer.FileSystem.RenameFile(mypath + "SpineLabeler.exe", "SpineLabeler-" + somVersion.Replace(".", "_") + ".exe");
                My.MyProject.Computer.FileSystem.RenameFile(mypath + "somtemp.exe", "SpineLabeler.exe");
                result = "SpineOMatic version " + sLatestVersion + " has been downloded." + Constants.vbCrLf + "You must close and restart SpineOMatic to begin using the new version.";
            }

            Interaction.MsgBox(result, (MsgBoxStyle)msgStyle, "SpineOMatic Download");
        }

        private void batchNumber_ValueChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            int ln = 0;
            ManualPrint.Text = "Add to batch #" + batchNumber.Value.ToString();

            batchPreview.Text = GetBatch((int)Math.Round(batchNumber.Value));
            if (batchPreview.Lines.Length > 0)
            {
                batchEntries.Text = countBatch();
            }
            else
            {
                batchEntries.Text = "0";
            }

            InputBox.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            object box2 = MessageBox.Show("Click OK to empty batch file #" + batchNumber.Value + ", or " + Constants.vbCrLf + "click CANCEL to keep the file.", "Confirm File Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(box2, ((dynamic)box2).OK, false)))
            {
                writeFile(mypath + "labelbatch" + batchNumber.Value + ".txt", "", false);
                batchPreview.Text = GetBatch((int)Math.Round(batchNumber.Value));
                batchPreview.Text = "";
                if (batchPreview.Lines.Length > 0)
                {
                    batchEntries.Text = countBatch();
                }
                else
                {
                    batchEntries.Text = "0";
                }
            }
            else
            {
                Interaction.MsgBox("Label batch file #" + batchNumber.Value + " has not been cleared.");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ignoreChange == false)
            {
                loadLabelText();
            }
        }

        private void createBatFiles()
        {
            // create a DOS batch file to ftp print commands to an FTP-style label printer
            // The file is re-created if it already exists, to ensure that the default path
            // is part of the command.

            // Also creates the "sendlabel.txt" file that logs in to the ftp printer and
            // "puts" the labelout.txt file into the printer.

            string batContents = "";
            batContents = "@echo OFF" + Constants.vbCrLf + "ftp -s:" + mypath + "sendlabel.txt %1";
            writeFile(mypath + "ftpbat.bat", batContents, false);

            batContents = FTPLogin.Text + Constants.vbCrLf + FTPPassword.Text + Constants.vbCrLf + "put " + mypath + "labelout.txt /execute/labelout.txt" + Constants.vbCrLf + "quit";
            writeFile(mypath + "sendlabel.txt", batContents, false);

            if (!File.Exists(mypath + "viados.bat"))
            {
                batContents = "REM Sample batch file displays label text" + Constants.vbCrLf + "REM in Windows Notepad" + Constants.vbCrLf + "start notepad.exe label.txt" + Constants.vbCrLf;
                writeFile(mypath + "viados.bat", batContents, false);
            }

            // 
            // Create getalma.bat to run the java desktop app "almalabelu2.class"
            // Includes parameters: %1 = Alma url; %2 = Alma user name; %3 = Alma password;
            // %4 = institution code; %5 = barcode number; %6 = output directory for returned XML file
            // 
            // batContents = "@echo OFF" & vbCrLf & _
            // "java -cp .;" & javaSDKName & " " & javaClassName & " %1 %2 %3 %4 %5 %6"
            // writeFile(mypath & "getalma.bat", batContents, False)

            // batContents = "java -cp .;" & javaSDKName & " " & javaClassName & " %1 %2 %3 %4 %5 %6" & vbCrLf & _
            // "pause"
            // writeFile(mypath & "getalmadiag.bat", batContents, False)

        }
        private void webDownload(string fname, string ftype, string webPath, string fdest)
        {
            string webrequest = "";
            var webClient = new WebClient();
            string txt;
            bool success = true;
            int knt = 0;
            webrequest = webPath + fname;
            try
            {
                if (ftype == "string")
                {
                    txt = webClient.DownloadString(webrequest);
                    txt = txt.Replace(Constants.vbCrLf, Constants.vbLf).Replace(Constants.vbLf, Constants.vbCrLf);
                    writeFile(fdest + fname, txt, false);
                }
                else
                {
                    webClient.DownloadFile(webrequest, fdest + fname);
                }
            }
            catch (Exception ex)
            {
                success = false;
                if (ex.Message.Contains("407"))
                {
                    Interaction.MsgBox("Your proxy server is not allowing you to connect to the GitHub server:" + Constants.vbCrLf + Constants.vbCrLf + webPath + Constants.vbCrLf + Constants.vbCrLf + "Ask your IT Networking office to allow access to ('whitelist') this server.", MsgBoxStyle.Exclamation, "Proxy Server Block");
                }
                Interaction.MsgBox(fname + "- Download error: " + ex.Message);
                return;
            }

        }

        private void downloadAboveLcFile()
        {

            string webRequest = "";
            var webClient = new WebClient();
            string labelText = "";
            object msgStyle = MsgBoxStyle.Exclamation;
            string result = "";

            if (radio_useLocal.Checked)
                return;
            if (string.IsNullOrEmpty(altURL.Text))
            {
                altURL.BackColor = Color.White;
                return;
            }
            if (Strings.Mid(altURL.Text, altURL.Text.Length, 1) != "/")
            {
                altURL.Text = altURL.Text + "/";
            }
            webRequest = altURL.Text + "aboveLabel.txt";

            try
            {
                labelText = webClient.DownloadString(webRequest);
                labelText = labelText.Replace(Constants.vbCrLf, Constants.vbLf).Replace(Constants.vbLf, Constants.vbCrLf);
            }

            catch (Exception ex)
            {
                altURL.BackColor = Color.Pink;
                msgStyle = MsgBoxStyle.Exclamation;
                Interaction.MsgBox("ERROR -- The 'aboveLabel.txt' file could not be downloaded from " + webRequest + Constants.vbCrLf + "Reason: " + ex.Message, (MsgBoxStyle)Conversions.ToInteger(msgStyle), "AboveLabelText File Download");
                return;
            }
            altURL.BackColor = Color.White;
            writeFile(mypath + "aboveLabel.txt", labelText, false);

        }

        private void SaveAboveLC_Click(object sender, EventArgs e)
        {
            downloadAboveLcFile();
            loadLabelText();
        }

        private void CloseSettings() // _Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseSettings.Click
        {
            // reduce the size of the user interface box to hide the administrative panels
            Size = new Size(233, 453);
            settingsOpen = false;
            lblToggleAdmin.Text = "u";
            InputBox.Focus();
        }

        private void btnBCFontDialog_Click(object sender, EventArgs e)
        {
            var fntSettings = new FontDialog();
            // fntSettings.ShowDialog()
            if (fntSettings.ShowDialog() == DialogResult.OK)
            {
                inBCFontName.Text = fntSettings.Font.Name;
                inBCFontSize.Text = fntSettings.Font.Size.ToString();
                inBCFontWeight.Checked = fntSettings.Font.Bold;
            }
        }

        private void Label47_Click(object sender, EventArgs e)
        {
            var picBox = new PictureBox();
            string btnmsg;
            picBox = PictureBox1;
            var img = new Bitmap(picBox.Width, picBox.Height);
            var brush = new LinearGradientBrush(new PointF(0f, 0f), new PointF(img.Width, img.Height), Color.Beige, Color.Tan);
            // Dim gr As Graphics = Graphics.FromImage(img)
            var gr = Graphics.FromImage(PictureBox1.BackgroundImage);
            // gr.FillRectangle(brush, New RectangleF(0, 0, img.Width, img.Height))
            // picBox.BackgroundImage = img
            object bcWeight = new FontStyle();
            bcWeight = FontStyle.Bold;
            var bFont = new Font("times new roman", 14.0f, FontStyle.Bold);
            var sFont = new Font("verdana", 10.0f, FontStyle.Bold);
            var tfont = new Font("verdana", 8.0f, FontStyle.Regular);
            var ufont = new Font("verdana", 12.0f, FontStyle.Bold);
            gr.DrawString("SpineOMatic", bFont, Brushes.Black, 5f, 10f);
            gr.DrawString("v" + somVersion + "", sFont, Brushes.Black, 120f, 20f);
            gr.DrawString("Works with Ex Libris' Alma to print spine labels,", tfont, Brushes.Black, 210f, 20f);
            gr.DrawString("flag slips, or other custom labels to a variety", tfont, Brushes.Black, 210f, 32f);
            gr.DrawString("of desktop or networked printers.", tfont, Brushes.Black, 210f, 44f);

            // gr.DrawString("Questions?", sFont, Brushes.Black, 5, 72)
            // gr.DrawString("Send them to: spineomatic-ggroup@bc.edu", tfont, Brushes.Black, 10, 90)

            gr.DrawString("X", ufont, Brushes.Red, img.Width - 20, 0f);
            PictureBox1.Visible = true;
            Application.DoEvents();
            btnmsg = "View the SpineOMatic " + somVersion + " Wiki";
            btnDocDownload.Text = btnmsg;
            btnDocDownload.Visible = true;
            btnDocDownload.BringToFront();
            saveTab = TabControl1.SelectedTab;
            TabControl1.SelectedTab = TabPage4;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox1.Visible = false;
            btnDocDownload.Visible = false;
            TabControl1.SelectedTab = saveTab;
        }

        private void btnDocDownload_Click(object sender, EventArgs e)
        {
            var webclient = new WebClient();
            try
            {
                Process.Start("www.github.com/ExLibrisGroup/SpineOMatic/wiki");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Unable to open Spine-O-Matic Wiki" + Constants.vbCrLf + "Error: " + ex.Message, MsgBoxStyle.Exclamation, "Connection Error");
            }
        }


        private void FTPInfo_Click(object sender, EventArgs e)
        {
            if (FTPInfo.Text == "Info")
            {
                FTPHelp.Visible = true;
                FTPInfo.Text = "   X";
                FTPInfo.ForeColor = Color.Red;
            }
            else
            {
                FTPHelp.Visible = false;
                FTPInfo.Text = "Info";
                FTPInfo.ForeColor = Color.Blue;
            }
        }

        private void useExlibrisParsing_CheckedChanged(object sender, EventArgs e)
        {
            if (useExlibrisParsing.Checked)
            {
                parsingSource.Enabled = true;
                inCallNumSource.Enabled = false;
            }
            else
            {
                parsingSource.Enabled = false;
                inCallNumSource.Enabled = true;
            }
        }

        private void chkIncludeHoldings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncludeHoldings.Checked)
            {
                inIssueLevelSource.Enabled = true;
            }
            else
            {
                inIssueLevelSource.Enabled = false;
            }
        }
        private void chkIncludeOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncludeOther.Checked)
            {
                inOtherSource.Enabled = true;
            }
            else
            {
                inOtherSource.Enabled = false;
            }
        }

        private void XMLPath_TextChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Strings.Trim(Conversions.ToString(string.IsNullOrEmpty(XMLPath.Text)))))
            {
                btnMonitor.Enabled = false;
            }
            else
            {
                btnMonitor.Enabled = true;
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Strings.Trim(XMLPath.Text)))
                return;
            if (Directory.Exists(XMLPath.Text))
            {
                FileSystemWatcher1.Path = XMLPath.Text;
                Interaction.MsgBox("The directory" + Constants.vbCrLf + XMLPath.Text + Constants.vbCrLf + "will be monitored for the arrival of new barcode XML files.", MsgBoxStyle.Information, "Directory Monitor");
                btnMonitor.Enabled = false;
            }
            else
            {
                Interaction.MsgBox("The directory " + Constants.vbCrLf + XMLPath.Text + Constants.vbCrLf + "does not exist." + Constants.vbCrLf + "Enter the name of an existing directory.", MsgBoxStyle.Exclamation, "Directory Monitor");
                XMLPath.Focus();
            }
        }

        private void usrname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ControlChars.Cr)
            {
                e.Handled = true;
                if (string.IsNullOrEmpty(usrname.Text))
                {
                    Interaction.Beep();
                    usrname.BackColor = Color.Pink;
                    return;
                }
                usrname.BackColor = Color.White;
                OutputBox.Text = "";
                usrname.Text = usrname.Text.ToUpper();
                InputBox.Focus();
            }
            if (usrname.Text.Length > 7) // if usrname 8 chars or more,
            {
                if (Strings.Asc(e.KeyChar) != 8) // allow backspace, even if username = 8 chars
                {
                    e.Handled = true; // if not backspace, ignore the character,
                    Interaction.Beep();           // and beep
                }
            }

        }

        private string obscure(string txtin)
        {
            string res = "";
            int i, j;
            string key = "\n" + '\v' + '\f' + '\r' + '\u000e' + '\u000f' + '\u0010' + '\u0011';
            var loopTo = txtin.Length;
            for (i = 1; i <= loopTo; i++)
            {
                j = (key.Length - 1) % i;
                res = res + Strings.Chr(Strings.Asc(Strings.Mid(key, j + 1, 1)) ^ Strings.Asc(Strings.Mid(txtin, i, 1)));
            }
            return res;
        }

        private void btn_addALT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(altText.Text))
            {
                if (altText.Text.Contains("+") & altText.Text.Contains("="))
                {
                    altText.Text = altText.Text.Replace(" +", "+").Replace("+ ", "+").Replace(" =", "=").Replace("= ", "=");
                    altList.Items.Add(altText.Text);
                    altText.Text = "";
                    madeALTchanges = true;
                    btn_saveALT.ForeColor = Color.Red;
                }
                else
                {
                    Interaction.Beep();
                    Interaction.MsgBox("Each entry must contain a plus sign (+) and an equal sign (=) following " + Constants.vbCrLf + "the Library name and the Location name, respectively.", MsgBoxStyle.Exclamation, "Missing + or = Signs");
                    altText.Focus();
                }
            }
        }

        private void btn_cancelALT_Click(object sender, EventArgs e)
        {
            altText.Text = "";
            altList.Enabled = true;
            btn_changeALT.Enabled = false;
            btn_deleteALT.Enabled = false;
            // btn_cancelALT.Enabled = False
        }

        private void btn_deleteALT_Click(object sender, EventArgs e)
        {
            altList.Items.RemoveAt(altList.SelectedIndex);
            altText.Text = "";
            altList.Enabled = true;
            madeALTchanges = true;
            btn_changeALT.Enabled = false;
            btn_deleteALT.Enabled = false;
            // btn_cancelALT.Enabled = False
            btn_saveALT.ForeColor = Color.Red;
        }

        private void btn_changeALT_Click(object sender, EventArgs e)
        {
            int saveidx = altList.SelectedIndex;
            if (!string.IsNullOrEmpty(altText.Text))
            {
                if (altText.Text.Contains("+") & altText.Text.Contains("="))
                {
                    altList.Enabled = true;
                    altList.Items.RemoveAt(saveidx);
                    altList.Items.Insert(saveidx, altText.Text);
                    altText.Text = "";
                    madeALTchanges = true;
                    btn_changeALT.Enabled = false;
                    btn_deleteALT.Enabled = false;
                    // btn_cancelALT.Enabled = False
                    btn_saveALT.ForeColor = Color.Red;
                }
                else
                {
                    Interaction.Beep();
                    Interaction.MsgBox("Each entry must contain a plus sign (+) and an equal sign (=) following " + Constants.vbCrLf + "the Library name and the Location name, respectively.", MsgBoxStyle.Exclamation, "Missing + or = Signs");
                    altText.Focus();
                }
            }

        }

        private void altList_DoubleClick(object sender, EventArgs e)
        {
            if (radio_useLocal.Checked == false)
                return;
            btn_changeALT.Enabled = true;
            btn_deleteALT.Enabled = true;
            btn_cancelALT.Enabled = true;
            altText.Text = Conversions.ToString(altList.Items[altList.SelectedIndex]);
            altList.Enabled = false;
        }

        private void updateLabelText(string fname)
        {
            string filetext = "";
            int i = 0;

            if (altList.Items.Count <= 0)
                return;
            var loopTo = altList.Items.Count - 1;
            for (i = 0; i <= loopTo; i++)
                filetext = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(filetext, altList.Items[i]), Constants.vbCrLf));
            writeFile(fname, filetext, false);
            Application.DoEvents();
            loadLabelText();

        }
        private void hideALTedit()
        {
            Label44.Visible = false;
            Label54.Visible = false;
            btn_addALT.Visible = false;
            btn_changeALT.Visible = false;
            btn_deleteALT.Visible = false;
            btn_cancelALT.Visible = false;
            btn_saveALT.Visible = false;
            altText.Visible = false;
        }
        private void showALTedit()
        {
            Label44.Visible = true;
            Label54.Visible = true;
            btn_addALT.Visible = true;
            btn_changeALT.Visible = true;
            btn_deleteALT.Visible = true;
            btn_cancelALT.Visible = true;
            btn_saveALT.Visible = true;
            altText.Visible = true;
        }

        private void radio_useLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (warranty_accepted == false)
                return;
            if (radio_useLocal.Checked == true)
            {
                altURL.BackColor = Color.White;
                ALTfile = "myLabelText.txt";
                showALTedit();
            }
            else
            {
                if (madeALTchanges == true)
                {
                    object box = MessageBox.Show("Changes to your local label text file have not been saved." + Constants.vbCrLf + "Do you want to save them now?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(box, ((dynamic)box).Yes, false)))
                    {
                        btn_saveALT.PerformClick();
                        Interaction.MsgBox("Changes to your local label text file have been saved.", MsgBoxStyle.Information, "Settings Saved");
                        madeALTchanges = false;
                    }
                }
                ALTfile = "aboveLabel.txt";
                hideALTedit();
            }
            loadLabelText();
        }

        private void btn_saveALT_Click(object sender, EventArgs e)
        {
            updateLabelText(mypath + ALTfile);
            btn_saveALT.ForeColor = Color.Black;
            madeALTchanges = false;
        }

        private void chkRequireUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireUser.Checked)
            {
                usrname.Enabled = true;
                usrname.ForeColor = Color.Blue;
                usrname.Text = "";
                OutputBox.Font = new Font("MS Sans Serif", 9f, FontStyle.Regular);
                OutputBox.Text = usermessage;
                usrname.BackColor = Color.Yellow;
                usrname.Focus();
            }
            else
            {
                usrname.Enabled = false;
                usrname.ForeColor = Color.Gray;
                usrname.BackColor = Color.White;
                usrname.Text = "[none]";
                OutputBox.Text = "";
            }
        }

        private void station_TextChanged(object sender, EventArgs e)
        {
            lblStation.Text = station.Text;
        }

        private void buildStatRec()
        {

            string dt = DateTime.Now.ToString("yyyyMMdd", CultureInfo.CurrentCulture);
            // MsgBox("date: " & dt & " to short date string: " & DateTime.Now.ToShortDateString)
            string tm = DateTime.Now.ToString("HHmmss", CultureInfo.CurrentCulture);
            string parse = "";
            if (useExlibrisParsing.Checked)
                parse = "ExL";
            else
                parse = "SoM";
            try
            {
                statrec = dt + Constants.vbTab + tm + Constants.vbTab + station.Text + Constants.vbTab + usrname.Text + Constants.vbTab + lastbc + Constants.vbTab + parse + Constants.vbTab + cntype + Constants.vbTab + almaReturnCode + Constants.vbTab + almaLibrary + Constants.vbTab + almaLocation;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error writing statistics record --" + ex.Message);
            }
            // MsgBox("almaLibrary: " & almaLibrary & " -- almaLocation: " & almaLocation)
            lastbc = "";
            parse = "";
            cntype = "";
            almaReturnCode = "";
            almaLibrary = "";
            almaLocation = "";
        }

        private void writeStat(string result)
        {
            // result = P if spine label has been printed, or "S" if the records has been scanned only
            if (!string.IsNullOrEmpty(statrec))
            {
                statrec = statrec + Constants.vbTab + result;
                // MsgBox("writing: " & statrec)
                writeFile(mypath + "activity_log.txt", statrec, true);
                statrec = "";
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string itm;
            Array tda;
            Array tmp;
            int i;
            var cnt = new int[5001];
            for (i = 0; i <= 99; i++)
                cnt[i] = 0;
            int idx;
            StreamReader sr;
            FileStream fs;
            string lodate;
            string hidate;
            string hr = "";
            string dt = "";
            DateTime dte;
            int fld = 0;
            string arg = "";
            int tot = 0;
            int thisrep = 0;
            string colheading = "";
            Array trimsort;
            string infile = "activity_log.txt";
            string geolist = "";
            Array cntIP;
            int idxIP = 0;
            string quot = "\"";
            string cidate = "";
            string latlong = "";

            if (!logView)
            {
                if (!File.Exists(mypath + infile))
                {
                    var sw = File.CreateText(mypath + "activity_log.txt");
                    sw.Close();
                }
            }

            else
            {
                infile = "somlog.log";

            }

            STL.Items.Clear();

            fs = new FileStream(mypath + infile, FileMode.Open);
            sr = new StreamReader(fs);
            itm = sr.ReadLine();
            statsOut.Text = "          " + "SpineOMatic Labeling Activity Report -- From " + Conversions.ToString(fromScan.Value) + " to " + Conversions.ToString(toScan.Value) + " -- Station: " + station.Text + "~";

            dte = Convert.ToDateTime(fromScan.Value, CultureInfo.CurrentCulture);
            lodate = dte.ToString("yyyyMMdd", CultureInfo.CurrentCulture);
            dte = Convert.ToDateTime(toScan.Value, CultureInfo.CurrentCulture);
            hidate = dte.ToString("yyyyMMdd", CultureInfo.CurrentCulture);

            if (radioByUser.Checked)
            {
                fld = 3;
                colheading = radioByUser.Text.Replace("By ", "");
            }
            if (radioByLibrary.Checked)
            {
                fld = 8;
                colheading = radioByLibrary.Text.Replace("By ", "");
            }
            if (radioByLocation.Checked)
            {
                fld = 9;
                colheading = radioByLocation.Text.Replace("By ", "");
            }
            if (radioSearch.Checked)
            {
                if (string.IsNullOrEmpty(searchArg.Text))
                {
                    statsOut.Text = statsOut.Text + "No filter" + Constants.vbCrLf + Constants.vbCrLf;
                }
                else
                {
                    statsOut.Text = statsOut.Text + "Filtered by: " + searchArg.Text + Constants.vbCrLf + Constants.vbCrLf;
                }
                if (logView)
                {
                    statsOut.Text = statsOut.Text + "  Date & Time" + Constants.vbTab + "IP" + Constants.vbTab + Constants.vbCrLf + "Hostname" + Constants.vbTab + "File" + Constants.vbCrLf;
                }
                else
                {
                    statsOut.Text = statsOut.Text + "  Date & Time" + Constants.vbTab + "User" + Constants.vbTab + "Barcode" + Constants.vbTab + "Library" + Constants.vbTab + "Location" + Constants.vbCrLf;
                }
            }
            try
            {
                while (itm is not null)
                {
                    if (itm.Length < 20)
                    {
                        itm = sr.ReadLine();
                        continue;
                    }

                    if (!logView)
                    {
                        tda = Strings.Split(itm, Constants.vbTab);
                    }
                    else
                    {
                        tda = Strings.Split("" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab + "" + Constants.vbTab, Constants.vbTab);
                        tmp = Strings.Split(itm, Constants.vbTab);
                        tda.SetValue(tmp.GetValue(0), 0);
                        tda.SetValue(tmp.GetValue(1), 1);
                        tda.SetValue("weblog", 2);
                        tda.SetValue(tmp.GetValue(2), 3);
                        tda.SetValue(tmp.GetValue(5), 7);
                        tda.SetValue(tmp.GetValue(3), 8);
                        tda.SetValue(tmp.GetValue(4), 9);
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLess(tda.GetValue(0), lodate, false)))
                    {
                        itm = sr.ReadLine();
                        continue;
                    }
                    if (!logView & !inclScanned.Checked)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(tda.GetValue(10), "S", false)))
                        {
                            itm = sr.ReadLine();
                            continue;
                        }
                    }
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(tda.GetValue(0), hidate, false)))
                        break;
                    tot = tot + 1;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(tda.GetValue(7), "OK", false)))
                    {
                        tda.SetValue(Operators.ConcatenateObject(Operators.ConcatenateObject("***", tda.GetValue(7)), "***"), 8);
                        tda.SetValue(Operators.ConcatenateObject(Operators.ConcatenateObject("***", tda.GetValue(7)), "***"), 9);
                    }
                    if (radioSearch.Checked)
                    {
                        dt = Strings.Mid(Conversions.ToString(tda.GetValue(0)), 5, 2) + "/" + Strings.Mid(Conversions.ToString(tda.GetValue(0)), 7, 2) + "/" + Strings.Mid(Conversions.ToString(tda.GetValue(0)), 1, 4);
                        cidate = Conversions.ToString(DateTime.ParseExact(dt, "d", CultureInfo.InvariantCulture));
                        hr = Strings.Mid(Conversions.ToString(tda.GetValue(1)), 1, 2) + ":" + Strings.Mid(Conversions.ToString(tda.GetValue(1)), 3, 2) + ":" + Strings.Mid(Conversions.ToString(tda.GetValue(1)), 5, 2);
                        // If logView And chkAddHostname.Checked Then tda.SetValue(resolveIP(tda.GetValue(3)), 4)
                        arg = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(cidate + " " + hr + Constants.vbTab, tda.GetValue(3)), Constants.vbTab), tda.GetValue(4)), Constants.vbTab), tda.GetValue(8)), Constants.vbTab), tda.GetValue(9)));
                        if (string.IsNullOrEmpty(searchArg.Text))
                        {
                            statsOut.Text = statsOut.Text + arg + Constants.vbCrLf;
                            thisrep = thisrep + 1;
                        }
                        else if (arg.Contains(searchArg.Text))
                        {
                            statsOut.Text = statsOut.Text + arg + Constants.vbCrLf;
                            thisrep = thisrep + 1;
                        }
                    }
                    else
                    {
                        arg = Conversions.ToString(tda.GetValue(fld));
                        if (STL.FindStringExact(arg) != -1)
                        {
                            idx = STL.FindStringExact(arg);
                            cnt[idx] = cnt[idx] + 1;
                        }
                        else
                        {
                            idx = STL.Items.Add(arg);
                            cnt[idx] = 1;
                        }
                    }

                    itm = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in reporting system -- " + ex.Message, MsgBoxStyle.Critical, "Program Error");
            }
            sr.Close();
            fs.Close();
            if (!radioSearch.Checked)
                thisrep = STL.Items.Count;
            if (inclScanned.Checked)
            {
                statsOut.Text = statsOut.Text.Replace("~", Constants.vbCrLf + "          Total codes scanned and labels printed in date range: " + tot + " -- Lines in this report: " + thisrep + Constants.vbCrLf + Constants.vbCrLf);
            }
            else
            {
                statsOut.Text = statsOut.Text.Replace("~", Constants.vbCrLf + "          Total labels printed in date range: " + tot + " -- Lines in this report: " + thisrep + Constants.vbCrLf + Constants.vbCrLf);
            }
            if (radioSearch.Checked)
                return;

            statsOut.Text = statsOut.Text + Constants.vbTab + "Count" + Constants.vbTab + colheading + Constants.vbCrLf;

            sortSTL.Items.Clear();
            sortSTL.Sorted = false;
            var loopTo = STL.Items.Count - 1;
            for (i = 0; i <= loopTo; i++)
            {
                if (byCount.Checked)
                {
                    sortSTL.Items.Add(Operators.ConcatenateObject(string.Format("{0,6:######}", 999999 - cnt[i]) + "|" + string.Format("{0,6:######}", cnt[i]) + Constants.vbTab, STL.Items[i]));
                }
                else
                {
                    sortSTL.Items.Add(Operators.ConcatenateObject(Strings.Mid(Conversions.ToString(Operators.ConcatenateObject(STL.Items[i], Strings.Space(30))), 1, 30) + "|" + string.Format("{0,6:######}", cnt[i]) + Constants.vbTab, STL.Items[i]));
                }
            }

            ispList.Items.Clear();
            sortSTL.Sorted = true;
            Array LL;
            string locText = "";
            var loopTo1 = sortSTL.Items.Count - 1;
            for (i = 0; i <= loopTo1; i++)
            {
                locText = "";
                trimsort = Strings.Split(Conversions.ToString(sortSTL.Items[i]), "|");
                if (chkAddHostname.Checked)
                {
                    cntIP = Strings.Split(Conversions.ToString(trimsort.GetValue(1)), Constants.vbTab);
                    latlong = getLatLong(Conversions.ToString(cntIP.GetValue(1)));
                    if (latlong == "** can't connect **")
                    {
                        Interaction.MsgBox("Can't connect to IP resolver.");
                        return;
                    }
                    else
                    {
                        LL = Strings.Split(latlong, "|");
                        if (LL.Length > 4)
                        {
                            locText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(LL.GetValue(2), "/"), LL.GetValue(3)), "/"), LL.GetValue(4)), "/"), LL.GetValue(5)));
                        }
                        string tloc = "";
                        tloc = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(LL.GetValue(5), " ("), LL.GetValue(2)), "/"), LL.GetValue(3)), "/"), LL.GetValue(4)), ")"));
                        if (showIsp.Checked & !ispList.Items.Contains(tloc))
                        {
                            ispList.Items.Add(tloc);
                        }
                    }
                    geolist = geolist + "field[" + i + "]=" + quot + latlong + quot + ";" + Constants.vbCrLf;
                }
                statsOut.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(statsOut.Text + Constants.vbTab, trimsort.GetValue(1)), Constants.vbTab), locText), Constants.vbCrLf));
            }

            if (chkGeoList.Checked)
            {
                geolist = geolist + Constants.vbCrLf + "document.getElementById(" + quot + "usr" + quot + ").innerHTML = " + quot + "From " + Conversions.ToString(fromScan.Value) + " to " + Conversions.ToString(toScan.Value) + quot + ";";
                writeFile(mypath + "geoinfo.txt", geolist, false);
                string framein = "";
                TextReader tr = new StreamReader(mypath + "geoframe.txt");
                framein = tr.ReadToEnd();
                tr.Close();
                // MsgBox(framein)
                framein = framein.Replace("//insert_geolist", geolist);
                writeFile(mypath + "sommap.html", framein, false);
                var startInfo = new ProcessStartInfo(mypath + "sommap.html");
                Process p;
                // startInfo.WindowStyle = ProcessWindowStyle.Hidden 'makes sure entire process is invisible
                // startInfo.Arguments = FTPip.Text 'the IP address is passed to ftpbat.bat as an argument
                p = Process.Start(startInfo); // tell Windows to start the batch file
            }
            if (showIsp.Checked)
            {
                statsOut.Text = "";
                var loopTo2 = ispList.Items.Count - 1;
                for (i = 0; i <= loopTo2; i++)
                    statsOut.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(statsOut.Text, ispList.Items[i]), Constants.vbCrLf));
            }
        }


        private void radio_useSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (settingsLoaded == false)
                return;
            if (radio_useSystem.Checked)
            {
                if (string.IsNullOrEmpty(altURL.Text))
                {
                    Interaction.MsgBox("To use the system file, provide a URL to the web folder" + Constants.vbCrLf + "where the 'aboveLabel.txt' file can be found, and click 'Download'.", MsgBoxStyle.Information, "Use System File");
                    altURL.BackColor = Color.Yellow;
                    altURL.Focus();
                }
            }
        }


        private void getWebLog()
        {
            var webClient = new WebClient();
            string webRequest = "";
            string result = "";
            try
            {
                webRequest = updatePath.Text + "somlog.log";
                webClient.DownloadFile(webRequest, mypath + "somlog.log");
                OutputBox.Text = OutputBox.Text + Constants.vbCrLf + "Web log loaded";
                radioByUser.Text = "By IP";
                radioByLibrary.Text = "By Hostname";
                radioByLocation.Text = "By Filename";
                TabControl1.SelectedTab = TabPage6;
                openSettings();
                logView = true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Web log download error: " + ex.Message, MsgBoxStyle.Exclamation, "Download Error");
                return;
            }
        }
        private void logByHostname()
        {
            FileStream fs;
            StreamReader sr;
            string itm;
            int i;
            var cnt = new int[101];
            for (i = 0; i <= 99; i++)
                cnt[i] = 0;
            DateTime dte;
            string arg;
            string lodate;
            string hidate;
            int idx;
            Array fld, trimsort;

            statsOut.Text = "          " + "SpineOMatic Web Activity Log -- From " + Conversions.ToString(fromScan.Value) + " to " + Conversions.ToString(toScan.Value) + " -- Station: " + station.Text + "~" + Constants.vbCrLf;

            if (!File.Exists(mypath + "somlog.log"))
            {
                Interaction.MsgBox("No log file has been downloaded.");
                return;
            }
            dte = Convert.ToDateTime(fromScan.Value, CultureInfo.InvariantCulture);
            lodate = dte.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            dte = Convert.ToDateTime(toScan.Value, CultureInfo.InvariantCulture);
            hidate = dte.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            STL.Items.Clear();

            fs = new FileStream(mypath + "somlog.log", FileMode.Open);
            sr = new StreamReader(fs);
            itm = sr.ReadLine();

            while (itm is not null)
            {
                fld = Strings.Split(itm, Constants.vbTab);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectLess(fld.GetValue(0), lodate, false)))
                {
                    itm = sr.ReadLine();
                    continue;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(fld.GetValue(0), hidate, false)))
                    break;
                arg = Conversions.ToString(fld.GetValue(2)); // hostname
                if (STL.FindStringExact(arg) != -1)
                {
                    idx = STL.FindStringExact(arg);
                    cnt[idx] = cnt[idx] + 1;
                }
                else
                {
                    idx = STL.Items.Add(arg);
                    cnt[idx] = 1;
                }

                itm = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            sortSTL.Items.Clear();
            sortSTL.Sorted = false;
            var loopTo = STL.Items.Count - 1;
            for (i = 0; i <= loopTo; i++)
            {
                if (byCount.Checked)
                {
                    sortSTL.Items.Add(Operators.ConcatenateObject(string.Format("{0,6:######}", 999999 - cnt[i]) + "|" + string.Format("{0,6:######}", cnt[i]) + Constants.vbTab, STL.Items[i]));
                }
                else
                {
                    sortSTL.Items.Add(Operators.ConcatenateObject(Strings.Mid(Conversions.ToString(Operators.ConcatenateObject(STL.Items[i], Strings.Space(30))), 1, 30) + "|" + string.Format("{0,6:######}", cnt[i]) + Constants.vbTab, STL.Items[i]));
                }
            }

            sortSTL.Sorted = true;
            var loopTo1 = sortSTL.Items.Count - 1;
            for (i = 0; i <= loopTo1; i++)
            {
                trimsort = Strings.Split(Conversions.ToString(sortSTL.Items[i]), "|");
                statsOut.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(statsOut.Text + Constants.vbTab, trimsort.GetValue(1)), Constants.vbCrLf));
            }
        }

        private void LoadDefaults(TextBox t)
        {
            Array val;
            val = Strings.Split(t.Text, "|");
            inTopMargin.Text = Conversions.ToString(val.GetValue(0));
            inLeftMargin.Text = Conversions.ToString(val.GetValue(1));
            inLineSpacing.Text = Conversions.ToString(val.GetValue(2));
            inLabelWidth.Text = Conversions.ToString(val.GetValue(3));
            inGapWidth.Text = Conversions.ToString(val.GetValue(4));
            inLabelHeight.Text = Conversions.ToString(val.GetValue(5));
            inGapHeight.Text = Conversions.ToString(val.GetValue(6));
            inLabelRows.Text = Conversions.ToString(val.GetValue(7));
            inLabelCols.Text = Conversions.ToString(val.GetValue(8));
            inMaxLines.Text = Conversions.ToString(val.GetValue(9));
            inMaxChars.Text = Conversions.ToString(val.GetValue(10));
            usePortrait.Checked = Conversions.ToBoolean(val.GetValue(11));
            useLandscape.Checked = !Conversions.ToBoolean(val.GetValue(11));
            if (CustomLabel.Checked)
            {
                CustomText.Text = Conversions.ToString(val.GetValue(12));
                CustomText.Enabled = true;
            }
            else
            {
                CustomText.Enabled = false;
            }
        }
        private void SaveDefaults(TextBox t)
        {
            t.Text = inTopMargin.Text;
            t.Text = t.Text + "|" + inLeftMargin.Text;
            t.Text = t.Text + "|" + inLineSpacing.Text;
            t.Text = t.Text + "|" + inLabelWidth.Text;
            t.Text = t.Text + "|" + inGapWidth.Text;
            t.Text = t.Text + "|" + inLabelHeight.Text;
            t.Text = t.Text + "|" + inGapHeight.Text;
            t.Text = t.Text + "|" + inLabelRows.Text;
            t.Text = t.Text + "|" + inLabelCols.Text;
            t.Text = t.Text + "|" + inMaxLines.Text;
            t.Text = t.Text + "|" + inMaxChars.Text;
            if (usePortrait.Checked)
            {
                t.Text = t.Text + "|" + "true";
            }
            else
            {
                t.Text = t.Text + "|" + "false";
            }
            // If CustomLabel.Checked Then
            t.Text = t.Text + "|" + CustomText.Text;
            // End If
        }

        public string GetJavaVersionInfo()
        {
            string ermsg = "";
            // Const quote As String = """"
            string mpath = mypath;
            string noslash = Strings.Mid(mypath, 1, mypath.Length - 1);

            try
            {
                var procStartInfo = new ProcessStartInfo("java", "-cp " + "\"" + noslash + "\"" + " " + javaTest);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                var proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Return proc.StandardError.ReadToEnd()
                ermsg = proc.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(ermsg))
                {
                    if (ermsg.Contains("find or load"))
                    {
                        return "The Java test program (" + javaTest + ") was not downloaded." + Constants.vbCrLf + "Unable to perform test.";
                    }
                    else
                    {
                        return "Unknown error: " + ermsg;
                    }
                }
                else
                {
                    return proc.StandardOutput.ReadToEnd().Replace(Constants.vbCr, Constants.vbCrLf);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("cannot find the file"))
                {
                    return "Java is not installed, or is not accessible." + Constants.vbCrLf + Constants.vbCrLf + "Please report this problem to your local systems support staff.";
                }
            }
            return "unknown error";
        }

        private void tips_CheckedChanged(object sender, EventArgs e)
        {
            if (tips.Checked)
            {
                ToolTip1.Active = true;
            }
            else
            {
                ToolTip1.Active = false;
            }

        }
        private string _getLatLong2_cnissue = "";


        private string getLatLong2(string ip)
        {
            var webclient = new WebClient();
            string locxml = "";
            string hn = searchArg.Text;
            // Dim host As IPHostEntry
            var xdoc = new XmlDocument();
            string xfield = "";
            // host = Dns.GetHostEntry(hn)
            if (_getLatLong2_cnissue == "x")
                return "** can't connect **";
            try
            {
                locxml = webclient.DownloadString("http://freegeoip.net/xml/" + ip);
                xdoc.LoadXml(locxml);
                xfield = xdoc.SelectSingleNode("//Response/Latitude").InnerText;
                xfield = xfield + "|" + xdoc.SelectSingleNode("//Response/Longitude").InnerText;
                xfield = xfield + "|" + xdoc.SelectSingleNode("//Response/CountryName").InnerText;
                xfield = xfield + "|" + xdoc.SelectSingleNode("//Response/RegionName").InnerText;
                xfield = xfield + "|" + xdoc.SelectSingleNode("//Response/City").InnerText;
            }
            catch (Exception ex)
            {
                // MsgBox("Unable to connect to server")
                _getLatLong2_cnissue = "x";
                return "** can't connect **";
            }
            // MsgBox(host.HostName & vbCrLf & vbCrLf & locxml)
            return xfield;
        }
        private string _getLatLong_cnissue = "";
        private string getLatLong(string ip)
        {
            var webclient = new WebClient();
            string locxml = "";
            string hn = searchArg.Text;
            // Dim host As IPHostEntry
            var xdoc = new XmlDocument();
            string xfield = "";
            string ans = "";
            // host = Dns.GetHostEntry(hn)
            if (_getLatLong_cnissue == "x")
                return "** can't connect **";
            try
            {
                locxml = webclient.DownloadString("http://www.telize.com/geoip/" + ip);
                locxml = locxml.Replace("{", "").Replace("}", ",");

                xfield = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(getjson("latitude", locxml), "|"), getjson("longitude", locxml)), "|"), getjson("country", locxml)), "|"), getjson("region", locxml)), "|"), getjson("city", locxml)), "|"), getjson("isp", locxml)));
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Unable to connect to server" + Constants.vbCrLf + "Error: " + ex.Message);
                _getLatLong_cnissue = "x";
                return "** can't connect **";
            }
            // MsgBox(host.HostName & vbCrLf & vbCrLf & locxml)

            return xfield;
        }

        private object getjson(string lookup, string json)
        {
            object quot = "\"";
            int pos = 0;
            string ans = "";
            pos = Strings.InStr(json, Conversions.ToString(Operators.ConcatenateObject(lookup, quot)), CompareMethod.Text);

            if (pos != 0)
            {
                ans = BTween(json.Substring(pos), ":", ",");
                return ans.Replace(Conversions.ToString(quot), "");
            }
            return "unknown";
        }
        private string BTween(string t, string a, string b)
        {
            int pos1, pos2;
            int len_a = a.Length;
            pos1 = t.IndexOf(a) + len_a; // 1
            pos2 = t.IndexOf(b, pos1);
            if (pos1 == -1 | pos2 == -1)
                return "?";
            return t.Substring(pos1, pos2 - pos1);
        }

        private string xmlValue(object node_in)
        {
            return xmlValue(node_in, false);
        }
        private string xmlValue(object node_in, object okToSkip)
        {

            string xfield = "";
            string prefix = "";
            string orig_node = node_in.ToString();
            string node = "";
            string er = "";
            string text_node;
            prefix = "//printout/section-01/physical_item_display_for_printing";
            text_node = orig_node;
            node = prefix + orig_node.Replace("<", "/").Replace(">", "");
            try
            {
                xfield = xdoc.SelectSingleNode(node).InnerText;
            }
            catch (Exception ex)
            {
                if (!node.Contains("parsed_")) // call_number") Then
                {

                    if (Conversions.ToBoolean(Operators.AndObject(ex.Message.Contains("Object reference not set"), okToSkip)))
                    {
                        // Return empty string; it is ok if this element doesn't exist in the XML.
                        return "";
                    }
                    Interaction.Beep();
                    if (ex.Message.Contains("Object reference not set"))
                    {
                        er = orig_node + " is not in the XML record.";
                    }
                    else if (ex.Message.Contains("invalid token"))
                    {
                        er = orig_node + " contains an unexpected character.";
                    }
                    else
                    {
                        er = "Error in " + orig_node + ": " + Constants.vbCrLf + Constants.vbCrLf + ex.Message;
                    }

                    if (chkXMLWarning.Checked)
                    {
                        Interaction.MsgBox(er + Constants.vbCrLf + Constants.vbCrLf + "Check and correct the value.", MsgBoxStyle.Exclamation, "Invalid XML Field Name");
                    }
                    else
                    {
                        lblXMLWarn.Visible = true;
                        xmlerr = xmlerr + er + Constants.vbCrLf;
                    }
                }
                xfield = "";
            }
            // MsgBox("xfield:" & xfield)
            // MsgBox("xfield returned:" & xfield.Replace("|amp", "&").Replace("|lt;", "<"))
            return xfield.Replace("|amp", "&").Replace("&amp;", "&").Replace("|lt;", "<");
        }
        private void getnodes()
        {
            foreach (XmlNode node in xdoc.SelectNodes("/printout/section-01/physical_item_display_for_printing/*"))
            {

            }
        }
        private void Spine_CheckedChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            if (Spine.Checked)
            {
                saveCurrentDefaults();
                LoadDefaults(spineDefaults);
                pocketDefaultLoaded = false;
                spineDefaultLoaded = true;
                customFlagDefaultLoaded = false;
                customNonFlagDefaultLoaded = false;
            }
        }

        private void CustomLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            if (CustomLabel.Checked)
            {
                FlagSlips.Enabled = true;
                saveCurrentDefaults();
                if (FlagSlips.Checked)
                {
                    LoadDefaults(flagDefaults);
                    wrapWidth.Text = flagWrapWidth.Text;
                    pocketDefaultLoaded = false;
                    spineDefaultLoaded = false;
                    customFlagDefaultLoaded = true;
                    customNonFlagDefaultLoaded = false;
                }
                else
                {
                    LoadDefaults(nonFlagDefaults);
                    wrapWidth.Text = nonFlagWrapWidth.Text;
                    pocketDefaultLoaded = false;
                    spineDefaultLoaded = false;
                    customFlagDefaultLoaded = false;
                    customNonFlagDefaultLoaded = true;
                }
            }
            else
            {
                FlagSlips.Enabled = false;
            }
        }

        private void FlagSlips_CheckedChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            saveCurrentDefaults();
            if (FlagSlips.Checked)
            {
                LoadDefaults(flagDefaults);
                wrapWidth.Text = flagWrapWidth.Text;
                pocketDefaultLoaded = false;
                spineDefaultLoaded = false;
                customFlagDefaultLoaded = true;
                customNonFlagDefaultLoaded = false;
            }
            else
            {
                LoadDefaults(nonFlagDefaults);
                wrapWidth.Text = nonFlagWrapWidth.Text;
                pocketDefaultLoaded = false;
                spineDefaultLoaded = false;
                customFlagDefaultLoaded = false;
                customNonFlagDefaultLoaded = true;
            }
        }
        private void chkUsePocketLabels_CheckedChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            if (chkUsePocketLabels.Checked)
            {
                PocketLabelPanel.Location = new Point(0, 30);
                PocketLabelPanel.Width = TabPage2.Size.Width;
                PocketLabelPanel.Height = TabPage2.Size.Height - 30;
                PocketLabelPanel.Visible = true;

                saveCurrentDefaults();
                LoadDefaults(pocketDefaults);
                pocketDefaultLoaded = true;
                spineDefaultLoaded = false;
                customFlagDefaultLoaded = false;
                customNonFlagDefaultLoaded = false;
            }

            else
            {
                PocketLabelPanel.Visible = false;
                // save pocket label defaults & load whatever was previously saved
                saveCurrentDefaults();
                if (Spine.Checked)
                {
                    LoadDefaults(spineDefaults);
                    pocketDefaultLoaded = false;
                    spineDefaultLoaded = true;
                    customFlagDefaultLoaded = false;
                    customNonFlagDefaultLoaded = false;
                }
                else
                {
                    CustomLabel.Checked = !CustomLabel.Checked;
                    CustomLabel.Checked = !CustomLabel.Checked;
                }
            }
            refreshFTP();
            InputBox.Focus();
        }

        private void Label71_Click(object sender, EventArgs e)
        {
            tweakParsingPanel.Visible = false;
        }

        private void tweakTest_Click(object sender, EventArgs e)
        {
            tweakParsingPanel.Location = new Point(0, 0);
            tweakParsingPanel.Size = TabPage2.Size;
            tweakParsingPanel.Visible = true;
            testCallNumType.Text = "0";
        }

        private void saveCurrentDefaults()
        {
            // save the margin defaults for the Call Number Format that is currently loaded
            if (spineDefaultLoaded)
            {
                SaveDefaults(spineDefaults);
            }
            // spineVerticalLine = chk_VerticalLine.Checked
            else if (customFlagDefaultLoaded)
            {
                SaveDefaults(flagDefaults);
                flagWrapWidth.Text = wrapWidth.Text;
            }
            // flagVerticalLine = chk_VerticalLine.Checked
            else if (customNonFlagDefaultLoaded)
            {
                SaveDefaults(nonFlagDefaults);
                nonFlagWrapWidth.Text = wrapWidth.Text;
            }
            // nonFlagVerticalLine = chk_VerticalLine.Checked
            else
            {
                SaveDefaults(pocketDefaults);
                // pocketVerticalLine = chk_VerticalLine.Checked
            }
        }

        private void btnTestParser_Click(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            string itm = "";
            itm = testComboBox.Text;
            if (string.IsNullOrEmpty(testCallNumType.Text))
            {
                Interaction.MsgBox("You must specify a Call Number Type", MsgBoxStyle.Information, "No Call Number Type");
                return;
            }
            cntype = testCallNumType.Text;
            if (itm.Contains("[LC]"))
                itm = itm.Replace("[LC]", "");
            if (itm.Contains("[LC child. lit]"))
                itm = itm.Replace("[LC child. lit]", "");
            if (itm.Contains("[NLM]"))
                itm = itm.Replace("[NLM]", "");
            if (itm.Contains("[Dewey]"))
                itm = itm.Replace("[Dewey]", "");
            if (itm.Contains("[SuDoc]"))
                itm = itm.Replace("[SuDoc]", "");
            if (itm.Contains("[Other]"))
                itm = itm.Replace("[Other]", "");
            OutputBox.Font = new Font(inFontName.Text, Conversions.ToSingle(inFontSize.Text), FontStyle.Regular);
            OutputBox.Text = parseLC("*" + itm);

        }

        private void testComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itm = "";
            itm = Conversions.ToString(testComboBox.Items[testComboBox.SelectedIndex]);
            if (itm.Contains("[LC]"))
                testCallNumType.Text = "0";
            if (itm.Contains("[LC child. lit]"))
                testCallNumType.Text = "0";
            if (itm.Contains("[Dewey]"))
                testCallNumType.Text = "1";
            if (itm.Contains("[NLM]"))
                testCallNumType.Text = "2";
            if (itm.Contains("[SuDoc]"))
                testCallNumType.Text = "3";
            if (itm.Contains("[Other]"))
                testCallNumType.Text = "4";
            OutputBox.Text = "";
            btnTestParser.Focus();
        }

        private void lcNumericBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcDecimalBreakB4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }
        private void lcNoDecimalBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcCutterBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcInCutterBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void hideCutterDecimal_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }


        private void testCallNumType_TextChanged(object sender, EventArgs e)
        {
            if (!settingsLoaded)
                return;
            string tct = "";
            if (string.IsNullOrEmpty(Strings.Trim(testCallNumType.Text)))
            {
                tct = convertBlankTo.Text; // "blank"
                testCallNumType.Text = tct;
            }
            else
            {
                tct = testCallNumType.Text;
            }

            if (lcType.Text.Contains(tct))
            {
                TabControl2.SelectedTab = TabPage7;
            }
            else if (DeweyType.Text.Contains(tct))
            {
                TabControl2.SelectedTab = TabPage8;
            }
            else if (sudocType.Text.Contains(tct))
            {
                TabControl2.SelectedTab = TabPage10;
            }
            else if (otherType.Text.Contains(tct))
            {
                TabControl2.SelectedTab = TabPage11;
            }
            else
            {
                Interaction.MsgBox("Call number type " + testCallNumType.Text + " is not handled by any parsing routine.");
            }
        }

        private void sudocBreakDecimal_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocBreakBeforeColon_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocBreakAfterColon_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocSlashBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocDashBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }
        private void sudocOtherNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocCharBreakB4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocRemoveAfter_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }
        private void deweyDecimalBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyCutterBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyInCutterBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
            if (TabControl2.SelectedIndex == 0)
            {
                testCallNumType.Text = "0";
            }
            if (TabControl2.SelectedIndex == 1)
            {
                testCallNumType.Text = "1";
            }
            if (TabControl2.SelectedIndex == 2)
            {
                testCallNumType.Text = "3";
            }
            if (TabControl2.SelectedIndex == 3)
            {
                testCallNumType.Text = "4";
            }
        }

        private void otherSpaceNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void otherAllSpaceBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void othernumnobreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void otherListNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void otherListBreakb4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void othernumbreakb4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyDecimalNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            // btnTestParser.PerformClick()
            if (deweyDecimalNoBreak.Checked)
            {
                deweyDecBreak.Enabled = true;
                deweyDigitsToBreak.Enabled = true;
            }
            else
            {
                deweyDecBreak.Enabled = false;
                deweyDigitsToBreak.Enabled = false;
            }
            btnTestParser.PerformClick();
        }

        private void deweyCharBreakb4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyOtherNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyPrefixBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocNoDecimalBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocNoColonBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocBreakBeforeColon_CheckedChanged_1(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocSlashNobreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocDashNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcOtherNoBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcOtherBreakB4_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void lcRemoveAfter_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyRemoveAfter_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void otherRemoveAfter_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void sudocBreakB4Numerics_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyGroup3_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweyDecBreak_CheckedChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void LabelRepeat_ValueChanged(object sender, EventArgs e)
        {
            if (LabelRepeat.Value > 1m & LabelRepeat.Value < 6m)
            {
                LabelRepeat.BackColor = Color.Pink;
                LabelRepeat.ForeColor = Color.Black;
            }
            else if (LabelRepeat.Value > 5m)
            {
                LabelRepeat.BackColor = Color.Red;
                LabelRepeat.ForeColor = Color.White;
            }
            else
            {
                LabelRepeat.BackColor = Color.PaleGreen;
                LabelRepeat.ForeColor = Color.Black;
            }
            InputBox.Focus();
        }

        private void lblXMLWarn_Click(object sender, EventArgs e)
        {
            string saveOutputBox = "";
            OutputBox.Text = xmlerr;
        }

        private void lblToggleAdmin_Click(object sender, EventArgs e)
        {
            if (lblToggleAdmin.Text == "u")
            {
                openSettings();
            }
            else
            {
                CloseSettings();
            }
        }

        private void TabChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                if (chkUsePocketLabels.Checked)
                {
                    showLabelType.Text = "Pocket Labels";
                }
                else if (Spine.Checked)
                {
                    showLabelType.Text = "Spine Labels";
                }
                else if (FlagSlips.Checked)
                {
                    showLabelType.Text = "Custom/Flag Slips";
                }
                else
                {
                    showLabelType.Text = "Custom Labels";
                }
            }
        }

        private void closeFormatInfo_Click(object sender, EventArgs e)
        {
            formatInfoPanel.Visible = false;
            formatInfoPanel.SendToBack();
        }

        private void showFormatInfo_Click(object sender, EventArgs e)
        {
            formatInfoPanel.Visible = true;
            formatInfoPanel.BringToFront();
            formatInfoPanel.Focus();
        }

        private void btnPlCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlCustom.Checked)
            {
                userDefinedPanel.Enabled = true;
            }
            else
            {
                userDefinedPanel.Enabled = false;
            }
        }

        private bool pingServer(string server)
        {
            bool pingServerRet = default;

            // MsgBox(TabControl2.SelectedTab.Text)
            // Dim p As New NetworkInformation.Ping()
            // Dim rtn As NetworkInformation.PingReply = p.Send("www.uno.edu", 3000)

            // If rtn.RoundtripTime = 0 Then
            // MsgBox("server unavailable" & rtn.RoundtripTime & _
            // vbCrLf & rtn.Status)

            // Else
            // MsgBox("Time: " & rtn.RoundtripTime)
            // End If
            if (My.MyProject.Computer.Network.IsAvailable)
            {
                try
                {
                    if (My.MyProject.Computer.Network.Ping(server, 5000))
                    {
                        pingServerRet = true;
                    }
                    else
                    {
                        pingServerRet = false;
                    }
                }
                catch (Exception ex)
                {
                    pingServerRet = false;
                }
            }

            return pingServerRet;
        }

        private void ColonBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (ColonBreak.Checked)
            {
                ProtectColon.Enabled = true;
            }
            else
            {
                ProtectColon.Enabled = false;
            }
        }
        private string bcyaInfo()
        {
            string strHostName = "";
            string strIPAddress = "";
            strHostName = Dns.GetHostName();
            strIPAddress = Dns.GetHostEntry(strHostName).AddressList[0].ToString();
            return "Host Name: " + strHostName + "; IP Address: " + strIPAddress;

        }
        private string ipconfig()
        {
            string ipconfigRet = default;
            var p = new Process();
            int i = 0;
            string ipinfo = "";
            {
                var withBlock = p.StartInfo;
                withBlock.FileName = "ipconfig.exe";
                withBlock.CreateNoWindow = true;
                withBlock.RedirectStandardOutput = true;
                withBlock.RedirectStandardError = true;
                withBlock.UseShellExecute = false;
            }
            try
            {
                p.Start();
                if (p.WaitForExit(1500))
                {
                    ipconfigRet = p.StandardOutput.ReadToEnd();
                    configText.Text = ipconfigRet;
                    var loopTo = configText.Lines.Length - 1;
                    for (i = 0; i <= loopTo; i++)
                    {
                        if (configText.Lines[i].ToUpper().Contains("IPV4"))
                        {
                            ipinfo = ipinfo + configText.Lines[i] + Constants.vbCrLf;
                        }
                    }
                    ipconfigRet = ipinfo;
                }
                else
                {
                    ipconfigRet = "No IPv4 Returned";
                }
            }
            catch (Exception ex)
            {
                ipconfigRet = "Cannot run ipconfig";
            }

            return ipconfigRet;
        }

        private void plDistance_TextChanged(object sender, EventArgs e)
        {
            plDistance.BackColor = Color.White;
        }

        private void Label62_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Strings.Trim(statsOut.Text)))
            {
                Interaction.MsgBox("There is no report text to copy to the clipboard.");
                return;
            }

            try
            {
                Clipboard.SetText(statsOut.Text);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("An error occurred when copying text to the Windows clipboard." + Constants.vbCrLf + Constants.vbCrLf + "Error: " + ex.Message, MsgBoxStyle.Exclamation, "Clipboard Error");
                return;
            }
            copyDone.Text = "...copied";
        }

        private void statsOut_TextChanged(object sender, EventArgs e)
        {
            copyDone.Text = "";
        }

        private void lbl_copyXMLtext_Click(object sender, EventArgs e)
        {
            string copyXmlHdr = "";
            string settingsText = "";

            if (includeSettings.Checked)
            {
                string settingsFile = mypath + "settings.som";
                try
                {
                    TextReader tr = new StreamReader(settingsFile);
                    settingsText = tr.ReadToEnd();
                    settingsText = "*** Settings ***" + Constants.vbCrLf + Constants.vbCrLf + settingsText;
                    tr.Close();
                }
                catch (Exception somEx)
                {
                    Interaction.MsgBox("Error reading 'settings.som' file." + Constants.vbCrLf + Constants.vbCrLf + "Error: " + somEx.Message, MsgBoxStyle.Exclamation, "Settings File Read Error");
                    settingsText = Constants.vbCrLf + Constants.vbCrLf + "************** Error reading settings file ****************";
                }
            }
            else
            {
                settingsText = "Settings not requested.";
            }

            if (string.IsNullOrEmpty(Strings.Trim(RichTextBox1.Text)))
            {
                Interaction.MsgBox("There is no text to copy to the clipboard.");
                return;
            }
            copyXmlHdr = bcyaInfo() + Constants.vbCrLf + Conversions.ToString(DateTime.Now) + Constants.vbCrLf + Constants.vbCrLf;
            try
            {
                Clipboard.SetText(copyXmlHdr + RichTextBox1.Text.Replace(Constants.vbLf, Constants.vbCrLf) + Constants.vbCrLf + Constants.vbCrLf + settingsText);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("An error occurred when copying text to the Windows clipboard." + Constants.vbCrLf + Constants.vbCrLf + "Error: " + ex.Message, MsgBoxStyle.Exclamation, "Clipboard Error");
                return;
            }
            xmlCopyDone.Text = "...copied";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            xmlCopyDone.Text = "";
        }

        private void includeSettings_CheckedChanged(object sender, EventArgs e)
        {
            xmlCopyDone.Text = "";
        }

        private string getHostName(string ip)
        {
            string hn;
            try
            {
                hn = Dns.GetHostEntry(ip).HostName.ToString();
            }
            catch (Exception ex)
            {
                hn = "(unknown host)";
            }
            return hn;
        }

        private string resolveIP(object ip)
        {
            // OutputBox.Text = getHostName(InputBox.Text)
            string iptext = "";
            string res = "";
            int pos = 0;
            int pos2 = 0;
            if (File.Exists(mypath + "resolve.txt"))
            {
                File.Delete(mypath + "resolve.txt");
            }
            Thread.Sleep(250);
            // lookup(InputBox.Text)
            lookup(Conversions.ToString(ip));
            Thread.Sleep(550);
            iptext = File.ReadAllText(mypath + "resolve.txt");
            pos = Strings.InStr(iptext, "Name:", CompareMethod.Text) + 5;
            if (pos < 6)
            {
                res = "Host Unknown";
            }
            else
            {
                pos2 = Strings.InStr(pos + 1, iptext, "Address", CompareMethod.Binary);
                res = Strings.Trim(Strings.Mid(iptext, pos, pos2 - pos));
            }
            // MsgBox(res)
            return res;
        }
        private void lookup(string ip)
        {
            var procInfo = new ProcessStartInfo();
            // procInfo.WindowStyle = ProcessWindowStyle.Hidden
            procInfo.UseShellExecute = true;
            procInfo.FileName = @"c:\windows\system32\cmd.exe";
            // MsgBox("ip: " & ip)
            // MsgBox("/c nslookup " & ip & " > resolve.txt")

            procInfo.Arguments = "/c nslookup " + ip + " > resolve.txt";
            procInfo.WorkingDirectory = mypath;

            procInfo.Verb = "runas";
            Process.Start(procInfo);
        }

        private void FTPLogin_TextChanged(object sender, EventArgs e)
        {
            if (settingsLoaded)
            {
                ftpArrow.Visible = true;
                btn_ftpRegister.Visible = true;
                ftpRegisterMsg.Visible = true;
            }
        }

        private void btn_ftpRegister_Click(object sender, EventArgs e)
        {
            createBatFiles();
            ftpArrow.Visible = false;
            btn_ftpRegister.Visible = false;
            ftpRegisterMsg.Visible = false;
        }

        private void FTPPassword_TextChanged(object sender, EventArgs e)
        {
            if (settingsLoaded)
            {
                ftpArrow.Visible = true;
                btn_ftpRegister.Visible = true;
                ftpRegisterMsg.Visible = true;
            }
        }

        private void useDOSBatch_CheckStateChanged(object sender, EventArgs e)
        {
            if (useDOSBatch.Checked)
            {
                viaDOSPanel.Location = new Point(4, 16); // DesktopGroup.Location
                viaDOSPanel.Size = new Size(408, 312); // DesktopGroup.Size
                Label35.Visible = false;
                UseDesktop.Visible = false;
                UseLaser.Visible = false;
                UseFTP.Visible = false;
                orientationPanel.Visible = false;
                marginPanel.Visible = false;
                ManualPrint.Text = "Run 'viados' batch file";
                ToolTip1.SetToolTip(ManualPrint, "Writes label text to 'label.txt' file, then starts 'viados.bat' batch file.");
                ManualPrint.ForeColor = Color.Red;
                viaDOSPanel.Visible = true;
                batchDisplay.Text = Conversions.ToString(getdosbatchfile("viados"));
                batsignal.ForeColor = Color.Green;
                LabelRepeat.Visible = false;
            }
            else
            {
                viaDOSPanel.Visible = false;
                marginPanel.Visible = true;
                orientationPanel.Visible = true;
                Label35.Visible = false;
                UseDesktop.Visible = true;
                UseLaser.Visible = true;
                UseFTP.Visible = true;
                LabelRepeat.Visible = true;
                SetPrintButtonText();
                refreshFTP();
            }
            InputBox.Focus();
        }
        private object getdosbatchfile(object batfile)
        {
            string dostext = "";
            string res = "";
            if (!File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(mypath, batfile), ".bat"))))
            {
                return ""; // Create your own " & batfile & ".bat batch file."
            }
            res = File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(mypath, batfile), ".bat")));
            res = res.Substring(0, res.Length - 2);
            return res;
        }

        private void viadosSave_Click(object sender, EventArgs e)
        {
            writeFile(mypath + "viados.bat", batchDisplay.Text, false);
            batsignal.ForeColor = Color.Green;
        }

        private void batchDisplay_TextChanged(object sender, EventArgs e)
        {
            if (batsignal.ForeColor == Color.Green)
            {
                batsignal.ForeColor = Color.Red;
            }
        }

        private void loadViados_Click(object sender, EventArgs e)
        {
            batchDisplay.Text = Conversions.ToString(getdosbatchfile("viados"));
            batsignal.ForeColor = Color.Green;
        }


        private void unitINCH_CheckedChanged(object sender, EventArgs e)
        {
            string ut = "";
            var clr = new Color();
            if (unitCM.Checked)
            {
                ut = "cm.";
                clr = Color.Maroon;
            }
            else
            {
                ut = "in.";
                clr = Color.Blue;
            }
            inUnits1.Text = ut;
            inUnits1.ForeColor = clr;
            inUnits2.Text = ut;
            inUnits2.ForeColor = clr;
            Label121.Text = ut;
            Label121.ForeColor = clr;
            plUnits1.Text = ut;
            plUnits1.ForeColor = clr;
            plUnits2.Text = ut;
            plUnits2.ForeColor = clr;
            InputBox.Focus();
        }

        private void decimalDOT_CheckedChanged(object sender, EventArgs e)
        {
            string pFrom = "";
            string pTo = "";

            if (decimalDOT.Checked)
            {
                pFrom = ",";
                pTo = ".";
            }
            else
            {
                pFrom = ".";
                pTo = ",";
            }
            inTopMargin.Text = inTopMargin.Text.Replace(pFrom, pTo);
            inLeftMargin.Text = inLeftMargin.Text.Replace(pFrom, pTo);
            inLineSpacing.Text = inLineSpacing.Text.Replace(pFrom, pTo);
            inLabelHeight.Text = inLabelHeight.Text.Replace(pFrom, pTo);
            inLabelWidth.Text = inLabelWidth.Text.Replace(pFrom, pTo);
            inGapHeight.Text = inGapHeight.Text.Replace(pFrom, pTo);
            inGapWidth.Text = inGapWidth.Text.Replace(pFrom, pTo);
            plLeftMargin.Text = plLeftMargin.Text.Replace(pFrom, pTo);
            plDistance.Text = plDistance.Text.Replace(pFrom, pTo);
            wrapWidth.Text = wrapWidth.Text.Replace(pFrom, pTo);
            InputBox.Focus();
        }

        private void deweyDecimalBreakAft_CheckedChanged(object sender, EventArgs e)
        {
            if (deweyDecimalBreakAft.Checked)
            {
                deweyGroup3.Enabled = true;
                deweydigitsperline.Enabled = true;
                Label25.Enabled = true;
            }
            else
            {
                deweyGroup3.Enabled = false;
                deweydigitsperline.Enabled = false;
                Label25.Enabled = false;
            }
        }

        private void closeXbox_Click(object sender, EventArgs e)
        {
            xboxPanel.Visible = false;
            xtb.BackColor = xtbOrigColor;
        }

        private void xmlLoad(object sender, EventArgs e)
        {

            XBOX.Items.Clear();
            xboxPanel.Height = ManualPrint.Location.Y - 30;
            xboxPanel.Width = TabControl1.Location.X - 4;
            foreach (XmlNode node in xdoc.SelectNodes("/printout/section-01/physical_item_display_for_printing/*"))
            {
                XBOX.Items.Add("<" + node.Name + ">");
                if (node.HasChildNodes)
                {
                    foreach (XmlNode child in node)
                    {
                        if (child.Name != "#text")
                            XBOX.Items.Add("<" + node.Name + "><" + child.Name + ">");
                    }
                }
            }
            if (XBOX.Items.Count != 0)
            {
                if (xtb is not null && xtb.BackColor != Color.White)
                {
                    xtb.BackColor = Color.White;
                }
                xtb = (TextBox)sender;
                xtbOrigColor = xtb.BackColor;
                xtb.BackColor = Color.AntiqueWhite;
                xboxPanel.Visible = true;
            }
            else
            {
                Interaction.MsgBox("XML fields can only be selected after a barcode has been scanned.", MsgBoxStyle.Information, "Select XML field");
            }
        }

        private void XBOX_DoubleClick(object sender, EventArgs e)
        {
            string xf = "";
            xf = Conversions.ToString(XBOX.SelectedItem);
            if (xtb.Multiline == false)
            {
                xtb.Text = xf;
            }
            else if (xtb.SelectionLength == 0)
            {
                xtb.SelectedText = xf + Constants.vbCrLf;
            }
            else
            {
                xtb.SelectedText = xf;
            }
            xtb.BackColor = xtbOrigColor;
            xboxPanel.Visible = false;
        }

        private void Label126_Click(object sender, EventArgs e)
        {
            string hmsg = "";
            hmsg = "When running in hidden mode, the Command Prompt window will not be visible.  ";
            hmsg = hmsg + "Make sure that there are no commands in the batch file (such as 'pause') ";
            hmsg = hmsg + "that will require a keypress or other response from the user.  Otherwise, the ";
            hmsg = hmsg + "batch process will never close." + Constants.vbCrLf + Constants.vbCrLf;
            hmsg = hmsg + "If this happens, use the Task Manager to kill any stray 'cmd.exe' processes.";

            Interaction.MsgBox(hmsg, MsgBoxStyle.Information, "Run Hidden Warning");
        }

        private void hideDosWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (hideDosWindow.Checked)
            {
                viadosCaution.Visible = true;
            }
            else
            {
                viadosCaution.Visible = false;
            }
        }

        private void chkAddHostname_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddHostname.Checked)
            {
                chkGeoList.Enabled = true;
            }
            else
            {
                chkGeoList.Enabled = false;
            }
        }

        private void deweyDigitsToBreak_TextChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void deweydigitsperline_TextChanged(object sender, EventArgs e)
        {
            btnTestParser.PerformClick();
        }

        private void UseRestfulApi_CheckedChanged(object sender, EventArgs e)
        {
            if (UseRestfulApi.Checked)
            {
                accessType.Text = "R";
                accessType.ForeColor = Color.Green;
                ToolTip1.SetToolTip(accessType, "Using preferred RESTful API access to Alma.");
            }
            else
            {
                accessType.Text = "J";
                accessType.ForeColor = Color.Red;
                ToolTip1.SetToolTip(accessType, "Caution--Using deprecated Java access to Alma.");
            }
        }

        private void dontConvert_CheckedChanged(object sender, EventArgs e)
        {
            if (dontConvert.Checked == true)
            {
                Interaction.MsgBox("Caution--Check this box only to enable viewing the RESTful XML file in " + "the 'Current XML' panel. The RESTful XML must be converted to the older (Java) " + "format in order for SpineOMatic to function.", MsgBoxStyle.Information, "Warning");
            }
        }

        private void UseServlet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}