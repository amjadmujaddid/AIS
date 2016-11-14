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
    public class BukuTanahService : IBukuTanahService
    {

        #region Class Attribute

        IBukuTanahRepository _bukuTanahRepo;

        #endregion

        #region Constructor

        public BukuTanahService()
        {
            _bukuTanahRepo = new BukuTanahRepository();
        }

        #endregion

        #region IBukuTanahService Implementation

        public GetAllDataBukuTanahResponse GetAllDataBukuTanah()
        {
            GetAllDataBukuTanahResponse response = new GetAllDataBukuTanahResponse();
            try
            {
                List<BukuTanah> _listBukuTanah = _bukuTanahRepo.GetAll();
                response.BukuTanahList.AddRange(_listBukuTanah);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataBukuTanahByIdResponse GetDataBukuTanahById(GetDataBukuTanahByIdRequest request)
        {
            GetDataBukuTanahByIdResponse response = new GetDataBukuTanahByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _bukuTanahRepo.GetDataById(request.NB_Barcode);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataBukuTanahResponse InsertDataBukuTanah(InsertDataBukuTanahRequest request)
        {
            InsertDataBukuTanahResponse response = new InsertDataBukuTanahResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _bukuTanahRepo.Add(request.BukuTanah);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataBukuTanahResponse UpdateDataBukuTanah(UpdateDataBukuTanahRequest request)
        {
            UpdateDataBukuTanahResponse response = new UpdateDataBukuTanahResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _bukuTanahRepo.Update(request.BukuTanah);
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
