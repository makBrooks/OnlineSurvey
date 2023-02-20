using OnlineSurvey.Models;
using OnlineSurvey.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurvey.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _surveyRepository;
        public SurveyService(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public async Task<List<Block>> GetAllBlockByDistId(int distId)
        {
            try
            {
                return await _surveyRepository.GetAllBlockByDistId(distId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<District>> GetAllDistrict()
        {
            try
            {
                return await _surveyRepository.GetAllDistrict();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Institution>> GetAllInstitution()
        {
            try
            {
                return await _surveyRepository.GetAllInstitution();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Panchayat>> GetAllPanchayatByBlockId(int blockId)
        {
            try
            {
                return await _surveyRepository.GetAllPanchayatByBlockId(blockId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Village>> GetAllVillageByPanchayatId(int punchId)
        {
            try
            {
                return await _surveyRepository.GetAllVillageByPanchayatId(punchId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> InsertOrUpdate(SurveyEntity survey)
        {
            try
            {
                return await _surveyRepository.InsertOrUpdate(survey);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
