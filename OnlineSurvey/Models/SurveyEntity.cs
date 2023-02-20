using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSurvey.Models
{
    public class SurveyEntity
    {
        public int SlNo { get; set; } = 0;
        public int DistrictID { get; set; } = 0;
        public int BlockID { get; set; } = 0;
        public int GPID { get; set; } = 0;
        public int VillageID { get; set; } = 0;
        public string RCNo { get; set; } = null;
        public string MobNo { get; set; } = null;
        public string SEBC { get; set; } = null;
        public string HOFName { get; set; } = null;
        public int GenID { get; set; } = 0;
        public int ILAID { get; set; } = 0;
        public int ESID { get; set; } = 0;
        public int MSID { get; set; } = 0;
        public int OccupID { get; set; } = 0;
        public int IPTID { get; set; } = 0;
        public string IDPNO { get; set; } = null;
        public int Age { get; set; } = 0;
        public int RwHOF { get; set; } = 0;
        public string SmOrNot { get; set; } = null;
        public string WithnessName { get; set; } = null;
        public string WithnessMob { get; set; } = null;
    }
    public class Village
    {
        public int VillageID { get; set; } = 0;
        public int GPID { get; set; } = 0;
        public string VillageName { get; set; } = null;
    }
    public class Panchayat
    {
        public int GPID { get; set; } = 0;
        public int BlockID { get; set; } = 0;
        public string GPName { get; set; } = null; 
    }
    public class Block
    {
        public int BlockID { get; set; } = 0;
        public int DistrictID { get; set; } = 0;
        public string BlockName { get; set; } = null;
    }
    public class District
    {
        public int DistrictID { get; set; } = 0;
        public string DistrictName { get; set; } = null;
    }
    public class Institution
    {
        public int ILAID { get; set; } = 0;
        public string ILAName { get; set; } = null;
    }
}
