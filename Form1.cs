using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VRAutorunHelper
{
    public partial class Form1 : Form
    {
        bool running = true;
        bool running_now = true;

        bool runit = false;
        string filename;
        NotifyIcon icon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath); //ファイル位置にカレントディレクトリを置く

            icon = new NotifyIcon();
            icon.Icon = Icon;
            icon.Visible = true;
            icon.Text = "VR Autorun Helper";
            icon.Click += Icon_Click;

            try
            {
                filename = File.ReadAllText("autorun.txt", System.Text.Encoding.UTF8);
                runLabel.Text = filename;
                runit = true;
            }
            catch (Exception ex)
            {
                runLabel.Text = "---";
            }

            //Startup時に自動でウィンドウ消えるやつ
            var arg = Environment.GetCommandLineArgs();
            if (arg.Length > 1) {
                if (arg[1] == "1") {
                    timer3.Enabled = true;
                }
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void run()
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.ErrorDialog = true;
            myProcess.StartInfo.FileName = filename;
            myProcess.StartInfo.Arguments = "";
            myProcess.StartInfo.WorkingDirectory = Application.StartupPath;
            myProcess.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Process[] p = Process.GetProcessesByName("vrcompositor");
                if (p.Length != 0)
                {
                    running = true;
                    stateRunning.Visible = true;
                    stateStopped.Visible = false;
                }
                else {
                    running = false;
                    running_now = false;
                    stateStopped.Visible = true;
                    stateRunning.Visible = false;
                }

                if (running_now == false && running == true)
                {
                    running_now = true;

                    //Run!!!
                    if (runit)
                    {
                        timer2.Enabled = true;
                    }
                }

            } catch (Exception ec) {
                Console.WriteLine(ec.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            try
            {
                run();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.ToString());
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            this.Hide();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            var startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            var batname = startup + "\\SteamVRautorun_" + Path.GetFileNameWithoutExtension(filename) + ".bat";
            var body = "@echo off\nstart " + Application.ExecutablePath + " 1\n";
            Console.WriteLine(batname);
            try
            {
                File.WriteAllText(batname, body, System.Text.Encoding.UTF8);
                MessageBox.Show(this, "Successfully registered.\nスタートアップへの登録に成功しました", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                MessageBox.Show(this, "Registration failed.\nスタートアップへの登録に失敗しました\n\n" + ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            var startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            var batname = startup + "\\SteamVRautorun_" + Path.GetFileNameWithoutExtension(filename) + ".bat";

            try
            {
                File.Delete(batname);
                MessageBox.Show(this, "Successfully unregistered.\nスタートアップからの登録解除に成功しました", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unregistration failed.\nスタートアップへの登録解除に失敗しました\n\n" + ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            icon.Visible = false;
        }
    }
}
