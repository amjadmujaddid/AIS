using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    [TestClass]
    public class WarkahUT
    {
        #region Class Attribute and Property

        private IWarkahService _warkahService = new WarkahService();

        #endregion

        #region Test Data

        Warkah _warkahValidData = new Warkah()
        {
            RecordStatus = "A",
            NW_Barcode = "30110001",
            Jenis = "D208",
            NomorWarkah = "101",
            Tahun = "2017",
            No_Album = "201",
            Status = "1"
        };

        Warkah _warkahUpdateData = new Warkah()
        {
            RecordStatus = "D",
            NW_Barcode = "30110001",
            Jenis = "D208",
            NomorWarkah = "280",
            Tahun = "2020",
            No_Album = "201",
            Status = "0"
        };

        Warkah _warkahGetDataById = new Warkah()
        {
            NW_Barcode = "30110001"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataWarkahTest()
        {
            InsertDataWarkahRequest request = new InsertDataWarkahRequest();
            request.Warkah = _warkahValidData;

            InsertDataWarkahResponse response = _warkahService.InsertDataWarkah(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataWarkahTest()
        {
            UpdateDataWarkahRequest request = new UpdateDataWarkahRequest();
            request.Warkah = _warkahUpdateData;

            UpdateDataWarkahResponse response = _warkahService.UpdateDataWarkah(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataByIDWarkahTest()
        {
            GetDataWarkahByIdRequest request = new GetDataWarkahByIdRequest();
            request.nwBarcode = _warkahGetDataById.NW_Barcode;

            GetDataWarkahByIdResponse response = _warkahService.GetDataWarkahById(request);
            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllWarkahTest()
        {
            GetAllDataWarkahResponse response = _warkahService.GetAllDataWarkah();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }

        #endregion
    }
}
