using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNetCore_Episode007.Entities
{
    [Keyless]
    public class Gender
    {
        public string Name { get; set; }
    }
}
