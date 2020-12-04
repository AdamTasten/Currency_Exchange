namespace UI
{
    partial class CurrencyExchange
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
            this.toBuyRB = new System.Windows.Forms.RadioButton();
            this.toSellRB = new System.Windows.Forms.RadioButton();
            this.eurRB = new System.Windows.Forms.RadioButton();
            this.usdRB = new System.Windows.Forms.RadioButton();
            this.rubRB = new System.Windows.Forms.RadioButton();
            this.clientName = new System.Windows.Forms.TextBox();
            this.cashierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.givenValue = new System.Windows.Forms.TextBox();
            this.gotValue = new System.Windows.Forms.TextBox();
            this.toExchangeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateBox = new System.Windows.Forms.ListBox();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.userID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBuyRB
            // 
            this.toBuyRB.AutoSize = true;
            this.toBuyRB.Checked = true;
            this.toBuyRB.Location = new System.Drawing.Point(39, 15);
            this.toBuyRB.Name = "toBuyRB";
            this.toBuyRB.Size = new System.Drawing.Size(84, 21);
            this.toBuyRB.TabIndex = 0;
            this.toBuyRB.TabStop = true;
            this.toBuyRB.Text = "Покупка";
            this.toBuyRB.UseVisualStyleBackColor = true;
            this.toBuyRB.CheckedChanged += new System.EventHandler(this.toBuyRB_CheckedChanged);
            // 
            // toSellRB
            // 
            this.toSellRB.AutoSize = true;
            this.toSellRB.Location = new System.Drawing.Point(184, 15);
            this.toSellRB.Name = "toSellRB";
            this.toSellRB.Size = new System.Drawing.Size(88, 21);
            this.toSellRB.TabIndex = 1;
            this.toSellRB.Text = "Продажа";
            this.toSellRB.UseVisualStyleBackColor = true;
            this.toSellRB.CheckedChanged += new System.EventHandler(this.toSellRB_CheckedChanged);
            // 
            // eurRB
            // 
            this.eurRB.AutoSize = true;
            this.eurRB.Location = new System.Drawing.Point(115, 15);
            this.eurRB.Name = "eurRB";
            this.eurRB.Size = new System.Drawing.Size(58, 21);
            this.eurRB.TabIndex = 2;
            this.eurRB.TabStop = true;
            this.eurRB.Text = "EUR";
            this.eurRB.UseVisualStyleBackColor = true;
            this.eurRB.CheckedChanged += new System.EventHandler(this.eurRB_CheckedChanged);
            // 
            // usdRB
            // 
            this.usdRB.AutoSize = true;
            this.usdRB.Checked = true;
            this.usdRB.Location = new System.Drawing.Point(23, 15);
            this.usdRB.Name = "usdRB";
            this.usdRB.Size = new System.Drawing.Size(58, 21);
            this.usdRB.TabIndex = 3;
            this.usdRB.TabStop = true;
            this.usdRB.Text = "USD";
            this.usdRB.UseVisualStyleBackColor = true;
            this.usdRB.CheckedChanged += new System.EventHandler(this.usdRB_CheckedChanged);
            // 
            // rubRB
            // 
            this.rubRB.AutoSize = true;
            this.rubRB.Location = new System.Drawing.Point(204, 15);
            this.rubRB.Name = "rubRB";
            this.rubRB.Size = new System.Drawing.Size(58, 21);
            this.rubRB.TabIndex = 4;
            this.rubRB.TabStop = true;
            this.rubRB.Text = "RUB";
            this.rubRB.UseVisualStyleBackColor = true;
            this.rubRB.CheckedChanged += new System.EventHandler(this.rubRB_CheckedChanged);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(266, 173);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(294, 22);
            this.clientName.TabIndex = 5;
            this.clientName.Text = "Здещиц Адам Александрович";
            this.clientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cashierName
            // 
            this.cashierName.Location = new System.Drawing.Point(266, 226);
            this.cashierName.Name = "cashierName";
            this.cashierName.Size = new System.Drawing.Size(294, 22);
            this.cashierName.TabIndex = 6;
            this.cashierName.Text = "Вортынько Мария Ивановна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО кассира";
            // 
            // givenValue
            // 
            this.givenValue.Location = new System.Drawing.Point(281, 333);
            this.givenValue.Name = "givenValue";
            this.givenValue.Size = new System.Drawing.Size(100, 22);
            this.givenValue.TabIndex = 9;
            this.givenValue.TextChanged += new System.EventHandler(this.givenValue_TextChanged);
            // 
            // gotValue
            // 
            this.gotValue.Location = new System.Drawing.Point(444, 333);
            this.gotValue.Name = "gotValue";
            this.gotValue.Size = new System.Drawing.Size(100, 22);
            this.gotValue.TabIndex = 10;
            this.gotValue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // toExchangeButton
            // 
            this.toExchangeButton.Location = new System.Drawing.Point(298, 414);
            this.toExchangeButton.Name = "toExchangeButton";
            this.toExchangeButton.Size = new System.Drawing.Size(222, 36);
            this.toExchangeButton.TabIndex = 11;
            this.toExchangeButton.Text = "Обмен валюты";
            this.toExchangeButton.UseVisualStyleBackColor = true;
            this.toExchangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отдаваемая валюта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Получаемая валюта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(307, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Обмен валюты";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(12, 12);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(206, 65);
            this.mainMenuButton.TabIndex = 15;
            this.mainMenuButton.Text = "Вернуться на главную страницу";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(126, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toBuyRB);
            this.groupBox1.Controls.Add(this.toSellRB);
            this.groupBox1.Location = new System.Drawing.Point(258, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 48);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eurRB);
            this.groupBox2.Controls.Add(this.usdRB);
            this.groupBox2.Controls.Add(this.rubRB);
            this.groupBox2.Location = new System.Drawing.Point(258, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 42);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.ItemHeight = 16;
            this.dateBox.Location = new System.Drawing.Point(576, 41);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(212, 36);
            this.dateBox.TabIndex = 19;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(645, 83);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(118, 62);
            this.nextDayButton.TabIndex = 20;
            this.nextDayButton.Text = "Перейти на новый день";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(266, 275);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(294, 22);
            this.userID.TabIndex = 21;
            this.userID.Text = "User1001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Идентификатор пользователя";
            // 
            // CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toExchangeButton);
            this.Controls.Add(this.gotValue);
            this.Controls.Add(this.givenValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashierName);
            this.Controls.Add(this.clientName);
            this.Name = "CurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обмен валюты";
            this.Load += new System.EventHandler(this.CurrencyExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton toBuyRB;
        private System.Windows.Forms.RadioButton toSellRB;
        private System.Windows.Forms.RadioButton eurRB;
        private System.Windows.Forms.RadioButton usdRB;
        private System.Windows.Forms.RadioButton rubRB;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox cashierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gotValue;
        private System.Windows.Forms.Button toExchangeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox dateBox;
        private System.Windows.Forms.Button nextDayButton;
        public System.Windows.Forms.TextBox givenValue;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label7;
    }
}