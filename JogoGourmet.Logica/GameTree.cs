namespace JogoGourmet.Logica
{
    public class GameTree
    {
        public TreeNode Root { get; set; }

        public GameTree()
        {
            Root = new TreeNode("O prato que você pensou é massa?", true)
            {
                Esquerda = new TreeNode("Lasanha", false),
                Direita = new TreeNode("Bolo de chocolate", false)
            };
        }
    }
}
