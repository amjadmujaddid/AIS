using AISEF.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISEF.Model;

namespace AISEF.DAL
{
    public class WarkahRepository : IWarkahRepository
    {
        #region IDALRepository

        public void Add(Warkah entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Warkah>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Warkah entity)
        {
            throw new NotImplementedException();
        }

        public List<Warkah> GetAll()
        {
            using (var context = new AISContext<Warkah>())
            {
                var result = (from a in context.DBEntities
                              join b in context.Set<GenVariable>() on a.RecordStatus equals b.Variable into tmp
                              from tmptest in tmp.DefaultIfEmpty()
                              select new
                              {
                                  a,
                                  tmptest.Keterangan
                              }).ToList()
                              .Select(i => new Warkah
                              {
                                  RecordStatus = i.Keterangan,
                                  NW_Barcode = i.a.NW_Barcode,
                                  Jenis = i.a.Jenis,
                                  NomorWarkah = i.a.NomorWarkah,
                                  Tahun = i.a.Tahun,
                                  No_Album = i.a.No_Album,
                                  Status = i.a.Status
                              }).ToList();
                return result;
            }
        }

        public void Update(Warkah entity)
        {
            using (var context = new AISContext<Warkah>())
            {
                Warkah data = context.DBEntities.Where(i => i.NW_Barcode == entity.NW_Barcode).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.Jenis = entity.Jenis;
                    data.NomorWarkah = entity.NomorWarkah;
                    data.Tahun = entity.Tahun;
                    data.No_Album = entity.No_Album;
                    data.Status = entity.Status;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IWarkahRepository Implementation

        public Warkah GetDataById(string nwBarcode)
        {
            using (AISContext<Warkah> context = new AISContext<Warkah>())
            {
                return context.DBEntities.Where(i => i.NW_Barcode == nwBarcode).FirstOrDefault();
            }
        }

        #endregion
    }
}
