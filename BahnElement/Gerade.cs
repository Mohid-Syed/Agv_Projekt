

public abstract class Gerade : BahnElement
{


  public Gerade(uint ausrichtung) : base(ausrichtung)
  {
    if(ausrichtung >= 2) this.setAusrichtung(0);
    this.setHatVerbindung(this.getAusrichtung() % 4, true);
    this.setHatVerbindung(this.getAusrichtung() - 2 % 4, true);
  }
}