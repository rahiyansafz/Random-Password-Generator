namespace RandomPasswordGenerator;

internal class App
{
    public static void Run()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter desired password length.");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Generated password of {0} character is", length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(GeneratePassword(length));
        }
    }
    private static string GeneratePassword(int passwordLength)
    {
        Random random = new();
        char[] buffer = new char[passwordLength];
        for (int i = 0; i < passwordLength; i++)
            buffer[i] = (char)('a' + random.Next(0, 26));
        var password = new string(buffer);

        return password;
    }
}
