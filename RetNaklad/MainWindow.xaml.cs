using System.Windows;
using RetNaklad.ViewModel;
using System;
using ExtendedGrid.ExtendedGridControl;
using System.Data;
using System.Collections.ObjectModel;
using System.Windows.Data;
using ExtendedGrid.Microsoft.Windows.Controls;

namespace RetNaklad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
           // grid.Theme = ExtendedDataGrid.Themes.Office2007Silver;          
        }

        private void grid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void DG_Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }
    }    
}