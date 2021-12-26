using RegistrationWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistrationWebApi.Model.SP;



namespace RegistrationWebApi.Data
{
    public class RegistrationDataRepo
    {
        private readonly RegistrationContext _context;

        public RegistrationDataRepo(RegistrationContext context)
        {
            _context = context;
        }
        public Regisdata Upsertregistration(Registradata dataa)
        {
            var data = _context.Set<Regisdata>().FromSqlInterpolated($"Regisdata null,{ dataa.UserName},{ dataa.Email},{ dataa.FullName},{ dataa.Password}").AsNoTracking().ToList().FirstOrDefault();

            //Validate(data);
            return data;
        }
    }
}
