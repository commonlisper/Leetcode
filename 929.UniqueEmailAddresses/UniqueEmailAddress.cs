using System;
using System.Collections.Generic;
using System.Linq;

namespace _929.UniqueEmailAddresses
{
    public class UniqueEmailAddress
    {
        public int NumUniqueEmails(string[] emails)
        {
            if (emails == null)
            {
                throw new ArgumentNullException(nameof(emails), "Emails are null.");
            }

            if (emails.Length == 0)
            {
                return 0;
            }

            var normalizedEmails = emails.Select(NormalizeEmail);
            var uniqueEmails = new List<string>();
            
            foreach (var email in normalizedEmails)
            {
                if (!uniqueEmails.Contains(email))
                {
                    uniqueEmails.Add(email);
                }
            }

            return uniqueEmails.Count();
        }

        private string NormalizeEmail(string email)
        {
            var splittedEmail = email.Split('@');
            string localName = splittedEmail[0];
            string domain = splittedEmail[1];
            var localNameWithoutDots = localName.Replace(".", "");
            var localNameWithoutPluses = localNameWithoutDots;

            if (localNameWithoutDots.Contains("+"))
            {
                localNameWithoutPluses = localNameWithoutDots.Remove(localNameWithoutDots.IndexOf('+'));
            }

            return $"{localNameWithoutPluses}@{domain}";
        }
    }
}
