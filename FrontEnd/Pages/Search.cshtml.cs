using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferenceDTO;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FrontEnd.Pages
{
    public class SearchModel : PageModel
    {

        private readonly IApiClient _apiClient;

        private readonly ILogger<SearchModel> _logger;

        public string Term { get; set; }

        public List<SearchResult> SearchResults { get; set; }

        public SearchModel(IApiClient apiClient, ILogger<SearchModel> logger)
        {
            _apiClient = apiClient;
            _logger = logger;
        }
        public async Task OnGetAsync(string term)
        {
            Term = term;
            SearchResults = await _apiClient.SearchAsync(term);
        }
    }
}
