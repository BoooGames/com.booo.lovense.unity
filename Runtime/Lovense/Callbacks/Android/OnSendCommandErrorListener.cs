using System;
using UnityEngine;
using Boooo.Lovense.Model;
using Boooo.Lovense.Model.Android;

namespace Boooo.Lovense.Callbacks.Android
{
    class OnSendCommandErrorListener : AndroidJavaProxy
    {
        Action<string, LovenseError> _onCommandError;

        public OnSendCommandErrorListener(Action<string, LovenseError> OnCommandError) : base("com.lovense.sdklibrary.callBack.OnSendCommandErrorListener")
        {
            _onCommandError = OnCommandError;
        }

        public void sendCommandError(string toyId, AndroidJavaObject error)
        {
            _onCommandError?.Invoke(toyId, new AndroidLovenseError(error));
        }

    }
}