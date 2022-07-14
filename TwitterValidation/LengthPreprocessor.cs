using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterValidation
{
    internal class LengthPreprocessor : TextPreprocessor
    {
        protected override bool Validate(string text)
        {
            return text.Length <= 280;
        }

        protected override string FixText(string text)
        {
            Console.WriteLine("\n>> Too long text! Cutting to 280 characters!\n"); // LOG

            return text.Substring(0, 280);
        }

    }
}
