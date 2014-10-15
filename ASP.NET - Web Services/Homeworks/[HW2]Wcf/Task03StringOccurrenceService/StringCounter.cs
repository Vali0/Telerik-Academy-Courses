using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace Task03StringOccurrenceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StringCounter : IStringCounter
    {
        public int CountHowMuchTimesStringApersInOtherString(string text, string word)
        {
            MatchCollection mathes = Regex.Matches(text.ToLower(), word.ToLower());

            int numberOfApears = mathes.Count;
            
            return numberOfApears;
        }
    }
}