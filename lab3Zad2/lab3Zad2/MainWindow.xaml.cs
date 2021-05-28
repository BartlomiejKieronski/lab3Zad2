using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace lab3Zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lWz.Content = "Podaj wzrost w calach";
            lWa.Content = "Podaj wagę w funtach";


        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            lWz.Content = "Podaj wzrost w metrach";
            lWa.Content = "Podaj wagę w kilogramach";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (chBBmi.IsChecked ==true && chBWI.IsChecked==false)
            {

                if (jSi.IsChecked==true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = y / (x * x);
                    if (z<18.5)
                    {
                        lWy.Content = "Twoje Bmi to: " +z;
                        MessageBox.Show("Masz niedowagę");
                    }
                    else if (z > 18.5 && z<25)
                    {
                        lWy.Content = "Twoje Bmi To: "+z;

                    }
                    else if(z >25)
                    {
                        lWy.Content = "Twoje Bmi to: " + z;
                        MessageBox.Show("Masz nadwagę");

                    }
                    else
                    {
                        lWy.Content = "błąd danych";
                    }
                }
                else if (jAm.IsChecked==true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = (y / (x * x))*703;
                    if (z < 18.5)
                    {
                        lWy.Content = "Twoje Bmi to: " + z;
                        MessageBox.Show("Masz niedowagę");
                    }
                    else if (z > 18.5 && z < 25)
                    {
                        lWy.Content = "Twoje Bmi To: " + z;

                    }
                    else if (z > 25)
                    {
                        lWy.Content = "Twoje Bmi to: " + z;
                        MessageBox.Show("Masz nadwagę");

                    }
                    else
                    {
                        lWy.Content = "błąd danych";
                    }
                }
                else
                {
                    lWy.Content = "błąd danych";
                }

            }
            else if (chBBmi.IsChecked == false && chBWI.IsChecked == true)
            {
                if (jSi.IsChecked == true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = y / (x * x);
                    float a = (float)((float)(2.2 * z + ((z * 3.5))*(x-1.5)));

                    lWy.Content = "Twoja waga idealna to: "+a+"kg";
                }
                else if (jAm.IsChecked == true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = (y / (x * x)) * 703;
                    float a = (5 * z + ((z / 5)*(x-60)));
                    lWy.Content = "Twoja waga idealna to: " + a+"lb";
                }
                else
                {
                    lWy.Content = "błąd danych";
                }


            }
            else if (chBBmi.IsChecked == true && chBWI.IsChecked == true)
            {
                if (jSi.IsChecked == true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = y / (x * x);
                    float a = (float)((float)(2.2 * z + ((z * 3.5)) * (x - 1.5)));
                    if (z < 18.5)
                    {
                        lWy.Content = "Twoje Bmi to: " + z+" Twoja waga idealna to: "+a+"kg";
                        MessageBox.Show("Masz niedowagę");
                    }
                    else if (z > 18.5 && z < 25)
                    {
                        lWy.Content = "Twoje Bmi to: "+z+" Twoja waga idealna to:" +a+"kg";

                    }
                    else if (z > 25)
                    {
                        lWy.Content = "Twoje Bmi to: "+z+" Twoja waga idealna to:" +a+"kg";
                        MessageBox.Show("Masz nadwagę");

                    }
                    else
                    {
                        lWy.Content = "błąd danych";
                    }

                }
                else if (jAm.IsChecked == true)
                {
                    float x = float.Parse(tBox1.Text, CultureInfo.InvariantCulture);
                    float y = float.Parse(tBox2.Text, CultureInfo.InvariantCulture);

                    float z = (y / (x * x)) * 703;
                    float a = (5 * z + ((z / 5) * (x - 60)));
                    if (z < 18.5)
                    {
                        lWy.Content = "Twoje Bmi to: " + z + " Twoja waga idealna to: " + a + "kg";
                        MessageBox.Show("Masz niedowagę");
                    }
                    else if (z > 18.5 && z < 25)
                    {
                        lWy.Content = "Twoje Bmi to: " + z + " Twoja waga idealna to: " + a + "kg";

                    }
                    else if (z > 25)
                    {
                        lWy.Content = "Twoje Bmi to: " + z + " Twoja waga idealna to: " + a + "kg";
                        MessageBox.Show("Masz nadwagę");

                    }
                    else {
                        lWy.Content = "błąd danych";
                    }
                }
                else
                {
                    lWy.Content = "błąd danych";
                }


            }
            else
            {
                lWy.Content = "błąd danych";
            }
        }

        private void btnWzo_Click(object sender, RoutedEventArgs e)
        {
            if (jAm.IsChecked==true)
            {
                lWy.Content = "Waga idealna: 5*BMI+(BMI/5)*Wzrost[cale]-60  BMI: waga/wzrost^2 *703";


            }
            else if (jSi.IsChecked == true)
            {
                lWy.Content = "Waga idealna: 2.2*BMI+(BMI*3.5)*Wzrost[metry]-1.5  BMI: waga/wzrost^2";


            }
        }
    }
}
