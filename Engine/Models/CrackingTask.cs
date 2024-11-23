public class CrackingTask
{
    public string Id { get; set; }
    public string Hash { get; set; } = string.Empty;
    public string HashType { get; set; } = "SHA-256";
    public string AttackType { get; set; } = "BruteForce";
    public string CharSet { get; set; } = "abcdefghijklmnopqrstuvwyxz";
    public int MaxPasswordLength { get; set; } = 8;
}