using Syncfusion.UI.Xaml.Controls.DataPager;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DisplayRowIndexInGridRowHeaderCell
{
    public class RowIndexConverter : IMultiValueConverter
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
