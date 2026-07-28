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
            MenuButton = new Button();
            label1 = new Label();
            comboBoxAddMoney = new ComboBox();
            label3 = new Label();
            textBoxWithdrawal = new TextBox();
            label2 = new Label();
            textBoxTakeCnicWithdraw = new TextBox();
            label5 = new Label();
            textBoxTakeAccountTitleWithdraw = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(308, 380);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 11;
            btnCreateAccYes.Text = "Withdraw Money";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 114);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 23;
            label1.Text = "Please select an Option. Do not Write";
            // 
            // comboBoxAddMoney
            // 
            comboBoxAddMoney.FormattingEnabled = true;
            comboBoxAddMoney.Location = new Point(96, 166);
            comboBoxAddMoney.Name = "comboBoxAddMoney";
            comboBoxAddMoney.Size = new Size(484, 23);
            comboBoxAddMoney.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 129);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 21;
            label3.Text = "Select the Account Number:";
            // 
            // textBoxWithdrawal
            // 
            textBoxWithdrawal.Location = new Point(711, 367);
            textBoxWithdrawal.Name = "textBoxWithdrawal";
            textBoxWithdrawal.Size = new Size(484, 23);
            textBoxWithdrawal.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 304);
            label2.Name = "label2";
            label2.Size = new Size(306, 20);
            label2.TabIndex = 19;
            label2.Text = "Enter the amount you want to withdraw:";
            // 
            // textBoxTakeCnicWithdraw
            // 
            textBoxTakeCnicWithdraw.Location = new Point(96, 367);
            textBoxTakeCnicWithdraw.Name = "textBoxTakeCnicWithdraw";
            textBoxTakeCnicWithdraw.Size = new Size(484, 23);
            textBoxTakeCnicWithdraw.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 332);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 26;
            label5.Text = "Enter the CNIC:\r\n";
            // 
            // textBoxTakeAccountTitleWithdraw
            // 
            textBoxTakeAccountTitleWithdraw.Location = new Point(711, 164);
            textBoxTakeAccountTitleWithdraw.Name = "textBoxTakeAccountTitleWithdraw";
            textBoxTakeAccountTitleWithdraw.Size = new Size(484, 23);
            textBoxTakeAccountTitleWithdraw.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(711, 129);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 24;
            label4.Text = "Enter the Account Title:\r\n";
            // 
            // Withdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(1298, 582);
            Controls.Add(textBoxTakeCnicWithdraw);
            Controls.Add(label5);
            Controls.Add(textBoxTakeAccountTitleWithdraw);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBoxAddMoney);
            Controls.Add(label3);
            Controls.Add(textBoxWithdrawal);
            Controls.Add(label2);
            Controls.Add(btnCreateAccYes);
            Controls.Add(MenuButton);
            Name = "Withdrawal";
            Text = "Withdrawal";
            Load += Withdrawal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAccYes;
        private Button MenuButton;
        private Label label1;
        private ComboBox comboBoxAddMoney;
        private Label label3;
        private TextBox textBoxWithdrawal;
        private Label label2;
        private TextBox textBoxTakeCnicWithdraw;
        private Label label5;
        private TextBox textBoxTakeAccountTitleWithdraw;
        private Label label4;
    }
}