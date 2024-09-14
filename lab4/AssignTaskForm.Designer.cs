namespace lab4
{
    partial class AssignTaskForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.assignTaskTesterEdit = new System.Windows.Forms.TextBox();
            this.assignTaskNameEdit = new System.Windows.Forms.TextBox();
            this.assignTaskBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(12, 12);
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
            this.splitContainer2.Panel2.Controls.Add(this.assignTaskTesterEdit);
            this.splitContainer2.Panel2.Controls.Add(this.assignTaskNameEdit);
            this.splitContainer2.Panel2.Controls.Add(this.assignTaskBtn);
            this.splitContainer2.Size = new System.Drawing.Size(222, 116);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 10;
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
            // 
            // assignTaskTesterEdit
            // 
            this.assignTaskTesterEdit.Location = new System.Drawing.Point(3, 42);
            this.assignTaskTesterEdit.Name = "assignTaskTesterEdit";
            this.assignTaskTesterEdit.Size = new System.Drawing.Size(111, 20);
            this.assignTaskTesterEdit.TabIndex = 6;
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
            this.assignTaskBtn.Text = "Assign";
            this.assignTaskBtn.UseVisualStyleBackColor = true;
            this.assignTaskBtn.Click += new System.EventHandler(this.assignTaskBtn_Click);
            // 
            // AssignTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 134);
            this.Controls.Add(this.splitContainer2);
            this.Name = "AssignTaskForm";
            this.Text = "Assign task";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assignTaskTesterEdit;
        private System.Windows.Forms.TextBox assignTaskNameEdit;
        private System.Windows.Forms.Button assignTaskBtn;
    }
}