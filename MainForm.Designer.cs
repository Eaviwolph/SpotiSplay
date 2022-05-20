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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backColorPanel = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.Button();
            this.foreColorPanel = new System.Windows.Forms.Panel();
            this.FontGroundButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.backColorPanel.SuspendLayout();
            this.foreColorPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.AutoSize = true;
            this.ConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConnectButton.Location = new System.Drawing.Point(0, 0);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(68, 284);
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
            this.ReloadButton.Location = new System.Drawing.Point(413, 0);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(66, 284);
            this.ReloadButton.TabIndex = 1;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.backColorPanel);
            this.panel1.Controls.Add(this.foreColorPanel);
            this.panel1.Controls.Add(this.MoveButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 284);
            this.panel1.TabIndex = 2;
            // 
            // backColorPanel
            // 
            this.backColorPanel.Controls.Add(this.colorButton);
            this.backColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backColorPanel.Location = new System.Drawing.Point(68, 156);
            this.backColorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backColorPanel.Name = "backColorPanel";
            this.backColorPanel.Size = new System.Drawing.Size(345, 49);
            this.backColorPanel.TabIndex = 11;
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorButton.Location = new System.Drawing.Point(206, 0);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(139, 49);
            this.colorButton.TabIndex = 8;
            this.colorButton.Text = "BackGround Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.backgroungColorButton_Click);
            // 
            // foreColorPanel
            // 
            this.foreColorPanel.Controls.Add(this.FontGroundButton);
            this.foreColorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreColorPanel.Location = new System.Drawing.Point(68, 205);
            this.foreColorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foreColorPanel.Name = "foreColorPanel";
            this.foreColorPanel.Size = new System.Drawing.Size(345, 49);
            this.foreColorPanel.TabIndex = 10;
            // 
            // FontGroundButton
            // 
            this.FontGroundButton.AutoSize = true;
            this.FontGroundButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FontGroundButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FontGroundButton.Location = new System.Drawing.Point(208, 0);
            this.FontGroundButton.Name = "FontGroundButton";
            this.FontGroundButton.Size = new System.Drawing.Size(137, 49);
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
            this.MoveButton.Location = new System.Drawing.Point(68, 254);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(345, 30);
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
            this.panel2.Location = new System.Drawing.Point(68, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 47);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity";
            // 
            // OpacityUpDown
            // 
            this.OpacityUpDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpacityUpDown.Location = new System.Drawing.Point(0, 20);
            this.OpacityUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpacityUpDown.Name = "OpacityUpDown";
            this.OpacityUpDown.Size = new System.Drawing.Size(345, 27);
            this.OpacityUpDown.TabIndex = 4;
            this.OpacityUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.OpacityUpDown.ValueChanged += new System.EventHandler(this.OpacityUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backColorPanel.ResumeLayout(false);
            this.backColorPanel.PerformLayout();
            this.foreColorPanel.ResumeLayout(false);
            this.foreColorPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityUpDown)).EndInit();
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
    }
}