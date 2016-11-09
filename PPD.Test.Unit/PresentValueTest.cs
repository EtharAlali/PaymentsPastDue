using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PPD.Test.Unit
{
    public class PresentValueTest
    {
        [Test]
        public void WhenCalculatingPresentValue_ThenItIncludesInterest()
        {
            var principal = 1000.00M;
            var apr = 39.9;

            Compounder compounder = new Compounder(principal, apr);
            Assert.That(compounder.PresentValueAt(89), Is.EqualTo(1085.31));
        }
    }
}
