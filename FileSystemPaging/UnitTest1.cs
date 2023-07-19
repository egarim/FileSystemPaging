using DevExpress.XtraRichEdit.Model;
using System.Diagnostics;

namespace FileSystemPaging
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DateTime startDate = DateTime.Now;
          
            var Items= FileSystemHelper.ReadFileSystem("D:\\Source");
            DateTime endDate = DateTime.Now;
            double totalSeconds = Tests.GetSecondsBetweenDates(startDate, endDate);
            Debug.WriteLine($"Total seconds between dates: {totalSeconds}");
            Assert.Pass();
        }
        public static double GetSecondsBetweenDates(DateTime startDate, DateTime endDate)
        {
            TimeSpan span = endDate - startDate;
            return span.TotalSeconds;
        }
    }
}