using RetNaklad.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using ExtendedGrid.ExtendedGridControl;
using ExtendedGrid.Microsoft.Windows.Controls;

namespace RetNaklad.Helpers
{
    class Converters
    {
    }

    public class ConvertItemToIndex : IValueConverter
    {
        #region IValueConverter Members
        //Convert the Item to an Index
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {               
                var drv = (ProductItemViewModel)value;
                //Get the CollectionView from the DataGrid that is using the converter
                System.Windows.Controls.DataGrid dg = (System.Windows.Controls.DataGrid)Application.Current.MainWindow.FindName("grid");
                CollectionView cv = (CollectionView)dg.Items;
                //Get the index of the DataRowView from the CollectionView
                int rowindex = cv.IndexOf(drv) + 1;

                return rowindex.ToString();
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }
        //One way binding, so ConvertBack is not implemented
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
