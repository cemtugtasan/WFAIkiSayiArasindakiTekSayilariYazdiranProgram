
namespace WFAikiSayiArasındakiTekSayılarıBulma
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.MaskedTextBox();
            this.btnGöster = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(20, 28);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(204, 26);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(20, 64);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(204, 26);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSayi2_MaskInputRejected);
            // 
            // btnGöster
            // 
            this.btnGöster.Location = new System.Drawing.Point(20, 98);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(204, 35);
            this.btnGöster.TabIndex = 2;
            this.btnGöster.Text = "TekSayilariGöster";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.Linen;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSonuc.Location = new System.Drawing.Point(20, 147);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(204, 53);
            this.lblSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 226);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.MaskedTextBox txtSayi2;
        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.Label lblSonuc;
    }
}

