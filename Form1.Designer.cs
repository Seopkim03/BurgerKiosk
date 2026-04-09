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
            rdoBurger = new RadioButton();
            rdoBulgogi = new RadioButton();
            rdoChicken = new RadioButton();
            picBurger = new PictureBox();
            picBulgogi = new PictureBox();
            picChicken = new PictureBox();
            chkChips = new CheckBox();
            chkCoke = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpAdditional = new GroupBox();
            grpTotal = new GroupBox();
            lblTotal = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)picBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            grpMenu.SuspendLayout();
            grpAdditional.SuspendLayout();
            grpTotal.SuspendLayout();
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
            lblAppName.TabIndex = 2;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoBurger
            // 
            rdoBurger.AutoSize = true;
            rdoBurger.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBurger.Location = new Point(10, 36);
            rdoBurger.Name = "rdoBurger";
            rdoBurger.Size = new Size(122, 44);
            rdoBurger.TabIndex = 1;
            rdoBurger.TabStop = true;
            rdoBurger.Text = "햄버거";
            rdoBurger.UseVisualStyleBackColor = true;
            rdoBurger.CheckedChanged += rdoBurger_CheckedChanged;
            // 
            // rdoBulgogi
            // 
            rdoBulgogi.AutoSize = true;
            rdoBulgogi.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogi.Location = new Point(10, 136);
            rdoBulgogi.Name = "rdoBulgogi";
            rdoBulgogi.Size = new Size(180, 44);
            rdoBulgogi.TabIndex = 2;
            rdoBulgogi.TabStop = true;
            rdoBulgogi.Text = "불고기버거";
            rdoBulgogi.UseVisualStyleBackColor = true;
            rdoBulgogi.CheckedChanged += rdoBulgogi_CheckedChanged;
            // 
            // rdoChicken
            // 
            rdoChicken.AutoSize = true;
            rdoChicken.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChicken.Location = new Point(10, 240);
            rdoChicken.Name = "rdoChicken";
            rdoChicken.Size = new Size(151, 44);
            rdoChicken.TabIndex = 3;
            rdoChicken.TabStop = true;
            rdoChicken.Text = "치킨버거";
            rdoChicken.UseVisualStyleBackColor = true;
            rdoChicken.CheckedChanged += rdoChicken_CheckedChanged;
            // 
            // picBurger
            // 
            picBurger.Anchor = AnchorStyles.Top;
            picBurger.BackgroundImageLayout = ImageLayout.Center;
            picBurger.Image = Properties.Resources.ham;
            picBurger.Location = new Point(211, 38);
            picBurger.Name = "picBurger";
            picBurger.Size = new Size(155, 94);
            picBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger.TabIndex = 4;
            picBurger.TabStop = false;
            // 
            // picBulgogi
            // 
            picBulgogi.Image = Properties.Resources.bul;
            picBulgogi.Location = new Point(211, 136);
            picBulgogi.Name = "picBulgogi";
            picBulgogi.Size = new Size(155, 94);
            picBulgogi.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogi.TabIndex = 5;
            picBulgogi.TabStop = false;
            // 
            // picChicken
            // 
            picChicken.Image = Properties.Resources.chic;
            picChicken.Location = new Point(211, 240);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(155, 94);
            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picChicken.TabIndex = 6;
            picChicken.TabStop = false;
            // 
            // chkChips
            // 
            chkChips.AutoSize = true;
            chkChips.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkChips.Location = new Point(6, 34);
            chkChips.Name = "chkChips";
            chkChips.Size = new Size(129, 36);
            chkChips.TabIndex = 7;
            chkChips.Text = "감자튀김";
            chkChips.UseVisualStyleBackColor = true;
            chkChips.CheckedChanged += chkChips_CheckedChanged;
            // 
            // chkCoke
            // 
            chkCoke.AutoSize = true;
            chkCoke.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCoke.Location = new Point(6, 96);
            chkCoke.Name = "chkCoke";
            chkCoke.Size = new Size(81, 36);
            chkCoke.TabIndex = 8;
            chkCoke.Text = "콜라";
            chkCoke.UseVisualStyleBackColor = true;
            chkCoke.CheckedChanged += chkCoke_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(6, 157);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(137, 36);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(6, 216);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(137, 36);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChicken);
            grpMenu.Controls.Add(picBulgogi);
            grpMenu.Controls.Add(picBurger);
            grpMenu.Controls.Add(rdoChicken);
            grpMenu.Controls.Add(rdoBulgogi);
            grpMenu.Controls.Add(rdoBurger);
            grpMenu.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMenu.Location = new Point(21, 95);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(372, 354);
            grpMenu.TabIndex = 3;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpAdditional
            // 
            grpAdditional.Controls.Add(chkSauce);
            grpAdditional.Controls.Add(chkCheese);
            grpAdditional.Controls.Add(chkCoke);
            grpAdditional.Controls.Add(chkChips);
            grpAdditional.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpAdditional.Location = new Point(411, 95);
            grpAdditional.Name = "grpAdditional";
            grpAdditional.Size = new Size(146, 354);
            grpAdditional.TabIndex = 4;
            grpAdditional.TabStop = false;
            grpAdditional.Text = "추가 메뉴";
            // 
            // grpTotal
            // 
            grpTotal.Controls.Add(lblTotal);
            grpTotal.Controls.Add(lstOrder);
            grpTotal.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpTotal.Location = new Point(594, 95);
            grpTotal.Name = "grpTotal";
            grpTotal.Size = new Size(271, 319);
            grpTotal.TabIndex = 5;
            grpTotal.TabStop = false;
            grpTotal.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 283);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(135, 30);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.ItemHeight = 30;
            lstOrder.Location = new Point(3, 36);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(266, 244);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(594, 420);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(127, 46);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(738, 420);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(127, 46);
            btnReset.TabIndex = 1;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 499);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpTotal);
            Controls.Add(grpAdditional);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)picBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpAdditional.ResumeLayout(false);
            grpAdditional.PerformLayout();
            grpTotal.ResumeLayout(false);
            grpTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoBurger;
        private RadioButton rdoBulgogi;
        private RadioButton rdoChicken;
        private PictureBox picBurger;
        private PictureBox picBulgogi;
        private PictureBox picChicken;
        private CheckBox chkChips;
        private CheckBox chkCoke;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpAdditional;
        private GroupBox grpTotal;
        private Label lblTotal;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
    }
}
