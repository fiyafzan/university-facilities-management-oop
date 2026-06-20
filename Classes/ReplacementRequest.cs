using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment
{
    public class ReplacementRequest
    {
        public int RequestID { get; set; }
        public string EquipmentName { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestDate { get; set; }
        public string ProblemDescription { get; set; }

        public ReplacementRequest() { }

        public ReplacementRequest(int id, string equipmentName, string requestType, DateTime requestDate, string problemDesc)
        {
            RequestID = id;
            EquipmentName = equipmentName;
            RequestType = requestType;
            RequestDate = requestDate;
            ProblemDescription = problemDesc;
        }
    }
}
