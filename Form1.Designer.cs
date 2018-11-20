namespace MP4_to_MP3_Converter
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.videoPathBox = new MetroFramework.Controls.MetroTextBox();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.savePathBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.aboutLabel = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Location = new System.Drawing.Point(10, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(498, 191);
            this.tabControl.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnConvert);
            this.metroTabPage1.Controls.Add(this.btnSave);
            this.metroTabPage1.Controls.Add(this.savePathBox);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.btnOpen);
            this.metroTabPage1.Controls.Add(this.videoPathBox);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(490, 152);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Convert";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.aboutLabel);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(490, 152);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "About";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Videos path:";
            // 
            // videoPathBox
            // 
            this.videoPathBox.Location = new System.Drawing.Point(89, 15);
            this.videoPathBox.Name = "videoPathBox";
            this.videoPathBox.Size = new System.Drawing.Size(297, 23);
            this.videoPathBox.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(392, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // savePathBox
            // 
            this.savePathBox.Location = new System.Drawing.Point(89, 50);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.Size = new System.Drawing.Size(297, 23);
            this.savePathBox.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Save to:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(145, 94);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(215, 29);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(171, 25);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(146, 95);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "MP4 to MP3 Converter\r\nVersion 1.0.0\r\n\r\n© 2018 Vladislav\r\n";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 271);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "MP4 to MP3 Converter";
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnConvert;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox savePathBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroTextBox videoPathBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel aboutLabel;
    }
}

