namespace WinFormsBankingApp
{
    partial class FormEditRecord
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
            btnBack_CreateAcc = new Button();
            btnCreateAccYesEdit = new Button();
            textBoxCreateACCBalance = new TextBox();
            label2 = new Label();
            textBoxAccNumEdit = new TextBox();
            label1 = new Label();
            textBoxTakeCnicEdit = new TextBox();
            label5 = new Label();
            textBoxTakeAccountTitleEdit = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnBack_CreateAcc
            // 
            btnBack_CreateAcc.Location = new Point(12, 12);
            btnBack_CreateAcc.Name = "btnBack_CreateAcc";
            btnBack_CreateAcc.Size = new Size(75, 23);
            btnBack_CreateAcc.TabIndex = 21;
            btnBack_CreateAcc.Text = "Back";
            btnBack_CreateAcc.UseVisualStyleBackColor = true;
            btnBack_CreateAcc.Click += btnBack_CreateAcc_Click;
            // 
            // btnCreateAccYesEdit
            // 
            btnCreateAccYesEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYesEdit.Location = new Point(296, 366);
            btnCreateAccYesEdit.Name = "btnCreateAccYesEdit";
            btnCreateAccYesEdit.Size = new Size(168, 60);
            btnCreateAccYesEdit.TabIndex = 20;
            btnCreateAccYesEdit.Text = "Edit Account";
            btnCreateAccYesEdit.UseVisualStyleBackColor = true;
            btnCreateAccYesEdit.Click += btnCreateAccYesEdit_Click;
            // 
            // textBoxCreateACCBalance
            // 
            textBoxCreateACCBalance.Location = new Point(711, 367);
            textBoxCreateACCBalance.Name = "textBoxCreateACCBalance";
            textBoxCreateACCBalance.Size = new Size(484, 23);
            textBoxCreateACCBalance.TabIndex = 19;
            textBoxCreateACCBalance.TextChanged += textBoxCreateACCBalance_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 283);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 18;
            label2.Text = "Enter the Balance:\r\n";
            // 
            // textBoxAccNumEdit
            // 
            textBoxAccNumEdit.Location = new Point(96, 166);
            textBoxAccNumEdit.Name = "textBoxAccNumEdit";
            textBoxAccNumEdit.Size = new Size(484, 23);
            textBoxAccNumEdit.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 129);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 22;
            label1.Text = "Account Number:";
            // 
            // textBoxTakeCnicEdit
            // 
            textBoxTakeCnicEdit.Location = new Point(96, 367);
            textBoxTakeCnicEdit.Name = "textBoxTakeCnicEdit";
            textBoxTakeCnicEdit.Size = new Size(484, 23);
            textBoxTakeCnicEdit.TabIndex = 27;
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
            // textBoxTakeAccountTitleEdit
            // 
            textBoxTakeAccountTitleEdit.Location = new Point(711, 164);
            textBoxTakeAccountTitleEdit.Name = "textBoxTakeAccountTitleEdit";
            textBoxTakeAccountTitleEdit.Size = new Size(484, 23);
            textBoxTakeAccountTitleEdit.TabIndex = 25;
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
            // FormEditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(1298, 582);
            Controls.Add(textBoxTakeCnicEdit);
            Controls.Add(label5);
            Controls.Add(textBoxTakeAccountTitleEdit);
            Controls.Add(label4);
            Controls.Add(textBoxAccNumEdit);
            Controls.Add(label1);
            Controls.Add(btnBack_CreateAcc);
            Controls.Add(btnCreateAccYesEdit);
            Controls.Add(textBoxCreateACCBalance);
            Controls.Add(label2);
            Name = "FormEditRecord";
            Text = "FormEditRecord";
            Load += FormEditRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack_CreateAcc;
        private Button btnCreateAccYesEdit;
        private TextBox textBoxCreateACCBalance;
        private Label label2;
        private TextBox textBoxAccNumEdit;
        private Label label1;
        private TextBox textBoxTakeCnicEdit;
        private Label label5;
        private TextBox textBoxTakeAccountTitleEdit;
        private Label label4;
    }
}