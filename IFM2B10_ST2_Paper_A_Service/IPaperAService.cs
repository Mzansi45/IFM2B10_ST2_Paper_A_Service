using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IFM2B10_ST2_Paper_A_Service
{
    [ServiceContract]
    public interface IPaperAService
    {
        [OperationContract]
        void DoWork();
    }
}
