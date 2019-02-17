namespace TicTacToe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelXwin = new System.Windows.Forms.Label();
            this.labelTIE = new System.Windows.Forms.Label();
            this.labelOwin = new System.Windows.Forms.Label();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1P1 = new System.Windows.Forms.TextBox();
            this.textBox2P2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA1.Location = new System.Drawing.Point(12, 27);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(75, 75);
            this.buttonA1.TabIndex = 1;
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonClick);
            this.buttonA1.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonA1.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonA2
            // 
            this.buttonA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA2.Location = new System.Drawing.Point(93, 27);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(75, 75);
            this.buttonA2.TabIndex = 2;
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.buttonClick);
            this.buttonA2.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonA2.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonA3
            // 
            this.buttonA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA3.Location = new System.Drawing.Point(174, 27);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(75, 75);
            this.buttonA3.TabIndex = 3;
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.buttonClick);
            this.buttonA3.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonA3.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonB1
            // 
            this.buttonB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB1.Location = new System.Drawing.Point(12, 108);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(75, 75);
            this.buttonB1.TabIndex = 4;
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.Click += new System.EventHandler(this.buttonClick);
            this.buttonB1.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonB1.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonB2
            // 
            this.buttonB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB2.Location = new System.Drawing.Point(93, 108);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(75, 75);
            this.buttonB2.TabIndex = 5;
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.Click += new System.EventHandler(this.buttonClick);
            this.buttonB2.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonB2.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonB3
            // 
            this.buttonB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB3.Location = new System.Drawing.Point(174, 108);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(75, 75);
            this.buttonB3.TabIndex = 6;
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.buttonClick);
            this.buttonB3.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonB3.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonC1
            // 
            this.buttonC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC1.Location = new System.Drawing.Point(12, 189);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(75, 75);
            this.buttonC1.TabIndex = 7;
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.Click += new System.EventHandler(this.buttonClick);
            this.buttonC1.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonC1.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonC2
            // 
            this.buttonC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC2.Location = new System.Drawing.Point(93, 189);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(75, 75);
            this.buttonC2.TabIndex = 8;
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.Click += new System.EventHandler(this.buttonClick);
            this.buttonC2.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonC2.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // buttonC3
            // 
            this.buttonC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC3.Location = new System.Drawing.Point(174, 189);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(75, 75);
            this.buttonC3.TabIndex = 9;
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.buttonClick);
            this.buttonC3.MouseEnter += new System.EventHandler(this.Benter);
            this.buttonC3.MouseLeave += new System.EventHandler(this.Bleave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tie Count";
            // 
            // labelXwin
            // 
            this.labelXwin.AutoSize = true;
            this.labelXwin.Location = new System.Drawing.Point(43, 296);
            this.labelXwin.Name = "labelXwin";
            this.labelXwin.Size = new System.Drawing.Size(13, 13);
            this.labelXwin.TabIndex = 13;
            this.labelXwin.Text = "0";
            // 
            // labelTIE
            // 
            this.labelTIE.AutoSize = true;
            this.labelTIE.Location = new System.Drawing.Point(125, 296);
            this.labelTIE.Name = "labelTIE";
            this.labelTIE.Size = new System.Drawing.Size(13, 13);
            this.labelTIE.TabIndex = 14;
            this.labelTIE.Text = "0";
            // 
            // labelOwin
            // 
            this.labelOwin.AutoSize = true;
            this.labelOwin.Location = new System.Drawing.Point(207, 296);
            this.labelOwin.Name = "labelOwin";
            this.labelOwin.Size = new System.Drawing.Size(13, 13);
            this.labelOwin.TabIndex = 15;
            this.labelOwin.Text = "0";
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // textBox1P1
            // 
            this.textBox1P1.Location = new System.Drawing.Point(13, 270);
            this.textBox1P1.Name = "textBox1P1";
            this.textBox1P1.Size = new System.Drawing.Size(74, 20);
            this.textBox1P1.TabIndex = 16;
            this.textBox1P1.Text = "Player 1";
            this.textBox1P1.TextChanged += new System.EventHandler(this.textBox1P1_TextChanged);
            // 
            // textBox2P2
            // 
            this.textBox2P2.Location = new System.Drawing.Point(175, 270);
            this.textBox2P2.Name = "textBox2P2";
            this.textBox2P2.Size = new System.Drawing.Size(74, 20);
            this.textBox2P2.TabIndex = 17;
            this.textBox2P2.Text = "Player 2";
            this.textBox2P2.TextChanged += new System.EventHandler(this.textBox2P2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2P2);
            this.Controls.Add(this.textBox1P1);
            this.Controls.Add(this.labelOwin);
            this.Controls.Add(this.labelTIE);
            this.Controls.Add(this.labelXwin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelXwin;
        private System.Windows.Forms.Label labelTIE;
        private System.Windows.Forms.Label labelOwin;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1P1;
        private System.Windows.Forms.TextBox textBox2P2;
        private System.Windows.Forms.Button button1;
    }
}

