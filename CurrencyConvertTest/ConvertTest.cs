using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverterForms;

namespace CurrencyConvertTest
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void ConversionBreadth()
        {
            decimal result;
            decimal amount;

            CurrencyType fromCur;
            CurrencyType toCur;
            amount = 100.0M;
            fromCur = CurrencyType.US;
            toCur = CurrencyType.US;
            result = FrmCurrency.CurrencyConvert(amount, fromCur, toCur);
            Assert.AreEqual(100.0M, result, "&quot; US to US should be no change & quot;");
            fromCur = CurrencyType.UK;
            toCur = CurrencyType.UK;
            result = FrmCurrency.CurrencyConvert(amount, fromCur, toCur);
            Assert.AreEqual(100.0M, result, "&quot; UK to UK should be no change & quot;");
            fromCur = CurrencyType.AUS;
            toCur = CurrencyType.AUS;
            result = FrmCurrency.CurrencyConvert(amount, fromCur, toCur);
            Assert.AreEqual(100.0M, result, "&quot; AUS to AUS should be no change & quot;");
            decimal expected;
            fromCur = CurrencyType.US;
            toCur = CurrencyType.AUS;
            result = FrmCurrency.CurrencyConvert(amount, fromCur, toCur);
            expected = amount * 2;
            Assert.AreEqual(expected, result, "&quot; US to AUS is incorrect & quot;");
            fromCur = CurrencyType.UK;
            toCur = CurrencyType.AUS;
            result = FrmCurrency.CurrencyConvert(amount, fromCur, toCur);
            expected = amount / 0.5M * 2;
            Assert.AreEqual(expected, result, "&quot; UK to AUS is incorrect & quot;");
        }
    }
}
