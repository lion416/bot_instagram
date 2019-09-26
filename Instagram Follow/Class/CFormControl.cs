using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Instagram_Email_Scrape.Class
{
    class CFormControl
    {
        public string EmailSearch(string text)
        {
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            MatchCollection emailMatches = emailRegex.Matches(text);
            foreach (Match emailMatch in emailMatches)
            {
                if (!emailMatch.Value.ToLower().Contains(".png") && !emailMatch.Value.ToLower().Contains(".jpg"))
                    return emailMatch.Value;
            }
            return "";
        }
    }
}
