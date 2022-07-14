using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterValidation
{
    abstract internal class TextPreprocessor
    {
        /// <summary>
        /// Base method which checks the text
        /// </summary>
        /// <param name="text">The text variable that is required to be passed as reference</param>
        public void PrepareText(ref string text)
        {
            if (!Validate(text))
            {
                text = FixText(text);
            }
        }

        /// <summary>
        /// Private validation method that is only being called from base public method. This method is virtual 
        /// in order to make child preprocessors override it, because each preprocessor validates in its own way
        /// </summary>
        /// <param name="text">The text variable that will be validated</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected abstract bool Validate(string text);
        /// <summary>
        /// In case text has been found invalid, then it has to be fixed. Each preprocessor fixes it in its own way
        /// </summary>
        /// <param name="text">The text variable that will be fixed</param>
        /// <returns></returns>
        protected abstract string FixText(string text);

    }
}
