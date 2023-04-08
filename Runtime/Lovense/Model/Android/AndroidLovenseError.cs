using UnityEngine;

namespace Boooo.Lovense.Model.Android
{
    public class AndroidLovenseError : LovenseError
    {
        private AndroidJavaObject nativeError;

        public AndroidLovenseError(AndroidJavaObject msg)
        {
            nativeError = msg;
        }

        public override string GetCode() {
            return nativeError.Call<string>("getCode");
        }

        public override string GetMessage() {
            return nativeError.Call<string>("getMessage");
        }
    }
}