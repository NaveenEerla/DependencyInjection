using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    public class Hammer
    {
        public void Use() {
            Console.WriteLine(  "Using the Hammer");
        }

    }
    public class Sow
    {
        public void Use()
        {
            Console.WriteLine("Using Sow");
        }
    }

    // Constructor Dependency Injection(DI)
    public class Builder
    {
        private Hammer _hammer;
        private Sow _sow;

        public Builder(Hammer hammer, Sow sow)
        {
            _hammer = hammer;
            _sow = sow;
        }
        public void BuildHose()
        {
            _hammer.Use();
            _sow.Use();
            Console.WriteLine(  "House Built");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Sow sow = new Sow();   
            Builder builder = new Builder(hammer,sow);
            builder.BuildHose();
            Console.Read();
        }
    }
}
