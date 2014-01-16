using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class ScoreBoard_It_Functions : CoreInfo
    {
        public int add, paddsubtract,subtract;
        public ScoreBoard_It_Functions()
        {
            subtract = CoreInfo.NM;
            add = CoreInfo.HTID;
            paddsubtract = CoreInfo.PScore;
        }
        public int Add(int num)
        {
            num += add;
            return num;
        }
        public int Add(int num, bool pass)
        {
            num += paddsubtract;
            return num;
        }
        public int Subtract(int num)
        {
            num -= subtract;
            return num;
        }
        public int Subtract(int num, bool pass)
        {
            num += paddsubtract;
            return num;
        }
        
    }
   
}
