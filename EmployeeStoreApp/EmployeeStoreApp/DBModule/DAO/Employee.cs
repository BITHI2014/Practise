namespace EmployeeStoreApp.DBModule.DAO
{
    class Employee
    {
        public int Serial { get; set; }
        public string Name { get;  set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Designation Designation { get; set; }
    }
}
