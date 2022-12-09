using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethods.Extensions  // podemos simplesmente declarar o namespace da classe como do System, pois os tipos já pertence a ele
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)  // esse é um metodo de extensão do tipo datetime -> this primeiro e o tipo desejado
        {
            //TimeSpan duration = DateTime.Now - thisObj; //  há diversas maneiras de realizar a lógica desejada
            TimeSpan duration = DateTime.Now.Subtract(thisObj);  // o parametro this apresenta-se sendo como o próprio objeto passado na invocação

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
