

namespace Exercicios.Exercicio_3.Solucao
{
    public abstract class Bird
    {    
        public virtual void Eat()
        {
            Console.WriteLine("Eating seeds");
        }
    }

    public class FlyingBird : Bird {
        public virtual void Fly()
        {
            Console.WriteLine("Flying high!");
        }

    }




    public class Penguin : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eating fish");
        }
    }
}
