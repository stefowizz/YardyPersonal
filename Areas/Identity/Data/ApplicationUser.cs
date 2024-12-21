﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace YardyRiver.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Column(TypeName ="nvarchar(100)")]
    [PersonalData]
    public string FirstName { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [PersonalData] 
    public string LastName { get; set; } 
}

