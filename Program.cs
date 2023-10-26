// See https://aka.ms/new-console-template for more information
Console.WriteLine("Poderes");
SuperHeroe batman = new SuperHeroe(
    "batman"
    ,"bruno diaz"
    ,"gotham"
    ,false
    ,new Superpoder(
        "inteligencia"
        ,"tactico y estrategico"
        ,10
    )
);

SuperHeroe linterna = new SuperHeroe(
    "linterna verde"
    ,"John stuar"
    ,"galaxia entera"
    ,true
    ,new Superpoder(
        "alien"
        ,"poderozo"
        ,7
    )
);

SuperHeroe ironman = new SuperHeroe(
    "ironman"
    ,"stark"
    ,"new york"
    ,true
    ,new Superpoder(
        "inteligencia"
        ,"tactico y estrategico"
        ,10
    )
);

batman.print();
linterna.print();
ironman.print();

public class SuperHeroe {
    public string? nombre;
    public string? identidadSecreta;
    public string? ciudad;
    public bool? puedeVolar;
    public Superpoder? superPoder;

    public SuperHeroe(string nombre,
                      string identidadSecreta,
                      string ciudad,
                      bool puedeVolar,
                      Superpoder superPoder)
    {
        this.nombre = nombre;
        this.identidadSecreta = identidadSecreta;
        this.ciudad = ciudad;
        this.puedeVolar = puedeVolar;
        this.superPoder = superPoder;
    }
    public void print(){
        Console.WriteLine(@$"
        Nombre:            {nombre}
        identidad secreta: {identidadSecreta}
        ciudad:            {ciudad}
        pudede volar:      {puedeVolar}");
        superPoder.print();
    }
}

public class Superpoder {
    public string? nombre;
    public string? descripcion;
    public int? nivel;

    public Superpoder(string nombre, string descripcion, int nivel){
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.nivel = nivel;
    }

    public void print(){
        Console.WriteLine(@$"          Super Poder: {nombre}
          Descripcion: {descripcion}
          Nivel:       {nivel}
        ***************************");
    }
}