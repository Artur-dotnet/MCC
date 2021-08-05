using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Server:BaseModel
    {
        public string Name { get; set; }

        // создатель
        public int UserId { get; set; }
        public User User { get; set; }

        public List<Group> Groups { get; set; }
    }
}
