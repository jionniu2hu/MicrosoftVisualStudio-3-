using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class UserDetails
    {
        public int UserDetailsID { get; set; }
        [Display(Name = "账号")]
        public string UserName { get; set; }
        [Display(Name = "密码")]
        public string Password { get; set; }
        public UserStatus Status { get; set; }
    }
}