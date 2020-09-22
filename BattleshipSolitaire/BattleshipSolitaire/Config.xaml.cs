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
using BattleshipSolitaire.Repository;

namespace BattleshipSolitaire
{

    /// <summary>
    /// Interaction logic for Config.xaml
    /// </summary>
    public partial class Config : Window
    {
        public Config()
        {
            InitializeComponent();
            FillXaml();
            FillContent();
        }

        void FillXaml()
        {
            for (int i = 0; i <= 10; i++)
            {
                this.rowComboBox.Items.Add(i);
                this.columnComboBox.Items.Add(i);
            }
        }

        void FillContent()
        {
            this.rowComboBox.SelectedIndex = Convert.ToInt32(ConfigRepository.ConfigArray[0]);
            this.columnComboBox.SelectedIndex = Convert.ToInt32(ConfigRepository.ConfigArray[1]);

            einerSlide.Value = Convert.ToInt32(ConfigRepository.ConfigArray[2]);
            zweierSlide.Value = Convert.ToInt32(ConfigRepository.ConfigArray[3]);
            dreierSlide.Value = Convert.ToInt32(ConfigRepository.ConfigArray[4]);
            viererSlide.Value = Convert.ToInt32(ConfigRepository.ConfigArray[5]);
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamwriter = new StreamWriter("C:\\Temp\\config.txt", false))
            {
                Settings.Column = 10;
                Settings.Row = 5;
                streamwriter.WriteLine(this.rowComboBox.SelectedValue);
                streamwriter.WriteLine(this.columnComboBox.SelectedValue);
                streamwriter.WriteLine(einerSlide.Value);
                streamwriter.WriteLine(zweierSlide.Value);
                streamwriter.WriteLine(dreierSlide.Value);
                streamwriter.WriteLine(viererSlide.Value);
            }

            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
