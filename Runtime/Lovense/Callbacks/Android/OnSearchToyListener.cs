using System;
using UnityEngine;
using Boooo.Lovense.Model;
using Boooo.Lovense.Model.Android;

namespace Boooo.Lovense.Callbacks.Android
{
    class OnSearchToyListener : AndroidJavaProxy
    {
        private Action<LovenseToy> _onSearchToy;
        private Action _finishSearch;
        private Action<LovenseError> _onError;

        public OnSearchToyListener(Action<LovenseToy> OnSearchToy, Action FinishSearch, Action<LovenseError> OnError) : base("com.lovense.sdklibrary.callBack.OnSearchToyListener")
        {
            _onSearchToy = OnSearchToy;
            _finishSearch = FinishSearch;
            _onError = OnError;
        }

        public void onSearchToy(AndroidJavaObject lovenseToy)
        {
            _onSearchToy?.Invoke(new AndroidLovenseToy(lovenseToy));
        }

        public void finishSearch()
        {
            _finishSearch?.Invoke();
        }

        public void onError(AndroidJavaObject error)
        {
            _onError?.Invoke(new AndroidLovenseError(error));
        }
    }
}