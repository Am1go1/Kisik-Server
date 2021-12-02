using Albina.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Get(int userId);
        Task<bool> DoesExist(int numberPrefix, int number);
    }
}
