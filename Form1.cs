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

                // Username boşdursa
                if (username == "")
                {
                    MessageBox.Show("Username boş ola bilməz!");
                    textBox3.Focus();
                    return;
                }

                // Password boşdursa
                if (password == "")
                {
                    MessageBox.Show("Password boş ola bilməz!");
                    textBox4.Focus();
                    return;
                }

                // Confirm Password boşdursa
                if (confirmPassword == "")
                {
                    MessageBox.Show("Confirm Password boş ola bilməz!");
                    textBox5.Focus();
                    return;
                }

                // PASSWORD VƏ CONFIRM PASSWORD EYNİ DEYİLSƏ
                if (password != confirmPassword)
                {
                    MessageBox.Show(
                        "Password və Confirm Password eyni olmalıdır!",
                        "Xəta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    textBox5.Focus();
                    return;
                }

                // Username artıq varsa
                if (users.ContainsKey(username))
                {
                    MessageBox.Show(
                        "Bu username artıq qeydiyyatdan keçib!",
                        "Xəta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    textBox3.Focus();
                    return;
                }

                // Bütün yoxlamalar keçdisə qeydiyyat edilir
                users.Add(username, password);

                MessageBox.Show(
                    "Qeydiyyat uğurla tamamlandı!",
                    "Uğurlu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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
                textBox5.UseSystemPasswordChar = false;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

