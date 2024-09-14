namespace lab4
{
    partial class AddTesterForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.testerLabel = new System.Windows.Forms.Label();
            this.testerNameEdit = new System.Windows.Forms.TextBox();
            this.addTesterBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.testerLabel);
            this.flowLayoutPanel1.Controls.Add(this.testerNameEdit);
            this.flowLayoutPanel1.Controls.Add(this.addTesterBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 31);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // testerLabel
            // 
            this.testerLabel.AutoSize = true;
            this.testerLabel.Location = new System.Drawing.Point(3, 0);
            this.testerLabel.Name = "testerLabel";
            this.testerLabel.Size = new System.Drawing.Size(35, 13);
            this.testerLabel.TabIndex = 2;
            this.testerLabel.Text = "Name";
            // 
            // testerNameEdit
            // 
            this.testerNameEdit.Location = new System.Drawing.Point(44, 3);
            this.testerNameEdit.Name = "testerNameEdit";
            this.testerNameEdit.Size = new System.Drawing.Size(102, 20);
            this.testerNameEdit.TabIndex = 0;
            // 
            // addTesterBtn
            // 
            this.addTesterBtn.Location = new System.Drawing.Point(152, 3);
            this.addTesterBtn.Name = "addTesterBtn";
            this.addTesterBtn.Size = new System.Drawing.Size(75, 23);
            this.addTesterBtn.TabIndex = 1;
            this.addTesterBtn.Text = "Add Tester";
            this.addTesterBtn.UseVisualStyleBackColor = true;
            this.addTesterBtn.Click += new System.EventHandler(this.addTesterBtn_Click);
            // 
            // AddTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 54);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddTesterForm";
            this.Text = "Add tester";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label testerLabel;
        private System.Windows.Forms.TextBox testerNameEdit;
        private System.Windows.Forms.Button addTesterBtn;
    }
}