using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnnualLottery
{
    public partial class MainForm : Form
    {
        private int nCurrentLevel;
        private int nStartx;
        private int nStarty;
        private int nXspan;
        private int nYspan;
        private bool isRunning;
        private Image image;
        private CItemMamager cItemMgr;
        private int nDisplayCOunt;
        private bool isStart = false;
        private bool isInitialize = true;
        private bool[] m_RadioState = new bool[8];
        private RadioButton[] m_buttons = new RadioButton[8];
        public MainForm()
        {
            nStartx = 50;
            nStarty = 50;
            nXspan = 100;
            nYspan = 100;
            isRunning = false;
            InitializeComponent();

            // init button arrays
           
            m_buttons[0] = this.SeventhLevel;
            m_buttons[1] = this.SixthLevel;
            m_buttons[2] = this.FifthLevel;   
            m_buttons[3] = this.ForthLevel;
            m_buttons[4] = this.ThirdLevel;
            m_buttons[5] = this.SecondLevel;
            m_buttons[6] = this.FirstLevel;
            m_buttons[7] = this.ZeroLevel;

            cItemMgr = new CItemMamager();
            nDisplayCOunt = cItemMgr.DisplayCount;
            cItemMgr.panel = MainSplit.Panel2;
            cItemMgr.form = this;
            if (cItemMgr.LoadUserInformation(false) == false)
            {
                MessageBox.Show("Read user information failed");
                this.Close();
            }

            // add buttons into panel   
            InitButtons(cItemMgr.LevelCount);

            nCurrentLevel = cItemMgr.LevelCount - 8;
            cItemMgr.SetCurrentDealLevel(nCurrentLevel);
            nDisplayCOunt = cItemMgr.DisplayCount;
            int displayIndex = nCurrentLevel;
            m_buttons[displayIndex].Checked = true;
            ChangeRadioButtonBackColor(m_buttons[displayIndex]);

            Control.CheckForIllegalCrossThreadCalls = false;

            labelInfo.BackColor = Color.FromArgb(206, 0, 12);
            labelInfo.Text = cItemMgr.GetHead();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void InitButtons(int levelCount)
        {
            // add buttons
            for (int i = 0; i < levelCount; i++)
            {
                this.LayoutPanel2.Controls.Add(m_buttons[i], i + 1, 0);
            }
            FirstLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            SecondLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            ThirdLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            ForthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            FifthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            SixthLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            SeventhLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
            ZeroLevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30f, FontStyle.Bold);
        }

        private void StoreRadioState()
        {
            m_RadioState[0] = ZeroLevel.Enabled;
            m_RadioState[1] = FirstLevel.Enabled;
            m_RadioState[2] = SecondLevel.Enabled;
            m_RadioState[3] = ThirdLevel.Enabled;
            m_RadioState[4] = ForthLevel.Enabled;
            m_RadioState[5] = FifthLevel.Enabled;
            m_RadioState[6] = SixthLevel.Enabled;
            m_RadioState[7] = SeventhLevel.Enabled;
           
        }
        private void ReStoreRadioState()
        {
            ZeroLevel.Enabled = m_RadioState[0];
            FirstLevel.Enabled = m_RadioState[1];
            SecondLevel.Enabled = m_RadioState[2];
            ThirdLevel.Enabled = m_RadioState[3];
            ForthLevel.Enabled = m_RadioState[4];
            FifthLevel.Enabled = m_RadioState[5];
            SixthLevel.Enabled = m_RadioState[6];
            SeventhLevel.Enabled = m_RadioState[7];
        }
        private void Onpaint(object sender, PaintEventArgs e)
        {
            int nDisplayCount = nDisplayCOunt;
            if (this.cItemMgr.lineNumer == ShowLineNumber.twoLine || this.cItemMgr.lineNumer == ShowLineNumber.threeLine)
            {
                int lineNumber =  (int) this.cItemMgr.lineNumer;
                nDisplayCount = nDisplayCOunt / lineNumber;

                if (nDisplayCOunt % lineNumber != 0)
                {
                    nDisplayCount++;
                }
            }
            
            Panel panel = this.MainSplit.Panel2;
            this.image = new Bitmap(panel.Width, panel.Height);
            Graphics g = Graphics.FromImage(image);
            //g.Clear(this.BackColor);
            g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
            Graphics graph = panel.CreateGraphics();
            Pen BluePen = new Pen(Color.Blue, 1);
            BluePen.DashStyle = DashStyle.Dot;
            Font font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
           // Font fontTemp = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);

            font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);

            if (cItemMgr.IsRunningOn)
            {
                isStart = true;
            }
            if ( isInitialize)
            {
                Font fontRuuing = new Font(FontFamily.GenericSansSerif, 55.0F, FontStyle.Bold);
                string awardName = cItemMgr.GetawardName(isInitialize);
                StringFormat fontFormat = new StringFormat();
                fontFormat.Alignment = StringAlignment.Center;
                fontFormat.LineAlignment = StringAlignment.Center;
               // public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format);
                g.DrawString(awardName, fontRuuing, Brushes.Black, new RectangleF(0, 0, panel.Width, panel.Height), fontFormat);
               
            }
            else 
            {
                if (nDisplayCount == 1)
                {
                    font = new Font(FontFamily.GenericSansSerif, 55.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 2)
                {
                    font = new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 3)
                {
                    font = new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 4)
                {
                    font = new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 5)
                {
                    font = new Font(FontFamily.GenericSansSerif, 35.0F, FontStyle.Bold);
                }
                else if (nDisplayCount >= 6 && nDisplayCount < 8)
                {
                    font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 8)
                {
                    font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 9)
                {
                    font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
                }
                else if (nDisplayCount >= 10 && nDisplayCount < 15)
                {
                    font = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
                }
                else if (nDisplayCount >= 15 && nDisplayCount < 20)
                {
                    font = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
                }
                else if (nDisplayCount >= 20 && nDisplayCount < 25)
                {
                    font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold);
                }
                else if (nDisplayCount >= 25 && nDisplayCount < 30)
                {
                    font = new Font(FontFamily.GenericSansSerif, 6.0F, FontStyle.Bold);
                }
                else if (nDisplayCount == 30)
                {
                    font = new Font(FontFamily.GenericSansSerif, 3.0F, FontStyle.Bold);
                }
                nXspan = (this.MainSplit.Panel2.Width - 100) / 3;
                nYspan = (this.MainSplit.Panel2.Height - 50) / nDisplayCount;
                if (nDisplayCOunt == 1)
                {
                    CItem item = this.cItemMgr.GetItmeByIndex(0);
                    string str = item.CName;
                    float nSize = font.SizeInPoints;
                    int width = (int)font.GetHeight();
                    nStartx = (panel.Width - str.Length * width) / 2;
                    nStarty = 50;
                    for (int i = 0; i < str.Length; ++i)
                    {
                        g.DrawString(str.Substring(i, 1), font, Brushes.Black, nStartx + i * width, 40);
                    }
                    str = item.EName;
                    width = (int)(font.GetHeight() * 0.65);
                    nStartx = (int)((panel.Width - str.Length * font.Size * 0.7) / 2);


                    g.DrawString(str, font, Brushes.Black, nStartx, (panel.Height - 200) / 3 + 80);
                    str = item.CDpart;
                    nStartx = (panel.Width - str.Length * width) / 2;
                    Font font2 = new Font(FontFamily.GenericSansSerif, 50.0F, FontStyle.Bold);

                    g.DrawString(str, font, Brushes.Black, nStartx, 2 * (panel.Height - 200) / 3 + 120);
                }
                else
                {
                    nStartx = 50;
                    int nStartyForLine = 20;
                    float fontSize = font.Size;
                    nStarty = (int)(20 - font.GetHeight() + nYspan);
                    if (this.cItemMgr.lineNumer == ShowLineNumber.threeLine)
                    {
                        for (int i = 0; i < nDisplayCount; ++i)
                        {
                            CItem item = this.cItemMgr.GetItmeByIndex(i);                           
                            g.DrawLine(BluePen, nStartx, nStartyForLine + nYspan * (i + 1), this.MainSplit.Panel2.Width - nStartx, nStartyForLine + nYspan * (i + 1));
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            Font fontTemp =  FontSize(item.CName, font);
                            g.DrawString(item.CName, fontTemp, Brushes.Black, nStartx, nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("0.4"), nStarty + i * nYspan);
                            // g.DrawString(item.CDpart, font, Brushes.Black, nStartx + nXspan * float.Parse("2.8"), nStarty + i * nYspan);

                            item = this.cItemMgr.GetItmeByIndex(i + nDisplayCount);
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            fontTemp = FontSize(item.CName, font);
                            g.DrawString(item.CName, fontTemp, Brushes.Black, nStartx + nXspan * float.Parse("1.1"), nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("1.5"), nStarty + i * nYspan);

                            item = this.cItemMgr.GetItmeByIndex(i + nDisplayCount * 2);
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            fontTemp = FontSize(item.CName, font);
                            g.DrawString(item.CName, fontTemp, Brushes.Black, nStartx + nXspan * float.Parse("2.2"), nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("2.6"), nStarty + i * nYspan);
                        }
                    }
                    else if (this.cItemMgr.lineNumer == ShowLineNumber.twoLine)
                    {
                        for (int i = 0; i < nDisplayCount; ++i)
                        {
                            CItem item = this.cItemMgr.GetItmeByIndex(i);
                            g.DrawLine(BluePen, nStartx, nStartyForLine + nYspan * (i + 1), this.MainSplit.Panel2.Width - nStartx, nStartyForLine + nYspan * (i + 1));
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            g.DrawString(item.CName, font, Brushes.Black, nStartx, nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("0.5"), nStarty + i * nYspan);
                            // g.DrawString(item.CDpart, font, Brushes.Black, nStartx + nXspan * float.Parse("2.8"), nStarty + i * nYspan);

                            item = this.cItemMgr.GetItmeByIndex(i + nDisplayCount);
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            g.DrawString(item.CName, font, Brushes.Black, nStartx + nXspan * float.Parse("1.8"), nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("2.3"), nStarty + i * nYspan);
                            //  g.DrawString(bothItem.CDpart, font, Brushes.Black, nStartx + nXspan * float.Parse("2.8"), nStarty + i * nYspan);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < nDisplayCount; ++i)
                        {
                            CItem item = this.cItemMgr.GetItmeByIndex(i);
                            g.DrawLine(BluePen, nStartx, nStartyForLine + nYspan * (i + 1), this.MainSplit.Panel2.Width - nStartx, nStartyForLine + nYspan * (i + 1));
                            if (item.UserID == "")
                            {
                                continue;
                            }
                            g.DrawString(item.CName, font, Brushes.Black, nStartx, nStarty + i * nYspan);
                            g.DrawString(item.EName, font, Brushes.Black, nStartx + nXspan * float.Parse("1.5"), nStarty + i * nYspan);
                            g.DrawString(item.CDpart, font, Brushes.Black, nStartx + nXspan * float.Parse("2.8"), nStarty + i * nYspan);
                        }
                    }
                }
            }
            graph.DrawImage(image, 0, 0, panel.Width, panel.Height);

            if (!cItemMgr.IsRunningOn && isStart)
            {
                isStart = false;
                Savepicture();
            }
          
        }

        public Font FontSize(string itemName,Font font) 
        {
            if (itemName.Length > 10)
            {
                font = new Font(FontFamily.GenericSansSerif, font.Size - 3, FontStyle.Bold);
            }
            else if (itemName.Length > 5)
            {
                font = new Font(FontFamily.GenericSansSerif, font.Size - 1, FontStyle.Bold);
            }

            return font;
        }

        private void DoAction()
        {
            if (isRunning)
            {
                cItemMgr.StopThread();
                isRunning = false;
                EnableTheRadioButton(true);
            }
            else
            {
                if (cItemMgr.StrartThread())
                {
                    isRunning = true;
                    EnableTheRadioButton(false);
                }
            }
            this.MainSplit.Panel2.Invalidate(new Rectangle(0, 0, 1, 1));
        }

        private void Level_CheckedChanged(object sender, EventArgs e)
        {
            isInitialize = true;
            button1.Enabled = true;
            button2.Enabled = false;
            Panel panel = this.MainSplit.Panel2;
            Graphics graph = panel.CreateGraphics();
            if (ZeroLevel.Checked)
            {
                nCurrentLevel = 0;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (FirstLevel.Checked)
            {
                nCurrentLevel = 1;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (SecondLevel.Checked)
            {
                nCurrentLevel = 2;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (ThirdLevel.Checked)
            {
                nCurrentLevel = 3;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (ForthLevel.Checked)
            {
                nCurrentLevel = 4;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (FifthLevel.Checked)
            {
                nCurrentLevel = 5;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (SixthLevel.Checked)
            {
                nCurrentLevel = 6;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }
            else if (SeventhLevel.Checked)
            {
                nCurrentLevel = 7;
                labelInfo.Text = cItemMgr.GetHead();
                this.image = new Bitmap(panel.Width, panel.Height);
                Graphics g = Graphics.FromImage(image);
                //g.Clear(this.BackColor);
                g.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
                graph.DrawImage(image, 0, 0, panel.Width, panel.Height);
            }

            ChangeRadioButtonBackColor(ZeroLevel);
            ChangeRadioButtonBackColor(FirstLevel);
            ChangeRadioButtonBackColor(SecondLevel);
            ChangeRadioButtonBackColor(ThirdLevel);
            ChangeRadioButtonBackColor(ForthLevel);
            ChangeRadioButtonBackColor(FifthLevel);
            ChangeRadioButtonBackColor(SixthLevel);
            ChangeRadioButtonBackColor(SeventhLevel);

            cItemMgr.SetCurrentDealLevel(nCurrentLevel);
            nDisplayCOunt = cItemMgr.DisplayCount;
            cItemMgr.ClearItem();
            this.MainSplit.Panel2.Invalidate(new Rectangle(0, 0, 1, 1));
        }
        private void ChangeRadioButtonBackColor(RadioButton radio)
        {
            if (radio.Enabled == false)
            {
                radio.BackColor = Color.FromArgb(168, 168, 168);   //Color.MistyRose;
                radio.ForeColor = Color.Black;
            }
            else
                if (radio.Checked)
                {
                    radio.BackColor = Color.FromArgb(254, 143, 1);
                    radio.ForeColor = Color.White;
                }
                else
                {
                    radio.BackColor = Color.FromArgb(255, 27, 0);
                    radio.ForeColor = Color.Black;
                }          
        }
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            cItemMgr.StopThread();
        }
        private void EnableTheRadioButton(bool value)
        {
            if (value)
            {
                ReStoreRadioState();
            }
            else
            {
                StoreRadioState();
                this.ZeroLevel.Enabled = this.ZeroLevel.Checked;
                this.FirstLevel.Enabled = this.FirstLevel.Checked;
                this.SecondLevel.Enabled = this.SecondLevel.Checked;
                this.ThirdLevel.Enabled = this.ThirdLevel.Checked;
                this.ForthLevel.Enabled = this.ForthLevel.Checked;
                this.FifthLevel.Enabled = this.FifthLevel.Checked;
                this.SixthLevel.Enabled = this.SixthLevel.Checked;
                this.SeventhLevel.Enabled = this.SeventhLevel.Checked;



                //this.ZeroLevel.Enabled = value;
                //this.FirstLevel.Enabled = value;
                //this.SecondLevel.Enabled = value;
                //this.ThirdLevel.Enabled = value;
                //this.ForthLevel.Enabled = value;
                //this.FifthLevel.Enabled = value;
                //this.SixthLevel.Enabled = value;
                //this.SeventhLevel.Enabled = value;

            }

        }
        public void DisableTheRadioButton(int nIndex)
        {
            try
            {
                switch (nIndex)
                {
                    case 0:
                         m_RadioState[0] = false;
                         ZeroLevel.Enabled = false;
                         ZeroLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 1:
                         m_RadioState[1] = false;
                         FirstLevel.Enabled = false;
                         FirstLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 2:
                        m_RadioState[2] = false;
                        SecondLevel.Enabled = false;
                        SecondLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 3:
                        m_RadioState[3] = false;
                        ThirdLevel.Enabled = false;
                        ThirdLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 4:
                         m_RadioState[4] = false;
                         ForthLevel.Enabled = false;
                         ForthLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 5:
                        m_RadioState[5] = false;
                        FifthLevel.Enabled = false;
                        FifthLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 6:
                        m_RadioState[6] = false;
                        SixthLevel.Enabled = false;
                        SixthLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                    case 7:
                        m_RadioState[7] = false;
                        SeventhLevel.Enabled = false;
                        SeventhLevel.BackColor = Color.FromArgb(168, 168, 168);;
                        break;
                }
                button1.Enabled = false;
            }
            catch { }
        }

        private void SetHotKey(Keys key)
        {
            try
            {
                WinHotKey.KeyModifiers modifier = WinHotKey.KeyModifiers.None;
                WinHotKey.RegisterHotKey(Handle, 100, modifier, key);
            }
            catch (Exception err)
            {
                MessageBox.Show("register hot key failed");
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.HWnd == this.Handle)
            {
                if (m.Msg == 786)
                {
                    DoAction();
                }
            }
            base.WndProc(ref m);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                if (isRunning)
                {
                    button2_Click(null, null);
                }
                else
                {
                    button1_Click(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoAction();
            labelInfo.Text = cItemMgr.GetHead();
            button1.Enabled = false;
            button2.Enabled = true;
            isInitialize = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoAction();
            labelInfo.Text = cItemMgr.GetHead();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        public void Savepicture()
        {
            string PictureName = cItemMgr.GetPictureName();

            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                Graphics g = System.Drawing.Graphics.FromImage(bmp);
                g.DrawImage(this.image, this.Width - image.Width, this.Height - image.Height, image.Width, image.Height);
                bmp.Save(PictureName, ImageFormat.Png); // make sure path exists!
            }
        }

        private void UpDownSliptContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class WinHotKey
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
        IntPtr hWnd,   //窗口句柄  
        int id,
        KeyModifiers fsModifiers,
        Keys vk
        );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
        IntPtr hWnd,
        int id
        );

        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        public WinHotKey()
        {
            //  
            //   TODO:   在此处添加构造函数逻辑  
            //  
        }
    }
}