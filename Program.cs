namespace RomanToArabicKata
{

    public class RomanToArabicConverter
    {

        private static readonly Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        public static int RomanToArabic(string numerals)
        {
            int result = 0;
            for (int i = 0; i < numerals.Length; i++)
            {
                int cur = romanValues[numerals[i]];
                int next = (i + 1 < numerals.Length) ? romanValues[numerals[i + 1]] : 0; // Check if next character exists
                if (cur < next)
                {
                    result += next - cur;
                    i++;
                }
                else
                {
                    result += cur;
            }
            }

            return result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string romanNumeral = "MMXXI";
            int arabicNumeral = RomanToArabicConverter.RomanToArabic(romanNumeral);
            Console.WriteLine($"The Arabic equivalent of {romanNumeral} is {arabicNumeral}");
        }
    }

}