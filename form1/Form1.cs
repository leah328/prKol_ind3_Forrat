using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace адрес
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 1;
        ArrayList al = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            n = 1;
            if (new FileInfo("sd.txt").Length != 0)
            {
                StreamReader sr = File.OpenText("sd.txt");
                al.Clear();
                comboBox1.Items.Clear();
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(',');
                    Addres a = new Addres();
                    a.State = s[0];
                    a.City = s[1];
                    a.Street = s[2];
                    a.Code = s[3];                            
                        listBox1.Items.Add(a.Getinfo());
                        al.Add(a);
                        comboBox1.Items.Add(n);
                    n++;
                }
                sr.Close();
            }
            else
            {
                try
                {
                    Addres a1 = new Addres();
                    a1.State = textBox1.Text;
                    a1.City = textBox2.Text;
                    a1.Street = textBox3.Text;
                    a1.Code = textBox4.Text;  
                        listBox1.Items.Add(a1.Getinfo());
                        comboBox1.Items.Add(n);
                        al.Add(a1);
                        n++;
                        StreamWriter sw = File.AppendText("sd.txt");
                        sw.WriteLine(a1.Getinfo());
                        sw.Close();
                   
                }
                catch (FormatException)
                {
                    MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            al.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            StreamWriter sw = File.CreateText("sd.txt");
            for (int i = 0; i < al.Count; i++)
            {
                Addres a2 = (Addres)al[i];
                sw.WriteLine(a2.Getinfo());
            }
            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Addres a1 = (Addres)al[comboBox1.SelectedIndex];
                a1.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                al[comboBox1.SelectedIndex] = a1;
                StreamWriter sw = File.CreateText("sd.txt");
                for (int i = 0; i < al.Count; i++)
                {
                    Addres a2 = (Addres)al[i];
                    sw.WriteLine(a2.Getinfo());
                }
                sw.Close();
            }
            catch (FormatException) { MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Addres a1 = new Addres();
                a1.State = textBox1.Text;
                a1.City = textBox2.Text;
                a1.Street = textBox3.Text;
                a1.Code = textBox4.Text;
                    listBox1.Items.Add(a1.Getinfo());
                    comboBox1.Items.Add(n);
                    al.Add(a1);
                    n++;
                    StreamWriter sw = File.CreateText("sd.txt");
                    for (int i = 0; i < al.Count; i++)
                    {
                        Addres a2 = (Addres)al[i];
                        sw.WriteLine(a2.Getinfo());
                    }
                    sw.Close();
              
            }
            catch (FormatException)
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
