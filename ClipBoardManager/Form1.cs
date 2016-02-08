using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace ClipBoardManager
{
    public partial class Form1 : Form
    {
        Document document { get; set; }

        public int noOfItems { get; set; }                          // variable to store maximum number of itemst to be stored
        int width { get; set; }                                     // width of the screen in pixels, used to determinate proper position of the form
        int height { get; set; }                                    // height of the screen in pixels, used to determinate proper position of the form
        bool closeApp { get; set; }                                   // variable to store if app should be closed od red X btn click or not (minimized to system tray)

        String setap { get; set; }                                  // location where the setup file is located
        String history { get; set; }                                // location where history is saved
        String username { get; set; }                               // name of the active user
        String root { get; set; }                                   // Leter of disk drive where Windows is installed (ex: C, D, E...)

        public Form1()
        {
            InitializeComponent();



            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            history = root + @"Users\Public\clipboard\history.txt";
            setap = root + @"Users\Public\clipboard\lines.txt";

            // Initialize clipBoard listener
            AddClipboardFormatListener(this.Handle);

            // intilize number of items acorting to value in form numeric updown
            noOfItems = (int)nudHistorySize.Value;

            // call methot to initialize width and height values representing screen size
            SetPosition();

            closeApp = false;

            // try to read config file   // if config file not found, load form defaults
            try
            {
                FillForm();
                MessageBox.Show("Form filed from file");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setup not found");
            }

            if (cbRememberHistory.Checked == true)
            {
                try
                {
                    FillWithHistory();
                    MessageBox.Show("History found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("History not found");
                }
            }

            this.document = new Document( Int32.Parse(nudHistorySize.Value.ToString()));
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        //
        //
        // Start initialization of fields neceserry for Clipboard Listener

        // <summary>
        // Places the given window in the system-maintained clipboard format listener list.
        // </summary>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AddClipboardFormatListener(IntPtr hwnd);

        // <summary>
        // Removes the given window from the system-maintained clipboard format listener list.
        // </summary>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        // <summary>
        // Sent when the contents of the clipboard have changed.
        // </summary
        private const int WM_CLIPBOARDUPDATE = 0x031D;

        // End initialization of fields neceserry for Clipboard Listener
        //
        //
        ///////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////////////////////////
        //
        // The logic behind the clipboard listener
        // method to catch clipboard changes
        // ****     note1: this is recursive method!!!
        protected override void WndProc(ref Message m)
        {
            // note1: you see! this is recursive method!
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                if (Clipboard.ContainsFileDropList() && cbFilesAndFolders.Checked)
                {
                    StringCollection item;
                    item = Clipboard.GetFileDropList();
                    if (item.Count == 1)
                    {
                        // add to context menu as last item
                        AddToDocument(item);
                        // add more code to produce specific behaviour for adding files (documents)
                        // should be implemented ****    ****    ****
                    }
                }
                // if 'else' is reached then current clipboard item is string for shure
                else
                {
                    if (Clipboard.ContainsText() && cbText.Checked)
                    {
                        string name = Clipboard.GetText();
                        AddToDocument(name);  
                    }
                }
            }
        }

        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////


        // note1: this method might trow Exception if file is missing
        // note2: the exception is handled in <formLoad()> method
        private void FillWithHistory()
        {
            string line;
            System.IO.StreamReader reader = new System.IO.StreamReader(history);

            line = reader.ReadLine();
            while (line != null)
            {
                // 0 = file or folder had to be serialized but it was not
                // note3: go to "HistorySerialization()" to see the implementation
                if (line != "0")
                {
                    document.AddEntry(line);
                }
                line = reader.ReadLine();
            }
            reader.Close();
            GenerateContextMenu();
            GenerateListBoxElements();
        }

        // note1: this method might trow Exception if file is missing
        // note2: the exception is handled in <formLoad()> method
        private void FillForm()
        {
            String line;
            System.IO.StreamReader reader = new System.IO.StreamReader(setap);

            for (int i = 0; i < 12; i++)
            {
                line = reader.ReadLine();

                // 0 < i < 11
                // each case for i test some property
                // ex: i=0 test if form should be in top left corner,
                // ex: i=1 test if form should be in top right corner...
                switch (i)
                {
                    case 0:
                        if (line == "1")
                        {
                            rbTopLeft.Checked = true;
                        }
                        else
                        {
                            rbTopLeft.Checked = false;
                        }
                        break;
                    case 1:
                        if (line == "1")
                        {
                            rbTopRight.Checked = true;
                        }
                        else
                        {
                            rbTopRight.Checked = false;
                        }
                        break;
                    case 2:
                        if (line == "1")
                        {
                            rbBotomLeft.Checked = true;
                        }
                        else
                        {
                            rbBotomLeft.Checked = false;
                        }
                        break;
                    case 3:
                        if (line == "1")
                        {
                            rbBotomRight.Checked = true;
                        }
                        else
                        {
                            rbBotomRight.Checked = false;
                        }
                        break;
                    case 4:
                        if (line == "1")
                        {
                            rbSortByTime.Checked = true;
                        }
                        else
                        {
                            rbSortByTime.Checked = false;
                        }
                        break;
                    case 5:
                        if (line == "1")
                        {
                            rbSortByCategory.Checked = true;
                        }
                        else
                        {
                            rbSortByCategory.Checked = false;
                        }
                        break;
                    case 6:
                        if (line == "1")
                        {
                            rbFirstText.Checked = true;
                        }
                        else
                        {
                            rbFirstText.Checked = false;
                        }
                        break;
                    case 7:
                        if (line == "1")
                        {
                            rbFilesAndFoldersFirst.Checked = true;
                        }
                        else
                        {
                            rbFilesAndFoldersFirst.Checked = false;
                        }
                        break;
                    case 8:
                        if (line == "1")
                        {
                            cbText.Checked = true;
                        }
                        else
                        {
                            cbText.Checked = false;
                        }
                        break;
                    case 9:
                        if (line == "1")
                        {
                            cbFilesAndFolders.Checked = true;
                        }
                        else
                        {
                            cbFilesAndFolders.Checked = false;
                        }
                        break;
                    case 10:
                        nudHistorySize.Value = Int32.Parse(line);
                        break;
                    case 11:
                        if (line == "1")
                        {
                            cbRememberHistory.Checked = true;
                        }
                        else
                        {
                            cbRememberHistory.Checked = false;
                        }
                        break;
                }
            }
            reader.Close();
            // if this code is reached, config file was present
            // that equals program has been running in the past
            // so we put it in systemtray
            this.WindowState = FormWindowState.Minimized;
        }

        // remember string (text) that was copied
        // note1: this method has one more signature, it is used for remembering files and folders
        private void AddToDocument(string text)
        {
            document.AddEntry(text);
            GenerateContextMenu();
            GenerateListBoxElements();
        }

        // remember files/folders that was copied
        // take care for duplicates!!   ***   [duplicates not handled]
        // note1: this method has one more signature, it is for remembering strings (text)
        private void AddToDocument(StringCollection item)
        {
            document.AddEntry(item);
            GenerateContextMenu();
            GenerateListBoxElements();
        }

        // delete all entries
        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            document.Clear();
            GenerateContextMenu();
            GenerateListBoxElements();
        }

        // delete unnecesery items from context menu and/or generate new ones
        private void GenerateContextMenu()
        {
            // MessageBox.Show(document.GetEntries().Count.ToString());

            // first delete all items in contextMenu
            // note1: variable "i" is not incrementing
            // note2: '.Count' return smaller integer in every next iteration
            for (int i = 2; i < contextMenu.Items.Count;)
            {
                contextMenu.Items.RemoveAt(2);
            }
            // all items are removed
            // only controls (show/hide, close) are left

            // now add  items
            // we might sort them here   ***   [sorting not implemented]

            List<Entry> entries = document.GetEntries();
            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];
                String id = entry.GetId();
                String shortContent = entry.GetShortContent();

                contextMenu.Items.Add(shortContent);
                // Warning !! ****    ****    ****    might asigned tag to deferent element
                contextMenu.Items[i + 2].Tag = id;
            }
        }

        // delete unnecesery items from ListBoxes and/or generate new ones
        private void GenerateListBoxElements()
        {
            lbText.Items.Clear();
            lbFilesAndFolders.Items.Clear();

            foreach(Entry e in document.GetEntries())
            {
                if (e is TextEntry)
                {
                    lbText.Items.Add(e);
                }
                else if (e is FileFolderEntry)
                {
                    lbFilesAndFolders.Items.Add(e);
                }
                
            }
        }

        // calculate proper position of the form acording to screen size (resolution)
        private void SetPosition()
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            width = resolution.Width;
            height = resolution.Height;

            if (rbBotomLeft.Checked == true)
            {
                this.SetDesktopLocation(0, height - 510);
            }
            else if (rbBotomRight.Checked == true)
            {
                this.SetDesktopLocation(width - 590, height - 510);
            }
            else if (rbTopLeft.Checked == true)
            {
                this.SetDesktopLocation(0, 0);
            }
            else if (rbTopRight.Checked == true)
            {
                this.SetDesktopLocation(width - 590, 0);
            }
        }

        // this will hide window frame
        // without this, when app is minimized to try, the frame will remain shown
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        // serialize the state of the elements on the form as plain text
        // ex: sheckboxes, radio buttons, etc...
        private void FormSerialization()
        {
            // ***    ****   ***  why tmp[] is 13 objects here, but on deserialiation it is only 11?
            // need more investigation
            string[] tmp = new string[13];

            bool checktl = rbTopLeft.Checked;
            if (checktl)
            {
                tmp[0] = "1";
            }
            else
            {
                tmp[0] = "0";
            }

            bool checktr = rbTopRight.Checked;
            if (checktr)
            {
                tmp[1] = "1";
            }
            else
            {
                tmp[1] = "0";
            }

            bool checkbl = rbBotomLeft.Checked;
            if (checkbl)
            {
                tmp[2] = "1";
            }
            else
            {
                tmp[2] = "0";
            }

            bool checkbr = rbBotomRight.Checked;
            if (checkbr)
            {
                tmp[3] = "1";
            }
            else
            {
                tmp[3] = "0";
            }

            bool checkByItems = rbSortByTime.Checked;
            if (checkByItems)
            {
                tmp[4] = "1";
            }
            else
            {
                tmp[4] = "0";
            }

            bool checkByCategory = rbSortByCategory.Checked;
            if (checkByCategory)
            {
                tmp[5] = "1";
            }
            else
            {
                tmp[5] = "0";
            }

            bool checkTextFirst = rbFirstText.Checked;
            if (checkTextFirst)
            {
                tmp[6] = "1";
            }
            else
            {
                tmp[6] = "0";
            }

            bool checkFilesFirst = rbFilesAndFoldersFirst.Checked;
            if (checkFilesFirst)
            {
                tmp[7] = "1";
            }
            else
            {
                tmp[7] = "0";
            }

            bool checkText = cbText.Checked;
            if (checkText)
            {
                tmp[8] = "1";
            }
            else
            {
                tmp[8] = "0";
            }

            bool checkFiles = cbFilesAndFolders.Checked;
            if (checkFiles)
            {
                tmp[9] = "1";
            }
            else
            {
                tmp[9] = "0";
            }

            int nitems = (int)nudHistorySize.Value;
            tmp[10] = nitems.ToString();

            bool checkHistory = cbRememberHistory.Checked;
            if (checkHistory)
            {
                tmp[11] = "1";
            }
            else
            {
                tmp[11] = "0";
            }

            System.IO.File.WriteAllLines(setap, tmp);
        }

        // show context menu on right mouse click (automatic behaviour)
        // show form on left click
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
                this.SetPosition();
            }
        }

        // show form on contextMenu show button click
        private void contextMenuShowHideBtn_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.SetPosition();
        }

        // put content back to the clipboard on context menu item click
        private void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != contextMenu.Items[0] && e.ClickedItem != contextMenu.Items[1])
            {
                String id = e.ClickedItem.Tag.ToString();
                Entry entry = document.getById(id);

                if (entry is TextEntry)
                {
                    TextEntry castedEntry = entry as TextEntry;
                    Clipboard.SetText(castedEntry.GetContent());
                }
                else if (entry is FileFolderEntry)
                {
                    FileFolderEntry castedEntry = entry as FileFolderEntry;
                    Clipboard.SetFileDropList(castedEntry.GetContent());
                }
            }
            
        }

        // call closing method on top menu Exit button click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeApp = true;
            this.Close();
        }

        // call closing method on context menu Close button click
        private void contextMenuCloseBtn_Click(object sender, EventArgs e)
        {
            closeApp = true;
            this.Close();
        }

        // handle closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // prevent closing from red X button placed on window frame, but allow closing from context menu
            if (closeApp == true || e.CloseReason != CloseReason.UserClosing)
            {
                RemoveClipboardFormatListener(this.Handle);
                FormSerialization();
                if (cbRememberHistory.Checked == true)
                {
                    document.Serialize(history);
                }
                return;

            }
            e.Cancel = true;
            Hide();
        }

    }
}
