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
            btnBack_CreateAcc = new Button();
            label3 = new Label();
            textBoxTakeAccountTitle = new TextBox();
            label4 = new Label();
            textBoxTakeCnicCreate = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxGetACCNUM
            // 
            textBoxGetACCNUM.Location = new Point(96, 166);
            textBoxGetACCNUM.Name = "textBoxGetACCNUM";
            textBoxGetACCNUM.Size = new Size(484, 23);
            textBoxGetACCNUM.TabIndex = 0;
            textBoxGetACCNUM.TextChanged += textBoxGetACCNUM_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 129);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 304);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the Balance:\r\n";
            // 
            // textBoxCreateACCBalance
            // 
            textBoxCreateACCBalance.Location = new Point(711, 367);
            textBoxCreateACCBalance.Name = "textBoxCreateACCBalance";
            textBoxCreateACCBalance.Size = new Size(484, 23);
            textBoxCreateACCBalance.TabIndex = 3;
            textBoxCreateACCBalance.TextChanged += textBoxCreateACCBalance_TextChanged;
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(298, 378);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 4;
            btnCreateAccYes.Text = "Create Account";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
            // 
            // btnBack_CreateAcc
            // 
            btnBack_CreateAcc.Location = new Point(12, 12);
            btnBack_CreateAcc.Name = "btnBack_CreateAcc";
            btnBack_CreateAcc.Size = new Size(75, 23);
            btnBack_CreateAcc.TabIndex = 7;
            btnBack_CreateAcc.Text = "Back";
            btnBack_CreateAcc.UseVisualStyleBackColor = true;
            btnBack_CreateAcc.Click += btnBack_CreateAcc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 108);
            label3.Name = "label3";
            label3.Size = new Size(299, 15);
            label3.TabIndex = 8;
            label3.Text = "Please use PKBM<num> Format (PKBMxxx456321xxxx)";
            // 
            // textBoxTakeAccountTitle
            // 
            textBoxTakeAccountTitle.Location = new Point(711, 164);
            textBoxTakeAccountTitle.Name = "textBoxTakeAccountTitle";
            textBoxTakeAccountTitle.Size = new Size(484, 23);
            textBoxTakeAccountTitle.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(711, 129);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 9;
            label4.Text = "Enter the Account Title:\r\n";
            // 
            // textBoxTakeCnicCreate
            // 
            textBoxTakeCnicCreate.Location = new Point(96, 367);
            textBoxTakeCnicCreate.Name = "textBoxTakeCnicCreate";
            textBoxTakeCnicCreate.Size = new Size(484, 23);
            textBoxTakeCnicCreate.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 332);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 11;
            label5.Text = "Enter the CNIC:\r\n";
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(1298, 582);
            Controls.Add(textBoxTakeCnicCreate);
            Controls.Add(label5);
            Controls.Add(textBoxTakeAccountTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBack_CreateAcc);
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
        private Button btnBack_CreateAcc;
        private Label label3;
        private TextBox textBoxTakeAccountTitle;
        private Label label4;
        private TextBox textBoxTakeCnicCreate;
        private Label label5;
    }
}