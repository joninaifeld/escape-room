using Newtonsoft.Json;

public class Coto{
    public int salasCompletadas;
    public List<Sala> salas;

// faltan rtas:
    public Coto(){
        this.salasCompletadas = 0;
        this.salas = new List<Sala>{
            new Sala("index.webp", "Estás en un Coto!!1!!!1!", "Parece que la idea de quedarse 24hs en el Coto no salió del todo bien"),
            new Sala("almacenamiento.png", "Sala de Almacenamiento", "Pensá fuera de la caja"),
            new Sala("mantenimiento.png", "Sala de Mantenimiento", "Si funciona, no lo toques"),
            new Sala("termica.png", "Caja de Térmica", ".._.__ ._.._", "CLAVES"),
            new Sala("heladeras.jpg", "Área de Heladeras", "Mantené la mente fría", ""),
            new Sala("heladeras-fechas.jpg", "Área de Heladeras", "Mantené la mente fría", "24/11"),
            new Sala("verduleria.jpg", "Verdulería", "Banana"),
            new Sala("caja.png", "Caja Registradora", "Beep beep beep"),
            new Sala("llave.png", "Caja Registradora", "Ka-ching!"),
            new Sala("cajaAbierta.png", "Caja Registradora", "Ka-ching!"),
            new Sala("index.webp", "(Ya no) estás en un Coto!!1!!!1!", "Ahora Coto te conoce")
        };
    }
}