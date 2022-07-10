public class Index{
    private int elementos;
    private string titulo;

    public Index(int elementos, string titulo){
        this.elementos = elementos;
        this.titulo = titulo;
    }

    public int getElementos(){
        return elementos;
    }
    public string getTitulo(){
        return titulo;
    }
    public void setElementos(int elementos){
        this.elementos = elementos;
    }
    public void setTitulo(string titulo){
        this.titulo = titulo;
    }
}