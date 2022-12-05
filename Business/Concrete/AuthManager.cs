using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants.Messages;
using Core.Entities.Concrete;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserCoreService _userCoreService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserCoreService userCoreService, ITokenHelper tokenHelper)
        {
            _userCoreService = userCoreService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<UserCore> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new UserCore
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userCoreService.Add(user);
            return new SuccessDataResult<UserCore>(user, Messages.UserRegistered);
        }

        public IDataResult<UserCore> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userCoreService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<UserCore>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<UserCore>(Messages.PasswordError);
            }

            return new SuccessDataResult<UserCore>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userCoreService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(UserCore user)
        {
            var claims = _userCoreService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
