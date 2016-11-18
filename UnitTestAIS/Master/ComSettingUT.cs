using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    /// <summary>
    /// Summary description for ComSettingUT
    /// </summary>
    [TestClass]
    public class ComSettingUT
    {
        #region Class Attribute and Property

        private IComSettingService _comSettingService = new ComSettingService();

        #endregion

        #region TestData

        ComSetting _comSettingValidData = new ComSetting()
        {
            CompanyID = "HYB01",
            CompanyName = "PT. HYBRINGS SYSTEM INDONESIA",
            CompanyAddress = "Jl.Kapuk No.4 Pondok Cina Depok",
            ApplicationVersion = "1.0",
            TokenServiceID = "kszPjQweTYvBuHBsN86QA3VbN"
        };

        ComSetting _comSettingUpdateData = new ComSetting()
        {
            CompanyID = "HYB01",
            CompanyName = "PT. HYBRINGS SYSTEM TEST UPDATE",
            CompanyAddress = "Jl.KH Wahid Hasyim No.86",
            ApplicationVersion = "9.0",
            TokenServiceID = "kszPjQweTYvBuHBsN86QA3VbN-Update"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataComSettingTest()
        {
            InsertDataComSettingRequest request = new InsertDataComSettingRequest();
            request.ComSetting = _comSettingValidData;
            InsertDataComSettingResponse response = _comSettingService.InsertDataComSetting(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }


        public void UpdateDataComSettingTest()
        {
            UpdateDataComSettingRequest request = new UpdateDataComSettingRequest();
            request.ComSetting = _comSettingUpdateData;
            UpdateDataComSettingResponse response = _comSettingService.UpdateDataComSetting(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        #endregion

    }
}
