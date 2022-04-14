namespace FormUI
{
    partial class Dashboard
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
            this.fullInfoLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.transactionText = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullInfoLabel
            // 
            this.fullInfoLabel.AutoSize = true;
            this.fullInfoLabel.Location = new System.Drawing.Point(370, 123);
            this.fullInfoLabel.Name = "fullInfoLabel";
            this.fullInfoLabel.Size = new System.Drawing.Size(82, 25);
            this.fullInfoLabel.TabIndex = 0;
            this.fullInfoLabel.Text = "FullInfo";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(370, 218);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(90, 25);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Balance";
            // 
            // transactionText
            // 
            this.transactionText.Location = new System.Drawing.Point(367, 301);
            this.transactionText.Name = "transactionText";
            this.transactionText.Size = new System.Drawing.Size(100, 31);
            this.transactionText.TabIndex = 2;
            this.transactionText.Text = "0.0";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(253, 374);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(119, 36);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(124, 521);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 36);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(461, 374);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(119, 36);
            this.depositButton.TabIndex = 6;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(253, 430);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 16);
            this.warningLabel.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 689);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.transactionText);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.fullInfoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "ATM Demo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dashboard_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullInfoLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox transactionText;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label warningLabel;
    }
}

