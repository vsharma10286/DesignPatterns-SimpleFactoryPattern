using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {

        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeID==1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if(emp.EmployeeTypeID==2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }

            return returnValue;
        }
    }
}