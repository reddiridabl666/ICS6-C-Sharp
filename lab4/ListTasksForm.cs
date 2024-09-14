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
    public partial class ListTasksForm : Form
    {
        MainForm form;

        public ListTasksForm(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void listTasksBtn_Click(object sender, EventArgs e)
        {
            if (listTasksTesterName.Text != "")
            {
                taskList.Items.Clear();

                var tasks = form.tracker.List(listTasksTesterName.Text);
                foreach (var task in tasks)
                {
                    taskList.Items.Add(task.ToString());
                }

                listTasksTesterName.Clear();
            }
        }
    }
}
