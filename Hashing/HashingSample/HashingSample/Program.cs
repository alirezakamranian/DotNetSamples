using System.Security.Cryptography;
using System.Text;

const int keySize = 64;
const int iterations = 3500000;
var algorithm = HashAlgorithmName.SHA512;

string HashPassword(string password,out byte[] salt)
{
    salt = RandomNumberGenerator.GetBytes(keySize);

    var hashed = Rfc2898DeriveBytes.Pbkdf2(
        Encoding.UTF8.GetBytes(password),
        salt, 
        iterations,
        algorithm,
        keySize
        );

    return Convert.ToHexString(hashed);
}

bool VerifyPasswrod(string password,string hash,byte[] salt)
{
    var hashed = Rfc2898DeriveBytes.Pbkdf2(
        Encoding.UTF8.GetBytes(password),
        salt,
        iterations,
        algorithm,
        keySize
        );

    return CryptographicOperations
        .FixedTimeEquals(hashed, Convert.FromHexString(hash));
}

var hash = HashPassword("P@ssW0rd",out var salt);

Console.WriteLine($"hash :{hash}");
Console.WriteLine($"salt : {Convert.ToHexString(salt)}");

var VerifRes = VerifyPasswrod("P@ssW0rd", hash, salt);
Console.WriteLine(VerifRes);
Console.ReadKey();