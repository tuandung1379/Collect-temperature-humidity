using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempHumi
{
    public class Hc
    {
        public DateTime m_dtTime;
        public int m_Temp;
        public int m_Humi;

        public Hc(DateTime dtTime, int Temp, int Humi)
        {
            m_dtTime = dtTime;
            m_Temp = Temp;
            m_Humi = Humi;
        }
    }
}
