namespace WinFormsBankingApp
{
    partial class Withdrawal
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
            btnCreateAccYes = new Button();
            textBoxWithdrawal = new TextBox();
            textBoxAccWithdrawal = new TextBox();
            label2 = new Label();
            label1 = new Label();
            MenuButton = new Button();
            SuspendLayout();
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(314, 362);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 11;
            btnCreateAccYes.Text = "Confirm";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
            // 
            // textBoxWithdrawal
            // 
            textBoxWithdrawal.Location = new Point(220, 306);
            textBoxWithdrawal.Name = "textBoxWithdrawal";
            textBoxWithdrawal.Size = new Size(376, 23);
            textBoxWithdrawal.TabIndex = 10;
            // 
            // textBoxAccWithdrawal
            // 
            textBoxAccWithdrawal.Location = new Point(220, 178);
            textBoxAccWithdrawal.Name = "textBoxAccWithdrawal";
            textBoxAccWithdrawal.Size = new Size(376, 23);
            textBoxAccWithdrawal.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 255);
            label2.Name = "label2";
            label2.Size = new Size(311, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter the amount you want to Withdraw.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 128);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter the Account number";
            // 
            // MenuButton
            // 
            MenuButton.Location = new Point(14, 15);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(75, 23);
            MenuButton.TabIndex = 6;
            MenuButton.Text = "Back";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // Withdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateAccYes);
            Controls.Add(textBoxWithdrawal);
            Controls.Add(textBoxAccWithdrawal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MenuButton);
            Name = "Withdrawal";
            Text = "Withdrawal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAccYes;
        private TextBox textBoxWithdrawal;
        private TextBox textBoxAccWithdrawal;
        private Label label2;
        private Label label1;
        private Button MenuButton;
    }
}