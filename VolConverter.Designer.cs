namespace VolumeConverter
{
    partial class volConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volConverter));
            this.lblConverterTitle = new System.Windows.Forms.Label();
            this.lblCl = new System.Windows.Forms.Label();
            this.lblLitre = new System.Windows.Forms.Label();
            this.txtCl = new System.Windows.Forms.TextBox();
            this.txtLitre = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConverterTitle
            // 
            this.lblConverterTitle.AutoSize = true;
            this.lblConverterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblConverterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverterTitle.ForeColor = System.Drawing.Color.White;
            this.lblConverterTitle.Location = new System.Drawing.Point(155, 42);
            this.lblConverterTitle.Name = "lblConverterTitle";
            this.lblConverterTitle.Size = new System.Drawing.Size(230, 29);
            this.lblConverterTitle.TabIndex = 0;
            this.lblConverterTitle.Text = "Convert CL to Litre";
            // 
            // lblCl
            // 
            this.lblCl.AutoSize = true;
            this.lblCl.Location = new System.Drawing.Point(429, 110);
            this.lblCl.Name = "lblCl";
            this.lblCl.Size = new System.Drawing.Size(29, 20);
            this.lblCl.TabIndex = 1;
            this.lblCl.Text = "CL";
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Location = new System.Drawing.Point(418, 215);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(40, 20);
            this.lblLitre.TabIndex = 2;
            this.lblLitre.Text = "Litre";
            // 
            // txtCl
            // 
            this.txtCl.Location = new System.Drawing.Point(160, 107);
            this.txtCl.Name = "txtCl";
            this.txtCl.Size = new System.Drawing.Size(238, 26);
            this.txtCl.TabIndex = 3;
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(160, 209);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(238, 26);
            this.txtLitre.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(308, 305);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 36);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // volConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VolumeConverter.Properties.Resources.bgimgvc;
            this.ClientSize = new System.Drawing.Size(602, 454);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.txtCl);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.lblCl);
            this.Controls.Add(this.lblConverterTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "volConverter";
            this.Text = "Volume Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConverterTitle;
        private System.Windows.Forms.Label lblCl;
        private System.Windows.Forms.Label lblLitre;
        private System.Windows.Forms.TextBox txtCl;
        private System.Windows.Forms.TextBox txtLitre;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
    }
}

