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


namespace Calculus_Plus_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int?[] num=new int?[2];
        char[] opt = new char[] { '+', '-', '*' ,'/'};


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        { 
            Screen.Text += 0; 
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Screen.Text += 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) 
        {
            Screen.Text += 2;
        }
        private void ParseNum() 
        {
            for(int i = 0; i < num.Length; i++) 
            {
                if (num[i] == null)
                {
                    num[i] = Convert.ToInt32(Screen.Text);
                    break;
                }
            }
            
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Screen.Text += 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Screen.Text += 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Screen.Text += 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Screen.Text += 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Screen.Text += 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Screen.Text += 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) 
        {
            Screen.Text += 9;
        }

        private void Button_Click_Prim(object sender, RoutedEventArgs e) 
        {
            
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            ParseNum();
            Screen.Text += "+";
            

        }

        private void Button_Click_Sqrt(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            Screen.Text += "-";
        }

        private void Button_Click_Mul(object sender, RoutedEventArgs e)
        {
            Screen.Text += "*";
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            Screen.Text += "/";
        }

        private void Button_Click_Sign(object sender, RoutedEventArgs e)
        {
            // 
            Screen.Text += "-";
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            Screen.Text="";
        }

        private void Button_Click_Mod(object sender, RoutedEventArgs e)
        {
            Screen.Text += "%";
        }

        private void Button_Click_Pot(object sender, RoutedEventArgs e)
        {
            Screen.Text += "^";
        }
    }
}