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
    public partial class mainMinue : Form
    {
        // المتغيرات الثابتة للكائنات المستخدمة في التنقل
        static CreateProject createProject = new CreateProject();
        static toDoListForm toDoList = new toDoListForm();

        // خصائص المشروع الحالي
        prtopertis p = new prtopertis();

        // مصفوفة لتخزين أسماء المشاريع
        string[] pr;

        // كائنات للكتابة والقراءة من الملفات
        StreamWriter stremW;

        bool projectIsSelected;

        public mainMinue()
        {
            InitializeComponent();
        }

        // عند تحميل الواجهة - يقرأ المشاريع السابقة من الملف ويضيفها للقائمة
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

        // زر إنشاء مشروع - يخفي النافذة الحالية ويفتح نافذة إنشاء المشروع
        private void create_Click(object sender, EventArgs e)
        {
            createProject = new CreateProject();
            this.Hide();
            createProject.Show();
        }

        // حدث تغيير اختيار العنصر من القائمة - غير مستعمل حالياً
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        // زر فتح مشروع - يفتح المشروع المحدد في نافذة قائمة المهام
        private void open_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    p.nameOfProject = listBox1.GetItemText(listBox1.Items[i]);
                    toDoList.Show();
                    toDoList.Text = p.nameOfProject;
                    p.nameOfProject = toDoList.Text;
                    this.Hide();
                }
            }
        }

        // زر حذف مشروع - يحذف المشروع المحدد من القائمة
        private void delate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                     listBox1.Items.Remove(listBox1.Items[i]);
                }

                if (listBox1.Items.Count == 0)
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "MyProject.txt");
                    return;
                }
            }

            using(stremW = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "MyProject.txt"))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    MessageBox.Show(listBox1.GetItemText(listBox1.Items[i]));
                    stremW.WriteLine(listBox1.GetItemText(listBox1.Items[i]));
                }
            }
        }
    }
}