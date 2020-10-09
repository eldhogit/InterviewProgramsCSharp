using System;

namespace DAL
{
    public class dalManager
    {
        public void Method1()
        {
            try
            {
                
                throw new Exception("Inside Method1");
            }
            catch (Exception ex)
            {
                var errMsg = ex.Message;
                throw;
            }
        }
    }
}
