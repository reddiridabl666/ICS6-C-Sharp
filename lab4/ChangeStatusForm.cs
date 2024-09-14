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
    public partial class ChangeStatusForm : Form
    {
        MainForm form;

        public ChangeStatusForm(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void changeStatusBtn_Click(object sender, EventArgs e)
        {
            if (taskStatusNameEdit.Text != "" && taskStatusEdit.Text != "")
            {
                var status = (Tasks.Status)Enum.Parse(typeof(Tasks.Status), taskStatusEdit.Text);

                form.tracker.SetStatus(taskStatusNameEdit.Text, status);
                form.refresh();

                taskStatusNameEdit.Clear();
            }
        }
    }
}
