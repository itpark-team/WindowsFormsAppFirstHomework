
namespace WindowsFormsAppFirstHomework
{
    partial class FormMain
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
            this.dataGridViewPhoneNumbers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPhoneNumbersFromTxtFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddPhoneNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhoneNumbers
            // 
            this.dataGridViewPhoneNumbers.AllowUserToAddRows = false;
            this.dataGridViewPhoneNumbers.AllowUserToDeleteRows = false;
            this.dataGridViewPhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewPhoneNumbers.Location = new System.Drawing.Point(16, 16);
            this.dataGridViewPhoneNumbers.Name = "dataGridViewPhoneNumbers";
            this.dataGridViewPhoneNumbers.ReadOnly = true;
            this.dataGridViewPhoneNumbers.Size = new System.Drawing.Size(672, 280);
            this.dataGridViewPhoneNumbers.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Инфо";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Степень важности";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // buttonPhoneNumbersFromTxtFile
            // 
            this.buttonPhoneNumbersFromTxtFile.Location = new System.Drawing.Point(16, 312);
            this.buttonPhoneNumbersFromTxtFile.Name = "buttonPhoneNumbersFromTxtFile";
            this.buttonPhoneNumbersFromTxtFile.Size = new System.Drawing.Size(304, 23);
            this.buttonPhoneNumbersFromTxtFile.TabIndex = 1;
            this.buttonPhoneNumbersFromTxtFile.Text = "Загрузить список телефонов из txt файла";
            this.buttonPhoneNumbersFromTxtFile.UseVisualStyleBackColor = true;
            this.buttonPhoneNumbersFromTxtFile.Click += new System.EventHandler(this.buttonPhoneNumbersFromTxtFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "номер телефона";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(24, 424);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 424);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "имя контакта";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(248, 424);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(128, 20);
            this.textBoxInfo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "информацию о контакте";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(384, 424);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(128, 20);
            this.textBoxGrade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(384, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 80);
            this.label4.TabIndex = 8;
            this.label4.Text = "Важность контакта\r\nкем является контакт\r\n0 - коллега,\r\n1 - друг,\r\n2 - родственник" +
    ",\r\n3 - важный контакт: ";
            // 
            // buttonAddPhoneNumber
            // 
            this.buttonAddPhoneNumber.Location = new System.Drawing.Point(520, 424);
            this.buttonAddPhoneNumber.Name = "buttonAddPhoneNumber";
            this.buttonAddPhoneNumber.Size = new System.Drawing.Size(152, 23);
            this.buttonAddPhoneNumber.TabIndex = 10;
            this.buttonAddPhoneNumber.Text = "Добавить номер";
            this.buttonAddPhoneNumber.UseVisualStyleBackColor = true;
            this.buttonAddPhoneNumber.Click += new System.EventHandler(this.buttonAddPhoneNumber_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 598);
            this.Controls.Add(this.buttonAddPhoneNumber);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPhoneNumbersFromTxtFile);
            this.Controls.Add(this.dataGridViewPhoneNumbers);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhoneNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonPhoneNumbersFromTxtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddPhoneNumber;
    }
}

