using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITW.RecruitmentSystem.Dtos
{
    
    public class ApplicantsDto
    {
        public long ApplicantID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string  MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public string Pincode { get; set; }
        public int Experience { get; set; }
        public int PostID { get; set; }
        public byte[] Resume { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string PostName { get; set; }
        public int RoundID { get; set; }
        public string RoundName { get; set; }
        public long ApplicantRoundID { get; set; }
    }
}
