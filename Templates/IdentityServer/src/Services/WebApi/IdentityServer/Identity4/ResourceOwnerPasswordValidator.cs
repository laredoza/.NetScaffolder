﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;

namespace DotNetScaffolder.IdentityServer.Services.WebApi.IdentityServer.Identity4
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        //repository to get user from db
        //private readonly IUserRepository _userRepository;

        //public ResourceOwnerPasswordValidator(IUserRepository userRepository)
        //{
        //    _userRepository = userRepository; //DI
        //}

        //this is used to validate your user account with provided grant at /connect/token
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
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
