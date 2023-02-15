namespace Scout
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HtATextBox = new System.Windows.Forms.TextBox();
            this.A_azTextBox = new System.Windows.Forms.TextBox();
            this.HtETextBox = new System.Windows.Forms.TextBox();
            this.E_azTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AzimuthLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расстояние до союзника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Азимут союзника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Расстояние до цели:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Азимут цели:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Высота наблюдателя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Расстояние до цели:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Азимут цели:";
            // 
            // HtATextBox
            // 
            this.HtATextBox.Location = new System.Drawing.Point(229, 21);
            this.HtATextBox.Name = "HtATextBox";
            this.HtATextBox.Size = new System.Drawing.Size(60, 20);
            this.HtATextBox.TabIndex = 8;
            this.HtATextBox.Text = "0";
            // 
            // A_azTextBox
            // 
            this.A_azTextBox.Location = new System.Drawing.Point(229, 47);
            this.A_azTextBox.Name = "A_azTextBox";
            this.A_azTextBox.Size = new System.Drawing.Size(60, 20);
            this.A_azTextBox.TabIndex = 9;
            this.A_azTextBox.Text = "0";
            // 
            // HtETextBox
            // 
            this.HtETextBox.Location = new System.Drawing.Point(229, 73);
            this.HtETextBox.Name = "HtETextBox";
            this.HtETextBox.Size = new System.Drawing.Size(60, 20);
            this.HtETextBox.TabIndex = 10;
            this.HtETextBox.Text = "0";
            // 
            // E_azTextBox
            // 
            this.E_azTextBox.Location = new System.Drawing.Point(229, 99);
            this.E_azTextBox.Name = "E_azTextBox";
            this.E_azTextBox.Size = new System.Drawing.Size(60, 20);
            this.E_azTextBox.TabIndex = 11;
            this.E_azTextBox.Text = "0";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(229, 125);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(60, 20);
            this.HeightTextBox.TabIndex = 12;
            this.HeightTextBox.Text = "0";
            // 
            // AzimuthLabel
            // 
            this.AzimuthLabel.AutoSize = true;
            this.AzimuthLabel.Location = new System.Drawing.Point(195, 252);
            this.AzimuthLabel.Name = "AzimuthLabel";
            this.AzimuthLabel.Size = new System.Drawing.Size(13, 13);
            this.AzimuthLabel.TabIndex = 14;
            this.AzimuthLabel.Text = "0";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(195, 229);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(13, 13);
            this.DistanceLabel.TabIndex = 13;
            this.DistanceLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 284);
            this.Controls.Add(this.AzimuthLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.E_azTextBox);
            this.Controls.Add(this.HtETextBox);
            this.Controls.Add(this.A_azTextBox);
            this.Controls.Add(this.HtATextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HtATextBox;
        private System.Windows.Forms.TextBox A_azTextBox;
        private System.Windows.Forms.TextBox HtETextBox;
        private System.Windows.Forms.TextBox E_azTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label AzimuthLabel;
        private System.Windows.Forms.Label DistanceLabel;
    }
}

