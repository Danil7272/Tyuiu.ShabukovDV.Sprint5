using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShabukovDV.Sprint5.Task4.V7.Lib
{
    public class DataService
    {
        
            public double LoadFromDataFile(string path)
            {
                string strX = File.ReadAllText(path);
                double x = Convert.ToDouble(strX.Replace(".", ","));
                double res = Math.Round(1.0 / Math.Cos(x) + Math.Pow(x, 3), 3);
                return res;
            }
        
    }
}
