namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            rdBurger = new RadioButton();
            rdBulgogi = new RadioButton();
            rdChicken = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Regular", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.FromArgb(255, 128, 0);
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(502, 83);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdBurger
            // 
            rdBurger.AutoSize = true;
            rdBurger.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdBurger.Location = new Point(7, 16);
            rdBurger.Name = "rdBurger";
            rdBurger.Size = new Size(122, 44);
            rdBurger.TabIndex = 1;
            rdBurger.TabStop = true;
            rdBurger.Text = "햄버거";
            rdBurger.UseVisualStyleBackColor = true;
            // 
            // rdBulgogi
            // 
            rdBulgogi.AutoSize = true;
            rdBulgogi.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdBulgogi.Location = new Point(7, 116);
            rdBulgogi.Name = "rdBulgogi";
            rdBulgogi.Size = new Size(180, 44);
            rdBulgogi.TabIndex = 2;
            rdBulgogi.TabStop = true;
            rdBulgogi.Text = "불고기버거";
            rdBulgogi.UseVisualStyleBackColor = true;
            // 
            // rdChicken
            // 
            rdChicken.AutoSize = true;
            rdChicken.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdChicken.Location = new Point(7, 220);
            rdChicken.Name = "rdChicken";
            rdChicken.Size = new Size(151, 44);
            rdChicken.TabIndex = 3;
            rdChicken.TabStop = true;
            rdChicken.Text = "치킨버거";
            rdChicken.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.ham;
            pictureBox1.Location = new Point(208, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bul;
            pictureBox2.Location = new Point(208, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chic;
            pictureBox3.Location = new Point(208, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            checkBox1.Location = new Point(430, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 36);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "감자튀김";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            checkBox2.Location = new Point(430, 173);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 36);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "콜라";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            checkBox3.Location = new Point(430, 234);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(137, 36);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "치즈 추가";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            checkBox4.Location = new Point(430, 293);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(137, 36);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "소스 추가";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rdChicken);
            groupBox1.Controls.Add(rdBulgogi);
            groupBox1.Controls.Add(rdBurger);
            groupBox1.Location = new Point(20, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 322);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdBurger;
        private RadioButton rdBulgogi;
        private RadioButton rdChicken;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox1;
    }
}
