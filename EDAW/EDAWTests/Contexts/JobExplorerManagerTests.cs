using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using EDAW.Data;

namespace EDAW.Contexts.Tests
{
    [TestClass()]
    public class JobExplorerManagerTests
    {
        [TestMethod()]
        public void FindTest()
        {
            IEnumerable<JobExplorer> jeList = JobExplorerManager.Find(x => x.gender == JobExplorer.Gender.Male);

            Assert.AreEqual(jeList.First().gender, JobExplorer.Gender.Male);
        }

        [TestMethod()]
        public void AddTest()
        {
            JobExplorer newExplorer = new JobExplorer();

            JobExplorerManager.Add(newExplorer);

            // Remove the inserted dummy job explorer
            JobExplorerManager.Delete(newExplorer);

            // After a JobExplorer is successfully added to the DB, the ObjectId is filled with a value by mongoDB automatically
            Assert.IsTrue(newExplorer.id != null);
        }

        [TestMethod()]
        public void AddTest1()
        {
            JobExplorer explorer1 = new JobExplorer();
            JobExplorer explorer2 = new JobExplorer();

            List<JobExplorer> jeList = new List<JobExplorer>();

            jeList.Add(explorer1);
            jeList.Add(explorer2);

            JobExplorerManager.Add(jeList as IEnumerable<JobExplorer>);

            JobExplorerManager.Delete(explorer1);

            JobExplorerManager.Delete(explorer2);

            Assert.IsTrue( (explorer1.id != null) && (explorer2.id != null) );
        }

        [TestMethod()]
        public void DeleteTest()
        {
            JobExplorer explorer = new JobExplorer();

            JobExplorerManager.Add(explorer);

            JobExplorerManager.Delete(explorer);

            int count = JobExplorerManager.Find(x => x.id == explorer.id).Count();

            Assert.IsTrue(count == 0);
        }
    }
}