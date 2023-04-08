using Boooo.Lovense.Clients;
using UnityEngine;

namespace Boooo.Lovense.Test
{
    public class LovenseClient : MonoBehaviour
    {
        public static ILovenseClient Client { get { return _client; } }        
        private static ILovenseClient _client;

        [SerializeField] private string token = "";

        void Awake()
        {
            #if UNITY_ANDROID && !UNITY_EDITOR                
                _client = new LovenseAndroidClient();
            #else       
                _client = new LovenseEditorClient();
            #endif
            
            _client.SetDeveloperToken(token);
        }
    }
}