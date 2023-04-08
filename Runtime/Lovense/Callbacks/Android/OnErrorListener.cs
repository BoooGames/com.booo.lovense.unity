using System;
using UnityEngine;
using Boooo.Lovense.Model;
using Boooo.Lovense.Model.Android;

namespace Boooo.Lovense.Callbacks.Android
{
    class OnErrorListener : AndroidJavaProxy
    {
        private Action<LovenseError> _onError;

        public OnErrorListener(Action<LovenseError> OnError) : base("com.lovense.sdklibrary.callBack.OnErrorListener")
        {
            _onError = OnError;
        }

        public void onError(AndroidJavaObject error)
        {
            _onError?.Invoke(new AndroidLovenseError(error));
        }
    }
}