namespace _002_Singleton.Tests
{
    public class SingletonPatternTests
    {
        [Fact]
        public void GetInstance_CreateInstanceTwice_AreEqual()
        {
            //Arrange, Act
            var firstAttemptInstance = ChocolateBoiler.GetInstance();
            var secondAttemptInstance = ChocolateBoiler.GetInstance();

            Assert.Equal(firstAttemptInstance, secondAttemptInstance);
        }
    }
}