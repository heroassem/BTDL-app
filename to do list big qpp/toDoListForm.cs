using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace to_do_list_big_qpp
{
    public partial class toDoListForm: Form
    {
        // المتغيرات الثابتة للكائنات المستخدمة في التنقل
        prtopertis p = new prtopertis();
        mainMinue mainMinue = new mainMinue();

        // المتغيرات العامة
        string nameOfTask;
        public string pathName;

        public toDoListForm()
        {
            InitializeComponent();
        }

        private void toDoListForm_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "pathetext.txt");
            string line = streamReader.ReadToEnd();
            p.pathOfProject = line.Trim();
            streamReader.Close();
            mainMinue.Close();
        }   

        private void add_Click(object sender, EventArgs e)
        {
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

        private void save_Click(object sender, EventArgs e)
        {
            p.nameOfProject = this.Text.Trim();
            string nameOfProject = (p.pathOfProject + @"\" + p.nameOfProject + @"\" + p.nameOfProject + ".txt");
            MessageBox.Show(nameOfProject);
            pathName = nameOfProject;

            using (StreamWriter streamWriter = new StreamWriter(nameOfProject))
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    streamWriter.WriteLine(checkedListBox1.Items[i].ToString() + ":" + checkedListBox1.GetItemChecked(i));
                }
            }
        }

        private void toDoListForm_Shown(object sender, EventArgs e)
        {
            p.nameOfProject = this.Text.Trim();
            string nameOfProject = (p.pathOfProject + @"\" + p.nameOfProject + @"\" + p.nameOfProject + ".txt");

            using (StreamReader sr = new StreamReader(nameOfProject))
            {
                string linel = sr.ReadToEnd();
                string[] lines = linel.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] part = lines[i].Split(':');

                    if (lines[i].Trim() != "")
                    {
                        checkedListBox1.Items.Add(part[0]);
                        checkedListBox1.SetItemChecked(i, Convert.ToBoolean(part[1]));
                    }
                }
            }
        }

        private void toDoListForm_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("your list is leave");
        }

        private void toDoListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                mainMinue.Close();
            }
        }
    }
}
