using System;
using System.Collections.Generic;
using Boooo.Lovense.Model;

namespace Boooo.Lovense.Clients
{
    public interface ILovenseClient
    {
        public void SetDeveloperToken(string token);
        public void SearchToys(Action<LovenseToy> OnSearchToy, Action FinishSearch, Action<LovenseError> OnError);
        public void StopSearching();
        public List<LovenseToy> ListToys(Action<LovenseError> OnError);
        public void SaveToys(List<LovenseToy> toys, Action<LovenseError> OnError);

        public void ConnectToy(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError);
        public void DisconnectToy(string toyID);
        public void ConnectToy(string toyID);
        public void SetConnectListener(string toyID, Action<string, string> OnConnect, Action<LovenseError> OnError);
        public bool IsToyConnected(string toyID);

        public void SendCommand(string toyID, LovenseCommand command, int intensity);
        public void SendCommand(string toyID, LovenseCommand command);
        public void AddCommandListener(string toyID, Action<string,LovenseError> OnError);
    }
}