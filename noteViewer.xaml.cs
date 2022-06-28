using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for noteViewer.xaml
    /// </summary>
    public partial class noteViewer : Window
    {
        public noteViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Interaction logic for AddNote.xaml
        /// </summary>
        TextRange range;
        FileStream fStream;




        // Handle "Save RichTextBox Content" button click.
        void SaveRTBContent(Object sender, RoutedEventArgs args)
        {

            // Send an arbitrary URL and file name string specifying
            // the location to save the XAML in.
            //SaveXamlPackage("C:\\test.xaml");

            range = new TextRange(noteContent.Document.ContentStart, noteContent.Document.ContentEnd);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = noteTitle.Text;
            saveFileDialog.Filter = " RichText file (*.rtf)|*.rtf | Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, range.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Filename cannot be empty or not accepted characters", null, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        // Handle "Load RichTextBox Content" button click.
        void LoadRTBContent(Object sender, RoutedEventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "@%userprofile%\\Documents";
            openFileDialog.Filter = " RichText File (*.rtf)|*.rtf | Text File (*.txt)|*.txt | All Files (*.*)|*.*";
            //openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
                // noteContent.Text = File.ReadAllText(openFileDialog.FileName);
                LoadXamlPackage(openFileDialog.FileName);
        }

        // Handle "Print RichTextBox Content" button click.
        void PrintRTBContent(Object sender, RoutedEventArgs args)
        {
            PrintCommand();
        }

        // Save XAML in RichTextBox to a file specified by _fileName
        void SaveXamlPackage(string _fileName)
        {
            range = new TextRange(noteContent.Document.ContentStart, noteContent.Document.ContentEnd);
            try
            {
                fStream = new FileStream(_fileName, FileMode.Create);
                range.Save(fStream, DataFormats.XamlPackage);
                fStream.Close();
            }
            catch (Exception)
            {
                /* if(_fileName.Length > 0)
                 {

                 }*/

                MessageBox.Show("Filename cannot be empty", null, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        // Load XAML into RichTextBox from a file specified by _fileName
        void LoadXamlPackage(string _fileName)
        {
            if (File.Exists(_fileName))
            {
                range = new TextRange(noteContent.Document.ContentStart, noteContent.Document.ContentEnd);
                fStream = new FileStream(_fileName, FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.Rtf);
                fStream.Close();
            }
        }

        // Print RichTextBox content
        private void PrintCommand()
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                //use either one of the below
                // print as paginator or visual
                //pd.PrintVisual(noteContent as Visual, "printing as visual");
                pd.PrintDocument(((IDocumentPaginatorSource)noteContent.Document).DocumentPaginator, "printing as paginator");
            }
        }
    }
}
