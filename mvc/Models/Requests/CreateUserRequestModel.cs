using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace mvc.Models.Requests
{
    public class CreateUserRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
