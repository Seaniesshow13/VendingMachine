
namespace VendingMachineSYS
{
    partial class FrmDrinks
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
            this.btnBackDrinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackDrinks
            // 
            this.btnBackDrinks.Location = new System.Drawing.Point(20, 20);
            this.btnBackDrinks.Name = "btnBackDrinks";
            this.btnBackDrinks.Size = new System.Drawing.Size(75, 25);
            this.btnBackDrinks.TabIndex = 0;
            this.btnBackDrinks.Text = "Back";
            this.btnBackDrinks.UseVisualStyleBackColor = true;
            this.btnBackDrinks.Click += new System.EventHandler(this.btnBackDrinks_Click);
            // 
            // FrmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackDrinks);
            this.Name = "FrmDrinks";
            this.Text = "FrmDrinks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackDrinks;
    }
}