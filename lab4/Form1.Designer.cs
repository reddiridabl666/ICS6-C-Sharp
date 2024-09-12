namespace lab4
{
    partial class Form1
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
            this.testerNameEdit = new System.Windows.Forms.TextBox();
            this.addTesterBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.testerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.taskDescEdit = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.taskDueToEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.assignTaskNameEdit = new System.Windows.Forms.TextBox();
            this.assignTaskBtn = new System.Windows.Forms.Button();
            this.assiognTaskTesterEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.taskStatusNameEdit = new System.Windows.Forms.TextBox();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.taskStatusEdit = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listTasksTesterName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listTasksBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testerNameEdit
            // 
            this.testerNameEdit.Location = new System.Drawing.Point(44, 3);
            this.testerNameEdit.Name = "testerNameEdit";
            this.testerNameEdit.Size = new System.Drawing.Size(102, 20);
            this.testerNameEdit.TabIndex = 0;
            this.testerNameEdit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addTesterBtn
            // 
            this.addTesterBtn.Location = new System.Drawing.Point(152, 3);
            this.addTesterBtn.Name = "addTesterBtn";
            this.addTesterBtn.Size = new System.Drawing.Size(75, 23);
            this.addTesterBtn.TabIndex = 1;
            this.addTesterBtn.Text = "Add Tester";
            this.addTesterBtn.UseVisualStyleBackColor = true;
            this.addTesterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.testerLabel);
            this.flowLayoutPanel1.Controls.Add(this.testerNameEdit);
            this.flowLayoutPanel1.Controls.Add(this.addTesterBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // testerLabel
            // 
            this.testerLabel.AutoSize = true;
            this.testerLabel.Location = new System.Drawing.Point(3, 0);
            this.testerLabel.Name = "testerLabel";
            this.testerLabel.Size = new System.Drawing.Size(35, 13);
            this.testerLabel.TabIndex = 2;
            this.testerLabel.Text = "Name";
            this.testerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(3, 180);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.addTaskBtn.TabIndex = 1;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // taskDescEdit
            // 
            this.taskDescEdit.Location = new System.Drawing.Point(3, 45);
            this.taskDescEdit.Multiline = true;
            this.taskDescEdit.Name = "taskDescEdit";
            this.taskDescEdit.Size = new System.Drawing.Size(111, 62);
            this.taskDescEdit.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(9, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.taskDueToEdit);
            this.splitContainer1.Panel2.Controls.Add(this.taskDescEdit);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.addTaskBtn);
            this.splitContainer1.Size = new System.Drawing.Size(222, 213);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 3;
            // 
            // taskDueToEdit
            // 
            this.taskDueToEdit.Location = new System.Drawing.Point(3, 132);
            this.taskDueToEdit.Name = "taskDueToEdit";
            this.taskDueToEdit.Size = new System.Drawing.Size(111, 20);
            this.taskDueToEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due to";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "New task";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "New tester";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Assign task";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(261, 25);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.assiognTaskTesterEdit);
            this.splitContainer2.Panel2.Controls.Add(this.assignTaskNameEdit);
            this.splitContainer2.Panel2.Controls.Add(this.assignTaskBtn);
            this.splitContainer2.Size = new System.Drawing.Size(222, 116);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tester name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Task name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // assignTaskNameEdit
            // 
            this.assignTaskNameEdit.Location = new System.Drawing.Point(3, 9);
            this.assignTaskNameEdit.Name = "assignTaskNameEdit";
            this.assignTaskNameEdit.Size = new System.Drawing.Size(111, 20);
            this.assignTaskNameEdit.TabIndex = 3;
            // 
            // assignTaskBtn
            // 
            this.assignTaskBtn.Location = new System.Drawing.Point(3, 80);
            this.assignTaskBtn.Name = "assignTaskBtn";
            this.assignTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.assignTaskBtn.TabIndex = 1;
            this.assignTaskBtn.Text = "Assign task";
            this.assignTaskBtn.UseVisualStyleBackColor = true;
            // 
            // assiognTaskTesterEdit
            // 
            this.assiognTaskTesterEdit.Location = new System.Drawing.Point(3, 42);
            this.assiognTaskTesterEdit.Name = "assiognTaskTesterEdit";
            this.assiognTaskTesterEdit.Size = new System.Drawing.Size(111, 20);
            this.assiognTaskTesterEdit.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Change task status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(261, 170);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.taskStatusEdit);
            this.splitContainer3.Panel2.Controls.Add(this.taskStatusNameEdit);
            this.splitContainer3.Panel2.Controls.Add(this.changeStatusBtn);
            this.splitContainer3.Size = new System.Drawing.Size(222, 116);
            this.splitContainer3.SplitterDistance = 90;
            this.splitContainer3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Task name";
            // 
            // taskStatusNameEdit
            // 
            this.taskStatusNameEdit.Location = new System.Drawing.Point(3, 9);
            this.taskStatusNameEdit.Name = "taskStatusNameEdit";
            this.taskStatusNameEdit.Size = new System.Drawing.Size(111, 20);
            this.taskStatusNameEdit.TabIndex = 3;
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.Location = new System.Drawing.Point(3, 80);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(89, 23);
            this.changeStatusBtn.TabIndex = 1;
            this.changeStatusBtn.Text = "Change status";
            this.changeStatusBtn.UseVisualStyleBackColor = true;
            // 
            // taskStatusEdit
            // 
            this.taskStatusEdit.FormattingEnabled = true;
            this.taskStatusEdit.Items.AddRange(new object[] {
            "Backlog",
            "InProgress",
            "Review",
            "Done"});
            this.taskStatusEdit.Location = new System.Drawing.Point(3, 45);
            this.taskStatusEdit.Name = "taskStatusEdit";
            this.taskStatusEdit.Size = new System.Drawing.Size(111, 21);
            this.taskStatusEdit.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listTasksBtn);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.listTasksTesterName);
            this.panel1.Location = new System.Drawing.Point(9, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 134);
            this.panel1.TabIndex = 15;
            // 
            // listTasksTesterName
            // 
            this.listTasksTesterName.Location = new System.Drawing.Point(98, 23);
            this.listTasksTesterName.Name = "listTasksTesterName";
            this.listTasksTesterName.Size = new System.Drawing.Size(111, 20);
            this.listTasksTesterName.TabIndex = 3;
            this.listTasksTesterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "List tasks";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tester name";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 71);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listTasksBtn
            // 
            this.listTasksBtn.Location = new System.Drawing.Point(231, 21);
            this.listTasksBtn.Name = "listTasksBtn";
            this.listTasksBtn.Size = new System.Drawing.Size(75, 23);
            this.listTasksBtn.TabIndex = 14;
            this.listTasksBtn.Text = "List";
            this.listTasksBtn.UseVisualStyleBackColor = true;
            this.listTasksBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testerNameEdit;
        private System.Windows.Forms.Button addTesterBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label testerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskDescEdit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker taskDueToEdit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assiognTaskTesterEdit;
        private System.Windows.Forms.TextBox assignTaskNameEdit;
        private System.Windows.Forms.Button assignTaskBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox taskStatusNameEdit;
        private System.Windows.Forms.Button changeStatusBtn;
        private System.Windows.Forms.ComboBox taskStatusEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox listTasksTesterName;
        private System.Windows.Forms.Button listTasksBtn;
    }
}

