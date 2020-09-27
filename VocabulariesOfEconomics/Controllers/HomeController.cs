using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VocabulariesOfEconomics.Models;
using VocabulariesOfEconomics.Repositories.VocabularyRepository;

namespace VocabulariesOfEconomics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVocabularyRepository _vocabularyRepository;

        public HomeController(ILogger<HomeController> logger, IVocabularyRepository vocabularyRepository)
        {
            _vocabularyRepository = vocabularyRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet, Route("home/get-list-voca")]
        public async Task<IActionResult> GetListVoca([FromQuery] VocabularyQueryModel model)
        {
            return PartialView("Partial/_ListVoca", await _vocabularyRepository.GetListVoca(model));
        }
        [HttpPost, Route("home/get-list-voca-details")]
        public IActionResult GetListVocaDetails([FromBody] VocabularyQueryModel model)
        {
            return Ok(_vocabularyRepository.GetVocaDetails(model));
        }
        [HttpPost, Route("home/update-voca")]
        public IActionResult UpdateVoca([FromBody] VocabularyModel model)
        {
            return Ok(_vocabularyRepository.UpdateVoca(model));
        }
        [HttpPost, Route("home/add-voca")]
        public IActionResult AddVoca([FromBody] VocabularyModel model)
        {
            return Ok(_vocabularyRepository.AddVoca(model));
        }
    }
}
