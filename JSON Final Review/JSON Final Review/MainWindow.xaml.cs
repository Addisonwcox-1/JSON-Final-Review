using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Final_Review
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var movie = client.GetAsync($"http://pcbstuou.w27.wh-2.com/webservices/3033/api/Movies?number=100").Result;
                if (movie.IsSuccessStatusCode)
                {
                    var movieResult = movie.Content.ReadAsStringAsync().Result;
                    Movie movieType = JsonConvert.DeserializeObject<Movie>(movieResult);
                }

            }
        }
    }
}
