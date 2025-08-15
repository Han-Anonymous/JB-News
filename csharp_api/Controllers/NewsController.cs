using JBSnorro;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace csharp_api.Controllers
{
    [ApiController]
    [Route("news/api")]
    public class NewsController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public NewsController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet("{news_source}/full-list")]
        public async Task<IActionResult> GetFullList(string news_source)
        {
            if (!Request.Headers.TryGetValue("Authorization", out var apiKey) || string.IsNullOrEmpty(apiKey))
            {
                return Unauthorized(new { message = "Error: Invalid API Key" });
            }

            var url = $"https://www.jblanked.com/news/api/{news_source}/full-list/";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", apiKey.ToString());

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<object>(content);
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, new { message = "Error fetching data from JBlanked API" });
        }

        [HttpGet("{news_source}/calendar")]
        public async Task<IActionResult> GetCalendar(string news_source)
        {
            return await ProxyToJBlankedAPI(news_source, "calendar");
        }

        [HttpGet("{news_source}/calendar/today")]
        public async Task<IActionResult> GetCalendarToday(string news_source)
        {
            return await ProxyToJBlankedAPI(news_source, "calendar/today");
        }

        [HttpGet("{news_source}/calendar/week")]
        public async Task<IActionResult> GetCalendarWeek(string news_source)
        {
            return await ProxyToJBlankedAPI(news_source, "calendar/week");
        }

        private async Task<IActionResult> ProxyToJBlankedAPI(string news_source, string endpoint)
        {
            if (!Request.Headers.TryGetValue("Authorization", out var apiKey) || string.IsNullOrEmpty(apiKey))
            {
                return Unauthorized(new { message = "Error: Invalid API Key" });
            }

            var url = $"https://www.jblanked.com/news/api/{news_source}/{endpoint}/";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", apiKey.ToString());

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<object>(content);
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, new { message = "Error fetching data from JBlanked API" });
        }

        [HttpPost("gpt")]
        public async Task<IActionResult> Gpt([FromBody] GptRequest request)
        {
            if (!Request.Headers.TryGetValue("Authorization", out var apiKey) || string.IsNullOrEmpty(apiKey))
            {
                return Unauthorized(new { message = "Error: Invalid API Key" });
            }

            var url = "https://www.jblanked.com/news/api/gpt/";
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
            httpRequest.Headers.Add("Authorization", apiKey.ToString());
            httpRequest.Content = new StringContent(JsonSerializer.Serialize(request), System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(httpRequest);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<object>(content);
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, new { message = "Error fetching data from JBlanked API" });
        }

        [HttpGet("gpt/status/{task_id}")]
        public async Task<IActionResult> GetGptStatus(string task_id)
        {
            if (!Request.Headers.TryGetValue("Authorization", out var apiKey) || string.IsNullOrEmpty(apiKey))
            {
                return Unauthorized(new { message = "Error: Invalid API Key" });
            }

            var url = $"https://www.jblanked.com/news/api/gpt/status/{task_id}/";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", apiKey.ToString());

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<object>(content);
                return Ok(data);
            }

            return StatusCode((int)response.StatusCode, new { message = "Error fetching data from JBlanked API" });
        }
    }

    public class GptRequest
    {
        public string? Content { get; set; }
    }
}
