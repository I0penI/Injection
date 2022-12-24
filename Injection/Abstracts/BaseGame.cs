namespace Injection.Abstracts
{
    public abstract class BaseGame : IGame
    {
        protected int second;

        public void Run()
        {
            Console.WriteLine("Running...  wait " + second + " seconds.");
        }
    }
}
