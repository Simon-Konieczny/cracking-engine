using Engine.Utils.HashingUtils;

public class BruteForce
{
    public string? BruteForce(string hash, string charset, int maxLength, string hashType)
    {
        foreach (var password in GeneratePasswords(charset, maxLength))
        {
            var computedHash = HashingUtils.ByteArrayToHexString(HashingUtils.ComputeHash(password, hashType));
            if (computedHash == hash) return password;
        }
    }
}