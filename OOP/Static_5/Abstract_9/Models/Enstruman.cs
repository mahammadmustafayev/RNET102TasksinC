using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_9.Models;

public abstract class Enstruman
{
    public Enstruman(){ this.Id=Guid.NewGuid(); }
    public Guid Id { get; set; }
    
    public string? Brand { get; set; }
    public int MyProperty {  get; set; }
    public string? Model { get; set; }
    public decimal? Price { get; set; }
    //public virtual  string Sound() => "Default Enstruman Sesi";

    public abstract string Sound();
    public abstract string Test();
}
public class Piano:Enstruman
{
    public string? Length { get; set; }

    public override string Sound() => $"{this.GetType().Name} sesi";

    public override string Test() => "Test oldu";
    

    //public override string Sound() => "Piano sesi";

}
public class Keman : Enstruman
{
    public string? Arse { get; set; }

    public override string Sound() => $"{this.GetType().Name} sesi";

    public override string Test() => "Test oldu";


    //public override string Sound() => "Keman sesi";
}
public class Gitar : Enstruman
{
    public string? MagneticArray { get; set; }

    public override string Sound()=> $"{this.GetType().Name} sesi";

    //public override string Sound() => "Gitar sesi";
    public override string Test() => "Test oldu";
}
public class YanFlut : Enstruman
{
    public string? Material { get; set; }
    public override string Test() => "Test oldu";

    public override string Sound() => $"{this.GetType().Name} sesi";
    
    //public override string Sound() => "Fulut sesi";
}
public class Muzisyen
{
    public Muzisyen(){this.Id = Guid.NewGuid();}
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Enstruman Enstruman { get; set; }
}