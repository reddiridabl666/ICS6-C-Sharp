namespace lab4
{
    partial class ChangeStatusForm
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.taskStatusEdit = new System.Windows.Forms.ComboBox();
            this.taskStatusNameEdit = new System.Windows.Forms.TextBox();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(12, 12);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.taskStatusEdit);
            this.splitContainer3.Panel2.Controls.Add(this.taskStatusNameEdit);
            this.splitContainer3.Panel2.Controls.Add(this.changeStatusBtn);
            this.splitContainer3.Size = new System.Drawing.Size(222, 116);
            this.splitContainer3.SplitterDistance = 90;
            this.splitContainer3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status";
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
            this.changeStatusBtn.Text = "Change";
            this.changeStatusBtn.UseVisualStyleBackColor = true;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // ChangeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 138);
            this.Controls.Add(this.splitContainer3);
            this.Name = "ChangeStatusForm";
            this.Text = "Change task status";
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox taskStatusEdit;
        private System.Windows.Forms.TextBox taskStatusNameEdit;
        private System.Windows.Forms.Button changeStatusBtn;
    }
}