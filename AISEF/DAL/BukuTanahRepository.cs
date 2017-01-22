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
    public class BukuTanahRepository : IBukuTanahRepository
    {

        #region IDAL Repository

        public void Add(BukuTanah entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<BukuTanah>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(BukuTanah entity)
        {
            throw new NotImplementedException();
        }

        public List<BukuTanah> GetAll()
        {
            using (var context = new AISContext<BukuTanah>())
            {
                var result = (from a in context.DBEntities
                              join b in context.Set<GenVariable>() on a.RecordStatus equals b.Variable into tmp
                              from tmptest in tmp.DefaultIfEmpty()
                              select new
                              {
                                  a,
                                  tmptest.Keterangan
                              }).ToList()
                              .Select(i => new BukuTanah
                              {
                                  RecordStatus = i.Keterangan,
                                  NB_Barcode = i.a.NB_Barcode,
                                  IDHak = i.a.IDHak,
                                  NomorHak = i.a.NomorHak,
                                  No_Album = i.a.No_Album,
                                  IDDesa = i.a.IDDesa,
                                  IDKecamatan = i.a.IDKecamatan,
                                  Luas = i.a.Luas,
                                  PemegangHak = i.a.PemegangHak,
                                  Status = i.a.Status
                              }).ToList();
                return result;
            }
        }

        public void Update(BukuTanah entity)
        {
            using (var context = new AISContext<BukuTanah>())
            {
                BukuTanah data = context.DBEntities.Where(i => i.NB_Barcode == entity.NB_Barcode).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.IDHak = entity.IDHak;
                    data.NomorHak = entity.NomorHak;
                    data.No_Album = entity.No_Album;
                    data.IDDesa = entity.IDDesa;
                    data.IDKecamatan = entity.IDKecamatan;
                    data.Luas = entity.Luas;
                    data.PemegangHak = entity.PemegangHak;
                    data.Status = entity.Status;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IBukuTanahRepository Implementation

        public BukuTanah GetDataById(string nbBarcode)
        {
            using (AISContext<BukuTanah> context = new AISContext<BukuTanah>())
            {
                return context.DBEntities.Where(i => i.NB_Barcode == nbBarcode).FirstOrDefault();
            }
        }

        #endregion

    }
}
