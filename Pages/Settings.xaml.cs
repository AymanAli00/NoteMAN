using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace NoteMAN.Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=ay9s1w0d;Initial Catalog=taskman_db;Integrated Security=True");
        public Settings()
        {
            InitializeComponent();
            //bindData();
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            if(new_username.Text == "" || new_password.Password == "")
            {
                MessageBox.Show("Empty fields are not valid");
            }
            else
            {
               
                Random rd = new Random();
                int rand_num = rd.Next(1, 999);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO [user] (username, password)values('" + new_username.Text + "','" + new_password.Password + "')", sqlCon);

                sda.SelectCommand.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void EditUser(object sender, RoutedEventArgs e)
        {
            if (edit_username.Text == "" || edit_password.Password == "")
            {
                MessageBox.Show("Empty fields are not valid");
            }
            else
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 999);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE [user] SET username = '" + edit_username.Text + "', password = '" + edit_password.Password + "' WHERE username ='" + edit_username + "'", sqlCon);
                sda.SelectCommand.ExecuteNonQuery();
                sqlCon.Close();
                
            }
        }

        private void RemoveUser(object sender, RoutedEventArgs e)
        {
            if (del_username.Text == "")
            {
                MessageBox.Show("Empty fields are not valid");
            }
            else
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 999);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("delete from [user] where username ='" + del_username.Text + "'", sqlCon);
                sda.SelectCommand.ExecuteNonQuery();
                sqlCon.Close();

            }
        }

        /*private void bindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user]", sqlCon);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataView.DataContext = dt;
        }*/
    }
}
