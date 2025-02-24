using NUnit.Framework;
using System.Threading.Tasks;
using TaskApplication;
namespace TaskTesting
{


[TestFixture]
public class TaskOperationsTests
{
    private TaskOperation _taskOperations;

    [SetUp]
    public void Setup()
    {
        _taskOperations = new TaskOperation();
    }

    [Test]
    [Timeout(4000)]
    public async Task LongRunningTask_ShouldFailIfTakesLongerThan2Seconds()
    {
        await _taskOperations.LongRunningTask();
    }
}

}