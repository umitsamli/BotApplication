
namespace SAMLibrary
{
    public static class Register
    {
        private static TRegister reg;
        public static TRegister Registry
        {
            get
            {
                if (reg == null)
                    reg = new TRegister();
                return reg;

            }
        }
    }
}
