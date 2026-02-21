
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Club_Start
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button8 = new Button();
            label6 = new Label();
            button7 = new Button();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            button6 = new Button();
            label4 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            button4 = new Button();
            tabPage5 = new TabPage();
            btnAddCoach = new Button();
            tabPage6 = new TabPage();
            btnAddAtten = new Button();
            tabPage3 = new TabPage();
            button1 = new Button();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            dgv = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgv, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1004, 709);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(214, 703);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(dtpEnd);
            tabPage1.Controls.Add(dtpStart);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(206, 675);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Представления";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 0);
            button8.Location = new Point(22, 470);
            button8.Name = "button8";
            button8.Size = new Size(158, 50);
            button8.TabIndex = 20;
            button8.Text = "Посмотреть";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 419);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 19;
            label6.Text = "Посмотреть таблицу \r\nПосещаемости тренеровок\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(22, 321);
            button7.Name = "button7";
            button7.Size = new Size(158, 50);
            button7.TabIndex = 18;
            button7.Text = "Посмотреть";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(23, 271);
            label5.Name = "label5";
            label5.Size = new Size(158, 36);
            label5.TabIndex = 17;
            label5.Text = "Посмотреть таблицу \r\nАктивости ребёнка";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 118);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 16;
            label8.Text = "До этой даты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 68);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "От этой даты";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(23, 136);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(165, 23);
            dtpEnd.TabIndex = 14;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(23, 86);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(165, 23);
            dtpStart.TabIndex = 13;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 255, 192);
            button6.Location = new Point(23, 179);
            button6.Name = "button6";
            button6.Size = new Size(158, 50);
            button6.TabIndex = 8;
            button6.Text = "Посмотреть";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(23, 16);
            label4.Name = "label4";
            label4.Size = new Size(158, 36);
            label4.TabIndex = 7;
            label4.Text = "Посмотреть таблицу \r\nПрогульшиков";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(206, 675);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавление";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 669);
            panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Location = new Point(1, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(198, 553);
            tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(190, 525);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Спортсмены";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 22);
            button4.Name = "button4";
            button4.Size = new Size(178, 49);
            button4.TabIndex = 0;
            button4.Text = "Добавление спортсмена";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Btn4SportAdd_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnAddCoach);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(190, 525);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Тренера";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnAddCoach
            // 
            btnAddCoach.Location = new Point(6, 22);
            btnAddCoach.Name = "btnAddCoach";
            btnAddCoach.Size = new Size(178, 49);
            btnAddCoach.TabIndex = 0;
            btnAddCoach.Text = "Добавить тренера";
            btnAddCoach.UseVisualStyleBackColor = true;
            btnAddCoach.Click += BtnAddCoach_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btnAddAtten);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(190, 525);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Посещения";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnAddAtten
            // 
            btnAddAtten.Location = new Point(6, 22);
            btnAddAtten.Name = "btnAddAtten";
            btnAddAtten.Size = new Size(178, 49);
            btnAddAtten.TabIndex = 1;
            btnAddAtten.Text = "Добавить посещение";
            btnAddAtten.UseVisualStyleBackColor = true;
            btnAddAtten.Click += button5_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(192, 255, 255);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(206, 675);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Просмотр";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(26, 44);
            button1.Name = "button1";
            button1.Size = new Size(158, 50);
            button1.TabIndex = 6;
            button1.Text = "Посмотреть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(26, 210);
            label3.Name = "label3";
            label3.Size = new Size(158, 36);
            label3.TabIndex = 5;
            label3.Text = "Посмотреть таблицу \r\nТренеровок";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(26, 249);
            button3.Name = "button3";
            button3.Size = new Size(158, 50);
            button3.TabIndex = 4;
            button3.Text = "Посмотреть";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(26, 148);
            button2.Name = "button2";
            button2.Size = new Size(158, 50);
            button2.TabIndex = 3;
            button2.Text = "Посмотреть";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(26, 109);
            label2.Name = "label2";
            label2.Size = new Size(158, 36);
            label2.TabIndex = 2;
            label2.Text = "Посмотреть таблицу \r\nТренеров\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(26, 5);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 1;
            label1.Text = "Посмотреть таблицу \r\nСпортсменов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ActiveCaptionText;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(223, 3);
            dgv.Name = "dgv";
            dgv.Size = new Size(778, 703);
            dgv.TabIndex = 1;
            dgv.CellFormatting += dgv_CellFormatting;
            dgv.CellValueChanged += dgv_CellValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 709);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgv;
        private Label label1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private Button button4;
        private TabPage tabPage5;
        private Button btnAddCoach;
        private TabPage tabPage6;
        private Button btnAddAtten;
        private Button button6;
        private Label label4;
        private Label label7;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label label8;
        private Button button7;
        private Label label5;
        private Button button8;
        private Label label6;
    }
}
