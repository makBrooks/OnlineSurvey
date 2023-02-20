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
    public class DistrictController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public DistrictController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet]
        public async Task<ActionResult<List<District>>> GetAllDistrict()
        {
            return await _surveyService.GetAllDistrict();
        }
        [HttpGet("{distId}")]
        public async Task<ActionResult<List<Block>>> GetAllPanchayatByBlockId(int distId)
        {
            return await _surveyService.GetAllBlockByDistId(distId);
        }
    }
}
