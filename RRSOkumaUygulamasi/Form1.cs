using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RRSOkumaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
          List<Haber> kayitlar=  XmlCevir();
            lst_Baslik.DataSource = kayitlar;
        }

        private List<Haber> XmlCevir()
        {
            List<Haber> habers = new List<Haber>(); //Haber sınıfından liste oluşturduk
            XDocument xdocument = XDocument.Load(txt_rssurl.Text); //text teki url yi okuduk.
            List<XElement> xElements= xdocument.Descendants("item").ToList(); //değerlerin item içinde olduğu xml den gördük
            foreach (XElement item in xElements) //elemanları tek tek gezip değerlerini atadık.
            {
                Haber temp = new Haber();
                temp.baslik = item.Element("title").Value;
                temp.link = item.Element("link").Value;
                temp.aciklama = item.Element("description").Value;
                habers.Add(temp);
            }

            return habers;
        }

        private void lst_Baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilendeger = (ListBox)sender; //listboxa çevirdim değerleri kullancam
          Haber secilenHaber=  (Haber)secilendeger.SelectedItem; //selected item i haber e çevirdik.
            web_browser.DocumentText = secilenHaber.aciklama;
        }
    }
}
