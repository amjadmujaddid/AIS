using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS
{
    [TestClass]
    public class AlbumUT
    {
        #region Class Attribute and Property

        private IAlbumService _albumService = new AlbumService();

        #endregion

        #region Test Data

        Album _albumValidData = new Album()
        {
            RecordStatus = "A",
            No_Album = "101",
            Lemari = "1",
            Rak = "1",
            Blok = "1A"
        };

        Album _albumUpdateData = new Album()
        {
            RecordStatus = "D",
            No_Album = "101",
            Lemari = "2",
            Rak = "2",
            Blok = "2A"
        };

        Album _albumGetDataById = new Album()
        {
            No_Album = "101"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void InsertDataAlbumTest()
        {
            InsertDataAlbumRequest request = new InsertDataAlbumRequest();
            request.Album = _albumValidData;
            InsertDataAlbumResponse response = _albumService.InsertDataAlbum(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        [TestMethod]
        public void UpdateDataAlbumTest()
        {
            UpdateDataAlbumRequest request = new UpdateDataAlbumRequest();
            request.Album = _albumUpdateData;
            UpdateDataAlbumResponse response = _albumService.UpdateDataAlbum(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed update data");
        }

        [TestMethod]
        public void GetDataAlbumByIdTest()
        {
            GetDataAlbumByIdRequest request = new GetDataAlbumByIdRequest();
            request.No_Album = _albumGetDataById.No_Album;
            GetDataAlbumByIdResponse response = _albumService.GetDataAlbumById(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed get data by Id");
        }

        [TestMethod]
        public void GetAllDataJabatan()
        {
            GetAllDataAlbumResponse response = _albumService.GetAllDataAlbum();

            Assert.IsTrue(response.Messages.Count == 0, "Failed insert data");
        }

        #endregion
    }
}
