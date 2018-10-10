using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRecorder
{
    class EncryptAndDecrypt
    {
        public String EncryptString(String data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder enValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                enValue.Append(hashdata[i].ToString());
            }

            return enValue.ToString();
        }
    }
}
