using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Polyg.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var content = "";

            using (StreamReader sr = new StreamReader("resources.txt"))
            {
                content = sr.ReadToEnd();
            }

            var lines = content.Split("\n")
                .Where(line => line.Trim() != "");


            var json = lines.Select(line => {
                var phrase = line.Split('-');
                return new
                {
                    English = phrase[0].Trim(),
                    Spanish = phrase[1].Trim(),
                    Word = phrase.Length > 2 ? phrase[2].Trim() : ""
                };
            }).ToList();

            using (StreamWriter sw = new StreamWriter("formated.json"))
            {
                sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(json));
            }

            Console.WriteLine(content);
        }
    }
}
