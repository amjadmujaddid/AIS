using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    [TestClass]
    public class StaffUT
    {
        #region Class Attribute and Property

        private IStaffService _staffService = new StaffService();

        #endregion

        #region Test Data

        Staff _staffValidData = new Staff()
        {
            RecordStatus = "A",
            NIP = "30110001",
            NamaLengkap = "Amjad",
            IDJabatan = "TEST",
            IDJekel = "L",
            Alamat = "Depok"
        };

        Staff _staffUpdateData = new Staff()
        {
            RecordStatus = "D",
            NIP = "30110001",
            NamaLengkap = "Risma Test Update",
            IDJabatan = "TEST",
            IDJekel = "P",
            Alamat = "Depok Test"
        };

        Staff _staffGetDataById = new Staff()
        {
            NIP = "30110001"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataStaffTest()
        {
            InsertDataStaffRequest request = new InsertDataStaffRequest();
            request.Staff = _staffValidData;

            InsertDataStaffResponse response = _staffService.InsertDataStaff(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataStaffTest()
        {
            UpdateDataStaffRequest request = new UpdateDataStaffRequest();
            request.Staff = _staffUpdateData;

            UpdateDataStaffResponse response = _staffService.UpdateDataStaff(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataStaffByIdTest()
        {
            GetDataStaffByIdRequest request = new GetDataStaffByIdRequest();
            request.nip = _staffGetDataById.NIP;

            GetDataStaffByIdResponse response = _staffService.GetDataStaffById(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllDataStaffTest()
        {
            GetAllDataStaffResponse response = _staffService.GetAllDataStaff();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }

        #endregion
    }
}
