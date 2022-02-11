using System;

namespace Model
{
    public class User
    {
        public int UserID { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public UserDetail UserDetail { get; set; }
        public int? UserDetailID { get; set; }
        public virtual Meal Meal { get; set; }
        public int? MealID { get; set; }
    }


}
}
