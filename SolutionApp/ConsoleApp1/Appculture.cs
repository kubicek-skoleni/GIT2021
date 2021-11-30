using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class AppCulture
    {


        public static CultureInfo? VratCulturu(string jazyk)
        {
            try
            {
                return new CultureInfo(jazyk);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
