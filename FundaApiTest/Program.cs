using FundaApiTest.WrappingApi;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FundaApiTest
{
    class Program
    {

        private static async Task PopulateProperties(IWrapFundaApi apiAccessor, List<FundaApiTest.WrappingApi.Models.Object> properties, int pageSize, string location, string type, string[] filters)
        {
            var currentPage = await apiAccessor.GetProperties(pageSize, 1, location, type, filters);
            int.TryParse(currentPage.Paging.AantalPaginas, out var totalPages);

            if (currentPage.Objects?.Object?.Any() == true)
            {
                properties.AddRange(currentPage.Objects.Object);
            }

            for (int i = 1; i <= totalPages; i++)
            {
                currentPage = await apiAccessor.GetProperties(pageSize, i, location, type, filters);

                if (currentPage.Objects?.Object?.Any() == true)
                {
                    properties.AddRange(currentPage.Objects.Object);
                }
            }
        }

        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection();
            var startup = new Startup();
            var provider = startup.ConfigureServices(serviceProvider);

            using(var apiAccessor = provider.GetService<IWrapFundaApi>())
            {
                var allProperties = new List<FundaApiTest.WrappingApi.Models.Object>();
                var properTiesWithGarden = new List<FundaApiTest.WrappingApi.Models.Object>();

                try
                {
                    // Api page size limit seems to be 25 - Can set higher however only returns 25 results on page and breaks pagination.
                    await PopulateProperties(apiAccessor, allProperties, 25, "amsterdam", "koop", null);
                }
                catch(Exception e)
                {
                    Log.Logger.Error(e, "Ran into exception when attempting to get all properties");
                }

                try
                {
                    await PopulateProperties(apiAccessor, properTiesWithGarden, 25, "amsterdam", "koop", new string[] { "tuin" });
                    
                }
                catch (Exception e)
                {
                    Log.Logger.Error(e, "Ran into exception when attempting to get properties with gardens");
                }

                var allGroupedByAgent = allProperties.GroupBy(x => x.MakelaarId).OrderByDescending(g => g.Count()).Take(10).ToList();
                var gardensGroupedByAgent = properTiesWithGarden.GroupBy(x => x.MakelaarId).OrderByDescending(g => g.Count()).Take(10).ToList();

                Console.WriteLine("Real Estate ages with most properties: \r\n");

                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{allGroupedByAgent.ElementAtOrDefault(i)?.First().MakelaarNaam} \r\n");
                }

                Console.WriteLine("\r\nReal Estate ages with most properties having gardens: \r\n");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{gardensGroupedByAgent.ElementAtOrDefault(i)?.First().MakelaarNaam} \r\n");
                }

                Console.ReadLine();
            }
        }
    }
}
