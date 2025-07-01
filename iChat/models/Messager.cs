// iChat.Models/Messager.cs

namespace iChat.Models
{
    public class Messager
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Message { get; set; } = null!;
        // any other fields…
    }
}
