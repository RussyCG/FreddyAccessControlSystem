using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions.Base
{
    /// <summary>
    /// Generic Exception for any Database error that occurs
    /// </summary>
    public abstract class FreddyDBException : Exception
    {
        public FreddyDBException()
        {
        }

        public FreddyDBException(string message) : base(message)
        {
        }

        public FreddyDBException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FreddyDBException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
