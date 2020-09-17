using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UsersChallenge.Models;
using UsersChallengeAPI.Services;

namespace UsersChallengeAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GenerateDummyData();
        }

        private static void GenerateDummyData()
        {
            Random random = new Random();

            UsersService service = new UsersService();

            User testUser1 = new User
            {
                Name = "Test user " + random.Next(99),
                Age = random.Next(),
                Address = Guid.NewGuid().ToString().Substring(0, 30)
            };

            User testUser2 = new User
            {
                Name = "Test user " + random.Next(99),
                Age = random.Next(),
                Address = Guid.NewGuid().ToString().Substring(0, 30)
            };

            service.CreateUser(testUser1);
            service.CreateUser(testUser2);
        }
    }
}
