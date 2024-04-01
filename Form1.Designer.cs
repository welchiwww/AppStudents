namespace AppStudents_DB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonView = new System.Windows.Forms.RadioButton();
            this.buttonChangeRow = new System.Windows.Forms.Button();
            this.buttonProcedureAbsentStudents = new System.Windows.Forms.Button();
            this.buttonProcedureFailedStudents = new System.Windows.Forms.Button();
            this.buttonEnableTrigger = new System.Windows.Forms.Button();
            this.buttonDisableTrigger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(12, 247);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 1;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(12, 228);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(111, 16);
            this.labelSelect.TabIndex = 2;
            this.labelSelect.Text = "Выбор таблицы:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(353, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Location = new System.Drawing.Point(353, 352);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(141, 23);
            this.buttonAddRow.TabIndex = 13;
            this.buttonAddRow.Text = "Добавить строку";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(353, 381);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить строку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(24, 277);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(129, 17);
            this.radioButtonEdit.TabIndex = 15;
            this.radioButtonEdit.Text = "Изменение таблицы";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.CheckedChanged += new System.EventHandler(this.radioButtonEdit_CheckedChanged);
            // 
            // radioButtonView
            // 
            this.radioButtonView.AutoSize = true;
            this.radioButtonView.Checked = true;
            this.radioButtonView.Location = new System.Drawing.Point(24, 298);
            this.radioButtonView.Name = "radioButtonView";
            this.radioButtonView.Size = new System.Drawing.Size(122, 17);
            this.radioButtonView.TabIndex = 16;
            this.radioButtonView.TabStop = true;
            this.radioButtonView.Text = "Просмотр таблицы";
            this.radioButtonView.UseVisualStyleBackColor = true;
            this.radioButtonView.CheckedChanged += new System.EventHandler(this.radioButtonView_CheckedChanged);
            // 
            // buttonChangeRow
            // 
            this.buttonChangeRow.Location = new System.Drawing.Point(353, 410);
            this.buttonChangeRow.Name = "buttonChangeRow";
            this.buttonChangeRow.Size = new System.Drawing.Size(141, 23);
            this.buttonChangeRow.TabIndex = 17;
            this.buttonChangeRow.Text = "Изменить строку";
            this.buttonChangeRow.UseVisualStyleBackColor = true;
            this.buttonChangeRow.Click += new System.EventHandler(this.buttonChangeRow_Click);
            // 
            // buttonProcedureAbsentStudents
            // 
            this.buttonProcedureAbsentStudents.Location = new System.Drawing.Point(542, 224);
            this.buttonProcedureAbsentStudents.Name = "buttonProcedureAbsentStudents";
            this.buttonProcedureAbsentStudents.Size = new System.Drawing.Size(106, 54);
            this.buttonProcedureAbsentStudents.TabIndex = 18;
            this.buttonProcedureAbsentStudents.Text = "Поиск студентов отсутствующих на занятиях";
            this.buttonProcedureAbsentStudents.UseVisualStyleBackColor = true;
            this.buttonProcedureAbsentStudents.Click += new System.EventHandler(this.buttonProcedureAbsentStudents_Click);
            // 
            // buttonProcedureFailedStudents
            // 
            this.buttonProcedureFailedStudents.Location = new System.Drawing.Point(668, 224);
            this.buttonProcedureFailedStudents.Name = "buttonProcedureFailedStudents";
            this.buttonProcedureFailedStudents.Size = new System.Drawing.Size(106, 53);
            this.buttonProcedureFailedStudents.TabIndex = 19;
            this.buttonProcedureFailedStudents.Text = "Поиск студентов не сдавших экзамен";
            this.buttonProcedureFailedStudents.UseVisualStyleBackColor = true;
            this.buttonProcedureFailedStudents.Click += new System.EventHandler(this.buttonProcedureFailedStudents_Click);
            // 
            // buttonEnableTrigger
            // 
            this.buttonEnableTrigger.Location = new System.Drawing.Point(542, 284);
            this.buttonEnableTrigger.Name = "buttonEnableTrigger";
            this.buttonEnableTrigger.Size = new System.Drawing.Size(232, 58);
            this.buttonEnableTrigger.TabIndex = 20;
            this.buttonEnableTrigger.Text = "Включения триггера изменения даты редактирования в таблице PersonalInfo";
            this.buttonEnableTrigger.UseVisualStyleBackColor = true;
            this.buttonEnableTrigger.Click += new System.EventHandler(this.buttonEnableTrigger_Click);
            // 
            // buttonDisableTrigger
            // 
            this.buttonDisableTrigger.Location = new System.Drawing.Point(542, 348);
            this.buttonDisableTrigger.Name = "buttonDisableTrigger";
            this.buttonDisableTrigger.Size = new System.Drawing.Size(232, 58);
            this.buttonDisableTrigger.TabIndex = 21;
            this.buttonDisableTrigger.Text = "Отлючение триггера изменения даты редактирования в таблице PersonalInfo";
            this.buttonDisableTrigger.UseVisualStyleBackColor = true;
            this.buttonDisableTrigger.Click += new System.EventHandler(this.buttonDisableTrigger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisableTrigger);
            this.Controls.Add(this.buttonEnableTrigger);
            this.Controls.Add(this.buttonProcedureFailedStudents);
            this.Controls.Add(this.buttonProcedureAbsentStudents);
            this.Controls.Add(this.buttonChangeRow);
            this.Controls.Add(this.radioButtonView);
            this.Controls.Add(this.radioButtonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Приложение для работы с БД личные данные студентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonView;
        private System.Windows.Forms.Button buttonChangeRow;
        private System.Windows.Forms.Button buttonProcedureAbsentStudents;
        private System.Windows.Forms.Button buttonProcedureFailedStudents;
        private System.Windows.Forms.Button buttonEnableTrigger;
        private System.Windows.Forms.Button buttonDisableTrigger;
    }
}

