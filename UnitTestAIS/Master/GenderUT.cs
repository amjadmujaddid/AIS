using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISService.Contract;
using AISService;
using AISEF.Model;

namespace UnitTestAIS.Master
{
    [TestClass]
    public class GenderUT
    {
        #region Class Attribute and Property

        private IGenderService _genderService = new GenderService();

        #endregion

        #region Test Data



        #endregion

        #region Test Method

        [TestMethod]
        public void GetAllDataGenderTest()
        {
            GetAllDataGenderResponse response = _genderService.GetAllDataGender();

            Assert.IsTrue(response.Messages.Count == 0, "Failed get all data");
        }

        #endregion
    }
}
