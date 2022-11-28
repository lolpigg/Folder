using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder
{
    class Arrow
    {
        int Max, Min, Cur;
        string ArrowStr = "->";
        public Arrow(int Max, int Min, int Cur)
        {
            this.Cur = Min;
            this.Max = Max;
            this.Min = Min;
        }
        public static void ArrowAct(string Where)
        {
            if (Where == "Up")
            {

            }
            else if (Where == "Down")
            {

            }
        }
    }
}
