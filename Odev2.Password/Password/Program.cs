//girilen şifrenin zayıf, orta veya güçlü şifre olduğunu söyleyen program
string password;
string numbers = "0123456789";
string alphabet = "abcdefghijklmnoprstuvyzxwqABCDEFGHIJKLMNOPRSTUVYZXWQ";
string aNumeric = "!@#&()–[{}]:;',?/*%";
char character;
bool numStatus = false;
bool alpStatus = false;
bool aNumericStatus = false;

do
{
    Console.WriteLine("En az 6 karakterden oluşan bir parola oluşturun");
    password = Console.ReadLine();
}
while (password.Length < 6);


for (int i = 0; i < password.Length; i++)
{
    character = char.Parse(password.Substring(i, 1));

    if (numbers.Contains(character))
    {
        numStatus = true;
    }

    if (alphabet.Contains(character))
    {
        alpStatus = true;
    }

    if (aNumeric.Contains(character))
    {
        aNumericStatus = true;
    }
}

if (numStatus == false && alpStatus == true && aNumericStatus == false)
{
    Console.WriteLine("Zayıf şifre");
}
if (numStatus == true && alpStatus == false && aNumericStatus == false)
{
    Console.WriteLine("Zayıf şifre");
}

if (numStatus == true && alpStatus == true && aNumericStatus == false)
{
    Console.WriteLine("Orta şifre");
}

if (numStatus == true && alpStatus == true && aNumericStatus == true)
{
    Console.WriteLine("Güçlü şifre");
}
//110 orta 111 güçlü  10 01 zayıf