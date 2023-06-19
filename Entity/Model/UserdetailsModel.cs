using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class UserdetailsModel
    {
        [Key]
        public int userDetailsId { get; set; }
        public int UserId { get; set; }
        public string DepartmentName { get; set; }
        public string MobileNumber { get; set; }
        public string Email_Id { get; set; }
        public string PinCode { get; set; }
        public string created_Date { get; set; }
        public string LastModified_Date { get; set; }
    }
}
