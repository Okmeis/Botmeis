using Botmeis.Communication;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Botmeis {
    public partial class MainForm : Form {

        IrcClient irc;
        String message;

        public MainForm() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {

            if (tbUsername.Text != "" && tbOAuth.Text != "" && tbChannel.Text != "") {
                btnStart.Enabled = false;
                ircConnect();
                backgroundWorker1.RunWorkerAsync();
                //implement later
                //btnChange.Enabled = true;
                tbUsername.Enabled = false;
                tbOAuth.Enabled = false;
                //implement later:
                //btnLoadProfile.Enabled = false;
            }
        }

        private void ircConnect() {
            irc = new IrcClient("irc.twitch.tv", 6667, tbUsername.Text, tbOAuth.Text);
            irc.joinRoom(tbChannel.Text.ToLower());
            irc.sendChatMessage(tbStartMessage.Text);
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

        }

    }
}
