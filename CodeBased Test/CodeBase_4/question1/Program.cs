using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // specify the path



            string path = @"D:\CSharp Training\CodeBased Test\CodeBase_4\example";



            try
            {
                using (StreamWriter writer = new StreamWriter(@"D:\CSharp Training\CodeBased Test\CodeBase_4\example", true))
                {
                    string append = "my name is sonu";



                    writer.WriteLine(append);



                    writer.Close();
                }
                Console.WriteLine("text is appened success");
            }
            catch (Exception e)
            {
                Console.WriteLine("error");



            }
        }
    }
}
