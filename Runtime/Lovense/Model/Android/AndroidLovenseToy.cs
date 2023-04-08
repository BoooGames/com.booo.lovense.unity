using UnityEngine;

namespace Boooo.Lovense.Model.Android
{
    public class AndroidLovenseToy : LovenseToy
    {
        private AndroidJavaObject nativeToy;

        public AndroidLovenseToy(AndroidJavaObject toy)
        {
            nativeToy = toy;
        }

        public override int GetBattery()
        {
            return nativeToy.Call<int>("getBattery");
        }

        public override string GetDeviceName()
        {
            return nativeToy.Call<string>("getDeviceName");
        }

        public override string GetDeviceType()
        {
            return nativeToy.Call<string>("getDeviceType");
        }

        public override string GetMacAddress()
        {
            return nativeToy.Call<string>("getMacAddress");
        }

        public override int GetRssi()
        {
            return nativeToy.Call<int>("getRssi");
        }

        public override LovenseState GetStatus()
        {
            return (LovenseState) nativeToy.Call<int>("getStatus");
        }

        public override string GetToyId()
        {
            return nativeToy.Call<string>("getToyId");
        }

        public override string GetUuid()
        {
            return nativeToy.Call<string>("getUuid");
        }

        public override int GetVersion()
        {
            return nativeToy.Call<int>("getVersion");
        }
    }
}