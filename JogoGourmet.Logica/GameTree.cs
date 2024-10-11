namespace JogoGourmet.Logica
{
    public class GameTree
    {
        public TreeNode Root { get; set; }

        public GameTree()
        {
            Root = new TreeNode("O prato que você pensou é massa?", true)
            {
                Left = new TreeNode("Lasanha", false),
                Right = new TreeNode("Bolo de chocolate", false)
            };
        }
    }
}
