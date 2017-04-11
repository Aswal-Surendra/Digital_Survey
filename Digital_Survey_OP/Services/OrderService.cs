using System;
using System.Reflection;

namespace Digital_Survey_Op_Services
{
    /// <summary>
    /// Example service demonstrating the required pattern
    /// for building commerce services based on core services.
    /// </summary>
    public class OrderService : IOrderService
    {
        
        /// <summary>
        /// Gets the version info and demonstrates accessing core services.
        /// </summary>
        /// <returns></returns>
        public int GetOrderDetails()
        {
            
            return 5;
        }
    }
}
