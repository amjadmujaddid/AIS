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
    public class DesaService : IDesaService
    {
        #region Class Attribute

        IDesaRepository _desaRepo;

        #endregion

        #region Constructor

        public DesaService()
        {
            _desaRepo = new DesaRepository();
        }

        #endregion

        #region IDesaService Implementation

        public GetAllDataDesaResponse GetAllDataDesa()
        {
            GetAllDataDesaResponse response = new GetAllDataDesaResponse();
            try
            {
                List<Desa> _listDesa = _desaRepo.GetAll();
                response.DesaList.AddRange(_listDesa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataDesaByIdResponse GetDataDesaById(GetDataDesaByIdRequest request)
        {
            GetDataDesaByIdResponse response = new GetDataDesaByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.Desa = _desaRepo.GetDataById(request.idDesa);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataDesaResponse InsertDataDesa(InsertDataDesaRequest request)
        {
            InsertDataDesaResponse response = new InsertDataDesaResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _desaRepo.Add(request.Desa);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataDesaResponse UpdateDataDesa(UpdateDataDesaRequest request)
        {
            UpdateDataDesaResponse response = new UpdateDataDesaResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _desaRepo.Update(request.Desa);
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
