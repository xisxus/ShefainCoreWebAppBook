using ShefainCoreWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShefainCoreWebApp.DAL
{
    public class PersonDTO
    {
        private readonly AppDbContext _context;

        public PersonDTO(AppDbContext context)
        {
            _context = context;
        }
        public PersonDTO()
        {
            
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public IQueryable<PersonDTO> GetDisplayPersons()
        {
           var pp =  from p in _context.Persons
            where p.FirstName == "shohana"
                     select new PersonDTO
            {
                FirstName = p.FirstName,
                LastName = p.LastName
            };


           
            return pp;
        }

        public IQueryable<Address> GetDisplayPersonsWithAddress()
        {
            var pp = from p in _context.Persons
                     join a in _context.Addresses on p.Id equals a.Id
                     where p.FirstName == "shohana"
                     select a;

            return pp;
        }

        //public IQueryable<Address> GetAddresses()
        //{
        //    var pa = (from p in _context.Persons where p.FirstName == "shohana"
        //             select p.Addresses).SelectMany
        //}


        public Person Gertadd()
        {
            var pp = _context.Persons.OrderByDescending(e=>e.FirstName);
            return (Person)pp;
        }

        //public void SaveMasterDetail()
        //{
        //    using (var context  = new AppDbContext())
        //    {
        //        FirstName = "Monir";
        //        LastName = 

        //    }
        //}

        public void UpdatePerson(int id)
        {
            var peroso = _context.Persons.SingleOrDefault(p=> p.Id == id);
            if (peroso != null)
            {
                peroso.FirstName = "fjd";
                peroso.LastName = "jksfd";
            }
            _context.SaveChanges();
        }

        public int PersonCount()
        {
            int count = _context.Persons.Count();
            return count;
        }

        //public void PersonMinAge()
        //{
        //    var minAge = _context.Persons.Min(c=>c.)
        //}

        public void GetAddressGroupByState()
        {
            var getByAddress = from a in _context.Addresses.ToList()
                               group a by a.City into s
                               select new
                               {
                                   City = s.Key,
                                   Address = s.Select(i => i.Id).ToArray()
                               };
        }
    }
}
