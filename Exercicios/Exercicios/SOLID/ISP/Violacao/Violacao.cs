using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio_4.Violacao
{
    public interface IWorker
    {
        void Work();
        void TakeBreak();
        void AttendMeeting();
    }

    public class OfficeWorker : IWorker
    {
        public void Work() => Console.WriteLine("Working on documents");
        public void TakeBreak() => Console.WriteLine("Taking coffee break");
        public void AttendMeeting() => Console.WriteLine("Attending meeting");
    }

    public class RobotWorker : IWorker
    {
        public void Work() => Console.WriteLine("Assembling parts");
        public void TakeBreak() => throw new NotImplementedException();
        public void AttendMeeting() => throw new NotImplementedException();
    }
}
