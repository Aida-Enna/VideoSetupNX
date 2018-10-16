using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VideoPreperationTool
{
    public partial class Form1 : Form
    {

        string HTML1 = "<!DOCTYPE html>" +
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
        string HTML2 = "        </div>" + Environment.NewLine + 
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
"            <p>Generated with <b>HTML-Video-Template-NX</b> by: <b>REPLACEMENAME</b></p>" + Environment.NewLine + 
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
        string VideoHTML = "          <div class=\"col-lg-4 col-md-6 col-sm-12 text-center\">" + Environment.NewLine + 
"\t\t\t  <a href=\"vid/replaceme.mp4\">" + Environment.NewLine + 
"            <img class=\"rounded-circle\" alt=\"140x140\" style=\"width: 140px; height: 140px;\" src=\"img/vid1.png\" data-holder-rendered=\"true\"></a>" + Environment.NewLine + 
"            <h3>VIDEONAME</h3>" + Environment.NewLine + 
"            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>" + Environment.NewLine + 
"          </div>" + Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(txtVideoDirectory.Text);
            string TotalVideoHTML = string.Empty;
            foreach (var file in d.GetFiles("*.mp4"))
            {
                TotalVideoHTML = TotalVideoHTML + VideoHTML.Replace("replaceme.mp4", file.Name).Replace("VIDEONAME",file.Name);
                //ffprobe -v error -select_streams v:0 -show_entries stream=codec_name -of default = noprint_wrappers = 1:nokey = 1 video.mkv
            }
            string CompleteHTML = HTML1 + TotalVideoHTML + HTML2;
            txtHTML.Text = CompleteHTML.Replace("REPLACEMETITLE", txtTitle.Text).Replace("REPLACEMENAME", txtYourName.Text);
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

        private void btnCopyHTML_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHTML.Text);
        }

        private void btnConvertSwitchVideos_Click(object sender, EventArgs e)
        {
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
            string TotalVideoHTML = string.Empty;
            foreach (var file in d.GetFiles("*.*"))
            {
                count = count + 1;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                string Filename = file.FullName;
                string FilenameAfterConversion = file.FullName + ".switch.mp4";

                startInfo.FileName = @"cmd.exe";
                startInfo.Arguments = "/C ffmpeg -i \"" + Filename + "\" -vcodec libx264 -preset fast -f mp4 -c:a aac -ac 2 \"" + FilenameAfterConversion + "\"";
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;
                process.Start();

                btnConvertSwitchVideos.Text = "Converting " + count + "/" + d.GetFiles("*.*").Length;

                process.WaitForExit();
            }
        }
    }
}