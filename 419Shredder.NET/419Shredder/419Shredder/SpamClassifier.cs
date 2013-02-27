using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _419Shredder
{
    class SpamClassifier
    {
        // Classify messages
        public static bool isSpam(EMail mail)
        {
            // Check whitelist
            if (isWhitelisted(mail.sender))
                return true;

            // Spamminess
            int spamminess = 0;
            int threshold = 80;

            // CAPS LOCK TITLES
            if (mail.subject == mail.subject.ToUpperInvariant())
                spamminess += 70;

            // million, yours truly, yahoo emails, IMF, UN

            // = Keyword filtering =
            //  NOTE: COUNT EACH MATCH!
            string[] keywords = {"million", "yours truly", "international monetary fund", "united nations", "dollars",
                                 "nigeria", "full name", "mobile/tel", "00,000", "donat", "drug", "online pharmacy",
                                 "medicine", "barrister"};
            if (mail.fullText != null)
            {
                string toLower = mail.fullText.ToLowerInvariant();
                foreach (string s in keywords)
                {
                    // Mail body
                    spamminess += 20 * Regex.Matches(mail.fullText, s).Count;

                    // Subject
                    spamminess += 20 * Regex.Matches(mail.subject, s).Count;
                }
            }
            else
            {
                spamminess += 15; // Spam can be null at times (but not always)
            }

            // Numerical emails (xxxx###@domain.com)

            // Return result
            return spamminess > threshold;
        }

        public static bool isWhitelisted(string address)
        {
            // Null check
            if (address == null)
                return false;

            // Case insensitivity
            address = address.ToLowerInvariant();
            
            // List of keywords that exist in white-listed e-mail addresses
            string[] whiteListWords = {"@illinois.edu", "@uiuc.edu"}; // An example

            // Check keywords
            foreach (string keyWord in whiteListWords)
            {
                if (address.Contains(keyWord))
                    return true; // Current address is whitelisted
            }

            // Current address isn't whitelisted
            return false;
        }

    }
}
