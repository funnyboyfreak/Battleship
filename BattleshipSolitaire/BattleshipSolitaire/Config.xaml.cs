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
                rowsCombo.Items.Add(i);
                columnsCombo.Items.Add(i);
            }
        }

        void FillContent()
        {
            if (MainWindow.ConfigArray[0] == "0")
            {
                rowsCombo.SelectedIndex = 0;
            }
            else
            {
                rowsCombo.SelectedIndex = Convert.ToInt32(MainWindow.ConfigArray[0]);
            }

            if (MainWindow.ConfigArray[1] == "0")
            {
                columnsCombo.SelectedIndex = 0;
            }
            else
            {
                columnsCombo.SelectedIndex = Convert.ToInt32(MainWindow.ConfigArray[1]);
            }

            einerSlide.Value = Convert.ToInt32(MainWindow.ConfigArray[2]);
            zweierSlide.Value = Convert.ToInt32(MainWindow.ConfigArray[3]);
            dreierSlide.Value = Convert.ToInt32(MainWindow.ConfigArray[4]);
            viererSlide.Value = Convert.ToInt32(MainWindow.ConfigArray[5]);
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            using (StreamWriter streamwriter = new StreamWriter("C:\\Temp\\config.txt", false))
            {
                streamwriter.WriteLine(rowsCombo.SelectedValue);
                streamwriter.WriteLine(columnsCombo.SelectedValue);
                streamwriter.WriteLine(einerSlide.Value);
                streamwriter.WriteLine(zweierSlide.Value);
                streamwriter.WriteLine(dreierSlide.Value);
                streamwriter.WriteLine(viererSlide.Value);
            }

            MainWindow window = new MainWindow();
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
