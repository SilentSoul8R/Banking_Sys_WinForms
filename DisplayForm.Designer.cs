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
            listBox_DisplayALL = new ListBox();
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
            btn_Menu_DisplayAll.Text = "Menu";
            btn_Menu_DisplayAll.UseVisualStyleBackColor = true;
            btn_Menu_DisplayAll.Click += btn_Menu_DisplayAll_Click;
            // 
            // listBox_DisplayALL
            // 
            listBox_DisplayALL.FormattingEnabled = true;
            listBox_DisplayALL.ItemHeight = 15;
            listBox_DisplayALL.Location = new Point(230, 99);
            listBox_DisplayALL.Name = "listBox_DisplayALL";
            listBox_DisplayALL.Size = new Size(361, 319);
            listBox_DisplayALL.TabIndex = 2;
            listBox_DisplayALL.Click += listBox_DisplayALL_SelectedIndexChanged;
            listBox_DisplayALL.SelectedIndexChanged += listBox_DisplayALL_SelectedIndexChanged;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_DisplayALL);
            Controls.Add(btn_Menu_DisplayAll);
            Controls.Add(label_Display_All);
            Name = "DisplayForm";
            Text = "DisplayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Display_All;
        private Button btn_Menu_DisplayAll;
        private ListBox listBox_DisplayALL;
    }
}