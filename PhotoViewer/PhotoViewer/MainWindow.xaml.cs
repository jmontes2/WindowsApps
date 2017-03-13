// PhotoViewer - Final Project
// Jorge Montes - 3/7/2017
// Creating Client Applications in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhotoViewer
{
    /// <summary>
    /// PhotoViewer class - Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhotographList photographList = new PhotographList();
        DisplayList displayList = new DisplayList();
        public MainWindow()
        {
            InitializeComponent();

            // Build initial display list with full photographList contents
            foreach (Photograph ph in photographList)
            {
                displayList.AddToDisplay(ph.Title, ph.DateTaken, ph.Description, ph.ArtistName,
                    ph.Keywords, ph.FileLocation);
            }
        }

    private void Photograph_Loaded(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Calls method to refresh the displayList object.
            /// </summary>
            refreshBrowseList();
        }

        private void dataGrid_Photo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /// <summary>
            /// Used to display the corresponding photograph and text boxes
            /// when a photograph in the displayList is selected.
            /// </summary>
            int index = dataGrid_Photo.SelectedIndex;
            if (index < 0)
                index = 0;
            Photograph ph = displayList[index];
            
            // Display image
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@ph.FileLocation);
            bitmap.EndInit();
            image_Photo.Stretch = Stretch.UniformToFill;
            image_Photo.Source = bitmap;

            // Populate textboxes
            textBox_title.Text = ph.Title.ToString();
            textBox_dateTaken.Text = ph.DateTaken.ToShortDateString();
            textBox_dateAdded.Text = ph.DateAdded.ToShortDateString();
            textBox_description.Text = ph.Description.ToString();
            textBox_artistName.Text = ph.ArtistName.ToString();
        }

        private void button_Upd_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Used to add a photograph.  Launches dialog box to enter photograph information.
            /// </summary>
            EditPhotograph editPh = new EditPhotograph();
            bool action = (bool) editPh.ShowDialog();
            if (action == true)
            {
                // Add photograph to main list
                photographList.AddPhotograph(editPh.textBox_title.Text,
                    DateTime.Parse(editPh.textBox_dateTaken.Text), editPh.textBox_description.Text,
                    editPh.textBox_artistName.Text, editPh.textBox_keywords.Text,
                    editPh.textBox_fileLocation.Text);
                // Add photograph to display list
                displayList.AddToDisplay(editPh.textBox_title.Text,
                    DateTime.Parse(editPh.textBox_dateTaken.Text), editPh.textBox_description.Text,
                    editPh.textBox_artistName.Text, editPh.textBox_keywords.Text,
                    editPh.textBox_fileLocation.Text);
                // Update original photograph object
                refreshBrowseList();
            }
        }
        public void refreshBrowseList()
        {
            /// <summary>
            /// Refreshes displayList (photograph object) - We set it to null and back to source,
            /// update a header, and hide unneeded columns.
            /// This method is called from several places as needed.
            /// </summary>
            dataGrid_Photo.ItemsSource = null;
            dataGrid_Photo.ItemsSource = displayList;
            dataGrid_Photo.Columns[1].Visibility = Visibility.Collapsed;
            dataGrid_Photo.Columns[2].Header = "Date Taken";
            dataGrid_Photo.Columns[3].Visibility = Visibility.Collapsed;
            dataGrid_Photo.Columns[5].Visibility = Visibility.Collapsed;
            dataGrid_Photo.Columns[6].Visibility = Visibility.Collapsed;
            dataGrid_Photo.Columns[7].Visibility = Visibility.Collapsed;
            dataGrid_Photo.IsReadOnly = true;
        }

        private void button_GO_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Search logic - runs when clicking th GO! button
            /// We clear the displayList object, then split the search contents and
            /// go through each one, looking to see if they exist in the photographList.
            /// If they exist, we add them to the displayList.
            /// </summary>
            displayList.Clear();
            String[] searchlist = textBox_Search.Text.Split(',');
            string resultsList = "";
            foreach (string s in searchlist)
            {
                // We convert search items and photograph information to caps to make search non-case sensitive
                string searchItem = s.ToUpper();
                foreach (Photograph ph in photographList)
                {
                    if (ph.Title.ToUpper().Contains(searchItem) || ph.ArtistName.ToUpper().Contains(searchItem) ||
                        ph.Description.ToUpper().Contains(searchItem) || ph.Keywords.ToUpper().Contains(searchItem))
                    {
                        // Create results list (non-duplicate Titles)
                        if (!resultsList.Contains(ph.Title))
                        {
                            if (resultsList == "")
                            {
                                resultsList = ph.Title;
                            }
                            else
                            {
                                resultsList += "," + ph.Title;
                            }
                        }
                    }
                }
            }
            // Add photograph(s) to display list
            String[] results = resultsList.Split(',');
            foreach (string result in results)
            {
                foreach (Photograph ph in photographList)
                {
                    if (ph.Title.Contains(result))
                        displayList.AddToDisplay(ph.Title, ph.DateTaken, ph.Description, ph.ArtistName,
                        ph.Keywords, ph.FileLocation);
                }
            }
                refreshBrowseList();
        }
    }
}
