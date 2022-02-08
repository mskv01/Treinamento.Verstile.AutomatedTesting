using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Versatile.UIAutomatedTesting.Configurations.Helpers
{
    public class SystemProperties
    {
        public static string PathProject = AppDomain.CurrentDomain.BaseDirectory.ToString().Remove(AppDomain.CurrentDomain.BaseDirectory.ToString().LastIndexOf("\\") - 23);
    }
}
