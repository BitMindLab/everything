﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsnOperation
{
    [Flags]
    public enum UsnReasonCode : uint
    {
        USN_REASON_DATA_OVERWRITE        = 0x00000001,
        USN_REASON_DATA_EXTEND           = 0x00000002,
        USN_REASON_DATA_TRUNCATION       = 0x00000004,
        USN_REASON_NAMED_DATA_OVERWRITE  = 0x00000010,
        USN_REASON_NAMED_DATA_EXTEND     = 0x00000020,
        USN_REASON_NAMED_DATA_TRUNCATION = 0x00000040,
        USN_REASON_FILE_CREATE           = 0x00000100,
        USN_REASON_FILE_DELETE           = 0x00000200,
        USN_REASON_EA_CHANGE             = 0x00000400,
        USN_REASON_SECURITY_CHANGE       = 0x00000800,
        USN_REASON_RENAME_OLD_NAME       = 0x00001000,
        USN_REASON_RENAME_NEW_NAME       = 0x00002000,
        USN_REASON_INDEXABLE_CHANGE      = 0x00004000,
        USN_REASON_BASIC_INFO_CHANGE     = 0x00008000,
        USN_REASON_HARD_LINK_CHANGE      = 0x00010000,
        USN_REASON_COMPRESSION_CHANGE    = 0x00020000,
        USN_REASON_ENCRYPTION_CHANGE     = 0x00040000,
        USN_REASON_OBJECT_ID_CHANGE      = 0x00080000,
        USN_REASON_REPARSE_POINT_CHANGE  = 0x00100000,
        USN_REASON_STREAM_CHANGE         = 0x00200000,
        USN_REASON_CLOSE                 = 0x80000000
    }
}
