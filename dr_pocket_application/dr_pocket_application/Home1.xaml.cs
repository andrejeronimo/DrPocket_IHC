using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Home1.xaml
    /// </summary>
    public partial class Home1 : Page
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void button_create_profile_Click(object sender, RoutedEventArgs e)
        {
            // View Create Profile Page
            CriarPerfil createProfilePage = new CriarPerfil();
            this.NavigationService.Navigate(createProfilePage);
        }

        private void button_profile1_Click(object sender, RoutedEventArgs e)
        {
            // View Profile 1 Page
            AlterarPerfil changeProfilePage = new AlterarPerfil();
            this.NavigationService.Navigate(changeProfilePage);
        }
    }
}
