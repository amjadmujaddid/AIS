using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;


namespace UnitTestAIS.Master
{
    [TestClass]
    public class JenisHakUT
    {
        #region Class Attribute and Property

        private IJenisHakService _jenisHakService = new JenisHakService();

        #endregion

        #region Test Data

        JenisHak _jenisHakValidData = new JenisHak()
        {
            RecordStatus="A",
            IDHak = "HGB",
            NamaHak = "HAK GUNA BANGUNAN"
        };

        JenisHak _jenisHakUpdateData = new JenisHak()
        {
            RecordStatus = "D",
            IDHak = "HGB",
            NamaHak = "HAK GUNA BANGUNAN TEST"
        };

        JenisHak _jenisHakGetDataById = new JenisHak()
        {
            IDHak = "HGB"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataJenisHakTest()
        {
            InsertDataJenisHakRequest request = new InsertDataJenisHakRequest();
            request.JenisHak = _jenisHakValidData;

            InsertDataJenisHakResponse response = _jenisHakService.InsertDataJenisHak(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataJenisHakTest()
        {
            UpdateDataJenisHakRequest request = new UpdateDataJenisHakRequest();
            request.JenisHak = _jenisHakUpdateData;

            UpdateDataJenisHakResponse response = _jenisHakService.UpdateDataJenisHak(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataJenisHakByIdTest()
        {
            GetDataJenisHakByIdRequest request = new GetDataJenisHakByIdRequest();
            request.idHak = _jenisHakGetDataById.IDHak;

            GetDataJenisHakByIdResponse response = _jenisHakService.GetDataJenisHakById(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllJenisHakTest()
        {
            GetAllDataJenisHakResponse response = _jenisHakService.GetAllDataJenisHak();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }
        #endregion
    }
}
