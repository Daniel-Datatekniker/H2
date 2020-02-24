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
using Game;
using OldMaid.Wrapper;

namespace OldMaid
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double distance = 40;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void TextBox_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {


            if (PlayerNameInput.Text.Length >= 1)
            {

                if (StandartCardCheck.IsChecked == true)
                {
                    GameCon game = new GameCon(CardTypes.Value, PlayerNameInput.Text);
                    game.StartGame();
                    AddCardsToCanvas(game.GetCards());
                    game.PlayerTurnEvent += Game_PlayerTurnEvent;
                    GameScreen.Visibility = Visibility.Visible;
                    Menu.Visibility = Visibility.Hidden;

                }
                else if (ImageCardCheck.IsChecked == true)
                {
                    GameCon game = new GameCon(CardTypes.Image, PlayerNameInput.Text);
                    game.StartGame();
                    AddCardsToCanvas(game.GetCards());
                    Menu.Visibility = Visibility.Hidden;
                    GameScreen.Visibility = Visibility.Visible;

                }
                else
                {
                    ErrorMessage("No card checked");
                }


            }
            else
            {
                ErrorMessage("No player name");
                Error.Visibility = Visibility.Visible;

            }

        }

        public void AddCardsToCanvas(List<ICard> cards)
        {

            foreach (var card in cards)
            {
                if (card is Card)
                {

                    PlayerCanvas.Children.Add(new ImageCardWrapper((Card)card, (int)distance, SystemParameters.PrimaryScreenWidth));
                    EnemyCanvas.Children.Add(new ImageCardWrapper((Card)card, (int)distance, SystemParameters.PrimaryScreenWidth));
                 
                  distance += 0;
                }


            }
           
            WindowState = WindowState.Maximized;

        }

        private void Game_PlayerTurnEvent(object sender, EventArgs e)
        {

            Dispatcher.Invoke(() =>
           {
               if (e is PlayerEventArgs)
               {
                   PlayerTurn.Content = ((PlayerEventArgs)e).PlayerTurn + " turn";
               }
           }
              );


        }




        private void ErrorMessage(string message)
        {
            Error.Content = message;
            Error.Visibility = Visibility.Visible;
        }

        private void ImageCheck_Checked(object sender, RoutedEventArgs e)
        {
            StandartCardCheck.IsChecked = false;
        }

        private void ValueCheck_Checked(object sender, RoutedEventArgs e)
        {
            ImageCardCheck.IsChecked = false;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            new CanvasUpdater(e.NewSize.Width, PlayerCanvas);
            new CanvasUpdater(e.NewSize.Width, EnemyCanvas);


        }

        

        

        
    }
}
