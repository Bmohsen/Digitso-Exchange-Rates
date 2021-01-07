
namespace Digitso_Exchange_Rates
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refreshBtn = new System.Windows.Forms.Button();
            this.usdLable = new System.Windows.Forms.Label();
            this.usdIrLable = new System.Windows.Forms.Label();
            this.irFlag = new System.Windows.Forms.PictureBox();
            this.usFlag = new System.Windows.Forms.PictureBox();
            this.timeStamp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.euroBuyLable = new System.Windows.Forms.Label();
            this.euroSellLable = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rublBuyLable = new System.Windows.Forms.Label();
            this.rublSellLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usdBuyLable = new System.Windows.Forms.Label();
            this.usdSellLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.irFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usFlag)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 405);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(108, 39);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // usdLable
            // 
            this.usdLable.AutoSize = true;
            this.usdLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdLable.Location = new System.Drawing.Point(273, 9);
            this.usdLable.Name = "usdLable";
            this.usdLable.Size = new System.Drawing.Size(147, 25);
            this.usdLable.TabIndex = 1;
            this.usdLable.Text = "US Dollar / IRR";
            // 
            // usdIrLable
            // 
            this.usdIrLable.AutoSize = true;
            this.usdIrLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdIrLable.Location = new System.Drawing.Point(321, 44);
            this.usdIrLable.Name = "usdIrLable";
            this.usdIrLable.Size = new System.Drawing.Size(39, 18);
            this.usdIrLable.TabIndex = 2;
            this.usdIrLable.Text = "NAN";
            // 
            // irFlag
            // 
            this.irFlag.BackgroundImage = global::Digitso_Exchange_Rates.Properties.Resources.iran_flag_icon_256;
            this.irFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.irFlag.Image = global::Digitso_Exchange_Rates.Properties.Resources.iran_flag_icon_256;
            this.irFlag.Location = new System.Drawing.Point(426, 9);
            this.irFlag.Name = "irFlag";
            this.irFlag.Size = new System.Drawing.Size(61, 34);
            this.irFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.irFlag.TabIndex = 4;
            this.irFlag.TabStop = false;
            // 
            // usFlag
            // 
            this.usFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usFlag.BackgroundImage")));
            this.usFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usFlag.Image = global::Digitso_Exchange_Rates.Properties.Resources._640px_Flag_of_the_United_States_svg;
            this.usFlag.Location = new System.Drawing.Point(206, 9);
            this.usFlag.Name = "usFlag";
            this.usFlag.Size = new System.Drawing.Size(61, 34);
            this.usFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usFlag.TabIndex = 3;
            this.usFlag.TabStop = false;
            // 
            // timeStamp
            // 
            this.timeStamp.AutoSize = true;
            this.timeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStamp.Location = new System.Drawing.Point(-4, -4);
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Size = new System.Drawing.Size(32, 15);
            this.timeStamp.TabIndex = 5;
            this.timeStamp.Text = "NAN";
            this.timeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.euroBuyLable, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.euroSellLable, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rublBuyLable, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.rublSellLable, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usdBuyLable, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.usdSellLable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 287);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // euroBuyLable
            // 
            this.euroBuyLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.euroBuyLable.AutoSize = true;
            this.euroBuyLable.Location = new System.Drawing.Point(353, 242);
            this.euroBuyLable.Name = "euroBuyLable";
            this.euroBuyLable.Size = new System.Drawing.Size(36, 15);
            this.euroBuyLable.TabIndex = 22;
            this.euroBuyLable.Text = "Code";
            // 
            // euroSellLable
            // 
            this.euroSellLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.euroSellLable.AutoSize = true;
            this.euroSellLable.Location = new System.Drawing.Point(247, 242);
            this.euroSellLable.Name = "euroSellLable";
            this.euroSellLable.Size = new System.Drawing.Size(36, 15);
            this.euroSellLable.TabIndex = 21;
            this.euroSellLable.Text = "Code";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(142, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Euro";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "EUR";
            // 
            // rublBuyLable
            // 
            this.rublBuyLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rublBuyLable.AutoSize = true;
            this.rublBuyLable.Location = new System.Drawing.Point(353, 170);
            this.rublBuyLable.Name = "rublBuyLable";
            this.rublBuyLable.Size = new System.Drawing.Size(36, 15);
            this.rublBuyLable.TabIndex = 18;
            this.rublBuyLable.Text = "Code";
            // 
            // rublSellLable
            // 
            this.rublSellLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rublSellLable.AutoSize = true;
            this.rublSellLable.Location = new System.Drawing.Point(247, 170);
            this.rublSellLable.Name = "rublSellLable";
            this.rublSellLable.Size = new System.Drawing.Size(36, 15);
            this.rublSellLable.TabIndex = 17;
            this.rublSellLable.Text = "Code";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Russian Ruble\t";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "RUB";
            // 
            // usdBuyLable
            // 
            this.usdBuyLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usdBuyLable.AutoSize = true;
            this.usdBuyLable.Location = new System.Drawing.Point(353, 99);
            this.usdBuyLable.Name = "usdBuyLable";
            this.usdBuyLable.Size = new System.Drawing.Size(36, 15);
            this.usdBuyLable.TabIndex = 14;
            this.usdBuyLable.Text = "Code";
            // 
            // usdSellLable
            // 
            this.usdSellLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usdSellLable.AutoSize = true;
            this.usdSellLable.Location = new System.Drawing.Point(247, 99);
            this.usdSellLable.Name = "usdSellLable";
            this.usdSellLable.Size = new System.Drawing.Size(36, 15);
            this.usdSellLable.TabIndex = 13;
            this.usdSellLable.Text = "Code";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "US Dollar";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "USD";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Buy";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sell";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Currency";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code";
            // 
            // calPrice
            // 
            this.calPrice.Location = new System.Drawing.Point(592, 405);
            this.calPrice.Name = "calPrice";
            this.calPrice.Size = new System.Drawing.Size(108, 39);
            this.calPrice.TabIndex = 7;
            this.calPrice.Text = "Calculate price";
            this.calPrice.UseVisualStyleBackColor = true;
            this.calPrice.Click += new System.EventHandler(this.calPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 456);
            this.Controls.Add(this.calPrice);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.timeStamp);
            this.Controls.Add(this.irFlag);
            this.Controls.Add(this.usFlag);
            this.Controls.Add(this.usdIrLable);
            this.Controls.Add(this.usdLable);
            this.Controls.Add(this.refreshBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitso Exchange rates";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.irFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usFlag)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label usdLable;
        private System.Windows.Forms.Label usdIrLable;
        private System.Windows.Forms.PictureBox usFlag;
        private System.Windows.Forms.PictureBox irFlag;
        private System.Windows.Forms.Label timeStamp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label euroBuyLable;
        private System.Windows.Forms.Label euroSellLable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label rublBuyLable;
        private System.Windows.Forms.Label rublSellLable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label usdBuyLable;
        private System.Windows.Forms.Label usdSellLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calPrice;
    }
}

