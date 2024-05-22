using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Picture { get; set; }
    }
}
