using AISEF.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISEF.Model;
using AISEF;

namespace AISEF.DAL
{
    public class GenderRepository : IGenderRepository
    {
        #region IGenderRepository Implementation

        public void Add(Gender entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gender entity)
        {
            throw new NotImplementedException();
        }

        public List<Gender> GetAll()
        {
            using (var context = new AISContext<Gender>())
            {
                return context.DBEntities.ToList();
            }
        }

        public void Update(Gender entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
