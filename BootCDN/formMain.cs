using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace BootCDN {
    public partial class formMain : Form {
        public struct cdnItem {
            public string ItemName, ItemHref;
        }
        public static class data {
            public static cdnItem[] Items;
        }
        public formMain()
        {
            InitializeComponent();
            textSourceUrl.Text = "http://www.bootcdn.cn";
            textXpathHref.Text = "//a[@class='package list-group-item']";
            textXpathName.Text = "//a[@class='package list-group-item']//h4[@class='package-name']";
            textXpathEachLink.Text = "//span[@class='library-url']";
            textCharset.Text = "UTF-8";
        }
        private static string getContent(string url, string charset)
        {
            if (url.Substring(0, 2) == "//")
                url = "http:" + url;
            if(charset=="")
                charset="iso-8859-1";
            MSXML2.XMLHTTP xmlHttp = new MSXML2.XMLHTTP();
            xmlHttp.open("GET", url,false,null,null);
            xmlHttp.setRequestHeader("Content-type", "text/xml;charset="+charset);
            xmlHttp.send("");
            byte[] b = (byte[]) xmlHttp.responseBody;
            return Encoding.GetEncoding(charset).GetString(b).Trim(); 
        }
        //private static string getContent(string url, string charset)
        //{
        //    string ret = String.Empty;
        //    if (url.Substring(0, 2) == "//")
        //        url = "http:" + url;
        //    WebRequest request = WebRequest.Create(url);
        //    WebResponse response = request.GetResponse();
        //    Encoding e = charset == "" ? Encoding.Default : Encoding.GetEncoding(charset);
        //    StreamReader reader = new StreamReader(response.GetResponseStream(), e);
        //    ret = reader.ReadToEnd();
        //    reader.Close();
        //    reader.Dispose();
        //    response.Close();
        //    return ret;
        //}
        private static string[] parseUrl(string pUrl)
        {
            if (pUrl.Substring(0, 2) == "//")
                pUrl = "http:" + pUrl;
            string[] ret = new string[3];
            string m = pUrl.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries)[1];
            int i = m.IndexOf('/');
            ret[0] = pUrl.Split('/', '/')[0].Trim(':');
            ret[1] = m.Split('/')[0];
            ret[2] = m.Substring(i, m.Length - i);
            return ret;
        }
        private static bool download(string cUrl)
        {
            string Content = getContent(cUrl, "");
            string Path = parseUrl(cUrl)[2].Trim('/');
            string Dir = getDirectory(Path);
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            StreamWriter sw = new StreamWriter(Path, false);
            sw.Write(Content);
            sw.Dispose();
            sw.Close();
            return true;
        }

        private static string getDirectory(string path)
        {
            string[] Dirs = path.Split('/');
            string[] NewDirs = new string[Dirs.Length - 1];
            for (int i = 0; i < Dirs.Length-1; i++)
            {
                NewDirs[i] = Dirs[i];
            }
            return string.Join("/", NewDirs);
        }

        private static string[] getLinks(string sUrl, string xLink, string charset)
        {
            string[] Links;
            sUrl = sUrl.TrimEnd('/');
            string SourceHtml = getContent(sUrl, charset);
            HtmlAgilityPack.HtmlDocument SourceDoc = new HtmlAgilityPack.HtmlDocument();
            SourceDoc.LoadHtml(SourceHtml);
            HtmlNodeCollection LinkCollection = SourceDoc.DocumentNode.SelectNodes(xLink);
            Links = new string[LinkCollection.Count];
            for (int i = 0; i < Links.Length; i++)
            {
                HtmlNode iNode = LinkCollection[i];
                Links[i] = iNode.InnerText;
            }
            return Links;
        }
        private static cdnItem[] getItems(string sUrl, string xHref, string xName, string charset)
        {
            cdnItem[] Items;
            sUrl = sUrl.TrimEnd('/');
            //string xhref = textXpathHref.Text, xname = textXpathName.Text, xdesc = textXpathDescription.Text;
            HtmlAgilityPack.HtmlDocument SourceDoc = new HtmlAgilityPack.HtmlDocument();
            string SourceHtml = getContent(sUrl, charset);
            SourceDoc.LoadHtml(SourceHtml);
            HtmlNodeCollection hrefs = SourceDoc.DocumentNode.SelectNodes(xHref);
            HtmlNodeCollection names = SourceDoc.DocumentNode.SelectNodes(xName);
            int total = hrefs.Count;
            Items = new cdnItem[total];
            for (int i = 0; i < total; i++)
            {
                HtmlNode name = names[i];
                HtmlNode href = hrefs[i];
                string iHref = href.Attributes["href"].Value;
                if (iHref.IndexOf("//") == -1)
                {
                    if (iHref.Substring(0, 1) == "/")
                        iHref = sUrl + iHref;
                    else
                        iHref = sUrl + "/" + iHref;
                }
                Items[i].ItemName = name.InnerText;
                Items[i].ItemHref = iHref;
            }
            return Items;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            data.Items = getItems(textSourceUrl.Text, textXpathHref.Text, textXpathName.Text, textCharset.Text);
            foreach (cdnItem Item in data.Items)
            {
                listBoxItems.Items.Add(Item.ItemName);
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            labelTipCurrentItem.Text = "当前项目: " + listBoxItems.Text;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            parseUrl("http://www.baidu.com/a/b/c/d/e");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] Links = getLinks(data.Items[listBoxItems.SelectedIndex].ItemHref, textXpathEachLink.Text, textCharset.Text);
            for (int i = 0; i < Links.Length;i++ )
            {
                string Link = Links[i];
                labelCurrentFile.Text = parseUrl(Link)[2];
                download(Link);
                progressTotal.Maximum = Links.Length;
                progressTotal.Value = i + 1;
            }
        }
    }
}