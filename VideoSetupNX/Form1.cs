using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
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
"            <h2>Video List</h2>" + Environment.NewLine +
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
                TotalVideoHTML = TotalVideoHTML + VideoHTML.Replace("replaceme.mp4", file.Name).Replace("VIDEONAME", file.Name).Replace("VIDEOPREVIEWREPLACE", file.Name + "_thumb");

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                string Filename = file.FullName;

                startInfo.FileName = @"cmd.exe";
                startInfo.Arguments = "/C ffmpeg -y -ss 00:02:00 -i \"" + Filename + "\" -vframes 1 -s 140x140  \"Output\\img\\" + file.Name + "_thumb.png\"";
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

        private async void btnConvertSwitchVideos_Click(object sender, EventArgs e)
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
                if (chkResize.Checked)
                {
                    if (chkAspectRatio.Checked)
                    {
                        startInfo.Arguments = "/C ffmpeg -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -vf scale=-1:720 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                    }
                    else
                    {
                        startInfo.Arguments = "/C ffmpeg -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -vf scale=1280:720 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                    }
                }
                else
                {
                    startInfo.Arguments = "/C ffmpeg -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
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
    }
}