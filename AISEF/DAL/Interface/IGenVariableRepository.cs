using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL.Interface
{
    public interface IGenVariableRepository  : IDALRepository<GenVariable>
    {
        /// <summary>
        /// Get Data ComGenVariable Startwith
        /// </summary>
        /// <param name="variableStartWith"></param>
        /// <returns></returns>
        List<GenVariable>GetDataComGenVariableStartWith(string variableStartWith);
    }
}
