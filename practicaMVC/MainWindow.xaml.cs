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

namespace practicaMVC
{
 
    public partial class MainWindow : Window
    {
        private PracticaMVCControll PracticaMVCControll;
        public MainWindow()
        {
            InitializeComponent();
            PracticaMVCControll = new PracticaMVCControll(this);
            Calcular.Click += new RoutedEventHandler(PracticaMVCControll.buton_Click);
            Borrar.Click += new RoutedEventHandler(PracticaMVCControll.Borrar);
        }

       
    }
}
