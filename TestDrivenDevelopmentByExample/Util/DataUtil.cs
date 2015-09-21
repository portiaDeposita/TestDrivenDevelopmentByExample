using System;

namespace TestDrivenDevelopmentByExample.Util
{
    public class DataUtil
    {
        public int SearchNumberOfOccurances(String searchword, string paragraphtosearchfrom)
        {
            var splitWords = paragraphtosearchfrom.Split(' ');
            int numberOfWordOccurancies = 0;
            foreach (string word in splitWords)
            {

                if (word.ToLower().Contains(searchword.ToLower()))
                {
                    numberOfWordOccurancies += 1;
                }
            }
            return numberOfWordOccurancies > 0 ? numberOfWordOccurancies : -1;
        }
    }
}