﻿using O2O.DTO;
using System.Collections.Generic;
using System.Linq;

namespace O2O.IService
{
    public interface IUserService : IServiceSupport
    {
        List<UserDTO> GetAll();

        //UserDTO 
    }
}
