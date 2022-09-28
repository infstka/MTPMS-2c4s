
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
            this.semtxt = new System.Windows.Forms.Label();
            this.coursetxt = new System.Windows.Forms.Label();
            this.semestr = new System.Windows.Forms.NumericUpDown();
            this.spectxt = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.ComboBox();
            this.lecttxt = new System.Windows.Forms.Label();
            this.lect = new System.Windows.Forms.TextBox();
            this.labstxt = new System.Windows.Forms.Label();
            this.labs = new System.Windows.Forms.TextBox();
            this.controltxt = new System.Windows.Forms.Label();
            this.control = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.disciplines = new System.Windows.Forms.ListBox();
            this.course = new System.Windows.Forms.TrackBar();
            this.clear = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.TextBox();
            this.fiotxt = new System.Windows.Forms.Label();
            this.aud = new System.Windows.Forms.TextBox();
            this.audttxt = new System.Windows.Forms.Label();
            this.depart = new System.Windows.Forms.TextBox();
            this.departtxt = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.sort = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByNOL = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByTOC = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.semestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.nametxt.Location = new System.Drawing.Point(8, 32);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(190, 21);
            this.nametxt.TabIndex = 0;
            this.nametxt.Text = "Название дисциплины";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.name.Location = new System.Drawing.Point(12, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 29);
            this.name.TabIndex = 1;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // semtxt
            // 
            this.semtxt.AutoSize = true;
            this.semtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.semtxt.Location = new System.Drawing.Point(8, 94);
            this.semtxt.Name = "semtxt";
            this.semtxt.Size = new System.Drawing.Size(78, 21);
            this.semtxt.TabIndex = 2;
            this.semtxt.Text = "Семестр";
            // 
            // coursetxt
            // 
            this.coursetxt.AutoSize = true;
            this.coursetxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.coursetxt.Location = new System.Drawing.Point(11, 159);
            this.coursetxt.Name = "coursetxt";
            this.coursetxt.Size = new System.Drawing.Size(50, 21);
            this.coursetxt.TabIndex = 4;
            this.coursetxt.Text = "Курс";
            // 
            // semestr
            // 
            this.semestr.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.semestr.Location = new System.Drawing.Point(12, 118);
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
            this.spectxt.Location = new System.Drawing.Point(8, 234);
            this.spectxt.Name = "spectxt";
            this.spectxt.Size = new System.Drawing.Size(133, 21);
            this.spectxt.TabIndex = 7;
            this.spectxt.Text = "Специальность";
            // 
            // spec
            // 
            this.spec.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.spec.FormattingEnabled = true;
            this.spec.Items.AddRange(new object[] {
            "ПОИТ",
            "ИСиТ",
            "ПОИБМС",
            "ДЭиВИ"});
            this.spec.Location = new System.Drawing.Point(12, 258);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(186, 29);
            this.spec.TabIndex = 8;
            // 
            // lecttxt
            // 
            this.lecttxt.AutoSize = true;
            this.lecttxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lecttxt.Location = new System.Drawing.Point(8, 303);
            this.lecttxt.Name = "lecttxt";
            this.lecttxt.Size = new System.Drawing.Size(166, 21);
            this.lecttxt.TabIndex = 9;
            this.lecttxt.Text = "Количество лекций";
            // 
            // lect
            // 
            this.lect.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lect.Location = new System.Drawing.Point(12, 327);
            this.lect.Name = "lect";
            this.lect.Size = new System.Drawing.Size(186, 29);
            this.lect.TabIndex = 10;
            this.lect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labstxt
            // 
            this.labstxt.AutoSize = true;
            this.labstxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labstxt.Location = new System.Drawing.Point(8, 369);
            this.labstxt.Name = "labstxt";
            this.labstxt.Size = new System.Drawing.Size(225, 21);
            this.labstxt.TabIndex = 11;
            this.labstxt.Text = "Количество лабораторных";
            // 
            // labs
            // 
            this.labs.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labs.Location = new System.Drawing.Point(12, 393);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(186, 29);
            this.labs.TabIndex = 12;
            this.labs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // controltxt
            // 
            this.controltxt.AutoSize = true;
            this.controltxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.controltxt.Location = new System.Drawing.Point(8, 435);
            this.controltxt.Name = "controltxt";
            this.controltxt.Size = new System.Drawing.Size(121, 21);
            this.controltxt.TabIndex = 13;
            this.controltxt.Text = "Вид контроля";
            // 
            // control
            // 
            this.control.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.control.FormattingEnabled = true;
            this.control.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет"});
            this.control.Location = new System.Drawing.Point(12, 459);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(186, 29);
            this.control.TabIndex = 14;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.add.Location = new System.Drawing.Point(15, 707);
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
            this.save.Location = new System.Drawing.Point(208, 707);
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
            this.open.Location = new System.Drawing.Point(208, 745);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(187, 32);
            this.open.TabIndex = 17;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // disciplines
            // 
            this.disciplines.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplines.FormattingEnabled = true;
            this.disciplines.HorizontalScrollbar = true;
            this.disciplines.ItemHeight = 21;
            this.disciplines.Location = new System.Drawing.Point(239, 32);
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
            this.course.Location = new System.Drawing.Point(12, 183);
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
            this.clear.Location = new System.Drawing.Point(15, 745);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(187, 32);
            this.clear.TabIndex = 20;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // fio
            // 
            this.fio.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fio.Location = new System.Drawing.Point(12, 524);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(186, 29);
            this.fio.TabIndex = 22;
            this.fio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // fiotxt
            // 
            this.fiotxt.AutoSize = true;
            this.fiotxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.fiotxt.Location = new System.Drawing.Point(8, 500);
            this.fiotxt.Name = "fiotxt";
            this.fiotxt.Size = new System.Drawing.Size(118, 21);
            this.fiotxt.TabIndex = 21;
            this.fiotxt.Text = "ФИО лектора";
            // 
            // aud
            // 
            this.aud.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.aud.Location = new System.Drawing.Point(15, 654);
            this.aud.Name = "aud";
            this.aud.Size = new System.Drawing.Size(186, 29);
            this.aud.TabIndex = 24;
            this.aud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress_1);
            // 
            // audttxt
            // 
            this.audttxt.AutoSize = true;
            this.audttxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.audttxt.Location = new System.Drawing.Point(11, 630);
            this.audttxt.Name = "audttxt";
            this.audttxt.Size = new System.Drawing.Size(97, 21);
            this.audttxt.TabIndex = 23;
            this.audttxt.Text = "Аудитория";
            // 
            // depart
            // 
            this.depart.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.depart.Location = new System.Drawing.Point(12, 592);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(186, 29);
            this.depart.TabIndex = 26;
            this.depart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress_1);
            // 
            // departtxt
            // 
            this.departtxt.AutoSize = true;
            this.departtxt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.departtxt.Location = new System.Drawing.Point(8, 568);
            this.departtxt.Name = "departtxt";
            this.departtxt.Size = new System.Drawing.Size(79, 21);
            this.departtxt.TabIndex = 25;
            this.departtxt.Text = "Кафедра";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.sort,
            this.about,
            this.date,
            this.progress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1510, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 25);
            this.file.Text = "Файл";
            // 
            // search
            // 
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(109, 22);
            this.search.Text = "Поиск";
            this.search.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // sort
            // 
            this.sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByNOL,
            this.SortByTOC});
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(85, 25);
            this.sort.Text = "Сортировка";
            // 
            // SortByNOL
            // 
            this.SortByNOL.Name = "SortByNOL";
            this.SortByNOL.Size = new System.Drawing.Size(173, 22);
            this.SortByNOL.Text = "По кол-ву лекций";
            this.SortByNOL.Click += new System.EventHandler(this.SortByNOL_Click);
            // 
            // SortByTOC
            // 
            this.SortByTOC.Name = "SortByTOC";
            this.SortByTOC.Size = new System.Drawing.Size(173, 22);
            this.SortByTOC.Text = "По виду контроля";
            this.SortByTOC.Click += new System.EventHandler(this.SortByTOC_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 25);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // date
            // 
            this.date.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(79, 20);
            this.date.Text = "Дата и время";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // progress
            // 
            this.progress.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 20);
            this.progress.Text = "Кол-во объектов";
            this.progress.Click += new System.EventHandler(this.progress_Click_1);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(401, 707);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(187, 32);
            this.next.TabIndex = 29;
            this.next.Text = "->";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(401, 745);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(187, 32);
            this.back.TabIndex = 30;
            this.back.Text = "<-";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(594, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "О форме";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.formabout_Click);
            // 
            // clone
            // 
            this.clone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clone.Location = new System.Drawing.Point(594, 745);
            this.clone.Name = "clone";
            this.clone.Size = new System.Drawing.Size(187, 32);
            this.clone.TabIndex = 32;
            this.clone.Text = "Клонирование";
            this.clone.UseVisualStyleBackColor = true;
            this.clone.Click += new System.EventHandler(this.clone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 782);
            this.Controls.Add(this.clone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.departtxt);
            this.Controls.Add(this.aud);
            this.Controls.Add(this.audttxt);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.fiotxt);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.course);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.control);
            this.Controls.Add(this.controltxt);
            this.Controls.Add(this.labs);
            this.Controls.Add(this.labstxt);
            this.Controls.Add(this.lect);
            this.Controls.Add(this.lecttxt);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.spectxt);
            this.Controls.Add(this.semestr);
            this.Controls.Add(this.coursetxt);
            this.Controls.Add(this.semtxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nametxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.semestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label semtxt;
        private System.Windows.Forms.Label coursetxt;
        private System.Windows.Forms.NumericUpDown semestr;
        private System.Windows.Forms.Label spectxt;
        private System.Windows.Forms.ComboBox spec;
        private System.Windows.Forms.Label lecttxt;
        private System.Windows.Forms.TextBox lect;
        private System.Windows.Forms.Label labstxt;
        private System.Windows.Forms.TextBox labs;
        private System.Windows.Forms.Label controltxt;
        private System.Windows.Forms.ComboBox control;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ListBox disciplines;
        private System.Windows.Forms.TrackBar course;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label fiotxt;
        private System.Windows.Forms.TextBox aud;
        private System.Windows.Forms.Label audttxt;
        private System.Windows.Forms.TextBox depart;
        private System.Windows.Forms.Label departtxt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem sort;
        private System.Windows.Forms.ToolStripMenuItem SortByNOL;
        private System.Windows.Forms.ToolStripMenuItem SortByTOC;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ToolStripStatusLabel progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clone;
    }
}

