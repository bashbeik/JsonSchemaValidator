using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonSchemaValidatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "JSON is valid against schema from 'not'. Path '[2]', line 4332, position 24.";
            s = s.Substring(s.IndexOf("line "));
            s = s.Substring(0, s.IndexOf(","));
            s = s.Replace("line ", "");
            s = s.Replace(",", "");
            int i = Convert.ToInt32(s);
            i++;
            Console.WriteLine(i);
        }
    }
}
