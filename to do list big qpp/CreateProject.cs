using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list_big_qpp
{
    public partial class CreateProject : Form
    {
        // المتغيرات العامة
        public string path;
        public string namePathe = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "pathetext.txt");
        public string nameOfProject;
        public bool projectIsCreated = false;

        // كائنات من كائنات أخرى
        mainMinue mainMinue = new mainMinue();
        prtopertis p = new prtopertis();

        public CreateProject()
        {
            InitializeComponent();
        }

        // دالة تحميل النموذج - تقوم بقراءة المسار المحفوظ إن وجد
        private void CreateProject_Load(object sender, EventArgs e)
        {
            if (File.Exists(namePathe))
            {
                using (StreamReader streamReader = new StreamReader(namePathe))
                {
                    path = streamReader.ReadLine();
                    textBox1.Text = path;
                }
            }
        }

        // دالة زر اختيار المسار - تفتح مستعرض المجلدات وتخزن المسار
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "Select the folder where you want to save the project";
            openFolder.ShowDialog();

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                path = openFolder.SelectedPath;

                using (StreamWriter writer = new StreamWriter(namePathe))
                {
                    writer.WriteLine(path);
                    textBox1.Text = path;
                }
            }
        }

        // دالة زر إنشاء المشروع - تتحقق من الاسم وتنشئ المجلد والملفات
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a project name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nameOfProject = textBox2.Text;

            if (CheckProjectName(nameOfProject, path))
            {
                MessageBox.Show("Project with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2.Clear();
            MessageBox.Show("Project created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateProjectFolder(nameOfProject, path);
            projectIsCreated = true;

            StreamWriter stremW = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "MyProject.txt", true);
            stremW.WriteLine(nameOfProject);
            stremW.Close();

            if (CheckProjectName(nameOfProject, path))
            {
                MessageBox.Show("Project folder created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            p.todDoListName = nameOfProject;
            p.pathOfProject = path;
            this.Close();
            mainMinue.Show();
        }

        // دالة إنشاء مجلد المشروع - تنشئ مجلد وملف نصي للمشروع
        public void CreateProjectFolder(string n, string p)
        {
            string projectPath = Path.Combine(p, n);
            Directory.CreateDirectory(projectPath);
            string projectFilePath = Path.Combine(projectPath, n + ".txt");

            using (StreamWriter writer = new StreamWriter(projectFilePath))
            {
                writer.WriteLine("Project Name: " + n);
            }
        }

        // دالة التحقق من اسم المشروع - تتأكد إذا المجلد موجود أم لا
        public bool CheckProjectName(string n, string p)
        {
            string projectPath = Path.Combine(p, n);
            return Directory.Exists(projectPath);
        }
    }
}