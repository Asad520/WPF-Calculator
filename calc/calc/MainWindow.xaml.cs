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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pt = "";
        double n1 = 0;
        double n2 = 0;
        double n3;
        string op = "";
        double res = 0;
        string trig = "";
        string others = "";
        const double PI = 3.14;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 8;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 8;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 7;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 7;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 1;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 1;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 0;
                n3 = n1;
                text.Text = n1.ToString();
            }
            else
            {
                n2 = (n2 * 10) + 0;
                text.Text = n2.ToString();
                n3 = n1;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 2;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 2;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 3;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 3;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 4;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 4;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 5;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 5;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }


        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 6;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 6;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = (n1 * 10) + 9;
                text.Text = n1.ToString();
                n3 = n1;
            }
            else
            {
                n2 = (n2 * 10) + 9;
                text.Text = n2.ToString();
                n3 = n2;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click_Cl(object sender, RoutedEventArgs e)
        {
            n1 = 0;
            n2 = 0;
            n3 = 0;
            op = "";
            trig = "";
            others = "";
            text.Text = "0";
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            op = "+";
            text.Text = op;
            text.Text += "";
        }

        private void Button_Click_sub(object sender, RoutedEventArgs e)
        {
            op = "-";
            text.Text = op;
            text.Text += "";
        }

        private void Button_Click_mul(object sender, RoutedEventArgs e)
        {
            op = "*";
            text.Text = op;
            text.Text += "";
        }

        private void Button_Click_div(object sender, RoutedEventArgs e)
        {
            op = "/";
            text.Text = op;
            text.Text += "";
        }

        private void Button_Click_sin(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Sin";
                text.Text += "Sin(";
            }
        }

        private void Button_Click_cos(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Cos";
                text.Text += "Cos(";
            }
        }

        private void Button_Click_tan(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Tan";
                text.Text += "Tan(";
            }
        }
        private void Button_Click_csc(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Csc";
                text.Text += "Csc(";
            }
        }

        private void Button_Click_sec(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Sec";
                text.Text += "Sec(";
            }
        }
        private void Button_Click_cot(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Cot";
                text.Text += "Cot(";
            }
        }

        private void Button_Click_asin(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Asin";
                text.Text += "Asin(";
            }

        }

        private void Button_Click_acos(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Acos";
                text.Text += "Acos(";
            }
        }

        private void Button_Click_atan(object sender, RoutedEventArgs e)
        {
            if (trig == "")
            {
                text.Text = "";
                trig = "Atan";
                text.Text += "Atan(";
            }
        }

        private void Button_Click_sqrt(object sender, RoutedEventArgs e)
        {
            if (others == "")
            {
                text.Text = "";
                others = "Sqrt";
                text.Text += "Sqrt(";
            }
        }

        private void Button_Click_mod(object sender, RoutedEventArgs e)
        {
            if (others == "")
            {
                text.Text = "";
                others = "mod";
                text.Text += "mod(";
            }
        }

        private void Button_Click_sqr(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                text.Text = n3 + "^2";
                others = "sq";
            }
        }
        private void Button_Click_cube(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                text.Text = n3 + "^3";
                others = "cube";
            }
        }

        private void Button_Click_xn(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                op = "pow";
                text.Text = n1 + "^";
            }
        }

        private void Button_Click_pi(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                n1 = PI;
            }
            else
            {
                n2 = PI;
            }
            text.Text = PI.ToString();
        }

        private void Button_Click_log(object sender, RoutedEventArgs e)
        {
            others = "log";
            text.Text = "log(";
        }

        private void Button_Click_loga(object sender, RoutedEventArgs e)
        {
            op = "Loga";
            text.Text = "LOG(";
        }

        private void Button_Click_twoP(object sender, RoutedEventArgs e)
        {
            others = "2^";
            text.Text = "2^(";
        }

        private void Button_Click_ep(object sender, RoutedEventArgs e)
        {
            others = "e^";
            text.Text = "e^(";
        }

        private void Button_Click_bsp(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
            }
            if (op != "" || trig != "" || others != "")
            {
                op = "";
                trig = "";
                others="";
            }
            else if (n1 != 0)
            {
                n1 = (int) n1 / 10;
            }
            else if (n2 != 0)
            {
                n2 = (int)n2 / 10;
            }
        }

        private void Button_Click_fact(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                others = "fact";
                text.Text = n1 + "!";
            }
        }

        private void Button_Click_reci(object sender, RoutedEventArgs e)
        {
            others = "reciprocal";
            text.Text = "1/";
        }

        private void Button_Click_floor(object sender, RoutedEventArgs e)
        {
            others = "floor";
            text.Text = "floor(";
        }

        private void Button_Click_ceil(object sender, RoutedEventArgs e)
        {
            others = "ceil";
            text.Text = "ceil(";
        }

        private void Button_Click_cls(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Button_Click_equ(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "+":      
                    text.Text = (n1+n2).ToString();
                    n1 += n2;
                    n2  = 0;
                    op = "";
                    break;
                case "-":
                    text.Text = (n1 - n2).ToString();
                    n1 -= n2;
                    n2  = 0;
                    op = "";
                    break;
                case "*":
                    text.Text = (n1 * n2).ToString();
                    n1 *= n2;
                    n2  = 0;
                    op = "";
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        text.Text = (n1 / n2).ToString();
                        n1 /= n2;
                        n2 = 0;
                        op = "";
                    }
                    else
                    {
                        text.Text = "Dividing By Zero Is Undefined!";
                    }

                    break;
                case "pow":
                    double ans = 1;
                    for (int i = 0; i < n2; i++)
                    {
                        ans = ans * n1;
                    }
                    text.Text = ans.ToString();
                    n1 =ans;
                    n2  = 0;
                    op = "";
                    break;
                case "Loga":
                    text.Text = Math.Log(n1, n2).ToString();
                    n1 = Math.Log(n1, n2);
                    n2  = 0;
                    op = "";
                    break;
                default:
                    break;
            }
            switch (trig)
            {
                case "Sin":
                    text.Text = Math.Sin(n3).ToString();
                    n1 = Math.Sin(n3);
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Cos":
                    text.Text = Math.Cos(n3).ToString();
                    n1 = Math.Round(Math.Cos(n3));
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Tan":
                    text.Text = Math.Tan(n3).ToString();
                    n1 =Math.Tan(n3);
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Csc":
                    double ans = (1 / Math.Sin(n3));
                    text.Text = ans.ToString();
                    n1 = ans;
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Sec":
                    ans = 1 / Math.Cos(n3);
                    text.Text = ans.ToString();
                    n1 = ans;
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Cot":
                    ans = 1 / Math.Tan(n3);
                    text.Text = ans.ToString();
                    n1 = Math.Round(1 / Math.Tan(n3));
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Asin":
                    double mycalcInRadians = Math.Asin(n3);
                    ans = mycalcInRadians * 180 / Math.PI;
                    text.Text = ans.ToString();
                    n1 = ans;
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Acos":
                    mycalcInRadians = Math.Acos(n3);
                    ans = mycalcInRadians * 180 / Math.PI;
                    text.Text = ans.ToString();
                    n1 = ans;
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;
                case "Atan":
                    mycalcInRadians = Math.Atan(n3);
                    ans = mycalcInRadians * 180 / Math.PI;
                    text.Text = ans.ToString();
                    n1 = ans;
                    n2  = 0;
                    n3 = 0;
                    trig = "";
                    break;

                default:
                    break;
            }
            switch (others)
            {
                case "Sqrt":
                    text.Text = Math.Sqrt(n3).ToString();
                    n1=Math.Sqrt(n3);
                    n2=0;
                    n3=0;
                    others = "";
                    break;
                case "mod":
                    if (n3 >= 0)
                    {
                        text.Text = n3.ToString();
                    }
                    else
                    {
                        n3 *= -1;
                        text.Text = n3.ToString();
                    }
                    n1 = n3;
                    n2=0;
                    n3=0;
                    others = "";
                    break;
                case "sq":
                    text.Text = (n3 * n3).ToString();
                    n1=n3*n3;
                    n1 = n2 = n3 = 0;
                    others = "";
                    break;
                case "cube":
                    text.Text = (n3 *n3* n3).ToString();
                    n1 = n3 * n3 * n3;
                    n1 = n2 = n3 = 0;
                    others = "";
                    break;
                case "log":
                    text.Text = Math.Log10(n3).ToString();
                    n1=Math.Log(n3);
                    n2 = n3 = 0;
                    others = "";
                    break;
                case "2^":
                    double d = 1;
                    for (int i = 0; i < n1; i++)
                    {
                        d = d * 2;
                    }
                    text.Text = d.ToString();
                    n1=d;
                    n2=0;
                    n3=0;
                    others = "";
                    break;
                case "e^":
                    double u = 1;
                    for (int i = 0; i < n1; i++)
                    {
                        u = u * 2.71828;
                    }
                    text.Text = u.ToString();
                    n1=u;
                    n2=0;
                    n3=0;
                    others="";
                    break;
                case "fact":
                    double fact = 1;
                    for (double i = n1; i > 0; i--)
                    {
                        fact = fact * n1;
                        n1--;
                    }
                    text.Text = fact.ToString();
                    n1=fact;
                    n2 = 0;
                    n3 = 0;
                    others = "";
                    break;
                case "reciprocal":
                    text.Text = (1 / n1).ToString();
                    n1=(1/n1);
                    n2 = n3 = 0;
                    others = "";
                    break;
                case "floor":
                    text.Text = Math.Floor(n1).ToString();
                    n1 = Math.Floor(n1);
                    n2 = n3 = 0;
                    others = "";
                    break;
                case "ceil":
                    text.Text = Math.Ceiling(n1).ToString();
                    n1 = Math.Ceiling(n1);
                    n2 = n3 = 0;
                    others = "";
                    break;
                default:
                    break;
            }
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
