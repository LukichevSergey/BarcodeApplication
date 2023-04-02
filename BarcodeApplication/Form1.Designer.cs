namespace BarcodeApplication
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
            this.barcodeImage = new System.Windows.Forms.PictureBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encodeText = new System.Windows.Forms.TextBox();
            this.dropDownList = new System.Windows.Forms.ComboBox();
            this.barcodeItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeImage
            // 
            this.barcodeImage.BackColor = System.Drawing.Color.White;
            this.barcodeImage.Location = new System.Drawing.Point(144, 12);
            this.barcodeImage.Name = "barcodeImage";
            this.barcodeImage.Size = new System.Drawing.Size(376, 205);
            this.barcodeImage.TabIndex = 0;
            this.barcodeImage.TabStop = false;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(355, 262);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(159, 23);
            this.encodeButton.TabIndex = 1;
            this.encodeButton.Text = "Сгенерировать штрих-код";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данные штрих-кода";
            // 
            // encodeText
            // 
            this.encodeText.Location = new System.Drawing.Point(255, 236);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(265, 20);
            this.encodeText.TabIndex = 3;
            // 
            // dropDownList
            // 
            this.dropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.Location = new System.Drawing.Point(12, 218);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(121, 21);
            this.dropDownList.TabIndex = 8;
            this.dropDownList.SelectedIndexChanged += new System.EventHandler(this.dropDownList_SelectedIndexChanged);
            // 
            // barcodeItems
            // 
            this.barcodeItems.FormattingEnabled = true;
            this.barcodeItems.Location = new System.Drawing.Point(13, 13);
            this.barcodeItems.Name = "barcodeItems";
            this.barcodeItems.Size = new System.Drawing.Size(120, 199);
            this.barcodeItems.TabIndex = 9;
            this.barcodeItems.SelectedIndexChanged += new System.EventHandler(this.barcodeItems_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 296);
            this.Controls.Add(this.barcodeItems);
            this.Controls.Add(this.dropDownList);
            this.Controls.Add(this.encodeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.barcodeImage);
            this.Name = "Form1";
            this.Text = "Barcode Application";
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox barcodeImage;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encodeText;
        private System.Windows.Forms.ComboBox dropDownList;
        private System.Windows.Forms.ListBox barcodeItems;
    }
}

