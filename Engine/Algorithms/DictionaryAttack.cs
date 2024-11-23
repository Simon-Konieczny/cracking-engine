public class DictionaryAttack
{
    public string? DictionaryAttack(string hash, string dictionaryPath, string hashType)
    {
        foreach (var password in File.ReadLines(dictionaryPath))
        {
            var computedHash = HashingUtils.ByteArrayToHexString(HashingUtils.ComputeHash(password.Trim(), hashType));
            if (computedHash == hash) return password;
        }
        return null;
    }
}