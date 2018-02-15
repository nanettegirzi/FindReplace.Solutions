using System.Collections.Generic;
using System;

namespace FindReplace.Models
{
    public class FindAndReplace
    {
        private string _userWord;      //This is the word that will replace _replaceThis
        private string _replaceThis;    //This is the word being replaced.
        private string _userSentence;   //This is the sentance that the words will be
        //replaced at.

        public FindAndReplace (string userSentence, string replaceThis, string userWord)
        {
            _userWord = userWord;
            _replaceThis = replaceThis;
            _userSentence = userSentence;
        }

        public string GetUserWord()
        {
            return _userWord;
        }

        public string GetReplaceThis()
        {
            return _replaceThis;
        }

        public string GetUserSentence()
        {
            return _userSentence;
        }

        public string ReplaceWords()
        {
            return _userSentence.Replace(_replaceThis, _userWord);
        }

    }

}
