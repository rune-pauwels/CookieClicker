using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        private double Count = 0;
        private double Upgrade = 1;
        private double UpgradeCost = 10;
        private double AutoClick = 0;
        private double AutoClickCost = 50;

        private System.Windows.Forms.Timer automatischeTimer;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            automatischeTimer = new System.Windows.Forms.Timer();
            automatischeTimer.Interval = 1000;
            automatischeTimer.Tick += HandmatigeTimer_Tick;
            automatischeTimer.Start();
        }

        private void HandmatigeTimer_Tick(object sender, EventArgs e)
        {
            Count += AutoClick;
            CountLabel.Text = Count.ToString("F0");
        }

        private void CookieButton_Click(object sender, EventArgs e)
        {
            Count += Upgrade;
            CountLabel.Text = Count.ToString("F0");
            RebirthProgressBar.Value = (int)Count;
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            if (Count >= UpgradeCost)
            {
                Count -= UpgradeCost;
                Upgrade += 1;
                UpgradeCost *= 1.15;
                CountLabel.Text = Count.ToString("F0");
                CostAmountLabel.Text = UpgradeCost.ToString("F0");
            }
        }

        private void AutoClickButton_Click(object sender, EventArgs e)
        {
            if (Count >= AutoClickCost)
            {
                Count -= AutoClickCost;
                AutoClick += 1;
                AutoClickCost *= 1.15;
                CountLabel.Text = Count.ToString("F0");
                AutoClickAmountLabel.Text = AutoClick.ToString("F0");
                CostAutoClickLabel.Text = AutoClickCost.ToString("F0");
            }
        }
    }
}
