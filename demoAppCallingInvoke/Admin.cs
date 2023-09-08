using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoAppCallingInvoke
{
    public class Admin
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime createdAt { get; set; }
        public int createdBy { get; set; }
        //public DateTime updatedAt { get; set; }
        public int updatedBy { get; set; }
        // public Int16 isSuperAdmin { get; set; }

    }
}
