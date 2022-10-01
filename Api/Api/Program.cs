using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class Program
    {
        static void Main(string[] args)
        {
            api();
            Console.ReadKey();
        }
        static async void api()
        {

            var httpCliente = new HttpClient();
            var respuesta = await httpCliente.GetAsync("https://rickandmortyapi.com/api/character");

            if (respuesta.IsSuccessStatusCode)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();

                Root Descerializacion = JsonConvert.DeserializeObject<Root>(contenido);

                Console.WriteLine("");

                foreach (var item in Descerializacion.results)
                {
                    Console.WriteLine(item.name);
                }
                Console.WriteLine("");

            }
        }

    }
}
