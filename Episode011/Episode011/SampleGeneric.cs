using System;
namespace Episode011
{
    public class SampleGeneric<T>
        where T: TagaCompute , new()
    {
        public void Process(int num1, int num2)
        {
            T t = new T();
            t.Compute(num1, num2);
            Console.WriteLine($"Compute: {t.Result}");
        }

        public Ace Get<Ace>(Ace ace1, Ace ace2)
            where Ace: class, new()
        {
            return ace1;
        }

        public TagaAdd Get(TagaAdd ace1, TagaAdd ace2)
        {
            return ace1;
        }
    }


    public class SampleMultipleType<Una, Pangalawa>
        where Una: TagaCompute, new()
        where Pangalawa: SampleGeneric<TagaMinus>, new()
    {
        public void ExecuteNa(int num1, int num2)
        {
            Una una = new Una();
            Pangalawa pangalawa = new Pangalawa();

            una.Compute(num1, num2);
            Console.WriteLine($"Una: {una.Result}");

            pangalawa.Process(num1, num2);
        }
    }
}
