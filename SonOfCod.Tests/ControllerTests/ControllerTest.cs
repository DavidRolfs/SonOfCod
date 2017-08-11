using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class MarketingControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
       // [Fact]
     //   public void Get_ModelList_Index_Test()
      //  {
       //     //Arrange
      //      ViewResult indexView = new MarketingController().Index() as ViewResult;

       //     //Act
      //      var result = indexView.ViewData.Model;

      //      //Assert
      //      Assert.IsType<List<Subscriber>>(result);
      //  }
    }
}
