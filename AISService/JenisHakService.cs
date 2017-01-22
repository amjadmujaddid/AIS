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
    public class JenisHakService : IJenisHakService
    {
        #region Class Attribute

        IJenisHakRepository _jenisHakRepo;

        #endregion

        #region Constructor

        public JenisHakService()
        {
            _jenisHakRepo = new JenisHakRepository();

        }

        #endregion

        #region IJenisHakService Implmentation

        public GetAllDataJenisHakResponse GetAllDataJenisHak()
        {
            GetAllDataJenisHakResponse response = new GetAllDataJenisHakResponse();
            try
            {
                List<JenisHak> _listJenisHak = _jenisHakRepo.GetAll();
                response.JenisHakList.AddRange(_listJenisHak);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return response;
        }

        public GetDataJenisHakByIdResponse GetDataJenisHakById(GetDataJenisHakByIdRequest request)
        {
            GetDataJenisHakByIdResponse response = new GetDataJenisHakByIdResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    response.JenisHak = _jenisHakRepo.GetDataById(request.idHak);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public InsertDataJenisHakResponse InsertDataJenisHak(InsertDataJenisHakRequest request)
        {
            InsertDataJenisHakResponse response = new InsertDataJenisHakResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _jenisHakRepo.Add(request.JenisHak);
                    transScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return response;
        }

        public UpdateDataJenisHakResponse UpdateDataJenisHak(UpdateDataJenisHakRequest request)
        {
            UpdateDataJenisHakResponse response = new UpdateDataJenisHakResponse();
            try
            {
                using (TransactionScope transScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    _jenisHakRepo.Update(request.JenisHak);
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
