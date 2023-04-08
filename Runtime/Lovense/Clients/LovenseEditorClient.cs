
using System;
using System.Collections.Generic;
using Boooo.Lovense.Model;
using UnityEngine;

namespace Boooo.Lovense.Clients
{
    public class LovenseEditorClient : ILovenseClient
    {
        public LovenseEditorClient()
        {
            Debug.Log("Created lovense editor client");
        }

        public void AddCommandListener(string toyID, Action<string, LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void ConnectToy(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void ConnectToy(string toyID)
        {
            throw new NotImplementedException();
        }

        public void DisconnectToy(string toyID)
        {
            throw new NotImplementedException();
        }

        public bool IsToyConnected(string toyID)
        {
            throw new NotImplementedException();
        }

        public List<LovenseToy> ListToys(Action<LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void SaveToys(List<LovenseToy> toys, Action<LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void SearchToys(Action<LovenseToy> OnSearchToy, Action FinishSearch, Action<LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void SendCommand(string toyID, LovenseCommand command, int intensity)
        {
            throw new NotImplementedException();
        }

        public void SendCommand(string toyID, LovenseCommand command)
        {
            throw new NotImplementedException();
        }

        public void SetConnectListener(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError)
        {
            throw new NotImplementedException();
        }

        public void SetDeveloperToken(string token)
        {
            throw new NotImplementedException();
        }

        public void StopSearching()
        {
            throw new NotImplementedException();
        }
    }
}