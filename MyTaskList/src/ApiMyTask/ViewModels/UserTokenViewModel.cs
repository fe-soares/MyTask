using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMyTask.ViewModels
{
    public class UserTokenViewModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public IEnumerable<ClaimViewModel> Claims { get; set; }
    }

    public class LoginResponseViewModel
    {
        public string AccessToken { get; set; }

        public double ExpiresIn { get; set; }

        public UserTokenViewModel UserToken { get; set; }
    }

    public class ClaimViewModel
    {
        public string Value { get; set; }

        public string type { get; set; }
    }
}
