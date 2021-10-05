using System;
namespace Episode012.SOLID
{
    public class Repository
    {
        public void Add()
        {
            //with 1000+ line of codes here
            Console.WriteLine("Add using DB");
        }

        public void Delete()
        {
            //with 1000+ line of codes here
            Console.WriteLine("Delete using DB");
        }
    }

    #region -- Dependency Inversion --

    public interface IRepository
    {
        void Add();
        void Delete();
    }

    public class DatabaseRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Add using DB");
        }

        public void Delete()
        {
            Console.WriteLine("Delete using DB");
        }
    }

    #region -- Changed Implementation using API --

    public class APIIntegrationRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Add using WebAPI");
        }

        public void Delete()
        {
            Console.WriteLine("Delete using WebAPI");
        }
    }

    #endregion

    #region -- Changed Implementation using File --

    public class FileRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Add using FileSystem");
        }

        public void Delete()
        {
            Console.WriteLine("Delete using FileSystem");
        }
    }

    #endregion

    #endregion
}
