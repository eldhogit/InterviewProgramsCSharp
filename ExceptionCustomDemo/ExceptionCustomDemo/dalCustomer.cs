using ExceptionCustomDemo.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCustomDemo
{
    class dalCustomer
    {

        public void Save()
        {
            try
            {
                //TODO:
                throw new Exception("Low level exception");//Inner Exception
            }
            catch (Exception ex)
            {

                throw new InvalidAddressException("Address should be India", ex);// Exception Message
            }
        }

    }
}
  