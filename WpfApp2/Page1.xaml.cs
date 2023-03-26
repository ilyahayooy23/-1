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
using WpfApp2.testDataSet1TableAdapters;

namespace WpfApp2
{
    
    public partial class Page1 : Page
    {
        AccessoriesTableAdapter Accessories = new AccessoriesTableAdapter();
        public Page1()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Accessories.GetData();
        }
    }
}
