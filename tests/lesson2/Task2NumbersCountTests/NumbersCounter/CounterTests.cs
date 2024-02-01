﻿using Task2NumbersCount.NumbersCounter;

namespace Task2NumbersCountTests.NumbersCounter;

public class CounterTests
{
    [Fact]
    public void TestData()
    {
        IDataCounter counter = Counter.Create(100);

        Assert.Equal(100, counter.Number);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(100, 3)]
    public void TestGetCount(int number, int expected)
    {
        ICountCounter counter = Counter.Create(number);

        var actual = counter.GetCount();

        Assert.Equal(expected, actual);
    }
}