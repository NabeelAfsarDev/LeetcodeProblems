namespace LeetcodeProblems.Easy
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            int number, temp, reverseNumber = 0, remainder;

            //Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(x);
            temp = number;

            while (number > 0)
            {
                //grab remainder first by modulos
                remainder = number % 10;

                //start creating the reverse number
                reverseNumber = reverseNumber * 10 + remainder;

                //Remove the last number of passed number
                number = number / 10;
            }

            if (reverseNumber == temp)
            {
                return true;
            }
            return false;
        }
    }
}
