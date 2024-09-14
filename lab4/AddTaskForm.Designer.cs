namespace lab4
{
    partial class AddTaskForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskDueToEdit = new System.Windows.Forms.DateTimePicker();
            this.taskDescEdit = new System.Windows.Forms.TextBox();
            this.taskNameEdit = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.taskDueToEdit);
            this.splitContainer1.Panel2.Controls.Add(this.taskDescEdit);
            this.splitContainer1.Panel2.Controls.Add(this.taskNameEdit);
            this.splitContainer1.Panel2.Controls.Add(this.addTaskBtn);
            this.splitContainer1.Size = new System.Drawing.Size(222, 213);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // taskDueToEdit
            // 
            this.taskDueToEdit.Location = new System.Drawing.Point(3, 132);
            this.taskDueToEdit.Name = "taskDueToEdit";
            this.taskDueToEdit.Size = new System.Drawing.Size(111, 20);
            this.taskDueToEdit.TabIndex = 5;
            // 
            // taskDescEdit
            // 
            this.taskDescEdit.Location = new System.Drawing.Point(3, 45);
            this.taskDescEdit.Multiline = true;
            this.taskDescEdit.Name = "taskDescEdit";
            this.taskDescEdit.Size = new System.Drawing.Size(111, 62);
            this.taskDescEdit.TabIndex = 4;
            // 
            // taskNameEdit
            // 
            this.taskNameEdit.Location = new System.Drawing.Point(3, 9);
            this.taskNameEdit.Name = "taskNameEdit";
            this.taskNameEdit.Size = new System.Drawing.Size(111, 20);
            this.taskNameEdit.TabIndex = 3;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(3, 180);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.addTaskBtn.TabIndex = 1;
            this.addTaskBtn.Text = "Add";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 236);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddTaskForm";
            this.Text = "Add task";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker taskDueToEdit;
        private System.Windows.Forms.TextBox taskDescEdit;
        private System.Windows.Forms.TextBox taskNameEdit;
        private System.Windows.Forms.Button addTaskBtn;
    }
}