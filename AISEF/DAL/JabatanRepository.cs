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
    public class JabatanRepository : IJabatanRepository
    {

        #region IDAL Repository

        public void Add(Jabatan entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Jabatan>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Jabatan entity)
        {
            throw new NotImplementedException();
        }

        public List<Jabatan> GetAll()
        {
            using (var context = new AISContext<Jabatan>())
            {
                var result = (from a in context.DBEntities
                              join b in context.Set<GenVariable>() on a.RecordStatus equals b.Variable into tmp
                              from tmptest in tmp.DefaultIfEmpty()
                              select new
                              {
                                  a,
                                  tmptest.Keterangan
                              }).ToList()
                              .Select(i => new Jabatan
                              {
                                  RecordStatus = i.Keterangan,
                                  IDJabatan = i.a.IDJabatan,
                                  NamaJabatan = i.a.NamaJabatan
                              }).ToList();
                return result;
            }
        }
        
        public void Update(Jabatan entity)
        {
            using (var context = new AISContext<Jabatan>())
            {
                Jabatan data = context.DBEntities.Where(i => i.IDJabatan == entity.IDJabatan).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.NamaJabatan = entity.NamaJabatan;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IJabatanRepository Implementation

        public Jabatan GetDataById(string idJabatan)
        {
            using (AISContext<Jabatan> context = new AISContext<Jabatan>())
            {
                return context.DBEntities.Where(i => i.IDJabatan == idJabatan).FirstOrDefault();
            }
        }

        #endregion
    }
}
