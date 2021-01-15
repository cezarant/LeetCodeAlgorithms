using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests
{    
    [TestClass]
    public class pascalTriangleUT
    {        
        [TestMethod]
        public void doIt()
        {
            var expectedTriangle = new List<IList<int>>();
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,2,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,3,3,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,4,6,4,1", expectedTriangle);
            IList<IList<int>> lstResult = pascalTriangleProblem.implementation(5);            
            lstResult.Should().BeEquivalentTo(expectedTriangle);

            expectedTriangle.Clear();
            lstResult.Clear();

            expectedTriangle = (List<IList<int>>)createNodeTriangle("1",expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,2,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,3,3,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,4,6,4,1", expectedTriangle);
            expectedTriangle = (List<IList<int>>)createNodeTriangle("1,5,10,10,5,1", expectedTriangle);
            
            lstResult = pascalTriangleProblem.implementation(6);
            lstResult.Should().BeEquivalentTo(expectedTriangle); 
        }
        private IList<IList<int>> createNodeTriangle(string sNode, List<IList<int>> lstTriangle)
        {
            lstTriangle.Add(new List<int>());
            for (int i = 0; i < sNode.Split(',').Length; i++)
            {                
                lstTriangle[lstTriangle.Count - 1].Add(int.Parse(sNode.Split(',')[i]));
            }
            return lstTriangle; 
        }
    }
}
