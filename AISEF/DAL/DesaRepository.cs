using AISEF.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISEF.Model;
using HyRestoEF;

namespace AISEF.DAL
{
    public class DesaRepository : IDesaRepository
    {
        #region IDAL Repository

        public void Add(Desa entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Desa>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Desa entity)
        {
            throw new NotImplementedException();
        }

        public List<Desa> GetAll()
        {
            using (var context = new AISContext<Desa>())
            {
                return context.DBEntities.ToList();
            }
        }

        public void Update(Desa entity)
        {
            using (var context = new AISContext<Desa>())
            {
                Desa data = context.DBEntities.Where(i => i.IDDesa == entity.IDDesa).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.IDKecamatan = entity.IDKecamatan;
                    data.NamaDesa = entity.NamaDesa;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IDesaRepository Impementation

        public Desa GetDataById(string idDesa)
        {
            using (AISContext<Desa> context = new AISContext<Desa>())
            {
                return context.DBEntities.Where(i => i.IDDesa == idDesa).FirstOrDefault();
            }
        }

        #endregion
    }
}
