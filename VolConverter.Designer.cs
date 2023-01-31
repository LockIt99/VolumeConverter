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
            this.lblCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCl.Location = new System.Drawing.Point(429, 110);
            this.lblCl.Name = "lblCl";
            this.lblCl.Size = new System.Drawing.Size(38, 25);
            this.lblCl.TabIndex = 1;
            this.lblCl.Text = "CL";
            this.lblCl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitre.Location = new System.Drawing.Point(418, 215);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(49, 25);
            this.lblLitre.TabIndex = 2;
            this.lblLitre.Text = "Litre";
            this.lblLitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCl
            // 
            this.txtCl.Location = new System.Drawing.Point(160, 107);
            this.txtCl.Multiline = true;
            this.txtCl.Name = "txtCl";
            this.txtCl.Size = new System.Drawing.Size(238, 33);
            this.txtCl.TabIndex = 3;
            this.txtCl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(160, 204);
            this.txtLitre.Multiline = true;
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(238, 31);
            this.txtLitre.TabIndex = 4;
            this.txtLitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Purple;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(303, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Navy;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(160, 307);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(124, 36);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // volConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::VolumeConverter.Properties.Resources.bgimgvc;
            this.ClientSize = new System.Drawing.Size(602, 454);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.txtCl);
            this.Controls.Add(this.lblConverterTitle);
            this.Controls.Add(this.lblCl);
            this.Controls.Add(this.lblLitre);
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

