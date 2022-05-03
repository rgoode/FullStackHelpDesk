namespace BackEndApi.Models
{
    public class PostUserRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool IsFavorite { get; set; }
    }
}
