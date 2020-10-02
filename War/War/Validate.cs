// Adrian Gutierrez
// 10/01/2020
// APA
// 1.2 Code Exercise

using System;
namespace War
{
    public static class Validate
    {
        // Validate for string
        public static string IsString(string message)
        {
            string value;

            Console.Write(message + " _");
            value = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("-!-You may not leave this blank!");
                Console.Write(message + " _");
                value = Console.ReadLine();
            }

            return value;
        }




        // Validate yes or no
        public static bool YesOrNo(string message)
        {
            Console.WriteLine("-----------------------");
            Console.Write(message + " _");
            string response = Console.ReadLine();

            // Validating response is 'y' or 'n' with flexibility for case
            while (response.ToLower() != "y" && response.ToLower() != "n")
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("-!-You must enter [Y] or [N]");
                Console.Write(message + " _");
                response = Console.ReadLine();
            }

            if (response.ToLower() == "y")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
