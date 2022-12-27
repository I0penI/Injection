namespace Injection.Abstracts
{
    public abstract class BaseGame : IGame
    {
        public int Second { get; set; }
       
        public int Run()
        {
            return Second;
        }
    }
}
