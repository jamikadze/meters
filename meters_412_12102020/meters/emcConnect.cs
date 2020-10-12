using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace meters
{
    public class emcConnect
    {
        private string meter, errorMsg, result="";
        private int  erCode;
        private XmlDocument xml;

        public emcConnect() { }
        public emcConnect(string meterno)
        {
            meter = meterno;
           
        }

        public string conMethod()
        {
            try
            {
                string strResponseValue = "", strcompr = "";
                XDocument doc = makeXML(meter);
                strcompr = Compress(doc.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Globals.url + "reading?token=" + Globals.sessionId.ToString() + "&xml=" + strcompr);
                request.Method = "POST";
                request.KeepAlive = true;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Timeout = Timeout.Infinite;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("error code:" + response.StatusCode.ToString());
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    responseStream.Close();
                }
                response.Close();

                JObject json = JObject.Parse(strResponseValue);
                erCode = (int)json.GetValue("errorCode");
                errorMsg = json.GetValue("errorMsg").ToString();
                xml = new XmlDocument();
                var x = json.GetValue("xml").ToString();
                if (erCode == 0)
                {
                    if (x != null&&x.Length!=0)
                    {
                        string decompr = Decompress(x);
                        xml.LoadXml(decompr);
                        XmlNodeList node2 = xml.GetElementsByTagName("m:value");
                        result = "Показания: " + node2[0].InnerText;
                       // Console.WriteLine(result);
                    }
                }
                else result = "Нет связи";
                //StreamWriter strwr = new StreamWriter(@"\\server\asu\Jamila\Logs\reading.txt", true, System.Text.Encoding.Unicode);
                //strwr.WriteLine(DateTime.Now.ToString());
                //strwr.WriteLine(meter);
                //strwr.WriteLine(result);
                //strwr.WriteLine(Decompress(x));
                //strwr.Close();
                return result;
            }
            catch (Exception ex)
            {
                StreamWriter strwr = new StreamWriter(@"\\server\asu\Jamila\Logs\reading_log.txt", true, System.Text.Encoding.Unicode);
                strwr.WriteLine(DateTime.Now.ToString());
                strwr.WriteLine(meter);
                strwr.WriteLine(ex.ToString());
                strwr.Close();
                return "Error";
            }
        }

        

        private XDocument makeXML(string meterm)
        {
            Guid g = Guid.NewGuid();
            string refs = "0.0.0.1.1.1.12.0.0.0.0.0.0.0.0.3.72.0";

            XDocument doc = new XDocument();
            try
            {
                XNamespace m = "http://iec.ch/TC57/2011/schema/message";
                doc = new XDocument(new XDeclaration("1.0", "utf-8", "true"),
                    new XElement("RequestMessage", new XAttribute(XNamespace.Xmlns + "m", "http://iec.ch/TC57/2011/schema/message"),
                        new XElement("Header",
                            new XElement("Verb", "create"),
                            new XElement("Noun", "MeterReadings"),
                            new XElement("Revision", "2.0"),
                            new XElement("Timestamp", System.DateTime.UtcNow),
                            new XElement("Source", "FDM"),
                            new XElement("AckRequired", "false"),
                            new XElement("AsyncReplyFlag", "false"),
                            new XElement("MessageID", g.ToString()),
                            new XElement("CorrelationID", g.ToString())),
                        new XElement("Payload",
                            new XElement(m + "MeterReadings",
                                new XElement(m + "ReadingType",
                                    new XElement(m + "mRID", refs),
                                    new XElement(m + "name", "Reading")
                                ),
                                new XElement(m + "MeterReading",
                                    new XElement(m + "Meter",
                                        new XElement(m + "mRID", meterm)
                                        )
                                )
                            )
                        )
                    )
                );
            }
            catch (Exception ex)
            {
                StreamWriter strwr = new StreamWriter(@"\\server\asu\Jamila\Logs\reading_log.txt", true, System.Text.Encoding.Unicode);
                strwr.WriteLine(DateTime.Now.ToString());
                strwr.WriteLine(ex.ToString());
                strwr.Close();
            }

            return doc;
        }
        
        private string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);

            MemoryStream ms = new MemoryStream();
            using (GZipStream zs = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zs.Write(buffer, 0, buffer.Length);
            }

            String s = Convert.ToBase64String(ms.ToArray());
            return s;
        }
        private string Decompress(string compressedText)
        {
            byte[] outputb = Convert.FromBase64String(compressedText);
            MemoryStream ms = new MemoryStream(outputb);

            using (MemoryStream source = new MemoryStream())
            {
                using (GZipStream zs = new GZipStream(ms, CompressionMode.Decompress, true))
                {
                    byte[] bytes = new byte[4096];

                    int n = 0;
                    while ((n = zs.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        source.Write(bytes, 0, n);
                    }
                }
                string orgStr = Encoding.UTF8.GetString(source.ToArray());
                return orgStr;
            }
        }
        
    }
 
}
