using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Infrastructure.CrossCutting.ExtensionMethods
{
   public  class ExtensionHelper
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
         
    }
}
