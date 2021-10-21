namespace Advanced_Windows_Tool
{
    partial class Cleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleaner));
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CleanLogElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CleanLog = new System.Windows.Forms.ListBox();
            this.ErrorLogElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ErrorLog = new System.Windows.Forms.ListBox();
            this.Left_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.AboutButton = new Guna.UI2.WinForms.Guna2Button();
            this.Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DebloaterButton = new Guna.UI2.WinForms.Guna2Button();
            this.CleanerButton = new Guna.UI2.WinForms.Guna2Button();
            this.About_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Website = new System.Windows.Forms.PictureBox();
            this.Github = new System.Windows.Forms.PictureBox();
            this.Discord = new System.Windows.Forms.PictureBox();
            this.Desc = new System.Windows.Forms.Label();
            this.Desc2 = new System.Windows.Forms.Label();
            this.CleanerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Clean = new Guna.UI2.WinForms.Guna2Button();
            this.CleanGBox = new System.Windows.Forms.GroupBox();
            this.ErrorGBox = new System.Windows.Forms.GroupBox();
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.ModeChanger = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.CleanBoxElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DebloaterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Debloater_Label = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Debloat = new Guna.UI2.WinForms.Guna2Button();
            this.Left_Panel.SuspendLayout();
            this.About_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Website)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).BeginInit();
            this.CleanerPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.DebloaterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.BorderRadius = 60;
            this.FormElipse.TargetControl = this;
            // 
            // CleanLogElipse
            // 
            this.CleanLogElipse.BorderRadius = 40;
            this.CleanLogElipse.TargetControl = this.CleanLog;
            // 
            // CleanLog
            // 
            this.CleanLog.BackColor = System.Drawing.Color.DarkGray;
            this.CleanLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CleanLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanLog.ForeColor = System.Drawing.Color.Black;
            this.CleanLog.FormattingEnabled = true;
            this.CleanLog.HorizontalScrollbar = true;
            this.CleanLog.ItemHeight = 19;
            this.CleanLog.Location = new System.Drawing.Point(17, 199);
            this.CleanLog.Name = "CleanLog";
            this.CleanLog.Size = new System.Drawing.Size(340, 285);
            this.CleanLog.TabIndex = 12;
            this.CleanLog.SelectedIndexChanged += new System.EventHandler(this.CleanLog_SelectedIndexChanged);
            // 
            // ErrorLogElipse
            // 
            this.ErrorLogElipse.BorderRadius = 40;
            this.ErrorLogElipse.TargetControl = this.ErrorLog;
            // 
            // ErrorLog
            // 
            this.ErrorLog.BackColor = System.Drawing.Color.DarkGray;
            this.ErrorLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLog.ForeColor = System.Drawing.Color.Black;
            this.ErrorLog.FormattingEnabled = true;
            this.ErrorLog.HorizontalScrollbar = true;
            this.ErrorLog.ItemHeight = 19;
            this.ErrorLog.Location = new System.Drawing.Point(371, 200);
            this.ErrorLog.Name = "ErrorLog";
            this.ErrorLog.Size = new System.Drawing.Size(340, 285);
            this.ErrorLog.TabIndex = 13;
            this.ErrorLog.SelectedIndexChanged += new System.EventHandler(this.ErrorLog_SelectedIndexChanged);
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.Black;
            this.Left_Panel.Controls.Add(this.AboutButton);
            this.Left_Panel.Controls.Add(this.Button4);
            this.Left_Panel.Controls.Add(this.Button3);
            this.Left_Panel.Controls.Add(this.Button2);
            this.Left_Panel.Controls.Add(this.Button1);
            this.Left_Panel.Controls.Add(this.DebloaterButton);
            this.Left_Panel.Controls.Add(this.CleanerButton);
            this.Left_Panel.Location = new System.Drawing.Point(0, 45);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.ShadowDecoration.Parent = this.Left_Panel;
            this.Left_Panel.Size = new System.Drawing.Size(188, 500);
            this.Left_Panel.TabIndex = 15;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Black;
            this.AboutButton.BorderColor = System.Drawing.Color.White;
            this.AboutButton.BorderThickness = 1;
            this.AboutButton.CheckedState.Parent = this.AboutButton;
            this.AboutButton.CustomImages.Parent = this.AboutButton;
            this.AboutButton.CustomizableEdges.BottomLeft = false;
            this.AboutButton.CustomizableEdges.BottomRight = false;
            this.AboutButton.CustomizableEdges.TopRight = false;
            this.AboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AboutButton.DisabledState.Parent = this.AboutButton;
            this.AboutButton.FillColor = System.Drawing.Color.Transparent;
            this.AboutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.HoverState.Parent = this.AboutButton;
            this.AboutButton.Location = new System.Drawing.Point(0, 2);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.ShadowDecoration.Parent = this.AboutButton;
            this.AboutButton.Size = new System.Drawing.Size(188, 71);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_MouseDown);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Black;
            this.Button4.BorderColor = System.Drawing.Color.White;
            this.Button4.BorderRadius = 31;
            this.Button4.BorderThickness = 1;
            this.Button4.CheckedState.Parent = this.Button4;
            this.Button4.CustomImages.Parent = this.Button4;
            this.Button4.CustomizableEdges.BottomRight = false;
            this.Button4.CustomizableEdges.TopLeft = false;
            this.Button4.CustomizableEdges.TopRight = false;
            this.Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button4.DisabledState.Parent = this.Button4;
            this.Button4.FillColor = System.Drawing.Color.Transparent;
            this.Button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.HoverState.Parent = this.Button4;
            this.Button4.Location = new System.Drawing.Point(0, 428);
            this.Button4.Name = "Button4";
            this.Button4.ShadowDecoration.Parent = this.Button4;
            this.Button4.Size = new System.Drawing.Size(188, 71);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "(None)";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.BorderColor = System.Drawing.Color.White;
            this.Button3.BorderThickness = 1;
            this.Button3.CheckedState.Parent = this.Button3;
            this.Button3.CustomImages.Parent = this.Button3;
            this.Button3.CustomizableEdges.BottomLeft = false;
            this.Button3.CustomizableEdges.BottomRight = false;
            this.Button3.CustomizableEdges.TopRight = false;
            this.Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button3.DisabledState.Parent = this.Button3;
            this.Button3.FillColor = System.Drawing.Color.Transparent;
            this.Button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.HoverState.Parent = this.Button3;
            this.Button3.Location = new System.Drawing.Point(0, 357);
            this.Button3.Name = "Button3";
            this.Button3.ShadowDecoration.Parent = this.Button3;
            this.Button3.Size = new System.Drawing.Size(188, 71);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "(None)";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Black;
            this.Button2.BorderColor = System.Drawing.Color.White;
            this.Button2.BorderThickness = 1;
            this.Button2.CheckedState.Parent = this.Button2;
            this.Button2.CustomImages.Parent = this.Button2;
            this.Button2.CustomizableEdges.BottomLeft = false;
            this.Button2.CustomizableEdges.BottomRight = false;
            this.Button2.CustomizableEdges.TopRight = false;
            this.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button2.DisabledState.Parent = this.Button2;
            this.Button2.FillColor = System.Drawing.Color.Transparent;
            this.Button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.HoverState.Parent = this.Button2;
            this.Button2.Location = new System.Drawing.Point(0, 286);
            this.Button2.Name = "Button2";
            this.Button2.ShadowDecoration.Parent = this.Button2;
            this.Button2.Size = new System.Drawing.Size(188, 71);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "(None)";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Black;
            this.Button1.BorderColor = System.Drawing.Color.White;
            this.Button1.BorderThickness = 1;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.CustomizableEdges.BottomLeft = false;
            this.Button1.CustomizableEdges.BottomRight = false;
            this.Button1.CustomizableEdges.TopRight = false;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.DisabledState.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(0, 215);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(188, 71);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "(None)";
            // 
            // DebloaterButton
            // 
            this.DebloaterButton.BackColor = System.Drawing.Color.Black;
            this.DebloaterButton.BorderColor = System.Drawing.Color.White;
            this.DebloaterButton.BorderThickness = 1;
            this.DebloaterButton.CheckedState.Parent = this.DebloaterButton;
            this.DebloaterButton.CustomImages.Parent = this.DebloaterButton;
            this.DebloaterButton.CustomizableEdges.BottomLeft = false;
            this.DebloaterButton.CustomizableEdges.BottomRight = false;
            this.DebloaterButton.CustomizableEdges.TopRight = false;
            this.DebloaterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DebloaterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DebloaterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DebloaterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DebloaterButton.DisabledState.Parent = this.DebloaterButton;
            this.DebloaterButton.FillColor = System.Drawing.Color.Transparent;
            this.DebloaterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebloaterButton.ForeColor = System.Drawing.Color.White;
            this.DebloaterButton.HoverState.Parent = this.DebloaterButton;
            this.DebloaterButton.Location = new System.Drawing.Point(0, 144);
            this.DebloaterButton.Name = "DebloaterButton";
            this.DebloaterButton.ShadowDecoration.Parent = this.DebloaterButton;
            this.DebloaterButton.Size = new System.Drawing.Size(188, 71);
            this.DebloaterButton.TabIndex = 2;
            this.DebloaterButton.Text = "Windows Debloater (Soon)";
            this.DebloaterButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DebloaterButton_MouseDown);
            // 
            // CleanerButton
            // 
            this.CleanerButton.BackColor = System.Drawing.Color.Black;
            this.CleanerButton.BorderColor = System.Drawing.Color.White;
            this.CleanerButton.BorderThickness = 1;
            this.CleanerButton.CheckedState.Parent = this.CleanerButton;
            this.CleanerButton.CustomImages.Parent = this.CleanerButton;
            this.CleanerButton.CustomizableEdges.BottomLeft = false;
            this.CleanerButton.CustomizableEdges.BottomRight = false;
            this.CleanerButton.CustomizableEdges.TopRight = false;
            this.CleanerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CleanerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CleanerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CleanerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CleanerButton.DisabledState.Parent = this.CleanerButton;
            this.CleanerButton.FillColor = System.Drawing.Color.Transparent;
            this.CleanerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CleanerButton.ForeColor = System.Drawing.Color.White;
            this.CleanerButton.HoverState.Parent = this.CleanerButton;
            this.CleanerButton.Location = new System.Drawing.Point(0, 73);
            this.CleanerButton.Name = "CleanerButton";
            this.CleanerButton.ShadowDecoration.Parent = this.CleanerButton;
            this.CleanerButton.Size = new System.Drawing.Size(188, 71);
            this.CleanerButton.TabIndex = 1;
            this.CleanerButton.Text = "Temp  File Cleaner";
            this.CleanerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CleanerButton_MouseDown);
            // 
            // About_Panel
            // 
            this.About_Panel.BackColor = System.Drawing.Color.Black;
            this.About_Panel.BorderColor = System.Drawing.Color.White;
            this.About_Panel.BorderRadius = 31;
            this.About_Panel.BorderThickness = 1;
            this.About_Panel.Controls.Add(this.Website);
            this.About_Panel.Controls.Add(this.Github);
            this.About_Panel.Controls.Add(this.Discord);
            this.About_Panel.Controls.Add(this.Desc);
            this.About_Panel.Controls.Add(this.Desc2);
            this.About_Panel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.About_Panel.CustomizableEdges.BottomLeft = false;
            this.About_Panel.CustomizableEdges.TopLeft = false;
            this.About_Panel.CustomizableEdges.TopRight = false;
            this.About_Panel.Location = new System.Drawing.Point(189, 46);
            this.About_Panel.Name = "About_Panel";
            this.About_Panel.ShadowDecoration.Parent = this.About_Panel;
            this.About_Panel.Size = new System.Drawing.Size(722, 498);
            this.About_Panel.TabIndex = 16;
            // 
            // Website
            // 
            this.Website.BackColor = System.Drawing.Color.Transparent;
            this.Website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Website.Image = global::Advanced_Windows_Tool.Properties.Resources.website;
            this.Website.Location = new System.Drawing.Point(564, 5);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(50, 50);
            this.Website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Website.TabIndex = 6;
            this.Website.TabStop = false;
            this.Website.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Website_MouseDown);
            // 
            // Github
            // 
            this.Github.BackColor = System.Drawing.Color.Transparent;
            this.Github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Github.Image = ((System.Drawing.Image)(resources.GetObject("Github.Image")));
            this.Github.Location = new System.Drawing.Point(667, 5);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(50, 50);
            this.Github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Github.TabIndex = 5;
            this.Github.TabStop = false;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // Discord
            // 
            this.Discord.BackColor = System.Drawing.Color.Transparent;
            this.Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Discord.Image = global::Advanced_Windows_Tool.Properties.Resources.discord;
            this.Discord.Location = new System.Drawing.Point(614, 5);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(50, 50);
            this.Discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Discord.TabIndex = 4;
            this.Discord.TabStop = false;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.ForeColor = System.Drawing.Color.White;
            this.Desc.Location = new System.Drawing.Point(103, 213);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(513, 24);
            this.Desc.TabIndex = 2;
            this.Desc.Text = "Gorkido\'s Advanced Windows Tool (Beta Release)";
            this.Desc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Desc2
            // 
            this.Desc2.AutoSize = true;
            this.Desc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desc2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc2.ForeColor = System.Drawing.Color.White;
            this.Desc2.Location = new System.Drawing.Point(81, 243);
            this.Desc2.Name = "Desc2";
            this.Desc2.Size = new System.Drawing.Size(557, 19);
            this.Desc2.TabIndex = 1;
            this.Desc2.Text = "\"Advanced Windows Tool\" is an app where you can speed up Windows.";
            this.Desc2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CleanerPanel
            // 
            this.CleanerPanel.BackColor = System.Drawing.Color.Black;
            this.CleanerPanel.BorderColor = System.Drawing.Color.White;
            this.CleanerPanel.BorderRadius = 31;
            this.CleanerPanel.BorderThickness = 1;
            this.CleanerPanel.Controls.Add(this.Clean);
            this.CleanerPanel.Controls.Add(this.ErrorLog);
            this.CleanerPanel.Controls.Add(this.CleanLog);
            this.CleanerPanel.Controls.Add(this.CleanGBox);
            this.CleanerPanel.Controls.Add(this.ErrorGBox);
            this.CleanerPanel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.CleanerPanel.CustomizableEdges.BottomLeft = false;
            this.CleanerPanel.CustomizableEdges.TopLeft = false;
            this.CleanerPanel.CustomizableEdges.TopRight = false;
            this.CleanerPanel.ForeColor = System.Drawing.Color.Black;
            this.CleanerPanel.Location = new System.Drawing.Point(189, 46);
            this.CleanerPanel.Name = "CleanerPanel";
            this.CleanerPanel.ShadowDecoration.Parent = this.CleanerPanel;
            this.CleanerPanel.Size = new System.Drawing.Size(722, 498);
            this.CleanerPanel.TabIndex = 17;
            this.CleanerPanel.Visible = false;
            // 
            // Clean
            // 
            this.Clean.AutoRoundedCorners = true;
            this.Clean.BackColor = System.Drawing.Color.Black;
            this.Clean.BorderColor = System.Drawing.Color.White;
            this.Clean.BorderRadius = 31;
            this.Clean.BorderThickness = 1;
            this.Clean.CheckedState.Parent = this.Clean;
            this.Clean.CustomImages.Parent = this.Clean;
            this.Clean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clean.DisabledState.Parent = this.Clean;
            this.Clean.FillColor = System.Drawing.Color.Transparent;
            this.Clean.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.ForeColor = System.Drawing.Color.White;
            this.Clean.HoverState.Parent = this.Clean;
            this.Clean.Location = new System.Drawing.Point(235, 63);
            this.Clean.Name = "Clean";
            this.Clean.ShadowDecoration.Parent = this.Clean;
            this.Clean.Size = new System.Drawing.Size(257, 64);
            this.Clean.TabIndex = 15;
            this.Clean.Text = "Clean";
            this.Clean.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clean_MouseDown);
            // 
            // CleanGBox
            // 
            this.CleanGBox.BackColor = System.Drawing.Color.Transparent;
            this.CleanGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanGBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanGBox.ForeColor = System.Drawing.Color.White;
            this.CleanGBox.Location = new System.Drawing.Point(10, 177);
            this.CleanGBox.Name = "CleanGBox";
            this.CleanGBox.Size = new System.Drawing.Size(352, 314);
            this.CleanGBox.TabIndex = 0;
            this.CleanGBox.TabStop = false;
            this.CleanGBox.Text = "Deleted Directories / Files";
            // 
            // ErrorGBox
            // 
            this.ErrorGBox.BackColor = System.Drawing.Color.Transparent;
            this.ErrorGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorGBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorGBox.ForeColor = System.Drawing.Color.White;
            this.ErrorGBox.Location = new System.Drawing.Point(365, 177);
            this.ErrorGBox.Name = "ErrorGBox";
            this.ErrorGBox.Size = new System.Drawing.Size(351, 314);
            this.ErrorGBox.TabIndex = 17;
            this.ErrorGBox.TabStop = false;
            this.ErrorGBox.Text = "Errors";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Black;
            this.TopBar.BorderColor = System.Drawing.Color.White;
            this.TopBar.BorderRadius = 31;
            this.TopBar.BorderThickness = 2;
            this.TopBar.Controls.Add(this.ModeChanger);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Exit);
            this.TopBar.Controls.Add(this.AppName);
            this.TopBar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.TopBar.CustomizableEdges.BottomLeft = false;
            this.TopBar.CustomizableEdges.BottomRight = false;
            this.TopBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TopBar.Location = new System.Drawing.Point(-1, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(913, 48);
            this.TopBar.TabIndex = 19;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_Panel_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_Panel_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_Panel_MouseUp);
            // 
            // ModeChanger
            // 
            this.ModeChanger.BackColor = System.Drawing.Color.Transparent;
            this.ModeChanger.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.ModeChanger.CheckedState.FillColor = System.Drawing.Color.White;
            this.ModeChanger.CheckedState.InnerBorderColor = System.Drawing.Color.Linen;
            this.ModeChanger.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.ModeChanger.CheckedState.Parent = this.ModeChanger;
            this.ModeChanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeChanger.Location = new System.Drawing.Point(524, 14);
            this.ModeChanger.Name = "ModeChanger";
            this.ModeChanger.ShadowDecoration.Parent = this.ModeChanger;
            this.ModeChanger.Size = new System.Drawing.Size(49, 20);
            this.ModeChanger.TabIndex = 5;
            this.ModeChanger.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.ModeChanger.UncheckedState.BorderThickness = 1;
            this.ModeChanger.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ModeChanger.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.ModeChanger.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ModeChanger.UncheckedState.Parent = this.ModeChanger;
            this.ModeChanger.Visible = false;
            this.ModeChanger.CheckedChanged += new System.EventHandler(this.ModeChanger_CheckedChanged);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(820, 10);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 18);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "__";
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseDown);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(870, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            // 
            // AppName
            // 
            this.AppName.AutoEllipsis = true;
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(13, 15);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(225, 21);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "Advanced Windows Tool";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppName_MouseDown);
            this.AppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppName_MouseMove);
            this.AppName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppName_MouseUp);
            // 
            // CleanBoxElipse
            // 
            this.CleanBoxElipse.BorderRadius = 40;
            this.CleanBoxElipse.TargetControl = this.CleanLog;
            // 
            // DebloaterPanel
            // 
            this.DebloaterPanel.BackColor = System.Drawing.Color.Black;
            this.DebloaterPanel.BorderColor = System.Drawing.Color.White;
            this.DebloaterPanel.BorderRadius = 31;
            this.DebloaterPanel.BorderThickness = 1;
            this.DebloaterPanel.Controls.Add(this.Debloat);
            this.DebloaterPanel.Controls.Add(this.guna2Button4);
            this.DebloaterPanel.Controls.Add(this.guna2Button3);
            this.DebloaterPanel.Controls.Add(this.guna2Button2);
            this.DebloaterPanel.Controls.Add(this.guna2Button1);
            this.DebloaterPanel.Controls.Add(this.Debloater_Label);
            this.DebloaterPanel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.DebloaterPanel.CustomizableEdges.BottomLeft = false;
            this.DebloaterPanel.CustomizableEdges.TopLeft = false;
            this.DebloaterPanel.CustomizableEdges.TopRight = false;
            this.DebloaterPanel.Location = new System.Drawing.Point(189, 47);
            this.DebloaterPanel.Name = "DebloaterPanel";
            this.DebloaterPanel.ShadowDecoration.Parent = this.DebloaterPanel;
            this.DebloaterPanel.Size = new System.Drawing.Size(722, 497);
            this.DebloaterPanel.TabIndex = 20;
            this.DebloaterPanel.Visible = false;
            // 
            // Debloater_Label
            // 
            this.Debloater_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Debloater_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Debloater_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debloater_Label.ForeColor = System.Drawing.Color.White;
            this.Debloater_Label.Location = new System.Drawing.Point(0, 0);
            this.Debloater_Label.Name = "Debloater_Label";
            this.Debloater_Label.Size = new System.Drawing.Size(722, 19);
            this.Debloater_Label.TabIndex = 1;
            this.Debloater_Label.Text = "Debloater";
            this.Debloater_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Black;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 31;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(10, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(150, 64);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Black;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 31;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(561, 22);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(150, 64);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Black;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 31;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(10, 419);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(150, 64);
            this.guna2Button3.TabIndex = 18;
            this.guna2Button3.Text = "guna2Button3";
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Black;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 31;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(559, 419);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(150, 64);
            this.guna2Button4.TabIndex = 19;
            this.guna2Button4.Text = "guna2Button4";
            // 
            // Debloat
            // 
            this.Debloat.AutoRoundedCorners = true;
            this.Debloat.BackColor = System.Drawing.Color.Black;
            this.Debloat.BorderColor = System.Drawing.Color.White;
            this.Debloat.BorderRadius = 31;
            this.Debloat.BorderThickness = 1;
            this.Debloat.CheckedState.Parent = this.Debloat;
            this.Debloat.CustomImages.Parent = this.Debloat;
            this.Debloat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Debloat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Debloat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Debloat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Debloat.DisabledState.Parent = this.Debloat;
            this.Debloat.FillColor = System.Drawing.Color.Transparent;
            this.Debloat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debloat.ForeColor = System.Drawing.Color.White;
            this.Debloat.HoverState.Parent = this.Debloat;
            this.Debloat.Location = new System.Drawing.Point(275, 216);
            this.Debloat.Name = "Debloat";
            this.Debloat.ShadowDecoration.Parent = this.Debloat;
            this.Debloat.Size = new System.Drawing.Size(172, 64);
            this.Debloat.TabIndex = 21;
            this.Debloat.Text = "Debloat Windows";
            // 
            // Cleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.DebloaterPanel);
            this.Controls.Add(this.About_Panel);
            this.Controls.Add(this.CleanerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cleaner_Form_Load);
            this.Left_Panel.ResumeLayout(false);
            this.About_Panel.ResumeLayout(false);
            this.About_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Website)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discord)).EndInit();
            this.CleanerPanel.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.DebloaterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2Elipse CleanLogElipse;
        private Guna.UI2.WinForms.Guna2Elipse ErrorLogElipse;
        private Guna.UI2.WinForms.Guna2Panel Left_Panel;
        private Guna.UI2.WinForms.Guna2Button AboutButton;
        private Guna.UI2.WinForms.Guna2Button Button4;
        private Guna.UI2.WinForms.Guna2Button Button3;
        private Guna.UI2.WinForms.Guna2Button Button2;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button DebloaterButton;
        private Guna.UI2.WinForms.Guna2Button CleanerButton;
        private Guna.UI2.WinForms.Guna2Panel About_Panel;
        private System.Windows.Forms.Label Desc2;
        private System.Windows.Forms.Label Desc;
        private Guna.UI2.WinForms.Guna2Panel CleanerPanel;
        private System.Windows.Forms.ListBox ErrorLog;
        private System.Windows.Forms.ListBox CleanLog;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Label AppName;
        private Guna.UI2.WinForms.Guna2Button Clean;
        private System.Windows.Forms.GroupBox CleanGBox;
        private Guna.UI2.WinForms.Guna2Elipse CleanBoxElipse;
        private System.Windows.Forms.GroupBox ErrorGBox;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox Github;
        private System.Windows.Forms.PictureBox Discord;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ModeChanger;
        private Guna.UI2.WinForms.Guna2Panel DebloaterPanel;
        private System.Windows.Forms.Label Debloater_Label;
        private System.Windows.Forms.PictureBox Website;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Debloat;
    }
}

