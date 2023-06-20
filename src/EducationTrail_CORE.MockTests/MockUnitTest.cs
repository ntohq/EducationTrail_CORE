using Xunit.Abstractions;

namespace EducationTrail_CORE.MockTests
{
    /// <summary>
    /// Class <c>UnitTest</c> models a collection suite of xUnit tests used to test the EducationTrail_CORE Services.
    /// </summary>
    public class MockUnitTest
    {
        /// <summary>
        /// Property <c>_output</c> is a service that manages a unit tests output.
        /// </summary>
        ITestOutputHelper _output;

        /// <summary>
        /// This constructor initializes the new <c>UnitTest</c> to
        /// (<paramref name="output"/>)
        /// </summary>
        /// <param name="output"><c>output</c> is a output helper used to manage the output of a unit test.</param>
        public MockUnitTest(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// Method <c>ExampleTest</c> is an example unit test that outputs some text and Asserts that true is true.
        /// </summary>
        [Fact]
        public void ExampleTest()
        {
            _output.WriteLine("Test the output");
            Assert.True(true);
        }
    }
}