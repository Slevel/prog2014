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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_bWeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_summ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_snatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clean_jerk)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
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
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
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
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.viewHelpToolStripMenuItem.Text = "Просмотреть справку";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // copyrightsToolStripMenuItem
            // 
            this.copyrightsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyrightsToolStripMenuItem.Image")));
            this.copyrightsToolStripMenuItem.Name = "copyrightsToolStripMenuItem";
            this.copyrightsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.copyrightsToolStripMenuItem.Text = "О программе";
            this.copyrightsToolStripMenuItem.Click += new System.EventHandler(this.copyrightsToolStripMenuItem_Click);
            // 
            // listBox_output
            // 
            this.listBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(12, 27);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(657, 186);
            this.listBox_output.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(142, 151);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 23);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Добавить";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // del_button
            // 
            this.del_button.Image = ((System.Drawing.Image)(resources.GetObject("del_button.Image")));
            this.del_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_button.Location = new System.Drawing.Point(230, 151);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 10;
            this.del_button.Text = "Удалить";
            this.del_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_button.Image")));
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_button.Location = new System.Drawing.Point(311, 151);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(81, 23);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Очистить";
            this.clear_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(9, 31);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(100, 20);
            this.textBox_fname.TabIndex = 1;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(9, 70);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(100, 20);
            this.textBox_lname.TabIndex = 2;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(9, 109);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(100, 20);
            this.textBox_country.TabIndex = 3;
            // 
            // numericUpDown_snatch
            // 
            this.numericUpDown_snatch.Location = new System.Drawing.Point(12, 32);
            this.numericUpDown_snatch.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_snatch.Name = "numericUpDown_snatch";
            this.numericUpDown_snatch.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_snatch.TabIndex = 7;
            this.numericUpDown_snatch.ValueChanged += new System.EventHandler(this.numericUpDown_snatch_ValueChanged);
            // 
            // numericUpDown_clean_jerk
            // 
            this.numericUpDown_clean_jerk.Location = new System.Drawing.Point(12, 74);
            this.numericUpDown_clean_jerk.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDown_clean_jerk.Name = "numericUpDown_clean_jerk";
            this.numericUpDown_clean_jerk.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_clean_jerk.TabIndex = 8;
            this.numericUpDown_clean_jerk.ValueChanged += new System.EventHandler(this.numericUpDown_clean_jerk_ValueChanged);
            // 
            // radioButton_gmen
            // 
            this.radioButton_gmen.AutoSize = true;
            this.radioButton_gmen.Checked = true;
            this.radioButton_gmen.Location = new System.Drawing.Point(149, 32);
            this.radioButton_gmen.Name = "radioButton_gmen";
            this.radioButton_gmen.Size = new System.Drawing.Size(71, 17);
            this.radioButton_gmen.TabIndex = 4;
            this.radioButton_gmen.TabStop = true;
            this.radioButton_gmen.Text = "Мужской";
            this.radioButton_gmen.UseVisualStyleBackColor = true;
            // 
            // radioButton_gwomen
            // 
            this.radioButton_gwomen.AutoSize = true;
            this.radioButton_gwomen.Location = new System.Drawing.Point(149, 62);
            this.radioButton_gwomen.Name = "radioButton_gwomen";
            this.radioButton_gwomen.Size = new System.Drawing.Size(72, 17);
            this.radioButton_gwomen.TabIndex = 5;
            this.radioButton_gwomen.Text = "Женский";
            this.radioButton_gwomen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDown_bWeight);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.del_button);
            this.groupBox1.Controls.Add(this.clear_button);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_fname);
            this.groupBox1.Controls.Add(this.radioButton_gwomen);
            this.groupBox1.Controls.Add(this.textBox_lname);
            this.groupBox1.Controls.Add(this.radioButton_gmen);
            this.groupBox1.Controls.Add(this.textBox_country);
            this.groupBox1.Location = new System.Drawing.Point(669, 27);
            this.groupBox1.MaximumSize = new System.Drawing.Size(400, 185);
            this.groupBox1.MinimumSize = new System.Drawing.Size(400, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о спортсмене:";
            // 
            // numericUpDown_bWeight
            // 
            this.numericUpDown_bWeight.Location = new System.Drawing.Point(149, 109);
            this.numericUpDown_bWeight.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_bWeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_bWeight.Name = "numericUpDown_bWeight";
            this.numericUpDown_bWeight.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_bWeight.TabIndex = 6;
            this.numericUpDown_bWeight.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Вес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Пол:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_summ);
            this.groupBox2.Controls.Add(this.numericUpDown_snatch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown_clean_jerk);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(237, 16);
            this.groupBox2.MinimumSize = new System.Drawing.Size(155, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 128);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показанный результат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Сумма двоеборья:";
            // 
            // label_summ
            // 
            this.label_summ.AutoSize = true;
            this.label_summ.Location = new System.Drawing.Point(114, 102);
            this.label_summ.Name = "label_summ";
            this.label_summ.Size = new System.Drawing.Size(18, 13);
            this.label_summ.TabIndex = 18;
            this.label_summ.Text = "-/-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Толчок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Рывок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Город/Страна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя:";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.printToolStripMenuItem.Text = "Печать...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 237);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1085, 275);
            this.Name = "Form1";
            this.Text = "WeightLift 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_snatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_clean_jerk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_summ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_bWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}

