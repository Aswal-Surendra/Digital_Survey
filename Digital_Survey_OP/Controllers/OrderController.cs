using System.Threading.Tasks;
using System;
using System.Web.Mvc;

namespace Digital_Survey_OP_Controllers
{
    /// <summary>
    /// The example controller.
    /// </summary>
    //[Authorize]
    [RoutePrefix("api/Account")]
    public class OrderController : System.Web.Http.ApiController
    {
        
        /// <summary>
        /// Gets the order detail.
        /// </summary>
        /// <returns>Order Detail</returns>
        [Route("orderDetail")]
        [HttpGet]
        public int GetOrderDetails()
        {

                return 5;
        }

    }
}
