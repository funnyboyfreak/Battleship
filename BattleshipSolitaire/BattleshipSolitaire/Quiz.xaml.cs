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
using System.Windows.Shapes;

namespace BattleshipSolitaire
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : Window
    {
        public Quiz()
        {
            InitializeComponent();
            Settings settings = new Settings();
            settings.Row = Convert.ToInt32(MainWindow.ConfigArray[0]);
            settings.Column = Convert.ToInt32(MainWindow.ConfigArray[1]);
            CreatePlayGround(settings.Row, settings.Column);
        }

        public void CreatePlayGround(int anzRows, int anzColumns)
        {
            int counter = 0;
            Button btn;

            for (int i = 0; i < anzRows; i++)
            {
                this.PlayGroundGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            for (int i = 0; i < anzColumns; i++)
            {
                this.PlayGroundGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int row = 0; row < this.PlayGroundGrid.RowDefinitions.Count; row++)
            {
                for (int column = 0; column < this.PlayGroundGrid.ColumnDefinitions.Count; column++)
                {
                    counter++;
                    btn = new Button();
                    //Button Hintergrundfarbe
                    btn.Background = Brushes.LightBlue;
                    btn.SetValue(Grid.ColumnProperty, column);
                    btn.SetValue(Grid.RowProperty, row);
                    //Nur zum luege öbs schön nach de reihe nummeriert chasch de counter den wieder lösche
                    btn.Content = counter;
                    this.PlayGroundGrid.Children.Add(btn);
                }
            }
        }
    }
}
