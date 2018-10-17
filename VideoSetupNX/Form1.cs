using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace VideoPreperationTool
{
    public partial class Form1 : Form
    {
        private string HTML1 = "<!DOCTYPE html>" +
"<html lang=\"en\">" + Environment.NewLine +
"  <head>" + Environment.NewLine +
"    <meta charset=\"UTF-8\">" + Environment.NewLine +
"    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">" + Environment.NewLine +
"    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">" + Environment.NewLine +
"    <title>REPLACEMETITLE</title>" + Environment.NewLine +
"    <!-- Bootstrap -->" + Environment.NewLine +
"    <link href=\"css/bootstrap-4.0.0.css\" rel=\"stylesheet\">" + Environment.NewLine +
"  </head>" + Environment.NewLine +
"  <body>" + Environment.NewLine +
"<header>" + Environment.NewLine +
"  <div class=\"jumbotron\">" + Environment.NewLine +
"\t<div style=\"display: flex; justify-content: center;\">" + Environment.NewLine +
"  <img src=\"img/banner.png\" style=\"width: 1280x; height: 140px;\" />" + Environment.NewLine +
"</div>" + Environment.NewLine +
"<div class=\"container\">" + Environment.NewLine +
"</div>" + Environment.NewLine +
"      </div>" + Environment.NewLine +
"  </header>" + Environment.NewLine +
"    <section>" + Environment.NewLine +
"      <div class=\"container\">" + Environment.NewLine +
"        <div class=\"row\">" + Environment.NewLine +
"          <div class=\"col-lg-12 mb-4 mt-2 text-center\">" + Environment.NewLine +
"            <h2>REPLACEMETITLE</h2>" + Environment.NewLine +
"          </div>" + Environment.NewLine +
"        </div>" + Environment.NewLine +
"      </div>" + Environment.NewLine +
"      <div class=\"container \">" + Environment.NewLine +
"        <div class=\"row\">" + Environment.NewLine;

        private string HTML2 = "        </div>" + Environment.NewLine +
"        <div class=\"row\">" + Environment.NewLine +
"          <div class=\"col-sm-12 mt-4 mb-2 text-center\"> </div>" + Environment.NewLine +
"        </div>" + Environment.NewLine +
"        <div class=\"row\"> </div>" + Environment.NewLine +
"      </div>" + Environment.NewLine +
"<div class=\"container\">" + Environment.NewLine +
"    <div class=\"row\"> </div>" + Environment.NewLine +
"</div>" + Environment.NewLine +
"    </section>" + Environment.NewLine +
"    <div class=\"container\">" + Environment.NewLine +
"      <div class=\"row\">" + Environment.NewLine +
"        <div class=\"col-12 col-md-8 mx-auto\"> </div>" + Environment.NewLine +
"      </div>" + Environment.NewLine +
"    </div>" + Environment.NewLine +
"    <footer class=\"text-center\">" + Environment.NewLine +
"      <div class=\"container\">" + Environment.NewLine +
"        <div class=\"row\">" + Environment.NewLine +
"          <div class=\"col-12\">" + Environment.NewLine +
"            <p>Generated with <b>HTML-Video-Template-NX & VideoSetupNX</b> by: <b>REPLACEMENAME</b></p>" + Environment.NewLine +
"          </div>" + Environment.NewLine +
"        </div>" + Environment.NewLine +
"      </div>" + Environment.NewLine +
"    </footer>" + Environment.NewLine +
"    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) --> " + Environment.NewLine +
"    <script src=\"js/jquery-3.2.1.min.js\"></script> " + Environment.NewLine +
"    <!-- Include all compiled plugins (below), or include individual files as needed --> " + Environment.NewLine +
"    <script src=\"js/popper.min.js\"></script> " + Environment.NewLine +
"    <script src=\"js/bootstrap-4.0.0.js\"></script><br>" + Environment.NewLine +
"  </body>" + Environment.NewLine +
"</html>";

        private string VideoHTML = "          <div class=\"col-lg-4 col-md-6 col-sm-12 text-center\">" + Environment.NewLine +
"\t\t\t  <a href=\"vid/replaceme.mp4\">" + Environment.NewLine +
"            <img class=\"rounded-circle\" alt=\"140x140\" style=\"width: 140px; height: 140px;\" src=\"img/VIDEOPREVIEWREPLACE.png\" data-holder-rendered=\"true\"></a>" + Environment.NewLine +
"            <h3>VIDEONAME</h3>" + Environment.NewLine +
"            <!--<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>-->" + Environment.NewLine +
"          </div>" + Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"Output\css") == false) Directory.CreateDirectory(@"Output\css");
            if (Directory.Exists(@"Output\img") == false) Directory.CreateDirectory(@"Output\img");
            if (Directory.Exists(@"Output\js") == false) Directory.CreateDirectory(@"Output\js");
            if (Directory.Exists(@"Output\vid") == false) Directory.CreateDirectory(@"Output\vid");
            DirectoryInfo d = new DirectoryInfo(txtVideoDirectory.Text);
            string TotalVideoHTML = string.Empty;
            foreach (var file in d.GetFiles("*.mp4"))
            {
                TotalVideoHTML = TotalVideoHTML + VideoHTML.Replace("replaceme.mp4", file.Name).Replace("VIDEONAME", file.Name.Replace(file.Extension, "")).Replace("VIDEOPREVIEWREPLACE", file.Name + "_thumb");

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                string Filename = file.FullName;

                startInfo.FileName = @"cmd.exe";
                startInfo.Arguments = "/C ffmpeg -y -ss 00:01:00 -i \"" + Filename + "\" -vframes 1 -s 140x140  \"Output\\img\\" + file.Name + "_thumb.png\"";
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;
                process.Start();

                process.WaitForExit();
            }

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            string[] HTMLResources = currentAssembly.GetManifestResourceNames();
            foreach (string resourceName in HTMLResources)
            {
                Stream resourceToSave = currentAssembly.GetManifestResourceStream(resourceName);

                if (resourceName.Contains(".css"))
                {
                    if (File.Exists(@"Output\css\" + resourceName.Replace("VideoSetupNX.Resources.", ""))) File.Delete(@"Output\css\" + resourceName.Replace("VideoSetupNX.Resources.", ""));
                    var output = File.OpenWrite(@"Output\css\" + resourceName.Replace("VideoSetupNX.Resources.", ""));
                    resourceToSave.CopyTo(output);
                    output.Close();
                }

                if (resourceName.Contains(".js"))
                {
                    if (File.Exists(@"Output\js\" + resourceName.Replace("VideoSetupNX.Resources.", ""))) File.Delete(@"Output\js\" + resourceName.Replace("VideoSetupNX.Resources.", ""));
                    var output = File.OpenWrite(@"Output\js\" + resourceName.Replace("VideoSetupNX.Resources.", ""));

                    resourceToSave.CopyTo(output);
                    output.Close();
                }

                if (resourceName.Contains(".png") & String.IsNullOrEmpty(txtBannerFile.Text))
                {
                    if (File.Exists(@"Output\img\" + resourceName.Replace("VideoSetupNX.Resources.", ""))) File.Delete(@"Output\img\" + resourceName.Replace("VideoSetupNX.Resources.", ""));
                    var output = File.OpenWrite(@"Output\img\" + resourceName.Replace("VideoSetupNX.Resources.", ""));

                    resourceToSave.CopyTo(output);
                    output.Close();
                }

                resourceToSave.Close();
            }

            if (String.IsNullOrEmpty(txtBannerFile.Text) == false)
            {
                if (File.Exists(txtBannerFile.Text))
                {
                    if (File.Exists(@"Output\img\banner.png")) File.Delete(@"Output\img\banner.png");
                    File.Copy(txtBannerFile.Text, @"Output\img\banner.png");
                }
            }
            string CompleteHTML = HTML1 + TotalVideoHTML + HTML2;
            File.WriteAllText(@"Output\index.html", CompleteHTML.Replace("REPLACEMETITLE", txtTitle.Text).Replace("REPLACEMENAME", txtYourName.Text));
            Process.Start("Output");
        }

        private void btnPickDirectory_Click(object sender, EventArgs e)
        {
            string filepath = String.Empty;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filepath = fbd.SelectedPath;
                    lblVideoStats.Text = "MP4s found: " + Directory.GetFiles(fbd.SelectedPath, "*.mp4").Length.ToString();
                }
            }
            txtVideoDirectory.Text = filepath;
        }

        private void btnConvertSwitchVideos_Click(object sender, EventArgs e)
        {
            //Try to convert the file *with* subs
            //If it fails, try without.
            //If it fails again idk
            string filepath = String.Empty;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filepath = fbd.SelectedPath;
                }
                if (result == DialogResult.Cancel) return;
            }

            int count = 0;
            DirectoryInfo d = new DirectoryInfo(filepath);
            int TotalVideos = d.GetFiles("*.*").Length;
            string TotalVideoHTML = string.Empty;
            foreach (var file in d.GetFiles("*.*"))
            {
                count = count + 1;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                string Filename = file.FullName;
                string FilenameAfterConversion = file.FullName + ".switch.mp4";

                startInfo.FileName = @"cmd.exe";
                if (chkKeepSubs.Checked)
                {
                    if (chkResize.Checked)
                    {
                        if (chkAspectRatio.Checked)
                        {
                            //Resizing and keep aspect, keeping subs
                            startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -disposition:s default+forced -filter_complex \"[0:v][sub]overlay,scale = -1:720\" -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                        }
                        else
                        {
                            //Resizing, keeping subs
                            startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -disposition:s default+forced -filter_complex \"[0:v][sub]overlay,scale = 1280:720\" -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                        }
                    }
                    else
                    {
                        //Keeping subs, no resize
                        //cmd.exe /C ffmpeg -y -i "%1" -vcodec libx264 -preset fast -f mp4 -vf subtitles="%~n1%~x1" -disposition:s default+forced -c:a aac -ac 2 "%1.converted.mp4" & PAUSE
                        startInfo.Arguments = startInfo.Arguments.Replace(" -c:a", " -vf subtitles=\"" + file.Name + "\" -disposition:s default+forced -c:a");
                    }
                }
                if (chkResize.Checked & !chkKeepSubs.Checked)
                {
                    if (chkAspectRatio.Checked)
                    {
                        //Resize and keep aspect, no subs
                        startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -vf scale=-1:720 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                    }
                    else
                    {
                        //Resize, no subs
                        startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -vf scale=1280:720 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                    }
                }
                if (!chkResize.Checked & !chkKeepSubs.Checked)
                {
                    startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                }
                if (chkOnlyConvertAudio.Checked)
                {
                    startInfo.Arguments = "/C ffmpeg -y -i \"" + Filename + "\" -c:v copy -f mp4 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                }
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;
                process.Start();

                btnConvertSwitchVideos.Text = "Converting " + count + "/" + TotalVideos;

                process.WaitForExit();
            }
            MessageBox.Show("Conversion completed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog BannerDialog = new OpenFileDialog();

            BannerDialog.Title = "Please select your banner picture file";
            BannerDialog.Filter = "All files (*.*)|*.*";
            BannerDialog.FilterIndex = 0;
            BannerDialog.RestoreDirectory = true;

            if (BannerDialog.ShowDialog() == DialogResult.OK)
            {
                txtBannerFile.Text = BannerDialog.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chkAspectRatio.Enabled = chkResize.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SuperOkazaki/HTML-Video-Template-NX");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void chkKeepSubs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeepSubs.Checked) MessageBox.Show("PLEASE NOTE: Having this option on will keep the default/forced subtitles of all videos during conversion. -However-, it will fail to convert videos which do not have subs in them. Please keep this in mind when turning this on.");
        }

        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }

        private void chkOnlyConvertAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnlyConvertAudio.Checked)
            {
                MessageBox.Show("PLEASE NOTE: This option will not modify the video and will only convert the audio to AAC. Please make sure your videos are already using H264 using the \"Check Compatiblity of Video\" button!");
                chkAspectRatio.Checked = false;
                chkKeepSubs.Checked = false;
                chkResize.Checked = false;
            }
            chkAspectRatio.Enabled = !chkOnlyConvertAudio.Checked;
            chkKeepSubs.Enabled = !chkOnlyConvertAudio.Checked;
            chkResize.Enabled = !chkOnlyConvertAudio.Checked;
        }

        private void btnCheckVideo_Click(object sender, EventArgs e)
        {
            string FileToCheck = string.Empty;
            string Output = string.Empty;

            OpenFileDialog FileToCheckDialog = new OpenFileDialog();

            FileToCheckDialog.Title = "Please select a video file to test";
            FileToCheckDialog.Filter = "Switch Video Files|*.mp4;*.mkv|All files (*.*)|*.*";
            FileToCheckDialog.FilterIndex = 0;
            FileToCheckDialog.RestoreDirectory = true;

            if (FileToCheckDialog.ShowDialog() == DialogResult.OK)
            {
                FileToCheck = FileToCheckDialog.FileName;
            }

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = @"cmd.exe";
            startInfo.Arguments = "/C ffprobe -v error -show_entries stream=codec_name -of default=nokey=1:noprint_wrappers=1 \"" + FileToCheck + "\"";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            int count = 0;
            string VideoCodec = string.Empty;
            string AudioCodec = string.Empty;
            string Subtitle = string.Empty;
            while (!process.StandardOutput.EndOfStream)
            {
                count++;
                string Currentline = process.StandardOutput.ReadLine();
                switch (count)
                {
                    case 1:
                        VideoCodec = Currentline.ToUpper();
                        if (VideoCodec == "H264")
                        {
                            VideoCodec = VideoCodec + " ✓";
                        }
                        else
                        {
                            VideoCodec = VideoCodec + " ✕";
                        }
                        Output = Output + "Video: " + VideoCodec + Environment.NewLine;
                        break;
                    case 2:
                        AudioCodec = Currentline.ToUpper();
                        if (AudioCodec == "AAC")
                        {
                            AudioCodec = AudioCodec + " ✓";
                        }
                        else
                        {
                            AudioCodec = AudioCodec + " ✕";
                        }
                        Output = Output + "Audio: " + AudioCodec + Environment.NewLine;
                        break;
                    case 3:
                        Subtitle = Currentline.ToUpper(); ;
                        Output = Output + "Subtitle: " + Subtitle + Environment.NewLine;
                        break;
                    case 4:
                        Output = "Too many streams (" + count + ") - This file is unlikely to work on the switch.";
                        break;
                    default:
                        Output = "Too many streams (" + count + ") - This file is unlikely to work on the switch.";
                        break;
                }
                // do something with line
            }
            process.WaitForExit();

            startInfo.Arguments = "/C ffprobe -v error -select_streams v:0 -show_entries stream=width,height -of csv=p=0 \"" + FileToCheck + "\"";
            process.StartInfo = startInfo;
            process.Start();

            string WidthHeight = string.Empty;

            while (!process.StandardOutput.EndOfStream)
            {
                WidthHeight = process.StandardOutput.ReadLine();
            }

            string[] WidthHeightSplit = WidthHeight.Split(',');
            int Width = Convert.ToInt32(WidthHeightSplit[0].Replace(",", ""));
            int Height = Convert.ToInt32(WidthHeightSplit[1].Replace(",",""));

            string Resolution = "Resolution: " + Environment.NewLine;

            if (Width > 1280)
            {
                Resolution = Resolution + "Width: " + Width + " ✕" + Environment.NewLine;
            }
            else
            {
                Resolution = Resolution + "Width: " + Width + " ✓" + Environment.NewLine;
            }
            if (Height > 720)
            {
                Resolution = Resolution + "Height: " + Height + " ✕" + Environment.NewLine;
            }
            else
            {
                Resolution = Resolution + "Height: " + Height + " ✓" + Environment.NewLine;
            }

            //ffprobe -v error -select_streams v:0 -show_entries stream=width,height -of csv=p=0 input.mp4

            string Errors = "The following issues were found with your file (" + FileToCheckDialog.SafeFileName + "):" + Environment.NewLine;

            if (VideoCodec.Contains("✕")) Errors = Errors + "The video codec is not compatible with the switch. You'll need to convert it." + Environment.NewLine;
            if (AudioCodec.Contains("✕")) Errors = Errors + "The audio codec is not compatible with the switch. You'll need to convert it." + Environment.NewLine;
            if (Width > 1280) Errors = Errors + "Your file's resolution is too wide - It will need to be resized to 720p or smaller." + Environment.NewLine;
            if (Height > 720) Errors = Errors + "Your file's resolution is too high - It will need to be resized to 720p or smaller." + Environment.NewLine;

            if (FileToCheckDialog.SafeFileName.Contains(" "))
            {
                Output = Output + Environment.NewLine + "!!!Please note, the switch does not play video files with spaces in the filename. You'll need to rename this video!!!" + Environment.NewLine;
            }

            if (Errors == "The following issues were found with your file (" + FileToCheckDialog.SafeFileName + "):" + Environment.NewLine)
            {
                if(Subtitle == String.Empty)
                {
                    MessageBox.Show(Output + Environment.NewLine + Resolution + Environment.NewLine + "Your file appears to be playable on the switch!");
                }
                else
                {
                    MessageBox.Show(Output + Environment.NewLine + Resolution + Environment.NewLine + "Your file appears to be playable on the switch! However, it seems to contain subtitles. These may or may not work on the switch. If they don't, you'll need to convert the file and select \"Keep subtitles\".");
                }
            }
            else
            {
                MessageBox.Show(Output + Environment.NewLine + Resolution + Environment.NewLine + Errors);
            }
        }
    }
}