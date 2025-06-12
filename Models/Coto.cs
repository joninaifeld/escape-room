using Newtonsoft.Json;

public class Coto{
    public int salasCompletadas;
    public List<Sala> salas;

// faltan rtas:

//  [JsonConstructor]
    public Coto(){
        this.salasCompletadas = 0;
        this.salas = new List<Sala>{
            new Sala("index.webp", "Estás en un Coto!!1!!!1!", "Parece que la idea de quedarse 24hs en el Coto no salió del todo bien", "Index", ""),
            new Sala("almacenamiento.png", "Sala de Almacenamiento", "Pensá fuera de la caja", "Almacenamiento", ""),
            new Sala("mantenimiento.png", "Sala de Mantenimiento", "Si funciona, no lo toques", "Mantenimiento", ""),
            new Sala("termica.png", "Caja de Térmica", ".._.__ ._.._", "Termica", "CLAVES"),
            new Sala("heladeras.jpg", "Área de Heladeras", "Mantené la mente fría", "Heladeras",""),
            new Sala("heladeras-fechas.jpg", "Área de Heladeras", "Mantené la mente fría", "HeladerasFecha","24/11"),
            new Sala("verduleria.jpg", "Verdulería", "Banana", "Verduleria", "20"),
            new Sala("caja.png", "Caja Registradora", "Beep beep beep", "Caja", "2597"),
            new Sala("llave.png", "Caja Registradora", "Ka-ching!", "Llave", ""),
            new Sala("cajaAbierta.png", "Caja Registradora", "Ka-ching!", "CajaAbierta", ""),
            new Sala("index.webp", "(Ya no) estás en un Coto!!1!!!1!", "Ahora Coto te conoce", "Escape", "")
        };
    }
}