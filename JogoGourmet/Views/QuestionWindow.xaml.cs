using System.Windows;

namespace JogoGourmet.Views
{
    /// <summary>
    /// Interaction logic for PerguntaWindow.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        public QuestionWindow(string question)
        {
            InitializeComponent();
            txtPergunta.Text = question;
        }

        private void btnSim_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnNao_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
