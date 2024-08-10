using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entities;


namespace TalentoTrack.Common.Entities
{
    public  class LoginDetails
    {
        public int Id { get; set; }
        public int  UserId  { get; set; }
        public string UserName { get; set; }
        public string  Password { get; set; }
        public bool IsBlocked { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
