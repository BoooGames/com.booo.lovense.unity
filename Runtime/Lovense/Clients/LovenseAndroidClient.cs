#if UNITY_ANDROID
using System;
using System.Collections.Generic;
using Boooo.Lovense.Callbacks.Android;
using Boooo.Lovense.Model;
using UnityEngine;

namespace Boooo.Lovense.Clients
{
    public class LovenseAndroidClient : ILovenseClient
    {
        AndroidJavaClass unityClass;
        AndroidJavaObject unityActivity;
        AndroidJavaObject pluginInstance;

        public LovenseAndroidClient()
        {
            Debug.Log("Created lovense android client");
            InitializePlugin();
        }

        public void SetDeveloperToken(string token)
        {
            GetInstance().Call("setDeveloperToken", $"HycXERLGWzrtW8H1-QN4NvoiaqNc4pdkS2SH1OM3kkDFxvOuQFUx7uAsRb1KQu5r");
        }
        
        public void SearchToys(Action<LovenseToy> OnSearchToy, Action FinishSearch, Action<LovenseError> OnError)
        {
            GetInstance().Call("searchToys", new OnSearchToyListener(OnSearchToy, FinishSearch, OnError));
        }

        public void StopSearching()
        {
            GetInstance().Call("stopSearching");
        }

        public List<LovenseToy> ListToys(Action<LovenseError> OnError)
        {
            Debug.LogWarning("LIST FUNCTION TRYYY!");
            var toys = GetInstance().Call<List<AndroidJavaObject>>("listToys", new OnErrorListener(OnError));

            Debug.LogWarning(toys.Count);
            throw new NotImplementedException(); 
        }

        public void SaveToys(List<LovenseToy> toys, Action<LovenseError> OnError)
        {
            Debug.LogWarning("LIST FUNCTION TRYYY!");

            GetInstance().Call("saveToys", toys, new OnErrorListener(OnError));
            throw new NotImplementedException(); 
        }

        public void ConnectToy(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError)
        {
            GetInstance().Call("connectToy", toyID, new OnConnectListener(OnConnect, OnError));
        }

        public void DisconnectToy(string toyID)
        {
            GetInstance().Call("disconnect", toyID);
        }

        public void ConnectToy(string toyID)
        {
            GetInstance().Call("connectToy", toyID);
        }

        public void SetConnectListener(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError)
        {
            GetInstance().Call("setConnectListener", toyID, new OnConnectListener(OnConnect, OnError));
        }

        public bool IsToyConnected(string toyID)
        {
            return GetInstance().Call<bool>("isConnected", toyID);
        }

        public void SendCommand(string toyID, LovenseCommand command, int intensity)
        {
            GetInstance().Call("sendCommand", toyID, (int) command, intensity);
        }

        public void SendCommand(string toyID, LovenseCommand command)
        {
            GetInstance().Call("sendCommand", toyID, (int) command);
        }

        public void AddCommandListener(string toyID, Action<string, LovenseError> OnError)
        {
            GetInstance().Call("addListener", toyID, new OnSendCommandErrorListener(OnError));
        }

        public void AddCommandListener(string toyID, Action<string, LovenseToy> OnSucceed)
        {
            GetInstance().Call("addListener", toyID, new OnCallBackDeviceTypListener(OnSucceed));
        }

        void InitializePlugin()
        {
            unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            unityActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
            pluginInstance = new AndroidJavaObject("com.lovense.sdklibrary.Lovense");

            if(pluginInstance == null)
            {
                Debug.LogError("Failed to initialize plugin");
            }
            else
            {
                Debug.Log("Seems to work?");
            }
        }

        private AndroidJavaObject GetInstance()
        { 
            var application = unityActivity.Call<AndroidJavaObject>("getApplication");
            return pluginInstance.CallStatic<AndroidJavaObject>("getInstance", application);
        }
    }
}
#endif