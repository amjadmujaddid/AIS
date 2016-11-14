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
    public class AlbumRepository : IAlbumRepository
    {

        #region IDAL Repository

        public void Add(Album entity)
        {
            entity.RecordStatus = "A";
            using (var context = new AISContext<Album>())
            {
                context.DBEntities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Album entity)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAll()
        {
            using (var context = new AISContext<Album>())
            {
                var result = (from a in context.DBEntities
                              join b in context.Set<GenVariable>() on a.RecordStatus equals b.Variable into tmp
                              from tmptest in tmp.DefaultIfEmpty()
                              select new
                              {
                                  a,
                                  tmptest.Keterangan
                              }).ToList()
                              .Select(i => new Album
                              {
                                  RecordStatus = i.Keterangan,
                                  No_Album = i.a.No_Album,
                                  Lemari = i.a.Lemari,
                                  Rak = i.a.Rak,
                                  Blok = i.a.Blok
                              }).ToList();
                return result;
            }
        }

        public void Update(Album entity)
        {
            using (var context = new AISContext<Album>())
            {
                Album data = context.DBEntities.Where(i => i.No_Album == entity.No_Album).FirstOrDefault();

                if (data == null)
                {
                    //TBD for error exception data not exist
                    throw new Exception("Data Not Exist");
                }
                else
                {
                    data.RecordStatus = entity.RecordStatus.Substring(0, 1);
                    data.Lemari = entity.Lemari;
                    data.Rak = entity.Rak;
                    data.Blok = entity.Blok;
                    context.SaveChanges();
                }
            }
        }

        #endregion

        #region IAlbumRepository Implementation

        public Album GetDataById(string noAlbum)
        {
            using (AISContext<Album> context = new AISContext<Album>())
            {
                return context.DBEntities.Where(i => i.No_Album == noAlbum).FirstOrDefault();
            }
        }

        #endregion
    }
}
