﻿using SchoolBus_DataAccess.Repositories.Abstract;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Repositories.Concrete;

public class AdminRepository : GenericRepository<Admin>, IAdminRepository
{
}