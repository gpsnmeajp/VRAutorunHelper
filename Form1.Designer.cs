namespace VRAutorunHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hideButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.stateStopped = new System.Windows.Forms.Label();
            this.stateRunning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.InstallButton = new System.Windows.Forms.Button();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hideButton
            // 
            this.hideButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hideButton.Location = new System.Drawing.Point(12, 115);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(337, 32);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SteamVR:";
            // 
            // stateStopped
            // 
            this.stateStopped.AutoSize = true;
            this.stateStopped.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stateStopped.ForeColor = System.Drawing.Color.Red;
            this.stateStopped.Location = new System.Drawing.Point(127, 13);
            this.stateStopped.Name = "stateStopped";
            this.stateStopped.Size = new System.Drawing.Size(92, 24);
            this.stateStopped.TabIndex = 2;
            this.stateStopped.Text = "Stopped";
            this.stateStopped.Visible = false;
            // 
            // stateRunning
            // 
            this.stateRunning.AutoSize = true;
            this.stateRunning.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stateRunning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stateRunning.Location = new System.Drawing.Point(127, 13);
            this.stateRunning.Name = "stateRunning";
            this.stateRunning.Size = new System.Drawing.Size(89, 24);
            this.stateRunning.TabIndex = 3;
            this.stateRunning.Text = "Running";
            this.stateRunning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXE:";
            // 
            // runLabel
            // 
            this.runLabel.AutoSize = true;
            this.runLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.runLabel.Location = new System.Drawing.Point(64, 46);
            this.runLabel.Name = "runLabel";
            this.runLabel.Size = new System.Drawing.Size(46, 24);
            this.runLabel.TabIndex = 5;
            this.runLabel.Text = "---";
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // InstallButton
            // 
            this.InstallButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InstallButton.Location = new System.Drawing.Point(12, 77);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(167, 32);
            this.InstallButton.TabIndex = 6;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // UninstallButton
            // 
            this.UninstallButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UninstallButton.Location = new System.Drawing.Point(182, 77);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(167, 32);
            this.UninstallButton.TabIndex = 7;
            this.UninstallButton.Text = "Uninstall";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(318, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "v0.02";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UninstallButton);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.runLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stateRunning);
            this.Controls.Add(this.stateStopped);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hideButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "VR Autorun Helper";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stateStopped;
        private System.Windows.Forms.Label stateRunning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label runLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.Label label3;
    }
}

