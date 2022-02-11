namespace Factory_1._1
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.richTextBoxMonitor = new System.Windows.Forms.RichTextBox();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.textBoxSale = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMagazine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(514, 52);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 28);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(514, 86);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(93, 28);
            this.buttonMake.TabIndex = 1;
            this.buttonMake.Text = "Произвести";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(514, 120);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(93, 28);
            this.buttonSale.TabIndex = 2;
            this.buttonSale.Text = "Продать";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(366, 12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(95, 28);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click_1);
            // 
            // richTextBoxMonitor
            // 
            this.richTextBoxMonitor.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxMonitor.Name = "richTextBoxMonitor";
            this.richTextBoxMonitor.Size = new System.Drawing.Size(348, 283);
            this.richTextBoxMonitor.TabIndex = 4;
            this.richTextBoxMonitor.Text = "";
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.Location = new System.Drawing.Point(366, 57);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoad.TabIndex = 5;
            this.textBoxLoad.TextChanged += new System.EventHandler(this.textBoxLoad_TextChanged);
            // 
            // textBoxSale
            // 
            this.textBoxSale.Location = new System.Drawing.Point(366, 125);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.Size = new System.Drawing.Size(100, 20);
            this.textBoxSale.TabIndex = 6;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(366, 91);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(100, 20);
            this.textBoxMake.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "шт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "шт";
            // 
            // buttonMagazine
            // 
            this.buttonMagazine.Location = new System.Drawing.Point(467, 12);
            this.buttonMagazine.Name = "buttonMagazine";
            this.buttonMagazine.Size = new System.Drawing.Size(95, 28);
            this.buttonMagazine.TabIndex = 11;
            this.buttonMagazine.Text = "Журнал";
            this.buttonMagazine.UseVisualStyleBackColor = true;
            this.buttonMagazine.Click += new System.EventHandler(this.buttonMagazine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 307);
            this.Controls.Add(this.buttonMagazine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxSale);
            this.Controls.Add(this.textBoxLoad);
            this.Controls.Add(this.richTextBoxMonitor);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "FactoryMask";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.RichTextBox richTextBoxMonitor;
        private System.Windows.Forms.TextBox textBoxLoad;
        private System.Windows.Forms.TextBox textBoxSale;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMagazine;
    }
}

