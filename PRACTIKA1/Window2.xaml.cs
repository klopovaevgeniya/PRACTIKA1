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

namespace PRACTIKA1
{
    public partial class Window2 : Window
    {
        TEREMOKEntities3 context = new TEREMOKEntities3();
        public Window2()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = context.EMPLOYEE.ToList();
            BlinGrid.ItemsSource = context.BLINI.ToList();
            BuyerGrid.ItemsSource = context.BUYERS.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}