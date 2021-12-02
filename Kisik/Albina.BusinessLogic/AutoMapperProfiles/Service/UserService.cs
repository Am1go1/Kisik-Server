using Albina.BusinessLogic.Core.Interfaces;
using Albina.BusinessLogic.Core.Models;
using AutoMapper;
using Kisik.DataAccess.Core.Interfaces;
using Kisik.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using Shareds.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinessLogic.AutoMapperProfiles.Service
{
    class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _context;

        public UserService(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInformationBlo> Get (int userId)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user == null) throw new NoteFoundException($"Пользователь с id {userId} не найден");
            UserInformationBlo userInformationBlo = await ConvertToUserInformation(user);
            return userInformationBlo;
        }

        public Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }
        private async Task<UserIdentityBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw ArgumentNullException(nameof(userRto));
            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);
            return userInformationBlo;
        }
    }
}
