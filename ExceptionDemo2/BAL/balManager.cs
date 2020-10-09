using DAL;
using System;

namespace BAL
{
    public class balManager
    {
        public void Method2()
        {
            try
            {
                dalManager odalManager = new dalManager();
                odalManager.Method1();
            }
            catch (Exception ex)
            {
                //throw ex; //resets the stack trace Coming from Method 1 and propogates it to the caller(Main)
                throw;
            }
        }
    }
}
