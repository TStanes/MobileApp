using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobas_Mob.Converters
{
    public class IndexPlusOneConverter : IValueConverter
    {
        public object Convert(object value, Type t, object p, CultureInfo c)
           => (int)value + 1;

        public object ConvertBack(object value, Type t, object p, CultureInfo c)
            => throw new NotImplementedException();
    }
}
