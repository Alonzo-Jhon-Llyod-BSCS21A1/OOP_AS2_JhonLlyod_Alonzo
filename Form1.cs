using System;
using System.Configuration;
using System.Text.Json;
using System.IO;

namespace Alonzo
{
    public partial class Form1 : Form
    {
        public interface IUsers
        {
            string username { get; }
            string password { get; }
        }

        class User : IUsers
        {
            public string username { get; set; }
            public string password { get; set; }

            public static User LoadFromJson(string filepath)
            {
                string Json = File.ReadAllText(filepath);
                return JsonSerializer.Deserialize<User>(Json);
            }
        }

        private User userFromJson;

        public Form1()
        {
            InitializeComponent();
            try
            {
                userFromJson = User.LoadFromJson("Data.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading JSON: JSON{ex.Message}");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            abc.Text = "";
            cba.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User person = new User();
            person.username = userFromJson.username;
            person.password = userFromJson.password;
            if (userBox.TextLength == 0 && passBox.TextLength > 0)
            {
                abc.Text = "Please Fill Up this Area";
                cba.Text = "";
            }

            else if (userBox.TextLength > 0 && passBox.TextLength == 0)
            {
                abc.Text = "";
                cba.Text = "Please Fill Up this Area";
            }
            else if (userBox.TextLength == 0 && passBox.TextLength == 0)
            {
                abc.Text = "Please Fill Up this Area";
                cba.Text = "Please Fill Up this Area";
            }
            else
            {
                if (userBox.Text != person.username)
                {
                    abc.Text = "Username does not Exist";
                    cba.Text = "";
                }
                else if (passBox.Text != person.password)
                {
                    abc.Text = "";
                    cba.Text = "Wrong Password";
                }
                else
                {
                    abc.Text = "";
                    cba.Text = "";
                    MessageBox.Show("Login Successful");
                }
            }
        } 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cba.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            abc.Text = "";
        }

    }
}
