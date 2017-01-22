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
    public class JabatanService : IJabatanService
    {
        #region Class Attribute

        IJabatanRepository _jabatanRepo;

        #endregion

        #region Constructor

        public JabatanService()
        {
            _jabatanRepo = new JabatanRepository();
        }

        #endregion

        #region IJabatanService Implementation

        public GetDataJabatanByIdResponse GetDataJabatanById(GetDataJabatanByIdRequest request)
        {
            GetDataJabatanByIdResponse response = new GetDataJabatanByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Jabatan = _jabatanRepo.GetDataById(request.IDJabatan);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataJabatanResponse InsertDataJabatan(InsertDataJabatanRequest request)
        {
            InsertDataJabatanResponse response = new InsertDataJabatanResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _jabatanRepo.Add(request.Jabatan);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public GetAllDataJabatanResponse GetAllDataJabatan()
        {
            GetAllDataJabatanResponse response = new GetAllDataJabatanResponse();
            try
            {
                List<Jabatan> _listJabatan = _jabatanRepo.GetAll();
                response.JabatanList.AddRange(_listJabatan);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public UpdateDataJabatanResponse UpdateDataJabatan(UpdateDataJabatanRequest request)
        {
            UpdateDataJabatanResponse response = new UpdateDataJabatanResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _jabatanRepo.Update(request.Jabatan);
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
