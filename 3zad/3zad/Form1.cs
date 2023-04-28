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
using System.Collections;

namespace _3zad
{
    public partial class Form1 : Form
    {
        private ArrayList students = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            fromfile();
        }
        private void fromfile()
        {
            if (File.Exists("student.txt"))
            {
                var lines = File.ReadAllLines("student.txt");
                foreach (var line in lines)
                {
                    var a = line.Split(' ');
                    if (a.Length == 4 && DateTime.TryParse(a[2], out DateTime dateOfBirth))
                    {
                        var student = new Student
                        {
                            FirstName = a[0],
                            LastName = a[1],
                            DateOfBirth = dateOfBirth,
                            PhoneNumber = a[3]
                        };
                        students.Add(student);
                    }
                }
                listBox1.DataSource = students;
            }
        }
        private void addfile()
        {
            var lines = students.Cast<Student>().Select(s => $"{s.FirstName} {s.LastName} {s.DateOfBirth.ToShortDateString()} {s.PhoneNumber}");
            File.WriteAllLines("student.txt", lines);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButtonk(object sender, EventArgs e)
        {
            var student = new Student
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                DateOfBirth = dateTimePicker1.Value,
                PhoneNumber = textBox3.Text
            };

            students.Add((object)student);
            addfile();
            listBox1.DataSource = null;
            listBox1.DataSource = students;
        }

        private void Delbuttonk(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                students.Remove(listBox1.SelectedItem);
                addfile();
                listBox1.DataSource = null;
                listBox1.DataSource = students;
            }
        }
       

        private void FindButton(object sender, EventArgs e)
        {
            var crit = textBox4.Text.ToLower();

            if (!string.IsNullOrWhiteSpace(crit))
            {
                var poisk = students.Cast<Student>().Where(s => s.FirstName.ToLower().Contains(crit) ||
                                                             s.LastName.ToLower().Contains(crit) ||
                                                             s.PhoneNumber.ToLower().Contains(crit));

                listBox1.DataSource = null;
                listBox1.DataSource = poisk.ToList();
            }
        }

        private void SortName(object sender, EventArgs e)
        {
            students.Sort(new StudentComparerByName());
            addfile();
            listBox1.DataSource = null;
            listBox1.DataSource = students;
        }

        private void SortDate(object sender, EventArgs e)
        {

           
        }

        private void Sbros(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Clear();
            listBox1.DataSource = null;
            listBox1.DataSource = students;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
