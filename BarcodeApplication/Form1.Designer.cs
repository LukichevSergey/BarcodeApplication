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
            this.label2 = new System.Windows.Forms.Label();
            this.decodeText = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeImage
            // 
            this.barcodeImage.BackColor = System.Drawing.Color.White;
            this.barcodeImage.Location = new System.Drawing.Point(12, 12);
            this.barcodeImage.Name = "barcodeImage";
            this.barcodeImage.Size = new System.Drawing.Size(376, 209);
            this.barcodeImage.TabIndex = 0;
            this.barcodeImage.TabStop = false;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(223, 320);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 1;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encode";
            // 
            // encodeText
            // 
            this.encodeText.Location = new System.Drawing.Point(62, 238);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(326, 20);
            this.encodeText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decode";
            // 
            // decodeText
            // 
            this.decodeText.Location = new System.Drawing.Point(62, 276);
            this.decodeText.Name = "decodeText";
            this.decodeText.Size = new System.Drawing.Size(326, 20);
            this.decodeText.TabIndex = 5;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(313, 320);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 6;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 359);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.decodeText);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decodeText;
        private System.Windows.Forms.Button decodeButton;
    }
}

