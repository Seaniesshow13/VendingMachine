
namespace VendingMachineSYS
{
    partial class FrmWraps
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
            this.btnBackWraps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackWraps
            // 
            this.btnBackWraps.Location = new System.Drawing.Point(20, 20);
            this.btnBackWraps.Name = "btnBackWraps";
            this.btnBackWraps.Size = new System.Drawing.Size(75, 25);
            this.btnBackWraps.TabIndex = 0;
            this.btnBackWraps.Text = "Back";
            this.btnBackWraps.UseVisualStyleBackColor = true;
            this.btnBackWraps.Click += new System.EventHandler(this.btnBackWraps_Click);
            // 
            // FrmWraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackWraps);
            this.Name = "FrmWraps";
            this.Text = "FrmWraps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackWraps;
    }
}