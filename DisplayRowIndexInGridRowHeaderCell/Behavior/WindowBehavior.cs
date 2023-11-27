using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DisplayRowIndexInGridRowHeaderCell
{
    internal class WindowBehavior : Behavior<Window>
    {

        SfDataPager dataPager;
        SfDataGrid dataGrid;
        protected override void OnAttached()
        {
            base.OnAttached();
            var window = this.AssociatedObject as Window;
            dataGrid = window.FindName("dataGrid") as SfDataGrid;
            dataPager = window.FindName("dataPager") as SfDataPager;
            dataPager.PageIndexChanged += OnPageIndexChanged;
        }

        private void OnPageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            for (int i = 1; i < dataGrid.RowGenerator.Items.Count; i++)
            {
                var rowHeaderCell = ((dataGrid.RowGenerator.Items[i] as DataRow).VisibleColumns[0] as DataColumn).ColumnElement;
                (rowHeaderCell as GridRowHeaderCell).RowIndex = -1;
            }
        }

        protected override void OnDetaching()
        {
            dataPager.PageIndexChanged -= OnPageIndexChanged;
            base.OnDetaching();
        }
    }
}
