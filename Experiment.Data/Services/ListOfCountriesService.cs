using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.Data.Services
{
    public class ListOfCountriesService
    {
        public async Task<IEnumerable<string>> GetAllAsync()
        {
            await Task.Delay(0);
            return Experiment.Data.Data.Country.List.OrderBy(m => m.Name).Select(m => m.Name);
        }
    }
}