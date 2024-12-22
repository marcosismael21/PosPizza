using System.Text;
using Newtonsoft.Json;
using PosPizza.Models;

namespace PosPizza.Controllers
{
    public class AuthService
    {
        private readonly string _baseUrl = "http://localhost:5070/api";
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }

        public async Task<LoginResponse> Login(string usuario, string clave)
        {
            try
            {
                var loginData = new
                {
                    Usuario = usuario,
                    Clave = clave
                };

                var json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("/api/Auth/login", content);
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LoginResponse>(jsonResponse);
                }

                throw new Exception(jsonResponse);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al iniciar sesión: {ex.Message}");
            }
        }

        public async Task<bool> CrearColaborador(Colaborador colaborador)
        {
            try
            {
                var json = JsonConvert.SerializeObject(colaborador);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("/api/Colaborador", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear colaborador: {ex.Message}");
            }
        }

        public async Task<List<Colaborador>> ObtenerColaboradores()
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/Colaborador");
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<ApiResponse<List<Colaborador>>>(jsonResponse);
                    return result.Response;
                }

                throw new Exception(jsonResponse);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener colaboradores: {ex.Message}");
            }
        }

        public async Task<bool> EliminarColaborador(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"/api/Colaborador/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar colaborador: {ex.Message}");
            }
        }

        public async Task<bool> ActualizarColaborador(Colaborador colaborador)
        {
            try
            {
                var json = JsonConvert.SerializeObject(colaborador);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"/api/Colaborador/{colaborador.Id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar colaborador: {ex.Message}");
            }
        }
    }

    public class ApiResponse<T>
    {
        public string Message { get; set; }
        public T Response { get; set; }
    }
}