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

namespace ScheduleDev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int line;

        public MainWindow()
        {
            InitializeComponent();
            output.Text = "";
            line = 0;
        }

        private void Command()
        {
            string[] words = commandPrompt.Text.ToString().Split(' ');

            string command = words[0];
            string argument = words[1];


            




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        

        private void WriteOutput(string sentence)
        {
            string PreOutput = "Command " + line.ToString() + ": ";
            output.Text += "\n" + PreOutput + commandPrompt.Text.ToString() + " " + sentence;
        }

        private void commandPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Command();
                line++;
            }

        }
    }
}
