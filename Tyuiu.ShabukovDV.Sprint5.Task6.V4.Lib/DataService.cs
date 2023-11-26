using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tyuiu.ShabukovDV.Sprint5.Task6.V4.Lib
{
    public class DataService
    {
        public int LoadFromDataFile(string path)
        {

            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        count = Regex.Matches(line, "[А-Я]").Count;

                    }

                }

            }
            return count;
        }
    }
}
