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
        private TreeNode currentNode;

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
            if (currentNode.IsQuestion)
            {
                PerguntaWindow perguntaWindow = new PerguntaWindow(currentNode.Value);
                var result = perguntaWindow.ShowDialog();
            }
        }
    }
}
