using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFrom("C:/Users/e.koshmak/source/repos/C-adv-hw6/hw1/bin/Debug/hw1.exe");
                MessageBox.Show("Сборка hw1 - успешно загружена.");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetInfoAboutAllTypes(assembly);
        }

        public void GetInfoAboutAllTypes(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();

            textBox1.Clear();
            foreach (Type type in types)
            {
                if (type.IsClass == true)
                {
                    textBox1.Text += String.Format("Class {0}", type.Name) + Environment.NewLine;
                    GetMethodsParams(assembly, Convert.ToString(type.FullName));
                }
                if (type.IsEnum == true)
                {
                    textBox1.Text += String.Format("Enum {0}", type.Name) + Environment.NewLine;
                }

            }
        }

        public void GetMethodsParams(Assembly assembly, string @string)
        {
            Type type = assembly.GetType(@string);
            MemberInfo[] membersInfo = type.GetMembers();

            foreach (MemberInfo memberInfo in membersInfo)
            {
                textBox1.Text += String.Format("\t{0}:  {1}", memberInfo.MemberType, memberInfo) + Environment.NewLine;
            }
        }
    }
}
