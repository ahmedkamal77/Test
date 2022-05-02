using aes256withsalt;
using System;
using tribleedes;

namespace LoginPage
{
    class dec_file
    {
        string salt = "asd@asd_er$#wwer125m,,844poiyfheawab";
        

        public byte[] decrypt_TDES(string key, byte[] bytes)
        {
                byte[] decrybtedfile = null;
                TDES tdes = new TDES(key);
                decrybtedfile = tdes.decfile(bytes);
                GC.Collect();
                return decrybtedfile; 
        }
       
        public byte[] decrypt_AES(string key, byte[] Bytes)
        {
            byte[] decrybtedfile = null;
            decrybtedfile = cryptor.getdecryptor(key, Bytes, salt);
            return decrybtedfile;      
        }


    }
}
