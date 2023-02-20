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
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Institution>>> GetInstitution()
        {
            return await _surveyService.GetAllInstitution();
        }
        [HttpGet("{punchId}")]
        public async Task<ActionResult<List<Village>>> GetAllVillageByPanchayatId(int punchId)
        {
            return await _surveyService.GetAllVillageByPanchayatId(punchId);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<int>> InsertOrUpdate(int id, SurveyEntity survey)
        {
            if (id != survey.SlNo)
            {
                return BadRequest();
            }
            try
            {
                return await _surveyService.InsertOrUpdate(survey);
            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
