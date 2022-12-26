using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithMosh1
{
  public  class StringUtility
    {
      public  static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');//return all words that are seperated by ' ', and store it an string array.
                var totalCharacters = 0;// array element count(word  count)
                var summaryWords = new List<string>(); //store only summary words in this list

                foreach (var word in words)
                {
                    summaryWords.Add(word);//add each array element to the list
                    totalCharacters += word.Length + 1;//iterate over array and get total character length(+1 is space after word)
                    if (totalCharacters > maxLength)
                    {
                        break; //if total characters greater than 20, then we need to stop loop to get summary words
                    }

                }
                // join the list items ,and  separated by them " ". and add ... to end
                return String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
