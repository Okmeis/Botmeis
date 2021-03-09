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
                btnChange.Enabled = true;
                tbUsername.Enabled = false;
                tbOAuth.Enabled = false;
                //implement later:
                //btnLoadProfile.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            irc.joinRoom(tbChannel.Text.ToLower());
            irc.sendChatMessage(tbStartMessage.Text);
        }


        private void ircConnect() {
            irc = new IrcClient("irc.twitch.tv", 6667, tbUsername.Text, tbOAuth.Text);
            irc.joinRoom(tbChannel.Text.ToLower());
            irc.sendChatMessage(tbStartMessage.Text);
        }


        /*--------------------------Textbox-Methods--------------------------*/

        private void tbUsername_TextChanged(object sender, EventArgs e) { greylabler(tbUsername, lbUsername); }
        private void tbOAuth_TextChanged(object sender, EventArgs e) { greylabler(tbOAuth, lbOAuth); }
        private void tbChannel_TextChanged(object sender, EventArgs e) { greylabler(tbChannel, lbChannel); }
        private void tbStartMessage_TextChanged(object sender, EventArgs e) { greylabler(tbStartMessage, lbStartMessage); }

        private static void greylabler(TextBox sender1, Label sender2) {
            if (sender1.Text != "") sender2.Visible = false;
            else sender2.Visible = true;
        }


        /*-----------------------------Label-Methods----------------------------*/

        private void lbUsername_Click(object sender, EventArgs e) { tbUsername.Select(); }
        private void lbChannel_Click(object sender, EventArgs e) { tbChannel.Select(); }
        private void lbOAuth_Click(object sender, EventArgs e) { tbOAuth.Select(); }
        private void lbStartMessage_Click(object sender, EventArgs e) { tbStartMessage.Select(); }


        /*-----------------------------BackgroundWorker----------------------------*/

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

        }

    }
}
