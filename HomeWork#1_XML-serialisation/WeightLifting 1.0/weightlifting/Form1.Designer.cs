namespace weightlifting
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyrightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.numericUpDown_snatch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_clean_jerk = new System.Windows.Forms.NumericUpDown();
            this.radioButton_gmen = new System.Windows.Forms.RadioButton();
            this.radioButton_gwomen = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_snatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clean_jerk)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyrightsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.viewHelpToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // copyrightsToolStripMenuItem
            // 
            this.copyrightsToolStripMenuItem.Name = "copyrightsToolStripMenuItem";
            this.copyrightsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.copyrightsToolStripMenuItem.Text = "О программе";
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(129, 27);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(418, 134);
            this.listBox_output.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(99, 341);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(180, 341);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 3;
            this.del_button.Text = "del";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(324, 340);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "clr";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(99, 213);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(100, 20);
            this.textBox_fname.TabIndex = 1;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(99, 259);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(100, 20);
            this.textBox_lname.TabIndex = 2;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(99, 302);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(100, 20);
            this.textBox_country.TabIndex = 3;
            // 
            // numericUpDown_snatch
            // 
            this.numericUpDown_snatch.Location = new System.Drawing.Point(292, 212);
            this.numericUpDown_snatch.Name = "numericUpDown_snatch";
            this.numericUpDown_snatch.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_snatch.TabIndex = 4;
            // 
            // numericUpDown_clean_jerk
            // 
            this.numericUpDown_clean_jerk.Location = new System.Drawing.Point(292, 258);
            this.numericUpDown_clean_jerk.Name = "numericUpDown_clean_jerk";
            this.numericUpDown_clean_jerk.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_clean_jerk.TabIndex = 5;
            // 
            // radioButton_gmen
            // 
            this.radioButton_gmen.AutoSize = true;
            this.radioButton_gmen.Checked = true;
            this.radioButton_gmen.Location = new System.Drawing.Point(210, 168);
            this.radioButton_gmen.Name = "radioButton_gmen";
            this.radioButton_gmen.Size = new System.Drawing.Size(45, 17);
            this.radioButton_gmen.TabIndex = 10;
            this.radioButton_gmen.TabStop = true;
            this.radioButton_gmen.Text = "men";
            this.radioButton_gmen.UseVisualStyleBackColor = true;
            // 
            // radioButton_gwomen
            // 
            this.radioButton_gwomen.AutoSize = true;
            this.radioButton_gwomen.Location = new System.Drawing.Point(354, 168);
            this.radioButton_gwomen.Name = "radioButton_gwomen";
            this.radioButton_gwomen.Size = new System.Drawing.Size(59, 17);
            this.radioButton_gwomen.TabIndex = 11;
            this.radioButton_gwomen.Text = "women";
            this.radioButton_gwomen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.radioButton_gwomen);
            this.Controls.Add(this.radioButton_gmen);
            this.Controls.Add(this.numericUpDown_clean_jerk);
            this.Controls.Add(this.numericUpDown_snatch);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.textBox_lname);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "WeightLift 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_snatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clean_jerk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox listBox_output;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.NumericUpDown numericUpDown_snatch;
        private System.Windows.Forms.NumericUpDown numericUpDown_clean_jerk;
        private System.Windows.Forms.RadioButton radioButton_gmen;
        private System.Windows.Forms.RadioButton radioButton_gwomen;

    }
}

