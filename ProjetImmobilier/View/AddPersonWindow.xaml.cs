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

namespace ProjetImmobilier.View
{
    /// <summary>
    /// Logique d'interaction pour addPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public AddPersonWindow(String n, String p)
        {
            InitializeComponent();
            this.DataContext = new ViewModel.AddPersonViewModel(n, p);
        }
    }
}
