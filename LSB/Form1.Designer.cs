namespace LSB
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
            this.buttonIn = new System.Windows.Forms.Button();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelOutputText = new System.Windows.Forms.Label();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.buttonSaveImg = new System.Windows.Forms.Button();
            this.chooseMethod = new System.Windows.Forms.ComboBox();
            this.buttonNewFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(382, 196);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(98, 23);
            this.buttonIn.TabIndex = 0;
            this.buttonIn.Text = "Встроить";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Location = new System.Drawing.Point(523, 54);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRight.TabIndex = 2;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Location = new System.Drawing.Point(39, 54);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeft.TabIndex = 3;
            this.pictureBoxLeft.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 54);
            this.textBox1.MaxLength = 10327670;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(151, 88);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Message";
            // 
            // labelOutputText
            // 
            this.labelOutputText.AutoSize = true;
            this.labelOutputText.Location = new System.Drawing.Point(60, 390);
            this.labelOutputText.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelOutputText.Name = "labelOutputText";
            this.labelOutputText.Size = new System.Drawing.Size(132, 13);
            this.labelOutputText.TabIndex = 5;
            this.labelOutputText.Text = "Распакованные данные:";
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(382, 234);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(98, 23);
            this.buttonOut.TabIndex = 6;
            this.buttonOut.Text = "Распаковать";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(382, 313);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(98, 41);
            this.buttonSaveText.TabIndex = 8;
            this.buttonSaveText.Text = "Сохранить текст";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            this.buttonSaveText.Click += new System.EventHandler(this.buttonSaveText_Click);
            // 
            // buttonSaveImg
            // 
            this.buttonSaveImg.Location = new System.Drawing.Point(382, 263);
            this.buttonSaveImg.Name = "buttonSaveImg";
            this.buttonSaveImg.Size = new System.Drawing.Size(98, 44);
            this.buttonSaveImg.TabIndex = 9;
            this.buttonSaveImg.Text = "Сохранить изображение";
            this.buttonSaveImg.UseVisualStyleBackColor = true;
            this.buttonSaveImg.Click += new System.EventHandler(this.buttonSaveImg_Click);
            // 
            // chooseMethod
            // 
            this.chooseMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseMethod.FormattingEnabled = true;
            this.chooseMethod.Items.AddRange(new object[] {
            "НЗБ",
            "ПСИ",
            "ПСП"});
            this.chooseMethod.Location = new System.Drawing.Point(371, 158);
            this.chooseMethod.Name = "chooseMethod";
            this.chooseMethod.Size = new System.Drawing.Size(121, 21);
            this.chooseMethod.TabIndex = 10;
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.Location = new System.Drawing.Point(39, 22);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(105, 23);
            this.buttonNewFile.TabIndex = 11;
            this.buttonNewFile.Text = "Открыть файл";
            this.buttonNewFile.UseVisualStyleBackColor = true;
            this.buttonNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 441);
            this.Controls.Add(this.buttonNewFile);
            this.Controls.Add(this.chooseMethod);
            this.Controls.Add(this.buttonSaveImg);
            this.Controls.Add(this.buttonSaveText);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.labelOutputText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.buttonIn);
            this.Name = "Form1";
            this.Text = "Встраивание данных в изображение";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelOutputText;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonSaveText;
        private System.Windows.Forms.Button buttonSaveImg;
        private System.Windows.Forms.ComboBox chooseMethod;
        private System.Windows.Forms.Button buttonNewFile;
    }
}

