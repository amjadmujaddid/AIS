using AISEF.DAL;
using AISEF.DAL.Interface;
using AISService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AISService
{
    public class ComSettingService : IComSettingService
    {
        #region Class Attribute

        IComSettingRepository _comSettingRepo;

        #endregion

        #region Constructor

        public ComSettingService()
        {
            _comSettingRepo = new ComSettingRepository();
        }

        #endregion

        #region IComSettingService Implementation

        public InsertDataComSettingResponse InsertDataComSetting(InsertDataComSettingRequest request)
        {
            InsertDataComSettingResponse response = new InsertDataComSettingResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _comSettingRepo.Add(request.ComSetting);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataComSettingResponse UpdateDataComSetting(UpdateDataComSettingRequest request)
        {
            UpdateDataComSettingResponse response = new UpdateDataComSettingResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _comSettingRepo.Update(request.ComSetting);
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
