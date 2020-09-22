using BattleshipSolitaire.Repository;
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

namespace BattleshipSolitaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConfigRepository.ReadFromFile();
        }

        private void GenerateQuiz_Click(object sender, RoutedEventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void OpenConfig_Click(object sender, RoutedEventArgs e)
        {
            Config config = new Config();
            config.Show();
            this.Close();
        }
    }
}
