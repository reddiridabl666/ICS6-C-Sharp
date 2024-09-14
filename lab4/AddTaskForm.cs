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
    public partial class AddTaskForm : Form
    {
        MainForm form;

        public AddTaskForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void addTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskNameEdit.Text != "")
            {
                var task = new Tasks.Task(
                    taskNameEdit.Text,
                    taskDescEdit.Text,
                    Tasks.Status.Backlog,
                    taskDueToEdit.Value
                );

                if (form.tracker.AddTask(task))
                {
                    form.taskList.Items.Add(task.ToString());
                }

                taskNameEdit.Clear();
                taskDescEdit.Clear();
            }
        }
    }
}
