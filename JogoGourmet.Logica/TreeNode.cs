namespace JogoGourmet.Logica
{
    public class TreeNode(string value, bool isQuestion)
    {
        public string Value { get; set; } = value;
        public bool IsQuestion { get; set; } = isQuestion;

        public TreeNode? Esquerda { get; set; }
        public TreeNode? Direita { get; set; }
    }
}
