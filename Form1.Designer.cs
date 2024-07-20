namespace MDKObjects
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReport1 = new System.Windows.Forms.Button();
            this.textBoxReport1FileName = new System.Windows.Forms.TextBox();
            this.textBoxReport2FileName = new System.Windows.Forms.TextBox();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заполнить МКД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReport1
            // 
            this.buttonReport1.Location = new System.Drawing.Point(548, 193);
            this.buttonReport1.Name = "buttonReport1";
            this.buttonReport1.Size = new System.Drawing.Size(225, 59);
            this.buttonReport1.TabIndex = 1;
            this.buttonReport1.Text = "Сформировать ежемесячный отчёт";
            this.buttonReport1.UseVisualStyleBackColor = true;
            this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
            // 
            // textBoxReport1FileName
            // 
            this.textBoxReport1FileName.Location = new System.Drawing.Point(386, 212);
            this.textBoxReport1FileName.Name = "textBoxReport1FileName";
            this.textBoxReport1FileName.Size = new System.Drawing.Size(138, 23);
            this.textBoxReport1FileName.TabIndex = 2;
            this.textBoxReport1FileName.Text = "Ежемесячный отчёт";
            // 
            // textBoxReport2FileName
            // 
            this.textBoxReport2FileName.Location = new System.Drawing.Point(386, 325);
            this.textBoxReport2FileName.Name = "textBoxReport2FileName";
            this.textBoxReport2FileName.Size = new System.Drawing.Size(138, 23);
            this.textBoxReport2FileName.TabIndex = 3;
            this.textBoxReport2FileName.Text = "Перечень всех МКД";
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(548, 306);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(225, 59);
            this.buttonReport2.TabIndex = 4;
            this.buttonReport2.Text = "Сформировать перечень всех МКД";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название файла:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReport2);
            this.Controls.Add(this.textBoxReport2FileName);
            this.Controls.Add(this.textBoxReport1FileName);
            this.Controls.Add(this.buttonReport1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button buttonReport1;
        private TextBox textBoxReport1FileName;
        private TextBox textBoxReport2FileName;
        private Button buttonReport2;
        private Label label1;
        private Label label2;
    }
}