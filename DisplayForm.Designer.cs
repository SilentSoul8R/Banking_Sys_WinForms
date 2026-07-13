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
            listBox_DisplayALL = new ListBox();
            BtnAddRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_Display_All
            // 
            label_Display_All.AutoSize = true;
            label_Display_All.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Display_All.Location = new Point(157, 50);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(694, 319);
            dataGridView1.TabIndex = 3;
            // 
            // listBox_DisplayALL
            // 
            listBox_DisplayALL.FormattingEnabled = true;
            listBox_DisplayALL.ItemHeight = 15;
            listBox_DisplayALL.Location = new Point(0, 446);
            listBox_DisplayALL.Name = "listBox_DisplayALL";
            listBox_DisplayALL.Size = new Size(10, 4);
            listBox_DisplayALL.TabIndex = 2;
            listBox_DisplayALL.Click += listBox_DisplayALL_SelectedIndexChanged;
            listBox_DisplayALL.SelectedIndexChanged += listBox_DisplayALL_SelectedIndexChanged;
            // 
            // BtnAddRecord
            // 
            BtnAddRecord.Location = new Point(692, 48);
            BtnAddRecord.Name = "BtnAddRecord";
            BtnAddRecord.Size = new Size(85, 30);
            BtnAddRecord.TabIndex = 4;
            BtnAddRecord.Text = "Add New";
            BtnAddRecord.UseVisualStyleBackColor = true;
            BtnAddRecord.Click += BtnAddRecord_Click;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAddRecord);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Menu_DisplayAll);
            Controls.Add(label_Display_All);
            Controls.Add(listBox_DisplayALL);
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
        private ListBox listBox_DisplayALL;
        private Button BtnAddRecord;
    }
}