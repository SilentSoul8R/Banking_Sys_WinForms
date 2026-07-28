namespace WinFormsBankingApp
{
    partial class Deposit
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
            MenuButton = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            btnCreateAccYes = new Button();
            label1 = new Label();
            comboBoxAddMoney = new ComboBox();
            label3 = new Label();
            textBoxTakeCnicDeposit = new TextBox();
            label5 = new Label();
            textBoxTakeAccountTitleDeposit = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // MenuButton
            // 
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(75, 23);
            MenuButton.TabIndex = 0;
            MenuButton.Text = "Back";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(711, 332);
            label2.Name = "label2";
            label2.Size = new Size(286, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the amount you want to deposit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(711, 367);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(484, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(560, 498);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 5;
            btnCreateAccYes.Text = "Add Money";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 206);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 18;
            label1.Text = "Please select an Option. Do not Write";
            // 
            // comboBoxAddMoney
            // 
            comboBoxAddMoney.FormattingEnabled = true;
            comboBoxAddMoney.Location = new Point(96, 166);
            comboBoxAddMoney.Name = "comboBoxAddMoney";
            comboBoxAddMoney.Size = new Size(484, 23);
            comboBoxAddMoney.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 129);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 16;
            label3.Text = "Select the Account Number:";
            // 
            // textBoxTakeCnicDeposit
            // 
            textBoxTakeCnicDeposit.Location = new Point(96, 367);
            textBoxTakeCnicDeposit.Name = "textBoxTakeCnicDeposit";
            textBoxTakeCnicDeposit.Size = new Size(484, 23);
            textBoxTakeCnicDeposit.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 332);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 21;
            label5.Text = "Enter the CNIC:\r\n";
            // 
            // textBoxTakeAccountTitleDeposit
            // 
            textBoxTakeAccountTitleDeposit.Location = new Point(711, 164);
            textBoxTakeAccountTitleDeposit.Name = "textBoxTakeAccountTitleDeposit";
            textBoxTakeAccountTitleDeposit.Size = new Size(484, 23);
            textBoxTakeAccountTitleDeposit.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(711, 129);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 19;
            label4.Text = "Enter the Account Title:\r\n";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vecteezy_white_background_with_blue_geometric_and_white_line_pattern_7677104_1;
            ClientSize = new Size(1298, 582);
            Controls.Add(textBoxTakeCnicDeposit);
            Controls.Add(label5);
            Controls.Add(textBoxTakeAccountTitleDeposit);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBoxAddMoney);
            Controls.Add(label3);
            Controls.Add(btnCreateAccYes);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(MenuButton);
            Name = "Deposit";
            Text = "Deposit";
            Load += Deposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuButton;
        private Label label2;
        private TextBox textBox2;
        private Button btnCreateAccYes;
        private Label label1;
        private ComboBox comboBoxAddMoney;
        private Label label3;
        private TextBox textBoxTakeCnicDeposit;
        private Label label5;
        private TextBox textBoxTakeAccountTitleDeposit;
        private Label label4;
    }
}