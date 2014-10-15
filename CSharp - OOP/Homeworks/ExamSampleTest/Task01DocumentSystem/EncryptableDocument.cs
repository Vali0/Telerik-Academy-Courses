﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class EncryptableDocument : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return String.Format("{0}[encrypted]", this.GetType().Name);
            }
            return base.ToString();
        }
    }
}
