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
    /// Summary description for BukuTanahUT
    /// </summary>
    [TestClass]
    public class BukuTanahUT
    {

        #region Class Attribute and Property

        private IBukuTanahService _bukuTanahService = new BukuTanahService();

        #endregion

        #region Test Data

        BukuTanah _bukuTanahValidData = new BukuTanah()
        {
            RecordStatus = "A",
            NB_Barcode = "111",
            IDHak = "HM",
            NomorHak = "1",
            No_Album = "1",
            IDDesa = "1",
            IDKecamatan="1",
            Luas = 100,
            PemegangHak = "Amjad Insert",
            Status = "1"
        };

        BukuTanah _bukuTanahUpdateData = new BukuTanah()
        {
            RecordStatus = "D",
            NB_Barcode = "111",
            IDHak = "HGB",
            NomorHak = "2",
            No_Album = "2",
            IDDesa = "2",
            IDKecamatan = "2",
            Luas = 200,
            PemegangHak = "Amjad Update",
            Status = "2"
        };

        BukuTanah _bukuTanahGetDataById = new BukuTanah()
        {
            NB_Barcode = "111"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataBukuTanahTest()
        {
            InsertDataBukuTanahRequest request = new InsertDataBukuTanahRequest();
            request.BukuTanah = _bukuTanahValidData;
            InsertDataBukuTanahResponse response = _bukuTanahService.InsertDataBukuTanah(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataBukuTanahTest()
        {
            UpdateDataBukuTanahRequest request = new UpdateDataBukuTanahRequest();
            request.BukuTanah = _bukuTanahUpdateData;
            UpdateDataBukuTanahResponse response = _bukuTanahService.UpdateDataBukuTanah(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void GetDataBukuTanahByIdTest()
        {
            GetDataBukuTanahByIdRequest request = new GetDataBukuTanahByIdRequest();
            request.NB_Barcode = _bukuTanahGetDataById.NB_Barcode;
            GetDataBukuTanahByIdResponse response = _bukuTanahService.GetDataBukuTanahById(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllDataBukuTanah()
        {
            GetAllDataBukuTanahResponse response = _bukuTanahService.GetAllDataBukuTanah();

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        #endregion

    }
}
