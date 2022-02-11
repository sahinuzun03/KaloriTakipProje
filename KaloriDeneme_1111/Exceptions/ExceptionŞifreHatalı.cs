using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriDeneme_1111.Exceptions
{
  public  class ExceptionŞifreHatalı:Exception
    {
        public ExceptionŞifreHatalı():base("Girmiş olduğunuz şifre veya kullanıcı adı yanlıştır!!")
        {

        }
    }
}
