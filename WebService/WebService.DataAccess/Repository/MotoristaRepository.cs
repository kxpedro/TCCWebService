using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Entities;

namespace WebService.DataAccess.Repository
{
    public class MotoristaRepository : IRepository
    {
        public MotoristaPreferencias GetPreferences()
        {
            MotoristaPreferencias preferencias = new MotoristaPreferencias();

            return preferencias;
        }
    }
}
