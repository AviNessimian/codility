using CheckPoint;
using FluentAssertions;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Task1_Tests()
    {
        var task = new Task1();
        var s1 = task.Linear([5, 11, 1, 3], [6, 1, 3, 2], 7);
        s1.Should().Be(2);

        var s2 = task.Linear([10, 15, 1], [10, 1, 2], 3);
        s2.Should().Be(1);

        var s3 = task.Linear([11, 18, 1], [9, 18, 8], 7);
        s3.Should().Be(0);

        var s4 = task.Linear([1, 4, 2, 5], [4, 9, 2, 3], 19);
        s4.Should().Be(4);
    }

    [Fact]
    public void Task2_Tests()
    {
        var task = new Task2();
        var s1 = task.LogLinear([1, 1, 1, 1, 1]);
        s1.Should().Be(5);

        var s2 = task.LogLinear([2, 1, 4]);
        s2.Should().Be(2);

        var s3 = task.LogLinear([2, 7, 2, 9, 8]);
        s3.Should().Be(2);

        var s4 = task.LogLinear([7, 3, 1, 1, 4, 5, 4, 9]);
        s4.Should().Be(4);
    }

    [Fact]
    public void Task3_Tests()
    {
        var task = new Task3();
        int s1 = task.Linear([4, 1, 2, 3]);
        s1.Should().Be(6);

        var s2 = task.Linear([1, 2, 3, 3, 2, 1, 5]);
        s2.Should().Be(7);

        var s3 = task.Linear([1000000000, 1, 2, 2, 1000000000, 1, 1000000000]);
        s3.Should().Be(999999998);
    }
}