using Injection.Abstracts;
using Injection.Model;

namespace Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XGame xGame = new XGame()
            {
                Second = 10
            };
            YGame yGame = new YGame() 
            {
                Second = 5
            };

            Computer computer = new Computer(yGame);

            computer.Run();

            
        }
    }
}