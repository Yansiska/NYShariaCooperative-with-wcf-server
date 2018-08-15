using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ilogin" in both code and config file together.
    [ServiceContract]
    public interface Ilogin
    {
        [OperationContract]
        int login_member(string username, string password);
        [OperationContract]
        int login_admin(string username, string password);
    }
}
