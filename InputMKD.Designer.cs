namespace MDKObjects
{
    partial class InputMKD
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
            this.radioButtonCurrent = new System.Windows.Forms.RadioButton();
            this.radioButtonSuspended = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameObject = new System.Windows.Forms.TextBox();
            this.groupBoxStateMKD = new System.Windows.Forms.GroupBox();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.groupBoxRequisites = new System.Windows.Forms.GroupBox();
            this.DateGivePermission = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContractNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateExtend = new System.Windows.Forms.DateTimePicker();
            this.DateExpiration = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPercantageReady = new System.Windows.Forms.GroupBox();
            this.LabelBuildingStage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBuildingStage = new System.Windows.Forms.TextBox();
            this.textBoxPercantage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxAdress = new System.Windows.Forms.GroupBox();
            this.textBoxHouseNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDeveloperData = new System.Windows.Forms.GroupBox();
            this.textBoxNameOrganization = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxSqareMKD = new System.Windows.Forms.GroupBox();
            this.textBoxSquareMKD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxNotes = new System.Windows.Forms.GroupBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.dataGridViewCurrent = new System.Windows.Forms.DataGridView();
            this.dataGridViewSuspended = new System.Windows.Forms.DataGridView();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxStateMKD.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxRequisites.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            this.groupBoxPercantageReady.SuspendLayout();
            this.groupBoxAdress.SuspendLayout();
            this.groupBoxDeveloperData.SuspendLayout();
            this.groupBoxSqareMKD.SuspendLayout();
            this.groupBoxNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspended)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonCurrent
            // 
            this.radioButtonCurrent.AutoSize = true;
            this.radioButtonCurrent.Location = new System.Drawing.Point(141, 21);
            this.radioButtonCurrent.Name = "radioButtonCurrent";
            this.radioButtonCurrent.Size = new System.Drawing.Size(102, 19);
            this.radioButtonCurrent.TabIndex = 0;
            this.radioButtonCurrent.Text = "Действующее";
            this.radioButtonCurrent.UseVisualStyleBackColor = true;
            this.radioButtonCurrent.CheckedChanged += new System.EventHandler(this.radioButtonCurrent_CheckedChanged);
            // 
            // radioButtonSuspended
            // 
            this.radioButtonSuspended.AutoSize = true;
            this.radioButtonSuspended.Checked = true;
            this.radioButtonSuspended.Location = new System.Drawing.Point(276, 21);
            this.radioButtonSuspended.Name = "radioButtonSuspended";
            this.radioButtonSuspended.Size = new System.Drawing.Size(132, 19);
            this.radioButtonSuspended.TabIndex = 1;
            this.radioButtonSuspended.TabStop = true;
            this.radioButtonSuspended.Text = "Приостановленное";
            this.radioButtonSuspended.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние МКД:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование объекта:";
            // 
            // textBoxNameObject
            // 
            this.textBoxNameObject.Location = new System.Drawing.Point(210, 22);
            this.textBoxNameObject.Name = "textBoxNameObject";
            this.textBoxNameObject.Size = new System.Drawing.Size(207, 23);
            this.textBoxNameObject.TabIndex = 4;
            // 
            // groupBoxStateMKD
            // 
            this.groupBoxStateMKD.Controls.Add(this.radioButtonSuspended);
            this.groupBoxStateMKD.Controls.Add(this.radioButtonCurrent);
            this.groupBoxStateMKD.Controls.Add(this.label1);
            this.groupBoxStateMKD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStateMKD.Name = "groupBoxStateMKD";
            this.groupBoxStateMKD.Size = new System.Drawing.Size(495, 58);
            this.groupBoxStateMKD.TabIndex = 5;
            this.groupBoxStateMKD.TabStop = false;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxNameObject);
            this.groupBoxName.Controls.Add(this.label2);
            this.groupBoxName.Location = new System.Drawing.Point(513, 12);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(423, 58);
            this.groupBoxName.TabIndex = 6;
            this.groupBoxName.TabStop = false;
            // 
            // groupBoxRequisites
            // 
            this.groupBoxRequisites.Controls.Add(this.DateGivePermission);
            this.groupBoxRequisites.Controls.Add(this.label4);
            this.groupBoxRequisites.Controls.Add(this.textBoxContractNumber);
            this.groupBoxRequisites.Controls.Add(this.label3);
            this.groupBoxRequisites.Location = new System.Drawing.Point(12, 88);
            this.groupBoxRequisites.Name = "groupBoxRequisites";
            this.groupBoxRequisites.Size = new System.Drawing.Size(495, 110);
            this.groupBoxRequisites.TabIndex = 7;
            this.groupBoxRequisites.TabStop = false;
            this.groupBoxRequisites.Text = "Реквизиты разрешения на строительство";
            // 
            // DateGivePermission
            // 
            this.DateGivePermission.Location = new System.Drawing.Point(276, 73);
            this.DateGivePermission.Name = "DateGivePermission";
            this.DateGivePermission.Size = new System.Drawing.Size(207, 23);
            this.DateGivePermission.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата выдачи разрешения на строительство:";
            // 
            // textBoxContractNumber
            // 
            this.textBoxContractNumber.Location = new System.Drawing.Point(276, 22);
            this.textBoxContractNumber.Name = "textBoxContractNumber";
            this.textBoxContractNumber.Size = new System.Drawing.Size(207, 23);
            this.textBoxContractNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер договора:";
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.label12);
            this.groupBoxDates.Controls.Add(this.checkBox1);
            this.groupBoxDates.Controls.Add(this.label5);
            this.groupBoxDates.Controls.Add(this.DateExtend);
            this.groupBoxDates.Controls.Add(this.DateExpiration);
            this.groupBoxDates.Location = new System.Drawing.Point(513, 88);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(423, 110);
            this.groupBoxDates.TabIndex = 8;
            this.groupBoxDates.TabStop = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 43);
            this.label12.TabIndex = 11;
            this.label12.Text = "Срок окончания действия разрешения на строительство:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(27, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Срок продления:";
            this.label5.Visible = false;
            // 
            // DateExtend
            // 
            this.DateExtend.Location = new System.Drawing.Point(234, 75);
            this.DateExtend.Name = "DateExtend";
            this.DateExtend.Size = new System.Drawing.Size(183, 23);
            this.DateExtend.TabIndex = 6;
            this.DateExtend.Visible = false;
            this.DateExtend.ValueChanged += new System.EventHandler(this.DateExtend_ValueChanged);
            // 
            // DateExpiration
            // 
            this.DateExpiration.Location = new System.Drawing.Point(234, 37);
            this.DateExpiration.Name = "DateExpiration";
            this.DateExpiration.Size = new System.Drawing.Size(183, 23);
            this.DateExpiration.TabIndex = 6;
            // 
            // groupBoxPercantageReady
            // 
            this.groupBoxPercantageReady.Controls.Add(this.LabelBuildingStage);
            this.groupBoxPercantageReady.Controls.Add(this.label13);
            this.groupBoxPercantageReady.Controls.Add(this.textBoxBuildingStage);
            this.groupBoxPercantageReady.Controls.Add(this.textBoxPercantage);
            this.groupBoxPercantageReady.Controls.Add(this.label6);
            this.groupBoxPercantageReady.Location = new System.Drawing.Point(513, 204);
            this.groupBoxPercantageReady.Name = "groupBoxPercantageReady";
            this.groupBoxPercantageReady.Size = new System.Drawing.Size(423, 147);
            this.groupBoxPercantageReady.TabIndex = 11;
            this.groupBoxPercantageReady.TabStop = false;
            // 
            // LabelBuildingStage
            // 
            this.LabelBuildingStage.Location = new System.Drawing.Point(15, 93);
            this.LabelBuildingStage.Name = "LabelBuildingStage";
            this.LabelBuildingStage.Size = new System.Drawing.Size(179, 40);
            this.LabelBuildingStage.TabIndex = 9;
            this.LabelBuildingStage.Text = "Описание этапа строительства:";
            this.LabelBuildingStage.Visible = false;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(15, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 32);
            this.label13.TabIndex = 8;
            this.label13.Text = "Ориентировочный процент готовности объекта:";
            // 
            // textBoxBuildingStage
            // 
            this.textBoxBuildingStage.Location = new System.Drawing.Point(200, 105);
            this.textBoxBuildingStage.Name = "textBoxBuildingStage";
            this.textBoxBuildingStage.Size = new System.Drawing.Size(207, 23);
            this.textBoxBuildingStage.TabIndex = 6;
            this.textBoxBuildingStage.Visible = false;
            this.textBoxBuildingStage.TextChanged += new System.EventHandler(this.textBoxBuildingStage_TextChanged);
            // 
            // textBoxPercantage
            // 
            this.textBoxPercantage.Location = new System.Drawing.Point(200, 43);
            this.textBoxPercantage.Name = "textBoxPercantage";
            this.textBoxPercantage.Size = new System.Drawing.Size(207, 23);
            this.textBoxPercantage.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 3;
            // 
            // groupBoxAdress
            // 
            this.groupBoxAdress.Controls.Add(this.textBoxHouseNumber);
            this.groupBoxAdress.Controls.Add(this.label9);
            this.groupBoxAdress.Controls.Add(this.textBoxStreet);
            this.groupBoxAdress.Controls.Add(this.label8);
            this.groupBoxAdress.Controls.Add(this.textBoxCountry);
            this.groupBoxAdress.Controls.Add(this.label7);
            this.groupBoxAdress.Location = new System.Drawing.Point(12, 204);
            this.groupBoxAdress.Name = "groupBoxAdress";
            this.groupBoxAdress.Size = new System.Drawing.Size(495, 147);
            this.groupBoxAdress.TabIndex = 10;
            this.groupBoxAdress.TabStop = false;
            this.groupBoxAdress.Text = "Адрес объекта";
            // 
            // textBoxHouseNumber
            // 
            this.textBoxHouseNumber.Location = new System.Drawing.Point(100, 110);
            this.textBoxHouseNumber.Name = "textBoxHouseNumber";
            this.textBoxHouseNumber.Size = new System.Drawing.Size(207, 23);
            this.textBoxHouseNumber.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Номер дома:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(100, 67);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(207, 23);
            this.textBoxStreet.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Улица:";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(100, 22);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(207, 23);
            this.textBoxCountry.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Город:";
            // 
            // groupBoxDeveloperData
            // 
            this.groupBoxDeveloperData.Controls.Add(this.textBoxNameOrganization);
            this.groupBoxDeveloperData.Controls.Add(this.label10);
            this.groupBoxDeveloperData.Location = new System.Drawing.Point(12, 357);
            this.groupBoxDeveloperData.Name = "groupBoxDeveloperData";
            this.groupBoxDeveloperData.Size = new System.Drawing.Size(495, 58);
            this.groupBoxDeveloperData.TabIndex = 13;
            this.groupBoxDeveloperData.TabStop = false;
            this.groupBoxDeveloperData.Text = "Данные застройщика";
            // 
            // textBoxNameOrganization
            // 
            this.textBoxNameOrganization.Location = new System.Drawing.Point(210, 22);
            this.textBoxNameOrganization.Name = "textBoxNameOrganization";
            this.textBoxNameOrganization.Size = new System.Drawing.Size(207, 23);
            this.textBoxNameOrganization.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Наименование организации:";
            // 
            // groupBoxSqareMKD
            // 
            this.groupBoxSqareMKD.Controls.Add(this.textBoxSquareMKD);
            this.groupBoxSqareMKD.Controls.Add(this.label11);
            this.groupBoxSqareMKD.Location = new System.Drawing.Point(513, 357);
            this.groupBoxSqareMKD.Name = "groupBoxSqareMKD";
            this.groupBoxSqareMKD.Size = new System.Drawing.Size(423, 58);
            this.groupBoxSqareMKD.TabIndex = 12;
            this.groupBoxSqareMKD.TabStop = false;
            // 
            // textBoxSquareMKD
            // 
            this.textBoxSquareMKD.Location = new System.Drawing.Point(210, 22);
            this.textBoxSquareMKD.Name = "textBoxSquareMKD";
            this.textBoxSquareMKD.Size = new System.Drawing.Size(207, 23);
            this.textBoxSquareMKD.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Общая площадь МКД:";
            // 
            // groupBoxNotes
            // 
            this.groupBoxNotes.Controls.Add(this.textBoxNotes);
            this.groupBoxNotes.Location = new System.Drawing.Point(12, 421);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Size = new System.Drawing.Size(924, 108);
            this.groupBoxNotes.TabIndex = 14;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "Примечания (не обязательно для заполнения)";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(15, 22);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(890, 68);
            this.textBoxNotes.TabIndex = 0;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(288, 535);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(170, 42);
            this.buttonAccept.TabIndex = 15;
            this.buttonAccept.Text = "Добавить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // dataGridViewCurrent
            // 
            this.dataGridViewCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrent.Location = new System.Drawing.Point(979, 21);
            this.dataGridViewCurrent.Name = "dataGridViewCurrent";
            this.dataGridViewCurrent.RowTemplate.Height = 25;
            this.dataGridViewCurrent.Size = new System.Drawing.Size(741, 290);
            this.dataGridViewCurrent.TabIndex = 16;
            this.dataGridViewCurrent.CurrentCellChanged += new System.EventHandler(this.dataGridViewCurrent_CurrentCellChanged);
            this.dataGridViewCurrent.SelectionChanged += new System.EventHandler(this.dataGridViewCurrent_SelectionChanged);
            // 
            // dataGridViewSuspended
            // 
            this.dataGridViewSuspended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuspended.Location = new System.Drawing.Point(979, 334);
            this.dataGridViewSuspended.Name = "dataGridViewSuspended";
            this.dataGridViewSuspended.RowTemplate.Height = 25;
            this.dataGridViewSuspended.Size = new System.Drawing.Size(741, 290);
            this.dataGridViewSuspended.TabIndex = 17;
            this.dataGridViewSuspended.CurrentCellChanged += new System.EventHandler(this.dataGridViewSuspended_CurrentCellChanged);
            this.dataGridViewSuspended.SelectionChanged += new System.EventHandler(this.dataGridViewSuspended_SelectionChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(489, 535);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(170, 42);
            this.buttonChange.TabIndex = 18;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(685, 535);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(170, 42);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(18, 546);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(237, 23);
            this.textBoxId.TabIndex = 20;
            this.textBoxId.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputMKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.dataGridViewSuspended);
            this.Controls.Add(this.dataGridViewCurrent);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxNotes);
            this.Controls.Add(this.groupBoxDeveloperData);
            this.Controls.Add(this.groupBoxSqareMKD);
            this.Controls.Add(this.groupBoxPercantageReady);
            this.Controls.Add(this.groupBoxAdress);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.groupBoxRequisites);
            this.Controls.Add(this.groupBoxName);
            this.Controls.Add(this.groupBoxStateMKD);
            this.Name = "InputMKD";
            this.Text = "Заполнение МКД";
            this.Load += new System.EventHandler(this.InputMKD_Load);
            this.groupBoxStateMKD.ResumeLayout(false);
            this.groupBoxStateMKD.PerformLayout();
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxRequisites.ResumeLayout(false);
            this.groupBoxRequisites.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBoxPercantageReady.ResumeLayout(false);
            this.groupBoxPercantageReady.PerformLayout();
            this.groupBoxAdress.ResumeLayout(false);
            this.groupBoxAdress.PerformLayout();
            this.groupBoxDeveloperData.ResumeLayout(false);
            this.groupBoxDeveloperData.PerformLayout();
            this.groupBoxSqareMKD.ResumeLayout(false);
            this.groupBoxSqareMKD.PerformLayout();
            this.groupBoxNotes.ResumeLayout(false);
            this.groupBoxNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspended)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonCurrent;
        private RadioButton radioButtonSuspended;
        private Label label1;
        private Label label2;
        private TextBox textBoxNameObject;
        private GroupBox groupBoxStateMKD;
        private GroupBox groupBoxName;
        private GroupBox groupBoxRequisites;
        private TextBox textBoxContractNumber;
        private Label label3;
        private Label label4;
        private DateTimePicker DateGivePermission;
        private GroupBox groupBoxDates;
        private DateTimePicker DateExpiration;
        private Label label5;
        private DateTimePicker DateExtend;
        private GroupBox groupBoxPercantageReady;
        private TextBox textBoxPercantage;
        private Label label6;
        private GroupBox groupBoxAdress;
        private TextBox textBoxHouseNumber;
        private Label label9;
        private TextBox textBoxStreet;
        private Label label8;
        private TextBox textBoxCountry;
        private Label label7;
        private GroupBox groupBoxDeveloperData;
        private TextBox textBoxNameOrganization;
        private Label label10;
        private GroupBox groupBoxSqareMKD;
        private TextBox textBoxSquareMKD;
        private Label label11;
        private GroupBox groupBoxNotes;
        private TextBox textBoxNotes;
        private Button buttonAccept;
        private TextBox textBoxBuildingStage;
        private CheckBox checkBox1;
        private Label label12;
        private Label label13;
        private Label LabelBuildingStage;
        private DataGridView dataGridViewCurrent;
        private DataGridView dataGridViewSuspended;
        private Button buttonChange;
        private Button buttonDelete;
        private TextBox textBoxId;
        private Button button1;
    }
}