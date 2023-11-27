using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRowIndexinRowheadercell
{
    public class Order : INotifyPropertyChanged
    {


        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public Order()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1011, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1012, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1013, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1014, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1015, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1016, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1017, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1018, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1019, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1020, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));


        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

    }
}
