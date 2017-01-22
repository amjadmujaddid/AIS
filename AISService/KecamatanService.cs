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
    public class KecamatanService : IKecamatanService
    {
        #region Class Attirbute

        IKecamatanRepository _kecamatanRepo;

        #endregion

        #region Constructor

        public KecamatanService()
        {
            _kecamatanRepo = new KecamatanRepository();
        }

        #endregion

        #region IKecamatanService Implementation

        public GetAllDataKecamatanResponse GetAllDataKecamatan()
        {
            GetAllDataKecamatanResponse response = new GetAllDataKecamatanResponse();
            try
            {
                List<Kecamatan> _listKecamatan = _kecamatanRepo.GetAll();
                response.KecamatanList.AddRange(_listKecamatan);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataKecamatanByIdResponse GetDataKecamatanById(GetDataKecamatanByIdRequest request)
        {
            GetDataKecamatanByIdResponse response = new GetDataKecamatanByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Kecamatan = _kecamatanRepo.GetDataById(request.idKecamatan);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataKecamatanResponse InsertDataKecamatan(InsertDataKecamatanaRequest request)
        {
            InsertDataKecamatanResponse response = new InsertDataKecamatanResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _kecamatanRepo.Add(request.Kecamatan);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataKecamatanResponse UpdateDataKecamatan(UpdateDataKecamatanRequest request)
        {
            UpdateDataKecamatanResponse response = new UpdateDataKecamatanResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _kecamatanRepo.Update(request.Kecamatan);
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
