using System.Windows;

namespace JogoGourmet.Views
{
    /// <summary>
    /// Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public string? Resposta { get; private set; }

        public InputWindow(string message)
        {
            InitializeComponent();
            txtMensagem.Text = message;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Resposta = txtResposta.Text;
            DialogResult = true;
            Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
