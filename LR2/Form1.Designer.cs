
namespace ЛР2
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
            this.nametxt = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.semestrtxt = new System.Windows.Forms.Label();
            this.coursetxt = new System.Windows.Forms.Label();
            this.semestr = new System.Windows.Forms.NumericUpDown();
            this.spectxt = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.ComboBox();
            this.lecttxt = new System.Windows.Forms.Label();
            this.lectures = new System.Windows.Forms.TextBox();
            this.labtxt = new System.Windows.Forms.Label();
            this.labs = new System.Windows.Forms.TextBox();
            this.typeofcontroltxt = new System.Windows.Forms.Label();
            this.typeofcontrol = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.disciplines = new System.Windows.Forms.ListBox();
            this.course = new System.Windows.Forms.TrackBar();
            this.clear = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.TextBox();
            this.fullnametxt = new System.Windows.Forms.Label();
            this.audience = new System.Windows.Forms.TextBox();
            this.cabtxt = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.departmenttxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.semestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.nametxt.Location = new System.Drawing.Point(8, 9);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(190, 21);
            this.nametxt.TabIndex = 0;
            this.nametxt.Text = "Название дисциплины";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.name.Location = new System.Drawing.Point(12, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 29);
            this.name.TabIndex = 1;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // semestrtxt
            // 
            this.semestrtxt.AutoSize = true;
            this.semestrtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.semestrtxt.Location = new System.Drawing.Point(8, 71);
            this.semestrtxt.Name = "semestrtxt";
            this.semestrtxt.Size = new System.Drawing.Size(78, 21);
            this.semestrtxt.TabIndex = 2;
            this.semestrtxt.Text = "Семестр";
            // 
            // coursetxt
            // 
            this.coursetxt.AutoSize = true;
            this.coursetxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.coursetxt.Location = new System.Drawing.Point(11, 136);
            this.coursetxt.Name = "coursetxt";
            this.coursetxt.Size = new System.Drawing.Size(50, 21);
            this.coursetxt.TabIndex = 4;
            this.coursetxt.Text = "Курс";
            this.coursetxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // semestr
            // 
            this.semestr.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.semestr.Location = new System.Drawing.Point(12, 95);
            this.semestr.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.semestr.Name = "semestr";
            this.semestr.Size = new System.Drawing.Size(186, 29);
            this.semestr.TabIndex = 5;
            // 
            // spectxt
            // 
            this.spectxt.AutoSize = true;
            this.spectxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.spectxt.Location = new System.Drawing.Point(8, 211);
            this.spectxt.Name = "spectxt";
            this.spectxt.Size = new System.Drawing.Size(133, 21);
            this.spectxt.TabIndex = 7;
            this.spectxt.Text = "Специальность";
            // 
            // specialization
            // 
            this.specialization.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.specialization.FormattingEnabled = true;
            this.specialization.Items.AddRange(new object[] {
            "ПОИТ",
            "ИСиТ",
            "ПОИБМС",
            "ДЭиВИ"});
            this.specialization.Location = new System.Drawing.Point(12, 235);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(186, 29);
            this.specialization.TabIndex = 8;
            // 
            // lecttxt
            // 
            this.lecttxt.AutoSize = true;
            this.lecttxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lecttxt.Location = new System.Drawing.Point(8, 280);
            this.lecttxt.Name = "lecttxt";
            this.lecttxt.Size = new System.Drawing.Size(166, 21);
            this.lecttxt.TabIndex = 9;
            this.lecttxt.Text = "Количество лекций";
            // 
            // lectures
            // 
            this.lectures.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lectures.Location = new System.Drawing.Point(12, 304);
            this.lectures.Name = "lectures";
            this.lectures.Size = new System.Drawing.Size(186, 29);
            this.lectures.TabIndex = 10;
            this.lectures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labtxt
            // 
            this.labtxt.AutoSize = true;
            this.labtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labtxt.Location = new System.Drawing.Point(8, 346);
            this.labtxt.Name = "labtxt";
            this.labtxt.Size = new System.Drawing.Size(225, 21);
            this.labtxt.TabIndex = 11;
            this.labtxt.Text = "Количество лабораторных";
            // 
            // labs
            // 
            this.labs.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labs.Location = new System.Drawing.Point(12, 370);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(186, 29);
            this.labs.TabIndex = 12;
            this.labs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // typeofcontroltxt
            // 
            this.typeofcontroltxt.AutoSize = true;
            this.typeofcontroltxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.typeofcontroltxt.Location = new System.Drawing.Point(8, 412);
            this.typeofcontroltxt.Name = "typeofcontroltxt";
            this.typeofcontroltxt.Size = new System.Drawing.Size(121, 21);
            this.typeofcontroltxt.TabIndex = 13;
            this.typeofcontroltxt.Text = "Вид контроля";
            // 
            // typeofcontrol
            // 
            this.typeofcontrol.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.typeofcontrol.FormattingEnabled = true;
            this.typeofcontrol.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет"});
            this.typeofcontrol.Location = new System.Drawing.Point(12, 436);
            this.typeofcontrol.Name = "typeofcontrol";
            this.typeofcontrol.Size = new System.Drawing.Size(186, 29);
            this.typeofcontrol.TabIndex = 14;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.add.Location = new System.Drawing.Point(15, 684);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(187, 32);
            this.add.TabIndex = 15;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.save.Location = new System.Drawing.Point(208, 684);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(187, 32);
            this.save.TabIndex = 16;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.open.Location = new System.Drawing.Point(208, 722);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(187, 32);
            this.open.TabIndex = 17;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // disciplines
            // 
            this.disciplines.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplines.FormattingEnabled = true;
            this.disciplines.HorizontalScrollbar = true;
            this.disciplines.ItemHeight = 15;
            this.disciplines.Location = new System.Drawing.Point(243, 27);
            this.disciplines.Name = "disciplines";
            this.disciplines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.disciplines.ScrollAlwaysVisible = true;
            this.disciplines.Size = new System.Drawing.Size(1255, 634);
            this.disciplines.TabIndex = 18;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.SystemColors.Control;
            this.course.LargeChange = 4;
            this.course.Location = new System.Drawing.Point(12, 160);
            this.course.Maximum = 4;
            this.course.Minimum = 1;
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(186, 45);
            this.course.TabIndex = 19;
            this.course.TabStop = false;
            this.course.Tag = "";
            this.course.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.course.Value = 1;
            this.course.Scroll += new System.EventHandler(this.course_Scroll);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.clear.Location = new System.Drawing.Point(15, 722);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(187, 32);
            this.clear.TabIndex = 20;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fullname.Location = new System.Drawing.Point(12, 501);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(186, 29);
            this.fullname.TabIndex = 22;
            this.fullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // fullnametxt
            // 
            this.fullnametxt.AutoSize = true;
            this.fullnametxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fullnametxt.Location = new System.Drawing.Point(8, 477);
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(118, 21);
            this.fullnametxt.TabIndex = 21;
            this.fullnametxt.Text = "ФИО лектора";
            // 
            // audience
            // 
            this.audience.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.audience.Location = new System.Drawing.Point(15, 631);
            this.audience.Name = "audience";
            this.audience.Size = new System.Drawing.Size(186, 29);
            this.audience.TabIndex = 24;
            this.audience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress_1);
            // 
            // cabtxt
            // 
            this.cabtxt.AutoSize = true;
            this.cabtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cabtxt.Location = new System.Drawing.Point(11, 607);
            this.cabtxt.Name = "cabtxt";
            this.cabtxt.Size = new System.Drawing.Size(97, 21);
            this.cabtxt.TabIndex = 23;
            this.cabtxt.Text = "Аудитория";
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.department.Location = new System.Drawing.Point(12, 569);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(186, 29);
            this.department.TabIndex = 26;
            this.department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress_1);
            // 
            // departmenttxt
            // 
            this.departmenttxt.AutoSize = true;
            this.departmenttxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.departmenttxt.Location = new System.Drawing.Point(8, 545);
            this.departmenttxt.Name = "departmenttxt";
            this.departmenttxt.Size = new System.Drawing.Size(79, 21);
            this.departmenttxt.TabIndex = 25;
            this.departmenttxt.Text = "Кафедра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 782);
            this.Controls.Add(this.department);
            this.Controls.Add(this.departmenttxt);
            this.Controls.Add(this.audience);
            this.Controls.Add(this.cabtxt);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.fullnametxt);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.course);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.typeofcontrol);
            this.Controls.Add(this.typeofcontroltxt);
            this.Controls.Add(this.labs);
            this.Controls.Add(this.labtxt);
            this.Controls.Add(this.lectures);
            this.Controls.Add(this.lecttxt);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.spectxt);
            this.Controls.Add(this.semestr);
            this.Controls.Add(this.coursetxt);
            this.Controls.Add(this.semestrtxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nametxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.semestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label semestrtxt;
        private System.Windows.Forms.Label coursetxt;
        private System.Windows.Forms.NumericUpDown semestr;
        private System.Windows.Forms.Label spectxt;
        private System.Windows.Forms.ComboBox specialization;
        private System.Windows.Forms.Label lecttxt;
        private System.Windows.Forms.TextBox lectures;
        private System.Windows.Forms.Label labtxt;
        private System.Windows.Forms.TextBox labs;
        private System.Windows.Forms.Label typeofcontroltxt;
        private System.Windows.Forms.ComboBox typeofcontrol;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ListBox disciplines;
        private System.Windows.Forms.TrackBar course;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label fullnametxt;
        private System.Windows.Forms.TextBox audience;
        private System.Windows.Forms.Label cabtxt;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label departmenttxt;
    }
}

