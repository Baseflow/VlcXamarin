using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Org.Videolan.Libvlc
{
    public sealed partial class MediaList
    {

        static IntPtr id_onEventNative_IJJ;
        // Metadata.xml XPath method reference: path="/api/package[@name='org.videolan.libvlc']/class[@name='MediaList']/method[@name='onEventNative' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
        [Register("onEventNative", "(IJJ)Lorg/videolan/libvlc/MediaList$Event;", "")]
        protected override unsafe global::Org.Videolan.Libvlc.VLCObject.Event OnEventNative(int p0, long p1, long p2)
        {
            if (id_onEventNative_IJJ == IntPtr.Zero)
                id_onEventNative_IJJ = JNIEnv.GetMethodID(class_ref, "onEventNative", "(IJJ)Lorg/videolan/libvlc/MediaList$Event;");
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                __args[2] = new JValue(p2);
                return global::Java.Lang.Object.GetObject<global::Org.Videolan.Libvlc.VLCObject.Event>(JNIEnv.CallObjectMethod(Handle, id_onEventNative_IJJ, __args), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}