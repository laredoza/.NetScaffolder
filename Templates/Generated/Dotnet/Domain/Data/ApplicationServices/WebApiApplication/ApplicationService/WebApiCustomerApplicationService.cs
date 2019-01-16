using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using Newtonsoft.Json;

namespace DotNetScaffolder.Domain.Data.ApplicationServices.WebApiApplicationService.ApplicationService
{
    public class WebApiCustomerApplicationService : ICustomerApplicationService
    {
        public IWebApiSettings apiSettings { get; set; }

        public WebApiCustomerApplicationService(IWebApiSettings apiSettings)
        {
            this.apiSettings = apiSettings;
        }

        public CustomerDto LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            CustomerDto result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/LoadByCustomerCustomerId/{customerId}/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.GetAsync(apiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<CustomerDto>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<CustomerDto> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            CustomerDto result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/LoadByCustomerCustomerIdAsync/{customerId}/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<CustomerDto>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public IList<CustomerDto> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            IList<CustomerDto> result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerLoadAll/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.GetAsync(apiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<IList<CustomerDto>>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<IList<CustomerDto>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            IList<CustomerDto> result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerLoadAllAsync/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IList<CustomerDto>>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public IList<CustomerDto> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            IList<CustomerDto> result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerSearchByCustomerCode/{customerCode}/{caseSensitive}/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.GetAsync(apiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<IList<CustomerDto>>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<IList<CustomerDto>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache,
            params Expression<Func<ICustomer, object>>[] includes)
        {
            IList<CustomerDto> result;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerSearchByCustomerCodeAsync/{customerCode}/{caseSensitive}/{cache}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IList<CustomerDto>>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public IList<CustomerDto> CustomerSearchByCompanyName(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByContactName(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, bool cache,
            params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByAddress(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByAddressAsync(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByCity(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByCityAsync(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByTelephone(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByFax(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerSearchByPhoto(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public bool CustomerAdd(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerAdd";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.PostAsync(apiUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<bool> CustomerAddAsync(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerAddAsync";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public bool CustomerUpdate(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerUpdate";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.PutAsync(apiUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<bool> CustomerUpdateAsync(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerUpdateAsync";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.PutAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public bool CustomerDelete(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerDelete/{entity.CustomerId}/true";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = client.DeleteAsync(apiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public async Task<bool> CustomerDeleteAsync(CustomerDto entity)
        {
            bool result = false;

            var apiUrl = $"{this.apiSettings.BasePath}/product/CustomerDeleteAsync/{entity.CustomerId}/true";

            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiSettings.Bearer);
            var response = await client.DeleteAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(json);
            }
            else
            {
                throw new Exception($"An error happened{response.StatusCode}");
            }

            return result;
        }

        public bool CustomerDelete(int customerId, bool cache)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CustomerDeleteAsync(int customerId, bool cache)
        {
            throw new NotImplementedException();
        }

        public TResult CustomerMax<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> CustomerMaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
            throw new NotImplementedException();
        }

        public TResult CustomerMin<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
            throw new NotImplementedException();
        }

        public void CustomerBulkDelete(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }

        public Task CustomerBulkDeleteAsync(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }

        public void CustomerBulkInsert(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }

        public Task CustomerBulkInsertAsync(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }

        public void CustomerBulkUpdate(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }

        public Task CustomerBulkUpdateAsync(IEnumerable<CustomerDto> items)
        {
            throw new NotImplementedException();
        }
    }
}
