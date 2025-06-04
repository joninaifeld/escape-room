using Newtonsoft.Json;

public class Sala{
    public bool completada;
    public string fotoBg;
    public string respuesta;
    public string titulo;

    public Sala(string fotoBg, string respuesta, string titulo){
        this.completada = false;
        this.fotoBg = fotoBg;
        this.respuesta = respuesta;
        this.titulo = titulo;
    }
}