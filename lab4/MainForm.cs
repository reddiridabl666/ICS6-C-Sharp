using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {

        public Tasks.Tracker tracker = new Tasks.Tracker();

        AddTesterForm testerForm;
        AssignTaskForm assignTaskForm;
        ChangeStatusForm changeStatusForm;
        AddTaskForm addTaskForm;
        ListTasksForm listTasksForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            taskList.Items.Clear();

            foreach (var pair in tracker.tasks)
            {
                taskList.Items.Add(pair.Value.ToString());
            }
        }

        private void addTesterBtn_Click(object sender, EventArgs e)
        {
            if (testerForm == null || testerForm.IsDisposed)
            {
                testerForm = new AddTesterForm(this);
                testerForm.Show();
            }
        }

        private void assignTaskBtn_Click(object sender, EventArgs e)
        {
            if (assignTaskForm == null || assignTaskForm.IsDisposed)
            {
                assignTaskForm = new AssignTaskForm(this);
                assignTaskForm.Show();
            }
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            if (addTaskForm == null || addTaskForm.IsDisposed)
            {
                addTaskForm = new AddTaskForm(this);
                addTaskForm.Show();
            }
        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            if (changeStatusForm == null || changeStatusForm.IsDisposed)
            {
                changeStatusForm = new ChangeStatusForm(this);
                changeStatusForm.Show();
            }
        }

        private void listTasksBtn_Click(object sender, EventArgs e)
        {
            if (listTasksForm == null || listTasksForm.IsDisposed)
            {
                listTasksForm = new ListTasksForm(this);
                listTasksForm.Show();
            }
        }
    }
}
