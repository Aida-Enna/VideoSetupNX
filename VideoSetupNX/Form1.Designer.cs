namespace VideoPreperationTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertSwitchVideos = new System.Windows.Forms.Button();
            this.lblStep5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBannerFile = new System.Windows.Forms.TextBox();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.chkAspectRatio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkKeepSubs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate project";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Step 4: Generate the HTML (and other files)";
            // 
            // btnConvertSwitchVideos
            // 
            this.btnConvertSwitchVideos.Location = new System.Drawing.Point(11, 253);
            this.btnConvertSwitchVideos.Name = "btnConvertSwitchVideos";
            this.btnConvertSwitchVideos.Size = new System.Drawing.Size(226, 31);
            this.btnConvertSwitchVideos.TabIndex = 11;
            this.btnConvertSwitchVideos.Text = "Convert videos to Switch-compatible format";
            this.btnConvertSwitchVideos.UseVisualStyleBackColor = true;
            this.btnConvertSwitchVideos.Click += new System.EventHandler(this.btnConvertSwitchVideos_Click);
            // 
            // lblStep5
            // 
            this.lblStep5.AutoSize = true;
            this.lblStep5.Location = new System.Drawing.Point(12, 209);
            this.lblStep5.Name = "lblStep5";
            this.lblStep5.Size = new System.Drawing.Size(304, 13);
            this.lblStep5.TabIndex = 12;
            this.lblStep5.Text = "Step 5: Use the Homebrew Web Framework to build your NSP!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Extras:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 21);
            this.button2.TabIndex = 16;
            this.button2.Text = "Select File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtBannerFile
            // 
            this.txtBannerFile.Location = new System.Drawing.Point(11, 133);
            this.txtBannerFile.Name = "txtBannerFile";
            this.txtBannerFile.Size = new System.Drawing.Size(213, 20);
            this.txtBannerFile.TabIndex = 15;
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Location = new System.Drawing.Point(9, 116);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(261, 13);
            this.lblStep3.TabIndex = 14;
            this.lblStep3.Text = "Step 3: Select a banner file (1280x140 recommended)";
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Location = new System.Drawing.Point(241, 240);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(154, 17);
            this.chkResize.TabIndex = 17;
            this.chkResize.Text = "Resize videos to 1280x720";
            this.chkResize.UseVisualStyleBackColor = true;
            this.chkResize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkAspectRatio
            // 
            this.chkAspectRatio.AutoSize = true;
            this.chkAspectRatio.Enabled = false;
            this.chkAspectRatio.Location = new System.Drawing.Point(241, 260);
            this.chkAspectRatio.Name = "chkAspectRatio";
            this.chkAspectRatio.Size = new System.Drawing.Size(176, 17);
            this.chkAspectRatio.TabIndex = 18;
            this.chkAspectRatio.Text = "Keep aspect ratio when resizing";
            this.chkAspectRatio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Credits:\r\nSuperOkazaki/OkazakiTheOtaku for their awesome HTML work\r\n(https://gith" +
    "ub.com/SuperOkazaki/HTML-Video-Template-NX)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // chkKeepSubs
            // 
            this.chkKeepSubs.AutoSize = true;
            this.chkKeepSubs.Location = new System.Drawing.Point(241, 280);
            this.chkKeepSubs.Name = "chkKeepSubs";
            this.chkKeepSubs.Size = new System.Drawing.Size(92, 17);
            this.chkKeepSubs.TabIndex = 20;
            this.chkKeepSubs.Text = "Keep subtitles";
            this.chkKeepSubs.UseVisualStyleBackColor = true;
            this.chkKeepSubs.CheckedChanged += new System.EventHandler(this.chkKeepSubs_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 340);
            this.Controls.Add(this.chkKeepSubs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAspectRatio);
            this.Controls.Add(this.chkResize);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBannerFile);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStep5);
            this.Controls.Add(this.btnConvertSwitchVideos);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertSwitchVideos;
        private System.Windows.Forms.Label lblStep5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBannerFile;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.CheckBox chkAspectRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkKeepSubs;
    }
}

