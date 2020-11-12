namespace CurrencyConverterForms
{
    partial class FrmCurrency
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConvert = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FromUS = new System.Windows.Forms.RadioButton();
            this.FromUK = new System.Windows.Forms.RadioButton();
            this.FromAUS = new System.Windows.Forms.RadioButton();
            this.ToUS = new System.Windows.Forms.RadioButton();
            this.ToUK = new System.Windows.Forms.RadioButton();
            this.ToAus = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(25, 24);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(57, 17);
            this.lblConvert.TabIndex = 0;
            this.lblConvert.Text = "Convert";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(91, 24);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 22);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FromAUS);
            this.groupBox2.Controls.Add(this.FromUK);
            this.groupBox2.Controls.Add(this.FromUS);
            this.groupBox2.Location = new System.Drawing.Point(28, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToAus);
            this.groupBox1.Controls.Add(this.ToUK);
            this.groupBox1.Controls.Add(this.ToUS);
            this.groupBox1.Location = new System.Drawing.Point(136, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(256, 73);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(256, 108);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(16, 17);
            this.Result.TabIndex = 5;
            this.Result.Text = "0";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(259, 150);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FromUS
            // 
            this.FromUS.AutoSize = true;
            this.FromUS.Checked = true;
            this.FromUS.Location = new System.Drawing.Point(17, 22);
            this.FromUS.Name = "FromUS";
            this.FromUS.Size = new System.Drawing.Size(56, 21);
            this.FromUS.TabIndex = 0;
            this.FromUS.TabStop = true;
            this.FromUS.Text = "US$";
            this.FromUS.UseVisualStyleBackColor = true;
            // 
            // FromUK
            // 
            this.FromUK.AutoSize = true;
            this.FromUK.Location = new System.Drawing.Point(17, 52);
            this.FromUK.Name = "FromUK";
            this.FromUK.Size = new System.Drawing.Size(56, 21);
            this.FromUK.TabIndex = 1;
            this.FromUK.TabStop = true;
            this.FromUK.Text = "UK£";
            this.FromUK.UseVisualStyleBackColor = true;
            // 
            // FromAUS
            // 
            this.FromAUS.AutoSize = true;
            this.FromAUS.Location = new System.Drawing.Point(17, 79);
            this.FromAUS.Name = "FromAUS";
            this.FromAUS.Size = new System.Drawing.Size(65, 21);
            this.FromAUS.TabIndex = 2;
            this.FromAUS.TabStop = true;
            this.FromAUS.Text = "AUS$";
            this.FromAUS.UseVisualStyleBackColor = true;
            // 
            // ToUS
            // 
            this.ToUS.AutoSize = true;
            this.ToUS.Checked = true;
            this.ToUS.Location = new System.Drawing.Point(16, 22);
            this.ToUS.Name = "ToUS";
            this.ToUS.Size = new System.Drawing.Size(56, 21);
            this.ToUS.TabIndex = 0;
            this.ToUS.TabStop = true;
            this.ToUS.Text = "US$";
            this.ToUS.UseVisualStyleBackColor = true;
            // 
            // ToUK
            // 
            this.ToUK.AutoSize = true;
            this.ToUK.Location = new System.Drawing.Point(16, 48);
            this.ToUK.Name = "ToUK";
            this.ToUK.Size = new System.Drawing.Size(56, 21);
            this.ToUK.TabIndex = 1;
            this.ToUK.TabStop = true;
            this.ToUK.Text = "UK£";
            this.ToUK.UseVisualStyleBackColor = true;
            // 
            // ToAus
            // 
            this.ToAus.AutoSize = true;
            this.ToAus.Location = new System.Drawing.Point(16, 78);
            this.ToAus.Name = "ToAus";
            this.ToAus.Size = new System.Drawing.Size(65, 21);
            this.ToAus.TabIndex = 2;
            this.ToAus.TabStop = true;
            this.ToAus.Text = "AUS$";
            this.ToAus.UseVisualStyleBackColor = true;
            // 
            // FrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 202);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblConvert);
            this.Name = "FrmCurrency";
            this.Text = "$ Converter";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FromAUS;
        private System.Windows.Forms.RadioButton FromUK;
        private System.Windows.Forms.RadioButton FromUS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ToAus;
        private System.Windows.Forms.RadioButton ToUK;
        private System.Windows.Forms.RadioButton ToUS;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ConvertButton;
    }
}

