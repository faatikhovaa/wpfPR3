using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private int click = 0;
        private void back_Click(object sender, RoutedEventArgs e)
        {
            if(click== 0)
            {
                return;
            }
            else
            {
                click--;
                UnitTbl.Text = UnitsList[click];
                Refresh();

            }
                
        }

        private void vpered_Click(object sender, RoutedEventArgs e)
        {
            if (click == UnitsList.Count - 1)
            {
                return;
            }
            else
            {
                click++;
                UnitTbl.Text = UnitsList[click];
                Refresh();

            }
        }
    }
}
