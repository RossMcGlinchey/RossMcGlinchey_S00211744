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

namespace RossMcGlinchey_S00211744
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //allows interaction with the database
            RentalData db = new RentalData();

            //query to show properties in order of their price, lowest to highest
            var query = from p in db.Properties
                        orderby p.Price ascending
                        select p;

            //adds all data from the query list to this variable
            allProperties = query.ToList();

            //Displays the query data in the listbox
            lbxLocations.ItemsSource = allProperties;
        }

        private void lbxLocations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Determine what has been selected
            RentalProperty selected = lbxLocations.SelectedItem as RentalProperty;

            //Ensure it is not null
            if (selected != null)
            {
                //Update textblock with relevant description
                tblkDescription.Text = selected.Description;
            }
        }
    }
}
