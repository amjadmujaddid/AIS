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
    /// Summary description for GenVariableUT
    /// </summary>
    [TestClass]
    public class GenVariableUT
    {

        #region Class Attribute and Property

        private IGenVariableService _genVariableService = new GenVariableService();

        #endregion

        #region Test Data

        GenVariable _genVariableGetDataComGenVariableStartWith = new GenVariable()
        {
            ValueName = "RECORD_"
        };

        #endregion

        #region Test Method

        [TestMethod]
        public void GetDataComGenVariableStartWithTest()
        {
            GetDataComGenVariableStartWithRequest request = new GetDataComGenVariableStartWithRequest();
            request.variableStartWith = _genVariableGetDataComGenVariableStartWith.ValueName;

            GetDataComGenVariableStartWithResponse response = _genVariableService.GetDataComGenVariableStartWith(request);

            Assert.IsTrue(response.Messages.Count == 0, "Failed Get data by Variable Start With");
        }

        #endregion
    }
}
