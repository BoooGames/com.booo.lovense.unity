using System;
using UnityEngine;
using Boooo.Lovense.Model;
using Boooo.Lovense.Model.Android;

namespace Boooo.Lovense.Callbacks.Android
{
    class OnCallBackDeviceTypListener : AndroidJavaProxy
    {
        Action<string, LovenseToy> _onCommandSucceed;

        public OnCallBackDeviceTypListener(Action<string, LovenseToy> OnCommandSucceed) : base("com.lovense.sdklibrary.callBack.OnCallBackDeviceTypListener")
        {
            _onCommandSucceed = OnCommandSucceed;
        }

        public void deviceType(string toyId, AndroidJavaObject toy)
        {
            _onCommandSucceed?.Invoke(toyId, new AndroidLovenseToy(toy));
        }

    }
}