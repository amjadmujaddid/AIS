using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;


namespace UnitTestAIS.Master
{
    [TestClass]
    public class JabatanUT
    {
        #region Class Attribute and Property

        private IJabatanService _jabatanService = new JabatanService();

        #endregion

        #region Test Data

        Jabatan _jabatanValidData = new Jabatan()
        {
            RecordStatus = "A",
            IDJabatan = "TEST",
            NamaJabatan = "Unit Test Valid Jabatan"
        };

        Jabatan _jabatanUpdateData = new Jabatan()
        {
            RecordStatus = "A",
            IDJabatan = "TEST",
            NamaJabatan = "Test Amjad Update Jabatan"

        };

        Jabatan _jabatanGetDataById = new Jabatan()
        {
            IDJabatan = "TEST"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataJabatanTest()
        {
            InsertDataJabatanRequest request = new InsertDataJabatanRequest();
            request.Jabatan = _jabatanValidData;
            InsertDataJabatanResponse response = _jabatanService.InsertDataJabatan(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataJabatanTest()
        {
            UpdateDataJabatanRequest request = new UpdateDataJabatanRequest();
            request.Jabatan = _jabatanUpdateData;
            UpdateDataJabatanResponse response = _jabatanService.UpdateDataJabatan(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void GetDataByIdJabatanTest()
        {
            GetDataJabatanByIdRequest request = new GetDataJabatanByIdRequest();
            request.IDJabatan = _jabatanGetDataById.IDJabatan;

            GetDataJabatanByIdResponse response = _jabatanService.GetDataJabatanById(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed Get data by Id");
        }

        [TestMethod]
        public void GetAllDataJabatanTest()
        {
            GetAllDataJabatanResponse response = _jabatanService.GetAllDataJabatan();
            Assert.IsTrue(response.Messages.Count == 0, "Failed Get All data");
        }

        #endregion
    }
}
