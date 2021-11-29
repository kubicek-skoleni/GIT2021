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
        public CultureInfo VratCulturu(string _jazyk)
        {
            try
            {
                return new CultureInfo(_jazyk);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
