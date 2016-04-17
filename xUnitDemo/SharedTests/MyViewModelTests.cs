using System;
using System.Collections.Generic;
using System.Text;
using SomeSharedLogic;
using Xunit;

namespace SharedTests
{
    public class MyViewModelTests
    {
        [Fact]
        public void TestAdd()
        {
            // arrange
            var vm = new MyViewModel();

            // act
            var result = vm.Add(2, 3);

            Assert.Equal(5, result);  
        }
    }
}
