using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IGenVariableService
    {
        /// <summary>
        /// Get Data Variable Start with ComGenVariable
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataComGenVariableStartWithResponse GetDataComGenVariableStartWith(GetDataComGenVariableStartWithRequest request);
    }

    #endregion

    #region Message

    public class GetDataComGenVariableStartWithRequest
    {
        public string variableStartWith { get; set; }
    }

    public class GetDataComGenVariableStartWithResponse : ResponseBase
    {
        private List<GenVariable> _genVariableList;

        public List<GenVariable> GenVariableList
        {
            get { return _genVariableList ?? (_genVariableList = new List<GenVariable>()); }
        }
    }


    #endregion
}
