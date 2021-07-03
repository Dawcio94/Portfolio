using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        public class Dog
        {
            public uint LegsCount=4;
            public virtual string Bark()=>"Hau";
            
        }

        public class GermanShepherd:Dog
        {
            public override string Bark() => "woof";

            public virtual string Growl() => "grr";
            
        }

        public class Corgi : Dog
        {
            public new string Bark() => "yip";

        }

        public class Puppy : GermanShepherd
        {
            public new string Bark() => "Squeak";
            public override string Growl() => "Lack";
        }
        static void Main(string[] args)
        {
            GermanShepherd shepherd = new GermanShepherd();

            Corgi corgi = new Corgi();
            Dog corgi1 = new Corgi();
            Puppy puppy = new Puppy();

            Console.WriteLine("Germanshepherd-Szczekanie:"+shepherd.Bark()+" Warczenie:"+shepherd.Growl());
            Console.WriteLine("Typ Corgi:"+corgi.Bark());
            Console.WriteLine("Inny typ:"+corgi1.Bark());

            Console.WriteLine("Szczeniak:" + "Warczenie:"+puppy.Growl()+" Szczekanie:"+puppy.Bark());


            Console.ReadKey();
        }
    }
}
