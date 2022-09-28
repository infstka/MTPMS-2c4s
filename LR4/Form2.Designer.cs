
namespace ЛР2
{
    partial class Form2
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
            this.discipline = new System.Windows.Forms.ListBox();
            this.disciplinetxt = new System.Windows.Forms.Label();
            this.form2search = new System.Windows.Forms.Button();
            this.fullnamesearch = new System.Windows.Forms.TextBox();
            this.semestrsearch = new System.Windows.Forms.NumericUpDown();
            this.semestrsearchtxt = new System.Windows.Forms.Label();
            this.coursesearchtxt = new System.Windows.Forms.Label();
            this.fullnamesearchtxt = new System.Windows.Forms.Label();
            this.coursesearch = new System.Windows.Forms.NumericUpDown();
            this.param = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.form2sort = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.semestrsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesearch)).BeginInit();
            this.param.SuspendLayout();
            this.SuspendLayout();
            // 
            // discipline
            // 
            this.discipline.FormattingEnabled = true;
            this.discipline.Location = new System.Drawing.Point(247, 26);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(541, 238);
            this.discipline.TabIndex = 21;
            // 
            // disciplinetxt
            // 
            this.disciplinetxt.AutoSize = true;
            this.disciplinetxt.Location = new System.Drawing.Point(244, 10);
            this.disciplinetxt.Name = "disciplinetxt";
            this.disciplinetxt.Size = new System.Drawing.Size(106, 13);
            this.disciplinetxt.TabIndex = 20;
            this.disciplinetxt.Text = "Результаты поиска";
            // 
            // form2search
            // 
            this.form2search.Location = new System.Drawing.Point(9, 140);
            this.form2search.Name = "form2search";
            this.form2search.Size = new System.Drawing.Size(75, 23);
            this.form2search.TabIndex = 19;
            this.form2search.Text = "Поиск";
            this.form2search.UseVisualStyleBackColor = true;
            this.form2search.Click += new System.EventHandler(this.form2search_Click);
            // 
            // fullnamesearch
            // 
            this.fullnamesearch.Location = new System.Drawing.Point(94, 33);
            this.fullnamesearch.Name = "fullnamesearch";
            this.fullnamesearch.Size = new System.Drawing.Size(127, 20);
            this.fullnamesearch.TabIndex = 10;
            // 
            // semestrsearch
            // 
            this.semestrsearch.Location = new System.Drawing.Point(94, 92);
            this.semestrsearch.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.semestrsearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semestrsearch.Name = "semestrsearch";
            this.semestrsearch.Size = new System.Drawing.Size(127, 20);
            this.semestrsearch.TabIndex = 7;
            this.semestrsearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // semestrsearchtxt
            // 
            this.semestrsearchtxt.AutoSize = true;
            this.semestrsearchtxt.Location = new System.Drawing.Point(9, 94);
            this.semestrsearchtxt.Name = "semestrsearchtxt";
            this.semestrsearchtxt.Size = new System.Drawing.Size(51, 13);
            this.semestrsearchtxt.TabIndex = 6;
            this.semestrsearchtxt.Text = "Семестр";
            // 
            // coursesearchtxt
            // 
            this.coursesearchtxt.AutoSize = true;
            this.coursesearchtxt.Location = new System.Drawing.Point(9, 61);
            this.coursesearchtxt.Name = "coursesearchtxt";
            this.coursesearchtxt.Size = new System.Drawing.Size(31, 13);
            this.coursesearchtxt.TabIndex = 5;
            this.coursesearchtxt.Text = "Курс";
            // 
            // fullnamesearchtxt
            // 
            this.fullnamesearchtxt.AutoSize = true;
            this.fullnamesearchtxt.Location = new System.Drawing.Point(6, 33);
            this.fullnamesearchtxt.Name = "fullnamesearchtxt";
            this.fullnamesearchtxt.Size = new System.Drawing.Size(34, 13);
            this.fullnamesearchtxt.TabIndex = 1;
            this.fullnamesearchtxt.Text = "ФИО";
            // 
            // coursesearch
            // 
            this.coursesearch.Location = new System.Drawing.Point(94, 59);
            this.coursesearch.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.coursesearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coursesearch.Name = "coursesearch";
            this.coursesearch.Size = new System.Drawing.Size(127, 20);
            this.coursesearch.TabIndex = 4;
            this.coursesearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // param
            // 
            this.param.Controls.Add(this.fullnamesearch);
            this.param.Controls.Add(this.textBox2);
            this.param.Controls.Add(this.semestrsearch);
            this.param.Controls.Add(this.semestrsearchtxt);
            this.param.Controls.Add(this.coursesearchtxt);
            this.param.Controls.Add(this.fullnamesearchtxt);
            this.param.Controls.Add(this.coursesearch);
            this.param.Controls.Add(this.label2);
            this.param.Location = new System.Drawing.Point(9, 12);
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(232, 122);
            this.param.TabIndex = 23;
            this.param.TabStop = false;
            this.param.Text = "Поиск по параметрам";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // form2sort
            // 
            this.form2sort.Items.Add("По кол-ву лекций");
            this.form2sort.Items.Add("По виду контроля");
            this.form2sort.Location = new System.Drawing.Point(121, 140);
            this.form2sort.Name = "form2sort";
            this.form2sort.Size = new System.Drawing.Size(120, 20);
            this.form2sort.TabIndex = 24;
            this.form2sort.Text = "По кол-ву лекций";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.form2sort);
            this.Controls.Add(this.param);
            this.Controls.Add(this.discipline);
            this.Controls.Add(this.disciplinetxt);
            this.Controls.Add(this.form2search);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.semestrsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesearch)).EndInit();
            this.param.ResumeLayout(false);
            this.param.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox discipline;
        private System.Windows.Forms.Label disciplinetxt;
        private System.Windows.Forms.Button form2search;
        private System.Windows.Forms.TextBox fullnamesearch;
        private System.Windows.Forms.NumericUpDown semestrsearch;
        private System.Windows.Forms.Label semestrsearchtxt;
        private System.Windows.Forms.Label coursesearchtxt;
        private System.Windows.Forms.Label fullnamesearchtxt;
        private System.Windows.Forms.NumericUpDown coursesearch;
        private System.Windows.Forms.GroupBox param;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown form2sort;
    }
}