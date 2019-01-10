using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using Newtonsoft.Json;

namespace DotNetScaffolder.Domain.Data.ApplicationServices.WebApiApplicationService.ApplicationService
{
    public class WebApiCustomerApplicationService : ICustomerApplicationService
    {
        public string accessToken { get; set; }

        public CustomerDto LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerDto> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CustomerDto>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            IList<CustomerDto> result = new List<CustomerDto>();

            var apiUrl = "http://localhost:5001/identity";

            var client = new HttpClient();
            //var at = await this.HttpContext.GetTokenAsync("access_token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var a = JsonConvert.SerializeObject(includes);

            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IList<CustomerDto>>(json);
            }
            else
            {
                throw new Exception("An error happened");
            }

            return result;
        }

        public IList<CustomerDto> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<IList<CustomerDto>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache,
            params Expression<Func<ICustomer, object>>[] includes)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Task<bool> CustomerAddAsync(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public bool CustomerUpdate(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CustomerUpdateAsync(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public bool CustomerDelete(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CustomerDeleteAsync(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public bool CustomerDelete(int customerId, bool cache)
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
