﻿using System;

namespace ExcemptionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (UserException ex)
            {
                Console.WriteLine($"{ex.Message}; number is {ex.NumberInError}") ;
            }

        }

        static void Run()
        {
            Test();
            var ex = new UserException("This exception was forced!");
            ex.NumberInError = 42;
            throw ex;
        }

        static void Test()
        {
            Divide();        
        }

        static void Divide()
        {
            try
            {
                var num = 1;
                var denom = 0;
                var ans = num / denom;
            } 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}");
                //throw;
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"General exception occured: {ex.Message}");
            }

        }
    }
}
