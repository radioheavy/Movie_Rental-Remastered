using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Enums
{
    public enum UserRole
    {
        // Standart userRole Enum class
        Admin = 1,
        Member = 2,
        Visitor = 3,

        // Müşteri İsteğine bağlı olarak, sitenin/programın hangi kısmına hangi departmanın müdahil olabileceğinin düzenlenmesi.
        Ceo = 4, 
        Purchasing_department = 5,
        Movie_Data_department = 6,
        Accounting_department = 7,
        Warehouse_Department = 8



    }
}
