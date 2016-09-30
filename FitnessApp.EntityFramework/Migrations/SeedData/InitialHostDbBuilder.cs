﻿using FitnessApp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace FitnessApp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FitnessAppDbContext _context;

        public InitialHostDbBuilder(FitnessAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
