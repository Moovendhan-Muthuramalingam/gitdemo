using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjtest2
{
    public class EmployeeDetails
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double salary { get; set; }  
        public string Gender { get; set; }
    }
    public class Logic
    {
        #region Login
        public string Login (string userid,string password)
        {
            if (string.IsNullOrEmpty(userid)|| string.IsNullOrEmpty(password))
            {
                return "userid or password cant be null!!";
            }
            else
            {
                if(userid=="Admin"&& password =="admin")
                {
                    return "Welcome Admin";
                }
                else
                {
                    return "Incorrect username or password!!";
                }
            }
        }

        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { Id = 101, Name = "Sai", Gender = "Male", Salary = 34000 });
            li.Add(new EmployeeDetails { Id = 102, Name = "Nisha", Gender = "female", Salary = 44000 });
            li.Add(new EmployeeDetails { Id = 103, Name = "anand", Gender = "male", Salary = 49000 });
            li.Add(new EmployeeDetails { Id = 102, Name = "hema", Gender = "female", Salary = 44000 });
            return li;
        }
        #endregion

        public List<EmployeeDetails>GetDetails(int id)
        {
            Logic logic =new Logic();
            var liuser=logic.AllUsers();
            foreach(var x in liuser)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }

    }
    class Emmployeeprj
    {

    }

}
