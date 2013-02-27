using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenPop.Pop3;
using System.Windows.Forms;

namespace _419Shredder
{
    class EMailReader
    {
        // Properties
        public static string username = "";
        public static string password = "";

        // Initialization
        static Pop3Client client = new Pop3Client();

        // Setup
        public static void setUp()
        {
            // Connect
            client.Connect("pop3.live.com", 995, true);

            // Authenticate
            try
            {
                client.Authenticate(username, password);
            }
            catch
            {
                MessageBox.Show("Authentication failed. Try again.");
            }
        }

        // Teardown
        public static void tearDown()
        {
            // Disconnect (this is what causes deletion of e-mails)
            client.Dispose(); // This calls client.disconnect() according to an OpenPOP3 dev

            // Reset
            client = new Pop3Client();

        }

        // Get mail count
        public static int getMailCount()
        {
            return client.GetMessageCount();
        }

        // Read mail
        public static EMail getMailMessage(int index)
        {
            // Create struct
            EMail output = new EMail();

            // Get message
            OpenPop.Mime.Message msg = client.GetMessage(index+1);

            // Populate struct
            try
            {
                output.fullText = msg.MessagePart.BodyEncoding.GetString(msg.MessagePart.Body);
            }
            catch
            {
            }
            output.subject = msg.Headers.Subject;
            output.sender = msg.Headers.From.Address;

            // Return struct
            return output;
        }

        // Delete mail
        public static void deleteMailMessage(int index)
        {
            client.DeleteMessage(index + 1);
        }
    }

    // A structure for storing e-mail data
    struct EMail
    {
        public string subject;
        public string fullText;
        public string sender;
    }
}
