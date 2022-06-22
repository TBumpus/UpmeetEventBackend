namespace UpmeetEventBackend.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        public List<Favorite> FavoriteList { get; set; }
        public User(int userId)
        {
            UserId = userId;
        }
    }


}
