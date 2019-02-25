using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;

namespace DotNetScaffolder.IdentityServer.Services.WebApi.IdentityServer.Identity4
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private IIdentityServerApplicationService applicationService;
        private IPasswordHasher<AspNetUserDto> passwordHasher;

        public ResourceOwnerPasswordValidator(IIdentityServerApplicationService applicationService, IPasswordHasher<AspNetUserDto> passwordHasher)
        {
            this.applicationService = applicationService;
            this.passwordHasher = passwordHasher;
        }

        //repository to get user from db
        //private readonly IUserRepository _userRepository;

        //public ResourceOwnerPasswordValidator(IUserRepository userRepository)
        //{
        //    _userRepository = userRepository; //DI
        //}

        //this is used to validate your user account with provided grant at /connect/token
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var a = "";
            //passwordHasher.HashPassword()
            //try
            //{
            //    //get your user model from db (by username - in my case its email)
            //    var user = await _userRepository.FindAsync(context.UserName);
            //    if (user != null)
            //    {
            //        //check if password match - remember to hash password if stored as hash in db
            //        if (user.Password == context.Password)
            //        {
            //            //set the result
            //            context.Result = new GrantValidationResult(
            //                subject: user.UserId.ToString(),
            //                authenticationMethod: "custom",
            //                claims: GetUserClaims(user));

            //            return;
            //        }

            //        context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Incorrect password");
            //        return;
            //    }
            //    context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "User does not exist.");
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Invalid username or password");
            //}
        }

        public async Task<bool> ValidateAsync(string username, string password)
        {
            //passwordHasher.HashPassword()
            try
            {
                //get your user model from db (by username - in my case its email)
                var user = await applicationService.ReturnUserAsync(username);
                if (user != null)
                {
                    //check if password match - remember to hash password if stored as hash in db
                    if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password.ToLower()) == PasswordVerificationResult.Success)
                    {
                        //set the result
                        return true;
                        //context.Result = new GrantValidationResult(
                        //    subject: user.UserId.ToString(),
                        //    authenticationMethod: "custom",
                        //    claims: GetUserClaims(user));

                        //return;
                    }

                    // context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Incorrect password");
                    return false;
                }

                // context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "User does not exist.");
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
                // context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "Invalid username or password");
            }

            return false;
        }

        //build claims array from user data
        //public static Claim[] GetUserClaims(User user)
        //{
        //    return new Claim[]
        //    {
        //    new Claim("user_id", user.UserId.ToString() ?? ""),
        //    new Claim(JwtClaimTypes.Name, (!string.IsNullOrEmpty(user.Firstname) && !string.IsNullOrEmpty(user.Lastname)) ? (user.Firstname + " " + user.Lastname) : ""),
        //    new Claim(JwtClaimTypes.GivenName, user.Firstname  ?? ""),
        //    new Claim(JwtClaimTypes.FamilyName, user.Lastname  ?? ""),
        //    new Claim(JwtClaimTypes.Email, user.Email  ?? ""),
        //    new Claim("some_claim_you_want_to_see", user.Some_Data_From_User ?? ""),

        //    //roles
        //    new Claim(JwtClaimTypes.Role, user.Role)
        //    };
        //}
    }
}
