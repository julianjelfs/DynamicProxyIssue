using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.EnterpriseServices;
using Interfaces;
using NUnit.Framework;
using Rhino.Mocks;

namespace DynamicProxyIssue
{
   

    [TestFixture]
    public class Class1
    {
        [TestFixtureSetUp]
        public void BeforeFixture()
        {
            var int1 = MockRepository.GenerateStub<Interface1>();

            ServiceDomain.Enter(new ServiceConfig
            {
                Transaction = TransactionOption.Required,
                TrackingAppName = "Test",
                TransactionDescription = "Test",
                TransactionTimeout = 30
            });

//            var name = typeof (Interface2).Assembly.GetName(true);
//            var a = AppDomain.CurrentDomain.DefineDynamicAssembly(typeof (Interface2).Assembly.GetName(true), 
//                AssemblyBuilderAccess.RunAndSave);
            
            var int2 = MockRepository.GenerateStub<Interface2>();
        }

        [Test]
        public void Test1()
        {
            
        }
    }
}
