using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Models;
using OnlineSurvey.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanchayatController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public PanchayatController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet("{blockId}")]
        public async Task<ActionResult<List<Panchayat>>> GetAllPanchayatByBlockId(int blockId)
        {
            return await _surveyService.GetAllPanchayatByBlockId(blockId);
        }
    }
}
