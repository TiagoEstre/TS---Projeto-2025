using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iChat.models
{
    public class Messager
    {
        [Key]
        public int Id { get; set; }
        public User IdUser { get; set; }
        public string Message { get; set; }

        public Messager()
        {
        }
    }
}
