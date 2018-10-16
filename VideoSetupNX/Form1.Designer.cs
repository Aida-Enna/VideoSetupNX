﻿namespace VideoPreperationTool
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.txtVideoDirectory = new System.Windows.Forms.TextBox();
            this.btnPickDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblVideoStats = new System.Windows.Forms.Label();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.btnCopyHTML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertSwitchVideos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate HTML in textbox below";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(389, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Title of your video player";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(9, 9);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(113, 13);
            this.lblStep1.TabIndex = 2;
            this.lblStep1.Text = "Step 1: Fill out this info";
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(12, 51);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(389, 20);
            this.txtYourName.TabIndex = 3;
            this.txtYourName.Text = "Your name";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(9, 74);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(207, 13);
            this.lblStep2.TabIndex = 4;
            this.lblStep2.Text = "Step 2: Select the folder your videos are in";
            // 
            // txtVideoDirectory
            // 
            this.txtVideoDirectory.Location = new System.Drawing.Point(12, 90);
            this.txtVideoDirectory.Name = "txtVideoDirectory";
            this.txtVideoDirectory.Size = new System.Drawing.Size(213, 20);
            this.txtVideoDirectory.TabIndex = 5;
            this.txtVideoDirectory.Text = "Directory with switch-compatible videos";
            // 
            // btnPickDirectory
            // 
            this.btnPickDirectory.Location = new System.Drawing.Point(231, 89);
            this.btnPickDirectory.Name = "btnPickDirectory";
            this.btnPickDirectory.Size = new System.Drawing.Size(85, 21);
            this.btnPickDirectory.TabIndex = 6;
            this.btnPickDirectory.Text = "Select Folder";
            this.btnPickDirectory.UseVisualStyleBackColor = true;
            this.btnPickDirectory.Click += new System.EventHandler(this.btnPickDirectory_Click);
            // 
            // lblVideoStats
            // 
            this.lblVideoStats.Location = new System.Drawing.Point(322, 93);
            this.lblVideoStats.Name = "lblVideoStats";
            this.lblVideoStats.Size = new System.Drawing.Size(101, 17);
            this.lblVideoStats.TabIndex = 7;
            // 
            // txtHTML
            // 
            this.txtHTML.Location = new System.Drawing.Point(12, 166);
            this.txtHTML.Multiline = true;
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.Size = new System.Drawing.Size(389, 157);
            this.txtHTML.TabIndex = 8;
            // 
            // btnCopyHTML
            // 
            this.btnCopyHTML.Location = new System.Drawing.Point(219, 129);
            this.btnCopyHTML.Name = "btnCopyHTML";
            this.btnCopyHTML.Size = new System.Drawing.Size(182, 31);
            this.btnCopyHTML.TabIndex = 9;
            this.btnCopyHTML.Text = "Copy HTML to clipboard";
            this.btnCopyHTML.UseVisualStyleBackColor = true;
            this.btnCopyHTML.Click += new System.EventHandler(this.btnCopyHTML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Step 3: Generate the HTML and save it as your index.html";
            // 
            // btnConvertSwitchVideos
            // 
            this.btnConvertSwitchVideos.Location = new System.Drawing.Point(12, 367);
            this.btnConvertSwitchVideos.Name = "btnConvertSwitchVideos";
            this.btnConvertSwitchVideos.Size = new System.Drawing.Size(226, 31);
            this.btnConvertSwitchVideos.TabIndex = 11;
            this.btnConvertSwitchVideos.Text = "Convert videos to Switch-compatible format";
            this.btnConvertSwitchVideos.UseVisualStyleBackColor = true;
            this.btnConvertSwitchVideos.Click += new System.EventHandler(this.btnConvertSwitchVideos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Step 4: Use the Homebrew Web Framework to build your NSP!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Extras:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertSwitchVideos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyHTML);
            this.Controls.Add(this.txtHTML);
            this.Controls.Add(this.lblVideoStats);
            this.Controls.Add(this.btnPickDirectory);
            this.Controls.Add(this.txtVideoDirectory);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "VideoSetupNX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.TextBox txtVideoDirectory;
        private System.Windows.Forms.Button btnPickDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblVideoStats;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.Button btnCopyHTML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertSwitchVideos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
