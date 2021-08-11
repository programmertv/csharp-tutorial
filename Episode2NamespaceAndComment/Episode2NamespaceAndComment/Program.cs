using System;
using System.Collections;
using Episode2NamespaceAndComment.Fruits;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Fighters;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Assasins;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Mages;
using Episode2NamespaceAndComment.Heroes.Pinoy.Tagalog;
using Episode2NamespaceAndComment.Heroes.Pinoy.Bisaya;
using PinoyHeroNaBisaya = Episode2NamespaceAndComment.Heroes.Pinoy.Bisaya;

namespace Episode2NamespaceAndComment
{
    class Program
    {
        ///summary>
        /// This is a sample document comment only
        /// </summary>
        /// <param name="args">this paramm will hold the parameter values</param>
        static void Main(string[] args)
        {
            #region -- Namespace Demo --

            Console.WriteLine("Hello World!");
            var queue = new Queue();
            var banana = new Banana();
            var apple = new Episode2NamespaceAndComment.Fruits.Apple();

            var alpha = new Alpha();
            var ling = new Ling();
            var kagura = new Kagura();

            var valir = new Valir();

            var rizal = new Rizal();
            var kudarat = new Kudarat();

            var lapulapu = new PinoyHeroNaBisaya.LapuLapu();

            #endregion

            #region -- Comment Demo --

            //this num1 variable is for demo purposes only
            var num1 = 0;
            var num2 = 1; //this is another sample for demo purposes only
            var num3 = 1 + 5; //this is a sample on how to "ADD" to numbers
            /* 
                test
                multiple
                comment
                only
             */
            var testCommentOnly = "";
            //Main(new[] { "a", "b" });

            #endregion
        }
    }
}
