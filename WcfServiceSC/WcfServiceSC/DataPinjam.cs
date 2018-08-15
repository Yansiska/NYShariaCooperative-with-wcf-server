using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceSC
{
    [DataContract]
    public class DataPinjam
    {
        string idpinjam;
        string idanggota;
        string nama;
        string gaji;
        string jumlahP;
        string jangkaP;
        string angsuran;
        string status;

        [DataMember]
        public string ID
        {
            get { return idpinjam; }
            set { idpinjam = value; }
        }

        [DataMember]
        public string IDAnggota
        {
            get { return idanggota; }
            set { idanggota = value; }
        }

        [DataMember]
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        [DataMember]
        public string Gaji
        {
            get { return gaji; }
            set { gaji = value; }
        }

        [DataMember]
        public string JumlahPinjam
        {
            get { return jumlahP; }
            set { jumlahP = value; }
        }

        [DataMember]
        public string JangkaPinjam
        {
            get { return jangkaP; }
            set { jangkaP = value; }
        }

        [DataMember]
        public string Angsuran
        {
            get { return angsuran; }
            set { angsuran = value; }
        }

        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}