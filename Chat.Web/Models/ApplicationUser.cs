﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Chat.Web.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
