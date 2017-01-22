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
    public class StaffService : IStaffService
    {
        #region Class Attribute

        IStaffRepository _staffRepo;

        #endregion

        #region Constructor

        public StaffService()
        {
            _staffRepo = new StaffRepository();
        }

        #endregion

        #region IStaffService Implementation

        public GetAllDataStaffResponse GetAllDataStaff()
        {
            GetAllDataStaffResponse response = new GetAllDataStaffResponse();
            try
            {
                List<Staff> _listStaff = _staffRepo.GetAll();
                response.StaffList.AddRange(_listStaff);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataStaffByIdResponse GetDataStaffById(GetDataStaffByIdRequest request)
        {
            GetDataStaffByIdResponse response = new GetDataStaffByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Staff = _staffRepo.GetDataById(request.nip);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataStaffResponse InsertDataStaff(InsertDataStaffRequest request)
        {
            InsertDataStaffResponse response = new InsertDataStaffResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _staffRepo.Add(request.Staff);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataStaffResponse UpdateDataStaff(UpdateDataStaffRequest request)
        {
            UpdateDataStaffResponse response = new UpdateDataStaffResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _staffRepo.Update(request.Staff);
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
