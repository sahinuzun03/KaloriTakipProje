using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriDeneme_1111.Exceptions
{
    public class ExceptionKullanıcıAdıUzunluk:Exception
    {
        public ExceptionKullanıcıAdıUzunluk():base("En az 3 karakterli bir kullanıcı adı girmelisiniz")
        {

        }
    }
}
