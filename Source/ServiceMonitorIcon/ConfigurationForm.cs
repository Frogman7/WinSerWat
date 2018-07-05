using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiceMonitorIcon
{
    public partial class ConfigurationForm : Form
    {
        protected Configuration configuration;

        private bool runAtStartupPreviousValue;

        public ConfigurationForm(Configuration configuration)
        {
            this.configuration = configuration;

            this.InitializeComponent();

            this.InitalizeControlsFromConfiguration();
        }

        private void InitalizeControlsFromConfiguration()
        {
            var services = System.ServiceProcess.ServiceController.GetServices()
                .Select(sc => sc.ServiceName).ToArray();

            this.serviceSelect_cb.Items.AddRange(services);

            this.serviceSelect_cb.SelectedItem = services.FirstOrDefault(service => service.Equals(this.configuration.ServiceToMonitor));

            this.pollrate_tb.Text = this.configuration.PollRate.ToString();

            this.timeout_tb.Text = this.configuration.WaitForStateTimeout.ToString();

            this.runningIcon_tb.Text = this.configuration.RunningIconPath;

            this.stoppedIcon_tb.Text = this.configuration.StoppedIconPath;

            this.pausedIcon_tb.Text = this.configuration.PausedIconPath;

            this.startingIcon_tb.Text = this.configuration.StartingIconPath;

            this.stoppingIcon_tb.Text = this.configuration.StoppingIconPath;

            this.pausedIcon_tb.Text = this.configuration.PausingIconPath;

            this.unpausingIcon_tb.Text = this.configuration.UnpausingIconPath;

            this.runAtStartupPreviousValue = TaskSchedulerHelper.CheckIfTaskExists();

            this.autoStartup_cb.Checked = this.runAtStartupPreviousValue;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (this.serviceSelect_cb.SelectedIndex >= 0)
            {
                this.configuration.ServiceToMonitor = (string)this.serviceSelect_cb.SelectedItem;
            }

            this.configuration.PollRate = int.Parse(this.pollrate_tb.Text);

            this.configuration.WaitForStateTimeout = int.Parse(this.timeout_tb.Text);

            this.configuration.RunningIconPath = this.runningIcon_tb.Text;

            this.configuration.StoppedIconPath = this.stoppedIcon_tb.Text;

            this.configuration.PausedIconPath = this.pausedIcon_tb.Text;

            this.configuration.StartingIconPath = this.startingIcon_tb.Text;

            this.configuration.StoppingIconPath = this.stoppingIcon_tb.Text;

            this.configuration.PausingIconPath = this.pausedIcon_tb.Text;

            this.configuration.UnpausingIconPath = this.unpausingIcon_tb.Text;

            if (this.runAtStartupPreviousValue != this.autoStartup_cb.Checked)
            {
                if (this.autoStartup_cb.Checked)
                {
                    TaskSchedulerHelper.AddTask();
                }
                else
                {
                    TaskSchedulerHelper.RemoveTask();
                }
            }

            this.configuration.SaveToAppConfig();

            this.Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateIntegerOnlyTextbox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!Regex.IsMatch(textBox.Text, @"^[1-9]\d*$"))
            {
                textBox.BackColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openIconDialog = new OpenFileDialog();

            openIconDialog.Filter = "ico files (*.ico)|*.ico|All files (*.*)|*.*";

            if (openIconDialog.ShowDialog() == DialogResult.OK)
            {
                var textBox = (TextBox)((Control)sender).Tag;

                textBox.Text = openIconDialog.FileName;
            }
        }
    }
}