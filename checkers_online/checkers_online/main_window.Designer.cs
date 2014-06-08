namespace checkers_online
{
    partial class Main_window
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connection_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.about_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame_ToolStripMenuItem,
            this.restartGame_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.exit_ToolStripMenuItem});
            this.играToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // newGame_ToolStripMenuItem
            // 
            this.newGame_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initGame_ToolStripMenuItem,
            this.joinGame_ToolStripMenuItem});
            this.newGame_ToolStripMenuItem.Name = "newGame_ToolStripMenuItem";
            this.newGame_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newGame_ToolStripMenuItem.Text = "Новая игра";
            // 
            // initGame_ToolStripMenuItem
            // 
            this.initGame_ToolStripMenuItem.Name = "initGame_ToolStripMenuItem";
            this.initGame_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.initGame_ToolStripMenuItem.Text = "Создать игру";
            this.initGame_ToolStripMenuItem.Click += new System.EventHandler(this.initGame_ToolStripMenuItem_Click);
            // 
            // joinGame_ToolStripMenuItem
            // 
            this.joinGame_ToolStripMenuItem.Name = "joinGame_ToolStripMenuItem";
            this.joinGame_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.joinGame_ToolStripMenuItem.Text = "Подключиться...";
            this.joinGame_ToolStripMenuItem.Click += new System.EventHandler(this.joinGame_ToolStripMenuItem_Click);
            // 
            // restartGame_ToolStripMenuItem
            // 
            this.restartGame_ToolStripMenuItem.Name = "restartGame_ToolStripMenuItem";
            this.restartGame_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.restartGame_ToolStripMenuItem.Text = "Разорвать соединение";
            this.restartGame_ToolStripMenuItem.Click += new System.EventHandler(this.restartGame_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exit_ToolStripMenuItem.Text = "Выход";
            // 
            // about_ToolStripMenuItem
            // 
            this.about_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.about_ToolStripMenuItem.Name = "about_ToolStripMenuItem";
            this.about_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.about_ToolStripMenuItem.Text = "О программе";
            // 
            // connection_panel
            // 
            this.connection_panel.Location = new System.Drawing.Point(613, 297);
            this.connection_panel.Name = "connection_panel";
            this.connection_panel.Size = new System.Drawing.Size(171, 145);
            this.connection_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(701, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "white";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(701, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "black";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(623, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Main_window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connection_panel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1067, 600);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initGame_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinGame_ToolStripMenuItem;
        private System.Windows.Forms.Panel connection_panel;
        private System.Windows.Forms.ToolStripMenuItem restartGame_ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

