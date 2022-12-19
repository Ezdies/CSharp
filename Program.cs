

namespace Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var xString = Console.ReadLine();
            var yString = Console.ReadLine();


            if (!IsValidInput(xString))
                return;

            if (!IsValidInput(yString))
                return;


            /*

                        var charArray = xString.ToCharArray();



                        var charsInYString = new Stack<char>(yString.ToCharArray());
                        while (charsInYString.Count > 0)
                        {
                            var c = charsInYString.Pop();
                            if (!Char.IsDigit(c))
                            {
                                Console.WriteLine("Podano conajmniej jeden znak, który nie jest cyfrą");
                                return;
                            }
                        }

                    */
            var x = int.Parse(xString!);
            var y = int.Parse(yString!);

            var p = new Point(x, y);
            Console.WriteLine(p.X);
            Console.WriteLine(yString);

        }

        public static bool IsStringNullOrEmpy(string? input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static bool DoesContainOnlyDigits(string? input)
        {
            var list = new List<char>(input!.ToCharArray());

            foreach (var c in list)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;

        }
        public static bool IsValidInput(string? input)
        {
            return !IsStringNullOrEmpy(input) && DoesContainOnlyDigits(input);
        }
    }

}
