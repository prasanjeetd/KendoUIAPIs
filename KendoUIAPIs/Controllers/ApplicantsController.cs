using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;


using ITW.RecruitmentSystem.Dtos;

namespace ITW.RecruitmentSystem.Web.Services
{

    public class ApplicantsController : ApiController
    {
        [HttpPost]
        public void Save(ApplicantsDto applicantsDto)
        {

        }

        [HttpGet]
        public List<ApplicantsDto> GetApplicantList()
        {
            List<ApplicantsDto> applicantList = new List<ApplicantsDto>();

            for (int i = 1; i <= 10; i++)
            {
                Random rand = new Random(5);
                ApplicantsDto app = new ApplicantsDto();
                app.ApplicantID = i;
                app.FirstName = "FirstName" + i;
                app.LastName = "LastName" + i;

                app.RoundID = rand.Next();
                app.RoundName = "Round" + app.RoundID;

                app.PostName = "Post" + i + app.RoundID;

                applicantList.Add(app);
            }

            return applicantList;
        }

        [HttpGet]
        public List<ApplicantsDto> GetRounds(int id)
        {
            List<ApplicantsDto> applicantList = new List<ApplicantsDto>();

            for (int i = 1; i <= 5; i++)
            {
                ApplicantsDto app = new ApplicantsDto();
                app.RoundID = i;
                app.RoundName = "Round" + app.RoundID;
                applicantList.Add(app);
            }

            return applicantList;
        }

    }
}
