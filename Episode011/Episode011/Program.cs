using System;
using Episode011.Abstraction;

namespace Episode011
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- OOP --
            var iphone13 = new IPhone();
            iphone13.Color = "Silver";
            iphone13.Shape = "Square";
            iphone13.PowerOn();

            /*
            iphone13._microChip = "CHip001";
            iphone13.ConnectMainboardToPowerSupply();
            iphone13.OpenWifiChip();
            */

            //new SampleOperation()
            //    .Process();
            #endregion

            #region -- Abstract VS Interface --

            var pdf = new PDF();
            var word = new Word();
            Document pdfDoc = new PDF();
            Document WordDoc = new Word();

            var excel = new Excel();
            IDokumento dokumentoExcel = new Excel();
            dokumentoExcel.Print();

            Word newWord = new NewDocument();
            IDoc1 doc1Excel = new NewDocument();
            IDoc2 doc2Excel = new NewDocument();

            #endregion

            #region -- Generic --

            var processor = new SampleGeneric<TagaMultiply>();
            processor.Process(9, 9);
            var processorDiv = new SampleGeneric<TagaDivide>();
            processorDiv.Process(9, 9);

            var newProcessor = new SampleMultipleType<TagaAdd, SampleGeneric<TagaMinus>>();
            newProcessor.ExecuteNa(10, 5);

            processor.Get<TagaAdd>(new TagaAdd(), new TagaAdd());
            //Simplified version
            processor.Get(new TagaAdd(), new TagaAdd());

            #endregion
        }
    }
}
