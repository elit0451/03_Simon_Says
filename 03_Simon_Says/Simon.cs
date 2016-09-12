using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        public Simon()
        {
        }

        internal string Echo(string v)
        {
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();
        }

        internal string Repeat(string v)
        {
            return v + " " + v;
        }

        internal object Repeat(string v1, int v2)
        {
            string All = "";
            for (int i = 0; i < v2; i++)
            {
                All = All + " " + v1;
            }
            return All.Trim();
        }

        internal string StartOfWord(string v1, int v2)
        {
            v1 = v1.Substring(0, v2);
            return v1;
        }

        internal string FirstWord(string v)
        {
            v = v.Substring(0, v.IndexOf(" "));
            return v;
        }

        internal string Titleize(string v)
        {
            string[] words;
            words = v.Split(' ');
            string contain = "";
            bool firstWord = true;
            foreach (string word in words)
            {
                if (word == "and"||word == "over"|| word == "the" && firstWord == false)
                {
                    contain = contain + word + " ";
                }
                else
                {
                    string firstLetter = "";
                    firstLetter = word.Substring(0, 1);
                    contain = contain + firstLetter.ToUpper() + word.Substring(1) + " ";
                }
                firstWord = false;
            }
            return contain.Trim();

        }
    }
}