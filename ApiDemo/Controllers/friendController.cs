using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class friendController : ControllerBase
    {

        public List<Friend> GetFriends()
        {
            List<Friend> friends = new List<Friend>(3);

            friends.Add(new Friend("Joynal", "Abedin", "Dhaka"));
            friends.Add(new Friend("Mehedi", "Hasan", "USA"));
            friends.Add(new Friend("Murad", "Wajed", "Australia"));

            return friends;
        }

    }
}
