using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment
{
    public class EquipmentRequestClass
    {
        public int RequestID { get; set; }
        public string EquipmentName { get; set; }
        public int Quantity { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestDate { get; set; }

        public EquipmentRequestClass() { }

        public EquipmentRequestClass(int id, string equipmentName, int quantity, string requestType, DateTime requestDate)
        {
            RequestID = id;
            EquipmentName = equipmentName;
            Quantity = quantity;
            RequestType = requestType;
            RequestDate = requestDate;
        }
    }
}
