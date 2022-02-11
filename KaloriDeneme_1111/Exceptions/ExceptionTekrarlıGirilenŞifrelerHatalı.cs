using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriDeneme_1111.Exceptions
{
   public class ExceptionTekrarlıGirilenŞifrelerHatalı:Exception
    {
        public ExceptionTekrarlıGirilenŞifrelerHatalı():base("Lütfen şifrelerin doğruluğunu kontrol ediniz!")
        {

        }
    }
}
