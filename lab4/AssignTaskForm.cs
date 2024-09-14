using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class AssignTaskForm : Form
    {
        MainForm form;

        public AssignTaskForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void assignTaskBtn_Click(object sender, EventArgs e)
        {
            if (assignTaskNameEdit.Text != "" && assignTaskTesterEdit.Text != "")
            {
                form.tracker.AssignTask(assignTaskNameEdit.Text, assignTaskTesterEdit.Text);
                form.refresh();

                assignTaskNameEdit.Clear();
                assignTaskTesterEdit.Clear();
            }
        }
    }
}
