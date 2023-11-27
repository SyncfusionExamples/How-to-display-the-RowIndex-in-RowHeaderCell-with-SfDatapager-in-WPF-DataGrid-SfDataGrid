using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DisplayRowIndexinRowheadercell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sfDataPager.PageIndexChanged += SfDataPager_PageIndexChanged;

        }

        private void SfDataPager_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            for (int i = 1; i < dataGrid.RowGenerator.Items.Count; i++)
            {
                var rowHeaderCell = ((dataGrid.RowGenerator.Items[i] as DataRow).VisibleColumns[0] as DataColumn).ColumnElement;
                (rowHeaderCell as GridRowHeaderCell).RowIndex = -1;
            }
        }
    }

    public class PageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var dataPager = values[2] as SfDataPager;

            if (dataPager.PageIndex == 0 || (int)values[0] == -1)
            {
                return values[0].ToString();
            }

            values[0] = (int)values[0] + (((dataPager.PageIndex + 1) - 1) * dataPager.PageSize);
            return values[0].ToString();

        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
