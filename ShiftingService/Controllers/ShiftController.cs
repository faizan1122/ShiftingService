using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftingService.Models;

namespace ShiftingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        Response resp = new Response();
      
        [HttpPost]
        public Response ShiftAssignment(ShiftDetail shift)
        {
            
            resp.Message= "Already Assigned for the same day";
            var res = Data.lst.Where(x => x.WorkerID == shift.WorkerID && x.Shiftdate == shift.Shiftdate).FirstOrDefault();

            if(res == null)
            {
                Data.lst.Add(shift);

                resp.Message = "Shift has been assigned";
            }
            return resp;
        }
    }
}
