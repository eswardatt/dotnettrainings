using demoAppCallingInvoke;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

class ApICalling
{
   static string apiUrl = "https://localhost:44353/api/Admin/";

    public static List<Admin> GetAdmins(string key, string endPoint)
    {
        List<Admin> admins = new List<Admin>();
        string apiData = CallWebApi(key, endPoint);
        Console.WriteLine("Converting api json data to Admins list {0} ",DateTime.Now);
        admins = JsonConvert.DeserializeObject<List<Admin>>(apiData);
        Console.WriteLine("Completed converting api json data to Admins list {0} ",DateTime.Now);
        return admins;
    }
    private static string CallWebApi(string key,string endPoint)
    {
        string returnData = "";
        try
        {
            Console.WriteLine($"API Calling  {DateTime.Now}");
            using (HttpClient client = new HttpClient())
            {
                
                // Set any headers if required (e.g., authentication headers)
                client.DefaultRequestHeaders.Add("apikey", "9d8c2a1e-3b47-4f95-b7e2-8d5e6c86d1a5");
                client.DefaultRequestHeaders.Add("login", key);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Example JSON header

                try
                {
                    HttpResponseMessage response = client.GetAsync(apiUrl + endPoint).Result; // Replace with your API endpoint

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Aunthenticated Successfully  {DateTime.Now}");
                        string result = response.Content.ReadAsStringAsync().Result;
                        returnData = result;
                        //Console.WriteLine("API Response: " + result);
                    }
                    else
                    {
                        Console.WriteLine("API Request failed. Status code: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("HTTP Request Exception: " + e.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine($"API Calling Completes {DateTime.Now}");
        return returnData;
    }
}
