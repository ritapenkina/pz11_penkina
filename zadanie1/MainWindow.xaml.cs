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

namespace pz11_penkina
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var cortege = (TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            SetCortege(cortege);
        }
        public void SetCortege((string a1, string a2) cortege)
        {
            Label1.Content = $"{cortege.a1}, {cortege.a2}";
        }
        private void SetCortege((string Text, int) cortege)
        {
            Label1.Content = $"{cortege.Item1}, {cortege.Item2}";
        }
    }

}
    
