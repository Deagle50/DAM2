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

namespace EjemploEventos_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Blanco");
            e.Handled = true;
     
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Verde");
            
        }

        private void Grid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Rojo");
        
        }

        private void Grid_MouseDown_2(object sender, MouseButtonEventArgs e)
        {  
            MessageBox.Show("Principal");
          
        }

        private void Grid_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Blanco");
           
        }

        private void Grid_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Principal");
           
        }

        private void Grid_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Rojo");
            
        }

        private void Grid_PreviewMouseDown_4(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Verde");
           
        }
    }
}
