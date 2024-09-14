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
    public partial class AddTesterForm : Form
    {
        MainForm form;

        public AddTesterForm(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void addTesterBtn_Click(object sender, EventArgs e)
        {
            if (testerNameEdit.Text != "")
            {
                if (form.tracker.AddTester(new Tasks.Tester(testerNameEdit.Text)))
                {
                    form.testerList.Items.Add(testerNameEdit.Text);
                }

                testerNameEdit.Clear();
            }
        }
    }
}
