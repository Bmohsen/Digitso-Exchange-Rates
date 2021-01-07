
namespace Digitso_Exchange_Rates
{
    partial class calPriceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calPriceForm));
            this.sourceCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profPercent = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.exchangePriceOutPut = new System.Windows.Forms.TextBox();
            this.profitBtn = new System.Windows.Forms.Button();
            this.profitExchangePrice = new System.Windows.Forms.TextBox();
            this.profitBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceCurrency
            // 
            this.sourceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sourceCurrency.FormattingEnabled = true;
            this.sourceCurrency.Items.AddRange(new object[] {
            "USD",
            "RUB",
            "EUR",
            "IRT"});
            this.sourceCurrency.Location = new System.Drawing.Point(3, 68);
            this.sourceCurrency.Name = "sourceCurrency";
            this.sourceCurrency.Size = new System.Drawing.Size(275, 21);
            this.sourceCurrency.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source currency";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceInput
            // 
            this.sourceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sourceInput.Location = new System.Drawing.Point(3, 103);
            this.sourceInput.Multiline = true;
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(275, 31);
            this.sourceInput.TabIndex = 2;
            this.sourceInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.profPercent_KeyDown);
            this.sourceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sourceInput_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Currency";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DestinationCurrency
            // 
            this.DestinationCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DestinationCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DestinationCurrency.FormattingEnabled = true;
            this.DestinationCurrency.Items.AddRange(new object[] {
            "USD",
            "RUB",
            "EUR",
            "IRT"});
            this.DestinationCurrency.Location = new System.Drawing.Point(284, 68);
            this.DestinationCurrency.Name = "DestinationCurrency";
            this.DestinationCurrency.Size = new System.Drawing.Size(275, 21);
            this.DestinationCurrency.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profit(%)";
            // 
            // profPercent
            // 
            this.profPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.profPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profPercent.Location = new System.Drawing.Point(3, 161);
            this.profPercent.Multiline = true;
            this.profPercent.Name = "profPercent";
            this.profPercent.Size = new System.Drawing.Size(275, 32);
            this.profPercent.TabIndex = 7;
            this.profPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.profPercent_KeyDown);
            this.profPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sourceInput_KeyPress);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(565, 103);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(144, 31);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price with Profit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.sourceCurrency, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DestinationCurrency, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.profPercent, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.exchangePriceOutPut, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.profitBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.profitExchangePrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.calcBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.profitBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.94846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.05155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 428);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Your profit margin:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exchangePriceOutPut
            // 
            this.exchangePriceOutPut.Location = new System.Drawing.Point(284, 103);
            this.exchangePriceOutPut.Multiline = true;
            this.exchangePriceOutPut.Name = "exchangePriceOutPut";
            this.exchangePriceOutPut.ReadOnly = true;
            this.exchangePriceOutPut.Size = new System.Drawing.Size(275, 31);
            this.exchangePriceOutPut.TabIndex = 14;
            this.exchangePriceOutPut.Text = "0";
            // 
            // profitBtn
            // 
            this.profitBtn.Location = new System.Drawing.Point(565, 161);
            this.profitBtn.Name = "profitBtn";
            this.profitBtn.Size = new System.Drawing.Size(144, 32);
            this.profitBtn.TabIndex = 9;
            this.profitBtn.Text = "calculate";
            this.profitBtn.UseVisualStyleBackColor = true;
            this.profitBtn.Click += new System.EventHandler(this.profitBtn_Click);
            // 
            // profitExchangePrice
            // 
            this.profitExchangePrice.Location = new System.Drawing.Point(284, 161);
            this.profitExchangePrice.Multiline = true;
            this.profitExchangePrice.Name = "profitExchangePrice";
            this.profitExchangePrice.ReadOnly = true;
            this.profitExchangePrice.Size = new System.Drawing.Size(275, 32);
            this.profitExchangePrice.TabIndex = 15;
            this.profitExchangePrice.Text = "0";
            // 
            // profitBox
            // 
            this.profitBox.Location = new System.Drawing.Point(284, 199);
            this.profitBox.Multiline = true;
            this.profitBox.Name = "profitBox";
            this.profitBox.ReadOnly = true;
            this.profitBox.Size = new System.Drawing.Size(275, 31);
            this.profitBox.TabIndex = 16;
            this.profitBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // calPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calPriceForm";
            this.Text = "exchange and profit";
            this.Load += new System.EventHandler(this.calPriceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourceCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DestinationCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profPercent;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button profitBtn;
        private System.Windows.Forms.TextBox exchangePriceOutPut;
        private System.Windows.Forms.TextBox profitExchangePrice;
        private System.Windows.Forms.TextBox profitBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}