using System;
namespace Episode012.SOLID
{
    public class PDFDocument
    {
        public void PrintPDF()
        {
        }

        public void CalculateQuadraticEquation()
        {
        }
    }

    #region -- Single Responsibiliy Principle --

    public class Word
    {
        public void Print()
        {
        }
    }

    public class QuadraticEquation
    {
        public void Calculate()
        {
        }
    }

    #endregion
}
