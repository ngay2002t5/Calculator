using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_caculator
{
    /// <summary>
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Window
    {
        private List<Calculation> calculations = new List<Calculation>();
        public History()
        {
            InitializeComponent();
        }

        private List<Calculation> LoadDataFromFile()
        {
            List<Calculation> datas = new List<Calculation>();
            string filePath = @"H:\data.txt";
            string content = "";
            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
                datas = JsonConvert.DeserializeObject<List<Calculation>>(content).ToList();
            }
            return datas;
        }

        private void LoadDate(object sender, RoutedEventArgs e)
        {
            calculations = LoadDataFromFile();
            dgvListStuden.ItemsSource = calculations.ToList();
        }
    }
}
