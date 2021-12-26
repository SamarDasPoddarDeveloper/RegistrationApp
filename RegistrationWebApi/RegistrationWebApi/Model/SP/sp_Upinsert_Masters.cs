using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationWebApi.Model.SP
{
    public class BaseProperty
    {
        [Key]
        public int Code { get; set; }
        public string Info { get; set; }
    }

    public class Regisdata : BaseProperty { }
    
}
