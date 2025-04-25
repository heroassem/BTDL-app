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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace to_do_list_big_qpp
{
    public partial class mainMinue: Form
    {
        static CreateProject createProject = new CreateProject();
        static toDoListForm toDoList = new toDoListForm();

        prtopertis p = new prtopertis();

        public mainMinue()
        {
            InitializeComponent();
        }

        private void mainMinue_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "MyProject.txt");
            string line = streamReader.ReadToEnd();
            string[] lines = line.Split('\n');
            streamReader.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim() != "")
                {
                    listBox1.Items.Add(lines[i]);
                }
            }
        }   

        private void create_Click(object sender, EventArgs e)
        { 
            createProject = new CreateProject();
            this.Hide();
            createProject.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void open_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if(listBox1.GetSelected(i))
                {
                    p.nameOfProject = listBox1.GetItemText(listBox1.Items[i]);
                    toDoList.Show();
                    toDoList.Text = p.nameOfProject;
                }
            }

/*            if(toDoList.IsDisposed)
            {
                return;
            }*/
        }
    }
}
