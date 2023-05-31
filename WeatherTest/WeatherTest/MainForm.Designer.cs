namespace WeatherTest
{
    partial class MainForm
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
            this.changeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.windLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.weatherPanel = new System.Windows.Forms.Panel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeButton.FlatAppearance.BorderSize = 0;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(537, 111);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(150, 41);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(145)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.windLabel);
            this.groupBox1.Controls.Add(this.temperatureLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.mainLabel);
            this.groupBox1.Controls.Add(this.weatherPanel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windLabel.Location = new System.Drawing.Point(200, 159);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(0, 22);
            this.windLabel.TabIndex = 5;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureLabel.Location = new System.Drawing.Point(200, 114);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(0, 22);
            this.temperatureLabel.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(200, 74);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 22);
            this.descriptionLabel.TabIndex = 3;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(200, 30);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(0, 22);
            this.mainLabel.TabIndex = 1;
            // 
            // weatherPanel
            // 
            this.weatherPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weatherPanel.Location = new System.Drawing.Point(18, 33);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(150, 150);
            this.weatherPanel.TabIndex = 0;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(204, 111);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(228, 41);
            this.cityTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherTest.Properties.Resources.sun;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.backPanel.Controls.Add(this.exitLabel);
            this.backPanel.Controls.Add(this.cityTextBox);
            this.backPanel.Controls.Add(this.changeButton);
            this.backPanel.Controls.Add(this.pictureBox1);
            this.backPanel.Controls.Add(this.infoLabel);
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(700, 450);
            this.backPanel.TabIndex = 5;
            this.backPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseDown);
            this.backPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backPanel_MouseMove);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.Location = new System.Drawing.Point(671, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(29, 33);
            this.exitLabel.TabIndex = 5;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(199, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(488, 57);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Please choose some sity and I`ll give you information about weather forecast:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel weatherPanel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}

