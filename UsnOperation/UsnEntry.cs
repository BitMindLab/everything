﻿// -----------------------------------------------------------------------
// <copyright file="UsnEntry.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace UsnOperation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using PInvoke.Win32.Constants;
    using PInvoke.Win32.Structures;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class UsnEntry
    {
        public UInt32 RecordLength { get; private set; }
        public UInt64 FileReferenceNumber { get; private set; }

        /// <summary>
        /// Gets the parent file reference number.
        /// When its values is 1407374883553285(0x5000000000005L), it means this file/folder is under drive root
        /// </summary>
        /// <value>
        /// The parent file reference number.
        /// </value>
        public UInt64 ParentFileReferenceNumber { get; private set; }
        public Int64 Usn { get; private set; }
        public UInt32 Reason { get; private set; }
        public UInt32 FileAttributes { get; private set; }
        public Int32 FileNameLength { get; private set; }
        public Int32 FileNameOffset { get; private set; }
        public string FileName { get; private set; }
        public bool IsFolder 
        { 
            get 
            {
                return (this.FileAttributes & Win32ApiConstant.FILE_ATTRIBUTE_DIRECTORY) != 0;
            } 
        }
            
        public UsnEntry(USN_RECORD_V2 usnRecord)
        {
            this.RecordLength = usnRecord.RecordLength;
            this.FileReferenceNumber = usnRecord.FileReferenceNumber;
            this.ParentFileReferenceNumber = usnRecord.ParentFileReferenceNumber;
            this.Usn = usnRecord.Usn;
            this.Reason = usnRecord.Reason;
            this.FileAttributes = usnRecord.FileAttributes;
            this.FileNameLength = usnRecord.FileNameLength;
            this.FileNameOffset = usnRecord.FileNameOffset;
            this.FileName = usnRecord.FileName;
        }
    }
}
