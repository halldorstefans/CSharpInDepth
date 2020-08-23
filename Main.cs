using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var mainClass = new MainClass();

            mainClass.CallChapter2();
            mainClass.CallChapter3();
            mainClass.CallChapter4();
            mainClass.CallChapter5_6();
            mainClass.CallChapter8();
            mainClass.CallChapter9();
        }

        private void CallChapter2()
        {
            Console.WriteLine("----------CHAPTER 2----------");

            var chapter2 = new Chapter2();
            
            chapter2.Generics();
            chapter2.Nullables();
            chapter2.Delegates();
            chapter2.Yields();
        }

        private void CallChapter3()
        {
            Console.WriteLine("\n----------CHAPTER 3----------");

            var chapter3 = new Chapter3();

            chapter3.ObjectInitializer();
            chapter3.AnonymousType();
            chapter3.LambdaExpression();
            chapter3.ExtensionMethod();
            chapter3.QueryExpression();
        }

        private void CallChapter4()
        {
            Console.WriteLine("\n----------CHAPTER 4----------");

            var chapter4 = new Chapter4();

            chapter4.DynamicTyping();
            chapter4.OptionalParametersNamedArguments();
        }

        private void CallChapter5_6()
        {
            Console.WriteLine("\n----------CHAPTER 5 & 6----------");

            var chapter5_6 = new Chapter5_6();

            chapter5_6.AsyncAwait();
        }

        private void CallChapter8()
        {
            Console.WriteLine("\n----------CHAPTER 8----------");

            var chapter8 = new Chapter8();

            chapter8.AutomaticProps();
            chapter8.ExpressionMembers();
        }

        private void CallChapter9()
        {
            Console.WriteLine("\n----------CHAPTER 9----------");

            var chapter9 = new Chapter9();

            chapter9.InterpolatedStringLiterals();
            chapter9.FormattableString();
            chapter9.NameOfMethod();
        }
    }
}