using System;
namespace Episode012.SOLID
{
    public interface IEmployee
    {
        void DoWork();
        void CheckSubordinates();
    }

    public class Manager : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("Work work work");
        }

        public void CheckSubordinates()
        {
            Console.WriteLine("Supervise");
        }
    }

    public class Staff : IEmployee
    {        
        public void DoWork()
        {
            Console.WriteLine("Work work work");
        }

        public void CheckSubordinates()
        {
            throw new NotImplementedException();
        }
    }

    #region -- Liskov's Substitution --

    public interface IStaff
    {
        void DoWork();
    }

    public interface IManager: IStaff
    {
        void CheckSubordinates();

    }

    public class StaffV2: IStaff
    {
        public void DoWork() {
        }
    }

    public class ManagerV2 : StaffV2, IManager
    {
        public void CheckSubordinates()
        {
            Console.WriteLine("Supervise");
        }
    }

    #endregion
}
