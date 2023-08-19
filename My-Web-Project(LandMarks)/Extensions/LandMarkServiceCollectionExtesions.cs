﻿using MyWebProject.Core.Services.IServices;
using MyWebProject.Core.Services.Services;
using MyWebProject.Infrastructure.Data.Common;
using System.ComponentModel;

namespace My_Web_Project_LandMarks_.Extensions
{
   
    public static class LandMarkServiceCollectionExtesions
    {
        /// <summary>
        /// The method contains the registration of all servers in an inversion control container
        /// </summary>
        /// <param name="services"></param>
        /// <returns>service</returns>
        public static IServiceCollection AddApplicationServiceApp(this IServiceCollection services) 
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IHomeService, HomeServices>();
            services.AddScoped<ICultureEventService, CultureEventService>();
            services.AddScoped<ITownService, TownService>();
            services.AddScoped<ILandmarkService, LandMarkService>();
            services.AddScoped<ITop10Destination, Top10Destination>();
            services.AddScoped<IMysteryPlace, MysteryPlace>();
            services.AddScoped<IJourneyServise, JourneyService>();
            services.AddScoped<IFactsService, FactsService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IPictureService, PictureService>();

            return services;
        }
    }
}
