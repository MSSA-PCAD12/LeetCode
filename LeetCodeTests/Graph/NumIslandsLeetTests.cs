using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.Tests;


[TestClass]
public class NumIslandsLeetTests
{
    [TestMethod]
    public void TestNumIslands_SingleIsland()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' },
                new char[] { '0', '0', '0', '1', '1' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestNumIslands_MultipleIslands()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '1', '0', '0', '1', '0' },
                new char[] { '0', '1', '0', '0', '1' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '1', '0', '0', '1', '0' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void TestNumIslands_NoIslands()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestNumIslands_AllLand()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestNumIslands_SingleCellIsland()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void TestNumIslands_Island()
    {
        // Arrange
        var numIslandsLeet = new NumIslandsLeet();
        char[][] grid = new char[][]
        {
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '0', '1', '0', '0', '0' },
                new char[] { '0', '1', '0', '0', '0' },
                new char[] { '1', '1', '1', '1', '1' }
        };

        // Act
        int result = numIslandsLeet.NumIslands(grid);

        // Assert
        Assert.AreEqual(1, result);
    }
}

