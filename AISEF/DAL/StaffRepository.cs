using AISEF.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISEF.Model;

namespace AISEF.DAL
{
    public class StaffRepository : IStaffRepository
    {
        #region IDALRepository

        public void Add(Staff entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Staff>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Staff entity)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetAll()
        {
            using (var context = new AISContext<Staff>())
            {
                var result = (from a in context.DBEntities
                              join b in context.Set<GenVariable>() on a.RecordStatus equals b.Variable into tmp
                              from tmptest in tmp.DefaultIfEmpty()
                              select new
                              {
                                  a,
                                  tmptest.Keterangan
                              }).ToList()
                              .Select(i => new Staff
                              {
                                  RecordStatus = i.Keterangan,
                                  NIP = i.a.NIP,
                                  NamaLengkap = i.a.NamaLengkap,
                                  Alamat = i.a.Alamat
                              }).ToList();
                return result;
            }
        }

        public void Update(Staff entity)
        {
            using (var context = new AISContext<Staff>())
            {
                Staff data = context.DBEntities.Where(i => i.NIP == entity.NIP).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.NamaLengkap = entity.NamaLengkap;
                    data.IDJabatan = entity.IDJabatan;
                    data.IDJekel = entity.IDJekel;
                    data.Alamat = entity.Alamat;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IStaffRepository Implementation

        public Staff GetDataById(string nip)
        {
            using (AISContext<Staff> context = new AISContext<Staff>())
            {
                return context.DBEntities.Where(i => i.NIP == nip).FirstOrDefault();
            }
        }

        #endregion
    }
}
