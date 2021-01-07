using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitso_Exchange_Rates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        private void getInfo()
        {
            const string url = @"https://www.bonbast.com/";
            HtmlWeb web = new HtmlWeb();
            var htmldoc = web.Load(url);
            var UsdIr = htmldoc.DocumentNode.SelectSingleNode("//*[@id='usd1_top']/text()").InnerText;
            var currentTimeStamp = htmldoc.DocumentNode.SelectSingleNode("/html/body/div[2]/div[2]/div[2]/div/div[1]/div[1]/div/div").InnerText;
            usdIrLable.Text = UsdIr + "T";
            timeStamp.Text = currentTimeStamp;
            // set lables prices
            usdSellLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='usd1']").InnerText;
            usdBuyLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='usd2']").InnerText;
            rublSellLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='rub1']").InnerText;
            rublBuyLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='rub2']").InnerText; 
            euroSellLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='eur1']").InnerText;
            euroBuyLable.Text = htmldoc.DocumentNode.SelectSingleNode("//*[@id='eur2']").InnerText;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            getInfo();
        }

        private void calPrice_Click(object sender, EventArgs e)
        {
            calPriceForm calPriceForm = new calPriceForm();
            calPriceForm.Show();
        }
    }
}
