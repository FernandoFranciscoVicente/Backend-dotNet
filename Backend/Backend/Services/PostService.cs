using   Backend.DTOs;
using System.Text.Json;
namespace Backend.Services
{
    //En esta clase implementamos la interfaz IPostService
    public class PostService : IPostService
    {
        //Creamos una entidad privada de tipo HttpClient
        //Nos permitirá conectar con una API externa
        private HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            //Inicializamos el HttpClient
            _httpClient = httpClient;
        }

        //Método tipo async que implementa la interfaz IPostService
        //El método asíncrono no se puede usar en la interfaz directamente
        public async Task<IEnumerable<PostDto>> Get()
        {
            var result = await _httpClient.GetAsync(_httpClient.BaseAddress);
            var body = await result.Content.ReadAsStringAsync();

            //Función para no distinguir entre mayúsculas y minúsculas
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            //Leer los post
            //Deserializar el JSON a una lista de PostDto
            var post = JsonSerializer.Deserialize<IEnumerable<PostDto>>(body, options);
            return post;
        }
    }

}
