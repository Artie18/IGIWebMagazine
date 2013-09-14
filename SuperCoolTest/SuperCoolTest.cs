using System;
using DAL;
using DAL.Implementation;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperCoolTest
{
    [TestClass]
    public class SuperCoolTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IData<User> useReader = new UserReader();
            useReader.Create(new User());
        }
    }
}
