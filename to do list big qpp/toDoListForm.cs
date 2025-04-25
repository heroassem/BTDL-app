using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list_big_qpp
{
    public partial class toDoListForm: Form
    {
        string nameOfTask;

        public toDoListForm()
        {
            InitializeComponent();
        }

        private void toDoListForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == nameOfTask)
                {
                    MessageBox.Show("this item orady is here");
                    return;
                }
            }
            nameOfTask = NameTask.Text;
            checkedListBox1.Items.Add(nameOfTask);
            NameTask.Clear();
            NameTask.Focus();
        }

        private void rmov_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            { 
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }
    }
}
