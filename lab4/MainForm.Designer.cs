namespace lab4
{
    partial class MainForm
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
            this.addTesterBtn = new System.Windows.Forms.Button();
            this.assignTaskBtn = new System.Windows.Forms.Button();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.listTasksBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.testerList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.taskList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTesterBtn
            // 
            this.addTesterBtn.Location = new System.Drawing.Point(12, 243);
            this.addTesterBtn.Name = "addTesterBtn";
            this.addTesterBtn.Size = new System.Drawing.Size(75, 23);
            this.addTesterBtn.TabIndex = 3;
            this.addTesterBtn.Text = "Add Tester";
            this.addTesterBtn.UseVisualStyleBackColor = true;
            this.addTesterBtn.Click += new System.EventHandler(this.addTesterBtn_Click);
            // 
            // assignTaskBtn
            // 
            this.assignTaskBtn.Location = new System.Drawing.Point(3, 3);
            this.assignTaskBtn.Name = "assignTaskBtn";
            this.assignTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.assignTaskBtn.TabIndex = 16;
            this.assignTaskBtn.Text = "Assign Task";
            this.assignTaskBtn.UseVisualStyleBackColor = true;
            this.assignTaskBtn.Click += new System.EventHandler(this.assignTaskBtn_Click);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(196, 243);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.addTaskBtn.TabIndex = 6;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.Location = new System.Drawing.Point(84, 3);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(124, 23);
            this.changeStatusBtn.TabIndex = 17;
            this.changeStatusBtn.Text = "Change Task Status";
            this.changeStatusBtn.UseVisualStyleBackColor = true;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // listTasksBtn
            // 
            this.listTasksBtn.Location = new System.Drawing.Point(214, 3);
            this.listTasksBtn.Name = "listTasksBtn";
            this.listTasksBtn.Size = new System.Drawing.Size(112, 23);
            this.listTasksBtn.TabIndex = 18;
            this.listTasksBtn.Text = "List Tasks By Tester";
            this.listTasksBtn.UseVisualStyleBackColor = true;
            this.listTasksBtn.Click += new System.EventHandler(this.listTasksBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.assignTaskBtn);
            this.flowLayoutPanel1.Controls.Add(this.changeStatusBtn);
            this.flowLayoutPanel1.Controls.Add(this.listTasksBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 26);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // testerList
            // 
            this.testerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.testerList.HideSelection = false;
            this.testerList.Location = new System.Drawing.Point(12, 31);
            this.testerList.Name = "testerList";
            this.testerList.Size = new System.Drawing.Size(151, 206);
            this.testerList.TabIndex = 20;
            this.testerList.UseCompatibleStateImageBehavior = false;
            this.testerList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Testers";
            // 
            // taskList
            // 
            this.taskList.HideSelection = false;
            this.taskList.Location = new System.Drawing.Point(196, 31);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(608, 206);
            this.taskList.TabIndex = 22;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tasks";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 350);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.addTesterBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testerList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Task tracker";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addTesterBtn;
        private System.Windows.Forms.Button assignTaskBtn;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button changeStatusBtn;
        private System.Windows.Forms.Button listTasksBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ListView testerList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
