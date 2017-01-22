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
    public class WarkahService : IWarkahService
    {
        #region Class Attribute

        IWarkahRepository _warkahRepo; 

        #endregion

        #region Constructor

        public WarkahService()
        {
            _warkahRepo = new WarkahRepository();
        }

        #endregion

        #region IWarkahService Implementation

        public GetAllDataWarkahResponse GetAllDataWarkah()
        {
            GetAllDataWarkahResponse response = new GetAllDataWarkahResponse();
            try
            {
                List<Warkah> _listWarkah = _warkahRepo.GetAll();
                response.WarkahList.AddRange(_listWarkah);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataWarkahByIdResponse GetDataWarkahById(GetDataWarkahByIdRequest request)
        {
            GetDataWarkahByIdResponse response = new GetDataWarkahByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Warkah = _warkahRepo.GetDataById(request.nwBarcode);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataWarkahResponse InsertDataWarkah(InsertDataWarkahRequest request)
        {
            InsertDataWarkahResponse response = new InsertDataWarkahResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _warkahRepo.Add(request.Warkah);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataWarkahResponse UpdateDataWarkah(UpdateDataWarkahRequest request)
        {
            UpdateDataWarkahResponse response = new UpdateDataWarkahResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _warkahRepo.Update(request.Warkah);
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
