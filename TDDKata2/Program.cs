using TDDKata1;

namespace TDDKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            new UserConsole(new StringCalculator(), new UserInteraction()).Start();
        }
    }
}