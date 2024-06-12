using SimpleApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Tests
{
    public class ControllerReturnTest1
    {
        [Fact]
        public void ValuesController_Get_returns_correctName_when_id_is_provided()
        {
            var controller = new ValuesController();
            var controllerReturn = controller.Get(1).Value;
            Assert.NotNull(controllerReturn);
            Assert.Equal("Isaac Mwesigwa", controllerReturn);
        }
    }
}
