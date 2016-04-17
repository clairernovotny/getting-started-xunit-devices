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

            // assert
            Assert.Equal(5, result);  
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        [InlineData(2, -5, -3)]
        public void AddWorksForPositiveAndNegative(int a, int b, int result)
        {
            // arrange
            var vm = new MyViewModel();
            // act
            var actual = vm.Add(a, b);
            // assert
            Assert.Equal(result, actual);
        }
    }
}
