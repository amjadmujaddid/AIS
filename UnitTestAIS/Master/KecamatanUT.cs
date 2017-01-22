using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    [TestClass]
    public class KecamatanUT
    {
        #region Class Attribute and Property

        private IKecamatanService _kecamatanService = new KecamatanService();

        #endregion

        #region Test Data

        Kecamatan _kecamatanValid = new Kecamatan()
        {
            RecordStatus = "A",
            IDKecamatan = "2",
            NamaKecamatan= "CIBINONG"
        };

        Kecamatan _kecamatanUpdateData = new Kecamatan()
        {
            RecordStatus = "D",
            IDKecamatan = "2",
            NamaKecamatan = "CIBINONG TEST"
        };

        Kecamatan _kecamatanGetDataById = new Kecamatan()
        {
            IDKecamatan = "2"
        };

        #endregion

        #region Method

        [TestMethod]
        public void InsertDataKecamatanTest()
        {
            InsertDataKecamatanaRequest request = new InsertDataKecamatanaRequest();
            request.Kecamatan = _kecamatanValid;

            InsertDataKecamatanResponse response = _kecamatanService.InsertDataKecamatan(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataKecamatanTest()
        {
            UpdateDataKecamatanRequest request = new UpdateDataKecamatanRequest();
            request.Kecamatan = _kecamatanUpdateData;

            UpdateDataKecamatanResponse response = _kecamatanService.UpdateDataKecamatan(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataByIDKecamatanTest()
        {
            GetDataKecamatanByIdRequest request = new GetDataKecamatanByIdRequest();
            request.idKecamatan = _kecamatanGetDataById.IDKecamatan;

            GetDataKecamatanByIdResponse response = _kecamatanService.GetDataKecamatanById(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllDataKecamatanTest()
        {
            GetAllDataKecamatanResponse response = _kecamatanService.GetAllDataKecamatan();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }
        #endregion
    }
}
