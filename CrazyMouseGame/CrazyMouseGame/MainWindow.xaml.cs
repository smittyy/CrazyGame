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
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace CrazyMouseGame
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

        public static Random _random = new Random();

        int score = 0;
        int width = 1900;
        int height = 900;

        int moveX = 0;
        int moveY = 0;

        int makeFastMain = 30;
        int makeFastTwo = 15;

        int ror = 2;
        TimeSpan Fisrt = new TimeSpan(1000, 0, 0, 0);


        public void FunkyButton_Click(object sender, RoutedEventArgs e)
        {
            char[] charsToGetRidOf = { ':', '[', ']', '.' };
            string highscore;
            string PlayerScore;
            double PlayerScoreTwo;
            String HisName;
            ror++;
            //Scoring Stuff
            score++;
            txtDisplay.Text = ($"Score: {score}");

            //Change Box Size
            if (width <= 250 && height <= 200)
            {
                width = width - 10;
                height = height - 5;


            }
            else
            {
                width = width - (60 + score);
                height = height - (20 + score);
            }
            FunkyButton.Width = (width);
            FunkyButton.Height = (height);


            if (score == 25)
            {
                Namey.Visibility = Visibility.Visible;
                Texty.Visibility = Visibility.Visible;
                Sub.Visibility = Visibility.Visible;
                FunkyButton.Visibility = Visibility.Hidden;

                using(StreamReader tr = new StreamReader("HighScoreName.txt"))
                {
                    HisName = tr.ReadLine();
                }

                using (StreamReader tr = new StreamReader("HighScore.txt"))
                {
                    highscore = tr.ReadLine();
                }

                Texty.Text = $"The current High Score is {highscore}, and it's held by {HisName}";

                PlayerScore = Convert.ToString(Time.Content);
                PlayerScoreTwo = Convert.ToDouble(Regex.Replace(PlayerScore, @"(\s+|@|:|)", ""));
                double Dohighscore = Convert.ToDouble(Regex.Replace(highscore, @"(\s+|@|:|)", ""));

                using (StreamWriter tw = new StreamWriter("HighScore.txt", append: false))
                {
                    tw.Write(Convert.ToString(Time.Content));
                }

                if (PlayerScoreTwo < Dohighscore)
                {

                    Texty.Text = $"You did so well that you have the new highscore of {Time.Content}.";
                }
            }

        }


        public void Start_Click(object sender, RoutedEventArgs e)
        {
            Namey.Visibility = Visibility.Hidden;
            Texty.Visibility = Visibility.Hidden;
            Sub.Visibility = Visibility.Hidden;

            Thread Timer = new Thread(new ThreadStart(TimerBoi));
            Timer.Start();

            Thread crazyMouseThread = new Thread(new ThreadStart(CrazyMouseThread));
            crazyMouseThread.Start();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);


        public void CrazyMouseThread()
        {

            while (score != 25)
            {
                if (score <= 15)
                {
                    moveX = _random.Next((makeFastMain + ror)) - (makeFastTwo + ror);
                    moveY = _random.Next((makeFastMain + ror)) - (makeFastTwo + ror);
                }
                else if (score >= 16)
                {
                    moveX = _random.Next((makeFastMain)) - makeFastTwo;
                    moveY = _random.Next(makeFastMain) - makeFastTwo;
                }

                SetCursorPos(System.Windows.Forms.Cursor.Position.X + moveX, System.Windows.Forms.Cursor.Position.Y + moveY);
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X + moveX, System.Windows.Forms.Cursor.Position.Y + moveY);
                Thread.Sleep(50);
            }
        }

        private void Time_Click(object sender, RoutedEventArgs e)
        {
            int width = 1900;
            int height = 900;
            FunkyButton.Width = (width);
            FunkyButton.Height = (height);
        }

        private void TimerBoi()
        {
            DateTime Date1 = DateTime.Now;
            while (score !=25)
            {
                DateTime Date2 = DateTime.Now;

                TimeSpan Mix = Date2 - Date1;

                this.Dispatcher.Invoke(() =>
                {
                    Time.Content = $"{Mix}";
                });
                Thread.Sleep(100);
            }
        }

        private void BetterTimer_Click(object sender, RoutedEventArgs e)
        {
            width = 1900;
            height = 900;
            FunkyButton.Width = (width);
            FunkyButton.Height = (height);
            FunkyButton.Visibility = Visibility.Visible;
            score = 0;
            txtDisplay.Text = score.ToString();
            Sub.Visibility = Visibility.Visible;
            Texty.Visibility = Visibility.Hidden;
            Namey.Visibility = Visibility.Hidden;
            this.Dispatcher.Invoke(() =>
            {
                Time.Content = $"00:00:00.0000000";
            });
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter nerd = new StreamWriter("HighScoreName.txt", append: false))
            {
                nerd.Write(Convert.ToString(Namey.Text));
            }
        }
    }
}
