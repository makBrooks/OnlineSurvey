using OnlineSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurvey.Services
{
    public interface ISurveyService
    {
        public Task<List<Institution>> GetAllInstitution();
        public Task<List<District>> GetAllDistrict();
        public Task<List<Block>> GetAllBlockByDistId(int distId);
        public Task<List<Panchayat>> GetAllPanchayatByBlockId(int blockId);
        public Task<List<Village>> GetAllVillageByPanchayatId(int punchId);
        public Task<int> InsertOrUpdate(SurveyEntity survey);
    }
}
