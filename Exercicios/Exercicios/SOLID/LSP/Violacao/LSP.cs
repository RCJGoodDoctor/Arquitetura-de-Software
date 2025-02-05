

namespace Exercicios.Exercicio_3.Violacao
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying high!");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eating seeds");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly!");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating fish");
        }
    }
}
