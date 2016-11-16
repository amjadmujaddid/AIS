using AISEF.DAL.Interface;
using AISEF.Model;
using HyRestoEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISEF.DAL
{
    public class GenVariableRepository : IGenVariableRepository
    {
        #region IDAL Reppository
 
        public void Add(GenVariable entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GenVariable entity)
        {
            throw new NotImplementedException();
        }

        public List<GenVariable> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(GenVariable entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IGenVariableRepository Implementation

        public List<GenVariable> GetDataComGenVariableStartWith(string variableStartWith)
        {
            using (var context = new AISContext<GenVariable>())
            {
                return context.Set<GenVariable>().Where(x => x.ValueName.StartsWith(variableStartWith)).ToList();
            }
        }

        #endregion
    }
}
