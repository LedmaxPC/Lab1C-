using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopApp2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                string username = textBox3.Text.Trim();
                string password = textBox4.Text;
                string confirmPassword = textBox5.Text;
            
                if (username == "")
                {
                    MessageBox.Show("Username boş ola bilməz!");
                    textBox3.Focus();
                    return;
                }

                if (password == "")
                {
                    MessageBox.Show("Password boş ola bilməz!");
                    textBox4.Focus();
                    return;
                }

                if (confirmPassword == "")
                {
                    MessageBox.Show("Confirm Password boş ola bilməz!");
                    textBox5.Focus();
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password və Confirm Password eyni olmalıdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    textBox5.Focus();
                    return;
                }

                if (users.ContainsKey(username))
                {
                    MessageBox.Show( "Bu username artıq qeydiyyatdan keçib!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Focus();
                    return;
                }

                users.Add(username, password);

                MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox3.Focus();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (username == "")
            {
                MessageBox.Show("Username boş ola bilməz!", "Xəta" , MessageBoxButtons.OK, MessageBoxIcon.Error );
                textBox1.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password boş ola bilməz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            if (!users.ContainsKey(username))
            {
                MessageBox.Show("Bu username qeydiyyatdan keçməyib!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            
            if (users[username] != password)
            {
                MessageBox.Show("Password səhvdir!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error );
                textBox2.Focus();
                return;
            }

            MessageBox.Show("Giriş uğurludur!\nXoş gəlmisiniz, " + username + "!", "Uğurlu giriş", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
                textBox5.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://aka.ms/dotnet-get-started-desktop"
            );
        }


    }
}

