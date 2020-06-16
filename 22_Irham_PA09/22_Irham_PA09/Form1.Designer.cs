namespace _22_Irham_PA09
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_SelectCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_Amount = new System.Windows.Forms.TextBox();
            this.txtBx_Value = new System.Windows.Forms.TextBox();
            this.btn_JPYen = new System.Windows.Forms.RadioButton();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_USD = new System.Windows.Forms.RadioButton();
            this.btn_ring = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(59, 112);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 0;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_SelectCurrency
            // 
            this.lbl_SelectCurrency.AutoSize = true;
            this.lbl_SelectCurrency.Location = new System.Drawing.Point(59, 211);
            this.lbl_SelectCurrency.Name = "lbl_SelectCurrency";
            this.lbl_SelectCurrency.Size = new System.Drawing.Size(85, 13);
            this.lbl_SelectCurrency.TabIndex = 1;
            this.lbl_SelectCurrency.Text = "Select Currency ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // txtBx_Amount
            // 
            this.txtBx_Amount.Location = new System.Drawing.Point(257, 109);
            this.txtBx_Amount.Name = "txtBx_Amount";
            this.txtBx_Amount.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Amount.TabIndex = 3;
            this.txtBx_Amount.TextChanged += new System.EventHandler(this.txtBx_Amount_TextChanged);
            // 
            // txtBx_Value
            // 
            this.txtBx_Value.Location = new System.Drawing.Point(257, 291);
            this.txtBx_Value.Name = "txtBx_Value";
            this.txtBx_Value.ReadOnly = true;
            this.txtBx_Value.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Value.TabIndex = 4;
            // 
            // btn_JPYen
            // 
            this.btn_JPYen.AutoSize = true;
            this.btn_JPYen.Location = new System.Drawing.Point(257, 203);
            this.btn_JPYen.Name = "btn_JPYen";
            this.btn_JPYen.Size = new System.Drawing.Size(93, 17);
            this.btn_JPYen.TabIndex = 6;
            this.btn_JPYen.TabStop = true;
            this.btn_JPYen.Text = "Japanese Yen";
            this.btn_JPYen.UseVisualStyleBackColor = true;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(471, 180);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(471, 228);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_USD
            // 
            this.btn_USD.AutoSize = true;
            this.btn_USD.Location = new System.Drawing.Point(257, 180);
            this.btn_USD.Name = "btn_USD";
            this.btn_USD.Size = new System.Drawing.Size(75, 17);
            this.btn_USD.TabIndex = 9;
            this.btn_USD.TabStop = true;
            this.btn_USD.Text = "US Dollars";
            this.btn_USD.UseVisualStyleBackColor = true;
            // 
            // btn_ring
            // 
            this.btn_ring.AutoSize = true;
            this.btn_ring.Location = new System.Drawing.Point(257, 226);
            this.btn_ring.Name = "btn_ring";
            this.btn_ring.Size = new System.Drawing.Size(108, 17);
            this.btn_ring.TabIndex = 10;
            this.btn_ring.TabStop = true;
            this.btn_ring.Text = "Malaysian Ringgit";
            this.btn_ring.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 371);
            this.Controls.Add(this.btn_ring);
            this.Controls.Add(this.btn_USD);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_JPYen);
            this.Controls.Add(this.txtBx_Value);
            this.Controls.Add(this.txtBx_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SelectCurrency);
            this.Controls.Add(this.lbl_Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_SelectCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_Amount;
        private System.Windows.Forms.TextBox txtBx_Value;
        private System.Windows.Forms.RadioButton btn_JPYen;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RadioButton btn_USD;
        private System.Windows.Forms.RadioButton btn_ring;
    }
}

