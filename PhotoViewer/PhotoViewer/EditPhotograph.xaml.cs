// PhotoViewer - Final Project
// Jorge Montes - 3/7/2017
// Creating Client Applications in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhotoViewer
{
    public partial class EditPhotograph : Window
    {
        /// <summary>
        /// EditPhotograph class - used to allow user to enter new photographs
        /// </summary>
        public EditPhotograph()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void button_Select_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Method to select photograph file location by using OpenFileDialog
            /// </summary>
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.JPG)|*.JPG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                textBox_fileLocation.Text = ofd.FileName;
            }
        }
    }
}
