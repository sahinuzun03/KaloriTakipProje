using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using KaloriDeneme_1111.ModelCluster;

namespace KaloriDeneme_1111.ModelCluster
{
    public class User
    {
        public int UserID { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public UserDetail UserDetail { get; set; } //one to one ilişki
        public ICollection<Meal>Meals { get; set; }
        private User()
        {
            Meals = new List<Meal>();
        }
        private static User user;
        public static User UserGenerate()
        {
            if (user==null)
            {
                user = new User() { UserDetail = new UserDetail() { }, Meals=new List<Meal>() };
            }
            return user;
        }
       
    }


}

