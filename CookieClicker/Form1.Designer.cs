namespace CookieClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CookieButton = new Button();
            CookieCounterLabel = new Label();
            CountLabel = new Label();
            UpgradeButton = new Button();
            CostLabel = new Label();
            CostAmountLabel = new Label();
            label1 = new Label();
            AutoClickAmountLabel = new Label();
            AutoClickButton = new Button();
            label2 = new Label();
            CostAutoClickLabel = new Label();
            RebirthProgressBar = new ProgressBar();
            label3 = new Label();
            RebirthPriceLabel = new Label();
            RebirthButton = new Button();
            SuspendLayout();
            // 
            // CookieButton
            // 
            CookieButton.BackgroundImage = Properties.Resources.coc;
            CookieButton.Location = new Point(12, 69);
            CookieButton.Name = "CookieButton";
            CookieButton.Size = new Size(256, 256);
            CookieButton.TabIndex = 1;
            CookieButton.Text = ".";
            CookieButton.UseVisualStyleBackColor = true;
            CookieButton.Click += CookieButton_Click;
            // 
            // CookieCounterLabel
            // 
            CookieCounterLabel.AutoSize = true;
            CookieCounterLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            CookieCounterLabel.Location = new Point(12, 9);
            CookieCounterLabel.Name = "CookieCounterLabel";
            CookieCounterLabel.Size = new Size(155, 25);
            CookieCounterLabel.TabIndex = 2;
            CookieCounterLabel.Text = "Cookie Counter :";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            CountLabel.Location = new Point(173, 9);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(23, 25);
            CountLabel.TabIndex = 3;
            CountLabel.Text = "0";
            // 
            // UpgradeButton
            // 
            UpgradeButton.Location = new Point(298, 43);
            UpgradeButton.Name = "UpgradeButton";
            UpgradeButton.Size = new Size(93, 34);
            UpgradeButton.TabIndex = 4;
            UpgradeButton.Text = "Upgrade";
            UpgradeButton.UseVisualStyleBackColor = true;
            UpgradeButton.Click += UpgradeButton_Click;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(397, 53);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 5;
            CostLabel.Text = "Cost:";
            // 
            // CostAmountLabel
            // 
            CostAmountLabel.AutoSize = true;
            CostAmountLabel.Location = new Point(428, 53);
            CostAmountLabel.Name = "CostAmountLabel";
            CostAmountLabel.Size = new Size(19, 15);
            CostAmountLabel.TabIndex = 6;
            CostAmountLabel.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 7;
            label1.Text = "Auto Click:";
            // 
            // AutoClickAmountLabel
            // 
            AutoClickAmountLabel.AutoSize = true;
            AutoClickAmountLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            AutoClickAmountLabel.Location = new Point(123, 41);
            AutoClickAmountLabel.Name = "AutoClickAmountLabel";
            AutoClickAmountLabel.Size = new Size(23, 25);
            AutoClickAmountLabel.TabIndex = 8;
            AutoClickAmountLabel.Text = "0";
            // 
            // AutoClickButton
            // 
            AutoClickButton.Location = new Point(298, 83);
            AutoClickButton.Name = "AutoClickButton";
            AutoClickButton.Size = new Size(93, 41);
            AutoClickButton.TabIndex = 9;
            AutoClickButton.Text = "Upgrade Auto Click";
            AutoClickButton.UseVisualStyleBackColor = true;
            AutoClickButton.Click += AutoClickButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 96);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "Cost:";
            // 
            // CostAutoClickLabel
            // 
            CostAutoClickLabel.AutoSize = true;
            CostAutoClickLabel.Location = new Point(428, 96);
            CostAutoClickLabel.Name = "CostAutoClickLabel";
            CostAutoClickLabel.Size = new Size(19, 15);
            CostAutoClickLabel.TabIndex = 11;
            CostAutoClickLabel.Text = "50";
            // 
            // RebirthProgressBar
            // 
            RebirthProgressBar.ForeColor = SystemColors.ControlDarkDark;
            RebirthProgressBar.Location = new Point(12, 356);
            RebirthProgressBar.Maximum = 1000;
            RebirthProgressBar.Name = "RebirthProgressBar";
            RebirthProgressBar.Size = new Size(251, 23);
            RebirthProgressBar.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 13;
            label3.Text = "RebirthPrice:";
            // 
            // RebirthPriceLabel
            // 
            RebirthPriceLabel.AutoSize = true;
            RebirthPriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            RebirthPriceLabel.Location = new Point(140, 328);
            RebirthPriceLabel.Name = "RebirthPriceLabel";
            RebirthPriceLabel.Size = new Size(53, 25);
            RebirthPriceLabel.TabIndex = 14;
            RebirthPriceLabel.Text = "1000";
            // 
            // RebirthButton
            // 
            RebirthButton.Location = new Point(12, 385);
            RebirthButton.Name = "RebirthButton";
            RebirthButton.Size = new Size(75, 23);
            RebirthButton.TabIndex = 15;
            RebirthButton.Text = "Rebirth";
            RebirthButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(RebirthButton);
            Controls.Add(RebirthPriceLabel);
            Controls.Add(label3);
            Controls.Add(RebirthProgressBar);
            Controls.Add(CostAutoClickLabel);
            Controls.Add(label2);
            Controls.Add(AutoClickButton);
            Controls.Add(AutoClickAmountLabel);
            Controls.Add(label1);
            Controls.Add(CostAmountLabel);
            Controls.Add(CostLabel);
            Controls.Add(UpgradeButton);
            Controls.Add(CountLabel);
            Controls.Add(CookieCounterLabel);
            Controls.Add(CookieButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CookieButton;
        private Label CookieCounterLabel;
        private Label CountLabel;
        private Button UpgradeButton;
        private Label CostLabel;
        private Label CostAmountLabel;
        private Label label1;
        private Label AutoClickAmountLabel;
        private Button AutoClickButton;
        private Label label2;
        private Label CostAutoClickLabel;
        private ProgressBar RebirthProgressBar;
        private Label label3;
        private Label RebirthPriceLabel;
        private Button RebirthButton;
    }
}
