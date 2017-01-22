using AISEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISService.Contract
{
    #region Service Definition

    public interface IStaffService
    {
        /// <summary>
        /// Get All Data Staff
        /// </summary>
        /// <returns></returns>
        GetAllDataStaffResponse GetAllDataStaff();

        /// <summary>
        /// Get Data Staff By Id NIP
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDataStaffByIdResponse GetDataStaffById(GetDataStaffByIdRequest request);

        /// <summary>
        /// Insert Data Staff
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        InsertDataStaffResponse InsertDataStaff(InsertDataStaffRequest request);

        /// <summary>
        /// Update Data Staff
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDataStaffResponse UpdateDataStaff(UpdateDataStaffRequest request);
    }

    #endregion

    #region Message

    public class GetAllDataStaffRequest
    {

    }

    public class GetAllDataStaffResponse : ResponseBase
    {
        private List<Staff> _staffList;

        public List<Staff> StaffList
        {
            get { return _staffList ?? (_staffList = new List<Staff>()); }
        }
    }

    public class GetDataStaffByIdRequest
    {
        public string nip { get; set; }
    }

    public class GetDataStaffByIdResponse : ResponseBase
    {
        public Staff Staff { get; set; }
    }

    public class InsertDataStaffRequest
    {
        public Staff Staff { get; set; }
    }

    public class InsertDataStaffResponse : ResponseBase
    {

    }

    public class UpdateDataStaffRequest
    {
        public Staff Staff { get; set; }
    }

    public class UpdateDataStaffResponse : ResponseBase
    {
        public Staff Staff { get; set; }
    }

    #endregion
}
