using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}