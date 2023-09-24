using CaploitteAPI.Repository;

namespace CaploitteAPI.Model.DataHandler
{
    public class EmployeeSalaryHandler : IDataHandlerRepository<EmployeeSalaryDetails>
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeSalaryHandler(EmployeeContext context)
        {
            this._employeeContext = context;
        }
        public int Add(EmployeeSalaryDetails entity)
        {
            using var transaction = _employeeContext.Database.BeginTransaction();
            try
            {
                _employeeContext.Add(entity);
                _employeeContext.SaveChanges();
                transaction.Commit();
                return entity.EmpSalaryId;

            }catch (Exception ex) { return 0; }
        }

        public int Delete(EmployeeSalaryDetails entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeSalaryDetails>> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeSalaryDetails GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(EmployeeSalaryDetails targetEntity, EmployeeSalaryDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
