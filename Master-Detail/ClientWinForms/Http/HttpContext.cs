using Microsoft.VisualBasic.ApplicationServices;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinForms.Http
{

    internal class HttpContext
    {
        private HttpClient httpClient;
        public HttpContext()
        {
            httpClient = new()
            {
                BaseAddress = new Uri(Properties.Settings.Default.url),
            };
        }

        internal List<Model.MasterView?>? LoadMaster()
        {
            try
            {
                using HttpResponseMessage response = httpClient.GetAsync("Master").Result;
                response.EnsureSuccessStatusCode();
                if (response == null || response.Content == null)
                    return null;
                //string s = response.Content.ReadAsStringAsync().Result;
                List<Model.MasterView?>? r = JsonConvert.DeserializeObject<List<MasterView?>?>(response.Content.ReadAsStringAsync().Result);
                return r;
            }
            catch
            {
                throw;
            }
            
        }
        internal List<Model.MasterView?>? AddMaster(MasterView master)
        {
            string? errorText = null;
            try
            {
                string json = JsonConvert.SerializeObject(master, new Formatting());
                using StringContent jsonContent =
                    new StringContent(json, Encoding.UTF8, "application/json");

                using HttpResponseMessage response = httpClient.PostAsync(
                    "Master",
                    jsonContent).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }

                response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch
            {
                if (string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }

        internal List<Model.MasterView?>? UpdateMaster(MasterView master)
        {
            string? errorText = null;
            try
            {
                string json = JsonConvert.SerializeObject(master, new Formatting());
                using StringContent jsonContent =
                    new StringContent(json, Encoding.UTF8, "application/json");

                using HttpResponseMessage response = httpClient.PutAsync(
                    "Master/"+ master.Id,
                    jsonContent).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }
                response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch
            {
                if (string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }

        internal List<Model.MasterView?>? DeleteMaster(int masterId)
        {
            string? errorText = null;
            try
            {
                using HttpResponseMessage response = httpClient.DeleteAsync(
                    "Master/" + masterId).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }
                response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch
            {
                if (string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }

        internal List<Model.MasterView?>? AddDetail(DetailView detail)
        {
            string? errorText = null;
            try
            {
                string json = JsonConvert.SerializeObject(detail, new Formatting());
                using StringContent jsonContent =
                    new StringContent(json, Encoding.UTF8, "application/json");

                using HttpResponseMessage response = httpClient.PostAsync(
                    "Detail",
                    jsonContent).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }
                    response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch 
            {
                if(string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }

        internal List<Model.MasterView?>? UpdateDetail(DetailView detail)
        {
            string? errorText = null;
            try
            {
                string json = JsonConvert.SerializeObject(detail, new Formatting());
                using StringContent jsonContent =
                    new StringContent(json, Encoding.UTF8, "application/json");

                using HttpResponseMessage response = httpClient.PutAsync(
                    "detail/" + detail.Id,
                    jsonContent).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }

                response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch
            {
                if (string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }

        internal List<Model.MasterView?>? DeleteDetail(int detailId)
        {
            string? errorText = null;
            try
            {
                using HttpResponseMessage response = httpClient.DeleteAsync(
                    "detail/" + detailId).Result;
                if (!response.IsSuccessStatusCode)
                {
                    errorText = response.Content.ReadAsStringAsync().Result;
                }
                response.EnsureSuccessStatusCode();
                return LoadMaster();
            }
            catch
            {
                if (string.IsNullOrEmpty(errorText))
                    throw;
                else
                    throw new Exception(errorText);
            }
        }
    }


}
