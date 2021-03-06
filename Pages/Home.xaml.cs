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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Controls.Primitives;

namespace NoteMAN
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        /*SqlConnection sqlCon = new SqlConnection(@"Data Source=ay9s1w0d;Initial Catalog=taskman_db;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;*/

        string[] files;

        public Home()
        {

            InitializeComponent();
            refreshList.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            noteList.MouseDoubleClick += new MouseButtonEventHandler(noteList_MouseDoubleClick);

        }

        private void AddNote(object sender, RoutedEventArgs e)
        {

        }

        private void EditNote(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveNote(object sender, RoutedEventArgs e)
        {
            try
            {
                //noteList.Items.Remove(noteList.SelectedIndex);
                var toDelete = noteList.SelectedItems;

                noteList.Items.Remove(toDelete);
                File.Delete("//my files//" + toDelete);




            }
            catch (Exception)
            {
                return;
            }
        }

        private void noteList_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void refresh(object sender, RoutedEventArgs e)
        {
            /*for (int i = 0; i < files.Length; i++)
            {
                noteList.Items.Add(files[i]);
            }*/

            /*noteList.Items.Clear();
            cmd = new SqlCommand();
            sqlCon.Open();
            cmd.Connection = sqlCon;
            cmd.CommandText = "SELECT * FROM note";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                noteList.Items.Add(dr["notename"]);
            }
            sqlCon.Close();*/
            noteList.Items.Clear();
            files = Directory.GetFiles("my files", "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                noteList.Items.Add(System.IO.Path.GetFileName(file));
                file_path.Text = System.IO.Path.GetDirectoryName(file);
            }
        }

        private void noteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            noteViewer win = new noteViewer();
            win.Show();
            win.noteTitle.Text = noteList.SelectedItem.ToString();
            //win.noteContent.Document = noteList.SelectedItem.;



            string fileName = @"my files\" + win.noteTitle.Text;

            TextRange range;

            FileStream fStream;


            if (File.Exists(fileName))
            {
                range = new TextRange(win.noteContent.Document.ContentStart, win.noteContent.Document.ContentEnd);

                fStream = new FileStream(fileName, FileMode.OpenOrCreate);

                range.Load(fStream, DataFormats.Text);

                fStream.Close();
            }
        }
    }
}
