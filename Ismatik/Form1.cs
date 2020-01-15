using Ismatik.BLL;
using Ismatik.ENTİTY;
using Ismatik.ENTİTY.Model;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ismatik
{
    public partial class Form1 : Form
    {
        UrunBll _urunBll;
        public Form1()
        {
            InitializeComponent();
            _urunBll = new UrunBll();

        }
        public string siteAdi;
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void getList(string url, string searchText, string searchClick, string urunAdiYol, string urunIndirimYol, string urunFiyatYol, string siteAdi)
        {
            List<UrunBilgileri> LsturunBilgileri = new List<UrunBilgileri>();
            IWebDriver driver = new ChromeDriver(@"C:\Users\SENA\Documents\Visual Studio 2017\Projects\Ismatik\");
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.Id(searchText)).SendKeys(rtxtUrunAdi.Text);
            if (siteAdi == "N11")
            {
                driver.FindElement(By.ClassName(searchClick)).Click();
            }
            else
            {
                driver.FindElement(By.Id(searchClick)).Click();
            }

            ReadOnlyCollection<IWebElement> UrunAdi = driver.FindElements(By.XPath(urunAdiYol));
            ReadOnlyCollection<IWebElement> İndirim = driver.FindElements(By.XPath(urunIndirimYol));
            ReadOnlyCollection<IWebElement> Fiyat = driver.FindElements(By.XPath(urunFiyatYol));

            foreach (var item in UrunAdi)
            {
                LsturunBilgileri.Add(new UrunBilgileri { UrunAdi = item.Text, ListelemeTarihi = DateTime.Now, SiteAdi = siteAdi, anahtarKelime = rtxtUrunAdi.Text });

            }
            int i = 0;
            foreach (var item in Fiyat)
            {
                for (; i < LsturunBilgileri.Count;)
                {
                    LsturunBilgileri[i].Fiyat = item.Text;
                    i++;
                    break;
                }
            }

            i = 0;
            foreach (var item in İndirim)
            {
                for (; i < LsturunBilgileri.Count;)
                {
                    LsturunBilgileri[i].İndirim = item.Text;
                    i++;
                    break;
                }

            }
          
            _urunBll.UrunBilgileriEkle(LsturunBilgileri);
            rgrwList.DataSource = _urunBll.GetUrunBilgileris(rtxtUrunAdi.Text, siteAdi);
            rgrwList.Columns["UrunID"].IsVisible = false;
            driver.Quit();

        }

        

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnUrunSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                string url, searchText, searchClick, urunAdiYol, urunIndirimYol, urunFiyatYol;

                if (!(string.IsNullOrWhiteSpace(rtxtUrunAdi.Text)) && (rchbN11.Checked || rchbHepsiBurada.Checked))
                {
                    if (rchbN11.Checked && rchbHepsiBurada.Checked)
                    {
                        MessageBox.Show("Tek seçim yapınız");
                    }
                    else
                    {

                        if (rchbN11.Checked)
                        {
                            url = @"https://www.n11.com/";
                            searchText = "searchData";
                            searchClick = "searchBtn";
                            urunAdiYol = "/html/body/div/div/div/div/div/section/div/ul/li/div/div/a/h3";
                            urunIndirimYol = "/html/body/div/div/div/div/div/section/div/ul/li/div/div/div/div/span[2]";
                            urunFiyatYol = "/html/body/div/div/div/div/div/section/div/ul/li/div/div/a/ins";
                            siteAdi = "N11";
                            getList(url, searchText, searchClick, urunAdiYol, urunIndirimYol, urunFiyatYol, siteAdi);

                        }
                        else
                        {
                            url = @"https://www.hepsiburada.com/";
                            searchText = "productSearch";
                            searchClick = "buttonProductSearch";
                            urunAdiYol = "/html/body/div/main/div/div/div/div/div/div/section/div/div/div/div/div/div/ul/li/div/a/div/h3/div/p/span";
                            urunIndirimYol = "/html/body/div/main/div/div/div/div/div/div/section/div/div/div/div/div/div/ul/li/div/a/div/div/div";
                            urunFiyatYol = "/html/body/div/main/div/div/div/div/div/div/section/div/div/div/div/div/div/ul/li/div/a/div/div/span";

                            siteAdi = "HepsiBurada";
                            getList(url, searchText, searchClick, urunAdiYol, urunIndirimYol, urunFiyatYol, siteAdi);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boşluk bırakmayınız ve Seçim yapınız.");
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                MessageBox.Show("Bir hata oluştu");
            }
        }

        private void rbtnUrunListele_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(rtxtAnahtarKelime.Text)))
                {
                    
                    //Select(a=> new UrunBilgileri { UrunAdi=a.UrunAdi,İndirim=a.İndirim, Fiyat=a.Fiyat, SiteAdi=a.SiteAdi, ListelemeTarihi=a.ListelemeTarihi, anahtarKelime=a.anahtarKelime })
                    rgrwList.DataSource = _urunBll.GetUrunFilter(rtxtAnahtarKelime.Text, siteAdi, rtxtUrunAdi.Text);
                    rgrwList.Columns["UrunID"].IsVisible = false;
                }

                else
                {
                    MessageBox.Show("Lütfen Aranacak Kelime Girin");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu");
            }
        }
    }
}
