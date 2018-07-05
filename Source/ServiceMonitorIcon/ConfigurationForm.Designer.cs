namespace ServiceMonitorIcon
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.serviceSelect_lb = new System.Windows.Forms.Label();
            this.timeout_tb = new System.Windows.Forms.TextBox();
            this.timeout_lb = new System.Windows.Forms.Label();
            this.serviceSelect_cb = new System.Windows.Forms.ComboBox();
            this.runningIcon_lb = new System.Windows.Forms.Label();
            this.stoppedIcon_lb = new System.Windows.Forms.Label();
            this.startingIcon_lb = new System.Windows.Forms.Label();
            this.stoppingIcon_lb = new System.Windows.Forms.Label();
            this.pausedIcon_lb = new System.Windows.Forms.Label();
            this.pausingIcon_lb = new System.Windows.Forms.Label();
            this.unpausingIcon_lb = new System.Windows.Forms.Label();
            this.runningIcon_tb = new System.Windows.Forms.TextBox();
            this.browseRunningIcon_bt = new System.Windows.Forms.Button();
            this.browseStoppedIcon_bt = new System.Windows.Forms.Button();
            this.stoppedIcon_tb = new System.Windows.Forms.TextBox();
            this.browseStartingIcon_bt = new System.Windows.Forms.Button();
            this.startingIcon_tb = new System.Windows.Forms.TextBox();
            this.browseStoppingIcon_bt = new System.Windows.Forms.Button();
            this.stoppingIcon_tb = new System.Windows.Forms.TextBox();
            this.browsePausedIcon_bt = new System.Windows.Forms.Button();
            this.pausedIcon_tb = new System.Windows.Forms.TextBox();
            this.browsePausingIcon_bt = new System.Windows.Forms.Button();
            this.pausingIcon_tb = new System.Windows.Forms.TextBox();
            this.browseUnpausingIcon_bt = new System.Windows.Forms.Button();
            this.unpausingIcon_tb = new System.Windows.Forms.TextBox();
            this.save_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.pollrate_lb = new System.Windows.Forms.Label();
            this.pollrate_tb = new System.Windows.Forms.TextBox();
            this.configuration_tc = new System.Windows.Forms.TabControl();
            this.service_tp = new System.Windows.Forms.TabPage();
            this.autoStartup_cb = new System.Windows.Forms.CheckBox();
            this.startupSettings_lb = new System.Windows.Forms.Label();
            this.service_lb = new System.Windows.Forms.Label();
            this.icons_tp = new System.Windows.Forms.TabPage();
            this.icons_lb = new System.Windows.Forms.Label();
            this.autostart_tt = new System.Windows.Forms.ToolTip(this.components);
            this.configuration_tc.SuspendLayout();
            this.service_tp.SuspendLayout();
            this.icons_tp.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceSelect_lb
            // 
            this.serviceSelect_lb.AutoSize = true;
            this.serviceSelect_lb.Location = new System.Drawing.Point(6, 52);
            this.serviceSelect_lb.Name = "serviceSelect_lb";
            this.serviceSelect_lb.Size = new System.Drawing.Size(182, 13);
            this.serviceSelect_lb.TabIndex = 0;
            this.serviceSelect_lb.Text = "Select a Windows service to monitor:";
            // 
            // timeout_tb
            // 
            this.timeout_tb.Location = new System.Drawing.Point(224, 146);
            this.timeout_tb.MaxLength = 10;
            this.timeout_tb.Name = "timeout_tb";
            this.timeout_tb.Size = new System.Drawing.Size(176, 20);
            this.timeout_tb.TabIndex = 1;
            this.timeout_tb.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateIntegerOnlyTextbox);
            // 
            // timeout_lb
            // 
            this.timeout_lb.AutoSize = true;
            this.timeout_lb.Location = new System.Drawing.Point(6, 149);
            this.timeout_lb.Name = "timeout_lb";
            this.timeout_lb.Size = new System.Drawing.Size(212, 13);
            this.timeout_lb.TabIndex = 2;
            this.timeout_lb.Text = "Service wait for status change timeout (ms):";
            // 
            // serviceSelect_cb
            // 
            this.serviceSelect_cb.FormattingEnabled = true;
            this.serviceSelect_cb.Location = new System.Drawing.Point(9, 68);
            this.serviceSelect_cb.Name = "serviceSelect_cb";
            this.serviceSelect_cb.Size = new System.Drawing.Size(391, 21);
            this.serviceSelect_cb.TabIndex = 3;
            // 
            // runningIcon_lb
            // 
            this.runningIcon_lb.AutoSize = true;
            this.runningIcon_lb.Location = new System.Drawing.Point(3, 38);
            this.runningIcon_lb.Name = "runningIcon_lb";
            this.runningIcon_lb.Size = new System.Drawing.Size(74, 13);
            this.runningIcon_lb.TabIndex = 4;
            this.runningIcon_lb.Text = "Running Icon:";
            // 
            // stoppedIcon_lb
            // 
            this.stoppedIcon_lb.AutoSize = true;
            this.stoppedIcon_lb.Location = new System.Drawing.Point(3, 77);
            this.stoppedIcon_lb.Name = "stoppedIcon_lb";
            this.stoppedIcon_lb.Size = new System.Drawing.Size(74, 13);
            this.stoppedIcon_lb.TabIndex = 5;
            this.stoppedIcon_lb.Text = "Stopped Icon:";
            // 
            // startingIcon_lb
            // 
            this.startingIcon_lb.AutoSize = true;
            this.startingIcon_lb.Location = new System.Drawing.Point(4, 116);
            this.startingIcon_lb.Name = "startingIcon_lb";
            this.startingIcon_lb.Size = new System.Drawing.Size(70, 13);
            this.startingIcon_lb.TabIndex = 6;
            this.startingIcon_lb.Text = "Starting Icon:";
            // 
            // stoppingIcon_lb
            // 
            this.stoppingIcon_lb.AutoSize = true;
            this.stoppingIcon_lb.Location = new System.Drawing.Point(4, 155);
            this.stoppingIcon_lb.Name = "stoppingIcon_lb";
            this.stoppingIcon_lb.Size = new System.Drawing.Size(76, 13);
            this.stoppingIcon_lb.TabIndex = 7;
            this.stoppingIcon_lb.Text = "Stopping Icon:";
            // 
            // pausedIcon_lb
            // 
            this.pausedIcon_lb.AutoSize = true;
            this.pausedIcon_lb.Location = new System.Drawing.Point(3, 194);
            this.pausedIcon_lb.Name = "pausedIcon_lb";
            this.pausedIcon_lb.Size = new System.Drawing.Size(70, 13);
            this.pausedIcon_lb.TabIndex = 8;
            this.pausedIcon_lb.Text = "Paused Icon:";
            // 
            // pausingIcon_lb
            // 
            this.pausingIcon_lb.AutoSize = true;
            this.pausingIcon_lb.Location = new System.Drawing.Point(3, 233);
            this.pausingIcon_lb.Name = "pausingIcon_lb";
            this.pausingIcon_lb.Size = new System.Drawing.Size(72, 13);
            this.pausingIcon_lb.TabIndex = 9;
            this.pausingIcon_lb.Text = "Pausing Icon:";
            // 
            // unpausingIcon_lb
            // 
            this.unpausingIcon_lb.AutoSize = true;
            this.unpausingIcon_lb.Location = new System.Drawing.Point(4, 272);
            this.unpausingIcon_lb.Name = "unpausingIcon_lb";
            this.unpausingIcon_lb.Size = new System.Drawing.Size(85, 13);
            this.unpausingIcon_lb.TabIndex = 10;
            this.unpausingIcon_lb.Text = "Unpausing Icon:";
            // 
            // runningIcon_tb
            // 
            this.runningIcon_tb.Location = new System.Drawing.Point(6, 54);
            this.runningIcon_tb.Name = "runningIcon_tb";
            this.runningIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.runningIcon_tb.TabIndex = 11;
            // 
            // browseRunningIcon_bt
            // 
            this.browseRunningIcon_bt.Location = new System.Drawing.Point(344, 53);
            this.browseRunningIcon_bt.Name = "browseRunningIcon_bt";
            this.browseRunningIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browseRunningIcon_bt.TabIndex = 12;
            this.browseRunningIcon_bt.Tag = "runningIcon_tb";
            this.browseRunningIcon_bt.Text = "Browse";
            this.browseRunningIcon_bt.UseVisualStyleBackColor = true;
            this.browseRunningIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // browseStoppedIcon_bt
            // 
            this.browseStoppedIcon_bt.Location = new System.Drawing.Point(344, 93);
            this.browseStoppedIcon_bt.Name = "browseStoppedIcon_bt";
            this.browseStoppedIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browseStoppedIcon_bt.TabIndex = 14;
            this.browseStoppedIcon_bt.Tag = "stoppedIcon_tb";
            this.browseStoppedIcon_bt.Text = "Browse";
            this.browseStoppedIcon_bt.UseVisualStyleBackColor = true;
            this.browseStoppedIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // stoppedIcon_tb
            // 
            this.stoppedIcon_tb.Location = new System.Drawing.Point(6, 93);
            this.stoppedIcon_tb.Name = "stoppedIcon_tb";
            this.stoppedIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.stoppedIcon_tb.TabIndex = 13;
            // 
            // browseStartingIcon_bt
            // 
            this.browseStartingIcon_bt.Location = new System.Drawing.Point(344, 132);
            this.browseStartingIcon_bt.Name = "browseStartingIcon_bt";
            this.browseStartingIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browseStartingIcon_bt.TabIndex = 16;
            this.browseStartingIcon_bt.Tag = "startingIcon_tb";
            this.browseStartingIcon_bt.Text = "Browse";
            this.browseStartingIcon_bt.UseVisualStyleBackColor = true;
            this.browseStartingIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // startingIcon_tb
            // 
            this.startingIcon_tb.Location = new System.Drawing.Point(6, 132);
            this.startingIcon_tb.Name = "startingIcon_tb";
            this.startingIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.startingIcon_tb.TabIndex = 15;
            // 
            // browseStoppingIcon_bt
            // 
            this.browseStoppingIcon_bt.Location = new System.Drawing.Point(344, 170);
            this.browseStoppingIcon_bt.Name = "browseStoppingIcon_bt";
            this.browseStoppingIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browseStoppingIcon_bt.TabIndex = 18;
            this.browseStoppingIcon_bt.Tag = "stoppingIcon_tb";
            this.browseStoppingIcon_bt.Text = "Browse";
            this.browseStoppingIcon_bt.UseVisualStyleBackColor = true;
            this.browseStoppingIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // stoppingIcon_tb
            // 
            this.stoppingIcon_tb.Location = new System.Drawing.Point(6, 171);
            this.stoppingIcon_tb.Name = "stoppingIcon_tb";
            this.stoppingIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.stoppingIcon_tb.TabIndex = 17;
            // 
            // browsePausedIcon_bt
            // 
            this.browsePausedIcon_bt.Location = new System.Drawing.Point(344, 210);
            this.browsePausedIcon_bt.Name = "browsePausedIcon_bt";
            this.browsePausedIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browsePausedIcon_bt.TabIndex = 20;
            this.browsePausedIcon_bt.Tag = "pausedIcon_tb";
            this.browsePausedIcon_bt.Text = "Browse";
            this.browsePausedIcon_bt.UseVisualStyleBackColor = true;
            this.browsePausedIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // pausedIcon_tb
            // 
            this.pausedIcon_tb.Location = new System.Drawing.Point(6, 210);
            this.pausedIcon_tb.Name = "pausedIcon_tb";
            this.pausedIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.pausedIcon_tb.TabIndex = 19;
            // 
            // browsePausingIcon_bt
            // 
            this.browsePausingIcon_bt.Location = new System.Drawing.Point(344, 248);
            this.browsePausingIcon_bt.Name = "browsePausingIcon_bt";
            this.browsePausingIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browsePausingIcon_bt.TabIndex = 22;
            this.browsePausingIcon_bt.Tag = "pausingIcon_tb";
            this.browsePausingIcon_bt.Text = "Browse";
            this.browsePausingIcon_bt.UseVisualStyleBackColor = true;
            this.browsePausingIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // pausingIcon_tb
            // 
            this.pausingIcon_tb.Location = new System.Drawing.Point(7, 249);
            this.pausingIcon_tb.Name = "pausingIcon_tb";
            this.pausingIcon_tb.Size = new System.Drawing.Size(331, 20);
            this.pausingIcon_tb.TabIndex = 21;
            // 
            // browseUnpausingIcon_bt
            // 
            this.browseUnpausingIcon_bt.Location = new System.Drawing.Point(344, 287);
            this.browseUnpausingIcon_bt.Name = "browseUnpausingIcon_bt";
            this.browseUnpausingIcon_bt.Size = new System.Drawing.Size(58, 20);
            this.browseUnpausingIcon_bt.TabIndex = 24;
            this.browseUnpausingIcon_bt.Tag = "unpausingIcon_tb";
            this.browseUnpausingIcon_bt.Text = "Browse";
            this.browseUnpausingIcon_bt.UseVisualStyleBackColor = true;
            this.browseUnpausingIcon_bt.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // unpausingIcon_tb
            // 
            this.unpausingIcon_tb.Location = new System.Drawing.Point(6, 288);
            this.unpausingIcon_tb.Name = "unpausingIcon_tb";
            this.unpausingIcon_tb.Size = new System.Drawing.Size(332, 20);
            this.unpausingIcon_tb.TabIndex = 23;
            // 
            // save_bt
            // 
            this.save_bt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_bt.Location = new System.Drawing.Point(16, 362);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(127, 30);
            this.save_bt.TabIndex = 25;
            this.save_bt.Text = "Save";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_bt.Location = new System.Drawing.Point(299, 362);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(127, 30);
            this.cancel_bt.TabIndex = 26;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // pollrate_lb
            // 
            this.pollrate_lb.AutoSize = true;
            this.pollrate_lb.Location = new System.Drawing.Point(79, 114);
            this.pollrate_lb.Name = "pollrate_lb";
            this.pollrate_lb.Size = new System.Drawing.Size(139, 13);
            this.pollrate_lb.TabIndex = 28;
            this.pollrate_lb.Text = "Service status poll rate (ms):";
            // 
            // pollrate_tb
            // 
            this.pollrate_tb.Location = new System.Drawing.Point(224, 111);
            this.pollrate_tb.MaxLength = 10;
            this.pollrate_tb.Name = "pollrate_tb";
            this.pollrate_tb.Size = new System.Drawing.Size(176, 20);
            this.pollrate_tb.TabIndex = 27;
            this.pollrate_tb.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateIntegerOnlyTextbox);
            // 
            // configuration_tc
            // 
            this.configuration_tc.Controls.Add(this.service_tp);
            this.configuration_tc.Controls.Add(this.icons_tp);
            this.configuration_tc.Location = new System.Drawing.Point(12, 12);
            this.configuration_tc.Name = "configuration_tc";
            this.configuration_tc.SelectedIndex = 0;
            this.configuration_tc.Size = new System.Drawing.Size(414, 344);
            this.configuration_tc.TabIndex = 29;
            // 
            // service_tp
            // 
            this.service_tp.Controls.Add(this.autoStartup_cb);
            this.service_tp.Controls.Add(this.startupSettings_lb);
            this.service_tp.Controls.Add(this.service_lb);
            this.service_tp.Controls.Add(this.serviceSelect_lb);
            this.service_tp.Controls.Add(this.pollrate_lb);
            this.service_tp.Controls.Add(this.timeout_tb);
            this.service_tp.Controls.Add(this.pollrate_tb);
            this.service_tp.Controls.Add(this.timeout_lb);
            this.service_tp.Controls.Add(this.serviceSelect_cb);
            this.service_tp.Location = new System.Drawing.Point(4, 22);
            this.service_tp.Name = "service_tp";
            this.service_tp.Padding = new System.Windows.Forms.Padding(3);
            this.service_tp.Size = new System.Drawing.Size(406, 318);
            this.service_tp.TabIndex = 0;
            this.service_tp.Text = "Service";
            this.service_tp.UseVisualStyleBackColor = true;
            // 
            // autoStartup_cb
            // 
            this.autoStartup_cb.AutoSize = true;
            this.autoStartup_cb.Location = new System.Drawing.Point(164, 242);
            this.autoStartup_cb.Name = "autoStartup_cb";
            this.autoStartup_cb.Size = new System.Drawing.Size(93, 17);
            this.autoStartup_cb.TabIndex = 31;
            this.autoStartup_cb.Text = "Run at startup";
            this.autostart_tt.SetToolTip(this.autoStartup_cb, "Whether or not the Service Monitor should launch on Windows Login");
            this.autoStartup_cb.UseVisualStyleBackColor = true;
            // 
            // startupSettings_lb
            // 
            this.startupSettings_lb.AutoSize = true;
            this.startupSettings_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupSettings_lb.Location = new System.Drawing.Point(161, 209);
            this.startupSettings_lb.Name = "startupSettings_lb";
            this.startupSettings_lb.Size = new System.Drawing.Size(98, 13);
            this.startupSettings_lb.TabIndex = 30;
            this.startupSettings_lb.Text = "Startup Settings";
            // 
            // service_lb
            // 
            this.service_lb.AutoSize = true;
            this.service_lb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_lb.Location = new System.Drawing.Point(140, 3);
            this.service_lb.Name = "service_lb";
            this.service_lb.Size = new System.Drawing.Size(126, 16);
            this.service_lb.TabIndex = 29;
            this.service_lb.Text = "Service Settings";
            // 
            // icons_tp
            // 
            this.icons_tp.Controls.Add(this.icons_lb);
            this.icons_tp.Controls.Add(this.runningIcon_lb);
            this.icons_tp.Controls.Add(this.stoppedIcon_lb);
            this.icons_tp.Controls.Add(this.startingIcon_lb);
            this.icons_tp.Controls.Add(this.browseUnpausingIcon_bt);
            this.icons_tp.Controls.Add(this.stoppingIcon_lb);
            this.icons_tp.Controls.Add(this.unpausingIcon_tb);
            this.icons_tp.Controls.Add(this.pausedIcon_lb);
            this.icons_tp.Controls.Add(this.browsePausingIcon_bt);
            this.icons_tp.Controls.Add(this.pausingIcon_lb);
            this.icons_tp.Controls.Add(this.pausingIcon_tb);
            this.icons_tp.Controls.Add(this.unpausingIcon_lb);
            this.icons_tp.Controls.Add(this.browsePausedIcon_bt);
            this.icons_tp.Controls.Add(this.runningIcon_tb);
            this.icons_tp.Controls.Add(this.pausedIcon_tb);
            this.icons_tp.Controls.Add(this.browseRunningIcon_bt);
            this.icons_tp.Controls.Add(this.browseStoppingIcon_bt);
            this.icons_tp.Controls.Add(this.stoppedIcon_tb);
            this.icons_tp.Controls.Add(this.stoppingIcon_tb);
            this.icons_tp.Controls.Add(this.browseStoppedIcon_bt);
            this.icons_tp.Controls.Add(this.browseStartingIcon_bt);
            this.icons_tp.Controls.Add(this.startingIcon_tb);
            this.icons_tp.Location = new System.Drawing.Point(4, 22);
            this.icons_tp.Name = "icons_tp";
            this.icons_tp.Size = new System.Drawing.Size(406, 318);
            this.icons_tp.TabIndex = 2;
            this.icons_tp.Text = "Icons";
            this.icons_tp.UseVisualStyleBackColor = true;
            // 
            // icons_lb
            // 
            this.icons_lb.AutoSize = true;
            this.icons_lb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icons_lb.Location = new System.Drawing.Point(143, 3);
            this.icons_lb.Name = "icons_lb";
            this.icons_lb.Size = new System.Drawing.Size(104, 16);
            this.icons_lb.TabIndex = 25;
            this.icons_lb.Text = "Icon Settings";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 401);
            this.Controls.Add(this.configuration_tc);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.save_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.Text = "Windows Service Process Monitor Configuration";
            this.configuration_tc.ResumeLayout(false);
            this.service_tp.ResumeLayout(false);
            this.service_tp.PerformLayout();
            this.icons_tp.ResumeLayout(false);
            this.icons_tp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label serviceSelect_lb;
        private System.Windows.Forms.TextBox timeout_tb;
        private System.Windows.Forms.Label timeout_lb;
        private System.Windows.Forms.ComboBox serviceSelect_cb;
        private System.Windows.Forms.Label runningIcon_lb;
        private System.Windows.Forms.Label stoppedIcon_lb;
        private System.Windows.Forms.Label startingIcon_lb;
        private System.Windows.Forms.Label stoppingIcon_lb;
        private System.Windows.Forms.Label pausedIcon_lb;
        private System.Windows.Forms.Label pausingIcon_lb;
        private System.Windows.Forms.Label unpausingIcon_lb;
        private System.Windows.Forms.TextBox runningIcon_tb;
        private System.Windows.Forms.Button browseRunningIcon_bt;
        private System.Windows.Forms.Button browseStoppedIcon_bt;
        private System.Windows.Forms.TextBox stoppedIcon_tb;
        private System.Windows.Forms.Button browseStartingIcon_bt;
        private System.Windows.Forms.TextBox startingIcon_tb;
        private System.Windows.Forms.Button browseStoppingIcon_bt;
        private System.Windows.Forms.TextBox stoppingIcon_tb;
        private System.Windows.Forms.Button browsePausedIcon_bt;
        private System.Windows.Forms.TextBox pausedIcon_tb;
        private System.Windows.Forms.Button browsePausingIcon_bt;
        private System.Windows.Forms.TextBox pausingIcon_tb;
        private System.Windows.Forms.Button browseUnpausingIcon_bt;
        private System.Windows.Forms.TextBox unpausingIcon_tb;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label pollrate_lb;
        private System.Windows.Forms.TextBox pollrate_tb;
        private System.Windows.Forms.TabControl configuration_tc;
        private System.Windows.Forms.TabPage service_tp;
        private System.Windows.Forms.CheckBox autoStartup_cb;
        private System.Windows.Forms.ToolTip autostart_tt;
        private System.Windows.Forms.Label startupSettings_lb;
        private System.Windows.Forms.Label service_lb;
        private System.Windows.Forms.TabPage icons_tp;
        private System.Windows.Forms.Label icons_lb;
    }
}