
namespace number
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
            this.txtYazıTura = new System.Windows.Forms.TextBox();
            this.btnFırlat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYazıTura
            // 
            this.txtYazıTura.Location = new System.Drawing.Point(168, 167);
            this.txtYazıTura.Name = "txtYazıTura";
            this.txtYazıTura.Size = new System.Drawing.Size(181, 20);
            this.txtYazıTura.TabIndex = 0;
            // 
            // btnFırlat
            // 
            this.btnFırlat.Location = new System.Drawing.Point(530, 167);
            this.btnFırlat.Name = "btnFırlat";
            this.btnFırlat.Size = new System.Drawing.Size(139, 93);
            this.btnFırlat.TabIndex = 1;
            this.btnFırlat.Text = "Fırlat";
            this.btnFırlat.UseVisualStyleBackColor = true;
            this.btnFırlat.Click += new System.EventHandler(this.btnFırlat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFırlat);
            this.Controls.Add(this.txtYazıTura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazıTura;
        private System.Windows.Forms.Button btnFırlat;
    }
}

