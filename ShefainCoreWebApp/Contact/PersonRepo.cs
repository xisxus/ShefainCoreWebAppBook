using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShefainCoreWebApp.Core.Entities;
using ShefainCoreWebApp.DAL;

namespace ShefainCoreWebApp.Contact
{
    public class PersonRepo : IPerson
    {
        private readonly AppDbContext _db;

        public PersonRepo(AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> AddPerson(Person person)
        {
            var paramter = new List<SqlParameter>();
            paramter.Add(new SqlParameter("@fn", person.FirstName));
            paramter.Add(new SqlParameter("@ln", person.LastName));
            paramter.Add(new SqlParameter("@em", person.EmailAddress));
            paramter.Add(new SqlParameter("@creDate", person.CreatedOn));

            var proc = @"Exec spsavePerson @fn, @ln, @em, @creDate";


            var result = await Task.Run(()=>_db.Database.ExecuteSqlRawAsync(proc)

        }
    }
}
