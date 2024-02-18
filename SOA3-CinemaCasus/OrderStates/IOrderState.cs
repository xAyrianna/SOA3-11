using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public interface IOrderState
    {
        public void CreateOrder();
        public void SubmitOrder();
        public void PayForOrder();
        public void CancelOrder();
        public void ChangeOrder();
        public void SendNotice();
    }
}
