using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hospital.Areas.Identity.Data;

// Add profile data for application users by adding properties to the HospitalUser class
public class HospitalUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

