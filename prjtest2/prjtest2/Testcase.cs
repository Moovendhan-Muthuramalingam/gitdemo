using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjtest2
{
    internal class Testcase
    {
        List<EmployeeDetails> li;
        Logic logic = new Logic();
        [Test]
        public void CheckDetails()
        {
            li=logic.AllUsers();
            foreach(var item in li)
            {
                Assert.IsNotNull(item.Id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Gender);
                Assert.IsNotNull(item.Salary);
                Assert.IsNotNull(item.Salary);
                Assert.GreaterOrEqual(Convert.ToInt32(item.Salary),0)
            }
        }
        [Test]
        public void TestLogin()
        {
            string a = logic.Login("kani", "123");
            string b = logic.Login("", "");
            string c = logic.Login("Admin", "Admin");
            string d = logic.Login("ka", "dd");
             
            Assert.AreEqual("Password length should  b3 <3",d)
            Assert.AreEqual("userid and password cannot be null!!", b);
            Assert.AreEqual("Incorrect username or password!!", a);
            Assert.AreEqual("Welcome Admin", c);
        }
    }
}
