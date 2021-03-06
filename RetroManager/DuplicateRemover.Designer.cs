﻿namespace RetroManager
{
    partial class DuplicateRemover
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
            this.components = new System.ComponentModel.Container();
            this.txtRegions = new System.Windows.Forms.TextBox();
            this.lbRegions = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ttRegions = new System.Windows.Forms.ToolTip(this.components);
            this.ttDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtRegions
            // 
            this.txtRegions.Location = new System.Drawing.Point(12, 44);
            this.txtRegions.Name = "txtRegions";
            this.txtRegions.Size = new System.Drawing.Size(327, 20);
            this.txtRegions.TabIndex = 0;
            // 
            // lbRegions
            // 
            this.lbRegions.AutoSize = true;
            this.lbRegions.Location = new System.Drawing.Point(9, 28);
            this.lbRegions.Name = "lbRegions";
            this.lbRegions.Size = new System.Drawing.Size(46, 13);
            this.lbRegions.TabIndex = 1;
            this.lbRegions.Text = "Regions";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(12, 143);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSize = true;
            this.lbDirectory.Location = new System.Drawing.Point(9, 81);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Size = new System.Drawing.Size(49, 13);
            this.lbDirectory.TabIndex = 4;
            this.lbDirectory.Text = "Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(12, 97);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(260, 20);
            this.txtDirectory.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(278, 96);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 20);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(197, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DuplicateRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 196);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lbDirectory);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lbRegions);
            this.Controls.Add(this.txtRegions);
            this.Name = "DuplicateRemover";
            this.Text = "Region Duplicate Remover";
            this.Load += new System.EventHandler(this.DuplicateRemover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegions;
        private System.Windows.Forms.Label lbRegions;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip ttRegions;
        private System.Windows.Forms.ToolTip ttDirectory;
    }
}