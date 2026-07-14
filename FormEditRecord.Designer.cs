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
            label1 = new Label();
            textBoxGetACCNUM = new TextBox();
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
            btnCreateAccYesEdit.Location = new Point(298, 356);
            btnCreateAccYesEdit.Name = "btnCreateAccYesEdit";
            btnCreateAccYesEdit.Size = new Size(168, 60);
            btnCreateAccYesEdit.TabIndex = 20;
            btnCreateAccYesEdit.Text = "Edit Account";
            btnCreateAccYesEdit.UseVisualStyleBackColor = true;
            btnCreateAccYesEdit.Click += btnCreateAccYesEdit_Click;
            // 
            // textBoxCreateACCBalance
            // 
            textBoxCreateACCBalance.Location = new Point(163, 248);
            textBoxCreateACCBalance.Name = "textBoxCreateACCBalance";
            textBoxCreateACCBalance.Size = new Size(484, 23);
            textBoxCreateACCBalance.TabIndex = 19;
            textBoxCreateACCBalance.TextChanged += textBoxCreateACCBalance_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 212);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 18;
            label2.Text = "Enter the Balance:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 113);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 17;
            label1.Text = "Enter the Account Number:";
            // 
            // textBoxGetACCNUM
            // 
            textBoxGetACCNUM.Location = new Point(163, 149);
            textBoxGetACCNUM.Name = "textBoxGetACCNUM";
            textBoxGetACCNUM.Size = new Size(484, 23);
            textBoxGetACCNUM.TabIndex = 16;
            // 
            // FormEditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack_CreateAcc);
            Controls.Add(btnCreateAccYesEdit);
            Controls.Add(textBoxCreateACCBalance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGetACCNUM);
            Name = "FormEditRecord";
            Text = "FormEditRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack_CreateAcc;
        private Button btnCreateAccYesEdit;
        private TextBox textBoxCreateACCBalance;
        private Label label2;
        private Label label1;
        private TextBox textBoxGetACCNUM;
    }
}