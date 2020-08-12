using ExceptionsAndErrorHandling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExceptionsAndErrorHandling
{
    public class HandleLogic
    {
        private Logic logic;

        public HandleLogic()
        {
            logic = new Logic();
        }

        public int RunLogic1(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ScubaException("the numbers array is empty", 16);

            }
            else if (numbers.Count() > 0)
            {
                throw new ScubaException("the numbers array is empty", 16);
            }
            else
            {
                return logic.Logic1(numbers);
            }
        }

        public void RunLogic2(string inputFileName, string outputFileName)
        {
            try
            {
                 logic.Logic2(inputFileName,outputFileName);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("the path to the file not found");
                throw;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("you cant send null to a file path");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }        
        }

        public int RunLogic3(string data)
        {
            int result;

            if (int.TryParse( data, out result))
            {
                return logic.Logic3(data);
            }
            else
            {
                throw new ScubaException("the data must be type int", 16);
            }
        }

        public void RunLogic4(string data1, int data2, long data3)
        {
            try
            {
                logic.Logic4(data1, data2, data3);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public void RunLogic5(string dllName)
        {
            try
            {
                logic.Logic5(dllName);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("the path to the dll not found");
                throw;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("you cant send null to a dll file path");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

    }
}
