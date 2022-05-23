using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Замена_слова_в_тексте
{
    internal class Replacement
    {
        public string change;
        public string changeTo;
        public string input;
        public string outp;
        public Replacement(string change, string changeTo, string input)
        {
            this.change = change;
            this.changeTo = changeTo;
            this.input = input;
        }

        public string Replace()
        {
            outp = input.Replace(change, changeTo);
            return outp;
        }
    }
}
