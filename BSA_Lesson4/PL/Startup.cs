﻿using System;
using System.Collections.Generic;
using System.Linq;
using BL.Interfaces;
using Common.DTO;
using BL.Services;
using DAL.Interfaces;
using DAL.Source;
using DAL.Models;
using DAL.UnitOfWork;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace PL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IService<FlightsDTO>, FlightsService>();
            services.AddTransient<IService<TicketsDTO>, TicketsServices>();
            services.AddTransient<IService<StewardessesDTO>, StewardessesService>();
            services.AddTransient<IService<PilotsDTO>, PilotsService>();
            services.AddTransient<IService<AircraftsDTO>, AircraftsService>();
            services.AddTransient<IService<CrewsDTO>, CrewsService>();
            services.AddTransient<IService<AircraftsModelsDTO>, AircraftsModelsService>();
            services.AddTransient<IService<DeparturesDTO>, DeparturesServices>();
            services.AddSingleton<ISource, Source>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddMvc();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AircraftsDTO, Aircrafts>();
                cfg.CreateMap<Aircrafts, AircraftsDTO>();

                cfg.CreateMap<TicketsDTO, Tickets>();
                cfg.CreateMap<Tickets, TicketsDTO>();

                cfg.CreateMap<PilotsDTO, Pilots>();
                cfg.CreateMap<Pilots, PilotsDTO>();

                cfg.CreateMap<StewardessesDTO, Stewardesses>();
                cfg.CreateMap<Stewardesses, StewardessesDTO>();

                cfg.CreateMap<CrewsDTO, Crews>();
                cfg.CreateMap<Crews, CrewsDTO>();

                cfg.CreateMap<AircraftsModelsDTO, AircraftsModels>();
                cfg.CreateMap<AircraftsModels, AircraftsModelsDTO>();

                cfg.CreateMap<DeparturesDTO, Departures>();
                cfg.CreateMap<Departures, DeparturesDTO>();

                cfg.CreateMap<FlightsDTO, Flights>();
                cfg.CreateMap<Flights, FlightsDTO>();

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
