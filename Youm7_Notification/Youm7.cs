using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Youm7_Notification.Properties;

namespace Youm7_Notification
{
	public class Youm7 : Form
	{
		private const int WS_EX_TOPMOST = 8;

		private IContainer components = null;

		private Button button2;

		private PictureBox pictureBox1;

		private NotifyIcon notifyIcon1;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem youm7comاذهباليToolStripMenuItem;

		private ToolStripMenuItem كتمالصوتToolStripMenuItem;

		private ToolStripMenuItem بدءمعالكمبيوترToolStripMenuItem;

		private ToolStripMenuItem نعمToolStripMenuItem;

		private ToolStripMenuItem لاToolStripMenuItem;

		private ToolStripMenuItem ايقافمؤقتToolStripMenuItem;

		private ToolStripMenuItem ربعساعةToolStripMenuItem;

		private ToolStripMenuItem نصفساعةToolStripMenuItem;

		private ToolStripMenuItem ساعةكاملةToolStripMenuItem;

		private ToolStripMenuItem الغاءالايقافالمؤقتToolStripMenuItem;

		private ToolStripMenuItem خروجToolStripMenuItem;

		private Button button3;

		private Button button4;

		private LinkLabel linkLabel1;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem مننحنToolStripMenuItem;

		private ToolStripMenuItem تغيراللغةToolStripMenuItem;

		private ToolStripMenuItem العربيةToolStripMenuItem;

		private ToolStripMenuItem englishToolStripMenuItem;

		private FontFamily ff;

		private Font font1;

		private Timer timer;

		private int startPosX;

		private int startPosY;

		private int posFlag = 0;

		private int counttick = 300;

		private int sound_flag = 1;

		private int shown_news = 7;

		private bool first_run = true;

		private string story_link = null;

		private bool chkStartUp = true;

		private ArrayList[] latest = new ArrayList[8];

		private int story_numbr = 9;

		private string TopStory = null;

		private string TopStory2 = null;

		private string Title_main;

		private int mute_counter = 0;

		private Timer t;

		private string mac_adress;

		private int NewsID = 0;

		private int UserID = 0;

		private int SessionID = 0;

		private int firsterror = 0;

		private string version = "1.0.0.3";

		private string security = "gD@$f@g2hj";

		private PrivateFontCollection pfc = new PrivateFontCollection();

		private int Language = 0;

		private string st;

		private string sl;

		private int nid;

		protected override bool ShowWithoutActivation
		{
			get
			{
				return true;
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 8;
				return createParams;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Youm7));
			this.button2 = new Button();
			this.pictureBox1 = new PictureBox();
			this.notifyIcon1 = new NotifyIcon(this.components);
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.youm7comاذهباليToolStripMenuItem = new ToolStripMenuItem();
			this.كتمالصوتToolStripMenuItem = new ToolStripMenuItem();
			this.ايقافمؤقتToolStripMenuItem = new ToolStripMenuItem();
			this.ربعساعةToolStripMenuItem = new ToolStripMenuItem();
			this.نصفساعةToolStripMenuItem = new ToolStripMenuItem();
			this.ساعةكاملةToolStripMenuItem = new ToolStripMenuItem();
			this.الغاءالايقافالمؤقتToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.بدءمعالكمبيوترToolStripMenuItem = new ToolStripMenuItem();
			this.نعمToolStripMenuItem = new ToolStripMenuItem();
			this.لاToolStripMenuItem = new ToolStripMenuItem();
			this.تغيراللغةToolStripMenuItem = new ToolStripMenuItem();
			this.العربيةToolStripMenuItem = new ToolStripMenuItem();
			this.englishToolStripMenuItem = new ToolStripMenuItem();
			this.مننحنToolStripMenuItem = new ToolStripMenuItem();
			this.خروجToolStripMenuItem = new ToolStripMenuItem();
			this.button3 = new Button();
			this.button4 = new Button();
			this.linkLabel1 = new LinkLabel();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.button2.Anchor = AnchorStyles.None;
			this.button2.BackColor = Color.Transparent;
			this.button2.BackgroundImageLayout = ImageLayout.Center;
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Location = new Point(6, 1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(20, 22);
			this.button2.TabIndex = 1;
			this.button2.TextImageRelation = TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox1.Cursor = Cursors.Hand;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new Point(8, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(60, 16);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = (Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "Youm7";
			this.notifyIcon1.Visible = true;
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.youm7comاذهباليToolStripMenuItem,
				this.كتمالصوتToolStripMenuItem,
				this.ايقافمؤقتToolStripMenuItem,
				this.toolStripSeparator1,
				this.بدءمعالكمبيوترToolStripMenuItem,
				this.تغيراللغةToolStripMenuItem,
				this.مننحنToolStripMenuItem,
				this.خروجToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(165, 186);
			this.youm7comاذهباليToolStripMenuItem.Name = "youm7comاذهباليToolStripMenuItem";
			this.youm7comاذهباليToolStripMenuItem.Size = new Size(164, 22);
			this.youm7comاذهباليToolStripMenuItem.Text = "موقع اليوم السابع ";
			this.youm7comاذهباليToolStripMenuItem.Click += new EventHandler(this.youm7comاذهباليToolStripMenuItem_Click);
			this.كتمالصوتToolStripMenuItem.Name = "كتمالصوتToolStripMenuItem";
			this.كتمالصوتToolStripMenuItem.Size = new Size(164, 22);
			this.كتمالصوتToolStripMenuItem.Text = "كتم الصوت";
			this.كتمالصوتToolStripMenuItem.Click += new EventHandler(this.كتمالصوتToolStripMenuItem_Click);
			this.ايقافمؤقتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ربعساعةToolStripMenuItem,
				this.نصفساعةToolStripMenuItem,
				this.ساعةكاملةToolStripMenuItem,
				this.الغاءالايقافالمؤقتToolStripMenuItem
			});
			this.ايقافمؤقتToolStripMenuItem.Name = "ايقافمؤقتToolStripMenuItem";
			this.ايقافمؤقتToolStripMenuItem.Size = new Size(164, 22);
			this.ايقافمؤقتToolStripMenuItem.Text = "ايقاف مؤقت";
			this.ربعساعةToolStripMenuItem.Name = "ربعساعةToolStripMenuItem";
			this.ربعساعةToolStripMenuItem.Size = new Size(174, 22);
			this.ربعساعةToolStripMenuItem.Text = "ربع ساعة";
			this.ربعساعةToolStripMenuItem.Click += new EventHandler(this.ربعساعةToolStripMenuItem_Click);
			this.نصفساعةToolStripMenuItem.Name = "نصفساعةToolStripMenuItem";
			this.نصفساعةToolStripMenuItem.Size = new Size(174, 22);
			this.نصفساعةToolStripMenuItem.Text = "نصف ساعة";
			this.نصفساعةToolStripMenuItem.Click += new EventHandler(this.نصفساعةToolStripMenuItem_Click);
			this.ساعةكاملةToolStripMenuItem.Name = "ساعةكاملةToolStripMenuItem";
			this.ساعةكاملةToolStripMenuItem.Size = new Size(174, 22);
			this.ساعةكاملةToolStripMenuItem.Text = "ساعة كاملة";
			this.ساعةكاملةToolStripMenuItem.Click += new EventHandler(this.ساعةكاملةToolStripMenuItem_Click);
			this.الغاءالايقافالمؤقتToolStripMenuItem.Name = "الغاءالايقافالمؤقتToolStripMenuItem";
			this.الغاءالايقافالمؤقتToolStripMenuItem.Size = new Size(174, 22);
			this.الغاءالايقافالمؤقتToolStripMenuItem.Text = "الغاء الايقاف المؤقت";
			this.الغاءالايقافالمؤقتToolStripMenuItem.Click += new EventHandler(this.الغاءالايقافالمؤقتToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(161, 6);
			this.بدءمعالكمبيوترToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.نعمToolStripMenuItem,
				this.لاToolStripMenuItem
			});
			this.بدءمعالكمبيوترToolStripMenuItem.Name = "بدءمعالكمبيوترToolStripMenuItem";
			this.بدءمعالكمبيوترToolStripMenuItem.Size = new Size(164, 22);
			this.بدءمعالكمبيوترToolStripMenuItem.Text = "بدء مع الكمبيوتر";
			this.نعمToolStripMenuItem.Name = "نعمToolStripMenuItem";
			this.نعمToolStripMenuItem.Size = new Size(92, 22);
			this.نعمToolStripMenuItem.Text = "نعم";
			this.نعمToolStripMenuItem.Click += new EventHandler(this.نعمToolStripMenuItem_Click);
			this.لاToolStripMenuItem.Name = "لاToolStripMenuItem";
			this.لاToolStripMenuItem.Size = new Size(92, 22);
			this.لاToolStripMenuItem.Text = "لا";
			this.لاToolStripMenuItem.Click += new EventHandler(this.لاToolStripMenuItem_Click);
			this.تغيراللغةToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.العربيةToolStripMenuItem,
				this.englishToolStripMenuItem
			});
			this.تغيراللغةToolStripMenuItem.Name = "تغيراللغةToolStripMenuItem";
			this.تغيراللغةToolStripMenuItem.Size = new Size(164, 22);
			this.تغيراللغةToolStripMenuItem.Text = "اللغة";
			this.العربيةToolStripMenuItem.Name = "العربيةToolStripMenuItem";
			this.العربيةToolStripMenuItem.Size = new Size(152, 22);
			this.العربيةToolStripMenuItem.Text = "العربية";
			this.العربيةToolStripMenuItem.Click += new EventHandler(this.العربيةToolStripMenuItem_Click);
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new Size(152, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new EventHandler(this.englishToolStripMenuItem_Click);
			this.مننحنToolStripMenuItem.Name = "مننحنToolStripMenuItem";
			this.مننحنToolStripMenuItem.Size = new Size(164, 22);
			this.مننحنToolStripMenuItem.Text = "من نحن ";
			this.مننحنToolStripMenuItem.Click += new EventHandler(this.مننحنToolStripMenuItem_Click);
			this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
			this.خروجToolStripMenuItem.Size = new Size(164, 22);
			this.خروجToolStripMenuItem.Text = "خروج";
			this.خروجToolStripMenuItem.Click += new EventHandler(this.خروجToolStripMenuItem_Click);
			this.button3.BackColor = Color.Transparent;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.Image = Resources.GRAY_Arrow_Right;
			this.button3.Location = new Point(277, 46);
			this.button3.Name = "button3";
			this.button3.Size = new Size(16, 27);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.BackColor = Color.Transparent;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.Image = Resources.GRAY_Arrow_Left;
			this.button4.Location = new Point(6, 46);
			this.button4.Name = "button4";
			this.button4.Size = new Size(16, 27);
			this.button4.TabIndex = 5;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.linkLabel1.ActiveLinkColor = Color.Black;
			this.linkLabel1.BackColor = Color.Transparent;
			this.linkLabel1.Cursor = Cursors.Hand;
			this.linkLabel1.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.linkLabel1.ForeColor = Color.White;
			this.linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
			this.linkLabel1.LinkColor = Color.Black;
			this.linkLabel1.Location = new Point(28, 37);
			this.linkLabel1.Name = "linkLabel1";
			//this.linkLabel1.RightToLeft = RightToLeft.Yes;
			this.linkLabel1.Size = new Size(235, 45);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "News";
			this.linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
			this.linkLabel1.VisitedLinkColor = Color.Black;
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
//			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Resources.Youm_7_Notification_BOX_Updated;
			base.ClientSize = new Size(300, 100);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button2);
//			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Youm7";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
//			base.SizeGripStyle = SizeGripStyle.Hide;
			this.Text = "اليوم السابع ";
			base.FormClosed += new FormClosedEventHandler(this.Youm7_FormClosed);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		[DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

		public Youm7()
		{
			this.InitializeComponent();
			this.t = new Timer();
			this.t.Interval = 60000;
			this.t.Tick += new EventHandler(this.t_Tick);
			base.ControlBox = false;
			base.MinimizeBox = false;
			base.MaximizeBox = false;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.timer = new Timer();
			this.timer.Interval = 50;
			this.timer.Tick += new EventHandler(this.timer_Tick);
			base.Load += new EventHandler(this.Form1_Load);
			this.notifyIcon1.MouseClick += new MouseEventHandler(this.notifyIcon1_MouseClick);
			this.button3.MouseEnter += new EventHandler(this.button3_MouseEnter);
			this.button3.MouseLeave += new EventHandler(this.button3_MouseLeave);
			this.button4.MouseEnter += new EventHandler(this.button4_MouseEnter);
			this.button4.MouseLeave += new EventHandler(this.button4_MouseLeave);
			this.notifyIcon1.Icon = Resources.Youm7_square_logo;
		}

		private void button4_MouseLeave(object sender, EventArgs e)
		{
			this.button4.Image = Resources.GRAY_Arrow_Left;
		}

		private void button4_MouseEnter(object sender, EventArgs e)
		{
			this.button4.Image = Resources.RED_Arrow_Left;
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			this.button3.Image = Resources.GRAY_Arrow_Right;
		}

		private void button3_MouseEnter(object sender, EventArgs e)
		{
			this.button3.Image = Resources.RED_Arrow_02;
		}

		private void callstyle()
		{
			//base.Hide();
			//this.button4.Hide();
			base.Opacity = 0.0;
			this.SetStartup();
			this.startPosX = Screen.PrimaryScreen.WorkingArea.Width - base.Width;
			this.startPosY = Screen.PrimaryScreen.WorkingArea.Height - base.Height + 25;
			this.notifyIcon1.ContextMenuStrip.Items[0].Image = Resources.Site;
			this.notifyIcon1.ContextMenuStrip.Items[6].Image = Resources.About;
			this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_Off;
			this.notifyIcon1.ContextMenuStrip.Items[2].Image = Resources.UNLock;
			this.notifyIcon1.ContextMenuStrip.Items[4].Image = Resources.Pc_Start;
			this.notifyIcon1.ContextMenuStrip.Items[7].Image = Resources.Exit;
			if (Settings.Default.language == 1)
			{
				this.notifyIcon1.ContextMenuStrip.Items[5].Image = Resources.Ar;
			}
			else
			{
				this.notifyIcon1.ContextMenuStrip.Items[5].Image = Resources.En;
			}
			this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = true;
			base.FormBorderStyle = FormBorderStyle.None;
			this.button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.button3.BackColor = Color.Transparent;
			this.button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.button4.BackColor = Color.Transparent;
			this.button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.linkLabel1.BackColor = Color.Transparent;
			this.button2.TabStop = false;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
			this.button2.BackColor = Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.button2.FlatAppearance.CheckedBackColor = Color.Transparent;
			this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
			base.ShowInTaskbar = false;
			base.Opacity = 0.0;
			if (!Settings.Default.sound)
			{
				this.sound_flag = 0;
				this.notifyIcon1.ContextMenuStrip.Items[1].Text = "استخدام الصوت";
				this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_On;
			}
			else
			{
				this.sound_flag = 1;
				this.notifyIcon1.ContextMenuStrip.Items[1].Text = "كتم الصوت";
				this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_Off;
			}
			base.SetDesktopLocation(this.startPosX, this.startPosY);
			try
			{
				byte[] droidKufi_Bold = Resources.DroidKufi_Bold;
				int num = Resources.DroidKufi_Bold.Length;
				IntPtr intPtr = Marshal.AllocCoTaskMem(num);
				Marshal.Copy(droidKufi_Bold, 0, intPtr, num);
				uint num2 = 0u;
				Youm7.AddFontMemResourceEx(intPtr, (uint)droidKufi_Bold.Length, IntPtr.Zero, ref num2);
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddMemoryFont(intPtr, num);
				Marshal.FreeCoTaskMem(intPtr);
				this.ff = privateFontCollection.Families[0];
				this.font1 = new Font(this.ff, 8f);
				this.linkLabel1.Font = this.font1;
				this.linkLabel1.ForeColor = Color.FromArgb(0, 51, 51, 51);
			}
			catch
			{
			}
			if (this.sound_flag == 1)
			{
				new SoundPlayer(Resources.sounds_954_all_eyes_on_me).Play();
			}
			if (Settings.Default.language == 1)
			{
				this.Language = 1;
				this.العربيةToolStripMenuItem.Checked = false;
				this.englishToolStripMenuItem.Checked = true;
				this.notifyIcon1.ContextMenuStrip.Items[0].Text = "Go To Youm7.com";
				if (!Settings.Default.sound)
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Enable Sound";
				}
				else
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Disable Sound";
				}
				this.notifyIcon1.ContextMenuStrip.Items[2].Text = "Temporarily Disable";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[0].Text = "For 15 Minutes";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[1].Text = "For 30 Minutes";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[2].Text = "For 1 Hour";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[3].Text = "Enable The Application";
				this.notifyIcon1.ContextMenuStrip.Items[4].Text = "Automatic Startup";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[0].Text = "Yes";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[1].Text = "No";
				this.notifyIcon1.ContextMenuStrip.Items[5].Text = "Language";
				this.notifyIcon1.ContextMenuStrip.Items[6].Text = "About";
				this.notifyIcon1.ContextMenuStrip.Items[7].Text = "Exit";
			}
			else
			{
				this.العربيةToolStripMenuItem.Checked = true;
				this.englishToolStripMenuItem.Checked = false;
			}
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString(string.Concat(new object[]
				{
					"http://youm7app.youm7.com/Api.aspx?ID=",
					this.UserID,
					"&SEC=",
					this.security
				}));
				webClient.Dispose();
			}
			catch
			{
			}
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.counttick = 300;
				this.posFlag = 0;
				this.timer.Start();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 8; i++)
			{
				this.latest[i] = new ArrayList();
			}
			this.callstyle();
			this.TopStory = this.check_updates();
			this.linkLabel1.Text = this.TopStory;
			this.t.Start();
			this.timer.Start();
			this.Login();
		}

		private void t_Tick(object sender, EventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString(string.Concat(new object[]
				{
					"http://youm7app.youm7.com/Api.aspx?ID=",
					this.UserID,
					"&SEC=",
					this.security
				}));
				webClient.Dispose();
			}
			catch
			{
			}
			if (this.mute_counter <= 0)
			{
				this.notifyIcon1.Icon = Resources.Youm7_square_logo;
				this.ساعةكاملةToolStripMenuItem.Checked = false;
				this.نصفساعةToolStripMenuItem.Checked = false;
				this.ربعساعةToolStripMenuItem.Checked = false;
				this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = true;
				this.TopStory2 = this.check_updates();
				if (this.TopStory != this.TopStory2)
				{
					this.TopStory = this.TopStory2;
					this.update_news();
					if (this.story_numbr == -1)
					{
						this.story_numbr = 0;
					}
					this.shown_news = 0;
					this.button3.Show();
					this.button4.Hide();
					if (!this.first_run)
					{
						this.story_link = this.latest[0][1].ToString();
					}
					this.story_numbr--;
					this.linkLabel1.Text = this.TopStory;
					this.posFlag = 0;
					this.counttick = 300;
					if (this.sound_flag == 1)
					{
						new SoundPlayer(Resources.sounds_954_all_eyes_on_me).Play();
					}
					this.timer.Start();
				}
			}
			else
			{
				this.notifyIcon1.Icon = Resources.Youm7_square_logo_mute;
				this.mute_counter--;
				this.TopStory2 = this.check_updates();
				if (this.TopStory != this.TopStory2)
				{
					this.TopStory = this.TopStory2;
					this.update_news();
					if (this.story_numbr == -1)
					{
						this.story_numbr = 0;
					}
					this.shown_news = 0;
					this.button3.Show();
					this.button4.Hide();
					if (!this.first_run)
					{
						this.story_link = this.latest[0][1].ToString();
					}
					this.story_numbr--;
					this.linkLabel1.Text = this.TopStory;
				}
			}
		}

		public string check_updates()
		{
			string result;
			try
			{
				string text = null;
				using (WebClient webClient = new WebClient())
				{
					WebClient webClient2 = new WebClient();
					webClient2.Encoding = Encoding.UTF8;
					string json = webClient2.DownloadString("http://api.youm7.com/y7API.svc/TopStories");
					JObject jObject = JObject.Parse(json);
					this.Title_main = Convert.ToString(jObject["TopStoriesResult"][0]["Title"]);
					text = this.Title_main;
					this.story_link = Convert.ToString(jObject["TopStoriesResult"][0]["link"]);
					this.NewsID = int.Parse(jObject["TopStoriesResult"][0]["NewID"].ToString());
					if (this.first_run)
					{
						int num = jObject["TopStoriesResult"].Count<JToken>() - 1;
						for (int i = jObject["TopStoriesResult"].Count<JToken>() - 1; i > -1; i--)
						{
							this.st = Convert.ToString(jObject["TopStoriesResult"][num]["Title"]);
							this.sl = Convert.ToString(jObject["TopStoriesResult"][num]["link"]);
							this.nid = int.Parse(jObject["TopStoriesResult"][num]["NewID"].ToString());
							this.latest[i].Add(this.st);
							this.latest[i].Add(this.sl);
							this.latest[i].Add(this.nid);
							this.story_numbr--;
							num--;
						}
						this.story_numbr = 0;
						this.shown_news = 0;
						this.first_run = false;
					}
					jObject.RemoveAll();
					webClient2.Dispose();
					webClient.Dispose();
				}
				result = text;
			}
			catch
			{
				if (this.firsterror == 0)
				{
					if (this.Language == 0)
					{
						this.notifyIcon1.BalloonTipText = "خطأ في الإتصال بالإنترنت, برجاء التأكد من صلة الإنترنت و سيعمل البرنامج تلقائيا";
						this.notifyIcon1.ShowBalloonTip(30000);
					}
					else
					{
						this.notifyIcon1.BalloonTipText = "Connection Error, check your network connection and the application will run automatically";
						this.notifyIcon1.ShowBalloonTip(30000);
					}
					this.firsterror = 1;
				}
				result = this.TopStory;
			}
			return result;
		}

		public void update_news()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string json = webClient.DownloadString("http://api.youm7.com/y7API.svc/TopStories");
				JObject jObject = JObject.Parse(json);
				int num = jObject["TopStoriesResult"].Count<JToken>() - 1;
				for (int i = 0; i < 8; i++)
				{
					this.latest[i].Clear();
				}
				for (int i = jObject["TopStoriesResult"].Count<JToken>() - 1; i > -1; i--)
				{
					this.st = Convert.ToString(jObject["TopStoriesResult"][num]["Title"]);
					this.sl = Convert.ToString(jObject["TopStoriesResult"][num]["link"]);
					this.nid = int.Parse(jObject["TopStoriesResult"][num]["NewID"].ToString());
					this.latest[i].Add(this.st);
					this.latest[i].Add(this.sl);
					this.latest[i].Add(this.nid);
					num--;
				}
				webClient.Dispose();
				jObject.RemoveAll();
				this.story_numbr = 0;
				this.shown_news = 0;
			}
			catch
			{
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			this.t.Stop();
			if (this.first_run)
			{
				this.shown_news = 0;
				this.story_numbr = 0;
			}
			if (this.posFlag == 0)
			{
				base.Show();
				base.Opacity += 0.1;
			}
			if (this.counttick <= 0)
			{
				this.posFlag = 2;
			}
			if (this.posFlag == 2)
			{
				base.Opacity -= 0.1;
				if (base.Opacity <= 0.0)
				{
					base.Hide();
					this.posFlag = 0;
					this.t.Start();
					this.timer.Stop();
				}
			}
			if (this.posFlag == 1)
			{
				this.counttick--;
			}
			if (base.Opacity == 1.0)
			{
				this.posFlag = 1;
			}
		}

		private void SetStartup()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (this.chkStartUp)
			{
				registryKey.SetValue(base.Name, Application.ExecutablePath.ToString());
				this.لاToolStripMenuItem.Checked = false;
				this.نعمToolStripMenuItem.Checked = true;
			}
			if (!this.chkStartUp)
			{
				registryKey.DeleteValue(base.Name, false);
				this.نعمToolStripMenuItem.Checked = false;
				this.لاToolStripMenuItem.Checked = true;
			}
		}

		private void youm7comاذهباليToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "سيتم تحويلكم على الصفحة فورا";
				this.notifyIcon1.ShowBalloonTip(30000);
				Process.Start("http://youm7.com/");
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "Opening The Webpage";
				this.notifyIcon1.ShowBalloonTip(30000);
				Process.Start("http://youm7.com/");
			}
		}

		private void كتمالصوتToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.sound_flag == 1)
			{
				if (this.Language == 0)
				{
					this.sound_flag = 0;
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "استخدام الصوت";
					this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_On;
					this.notifyIcon1.BalloonTipText = "تم كتم الصوت";
					this.notifyIcon1.ShowBalloonTip(30000);
					Settings.Default["sound"] = false;
					Settings.Default.Save();
				}
				else
				{
					this.sound_flag = 0;
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Enable Sound";
					this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_On;
					this.notifyIcon1.BalloonTipText = "Sound is Disabled";
					this.notifyIcon1.ShowBalloonTip(30000);
					Settings.Default["sound"] = false;
					Settings.Default.Save();
				}
			}
			else if (this.sound_flag == 0)
			{
				if (this.Language == 0)
				{
					this.sound_flag = 1;
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "كتم الصوت";
					this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_Off;
					this.notifyIcon1.BalloonTipText = "تم إتاحةالصوت";
					this.notifyIcon1.ShowBalloonTip(30000);
					Settings.Default["sound"] = true;
					Settings.Default.Save();
				}
				else
				{
					this.sound_flag = 1;
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Disable Sound";
					this.notifyIcon1.ContextMenuStrip.Items[1].Image = Resources.Sound_Off;
					this.notifyIcon1.BalloonTipText = "Sound is Enabled";
					this.notifyIcon1.ShowBalloonTip(30000);
					Settings.Default["sound"] = true;
					Settings.Default.Save();
				}
			}
		}

		private void نعمToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chkStartUp = true;
			this.SetStartup();
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "عند فتح الكمبيوتر المره القادمة سوف يبدأ البرنامج تلقائيا";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The application will be automatically launched on the next computer startup";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void لاToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chkStartUp = false;
			this.SetStartup();
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "عند فتح الكمبيوتر المره القادمة لن يبدأ البرنامج تلقائيا";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The application will not start automatically on the next computer startup";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void ربعساعةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Icon = Resources.Youm7_square_logo_mute;
			this.notifyIcon1.ContextMenuStrip.Items[2].Image = Resources.Lock;
			this.mute_counter = 15;
			this.ربعساعةToolStripMenuItem.Checked = true;
			this.ساعةكاملةToolStripMenuItem.Checked = false;
			this.نصفساعةToolStripMenuItem.Checked = false;
			this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = false;
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "تم تفعيل الايقاف المؤقت لمدة ربع ساعة - يمكنكم متابعة الأخبار عند الضغط على الأيقونة";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The notifications is temporarily disabled for 15 minutes - To check the latest news, left-click on the Icon in the taskbar";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void نصفساعةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Icon = Resources.Youm7_square_logo_mute;
			this.notifyIcon1.ContextMenuStrip.Items[2].Image = Resources.Lock;
			this.mute_counter = 30;
			this.نصفساعةToolStripMenuItem.Checked = true;
			this.ساعةكاملةToolStripMenuItem.Checked = false;
			this.ربعساعةToolStripMenuItem.Checked = false;
			this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = false;
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "تم تفعيل الايقاف المؤقت لمدة نصف ساعة - يمكنكم متابعة الأخبار عند الضغط على الأيقونة";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The notifications is temporarily disabled for 30 minutes - To check the latest news, left-click on the Icon in the taskbar";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void ساعةكاملةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Icon = Resources.Youm7_square_logo_mute;
			this.notifyIcon1.ContextMenuStrip.Items[2].Image = Resources.Lock;
			this.mute_counter = 60;
			this.ساعةكاملةToolStripMenuItem.Checked = true;
			this.نصفساعةToolStripMenuItem.Checked = false;
			this.ربعساعةToolStripMenuItem.Checked = false;
			this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = false;
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "تم تفعيل الايقاف المؤقت لمدة ساعة - يمكنكم متابعة الأخبار عند الضغط على الأيقونة";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The notifications is temporarily disabled for 1 hour - To check the latest news, left-click on the Icon in the taskbar";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void الغاءالايقافالمؤقتToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Icon = Resources.Youm7_square_logo;
			this.notifyIcon1.ContextMenuStrip.Items[2].Image = Resources.UNLock;
			this.mute_counter = 0;
			this.الغاءالايقافالمؤقتToolStripMenuItem.Checked = true;
			this.ساعةكاملةToolStripMenuItem.Checked = false;
			this.نصفساعةToolStripMenuItem.Checked = false;
			this.ربعساعةToolStripMenuItem.Checked = false;
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "تم الغاء الايقاف المؤقت";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "The Application is now Enabled";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
		}

		private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.timer.Dispose();
			this.t.Dispose();
			this.notifyIcon1.Dispose();
			base.Close();
			this.Logout();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "سيتم تحويلكم على الصفحة فورا";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "Opening The Webpage";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			Process.Start("http://youm7.com/");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.posFlag = 2;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.counttick = 300;
			if (this.shown_news < 7)
			{
				if (this.latest[this.shown_news + 1].Count > 0)
				{
					this.button4.Show();
					this.shown_news++;
					this.linkLabel1.Text = this.latest[this.shown_news][0].ToString();
					this.story_link = this.latest[this.shown_news][1].ToString();
					this.NewsID = int.Parse(this.latest[this.shown_news][2].ToString());
				}
			}
			if (this.shown_news > 0)
			{
				if (this.latest[this.shown_news - 1].Count == 0)
				{
					this.button4.Hide();
				}
			}
			if (this.shown_news == 7)
			{
				this.button3.Hide();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.counttick = 300;
			if (this.shown_news > 0)
			{
				if (this.latest[this.shown_news - 1].Count > 0)
				{
					this.button3.Show();
					this.shown_news--;
					this.linkLabel1.Text = this.latest[this.shown_news][0].ToString();
					this.story_link = this.latest[this.shown_news][1].ToString();
					this.NewsID = Convert.ToInt32(this.latest[this.shown_news][2]);
				}
			}
			if (this.shown_news > 0)
			{
				if (this.latest[this.shown_news - 1].Count == 0)
				{
					this.button4.Hide();
				}
			}
			if (this.shown_news == 0)
			{
				this.button4.Hide();
			}
		}

		public static string GetMacAddress()
		{
			string result = string.Empty;
			long num = -1L;
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			for (int i = 0; i < allNetworkInterfaces.Length; i++)
			{
				NetworkInterface networkInterface = allNetworkInterfaces[i];
				string text = networkInterface.GetPhysicalAddress().ToString();
				if (networkInterface.Speed > num && !string.IsNullOrEmpty(text) && text.Length >= 12)
				{
					num = networkInterface.Speed;
					result = text;
				}
			}
			return result;
		}

		private void CheckMac_adress()
		{
			this.mac_adress = Convert.ToString(Youm7.GetMacAddress());
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string json = webClient.DownloadString(string.Concat(new string[]
				{
					"http://youm7app.youm7.com/Api.aspx?MacAdress=",
					this.mac_adress,
					"&Version=",
					this.version,
					"&SEC=",
					this.security
				}));
				JObject jObject = JObject.Parse(json);
				this.UserID = int.Parse(jObject["UserID"].ToString());
				this.SessionID = int.Parse(jObject["SessionID"].ToString());
				webClient.Dispose();
				jObject.RemoveAll();
			}
			catch
			{
			}
		}

		private void Login()
		{
			this.mac_adress = Convert.ToString(Youm7.GetMacAddress());
			this.CheckMac_adress();
			try
			{
				try
				{
					WebClient webClient = new WebClient();
					Stream stream = webClient.OpenRead("http://youm7app.youm7.com/version.txt");
					StreamReader streamReader = new StreamReader(stream);
					string a = streamReader.ReadToEnd();
					if (a != this.version)
					{
						if (this.Language == 0)
						{
							if (MessageBox.Show("لأداء أفضل يجب تحديث البرنامج, هل تريد التحديث الآن؟", "تحديث جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
							{
								Process.Start("http://youm7app.youm7.com/اليوم-السابع-اخبار-عاجلة.exe");
							}
						}
						else if (MessageBox.Show("For A Better Performance You Have To Update The Application, Update Now?", "New Update", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
						{
							Process.Start("http://youm7app.youm7.com/اليوم-السابع-اخبار-عاجلة.exe");
						}
					}
					streamReader.Dispose();
					stream.Dispose();
					webClient.Dispose();
				}
				catch
				{
				}
			}
			catch
			{
			}
			finally
			{
				if (this.Language == 0)
				{
					this.notifyIcon1.BalloonTipText = "انتم على اتصل بـأهم الاخبار";
					this.notifyIcon1.ShowBalloonTip(30000);
				}
				else
				{
					this.notifyIcon1.BalloonTipText = "You are now connected to the latest news";
					this.notifyIcon1.ShowBalloonTip(30000);
				}
			}
		}

		private void Logout()
		{
			string text;
			if (this.Language == 0)
			{
				text = "Ar";
			}
			else
			{
				text = "En";
			}
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string text2 = webClient.DownloadString(string.Concat(new object[]
				{
					"http://youm7app.youm7.com/Api.aspx?SessionID=",
					this.SessionID,
					"&Lang=",
					text,
					"&SEC=",
					this.security
				}));
				webClient.Dispose();
			}
			catch
			{
			}
		}

		private void Update_News()
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string text = webClient.DownloadString(string.Concat(new object[]
				{
					"http://youm7app.youm7.com/Api.aspx?NewsID=",
					this.NewsID,
					"&UserID=",
					this.UserID,
					"&SEC=",
					this.security
				}));
				webClient.Dispose();
			}
			catch
			{
			}
		}

		private void Youm7_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.timer.Dispose();
			this.t.Dispose();
			this.notifyIcon1.Dispose();
			this.Logout();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "سيتم تحويلكم على الخبر فورا";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "Opening The Webpage";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			Process.Start(this.story_link);
			this.Update_News();
		}

		private void مننحنToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.Language == 0)
			{
				this.notifyIcon1.BalloonTipText = "سيتم تحويلكم على الصفحه فورا";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			else
			{
				this.notifyIcon1.BalloonTipText = "Opening The Webpage";
				this.notifyIcon1.ShowBalloonTip(30000);
			}
			Process.Start("http://www.youm7.com/home/about");
		}

		private void العربيةToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Language = 0;
			Settings.Default["language"] = 0;
			Settings.Default.Save();
			this.change_language();
		}

		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Language = 1;
			Settings.Default["language"] = 1;
			Settings.Default.Save();
			this.change_language();
		}

		private void change_language()
		{
			if (Settings.Default.language == 1)
			{
				this.notifyIcon1.ContextMenuStrip.Items[5].Image = Resources.Ar;
				this.العربيةToolStripMenuItem.Checked = false;
				this.englishToolStripMenuItem.Checked = true;
				this.notifyIcon1.ContextMenuStrip.Items[0].Text = "Go To Youm7.com";
				if (!Settings.Default.sound)
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Enable Sound";
				}
				else
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "Disable Sound";
				}
				this.notifyIcon1.ContextMenuStrip.Items[2].Text = "Temporarily Disable";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[0].Text = "For 15 Minutes";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[1].Text = "For 30 Minutes";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[2].Text = "For 1 Hour";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[3].Text = "Enable The Application";
				this.notifyIcon1.ContextMenuStrip.Items[4].Text = "Automatic Startup";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[0].Text = "Yes";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[1].Text = "No";
				this.notifyIcon1.ContextMenuStrip.Items[5].Text = "Language";
				this.notifyIcon1.ContextMenuStrip.Items[6].Text = "About";
				this.notifyIcon1.ContextMenuStrip.Items[7].Text = "Exit";
			}
			if (Settings.Default.language == 0)
			{
				this.notifyIcon1.ContextMenuStrip.Items[5].Image = Resources.En;
				this.العربيةToolStripMenuItem.Checked = true;
				this.englishToolStripMenuItem.Checked = false;
				this.notifyIcon1.ContextMenuStrip.Items[0].Text = "موقع اليوم السابع";
				if (!Settings.Default.sound)
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "إستخدام الصوت";
				}
				else
				{
					this.notifyIcon1.ContextMenuStrip.Items[1].Text = "كتم الصوت";
				}
				this.notifyIcon1.ContextMenuStrip.Items[2].Text = "ايقاف مؤقت";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[0].Text = "ربع ساعة";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[1].Text = "نصف ساعة";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[2].Text = "ساعة كاملة";
				(this.notifyIcon1.ContextMenuStrip.Items[2] as ToolStripDropDownItem).DropDownItems[3].Text = "الغاء الايقاف المؤقت";
				this.notifyIcon1.ContextMenuStrip.Items[4].Text = "بدء مع الكمبيوتر";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[0].Text = "نعم";
				(this.notifyIcon1.ContextMenuStrip.Items[4] as ToolStripDropDownItem).DropDownItems[1].Text = "لا";
				this.notifyIcon1.ContextMenuStrip.Items[5].Text = "اللغة";
				this.notifyIcon1.ContextMenuStrip.Items[6].Text = "من نحن ";
				this.notifyIcon1.ContextMenuStrip.Items[7].Text = "خروج";
			}
		}
	}
}
