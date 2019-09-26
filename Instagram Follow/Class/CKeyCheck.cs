using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Email_Scrape
{
    class CKeyCheck
    {
        public bool thirdPart()
        {
            WebRequest request = null;
            WebResponse response = null;
            Stream resStream = null;
            StreamReader resReader = null;
            string resstring = "";
            try
            {
                string uristring = "http://socialinterestmarketer.com/software/check.php";
                request = WebRequest.Create(uristring.Trim());
                response = request.GetResponse();
                resStream = response.GetResponseStream();
                resReader = new StreamReader(resStream);
                resstring = resReader.ReadToEnd();
            }
            catch (Exception)
            {
            }
            finally
            {
                if (resReader != null) resReader.Close();
                if (response != null) response.Close();
            }

            if (resstring.Contains("Bobby Krieger")) return true;

            return false;
        }

        public string getSite(string url)
        {
            WebRequest request = null;
            WebResponse response = null;
            Stream resStream = null;
            StreamReader resReader = null;
            string resstring = "";
            try
            {
                string uristring = url;
                request = WebRequest.Create(uristring.Trim());
                response = request.GetResponse();
                resStream = response.GetResponseStream();
                resReader = new StreamReader(resStream);
                resstring = resReader.ReadToEnd();
            }
            catch (Exception)
            {
            }
            finally
            {
                if (resReader != null) resReader.Close();
                if (response != null) response.Close();
            }
            return resstring;
        }
    }
}
