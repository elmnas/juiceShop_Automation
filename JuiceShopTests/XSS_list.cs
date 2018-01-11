using System;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace JuiceShopTests
{
    public class XSS_list
    {

        public static void userNames()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"Expressions\XSSExpressions.txt"))
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("The file could not be found");
                Console.WriteLine(ex.Message);
            }     
        }
          
    

        public static void Passwords()
        {
            throw new NotImplementedException();
        }
    }

}