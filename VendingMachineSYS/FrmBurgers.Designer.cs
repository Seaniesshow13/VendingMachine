﻿
namespace VendingMachineSYS
{
    partial class FrmBurgers
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
            this.btnBackBurgers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackBurgers
            // 
            this.btnBackBurgers.Location = new System.Drawing.Point(20, 20);
            this.btnBackBurgers.Name = "btnBackBurgers";
            this.btnBackBurgers.Size = new System.Drawing.Size(75, 25);
            this.btnBackBurgers.TabIndex = 0;
            this.btnBackBurgers.Text = "Back";
            this.btnBackBurgers.UseVisualStyleBackColor = true;
            this.btnBackBurgers.Click += new System.EventHandler(this.btnBackBurgers_Click);
            // 
            // FrmBurgers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackBurgers);
            this.Name = "FrmBurgers";
            this.Text = "FrmBurgers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackBurgers;
    }
}