using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssHaberÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnanadoluajansı_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.aa.com.tr/tr/teyithatti/rss/news?cat=aktuel");
            while (xmlOku.Read())
            {
                if(xmlOku.Name =="title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());    
                }
            }



        }

        private void btnahaber_Click(object sender, EventArgs e)
        {
            //https://www.ahaber.com.tr/rss/anasayfa.xml
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.ahaber.com.tr/rss/anasayfa.xml");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                }
            }


        }

        private void btnfb_Click(object sender, EventArgs e)
        {
            //http://spor.mynet.com/rss
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://spor.mynet.com/rss");
            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                }
            }

        }
    }
}
