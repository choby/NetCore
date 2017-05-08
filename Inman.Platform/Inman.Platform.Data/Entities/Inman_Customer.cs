using Inman.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Platform.Data.Entities
{
    public class Inman_Customer : BaseEntity
    {
      
        public Guid CustomerGuid { get; set; }
        public string Username { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsSystemAccount { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public int LoginErrorCount { get; set; }
        public string Code { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? SubCompanyId { get; set; }
        public string SubCompanyName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? WorkgroupId { get; set; }
        public string WorkgroupName { get; set; }
        public DateTime? ChangePasswordDate { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string HomeAddress { get; set; }
        public DateTime? LockStartDate { get; set; }
        public DateTime? LockEndDate { get; set; }
        public int? LogOnCount { get; set; }
        public bool? UserOnLine { get; set; }
        public string IPAddress { get; set; }
        public string MACAddress { get; set; }
        public string Question { get; set; }
        public string AnswerQuestion { get; set; }
        public bool? AuditStatus { get; set; }
        public int? SortCode { get; set; }
        public string Description { get; set; }
     
        public bool IsAccessInternet { get; set; }
        public int? FactoryId { get; set; }
      
        public int? OutsourceType { get; set; }
    }
}
