namespace Club_Start.Add.Data
{
    partial class AddSportsmenInBase
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
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(135, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 26);
            dateTimePicker1.TabIndex = 22;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(8, 197);
            label5.Name = "label5";
            label5.Size = new Size(121, 55);
            label5.TabIndex = 21;
            label5.Text = "Номер телефона родителя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(8, 156);
            label4.Name = "label4";
            label4.Size = new Size(115, 18);
            label4.TabIndex = 20;
            label4.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(8, 107);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 19;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(8, 62);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 18;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 18);
            label1.TabIndex = 17;
            label1.Text = "Имя";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 11.25F);
            button1.Location = new Point(175, 265);
            button1.Name = "button1";
            button1.Size = new Size(157, 53);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddSportsmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 332);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "AddSportsmen";
            Text = "AddSportsmen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}