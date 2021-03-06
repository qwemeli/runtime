// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct CMSG_RECIPIENT_ENCODE_INFO
        {
            internal CMsgCmsRecipientChoice dwRecipientChoice;

            //union
            //{
            //   CMSG_KEY_TRANS_RECIPIENT
            //     PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO pKeyTrans;
            //   CMSG_KEY_AGREE_RECIPIENT
            //     PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO pKeyAgree;
            //   CMSG_MAIL_LIST_RECIPIENT
            //     PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO pMailList;
            //}
            internal IntPtr pCmsRecipientEncodeInfo;
        }
    }
}
