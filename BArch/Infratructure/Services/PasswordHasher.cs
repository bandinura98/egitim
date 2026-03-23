using System.Security.Cryptography;
using System.Text;

namespace Infratructure.Services;

internal class PasswordHasher : IPasswordHasher
{
    public string Hash(string password)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(password);
        byte[] hashBytes = MD5.HashData(inputBytes);

        StringBuilder sb = new();
        foreach (var b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
}