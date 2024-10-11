namespace JogoGourmet.Logica
{
    public class GameTree
    {
        public TreeNode Root { get; set; }

        public GameTree()
        {
            Root = new TreeNode("Massa", true)
            {
                Left = new TreeNode("Lasanha", false),
                Right = new TreeNode("Bolo de chocolate", false)
            };
        }
    }
}
