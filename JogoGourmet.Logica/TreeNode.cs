namespace JogoGourmet.Logica
{
    public class TreeNode(string value, bool isQuestion)
    {
        public string Value { get; set; } = value;
        public bool IsQuestion { get; set; } = isQuestion;

        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }
}
