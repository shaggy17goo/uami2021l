namespace UnitTests
{
    using System.Threading;
    using Controller;
    using Model;
    using Utilities;
    using Moq;
    using NUnit.Framework;


    public class Tests
    {
        private IData Model { get; set; }
        private IController Controller { get; set; }

        [SetUp]
        public void Setup()
        {
            var mock = new Mock<IEventDispatcher>();
            Controller = ControllerFactory.GetController(mock.Object);
            this.Model = this.Controller.Model;
        }

        [Test]
        public void ModelTest_ModelShouldNotBeNull_NotNull()
        {
            Assert.NotNull(Model);
        }
        
        [Test]
        public void ControllerTest_ModelShouldNotBeNull_NotNull()
        {
            Assert.NotNull(Controller);
        }
        
    }
}