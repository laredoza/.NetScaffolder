using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVCClient.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var a = this.User.IsInRole("Admin");
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");
            return View();
        }

        public async Task<IActionResult> Test()
        {
            return View("Test");
        }

        public async Task<IActionResult> ReturnApiIdentity()
        {
            var apiUrl = "http://localhost:5001/identity";

            var client = new HttpClient();
            var at = await this.HttpContext.GetTokenAsync("access_token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", at);
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewData["json"] = json;
            }
            else
            {
                ViewData["json"] = "Error: " + response.StatusCode;
            }

            return View("CallApi");
        }

        public async Task<IActionResult> PostTestAsync()
        {
            var apiUrl = "http://localhost:5001/Api/Product/ProductAdd";

            var client = new HttpClient();
            var at = await this.HttpContext.GetTokenAsync("access_token");

            //Expression<Func<ICustomer, object>>[] includes = new Expression<Func<ICustomer, object>>[]
            //{
            //   a => a.Country 
            //};

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", at);
            var response = await client.PostAsJsonAsync(apiUrl, new ProductDto
            {
                ProductId = 1,
                ProductDescription = "Test"
            });

            //var a = new HttpContent();
            //a.
            //var response = await client.PostAsync(apiUrl, new ProductDto
            //{
            //    ProductId = 1,
            //    ProductDescription = "Test"
            //});

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                ViewData["json"] = json;
            }
            else
            {
                ViewData["json"] = "Error: " + response.StatusCode;
            }

            return View("CallApi");
        }
    }
}