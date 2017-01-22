using AISEF.DAL;
using AISEF.DAL.Interface;
using AISEF.Model;
using AISService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AISService
{
    public class AlbumService : IAlbumService
    {
        #region Class Attribute

        IAlbumRepository _albumRepo;

        #endregion

        #region Constructor

        public AlbumService()
        {
            _albumRepo = new AlbumRepository();
        }

        #endregion

        #region IAlbum Service Implementation

        public GetAllDataAlbumResponse GetAllDataAlbum()
        {
            GetAllDataAlbumResponse response = new GetAllDataAlbumResponse();
            try
            {
                List<Album> _listAlbum = _albumRepo.GetAll();
                response.AlbumList.AddRange(_listAlbum);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataAlbumByIdResponse GetDataAlbumById(GetDataAlbumByIdRequest request)
        {
            GetDataAlbumByIdResponse response = new GetDataAlbumByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Album = _albumRepo.GetDataById(request.No_Album);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataAlbumResponse InsertDataAlbum(InsertDataAlbumRequest request)
        {
            InsertDataAlbumResponse response = new InsertDataAlbumResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _albumRepo.Add(request.Album);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataAlbumResponse UpdateDataAlbum(UpdateDataAlbumRequest request)
        {
            UpdateDataAlbumResponse response = new UpdateDataAlbumResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _albumRepo.Update(request.Album);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        #endregion
    }
}
