﻿using Data;
using Services;
using Services.Common;
using Services.CustomModels;
using Services.Implementations;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // NumberGenerator.EmployeeNumberGenerator();
            //UserRolesManager um = new UserRolesManager(new StoreDbContext());
            //um.Add(new UserRolesModel() { AddRoleIds = new System.Collections.Generic.List<int>() { 6, 7 }, UserId = 1 });
            //um.GetAll(1);
            RoleManager rm = new RoleManager(new StoreDbContext());
            var all=rm.GetAll();
           
        }
      
    }
}
