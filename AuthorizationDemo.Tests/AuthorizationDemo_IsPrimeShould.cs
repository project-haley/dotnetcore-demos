using AuthorizationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AuthorizationDemo.Tests.Services
{
    public class AuthorizationDemo_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var todoItem = new TodoItem();
            bool result = todoItem.IsDone;

            Assert.False(result, "looks like it's not done");
        }
    }
}
