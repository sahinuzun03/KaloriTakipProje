using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriDeneme_1111.Exceptions
{
   public class ExceptionMailOnayKoduHatası:Exception
    {

        public ExceptionMailOnayKoduHatası():base("Kaydınız oluşturulamadı, lütfen onay kodunuzu kontrol edin!")
        {

        }
    }
}
