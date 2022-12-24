using Injection.Abstracts;
using Injection.Model;

namespace Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XGame xGame = new XGame();
            YGame yGame = new YGame();

            xGame.Run();
            yGame.Run();

            
        }
    }
}