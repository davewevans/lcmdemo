﻿using System;
using System.Linq;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Helpers
{
    public static class IHttpServiceExtensionMethods
    {
        public static async Task<T> GetHelper<T>(this IHttpService httpService, string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public static async Task<PaginatedResponse<T>> GetHelper<T>(this IHttpService httpService, string url, 
            Pagination pagination)
        {
            string newURL = "";
            if (url.Contains("?"))
            {
                newURL = $"{url}&page={pagination.Page}&recordsPerPage={pagination.RecordsPerPage}";
            }
            else
            {
                newURL = $"{url}?page={pagination.Page}&recordsPerPage={pagination.RecordsPerPage}";
            }

            var httpResponse = await httpService.Get<T>(newURL);
            var totalAmountPages = int.Parse(httpResponse.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<T>
            {
                Response = httpResponse.Response,
                TotalAmountPages = totalAmountPages
            };
            return paginatedResponse;
        }

    }
}