using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace meters
{
    class emcLogin
    {
        private string strResponseValue;

         public emcLogin()
        {
            connect();
        }

        private void connect()
        {
            try
            {
                Globals.url = @"http://192.168.20.244:8080/epower/billingservice/";
                Globals.username = "UBilling";
                Globals.password = "ubilling.,";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Globals.url + "login?username=" + Globals.username + "&password=" + getMD5(Globals.password));
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new ApplicationException("error code:" + response.StatusCode.ToString());
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                    }
                }
                JObject json = JObject.Parse(strResponseValue);
                Globals.sessionId = json.GetValue("sessionID").ToString();
            }
            catch (Exception ex)
            {
                StreamWriter strwr = new StreamWriter(@"\\server\asu\Jamila\Logs\login_log.txt", true, System.Text.Encoding.Unicode);
                strwr.WriteLine(DateTime.Now.ToString());
                strwr.WriteLine(ex.ToString());
                strwr.Close();
            }
        }

        private string getMD5(string password)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return (sb.ToString());
        }
    }
}
