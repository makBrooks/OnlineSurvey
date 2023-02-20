using Dapper;
using Microsoft.Extensions.Configuration;
using OnlineSurvey.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurvey.Repository
{
    public class SurveyRepository : BaseRepository, ISurveyRepository
    {
        public SurveyRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public string storedProcedure = "SP_MTSurvey";
        public async Task<List<Block>> GetAllBlockByDistId(int distId)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@DistrictID", distId);
                param.Add("@action", "FillBlock");
                var lst = cn.Query<Block>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<District>> GetAllDistrict()
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "FillDistrict");
                var lst = cn.Query<District>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Institution>> GetAllInstitution()
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "FillILA");
                var lst = cn.Query<Institution>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Panchayat>> GetAllPanchayatByBlockId(int blockId)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockID", blockId);
                param.Add("@action", "FillGP");
                var lst = cn.Query<Panchayat>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Village>> GetAllVillageByPanchayatId(int punchId)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@GPID", punchId);
                param.Add("@action", "FillVillage");
                var lst = cn.Query<Village>(storedProcedure, param, commandType: CommandType.StoredProcedure).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<int> InsertOrUpdate(SurveyEntity survey)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@SlNo", survey.SlNo);
                param.Add("@DistrictID", survey.DistrictID);
                param.Add("@DistrictID", survey.DistrictID);
                param.Add("@BlockID", survey.BlockID);
                param.Add("@GPID", survey.GPID);
                param.Add("@VillageID", survey.VillageID);
                param.Add("@RCNo", survey.RCNo);
                param.Add("@MobNo", survey.MobNo);
                param.Add("@SEBC", survey.SEBC);
                param.Add("@HOFName", survey.HOFName);
                param.Add("@GenID", survey.GenID);
                param.Add("@ILAID", survey.ILAID);
                param.Add("@ESID", survey.ESID);
                param.Add("@MSID", survey.MSID);
                param.Add("@OccupID", survey.OccupID);
                param.Add("@IPTID", survey.IPTID);
                param.Add("@IDPNO", survey.IDPNO);
                param.Add("@Age", survey.Age);
                param.Add("@RwHOF", survey.RwHOF);
                param.Add("@SmOrNot", survey.SmOrNot);
                param.Add("@WithnessName", survey.WithnessName);
                param.Add("@WithnessMob", survey.WithnessMob);
                param.Add("@Action", "InsertOrUpdate");
                int x = cn.Execute(storedProcedure, param, commandType: CommandType.StoredProcedure);
                cn.Close();
                return x;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
