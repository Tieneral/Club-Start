
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
            tabPage2 = new TabPage();
            panel1 = new Panel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            button4 = new Button();
            tabPage5 = new TabPage();
            btnAddCoach = new Button();
            tabPage3 = new TabPage();
            button1 = new Button();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            dgv = new DataGridView();
            tabPage6 = new TabPage();
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            tabPage6.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(899, 598);
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
            tabControl1.Size = new Size(214, 592);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(206, 564);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(206, 564);
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
            panel1.Size = new Size(200, 558);
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
            button4.Click += btn4SportAdd_Click;
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
            btnAddCoach.Click += btnAddCoach_Click;
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
            tabPage3.Size = new Size(206, 564);
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
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(26, 235);
            label3.Name = "label3";
            label3.Size = new Size(158, 36);
            label3.TabIndex = 5;
            label3.Text = "Посмотреть таблицу \r\nТренеровок";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(26, 274);
            button3.Name = "button3";
            button3.Size = new Size(158, 50);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(26, 159);
            button2.Name = "button2";
            button2.Size = new Size(158, 50);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(26, 120);
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
            dgv.Size = new Size(673, 592);
            dgv.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button5);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(190, 525);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Посещения";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 22);
            button5.Name = "button5";
            button5.Size = new Size(178, 49);
            button5.TabIndex = 1;
            button5.Text = "Добавить тренера";
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 598);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            tabPage6.ResumeLayout(false);
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
        private Button button5;
    }
}
