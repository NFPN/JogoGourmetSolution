using JogoGourmet.Logica;
using System.Windows;

namespace JogoGourmet.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GameTree gameTree;
        private TreeNode? currentNode;

        public MainWindow()
        {
            InitializeComponent();
            gameTree = new GameTree();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            currentNode = gameTree.Root;
            FazerPergunta();
        }

        private void FazerPergunta()
        {
            if (currentNode == null)
                return;

            if (currentNode.IsQuestion)
            {
                var perguntaWindow = new QuestionWindow($"O prato que você pensou é {currentNode.Value}?");
                var result = perguntaWindow.ShowDialog();

                if (result == true)
                    currentNode = currentNode.Left;
                else
                    currentNode = currentNode.Right;

                FazerPergunta();
            }
            else
            {
                var perguntaPrato = new QuestionWindow($"O prato que você pensou é {currentNode.Value}?");
                var result = perguntaPrato.ShowDialog();

                if (result == true)
                {
                    MessageBox.Show("Acertei de novo!", "Jogo Gourmet", MessageBoxButton.OK, MessageBoxImage.Information);
                    currentNode = null;
                }
                else
                    ObterNovoPrato();

                FazerPergunta();
            }
        }

        private void ObterNovoPrato()
        {
            if (currentNode == null)
                return;

            InputWindow pratoWindow = new InputWindow("Qual prato você pensou?");
            var resultadoPrato = pratoWindow.ShowDialog();

            if (resultadoPrato == true)
            {
                string novoPrato = pratoWindow.Resposta ?? string.Empty;

                InputWindow perguntaWindow = new InputWindow($"{novoPrato} é ______ mas {currentNode.Value} não.");
                var resultadoPergunta = perguntaWindow.ShowDialog();

                if (resultadoPergunta == true)
                {
                    string novaPergunta = perguntaWindow.Resposta ?? string.Empty;

                    TreeNode pratoNovoNodo = new TreeNode(novoPrato, false);
                    TreeNode pratoAntigoNodo = new TreeNode(currentNode.Value, false);

                    currentNode.Value = novaPergunta;
                    currentNode.IsQuestion = true;
                    currentNode.Left = pratoNovoNodo;
                    currentNode.Right = pratoAntigoNodo;
                }
            }

            currentNode = null;
        }
    }
}
