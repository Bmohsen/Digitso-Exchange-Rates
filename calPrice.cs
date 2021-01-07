using HtmlAgilityPack;
using System;
using System.Windows.Forms;

namespace Digitso_Exchange_Rates
{
    public partial class calPriceForm : Form
    {
        public calPriceForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (sourceInput.Text != "")
            {
                int sourcePrice = int.Parse(sourceInput.Text);
                switch (sourceCurrency.Text)
                {
                    case "RUB":
                        exchangePriceRub(DestinationCurrency.SelectedItem.ToString(), sourcePrice);
                        break;
                    case "USD":
                        exchangePriceUsd(DestinationCurrency.SelectedItem.ToString(), sourcePrice);
                        break;
                    case "EUR":
                        exchangePriceEur(DestinationCurrency.SelectedItem.ToString(), sourcePrice);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter number for source currency!");
            }

        }

        // exchange Euro currency
        private void exchangePriceEur(string currency, int sourcePrice)
        {
            const string url = @"https://www.bonbast.com/";
            HtmlWeb web = new HtmlWeb();
            var htmldoc = web.Load(url);
            var euroSellPrice = htmldoc.DocumentNode.SelectSingleNode("//*[@id='eur1']").InnerText;

            switch (currency)
            {
                case "IRT":
                    int finalPrice = int.Parse(euroSellPrice) * sourcePrice;
                    exchangePriceOutPut.Text = finalPrice.ToString();
                    break;
                default:
                    break;
            }
        }

        // exchange US Dollar currency
        private void exchangePriceUsd(string currency, int sourcePrice)
        {
            const string url = @"https://www.bonbast.com/";
            HtmlWeb web = new HtmlWeb();
            var htmldoc = web.Load(url);
            var usdSellPrice = htmldoc.DocumentNode.SelectSingleNode("//*[@id='usd1']").InnerText;

            switch (currency)
            {
                case "IRT":
                    int finalPrice = int.Parse(usdSellPrice) * sourcePrice;
                    exchangePriceOutPut.Text = finalPrice.ToString();
                    break;
                default:
                    break;
            }
        }
        // exchange russian ruble currency
        private void exchangePriceRub(string currency, int sourcePrice)
        {
            const string url = @"https://www.bonbast.com/";
            HtmlWeb web = new HtmlWeb();
            var htmldoc = web.Load(url);
            var rubSellPrice = htmldoc.DocumentNode.SelectSingleNode("//*[@id='rub1']").InnerText;

            switch (currency)
            {
                case "IRT":
                    int finalPrice = int.Parse(rubSellPrice) * sourcePrice;
                    exchangePriceOutPut.Text = finalPrice.ToString();
                    break;
                default:
                    break;
            }
        }

        private void calPriceForm_Load(object sender, EventArgs e)
        {
            // set default currencies on form load
            sourceCurrency.SelectedItem = "RUB";
            DestinationCurrency.SelectedItem = "IRT";
        }

        private void sourceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void profPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        // calculate the margin profit 
        private void profitBtn_Click(object sender, EventArgs e)
        {
            if (exchangePriceOutPut.Text != "0" && profPercent.Text != "")
            {
                float totalPrice = float.Parse(exchangePriceOutPut.Text);
                float margin = float.Parse(profPercent.Text);
                float profit = margin / 100 * totalPrice;
                float finalPrice = profit + totalPrice;
                profitExchangePrice.Text = Math.Floor(finalPrice).ToString();
                profitBox.Text = Math.Floor(profit).ToString();
            } 
        }
    }
}
