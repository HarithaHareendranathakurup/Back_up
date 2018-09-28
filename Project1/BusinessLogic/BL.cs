using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity1;
using DataAccess;
namespace BusinessLogic
{
    public class BL
    {
        public void save(Student1 s)
        {
            DA da = new DA();
            da.AddDetails(Student1 s);
            

        }
    }
}
