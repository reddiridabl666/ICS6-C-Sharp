namespace lab4
{
    partial class ListTasksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listTasksBtn = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.listTasksTesterName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listTasksBtn);
            this.panel1.Controls.Add(this.taskList);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.listTasksTesterName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 116);
            this.panel1.TabIndex = 16;
            // 
            // listTasksBtn
            // 
            this.listTasksBtn.Location = new System.Drawing.Point(231, 7);
            this.listTasksBtn.Name = "listTasksBtn";
            this.listTasksBtn.Size = new System.Drawing.Size(75, 23);
            this.listTasksBtn.TabIndex = 14;
            this.listTasksBtn.Text = "List";
            this.listTasksBtn.UseVisualStyleBackColor = true;
            this.listTasksBtn.Click += new System.EventHandler(this.listTasksBtn_Click);
            // 
            // taskList
            // 
            this.taskList.HideSelection = false;
            this.taskList.Location = new System.Drawing.Point(6, 35);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(455, 71);
            this.taskList.TabIndex = 13;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.List;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tester name";
            // 
            // listTasksTesterName
            // 
            this.listTasksTesterName.Location = new System.Drawing.Point(98, 9);
            this.listTasksTesterName.Name = "listTasksTesterName";
            this.listTasksTesterName.Size = new System.Drawing.Size(111, 20);
            this.listTasksTesterName.TabIndex = 3;
            // 
            // ListTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 140);
            this.Controls.Add(this.panel1);
            this.Name = "ListTasksForm";
            this.Text = "List tasks by tester";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button listTasksBtn;
        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.TextBox listTasksTesterName;
    }
}