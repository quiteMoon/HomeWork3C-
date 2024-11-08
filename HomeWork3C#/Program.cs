using System.Text;

namespace HomeWork3C_
{
    internal class Program
    {
        static void DisplaySquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPalindrome(int number)
        {
            string numStr = number.ToString();

            char[] arr = numStr.ToCharArray();
            Array.Reverse(arr);
            string reversedStr = new string(arr);

            return numStr == reversedStr;
        }

        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int[] tempArray = new int[originalArray.Length];
            int index = 0;

            foreach (int element in originalArray)
            {
                bool shouldFilter = false;

                foreach (int filter in filterArray)
                {
                    if (element == filter)
                    {
                        shouldFilter = true;
                        break;
                    }
                }

                if (!shouldFilter)
                {
                    tempArray[index] = element;
                    index++;
                }
            }

            int[] resultArray = new int[index];
            Array.Copy(tempArray, resultArray, index);

            return resultArray;
        }


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Завдання 1
            // DisplaySquare(5, '*');

            // Завдання 2
            /*Console.WriteLine(IsPalindrome(1221));
            Console.WriteLine(IsPalindrome(3443));
            Console.WriteLine(IsPalindrome(7854));*/

            // Завдання 3
            /*int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] resultArray = FilterArray(originalArray, filterArray);

            Console.WriteLine("Результат: " + string.Join(", ", resultArray));*/

            // Завдання 4
            /*Website website = new Website("Google", "https://www.google.com", "Пошукова система", "142.250.64.78");

            website.DisplayWebsiteDetails();

            website.SetDescription("Пошукова система та інші сервіси");
            website.SetIpAddress("142.250.64.79");

            Console.WriteLine("\nПісля змін:");
            website.DisplayWebsiteDetails();*/

            //Завдання 5
            /*Journal journal = new Journal("Tech Monthly", 1999, "Журнал про технології", "123-456-7890", "info@techmonthly.com");

            journal.DisplayInformation();

            journal.SetTitle("Tech Weekly");
            journal.SetYearOfEstablishment(2000);

            Console.WriteLine("\nОновлена інформація:");
            journal.DisplayInformation();*/

            // Завдання 6
            /*Store store = new Store("Магазин 'Електроніка'", "м. Київ, вул. Хрещатик, 15", "Магазин побутової техніки та електроніки", "+380631234567", "info@electroshop.ua");

            store.DisplayData();

            store.SetName("Магазин 'Техніка'");
            store.SetAddress("м. Київ, вул. Хрещатик, 12");

            Console.WriteLine("\nОновлена інформація:");
            store.DisplayData();*/
        }
    }
}
