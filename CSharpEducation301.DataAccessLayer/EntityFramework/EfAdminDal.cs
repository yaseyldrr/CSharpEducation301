﻿using CSharpEducation301.DataAccessLayer.Abstract;
using CSharpEducation301.DataAccessLayer.Repositories;
using CSharpEducation301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
    /*
     * Enitity'ye özgü olmayan methodlar
     * İçinde a harfi geçmeyen kullanıcılıarı listeleyen method: Admine özgü bir method.
     */
}
