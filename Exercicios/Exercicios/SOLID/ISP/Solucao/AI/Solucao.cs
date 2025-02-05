using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio_4.Solucao.AI
{
    // ===== SEGREGATED INTERFACES =====
    public interface IWorkable
    {
        void Work();
    }

    public interface IBreakable
    {
        void TakeBreak();
    }

    public interface IMeetingAttendable
    {
        void AttendMeeting();
    }

    // ===== CONCRETE CLASSES =====
    public class OfficeWorker : IWorkable, IBreakable, IMeetingAttendable
    {
        public void Work() => Console.WriteLine("Working on documents");
        public void TakeBreak() => Console.WriteLine("Taking coffee break");
        public void AttendMeeting() => Console.WriteLine("Attending meeting");
    }

    public class DevWorker : IWorkable, IBreakable
    {
        public void TakeBreak()
        {
            Console.WriteLine("Working on code ");
        }

        public void Work()
        {
            Console.WriteLine("Taking coffee break");
        }
    }

    public class RobotWorker : IWorkable
    {
        public void Work() => Console.WriteLine("Assembling parts");
    }
}
