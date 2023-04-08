namespace Boooo.Lovense.Model
{
    public abstract class LovenseToy
    {   
        public LovenseToy()
        {   
        }

        public abstract int GetVersion();
        public abstract string GetDeviceName();
        public abstract LovenseState GetStatus();
        public abstract int GetBattery();
        public abstract int GetRssi();
        public abstract string GetToyId();
        public abstract string GetUuid();
        public abstract string GetDeviceType();
        public abstract string GetMacAddress();
    }
}