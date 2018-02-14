using System.Collections.Generic;
using System;

namespace FindReplace.Models
{
    public class FindAndReplace
    {
        private string _UserInput;

        public FindAndReplace (string UserInput)
        {
            _UserInput= UserInput;
        }

        public string ReplaceWords()
        {
            return "world";
        }

    }

}
