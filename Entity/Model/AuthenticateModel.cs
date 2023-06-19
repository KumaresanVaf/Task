using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class AuthenticateModel
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string created_Date { get; set; }
        public string LastModified_Date { get; set; }
        public string isActive { get; set; }
        public string Roll { get; set; }

    }
}
