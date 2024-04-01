﻿using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Branch : BaseEntity
    {
        //Many to one relationship with Department
       
       public Department? Department { get; set; }
         public int DepartmentId { get; set; }
        //Many to one relationship with Employee
        [JsonIgnore]
        public List<Employee>?  Employees { get; set; }
    }
}
