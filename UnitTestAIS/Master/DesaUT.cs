using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    [TestClass]
    public class DesaUT
    {
        #region Class Attribute and Property

        private IDesaService _desaService = new DesaService();

        #endregion

        #region Test Data

        Desa _desaValidData = new Desa()
        {
            RecordStatus = "A",
            IDDesa = "2",
            NamaDesa = "PABUARAN",
            IDKecamatan = "1"
        };

        Desa _desaUpdateData = new Desa()
        {
            RecordStatus = "D",
            IDDesa = "2",
            NamaDesa = "PABUARAN Update",
            IDKecamatan = "1"
        };

        Desa _desaGetDataById = new Desa()
        {
            IDDesa = "2"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataDesaTest()
        {
            InsertDataDesaRequest request = new InsertDataDesaRequest();
            request.Desa = _desaValidData;
            InsertDataDesaResponse response = _desaService.InsertDataDesa(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataDesaTest()
        {
            UpdateDataDesaRequest request = new UpdateDataDesaRequest();
            request.Desa = _desaUpdateData;
            UpdateDataDesaResponse response = _desaService.UpdateDataDesa(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataDesaByIdTest()
        {
            GetDataDesaByIdRequest request = new GetDataDesaByIdRequest();
            request.idDesa = _desaGetDataById.IDDesa;
            GetDataDesaByIdResponse response = _desaService.GetDataDesaById(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");

        }

        [TestMethod]
        public void GetAllDataDesaTest()
        {
            GetAllDataDesaResponse response = _desaService.GetAllDataDesa();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }

        #endregion
    }
}
