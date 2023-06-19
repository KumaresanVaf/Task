using Entity;
using Entity.Model;
using OfficeOpenXml;

namespace DataLayer
{
    public class DataLayerClass : IDatalayerClass
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DataLayerClass(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<UserdetailsModel> GetData()
        {
            var data = _applicationDbContext.UserDetails.ToList();

            string saveFilePath = @"\\192.168.0.252\vaf\001\";
            FileInfo fileInfo = new FileInfo(saveFilePath + "kumar.xlsx");
            fileInfo.Create();
            OfficeOpenXml.LicenseContext licenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excel = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet excelWorksheet = excel.Workbook.Worksheets.Add("UserData");
                excelWorksheet.Cells[1, 1].Value = "userDetailsId";
                excelWorksheet.Cells[1, 2].Value = "UserId";
                excelWorksheet.Cells[1, 3].Value = "DepartmentName";
                excelWorksheet.Cells[1, 4].Value = "MobileNumber";
                excelWorksheet.Cells[1, 5].Value = "Email_Id";
                excelWorksheet.Cells[1, 6].Value = "PinCode";
                excelWorksheet.Cells[1, 7].Value = "created_Date";
                excelWorksheet.Cells[1, 8].Value = "LastModified_Date";

                int row = 2;
                int col = 1;

                for (col = 1; col <= data.Count; col++)
                {
                    excelWorksheet.Cells[row, col].Value = data[col];
                }

                excel.SaveAs(fileInfo);
            }

            return data;
        }
    }
}