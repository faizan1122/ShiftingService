using NUnit.Framework;
using ShiftingService.Controllers;
using ShiftingService.Models;

namespace ShiftUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void ShiftUnitTest()
        {
            Response resp = new Response();

            ShiftController shiftcontroller = new ShiftController();
            ShiftDetail shiftDetail = new ShiftDetail();
            shiftDetail.WorkerID = 1;
            shiftDetail.ShiftType = ShiftType.Shift1;
            shiftDetail.Shiftdate = System.DateTime.Today;

            resp = shiftcontroller.ShiftAssignment(shiftDetail);

            Assert.AreEqual("Shift has been assigned", resp.Message);
        }

        [Test]
        public void ShiftUnitTest2()
        {
            Response resp = new Response();

            ShiftController shiftcontroller = new ShiftController();
            ShiftDetail shiftDetail = new ShiftDetail();
            shiftDetail.WorkerID = 1;
            shiftDetail.ShiftType = ShiftType.Shift1;
            shiftDetail.Shiftdate = System.DateTime.Today;

            resp = shiftcontroller.ShiftAssignment(shiftDetail);

            Assert.AreEqual("Already Assigned for the same day", resp.Message);
        }
    }
}