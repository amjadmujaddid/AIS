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
    public class KecamatanRepository : IKecamatanRepository
    {
        #region IDAL Repository

        public void Add(Kecamatan entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Kecamatan>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Kecamatan entity)
        {
            throw new NotImplementedException();
        }

        public List<Kecamatan> GetAll()
        {
            using (var context = new AISContext<Kecamatan>())
            {
                return context.DBEntities.ToList();
            }
        }

        public void Update(Kecamatan entity)
        {
            using (var context = new AISContext<Kecamatan>())
            {
                Kecamatan data = context.DBEntities.Where(i => i.IDKecamatan == entity.IDKecamatan).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.NamaKecamatan = entity.NamaKecamatan;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IKecamatanRepository

        public Kecamatan GetDataById(string idKecamatan)
        {
            using (AISContext<Kecamatan> context = new AISContext<Kecamatan>())
            {
                return context.DBEntities.Where(i => i.IDKecamatan == idKecamatan).FirstOrDefault();
            }
        }

        #endregion
    }
}
