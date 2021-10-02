using System;
namespace Episode011
{
    public class SampleOperation
    {
        public void Process()
        {
            TagaCompute add = new TagaAdd();
            add.Compute(1, 2);
            //add._result = 0;
            Console.WriteLine($"Add: {add.Result}");

            var addWith10 = new TagaAddWith10();
            TagaCompute tagaCompute = addWith10;
            tagaCompute.Compute(1, 2);
            Console.WriteLine($"Add: {tagaCompute.Result}");
        }
    }

    public class TagaAdd: TagaCompute {}
    public class TagaMinus : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 - num2;
        }
    }

    public class TagaMultiply : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 * num2;
        }
    }
    public class TagaDivide : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            _result = num1 / num2;
        }
    }

    public class TagaAddWith10 : TagaCompute
    {
        public override void Compute(int num1, int num2)
        {
            num1 += 10;
            num2 += 10;
            base.Compute(num1, num2);
        }
    }
}
