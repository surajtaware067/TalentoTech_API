using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetailes(string userName, string password);
    }
}
