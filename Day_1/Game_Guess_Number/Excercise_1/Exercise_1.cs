using System.Linq;

namespace Game_Guess_Number
{
    class Exercise_1
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(" Chuong Trinh Doan So  ");

            int targetNumber = random.Next(100, 999);
            string targetString = targetNumber.ToString();

            string guess = "", feedback = "";
            int attempt = 0;
            const int MAX_GUESS = 7;
            while (feedback != "+++" && attempt <= MAX_GUESS)
            {
                Console.Write("Nguoi dung du doan lan thu {0} : ", attempt);
                guess = Console.ReadLine();
                feedback = getFeedback(targetString, guess);
                Console.WriteLine("Phan hoi cua may tinh  {0} ", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. Tro choi ket thuc !", attempt - 1);
            if (attempt > MAX_GUESS)
            {
                Console.WriteLine("Nguoi choi thua cuoc . So can doan la : {0} ", targetNumber);
            }
            else
            {
                Console.WriteLine("Nguoi choi thang quoc ! ", attempt);
            }
            Console.WriteLine();
        }

        public static string getFeedback(string targetNumber, string guessNumber)
        {
            string feedback = "";
            int length = targetNumber.Length;
            for (int i = 0; i < length; i++)
            {
                if (targetNumber[i] == guessNumber[i])
                {
                    feedback += "+";
                }
                else if (targetNumber.Contains(guessNumber[i].ToString()))
                {
                    feedback += "?";
                }
            }

            return feedback;
        }
    }

}
