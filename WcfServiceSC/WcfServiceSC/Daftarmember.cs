using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfServiceSC
{
    [DataContract]
    public class Daftarmember
    {
        string id;
        string nama;
        string address;
        string dateofbirth;
        string jeniskelamin;
        string work;
        string gaji;
        string email;
        string nohp;
        string password;

        [DataMember]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public string DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        [DataMember]
        public string Jk
        {
            get { return jeniskelamin; }
            set { jeniskelamin = value; }
        }

        [DataMember]
        public string Work
        {
            get { return work; }
            set { work = value; }
        }

        [DataMember]
        public string Gaji
        {
            get { return gaji; }
            set { gaji = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public string NoHP
        {
            get { return nohp; }
            set { nohp = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}