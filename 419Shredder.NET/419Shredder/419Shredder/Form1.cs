using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _419Shredder
{
    public partial class Form1 : Form
    {
        // List of banned keywords


        public Form1()
        {
            InitializeComponent();
        }

        // Set up
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Set values
            EMailReader.username = txtUsername.Text;
            EMailReader.password = txtPassword.Text;

            // Setup process
            EMailReader.setUp();

            // Clear password values
            EMailReader.password = "";
            txtPassword.Text = "";

            // Enable other buttons
            btnDeSpam.Enabled = true;
            btnTearDown.Enabled = true;
        }

        // Tear down
        private void btnTearDown_Click(object sender, EventArgs e)
        {
            // Tear down EMail reader
            EMailReader.tearDown();

            // Disable buttons whose functions require an active email reader
            btnDeSpam.Enabled = false;
            btnTearDown.Enabled = false;
        }

        // Antispam stuff
        private void btnDeSpam_Click(object sender, EventArgs e)
        {
            // Get message count
            int msgCount = EMailReader.getMailCount();

            // Iterate through messages (only checks the past 50)
            for (int i = msgCount-1; i > Math.Max(0, msgCount-50); i--)
            {
                EMail msg = EMailReader.getMailMessage(i);

                // Decide if the message is spam
                if (SpamClassifier.isSpam(msg))
                {
                    if (MessageBox.Show("SPAM: " + msg.subject + " [Delete?]", "Confirm spam deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        EMailReader.deleteMailMessage(i);
                }
            }

            // SPAM CLUES
            //  Titles all in caps with more than 1 word in them

            // NOTE: Whitelisted senders is a VERY GOOD idea!

        }

    }
}
