namespace Курсовая_2._0
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЭкзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗачётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet = new Курсовая_2._0.bdDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЧасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зачётDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.фамилияПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДисциплиныDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЧасовDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПреподавателяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.groupTableAdapter = new Курсовая_2._0.bdDataSetTableAdapters.GroupTableAdapter();
            this.studentTableAdapter = new Курсовая_2._0.bdDataSetTableAdapters.StudentTableAdapter();
            this.creditTableAdapter = new Курсовая_2._0.bdDataSetTableAdapters.CreditTableAdapter();
            this.examTableAdapter = new Курсовая_2._0.bdDataSetTableAdapters.ExamTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCreditBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЭкзаменыToolStripMenuItem,
            this.ЗачётыToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // ЭкзаменыToolStripMenuItem
            // 
            this.ЭкзаменыToolStripMenuItem.Name = "ЭкзаменыToolStripMenuItem";
            this.ЭкзаменыToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ЭкзаменыToolStripMenuItem.Text = "Экзамены";
            this.ЭкзаменыToolStripMenuItem.Click += new System.EventHandler(this.ЭкзаменыToolStripMenuItem_Click);
            // 
            // ЗачётыToolStripMenuItem
            // 
            this.ЗачётыToolStripMenuItem.Name = "ЗачётыToolStripMenuItem";
            this.ЗачётыToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ЗачётыToolStripMenuItem.Text = "Зачёты";
            this.ЗачётыToolStripMenuItem.Click += new System.EventHandler(this.ЗачётыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 315);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Группа и студент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(210, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.bdDataSet;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.groupStudentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(210, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(560, 249);
            this.dataGridView2.TabIndex = 2;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Width = 500;
            // 
            // groupStudentBindingSource
            // 
            this.groupStudentBindingSource.DataMember = "GroupStudent";
            this.groupStudentBindingSource.DataSource = this.groupBindingSource;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Зачёты";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ппDataGridViewTextBoxColumn,
            this.названиеДисциплиныDataGridViewTextBoxColumn,
            this.колвоЧасовDataGridViewTextBoxColumn,
            this.зачётDataGridViewCheckBoxColumn,
            this.фамилияПреподавателяDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.studentCreditBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(778, 249);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ппDataGridViewTextBoxColumn
            // 
            this.ппDataGridViewTextBoxColumn.DataPropertyName = "№ п/п";
            this.ппDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.ппDataGridViewTextBoxColumn.Name = "ппDataGridViewTextBoxColumn";
            this.ппDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеДисциплиныDataGridViewTextBoxColumn
            // 
            this.названиеДисциплиныDataGridViewTextBoxColumn.DataPropertyName = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.HeaderText = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.Name = "названиеДисциплиныDataGridViewTextBoxColumn";
            this.названиеДисциплиныDataGridViewTextBoxColumn.Width = 300;
            // 
            // колвоЧасовDataGridViewTextBoxColumn
            // 
            this.колвоЧасовDataGridViewTextBoxColumn.DataPropertyName = "Кол-во часов";
            this.колвоЧасовDataGridViewTextBoxColumn.HeaderText = "Кол-во часов";
            this.колвоЧасовDataGridViewTextBoxColumn.Name = "колвоЧасовDataGridViewTextBoxColumn";
            this.колвоЧасовDataGridViewTextBoxColumn.Width = 50;
            // 
            // зачётDataGridViewCheckBoxColumn
            // 
            this.зачётDataGridViewCheckBoxColumn.DataPropertyName = "Зачёт";
            this.зачётDataGridViewCheckBoxColumn.HeaderText = "Зачёт";
            this.зачётDataGridViewCheckBoxColumn.Name = "зачётDataGridViewCheckBoxColumn";
            this.зачётDataGridViewCheckBoxColumn.Width = 50;
            // 
            // фамилияПреподавателяDataGridViewTextBoxColumn
            // 
            this.фамилияПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.HeaderText = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.Name = "фамилияПреподавателяDataGridViewTextBoxColumn";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.Width = 270;
            // 
            // studentCreditBindingSource
            // 
            this.studentCreditBindingSource.DataMember = "StudentCredit";
            this.studentCreditBindingSource.DataSource = this.groupStudentBindingSource;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Экзамены";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ппDataGridViewTextBoxColumn1,
            this.названиеДисциплиныDataGridViewTextBoxColumn1,
            this.колвоЧасовDataGridViewTextBoxColumn1,
            this.оценкаDataGridViewTextBoxColumn,
            this.фамилияПреподавателяDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.studentExamBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(778, 249);
            this.dataGridView4.TabIndex = 0;
            // 
            // ппDataGridViewTextBoxColumn1
            // 
            this.ппDataGridViewTextBoxColumn1.DataPropertyName = "№ п/п";
            this.ппDataGridViewTextBoxColumn1.HeaderText = "№ п/п";
            this.ппDataGridViewTextBoxColumn1.Name = "ппDataGridViewTextBoxColumn1";
            this.ппDataGridViewTextBoxColumn1.Width = 50;
            // 
            // названиеДисциплиныDataGridViewTextBoxColumn1
            // 
            this.названиеДисциплиныDataGridViewTextBoxColumn1.DataPropertyName = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn1.HeaderText = "Название дисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn1.Name = "названиеДисциплиныDataGridViewTextBoxColumn1";
            this.названиеДисциплиныDataGridViewTextBoxColumn1.Width = 300;
            // 
            // колвоЧасовDataGridViewTextBoxColumn1
            // 
            this.колвоЧасовDataGridViewTextBoxColumn1.DataPropertyName = "Кол-во часов";
            this.колвоЧасовDataGridViewTextBoxColumn1.HeaderText = "Кол-во часов";
            this.колвоЧасовDataGridViewTextBoxColumn1.Name = "колвоЧасовDataGridViewTextBoxColumn1";
            this.колвоЧасовDataGridViewTextBoxColumn1.Width = 50;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.Width = 50;
            // 
            // фамилияПреподавателяDataGridViewTextBoxColumn1
            // 
            this.фамилияПреподавателяDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn1.HeaderText = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn1.Name = "фамилияПреподавателяDataGridViewTextBoxColumn1";
            this.фамилияПреподавателяDataGridViewTextBoxColumn1.Width = 270;
            // 
            // studentExamBindingSource
            // 
            this.studentExamBindingSource.DataMember = "StudentExam";
            this.studentExamBindingSource.DataSource = this.groupStudentBindingSource;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // creditTableAdapter
            // 
            this.creditTableAdapter.ClearBeforeFill = true;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 339);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронная зачётная книжка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCreditBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentExamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ToolStripMenuItem ЭкзаменыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗачётыToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private bdDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource groupStudentBindingSource;
        private bdDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentCreditBindingSource;
        private bdDataSetTableAdapters.CreditTableAdapter creditTableAdapter;
        private System.Windows.Forms.BindingSource studentExamBindingSource;
        private bdDataSetTableAdapters.ExamTableAdapter examTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЧасовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn зачётDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДисциплиныDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЧасовDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПреподавателяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

