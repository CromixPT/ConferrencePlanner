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
    public class SpeakerModel : PageModel
    {
        private readonly IApiClient _apiClient;
        private readonly ILogger<SpeakerModel> _logger;

        public SpeakerResponse Speaker { get; set; }

        public SpeakerModel(IApiClient apiClient,ILogger<SpeakerModel> logger)
        {
            _logger = logger;
            _apiClient = apiClient;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            Speaker = await _apiClient.GetSpeakerAsync(id);

            if ( Speaker == null )
            {
                return NotFound();
            }

            return Page();
        }


    }
}
