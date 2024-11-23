using System.Security.Cryptography;

namespace Engine.Utils;

public class HashingUtils
{
    public static byte[] ComputeHash(string input, string hashType)
    {
        using HashAlgorithm hashingAlgorithm = hashType.ToUpper() switch
        {
            "MD5" => MD5.Create(),
            "SHA-1" => SHA1.Create(),
            "SHA-256" => SHA256.Create(),
            _ => throw new ArgumentException("Unsupported hashing type", hashType)
        };
        return hashingAlgorithm.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
    }
    
    public static string ByteArrayToHexString(byte[] bytes)
    => BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
}