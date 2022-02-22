namespace SpectralLinesTatischev
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.ComboBoxElements = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox1
            // 
            this.picturebox1.Location = new System.Drawing.Point(12, 46);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(520, 105);
            this.picturebox1.TabIndex = 23;
            this.picturebox1.TabStop = false;
            this.picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picterbox1_Paint);
            // 
            // ComboBoxElements
            // 
            this.ComboBoxElements.Font = new System.Drawing.Font("Times New Roman", 10.25F);
            this.ComboBoxElements.FormattingEnabled = true;
            this.ComboBoxElements.Location = new System.Drawing.Point(83, 12);
            this.ComboBoxElements.Name = "ComboBoxElements";
            this.ComboBoxElements.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxElements.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Элемент";
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.buttonShow.Location = new System.Drawing.Point(210, 9);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(121, 31);
            this.buttonShow.TabIndex = 20;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 163);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.ComboBoxElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Спектрограмма";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.ComboBox ComboBoxElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
    }
}

