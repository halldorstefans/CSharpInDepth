using System;
using System.Globalization;

namespace CSharpInDepth
{
    class Chapter9
    {
        /// <summary>
        /// Test interpolated string literals
        /// </summary>
        public void InterpolatedStringLiterals()
        {
            Console.WriteLine("***INTERPOLATED STRING LITERALS***");

            var price = 105.64m;
            var tip = price * 0.15m;

            Console.WriteLine($"Price:{price,10:C}");
            Console.WriteLine($"Tip:  {tip,10:C}");
            Console.WriteLine($"Total:{price + tip,10:C}");
        }

        /// <summary>
        /// Test FormattableString
        /// </summary>
        public void FormattableString()
        {
            Console.WriteLine("\n***FORMATTABLESTRING***");

            var dateOfBirth = new DateTime(1675, 10, 25);
            FormattableString fString = $"You were born on {dateOfBirth:d}";
            var culture = CultureInfo.GetCultureInfo("en-GB");

            Console.WriteLine(fString.ToString(culture));
        }

        /// <summary>
        /// Test of nameOf()
        /// </summary>
        public void NameOfMethod()
        {
            Console.WriteLine($"This method is called: {nameof(NameOfMethod)}");
        }

    }
}
    