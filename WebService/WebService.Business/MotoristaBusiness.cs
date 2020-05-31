using System;
using System.Collections.Generic;
using System.Text;
using WebService.DataAccess.Repository;
using WebService.Entities;

namespace WebService.Business
{
    public class MotoristaBusiness
    {
        MotoristaRepository motoristaRepository = new MotoristaRepository();
        public MotoristaPreferencias GetPreferencias(string idUser)
        {
            MotoristaPreferencias motoristaPreferencias = motoristaRepository.GetPreferences();
            return motoristaPreferencias;
        }
    }
}
