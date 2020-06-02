namespace YuYuDown
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.ImgDown = new CCWin.SkinControl.SkinTextBox();
            this.ImgDwBar = new CCWin.SkinControl.SkinProgressBar();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.DwMusicCk = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.ShowView = new CCWin.SkinControl.SkinListView();
            this.nowDown = new CCWin.SkinControl.SkinTextBox();
            this.Newtext = new CCWin.SkinControl.SkinTextBox();
            this.AllDwBt = new CCWin.SkinControl.SkinButton();
            this.DwprogressBar = new CCWin.SkinControl.SkinProgressBar();
            this.SelectBt = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.pictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.OpenDown = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::YuYuDown.Properties.Resources.bj;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(603, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.pictureBox2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 32);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(603, 100);
            this.skinPanel1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.OpenDown);
            this.panel1.Controls.Add(this.skinLabel5);
            this.panel1.Controls.Add(this.ImgDown);
            this.panel1.Controls.Add(this.ImgDwBar);
            this.panel1.Controls.Add(this.skinLabel4);
            this.panel1.Controls.Add(this.DwMusicCk);
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.ShowView);
            this.panel1.Controls.Add(this.nowDown);
            this.panel1.Controls.Add(this.Newtext);
            this.panel1.Controls.Add(this.AllDwBt);
            this.panel1.Controls.Add(this.DwprogressBar);
            this.panel1.Controls.Add(this.SelectBt);
            this.panel1.Controls.Add(this.skinTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.Idtext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 432);
            this.panel1.TabIndex = 24;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(23, 396);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(109, 19);
            this.skinLabel5.TabIndex = 53;
            this.skinLabel5.Text = "正在下载：";
            this.skinLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgDown
            // 
            this.ImgDown.BackColor = System.Drawing.Color.Transparent;
            this.ImgDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgDown.DownBack = null;
            this.ImgDown.Icon = null;
            this.ImgDown.IconIsButton = false;
            this.ImgDown.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ImgDown.IsPasswordChat = '\0';
            this.ImgDown.IsSystemPasswordChar = false;
            this.ImgDown.Lines = new string[] {
        "暂无"};
            this.ImgDown.Location = new System.Drawing.Point(135, 391);
            this.ImgDown.Margin = new System.Windows.Forms.Padding(0);
            this.ImgDown.MaxLength = 32767;
            this.ImgDown.MinimumSize = new System.Drawing.Size(28, 28);
            this.ImgDown.MouseBack = null;
            this.ImgDown.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ImgDown.Multiline = false;
            this.ImgDown.Name = "ImgDown";
            this.ImgDown.NormlBack = null;
            this.ImgDown.Padding = new System.Windows.Forms.Padding(5);
            this.ImgDown.ReadOnly = true;
            this.ImgDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ImgDown.Size = new System.Drawing.Size(141, 28);
            // 
            // 
            // 
            this.ImgDown.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgDown.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgDown.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ImgDown.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ImgDown.SkinTxt.Name = "BaseText";
            this.ImgDown.SkinTxt.ReadOnly = true;
            this.ImgDown.SkinTxt.Size = new System.Drawing.Size(131, 18);
            this.ImgDown.SkinTxt.TabIndex = 0;
            this.ImgDown.SkinTxt.Text = "暂无";
            this.ImgDown.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ImgDown.SkinTxt.WaterText = "煜煜";
            this.ImgDown.TabIndex = 52;
            this.ImgDown.Text = "暂无";
            this.ImgDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ImgDown.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ImgDown.WaterText = "煜煜";
            this.ImgDown.WordWrap = true;
            // 
            // ImgDwBar
            // 
            this.ImgDwBar.Back = null;
            this.ImgDwBar.BackColor = System.Drawing.Color.Transparent;
            this.ImgDwBar.BarBack = null;
            this.ImgDwBar.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ImgDwBar.ForeColor = System.Drawing.Color.Red;
            this.ImgDwBar.Location = new System.Drawing.Point(302, 396);
            this.ImgDwBar.Name = "ImgDwBar";
            this.ImgDwBar.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ImgDwBar.Size = new System.Drawing.Size(267, 23);
            this.ImgDwBar.TabIndex = 51;
            // 
            // skinLabel4
            // 
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(23, 22);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(86, 31);
            this.skinLabel4.TabIndex = 50;
            this.skinLabel4.Text = "动漫ID：";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DwMusicCk
            // 
            this.DwMusicCk.AutoSize = true;
            this.DwMusicCk.BackColor = System.Drawing.Color.Transparent;
            this.DwMusicCk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.DwMusicCk.DownBack = null;
            this.DwMusicCk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DwMusicCk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DwMusicCk.Location = new System.Drawing.Point(482, 53);
            this.DwMusicCk.MouseBack = null;
            this.DwMusicCk.Name = "DwMusicCk";
            this.DwMusicCk.NormlBack = null;
            this.DwMusicCk.SelectedDownBack = null;
            this.DwMusicCk.SelectedMouseBack = null;
            this.DwMusicCk.SelectedNormlBack = null;
            this.DwMusicCk.Size = new System.Drawing.Size(87, 21);
            this.DwMusicCk.TabIndex = 49;
            this.DwMusicCk.Text = "下载提示音";
            this.DwMusicCk.UseVisualStyleBackColor = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(23, 367);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(109, 19);
            this.skinLabel3.TabIndex = 48;
            this.skinLabel3.Text = "正在下载：";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(192, 133);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(109, 19);
            this.skinLabel2.TabIndex = 47;
            this.skinLabel2.Text = "最新一话：";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowView
            // 
            this.ShowView.HideSelection = false;
            this.ShowView.Location = new System.Drawing.Point(27, 196);
            this.ShowView.Name = "ShowView";
            this.ShowView.OwnerDraw = true;
            this.ShowView.Size = new System.Drawing.Size(542, 153);
            this.ShowView.TabIndex = 46;
            this.ShowView.UseCompatibleStateImageBehavior = false;
            // 
            // nowDown
            // 
            this.nowDown.BackColor = System.Drawing.Color.Transparent;
            this.nowDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nowDown.DownBack = null;
            this.nowDown.Icon = null;
            this.nowDown.IconIsButton = false;
            this.nowDown.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.nowDown.IsPasswordChat = '\0';
            this.nowDown.IsSystemPasswordChar = false;
            this.nowDown.Lines = new string[] {
        "暂无"};
            this.nowDown.Location = new System.Drawing.Point(135, 362);
            this.nowDown.Margin = new System.Windows.Forms.Padding(0);
            this.nowDown.MaxLength = 32767;
            this.nowDown.MinimumSize = new System.Drawing.Size(28, 28);
            this.nowDown.MouseBack = null;
            this.nowDown.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.nowDown.Multiline = false;
            this.nowDown.Name = "nowDown";
            this.nowDown.NormlBack = null;
            this.nowDown.Padding = new System.Windows.Forms.Padding(5);
            this.nowDown.ReadOnly = true;
            this.nowDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nowDown.Size = new System.Drawing.Size(141, 28);
            // 
            // 
            // 
            this.nowDown.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowDown.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowDown.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.nowDown.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.nowDown.SkinTxt.Name = "BaseText";
            this.nowDown.SkinTxt.ReadOnly = true;
            this.nowDown.SkinTxt.Size = new System.Drawing.Size(131, 18);
            this.nowDown.SkinTxt.TabIndex = 0;
            this.nowDown.SkinTxt.Text = "暂无";
            this.nowDown.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.nowDown.SkinTxt.WaterText = "煜煜";
            this.nowDown.TabIndex = 45;
            this.nowDown.Text = "暂无";
            this.nowDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nowDown.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.nowDown.WaterText = "煜煜";
            this.nowDown.WordWrap = true;
            // 
            // Newtext
            // 
            this.Newtext.BackColor = System.Drawing.Color.Transparent;
            this.Newtext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Newtext.DownBack = null;
            this.Newtext.Icon = null;
            this.Newtext.IconIsButton = false;
            this.Newtext.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Newtext.IsPasswordChat = '\0';
            this.Newtext.IsSystemPasswordChar = false;
            this.Newtext.Lines = new string[] {
        "暂无"};
            this.Newtext.Location = new System.Drawing.Point(311, 129);
            this.Newtext.Margin = new System.Windows.Forms.Padding(0);
            this.Newtext.MaxLength = 32767;
            this.Newtext.MinimumSize = new System.Drawing.Size(28, 28);
            this.Newtext.MouseBack = null;
            this.Newtext.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Newtext.Multiline = false;
            this.Newtext.Name = "Newtext";
            this.Newtext.NormlBack = null;
            this.Newtext.Padding = new System.Windows.Forms.Padding(5);
            this.Newtext.ReadOnly = true;
            this.Newtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Newtext.Size = new System.Drawing.Size(258, 28);
            // 
            // 
            // 
            this.Newtext.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Newtext.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Newtext.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Newtext.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Newtext.SkinTxt.Name = "BaseText";
            this.Newtext.SkinTxt.ReadOnly = true;
            this.Newtext.SkinTxt.Size = new System.Drawing.Size(248, 18);
            this.Newtext.SkinTxt.TabIndex = 0;
            this.Newtext.SkinTxt.Text = "暂无";
            this.Newtext.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Newtext.SkinTxt.WaterText = "煜煜";
            this.Newtext.TabIndex = 44;
            this.Newtext.Text = "暂无";
            this.Newtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Newtext.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Newtext.WaterText = "煜煜";
            this.Newtext.WordWrap = true;
            // 
            // AllDwBt
            // 
            this.AllDwBt.BackColor = System.Drawing.Color.Transparent;
            this.AllDwBt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(169)))), ((int)(((byte)(75)))));
            this.AllDwBt.BorderColor = System.Drawing.Color.Transparent;
            this.AllDwBt.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AllDwBt.DownBack = null;
            this.AllDwBt.Location = new System.Drawing.Point(494, 24);
            this.AllDwBt.MouseBack = null;
            this.AllDwBt.Name = "AllDwBt";
            this.AllDwBt.NormlBack = null;
            this.AllDwBt.Size = new System.Drawing.Size(75, 23);
            this.AllDwBt.TabIndex = 45;
            this.AllDwBt.Text = "下载全部";
            this.AllDwBt.UseVisualStyleBackColor = false;
            this.AllDwBt.Click += new System.EventHandler(this.AllDown);
            // 
            // DwprogressBar
            // 
            this.DwprogressBar.Back = null;
            this.DwprogressBar.BackColor = System.Drawing.Color.Transparent;
            this.DwprogressBar.BarBack = null;
            this.DwprogressBar.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.DwprogressBar.ForeColor = System.Drawing.Color.Red;
            this.DwprogressBar.Location = new System.Drawing.Point(302, 367);
            this.DwprogressBar.Name = "DwprogressBar";
            this.DwprogressBar.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.DwprogressBar.Size = new System.Drawing.Size(267, 23);
            this.DwprogressBar.TabIndex = 35;
            // 
            // SelectBt
            // 
            this.SelectBt.BackColor = System.Drawing.Color.Transparent;
            this.SelectBt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(169)))), ((int)(((byte)(75)))));
            this.SelectBt.BorderColor = System.Drawing.Color.Transparent;
            this.SelectBt.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SelectBt.DownBack = null;
            this.SelectBt.Location = new System.Drawing.Point(306, 24);
            this.SelectBt.MouseBack = null;
            this.SelectBt.Name = "SelectBt";
            this.SelectBt.NormlBack = null;
            this.SelectBt.Size = new System.Drawing.Size(75, 23);
            this.SelectBt.TabIndex = 44;
            this.SelectBt.Text = "查询";
            this.SelectBt.UseVisualStyleBackColor = false;
            this.SelectBt.Click += new System.EventHandler(this.Select);
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "暂无"};
            this.skinTextBox1.Location = new System.Drawing.Point(311, 80);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = true;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(258, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.ReadOnly = true;
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(248, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "暂无";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "煜煜";
            this.skinTextBox1.TabIndex = 43;
            this.skinTextBox1.Text = "暂无";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "煜煜";
            this.skinTextBox1.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YuYuDown.Properties.Resources._default;
            this.pictureBox1.InitialImage = global::YuYuDown.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(27, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(192, 84);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(109, 19);
            this.skinLabel1.TabIndex = 41;
            this.skinLabel1.Text = "漫画名称：";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Idtext.Location = new System.Drawing.Point(128, 24);
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(159, 30);
            this.Idtext.TabIndex = 36;
            this.Idtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Idtext_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bj.png");
            this.imageList1.Images.SetKeyName(1, "default.jpg");
            this.imageList1.Images.SetKeyName(2, "defute.jpg");
            this.imageList1.Images.SetKeyName(3, "FormIco.ico");
            this.imageList1.Images.SetKeyName(4, "loading.gif");
            // 
            // OpenDown
            // 
            this.OpenDown.BackColor = System.Drawing.Color.Transparent;
            this.OpenDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(169)))), ((int)(((byte)(75)))));
            this.OpenDown.BorderColor = System.Drawing.Color.Transparent;
            this.OpenDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OpenDown.DownBack = null;
            this.OpenDown.Location = new System.Drawing.Point(400, 24);
            this.OpenDown.MouseBack = null;
            this.OpenDown.Name = "OpenDown";
            this.OpenDown.NormlBack = null;
            this.OpenDown.Size = new System.Drawing.Size(75, 23);
            this.OpenDown.TabIndex = 54;
            this.OpenDown.Text = "打开Down";
            this.OpenDown.UseVisualStyleBackColor = false;
            this.OpenDown.Click += new System.EventHandler(this.OpenDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("Segoe UI Symbol", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(611, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MdiAutoScroll = false;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.SkinOpacity = 0.8D;
            this.Text = "煜煜FM专属下载器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTextBox Newtext;
        private CCWin.SkinControl.SkinButton AllDwBt;
        private CCWin.SkinControl.SkinProgressBar DwprogressBar;
        private CCWin.SkinControl.SkinButton SelectBt;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinPictureBox pictureBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.TextBox Idtext;
        private CCWin.SkinControl.SkinTextBox nowDown;
        private CCWin.SkinControl.SkinListView ShowView;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinCheckBox DwMusicCk;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox ImgDown;
        private CCWin.SkinControl.SkinProgressBar ImgDwBar;
        private System.Windows.Forms.ImageList imageList1;
        private CCWin.SkinControl.SkinButton OpenDown;
    }
}

