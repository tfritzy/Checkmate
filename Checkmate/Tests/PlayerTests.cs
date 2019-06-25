using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class PlayerTests
    {
        [SetUp]
        public virtual void SetUp()
        {
            //do something
        }

    }

    [TestFixture]
    public class DerivedClass : PlayerTests
    {
        public override void SetUp()
        {
            base.SetUp(); //Call this when you want the parent class's SetUp to run, or omit it all together if you don't want it.
                          //do something else, with no call to base.SetUp()
        }
        //tests run down here.
        [Test]
        public void TestPlayerConstructor()
        {
            Player player = new Player("George");
            Assert.AreEqual("George", player.PlayerName);
            Assert.AreEqual(0, player.xPos);
            Assert.AreEqual(0, player.yPos);
        }

        //[Test]
        //etc
    }

}


