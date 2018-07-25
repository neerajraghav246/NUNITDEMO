using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExample
{
    public class SentenceParser
    {
        public int GetNoofWordsInString(string words)
        {
            int count = 1;
            int nextspaceposition = words.IndexOf(" ");
            while (nextspaceposition != -1 && words.Length != 0)
            {
                words = words.Remove(0, nextspaceposition + 1);
                count++;
                nextspaceposition = words.IndexOf(" ");
            }
            return count;
        }
    }
}
