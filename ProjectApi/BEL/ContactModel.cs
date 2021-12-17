using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class ContactModel
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
