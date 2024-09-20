namespace lab12
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.board = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.Location = new System.Drawing.Point(171, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ход крестиков";
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(419, 391);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Выход";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(210, 391);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(103, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Начать заново";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Visible = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // board
            // 
            this.board.AllowUserToAddRows = false;
            this.board.AllowUserToDeleteRows = false;
            this.board.AllowUserToResizeColumns = false;
            this.board.AllowUserToResizeRows = false;
            this.board.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.board.ColumnHeadersVisible = false;
            this.board.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.board.Location = new System.Drawing.Point(111, 71);
            this.board.Name = "board";
            this.board.ReadOnly = true;
            this.board.RowHeadersVisible = false;
            this.board.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.board.Size = new System.Drawing.Size(300, 300);
            this.board.TabIndex = 2;
            this.board.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.board_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.board);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Крестики-нолики";
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridView board;
    }
}

