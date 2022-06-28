using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NoteMAN
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=ay9s1w0d;Initial Catalog=taskman_db;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;


        
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Console.WriteLine(username.Text + " and " + password.Password);
                cmd = new SqlCommand();
                sqlCon.Open();
                cmd.Connection = sqlCon;
                cmd.CommandText = "SELECT * FROM [user] WHERE username='" + username.Text + "' AND password='" + password.Password + "'";
                dr = cmd.ExecuteReader();

                int i = 0;

                while (dr.Read())
                {
                    i++;
                }

                if (i == 1)
                {
                    this.Hide();
                    MainWindow win = new MainWindow();
                    win.Show();
                }
                else
                {
                    errText.Visibility = Visibility.Visible;
                    username.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    password.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));

                    errText.Content = "Invalid username or password!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
