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
    public class ComSettingRepository : IComSettingRepository
    {
        #region IDAL Repository

        public void Add(ComSetting entity)
        {
            using (var context = new AISContext<ComSetting>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(ComSetting entity)
        {
            throw new NotImplementedException();
        }

        public List<ComSetting> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ComSetting entity)
        {
            using (var context = new AISContext<ComSetting>())
            {
                ComSetting data = context.DBEntities.Where(i => i.CompanyID == entity.CompanyID).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.CompanyName = entity.CompanyName;
                    data.CompanyAddress = entity.CompanyAddress;
                    data.TokenServiceID = entity.TokenServiceID;
                    context.SaveChanges();
                }
            }
        }

        #endregion
    }
}
