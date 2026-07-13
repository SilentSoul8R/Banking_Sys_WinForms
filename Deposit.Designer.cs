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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCreateAccYes = new Button();
            SuspendLayout();
            // 
            // MenuButton
            // 
            MenuButton.Location = new Point(12, 12);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(75, 23);
            MenuButton.TabIndex = 0;
            MenuButton.Text = "Menu";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 125);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the Account number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 252);
            label2.Name = "label2";
            label2.Size = new Size(286, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the amount you want to deposit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnCreateAccYes
            // 
            btnCreateAccYes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccYes.Location = new Point(312, 359);
            btnCreateAccYes.Name = "btnCreateAccYes";
            btnCreateAccYes.Size = new Size(168, 60);
            btnCreateAccYes.TabIndex = 5;
            btnCreateAccYes.Text = "Confirm";
            btnCreateAccYes.UseVisualStyleBackColor = true;
            btnCreateAccYes.Click += btnCreateAccYes_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__1_;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateAccYes);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MenuButton);
            Name = "Deposit";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuButton;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCreateAccYes;
    }
}