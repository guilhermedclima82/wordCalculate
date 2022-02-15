using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareWordsLenght.Business
{
    public class WordCalculate
    {
        public string WordsToCalculate(string[] obj)
        {
            var t = obj.OrderByDescending(x => x.Length);
            
            return t.FirstOrDefault();
        }
    }
}
