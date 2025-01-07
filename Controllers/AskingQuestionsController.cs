using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDMC3TwoToFour_Endpoint.Services;

namespace MonterrosaDMC3TwoToFour_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingquestionsServices;

        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingquestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("AskQuestions/{userName}/{time}")]

        public string AskQuestions(string userName, string time)
        {
            return _askingquestionsServices.AskQuestions(userName, time);
        }
    }
}