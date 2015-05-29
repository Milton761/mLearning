using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit.Framework;

namespace mLearningTest
{
    class CrossPlataformTests
    {
        protected IApp app;

        static readonly Func<AppQuery, AppQuery> Button = c => c.Marked("MyButton");


        [TestMethod]
        public void TestCase()
        {
            app.Repl();
        }

    }

    
}
