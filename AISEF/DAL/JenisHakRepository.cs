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
    public class JenisHakRepository : IJenisHakRepository
    {
        #region IDAL Repository

        public void Add(JenisHak entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<JenisHak>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(JenisHak entity)
        {
            throw new NotImplementedException();
        }

        public List<JenisHak> GetAll()
        {
            using (var context = new AISContext<JenisHak>())
            {
                return context.DBEntities.ToList();
            }
        }

        public void Update(JenisHak entity)
        {
            using (var context = new AISContext<JenisHak>())
            {
                JenisHak data = context.DBEntities.Where(i => i.IDHak == entity.IDHak).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.NamaHak = entity.NamaHak;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IJenisHakRepository Implementation

        public JenisHak GetDataById(string idHak)
        {
            using (AISContext<JenisHak> context = new AISContext<JenisHak>())
            {
                return context.DBEntities.Where(i => i.IDHak == idHak).FirstOrDefault();
            }
        }

        #endregion

    }
}
