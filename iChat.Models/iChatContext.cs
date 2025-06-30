// iChat.Models/iChatContext.cs
using System.Data.Entity;

namespace iChat.Models
{
    public class iChatContext : DbContext
    {
        public iChatContext()
            : base("name=iChatContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Messager> Messagers { get; set; }
    }
}
