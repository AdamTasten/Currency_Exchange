namespace UI
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.exchangeCurrency = new System.Windows.Forms.Button();
            this.showHistory = new System.Windows.Forms.Button();
            this.setLimits = new System.Windows.Forms.Button();
            this.setRateOfExchange = new System.Windows.Forms.Button();
            this.setNextDay = new System.Windows.Forms.Button();
            this.dateField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterAdmin = new System.Windows.Forms.Button();
            this.exitAdmin = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exchangeCurrency
            // 
            this.exchangeCurrency.Location = new System.Drawing.Point(271, 96);
            this.exchangeCurrency.Name = "exchangeCurrency";
            this.exchangeCurrency.Size = new System.Drawing.Size(267, 47);
            this.exchangeCurrency.TabIndex = 0;
            this.exchangeCurrency.Text = "Обмен валюты";
            this.exchangeCurrency.UseVisualStyleBackColor = true;
            this.exchangeCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // showHistory
            // 
            this.showHistory.Location = new System.Drawing.Point(271, 162);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(267, 47);
            this.showHistory.TabIndex = 1;
            this.showHistory.Text = "История операций";
            this.showHistory.UseVisualStyleBackColor = true;
            this.showHistory.Click += new System.EventHandler(this.showHistory_Click);
            // 
            // setLimits
            // 
            this.setLimits.Location = new System.Drawing.Point(271, 295);
            this.setLimits.Name = "setLimits";
            this.setLimits.Size = new System.Drawing.Size(267, 47);
            this.setLimits.TabIndex = 2;
            this.setLimits.Text = "Установить лимиты";
            this.setLimits.UseVisualStyleBackColor = true;
            this.setLimits.Click += new System.EventHandler(this.setLimits_Click);
            // 
            // setRateOfExchange
            // 
            this.setRateOfExchange.Location = new System.Drawing.Point(271, 229);
            this.setRateOfExchange.Name = "setRateOfExchange";
            this.setRateOfExchange.Size = new System.Drawing.Size(267, 47);
            this.setRateOfExchange.TabIndex = 3;
            this.setRateOfExchange.Text = "Установить курсы обмена валют";
            this.setRateOfExchange.UseVisualStyleBackColor = true;
            this.setRateOfExchange.Click += new System.EventHandler(this.setRateOfExchange_Click);
            // 
            // setNextDay
            // 
            this.setNextDay.Location = new System.Drawing.Point(271, 364);
            this.setNextDay.Name = "setNextDay";
            this.setNextDay.Size = new System.Drawing.Size(267, 47);
            this.setNextDay.TabIndex = 4;
            this.setNextDay.Text = "Перейти на следующий день";
            this.setNextDay.UseVisualStyleBackColor = true;
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(329, 32);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(152, 22);
            this.dateField.TabIndex = 5;
            this.dateField.TextChanged += new System.EventHandler(this.dateField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(360, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ДД.ММ.ГГГГ";
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(67, 37);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(100, 22);
            this.passField.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Режим администратора";
            // 
            // enterAdmin
            // 
            this.enterAdmin.Location = new System.Drawing.Point(70, 82);
            this.enterAdmin.Name = "enterAdmin";
            this.enterAdmin.Size = new System.Drawing.Size(93, 26);
            this.enterAdmin.TabIndex = 17;
            this.enterAdmin.Text = "Включить";
            this.enterAdmin.UseVisualStyleBackColor = true;
            this.enterAdmin.Click += new System.EventHandler(this.enterAdmin_Click);
            // 
            // exitAdmin
            // 
            this.exitAdmin.Location = new System.Drawing.Point(38, 135);
            this.exitAdmin.Name = "exitAdmin";
            this.exitAdmin.Size = new System.Drawing.Size(151, 58);
            this.exitAdmin.TabIndex = 18;
            this.exitAdmin.Text = "Выйти из режима администратора";
            this.exitAdmin.UseVisualStyleBackColor = true;
            this.exitAdmin.Click += new System.EventHandler(this.exitAdmin_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(672, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 62);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exitAdmin);
            this.Controls.Add(this.enterAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.setNextDay);
            this.Controls.Add(this.setRateOfExchange);
            this.Controls.Add(this.setLimits);
            this.Controls.Add(this.showHistory);
            this.Controls.Add(this.exchangeCurrency);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exchangeCurrency;
        private System.Windows.Forms.Button showHistory;
        private System.Windows.Forms.Button setLimits;
        private System.Windows.Forms.Button setRateOfExchange;
        private System.Windows.Forms.Button setNextDay;
        private System.Windows.Forms.TextBox dateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterAdmin;
        private System.Windows.Forms.Button exitAdmin;
        private System.Windows.Forms.Button exitButton;
    }
}

