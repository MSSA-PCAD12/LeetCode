using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.AzureStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AzureStorage.Tests
{
    [TestClass()]
    public class BlobStorageTests
    {
        [TestMethod()]
        public void CreateFolderTest()
        {

            new BlobStorage().CreateFolder("vc08272024");

        }

        [TestMethod()]
        public void EnumerateFolderContentTest()
        {
            int actual = new BlobStorage().EnumerateFolderContent("images");
            Assert.AreEqual(10, actual);
        }

        [TestMethod()]
        public void DownloadFolderContentTest()
        {
            var actual = new BlobStorage().DownloadFolderContent("images", 1);
            Assert.AreEqual(actual.Count, 1);
        }
    }
}