using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio_4.Solucao
{
    public interface IOfficeWorker
    {
        void Work();
        void TakeBreak();
        void AttendMeeting();
    }

    public class OfficeWorker : IOfficeWorker
    {
        public void Work() => Console.WriteLine("Working on documents");
        public void TakeBreak() => Console.WriteLine("Taking coffee break");
        public void AttendMeeting() => Console.WriteLine("Attending meeting");
    }

    public class RobotWorker : IRobotWorker
    {
        public void Work() => Console.WriteLine("Assembling parts");
       
    }

    public interface IRobotWorker
    {
        public void Work();
    }
}
