using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApplicationCore.Application.Claims
{
    public class PhoneClaimModel
    {

        public string FileName { get; }
        public Stream ClaimStream { get; }

        public PhoneClaimModel(string fileName, Stream claimStream)
        {
            FileName = fileName;
            ClaimStream = claimStream;
        }



    }
}
