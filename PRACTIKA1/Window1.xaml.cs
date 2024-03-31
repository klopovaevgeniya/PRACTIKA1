using PRACTIKA1.TEREMOKDataSetTableAdapters;
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
using System.Windows.Shapes;
using PRACTIKA1.TEREMOKDataSetTableAdapters;

namespace PRACTIKA1
{
    public partial class Window1 : Window
    {
        EMPLOYEETableAdapter employee = new EMPLOYEETableAdapter();
        BLINITableAdapter blin = new BLINITableAdapter();
        BUYERSTableAdapter buyer = new BUYERSTableAdapter();
        public Window1()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = employee.GetData();
            BlinGrid.ItemsSource = blin.GetData();
            BuyerGrid.ItemsSource = buyer.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

    }
}
