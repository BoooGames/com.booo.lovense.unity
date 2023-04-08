using System;
using UnityEngine;
using Boooo.Lovense.Model;
using Boooo.Lovense.Model.Android;

namespace Boooo.Lovense.Callbacks.Android
{
    class OnConnectListener : AndroidJavaProxy
    {
        private Action<LovenseError> _onError;
        private Action<string, string> _onConnect;

        public OnConnectListener(Action<string, string> OnConnect, Action<LovenseError> OnError) : base("com.lovense.sdklibrary.callBack.OnConnectListener")
        {
            _onError = OnError;
            _onConnect = OnConnect;
        }

        public void onConnect(string toyId, string status)
        {
            _onConnect?.Invoke(toyId, status);
        }

        public void onError(AndroidJavaObject error)
        {
            _onError?.Invoke(new AndroidLovenseError(error));
        }
    }
}