using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint3.TaskReview.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = {7.76, 7.36, 7.26, 7.90, 15.88, 2.00, 4.35, 5.63, 6.49, 6.49, 6.32};

            CollectionAssert.AreEqual(res, ds.GetMassFunction(-5, 5));
        }
    }
}
