namespace WinFormsBankingApp
{
    partial class CreateAccountForm
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
            textBoxGetACCNUM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCreateACCBalance = new TextBox();
            btnCreateAccYes = new Button();
            btnaccnumyes = new Button();
            btn_createcc_balance = new Button();
            btnBack_CreateAcc = new Button();
            SuspendLayout();
            // 
            // textBoxGetACCNUM
            // 
            textBoxGetACCNUM.Location = new Point(158, 142);
            textBoxGetACCNUM.Name = "textBoxGetACCNUM";
            textBoxGetACCNUM.Size = new Size(484, 23);
            textBoxGetACCNUM.TabIndex = 0;
            textBoxGetACCNUM.TextChanged += textBoxGetACCNUM_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 107);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 227);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the Balance:\r\n";
            // 
            // textBoxCreateACCBalance
            // 
            textBoxCreateACCBalance.Location = new Point(158, 262);
            textBoxCreateACCBalance.Name = "textBoxCreateACCBalance";
            textBoxCreateACCBalance.Size = new Size(484, 23);
            textBoxCreateACCBalance.TabIndex = 3;
            textBoxCreateACCBalance.TextChanged += textBoxCreateACCBalance_TextChanged;
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(298, 356);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 4;
            btnCreateAccYes.Text = "Confirm";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
            // 
            // btnaccnumyes
            // 
            btnaccnumyes.Location = new Point(687, 142);
            btnaccnumyes.Name = "btnaccnumyes";
            btnaccnumyes.Size = new Size(75, 23);
            btnaccnumyes.TabIndex = 5;
            btnaccnumyes.Text = "Confirm";
            btnaccnumyes.UseVisualStyleBackColor = true;
            btnaccnumyes.Click += btnaccnumyes_Click;
            // 
            // btn_createcc_balance
            // 
            btn_createcc_balance.Location = new Point(687, 262);
            btn_createcc_balance.Name = "btn_createcc_balance";
            btn_createcc_balance.Size = new Size(75, 23);
            btn_createcc_balance.TabIndex = 6;
            btn_createcc_balance.Text = "Confirm";
            btn_createcc_balance.UseVisualStyleBackColor = true;
            btn_createcc_balance.Click += btn_createcc_balance_Click;
            // 
            // btnBack_CreateAcc
            // 
            btnBack_CreateAcc.Location = new Point(12, 12);
            btnBack_CreateAcc.Name = "btnBack_CreateAcc";
            btnBack_CreateAcc.Size = new Size(75, 23);
            btnBack_CreateAcc.TabIndex = 7;
            btnBack_CreateAcc.Text = "Menu";
            btnBack_CreateAcc.UseVisualStyleBackColor = true;
            btnBack_CreateAcc.Click += btnBack_CreateAcc_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack_CreateAcc);
            Controls.Add(btn_createcc_balance);
            Controls.Add(btnaccnumyes);
            Controls.Add(btnCreateAccYes);
            Controls.Add(textBoxCreateACCBalance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGetACCNUM);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGetACCNUM;
        private Label label1;
        private Label label2;
        private TextBox textBoxCreateACCBalance;
        private Button btnCreateAccYes;
        private Button btnaccnumyes;
        private Button btn_createcc_balance;
        private Button btnBack_CreateAcc;
    }
}