namespace SpotiSplay
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TPadUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LPadUpDown = new System.Windows.Forms.NumericUpDown();
            this.backColorPanel = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.Button();
            this.foreColorPanel = new System.Windows.Forms.Panel();
            this.FontGroundButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpotiNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotif = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripTextBoxQuit = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPadUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPadUpDown)).BeginInit();
            this.backColorPanel.SuspendLayout();
            this.foreColorPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityUpDown)).BeginInit();
            this.contextMenuStripNotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.AutoSize = true;
            this.ConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConnectButton.Location = new System.Drawing.Point(0, 0);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(55, 276);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Display";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.StartDisplay);
            // 
            // ReloadButton
            // 
            this.ReloadButton.AutoSize = true;
            this.ReloadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReloadButton.Location = new System.Drawing.Point(366, 0);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(53, 276);
            this.ReloadButton.TabIndex = 1;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.backColorPanel);
            this.panel1.Controls.Add(this.foreColorPanel);
            this.panel1.Controls.Add(this.MoveButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 276);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TPadUpDown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(55, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 38);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Top Padding";
            // 
            // TPadUpDown
            // 
            this.TPadUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TPadUpDown.Location = new System.Drawing.Point(0, 15);
            this.TPadUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TPadUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.TPadUpDown.Name = "TPadUpDown";
            this.TPadUpDown.Size = new System.Drawing.Size(311, 23);
            this.TPadUpDown.TabIndex = 4;
            this.TPadUpDown.ValueChanged += new System.EventHandler(this.TPadUpDown_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.LPadUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(55, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 38);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left Padding";
            // 
            // LPadUpDown
            // 
            this.LPadUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LPadUpDown.Location = new System.Drawing.Point(0, 15);
            this.LPadUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LPadUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.LPadUpDown.Name = "LPadUpDown";
            this.LPadUpDown.Size = new System.Drawing.Size(311, 23);
            this.LPadUpDown.TabIndex = 4;
            this.LPadUpDown.ValueChanged += new System.EventHandler(this.LPadUpDown_ValueChanged);
            // 
            // backColorPanel
            // 
            this.backColorPanel.Controls.Add(this.colorButton);
            this.backColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backColorPanel.Location = new System.Drawing.Point(55, 177);
            this.backColorPanel.Name = "backColorPanel";
            this.backColorPanel.Size = new System.Drawing.Size(311, 37);
            this.backColorPanel.TabIndex = 11;
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorButton.Location = new System.Drawing.Point(197, 0);
            this.colorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(114, 37);
            this.colorButton.TabIndex = 8;
            this.colorButton.Text = "BackGround Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.backgroungColorButton_Click);
            // 
            // foreColorPanel
            // 
            this.foreColorPanel.Controls.Add(this.FontGroundButton);
            this.foreColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreColorPanel.Location = new System.Drawing.Point(55, 214);
            this.foreColorPanel.Name = "foreColorPanel";
            this.foreColorPanel.Size = new System.Drawing.Size(311, 37);
            this.foreColorPanel.TabIndex = 10;
            // 
            // FontGroundButton
            // 
            this.FontGroundButton.AutoSize = true;
            this.FontGroundButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FontGroundButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FontGroundButton.Location = new System.Drawing.Point(198, 0);
            this.FontGroundButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FontGroundButton.Name = "FontGroundButton";
            this.FontGroundButton.Size = new System.Drawing.Size(113, 37);
            this.FontGroundButton.TabIndex = 9;
            this.FontGroundButton.Text = "FontGround Color";
            this.FontGroundButton.UseVisualStyleBackColor = true;
            this.FontGroundButton.Click += new System.EventHandler(this.FontGroundButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.AutoSize = true;
            this.MoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoveButton.Location = new System.Drawing.Point(55, 251);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(311, 25);
            this.MoveButton.TabIndex = 7;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.OpacityUpDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(55, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 38);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity";
            // 
            // OpacityUpDown
            // 
            this.OpacityUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpacityUpDown.Location = new System.Drawing.Point(0, 15);
            this.OpacityUpDown.Name = "OpacityUpDown";
            this.OpacityUpDown.Size = new System.Drawing.Size(311, 23);
            this.OpacityUpDown.TabIndex = 4;
            this.OpacityUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.OpacityUpDown.ValueChanged += new System.EventHandler(this.OpacityUpDown_ValueChanged);
            // 
            // SpotiNotif
            // 
            this.SpotiNotif.Icon = ((System.Drawing.Icon)(resources.GetObject("SpotiNotif.Icon")));
            this.SpotiNotif.Text = "SpotiNotif";
            this.SpotiNotif.Visible = true;
            this.SpotiNotif.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpotiNotif_MouseClick);
            // 
            // contextMenuStripNotif
            // 
            this.contextMenuStripNotif.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripTextBoxQuit});
            this.contextMenuStripNotif.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripNotif.Name = "contextMenuStrip1";
            this.contextMenuStripNotif.ShowImageMargin = false;
            this.contextMenuStripNotif.Size = new System.Drawing.Size(136, 29);
            // 
            // StripTextBoxQuit
            // 
            this.StripTextBoxQuit.Name = "StripTextBoxQuit";
            this.StripTextBoxQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StripTextBoxQuit.Size = new System.Drawing.Size(100, 23);
            this.StripTextBoxQuit.Text = "Quit";
            this.StripTextBoxQuit.Click += new System.EventHandler(this.StripTextBoxQuit_Click);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 276);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TPadUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPadUpDown)).EndInit();
            this.backColorPanel.ResumeLayout(false);
            this.backColorPanel.PerformLayout();
            this.foreColorPanel.ResumeLayout(false);
            this.foreColorPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityUpDown)).EndInit();
            this.contextMenuStripNotif.ResumeLayout(false);
            this.contextMenuStripNotif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ConnectButton;
        private Button ReloadButton;
        private Panel panel1;
        private NumericUpDown OpacityUpDown;
        private Panel panel2;
        private Label label1;
        private Button MoveButton;
        private Button colorButton;
        private Button FontGroundButton;
        private Panel backColorPanel;
        private Panel foreColorPanel;
        private NotifyIcon SpotiNotif;
        private ContextMenuStrip contextMenuStripNotif;
        private ToolStripTextBox StripTextBoxQuit;
        private Panel panel3;
        private Label label2;
        private NumericUpDown LPadUpDown;
        private Panel panel4;
        private Label label3;
        private NumericUpDown TPadUpDown;
    }
}