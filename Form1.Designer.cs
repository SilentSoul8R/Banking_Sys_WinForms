namespace WinFormsBankingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnCreateAccount = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            label3Form1 = new Label();
            label3Form1Balance = new Label();
            menuStrip1 = new MenuStrip();
            accountsToolStripMenuItem = new ToolStripMenuItem();
            createAccountToolStripMenuItem = new ToolStripMenuItem();
            viewAllAccountsToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            addMoneyToolStripMenuItem = new ToolStripMenuItem();
            withdrawMoneyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 24);
            label1.Name = "label1";
            label1.Size = new Size(345, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Our BANK";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(578, 128);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(162, 70);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // button3
            // 
            button3.Location = new Point(578, 218);
            button3.Name = "button3";
            button3.Size = new Size(162, 70);
            button3.TabIndex = 3;
            button3.Text = "View All Accounts";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(578, 306);
            button4.Name = "button4";
            button4.Size = new Size(162, 70);
            button4.TabIndex = 4;
            button4.Text = "Add Money";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(578, 394);
            button5.Name = "button5";
            button5.Size = new Size(162, 70);
            button5.TabIndex = 5;
            button5.Text = "Withdraw Money";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(578, 484);
            button7.Name = "button7";
            button7.Size = new Size(162, 70);
            button7.TabIndex = 7;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label3Form1
            // 
            label3Form1.AutoSize = true;
            label3Form1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3Form1.Location = new Point(943, 220);
            label3Form1.Name = "label3Form1";
            label3Form1.Size = new Size(0, 20);
            label3Form1.TabIndex = 9;
            // 
            // label3Form1Balance
            // 
            label3Form1Balance.AutoSize = true;
            label3Form1Balance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3Form1Balance.Location = new Point(943, 154);
            label3Form1Balance.Name = "label3Form1Balance";
            label3Form1Balance.Size = new Size(0, 17);
            label3Form1Balance.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountsToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1298, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountsToolStripMenuItem
            // 
            accountsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createAccountToolStripMenuItem, viewAllAccountsToolStripMenuItem });
            accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            accountsToolStripMenuItem.Size = new Size(69, 20);
            accountsToolStripMenuItem.Text = "Accounts";
            accountsToolStripMenuItem.Click += accountsToolStripMenuItem_Click;
            // 
            // createAccountToolStripMenuItem
            // 
            createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            createAccountToolStripMenuItem.Size = new Size(169, 22);
            createAccountToolStripMenuItem.Text = "Create Account";
            createAccountToolStripMenuItem.Click += createAccountToolStripMenuItem_Click_1;
            // 
            // viewAllAccountsToolStripMenuItem
            // 
            viewAllAccountsToolStripMenuItem.Name = "viewAllAccountsToolStripMenuItem";
            viewAllAccountsToolStripMenuItem.Size = new Size(169, 22);
            viewAllAccountsToolStripMenuItem.Text = "View All Accounts";
            viewAllAccountsToolStripMenuItem.Click += viewAllAccountsToolStripMenuItem_Click_1;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addMoneyToolStripMenuItem, withdrawMoneyToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(84, 20);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // addMoneyToolStripMenuItem
            // 
            addMoneyToolStripMenuItem.Name = "addMoneyToolStripMenuItem";
            addMoneyToolStripMenuItem.Size = new Size(165, 22);
            addMoneyToolStripMenuItem.Text = "Add Money";
            addMoneyToolStripMenuItem.Click += addMoneyToolStripMenuItem_Click_1;
            // 
            // withdrawMoneyToolStripMenuItem
            // 
            withdrawMoneyToolStripMenuItem.Name = "withdrawMoneyToolStripMenuItem";
            withdrawMoneyToolStripMenuItem.Size = new Size(165, 22);
            withdrawMoneyToolStripMenuItem.Text = "Withdraw Money";
            withdrawMoneyToolStripMenuItem.Click += withdrawMoneyToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.vecteezy_white_background_with_blue_geometric_and_white_line_pattern_7677104_1;
            ClientSize = new Size(1298, 592);
            Controls.Add(label3Form1Balance);
            Controls.Add(label3Form1);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnCreateAccount);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreateAccount;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Label label3Form1;
        private Label label3Form1Balance;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountsToolStripMenuItem;
        private ToolStripMenuItem createAccountToolStripMenuItem;
        private ToolStripMenuItem viewAllAccountsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem addMoneyToolStripMenuItem;
        private ToolStripMenuItem withdrawMoneyToolStripMenuItem;
    }
}
