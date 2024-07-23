using Newtonsoft.Json;
using System.IO;
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

namespace Wpf_caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string content = "";
        private double Number1 = 0.0, Number2 = 0.0;
        private string Operator = "";
        private List<Calculation>? calculations = new List<Calculation>();
        public MainWindow()
        {
            InitializeComponent();
            lbContent.Content = "0";
            lbHistory.Content = "";
        }
        private void UnlockButton()
        {
            content = "";
            lbHistory.Content = "";
            lbContent.Content = content;
            Number1 = 0.0;
            Number2 = 0.0;
            Add.IsEnabled = true;
            Minus.IsEnabled = true;
            Tich.IsEnabled = true;
            Thuong.IsEnabled = true;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '4';
            lbContent.Content = content;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '8';
            lbContent.Content = content;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '1';
            lbContent.Content = content;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString().Length - 2 == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '2';
            lbContent.Content = content;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '5';
            lbContent.Content = content;
        }



        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '9';
            lbContent.Content = content;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '6';
            lbContent.Content = content;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '3';
            lbContent.Content = content;
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '0';
            lbContent.Content = content;
        }

        private void bt7_Click_1(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            content += '7';
            lbContent.Content = content;
        }



        private void btcham_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (lbContent.Content != "" && lbHistory.Content != ""
                && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                content = "";
                lbHistory.Content = "";
            }
            if (content.Contains("."))
            {
                return;
            }
            if (content == "")
            {
                content = "0";
            }
            content += '.';
            lbContent.Content = content;
        }
        private List<Calculation> LoadDataFromFile()
        {
            List<Calculation> datas = new List<Calculation>();
            string filePath = @"H:\data.txt";
            string content = "";
            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
                if (content == "") return null;
                datas = JsonConvert.DeserializeObject<List<Calculation>>(content).ToList();
            }
            return datas;
        }
        private void WriteDataToFile()
        {
            string filePath = @"H:\data.txt";
            string content = JsonConvert.SerializeObject(calculations);
            File.WriteAllText(filePath, content);
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            Calculation calculation = new Calculation();
            calculations = LoadDataFromFile();
            if (lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] == '=')
            {
                Number1 = double.Parse(content);
                lbHistory.Content = Number1.ToString() + " " + Operator.ToString() + " " + Number2.ToString() + " = ";
            }
            else
            {
                Number2 = double.Parse(content);
                lbHistory.Content = lbHistory.Content + Number2.ToString() + " = ";
            }
            switch (Operator)
            {
                case "+":
                    {
                        content = (Number2 + Number1).ToString();
                        lbContent.Content = content;

                        string Content = lbHistory.Content + content;
                        DateTime Log = DateTime.Now;
                        calculation.Content = Content;
                        calculation.Log = Log;
                        if (calculations == null) calculations = new List<Calculation> { calculation };
                        else calculations.Add(calculation);
                        WriteDataToFile();
                        break;
                    }
                case "-":
                    {
                        content = (Number1 - Number2).ToString();
                        lbContent.Content = content;
                        string Content = lbHistory.Content + content;
                        DateTime Log = DateTime.Now;
                        calculation.Content = Content;
                        calculation.Log = Log;
                        if (calculations == null) calculations = new List<Calculation> { calculation };
                        else calculations.Add(calculation);
                        WriteDataToFile();
                        break;
                    }
                case "*":
                    {
                        content = (Number1 * Number2).ToString();
                        lbContent.Content = content;
                        string Content = lbHistory.Content + content;
                        DateTime Log = DateTime.Now;
                        calculation.Content = Content;
                        calculation.Log = Log;
                        if (calculations == null) calculations = new List<Calculation> { calculation };
                        else calculations.Add(calculation);
                        WriteDataToFile();
                        break;
                    }
                case "/":
                    {
                        if (Number2 == 0)
                        {
                            content = "Cannot divide by zero";
                            Add.IsEnabled = false;
                            Minus.IsEnabled = false;
                            Tich.IsEnabled = false;
                            Thuong.IsEnabled = false;
                            lbContent.Content = content;
                            return;
                        }
                        else
                        {
                            content = (Number1 / Number2).ToString();
                            lbContent.Content = content;
                            string Content = lbHistory.Content + content;
                            DateTime Log = DateTime.Now;
                            calculation.Content = Content;
                            calculation.Log = Log;
                            if (calculations == null) calculations = new List<Calculation> { calculation };
                            else calculations.Add(calculation);
                            WriteDataToFile();
                        }
                        break;
                    }
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (lbHistory.Content.ToString() != "" && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] != '=')
            {
                equal_Click(sender, e);
            }
            if (content != "")
            {
                Number1 = double.Parse(content);
                content += " - ";
                lbHistory.Content = content;
                Operator = "-";
                content = "";
                lbContent.Content = content;
            }
        }

        private void Thuong_Click(object sender, RoutedEventArgs e)
        {
            if (lbHistory.Content.ToString() != "" && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] != '=')
            {
                equal_Click(sender, e);
            }
            if (content != "")
            {
                Number1 = double.Parse(content);
                content += " / ";
                lbHistory.Content = content;
                Operator = "/";
                content = "";
                lbContent.Content = content;
            }
        }



        private void AC_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }

            content = "";
            Number1 = 0.0;
            Number2 = 0.0;
            Operator = "";
            lbContent.Content = "0";
            lbHistory.Content = "";

        }
        private void Tich_Click_1(object sender, RoutedEventArgs e)
        {
            if (lbHistory.Content.ToString() != "" && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] != '=')
            {
                equal_Click(sender, e);
            }
            if (content != "")
            {
                Number1 = double.Parse(content);
                content += " * ";
                lbHistory.Content = content;
                Operator = "*";
                content = "";
                lbContent.Content = content;
            }
        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsEnabled == false)
            {
                UnlockButton();
            }
            if (content != "")
            {
                content = content.Substring(0, content.Length - 1);
                lbContent.Content = content;
                if (content == "")
                {
                    lbContent.Content = "0";
                    lbHistory.Content = "";
                }
            }
        }

        private void btHistory_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            history.Show();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (lbHistory.Content.ToString() != "" && lbHistory.Content.ToString()[lbHistory.Content.ToString().Length - 2] != '=')
            {
                equal_Click(sender, e);
            }
            if (content != "")
            {
                Number1 = double.Parse(content);
                content += " + ";
                lbHistory.Content = content;
                Operator = "+";
                content = "";
                lbContent.Content = content;
            }
        }
    }
}