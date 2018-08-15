using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFSharia" in both code and config file together.
    [ServiceContract]
    public interface IWCFSharia
    {
        [OperationContract]
        int insertMember(Daftarmember daftar);

        [OperationContract]
        int updateMember(Daftarmember daftar);

        //[OperationContract]
        //ArrayList ListMember(string id);
    }
}