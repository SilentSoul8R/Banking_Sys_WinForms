namespace WinFormsBankingApp
{
    partial class DisplayForm
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
            label_Display_All = new Label();
            btn_Menu_DisplayAll = new Button();
            dataGridView1 = new DataGridView();
            AccountNumber = new DataGridViewTextBoxColumn();
            AccountTitle = new DataGridViewTextBoxColumn();
            Cnic = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewButtonColumn();
            BtnAddRecord = new Button();
            btnSearch = new Button();
            textBoxAccNum = new TextBox();
            textBoxAccTitle = new TextBox();
            textBoxAccCnic = new TextBox();
            label1 = new Label();
            textBoxFromValue = new TextBox();
            textBoxToValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_Display_All
            // 
            label_Display_All.AutoSize = true;
            label_Display_All.Font = new Font("Century Schoolbook", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Display_All.Location = new Point(290, 30);
            label_Display_All.Name = "label_Display_All";
            label_Display_All.Size = new Size(725, 41);
            label_Display_All.TabIndex = 0;
            label_Display_All.Text = "This Shows all Active Accounts in the Bank";
            // 
            // btn_Menu_DisplayAll
            // 
            btn_Menu_DisplayAll.Location = new Point(12, 12);
            btn_Menu_DisplayAll.Name = "btn_Menu_DisplayAll";
            btn_Menu_DisplayAll.Size = new Size(75, 23);
            btn_Menu_DisplayAll.TabIndex = 1;
            btn_Menu_DisplayAll.Text = "Back";
            btn_Menu_DisplayAll.UseVisualStyleBackColor = true;
            btn_Menu_DisplayAll.Click += btn_Menu_DisplayAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AccountNumber, AccountTitle, Cnic, Balance, Column1, Column2 });
            dataGridView1.Location = new Point(55, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1193, 377);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AccountNumber
            // 
            AccountNumber.DataPropertyName = "accountNumber";
            AccountNumber.HeaderText = "Account Number";
            AccountNumber.Name = "AccountNumber";
            AccountNumber.Width = 200;
            // 
            // AccountTitle
            // 
            AccountTitle.DataPropertyName = "accountTitle";
            AccountTitle.HeaderText = "Account Title";
            AccountTitle.Name = "AccountTitle";
            AccountTitle.Width = 200;
            // 
            // Cnic
            // 
            Cnic.DataPropertyName = "cnic";
            Cnic.HeaderText = "Cnic";
            Cnic.Name = "Cnic";
            Cnic.Width = 200;
            // 
            // Balance
            // 
            Balance.DataPropertyName = "balance";
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.Width = 200;
            // 
            // Column1
            // 
            Column1.HeaderText = "Edit";
            Column1.Name = "Column1";
            Column1.Text = "Edit";
            Column1.UseColumnTextForButtonValue = true;
            Column1.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "Delete";
            Column2.Name = "Column2";
            Column2.Text = "Delete";
            Column2.UseColumnTextForButtonValue = true;
            Column2.Width = 175;
            // 
            // BtnAddRecord
            // 
            BtnAddRecord.Location = new Point(1131, 51);
            BtnAddRecord.Name = "BtnAddRecord";
            BtnAddRecord.Size = new Size(117, 48);
            BtnAddRecord.TabIndex = 4;
            BtnAddRecord.Text = "Add New";
            BtnAddRecord.UseVisualStyleBackColor = true;
            BtnAddRecord.Click += BtnAddRecord_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1131, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 47);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxAccNum
            // 
            textBoxAccNum.Location = new Point(102, 120);
            textBoxAccNum.Name = "textBoxAccNum";
            textBoxAccNum.Size = new Size(192, 23);
            textBoxAccNum.TabIndex = 8;
            // 
            // textBoxAccTitle
            // 
            textBoxAccTitle.Location = new Point(300, 120);
            textBoxAccTitle.Name = "textBoxAccTitle";
            textBoxAccTitle.Size = new Size(192, 23);
            textBoxAccTitle.TabIndex = 9;
            // 
            // textBoxAccCnic
            // 
            textBoxAccCnic.Location = new Point(498, 119);
            textBoxAccCnic.Name = "textBoxAccCnic";
            textBoxAccCnic.Size = new Size(192, 23);
            textBoxAccCnic.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 123);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 11;
            label1.Text = "Search By:";
            // 
            // textBoxFromValue
            // 
            textBoxFromValue.Location = new Point(795, 104);
            textBoxFromValue.Name = "textBoxFromValue";
            textBoxFromValue.Size = new Size(100, 23);
            textBoxFromValue.TabIndex = 12;
            // 
            // textBoxToValue
            // 
            textBoxToValue.Location = new Point(795, 129);
            textBoxToValue.Name = "textBoxToValue";
            textBoxToValue.Size = new Size(100, 23);
            textBoxToValue.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 112);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 14;
            label2.Text = "From: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 137);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 15;
            label3.Text = "To: ";
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vecteezy_white_background_with_blue_geometric_and_white_line_pattern_7677104_1;
            ClientSize = new Size(1298, 582);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxToValue);
            Controls.Add(textBoxFromValue);
            Controls.Add(label1);
            Controls.Add(textBoxAccCnic);
            Controls.Add(textBoxAccTitle);
            Controls.Add(textBoxAccNum);
            Controls.Add(btnSearch);
            Controls.Add(BtnAddRecord);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Menu_DisplayAll);
            Controls.Add(label_Display_All);
            Name = "DisplayForm";
            Text = "DisplayForm";
            Load += DisplayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Display_All;
        private Button btn_Menu_DisplayAll;
        private DataGridView dataGridView1;
        private Button BtnAddRecord;
        private Button btnSearch;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn AccountTitle;
        private DataGridViewTextBoxColumn Cnic;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
        private TextBox textBoxAccNum;
        private TextBox textBoxAccTitle;
        private TextBox textBoxAccCnic;
        private Label label1;
        private TextBox textBoxFromValue;
        private TextBox textBoxToValue;
        private Label label2;
        private Label label3;
    }
}