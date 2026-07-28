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
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            Filters = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_Display_All
            // 
            label_Display_All.AutoSize = true;
            label_Display_All.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Display_All.Location = new Point(328, 9);
            label_Display_All.Name = "label_Display_All";
            label_Display_All.Size = new Size(501, 28);
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
            BtnAddRecord.Location = new Point(1163, 54);
            BtnAddRecord.Name = "BtnAddRecord";
            BtnAddRecord.Size = new Size(85, 30);
            BtnAddRecord.TabIndex = 4;
            BtnAddRecord.Text = "Add New";
            BtnAddRecord.UseVisualStyleBackColor = true;
            BtnAddRecord.Click += BtnAddRecord_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(55, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(609, 23);
            textBoxSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1173, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Filters
            // 
            Filters.Location = new Point(1173, 119);
            Filters.Name = "Filters";
            Filters.Size = new Size(75, 23);
            Filters.TabIndex = 7;
            Filters.Text = "Filters";
            Filters.UseVisualStyleBackColor = true;
            Filters.Click += Filters_Click;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vecteezy_white_background_with_blue_geometric_and_white_line_pattern_7677104_1;
            ClientSize = new Size(1298, 582);
            Controls.Add(Filters);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
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
        private TextBox textBoxSearch;
        private Button btnSearch;
        private Button Filters;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn AccountTitle;
        private DataGridViewTextBoxColumn Cnic;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}