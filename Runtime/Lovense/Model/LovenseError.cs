namespace Boooo.Lovense.Model
{
    public abstract class LovenseError
    {
        public LovenseError()
        {
        }

        public abstract string GetCode();

        public abstract string GetMessage();
    }
}