using Injection.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection.Model
{
    public class Computer
    {
        public string Adi { get; set; }

        private readonly BaseGame _game;
        public Computer(BaseGame game)
        {
            _game = game;
        }

        public Computer()
        {
        }
        public void Run()
        {
            Console.WriteLine("Running.. wait " + _game.Run() + " second");
        }
    }
}
