using Newtonsoft.Json;

public class Sala{
    public string fotoBg { get; private set; }
    public string respuesta { get; private set; }
    public string titulo { get; private set; }
    public string frase { get; private set; }

    public Sala(string fotoBg, string titulo, string frase, string respuesta){
        this.fotoBg = fotoBg;
        this.respuesta = respuesta;
        this.titulo = titulo;
        this.frase = frase;
    }
    public Sala(string fotoBg, string titulo, string frase){
        this.fotoBg = fotoBg;
        this.titulo = titulo;
        this.frase = frase;
        this.respuesta = "";
    }
    public bool comprobarRespuesta(string input){
        return (respuesta == input);
    }
}