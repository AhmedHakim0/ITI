namespace Form_Connecting
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
            Employees = new ListBox();
            Btn_Display = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Btn_Add = new Button();
            Btn_Change = new Button();
            Btn_Remove = new Button();
            Btn_Connect = new Button();
            Btn_Disconnect = new Button();
            SuspendLayout();
            // 
            // Employees
            // 
            Employees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Employees.BackColor = SystemColors.AppWorkspace;
            Employees.FormattingEnabled = true;
            Employees.ItemHeight = 15;
            Employees.Location = new Point(313, 12);
            Employees.Name = "Employees";
            Employees.Size = new Size(475, 289);
            Employees.TabIndex = 0;
            // 
            // Btn_Display
            // 
            Btn_Display.BackColor = Color.BurlyWood;
            Btn_Display.Location = new Point(372, 333);
            Btn_Display.Name = "Btn_Display";
            Btn_Display.Size = new Size(84, 30);
            Btn_Display.TabIndex = 1;
            Btn_Display.Text = "Display";
            Btn_Display.UseVisualStyleBackColor = false;
            Btn_Display.Click += Display_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 53);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Fname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 157);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 11;
            label3.Text = "Lname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 213);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Dept_Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 272);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 13;
            label5.Text = "Dept_Number";
            // 
            // Btn_Add
            // 
            Btn_Add.BackColor = Color.Pink;
            Btn_Add.Location = new Point(472, 333);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(85, 30);
            Btn_Add.TabIndex = 14;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = false;
            Btn_Add.Click += Add_Click;
            // 
            // Btn_Change
            // 
            Btn_Change.BackColor = Color.Silver;
            Btn_Change.Location = new Point(566, 333);
            Btn_Change.Name = "Btn_Change";
            Btn_Change.Size = new Size(83, 30);
            Btn_Change.TabIndex = 15;
            Btn_Change.Text = "change";
            Btn_Change.UseVisualStyleBackColor = false;
            Btn_Change.Click += Update_Click;
            // 
            // Btn_Remove
            // 
            Btn_Remove.BackColor = Color.Tomato;
            Btn_Remove.Location = new Point(663, 333);
            Btn_Remove.Name = "Btn_Remove";
            Btn_Remove.Size = new Size(87, 30);
            Btn_Remove.TabIndex = 16;
            Btn_Remove.Text = "Remove";
            Btn_Remove.UseVisualStyleBackColor = false;
            Btn_Remove.Click += Delete_Click;
            // 
            // Btn_Connect
            // 
            Btn_Connect.BackColor = Color.SpringGreen;
            Btn_Connect.Location = new Point(29, 367);
            Btn_Connect.Name = "Btn_Connect";
            Btn_Connect.Size = new Size(81, 33);
            Btn_Connect.TabIndex = 17;
            Btn_Connect.Text = "Connect";
            Btn_Connect.UseVisualStyleBackColor = false;
            Btn_Connect.Click += Connect_Click;
            // 
            // Btn_Disconnect
            // 
            Btn_Disconnect.BackColor = Color.Red;
            Btn_Disconnect.Location = new Point(134, 367);
            Btn_Disconnect.Name = "Btn_Disconnect";
            Btn_Disconnect.Size = new Size(77, 33);
            Btn_Disconnect.TabIndex = 18;
            Btn_Disconnect.Text = "Disconnect";
            Btn_Disconnect.UseVisualStyleBackColor = false;
            Btn_Disconnect.Click += DisConnect_Click;
            // 
            // Form1
            // 
            AccessibleDescription = "0";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Disconnect);
            Controls.Add(Btn_Connect);
            Controls.Add(Btn_Remove);
            Controls.Add(Btn_Change);
            Controls.Add(Btn_Add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Btn_Display);
            Controls.Add(Employees);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Employees;
        private Button Btn_Display;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Btn_Add;
        private Button Btn_Change;
        private Button Btn_Remove;
        private Button Btn_Connect;
        private Button Btn_Disconnect;
    }
}
