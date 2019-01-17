using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Data.ApplicationServices.WebApiApplicationService.ApplicationService;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            //var apiUrl = "http://localhost:5001/identity";

            //var client = new HttpClient();
            //var at = await this.HttpContext.GetTokenAsync("access_token");

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", at);
            //var response = await client.GetAsync(apiUrl);

            //if (response.IsSuccessStatusCode)
            //{
            //    var json = await response.Content.ReadAsStringAsync();
            //    ViewData["json"] = json;
            //}
            //else
            //{
            //    ViewData["json"] = "Error: " + response.StatusCode;
            //}

            WebApiCustomerApplicationService applicationService = new WebApiCustomerApplicationService(new WebApiSettings{ BasePath = "http://localhost:5001/api", Bearer = await this.HttpContext.GetTokenAsync("access_token") });

            //var resultCustomerLoadAllAsync = await applicationService.CustomerLoadAllAsync(true);
            //var resultCustomerLoadAll =  applicationService.CustomerLoadAll(true);
            //var resultLoadByCustomerCustomerId = applicationService.LoadByCustomerCustomerId(1,true);
            //var resultLoadByCustomerCustomerIdAsync = await applicationService.LoadByCustomerCustomerIdAsync(1, true);

            //var resultCustomerSearchByCustomerCodeAsync = await applicationService.CustomerSearchByCustomerCodeAsync("001", false, true);
            //var resultCustomerSearchByCustomerCode = applicationService.CustomerSearchByCustomerCode("001", false, true);

            var customer1 = new CustomerDto
            {
                CustomerId = 9,
                Address = "My Address",
                City = "Pretoria",
                CompanyName = "My Company 1",
                ContactName = "Context 1",
                ContactTitle = "Title",
                CustomerCode = "009"
            };

            var customer2 = new CustomerDto
            {
                CustomerId = 10,
                Address = "My Address",
                City = "Pretoria",
                CompanyName = "My Company 2",
                ContactName = "Context 1",
                ContactTitle = "Title 2",
                CustomerCode = "010"
            };

            applicationService.CustomerAdd(customer1);
            await applicationService.CustomerAddAsync(customer2);

            customer1.Address = "Changed Address";
            customer2.Address = "Changed Address";

            applicationService.CustomerUpdate(customer1);
            await applicationService.CustomerUpdateAsync(customer2);

            //applicationService.CustomerDelete(customer1);
            //await applicationService.CustomerDeleteAsync(customer2);


            //ViewData["json"] = JsonConvert.SerializeObject(resultCustomerLoadAllAsync);
            ViewData["json"] = JsonConvert.SerializeObject(true);
            return View("CallApi");
        }

        public async Task<IActionResult> PostTestAsync()
        {
            var apiUrl = "http://localhost:5001/Api/Product/ProductAdd";

            var client = new HttpClient();
            var at = await this.HttpContext.GetTokenAsync("access_token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", at);
            var response = await client.PostAsJsonAsync(apiUrl, new ProductDto
            {
                ProductId = 1,
                ProductDescription = "Test"
            });

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