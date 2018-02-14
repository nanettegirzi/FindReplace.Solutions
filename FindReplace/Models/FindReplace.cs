using System.Collections.Generic;
using System;

namespace FindReplace.Models
{
    public class FindAndReplace
    {
        private string _userInput;      //This is the word that will replace _replaceThis
        private string _replaceThis;    //This is the word being replaced.
        private string _userSentance;   //This is the sentance that the words will be
                                        //replaced at.

        public FindAndReplace ( string userSentance, string replaceThis, string userInput)
        {
            _userInput = userInput;
            _replaceThis = replaceThis;
            _userSentance = userSentance;
        }

        public string ReplaceWords()
        {
            return _userSentance.Replace(_replaceThis, _userInput);
        }

    }

}
